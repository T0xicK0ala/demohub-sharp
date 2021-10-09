using System;
using System.Linq;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Quartz;
using DemoHub.Common;
using DemoHub.Persistence.Models;
using DemoHub.WebServices.Helpers;
using DemoHub.Infrastructure.TAURUS;
using System.Collections.Generic;
using DemoHub.Common.Enums;

namespace DemoHub.WebServices.Scheduler.Jobs
{
    [DisallowConcurrentExecution]
    public class SendToRegistryJob : IJob
    {
        private readonly ILogger<SendToRegistryJob> _logger;
        private readonly IConfiguration _configuration;
        private readonly DemoHubDBContext _dbcontext;

        public SendToRegistryJob(
            ILogger<SendToRegistryJob> logger,
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
                       .Where(r => r.FkTransactionRequestStatus == (int)CalastoneEnums.TransactionStatus.Validated
                            && (r.FkTransactionType == (int)CalastoneEnums.TransactionType.Subscription
                                || r.FkTransactionType == (int)CalastoneEnums.TransactionType.Redemption))
                       .ToList();

                ParallelOptions opt = new ParallelOptions
                {
                    MaxDegreeOfParallelism = Gear.MULTI_THREAD_NUMBER // same thread number as Quartz jobs 
                    //Process.GetCurrentProcess().Threads.Count
                };

                if (requests.Count > 0)
                {
                    ParallelLoopResult sendToRegistryParallel = Parallel.ForEach(requests, opt, request =>
                    {
                        try
                        {
                            int requestId = request.KTransactionRequest;
                            Interlocked.Increment(ref requestId);
                            BusinessLogicHelper.SendToRegistry(apiuri, token, request);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError($"Error occurs when sending transaction to TAURUS.");
                            _logger.LogError(ex.Message);
                            _logger.LogError(ex.InnerException.Message);
                            throw ex ?? ex.InnerException;
                        }
                    });
                    if (sendToRegistryParallel.IsCompleted)
                    {
                        _dbcontext.TblDCalastoneTransactionRequest.UpdateRange(requests);
                        _dbcontext.SaveChanges();
                    }
                }
                else
                {
                    _logger.LogError($"No entries to be processed.");
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
            }
            catch (Exception ex)
            {
                _logger.LogError("Error while sending messages to TAURUS.");
                _logger.LogError(ex.Message);
            }
            _logger.LogInformation($"Processing time: {sw.Elapsed}");
            return Task.CompletedTask;
        }
    }
}