using System;
using Quartz;
using System.Linq;
using DemoHub.Common;
using System.Threading;
using System.Diagnostics;
using DemoHub.Common.Enums;
using System.Threading.Tasks;
using DemoHub.Persistence.Models;
using DemoHub.WebServices.Helpers;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using DemoHub.Infrastructure.TAURUS;
using Microsoft.Extensions.Configuration;

namespace DemoHub.WebServices.Scheduler.Jobs
{
    public class ProcessSwitchJob : IJob
    {
        private readonly ILogger<ProcessSwitchJob> _logger;
        private readonly IConfiguration _configuration;
        private readonly DemoHubDBContext _dbcontext;

        public ProcessSwitchJob(
            ILogger<ProcessSwitchJob> logger,
            IConfiguration configuration,
            DemoHubDBContext dbcontext)
        {
            _logger = logger;
            _configuration = configuration;
            _dbcontext = dbcontext;
        }

        public Task Execute(IJobExecutionContext context)
        {
            var sw = Stopwatch.StartNew();
            try
            {
                var clientID = _configuration.GetSection("TAURUSBearerToken:ClientID").Value;
                var clientSecret = _configuration.GetSection("TAURUSBearerToken:ClientSecret").Value;
                var uri = _configuration.GetSection("TAURUSBearerToken:Uri").Value;
                var audience = _configuration.GetSection("CTAURUSBearerToken:Audience").Value;
                string apiuri = _configuration.GetSection("TAURUSAPI:Uri").Value;

                var service = new TAURUSCommunicationService(clientID, clientSecret, uri, audience, apiuri);
                string token = service.GetToken();

                var outrequests = _dbcontext.TblDCalastoneTransactionRequest
                    .Where(r => r.FkTransactionRequestStatus == (int)CalastoneEnums.TransactionStatus.Validated
                        && r.FkTransactionType == (int)CalastoneEnums.TransactionType.SwitchRedemption)
                    .ToList();

                var inrequests = _dbcontext.TblDCalastoneTransactionRequest
                    .Where(r => r.FkTransactionRequestStatus == (int)CalastoneEnums.TransactionStatus.Validated
                        && r.FkTransactionType == (int)CalastoneEnums.TransactionType.SwitchSubscription)
                    .ToList();

                var transactions = new List<TblDTransaction>();
                if (outrequests.Count != 0 && inrequests.Count != 0) // check null
                {
                    if (outrequests.Count == inrequests.Count) // check switch order is coming in a pair
                    {
                        ParallelOptions opt = new ParallelOptions
                        {
                            MaxDegreeOfParallelism = Gear.MULTI_THREAD_NUMBER // same thread number as Quartz jobs 
                            //Process.GetCurrentProcess().Threads.Count
                        };

                        ParallelLoopResult sendToRegistryParallel = Parallel.ForEach(outrequests, opt, outrequest =>
                        {
                            int requestId = outrequest.KTransactionRequest;
                            Interlocked.Increment(ref requestId);
                            var inrequest = inrequests.Find(i => i.SOrderReference == outrequest.SOrderReference);

                            //// check account number - if different then business reject
                            string transactionNumber = BusinessLogicHelper.SendSwitchRequest(apiuri, token, outrequest, inrequest);
                            bool isUnitised = BusinessLogicHelper.ProcessSwitch(apiuri, token, outrequest, inrequest,
                                out string newOutTransactionNumber, out string newInTransactionNumber);

                            if (isUnitised)
                            {
                                TblDTransaction otransaction = BusinessLogicHelper.AppendTransaction(apiuri, token, newOutTransactionNumber, outrequest);
                                TblDTransaction itransaction = BusinessLogicHelper.AppendTransaction(apiuri, token, newInTransactionNumber, inrequest);
                                if (otransaction != null && itransaction != null)
                                {
                                    transactions.Add(otransaction);
                                    transactions.Add(itransaction);
                                    outrequest.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.ReadyToBeConfirmed;
                                    inrequest.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.ReadyToBeConfirmed;
                                }
                                else
                                {
                                    outrequest.SAdditionalRejectedReason = Gear.REJECT_REASON_PROCESS;
                                    outrequest.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                                    inrequest.SAdditionalRejectedReason = Gear.REJECT_REASON_PROCESS;
                                    inrequest.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                                }
                            }
                        });
                    }
                    else
                    {
                        outrequests.ForEach(o => o.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.InRepair);
                        inrequests.ForEach(o => o.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.InRepair);
                    }
                    _dbcontext.TblDCalastoneTransactionRequest.UpdateRange(outrequests);
                    _dbcontext.TblDCalastoneTransactionRequest.UpdateRange(inrequests);
                    _dbcontext.TblDTransaction.AddRange(transactions);
                    _dbcontext.SaveChanges();
                }

                #region Send business reject
                var rejrequests = _dbcontext.TblDCalastoneTransactionRequest
                   .Where(r => r.FkTransactionRequestStatus == (int)CalastoneEnums.TransactionStatus.BusinessRejected).ToList();
                if (rejrequests.Count > 0)
                {
                    string result = MessageHelper.SendStatusReportV04(rejrequests, "BusinessReject");
                    _logger.LogInformation(result);
                }
                #endregion
            }
            catch (Exception ex)
            {
                _logger.LogError("Error while processing messages");
                _logger.LogError(ex.Message);
            }
            _logger.LogInformation($"Spent time: {sw.Elapsed}");
            return Task.CompletedTask;
        }
    }
}