using System;
using Quartz;
using System.Linq;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using DemoHub.Persistence.Models;
using DemoHub.WebServices.Helpers;
using Microsoft.Extensions.Logging;
using DemoHub.Infrastructure.TAURUS;
using Microsoft.Extensions.Configuration;
using DemoHub.Common.Enums;
using DemoHub.Common;

namespace DemoHub.WebServices.Scheduler.Jobs
{
    [DisallowConcurrentExecution]
    public class ValidateMessagesJob : IJob
    {
        private readonly ILogger<ValidateMessagesJob> _logger;
        private readonly IConfiguration _configuration;
        private readonly DemoHubDBContext _dbcontext;

        public ValidateMessagesJob(
            ILogger<ValidateMessagesJob> logger,
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
            try
            {
                var clientID = _configuration.GetSection("TAURUSBearerToken:ClientID").Value;
                var clientSecret = _configuration.GetSection("TAURUSBearerToken:ClientSecret").Value;
                var uri = _configuration.GetSection("TAURUSBearerToken:Uri").Value;
                var audience = _configuration.GetSection("CTAURUSBearerToken:Audience").Value;
                string apiuri = _configuration.GetSection("TAURUSAPI:Uri").Value;

                var service = new TAURUSCommunicationService(clientID, clientSecret, uri, audience, apiuri);
                string token = service.GetToken();

                var requests = _dbcontext.TblDCalastoneTransactionRequest
                    .Where(r => r.FkTransactionRequestStatus == (int)CalastoneEnums.TransactionStatus.Received)
                    .Take(Gear.MULTI_THREAD_NUMBER).ToList();

                if (requests.Count > 0)
                {
                    #region Send business receive
                    //var receivedReq = requests.Where(r => r.FkTransactionRequestResource == 2).ToList();
                    var receivedReq = requests.ToList();
                    if (receivedReq.Count > 0)
                    {
                        string messageresult = MessageHelper.SendStatusReportV04(receivedReq, "Received");
                        _logger.LogInformation(messageresult);
                    }
                    #endregion

                    ParallelOptions opt = new ParallelOptions
                    {
                        MaxDegreeOfParallelism = Gear.MULTI_THREAD_NUMBER // same thread number as Quartz jobs
                        // Process.GetCurrentProcess().Threads.Count
                    };

                    ParallelLoopResult parallelLoopResult = Parallel.ForEach(requests, opt, request =>
                    {
                        int requestId = request.KTransactionRequest;
                        Interlocked.Increment(ref requestId);
                        //if(request.FkTransactionRequestResource == 3)
                        //{
                        //    bool IsValidated = Validator.ValidateChess(apiuri, token, request);
                        //    if (IsValidated)
                        //    {
                        //        request.FkTransactionRequestStatus = 8;
                        //    }
                        //    else
                        //    {
                        //        request.FkTransactionRequestStatus = 5;
                        //    }
                        //}
                        //else
                        //{
                        //    Validator.Validate(apiuri, token, request);
                        //}

                    });

                    if (parallelLoopResult.IsCompleted)
                    {
                        //var requests3 = requests.FindAll(r => r.FkTransactionType == 3 && r.FkTransactionRequestStatus == 5);
                        //var requests4_tobemodify = requests.Where()
                        //requests.FindAll(r => r.FkTransactionType == 4)
                        //    .Where(r => r.FkTransactionType == 3 && r.FkTransactionRequestStatus == 5)
                        //    .ForEach(r => r.FkTransactionRequestStatus = 5)
                        //    ;
                        //Validator.SyncSwitchOrders();

                        _dbcontext.TblDCalastoneTransactionRequest.UpdateRange(requests);
                        _dbcontext.SaveChanges();
                    }
                }
                else
                {
                    _logger.LogError($"No entries to be validated.");
                }

                #region Send business accept
                var acceptedRequests = _dbcontext.TblDCalastoneTransactionRequest
                   .Where(r => r.FkTransactionRequestStatus == (int)CalastoneEnums.TransactionStatus.BusinessAccepted
                        //&& r.FkTransactionRequestResource == 2
                        )
                   .ToList();
                if (acceptedRequests.Count > 0)
                {
                    string result = MessageHelper.SendStatusReportV04(acceptedRequests, "BusinessAccept");
                    acceptedRequests.ForEach(r => r.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.Validated);
                    _dbcontext.TblDCalastoneTransactionRequest.UpdateRange(acceptedRequests);
                    _dbcontext.SaveChanges();
                    //Validatior.ValidateTransactionRequest(acceptedRequests);
                    _logger.LogInformation(result);
                }
                #endregion Send business accept
                #region Send business reject
                var rejectedRequests = _dbcontext.TblDCalastoneTransactionRequest
                   .Where(r => r.FkTransactionRequestStatus == (int)CalastoneEnums.TransactionStatus.BusinessRejected
                        //&& r.FkTransactionRequestResource == 2
                        )
                   .ToList();
                if (rejectedRequests.Count > 0)
                {
                    string result = MessageHelper.SendStatusReportV04(rejectedRequests, "BusinessReject");
                    rejectedRequests.ForEach(r => r.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.SentToCTN);
                    _dbcontext.TblDCalastoneTransactionRequest.UpdateRange(rejectedRequests);
                    _dbcontext.SaveChanges();
                    _logger.LogInformation(result);
                }
                #endregion Send business reject
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                _logger.LogError("You have hit problem when validating transaction requests.");
                _logger.LogError(ex.Message ?? ex.InnerException.Message);
                throw ex;
            }
        }
    }
}