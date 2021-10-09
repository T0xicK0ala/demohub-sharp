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
    [DisallowConcurrentExecution]
    public class ProcessMessagesJob : IJob
    {
        private readonly ILogger<ProcessMessagesJob> _logger;
        private readonly IConfiguration _configuration;
        private DemoHubDBContext _dbcontext;

        public ProcessMessagesJob(
            ILogger<ProcessMessagesJob> logger,
            IConfiguration configuration,
            DemoHubDBContext dbcontext)
        {
            _logger = logger;
            _configuration = configuration;
            _dbcontext = dbcontext;
        }

        public Task Execute(IJobExecutionContext context)
        {
            Task.WaitAll();
            var sw = Stopwatch.StartNew();
            try
            {
                string clientId = _configuration.GetSection("TAURUSBearerToken:ClientID").Value;
                string clientSecret = _configuration.GetSection("TAURUSBearerToken:ClientSecret").Value;
                string uri = _configuration.GetSection("TAURUSBearerToken:Uri").Value;
                string audience = _configuration.GetSection("TAURUSBearerToken:Audience").Value;
                string apiuri = _configuration.GetSection("TAURUSAPI:Uri").Value;

                var service = new TAURUSCommunicationService(clientId, clientSecret, uri, audience, apiuri);
                string token = service.GetToken();
                var requests = _dbcontext.TblDCalastoneTransactionRequest
                       .Where(r => r.FkTransactionRequestStatus == (int)CalastoneEnums.TransactionStatus.SentToRegistry
                            && (r.FkTransactionType == (int)CalastoneEnums.TransactionType.Subscription
                                || r.FkTransactionType == (int)CalastoneEnums.TransactionType.Redemption))
                       .Take(Gear.MULTI_THREAD_NUMBER)
                       .ToList();

                ParallelOptions opt = new ParallelOptions
                {
                    MaxDegreeOfParallelism = Gear.MULTI_THREAD_NUMBER // same thread number as Quartz jobs 
                    //Process.GetCurrentProcess().Threads.Count
                };

                var transactions = new List<TblDTransaction>();
                if (requests.Count > 0)
                {
                    ParallelLoopResult processTransactionsParallel = Parallel.ForEach(requests, opt, request =>
                    {
                        int requestId = request.KTransactionRequest;
                        Interlocked.Increment(ref requestId);
                        //string newTransactionNumber = BusinessLogicHelper.ProcessTransaction(apiuri, token, request);

                        if (!string.IsNullOrEmpty(request.SRegTransactionNumber))
                        {
                            TblDTransaction transaction = BusinessLogicHelper.AppendTransaction(apiuri, token, request.SRegTransactionNumber, request);
                            if (transaction != null)
                            {
                                transactions.Add(transaction);
                                request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.ReadyToBeConfirmed;
                            }
                            else
                            {
                                request.SAdditionalRejectedReason = Gear.REJECT_REASON_PROCESS;
                                request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                            }
                        }
                    });
                    if (processTransactionsParallel.IsCompleted)
                    {
                        _dbcontext.TblDCalastoneTransactionRequest.UpdateRange(requests);
                        _dbcontext.TblDTransaction.AddRange(transactions);
                        _dbcontext.SaveChanges();
                    }
                }

                #region Send business reject
                var rejrequests = _dbcontext.TblDCalastoneTransactionRequest
                   .Where(r => r.FkTransactionRequestStatus == (int)CalastoneEnums.TransactionStatus.BusinessRejected
                        //&& r.FkTransactionRequestResource == 2
                        )
                   .ToList();
                if (rejrequests.Count > 0)
                {
                    string result = MessageHelper.SendStatusReportV04(rejrequests, "BusinessReject");
                    _logger.LogInformation(result);
                }
                #endregion
                #region Send in repair
                var inrepairRequests = _dbcontext.TblDCalastoneTransactionRequest
                   .Where(r => r.FkTransactionRequestStatus == (int)CalastoneEnums.TransactionStatus.InRepair
                        //&& r.FkTransactionRequestResource == 2
                        )
                   .ToList();
                if (inrepairRequests.Count > 0)
                {
                    string result = MessageHelper.SendStatusReportV04(inrepairRequests, "InRepair");
                    _logger.LogInformation(result);
                }
                #endregion
            }
            catch (Exception ex)
            {
                _logger.LogError("Error while processing messages");
                _logger.LogError(ex.Message);
            }
            _logger.LogInformation($"Processing time: {sw.Elapsed}");
            return Task.CompletedTask;
        }
    }
}