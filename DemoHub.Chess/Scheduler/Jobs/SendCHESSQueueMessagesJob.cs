//using Amazon.SQS.Model;
//using CalastoneServiceReference;
//using DemoHub.Common;
//using DemoHub.Common.Enums;
//using DemoHub.Infrastructure.MessageEngine;
//using DemoHub.Persistence.Models;
//using DemoHub.WebServices.Helpers;
//using DemoHub.WebServices.MessageHandlers;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Logging;
//using Quartz;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace DemoHub.Chess.Scheduler.Jobs
//{
//    [DisallowConcurrentExecution]
//    public class SendCHESSQueueMessagesJob : IJob
//    {
//        private readonly ILogger<SendCHESSQueueMessagesJob> _logger;
//        private readonly IConfiguration _configuration;
//        private readonly DemoHubDBContext _dbcontext;

//        public SendCHESSQueueMessagesJob(ILogger<SendCHESSQueueMessagesJob> logger, IConfiguration configuration, DemoHubDBContext dbcontext)
//        {
//            _logger = logger;
//            _configuration = configuration;
//            _dbcontext = dbcontext;
//        }

//        public Task Execute(IJobExecutionContext context)
//        {
//            try
//            {
//                string queuename = _configuration.GetSection("MessageEngine").GetSection("DemoHubMQ").Value;
//                string clientName = "client"; // get client name from appsettings
//                SqsMessagesService service = new SqsMessagesService(queuename, clientName);

//                var trans = _dbcontext.TblDTransaction
//                    .Where(r => r.FkTransactionStatus == 9
//                        && r.FkTransactionResource == 3)
//                    .ToList();
//                if (trans.Count > 0)
//                {
//                    string msg = "";// ChessMessageHelper.SendChessMessage(trans);

//                    if (!string.IsNullOrEmpty(msg))
//                    {
//                        SendMessageResponse response = service.Enqueue(msg, "ChessOrderResponse").Result;
//                        if (response.HttpStatusCode.ToString() == "OK")
//                        {
//                            trans.FirstOrDefault(t => t.FkTransactionResource == 3).FkTransactionStatus = 10;
//                            _dbcontext.TblDTransactionRequest.FirstOrDefault(r => r.FkTransactionRequestResource == 3).FkTransactionRequestStatus = 10;
//                            _dbcontext.UpdateRange(trans);
//                            _dbcontext.UpdateRange(_dbcontext.TblDTransactionRequest);
//                            _dbcontext.SaveChanges();
//                        }
//                    }
//                }  
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError("Error while sending queue messages");
//                _logger.LogError(ex.Message);
//            }
//            return Task.CompletedTask;
//        }
//    }
//}
