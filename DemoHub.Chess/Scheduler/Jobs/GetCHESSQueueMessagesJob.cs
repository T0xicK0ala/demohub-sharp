//using Amazon.SQS.Model;
//using DemoHub.Common.Enums;
//using DemoHub.Infrastructure.MessageEngine;
//using DemoHub.Persistence.Models;
//using DemoHub.WebServices.ChessMessageHandlers;
//using DemoHub.WebServices.Helpers;
//using DemoHub.WebServices.MessageHandlers;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Logging;
//using Quartz;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using static DemoHub.WebServices.Scheduler.Jobs.SendCTNMessagesJob;

//namespace DemoHub.Chess.Scheduler.Jobs
//{
//    [DisallowConcurrentExecution]
//    public class GetCHESSQueueMessagesJob : IJob
//    {
//        private readonly ILogger<GetCHESSQueueMessagesJob> _logger;
//        private readonly IConfiguration _configuration;
//        private readonly DemoHubDBContext _dbcontext;

//        public GetCHESSQueueMessagesJob(
//            ILogger<GetCHESSQueueMessagesJob> logger,
//            IConfiguration configuration,
//            DemoHubDBContext dbcontext)
//        {
//            _logger = logger;
//            _configuration = configuration;
//            _dbcontext = dbcontext;
//        }

//        public Task Execute(IJobExecutionContext context)
//        {
//            try
//            {
//                //save into SQS queue
//                string queuename = _configuration.GetSection("MessageEngine").GetSection("ChessMQ").Value;
//                string clientName = "client"; // get client name from appsettings
//                SqsMessagesService service = new SqsMessagesService(queuename, clientName);

//                var message = service.Dequeue().Result;
//                _logger.LogInformation("Messages Received from Queue. Start writing message....");
//                var reEnqueMessageList = new List<SQSMessage>();
//                foreach (var msg in message.Messages)
//                {
//                    _logger.LogInformation(msg.Body);
//                    var receiptHandle = msg.ReceiptHandle; // for delete message
//                    var msgGroupID = service.GetGroupMessageId(msg?.MessageAttributes);
//                    var deDupId = service.GetMessageDeduplicationId(msg?.MessageAttributes);
//                    var deleteResponse = service.Delete(receiptHandle).Result;
//                    reEnqueMessageList.Add(new SQSMessage()
//                    {
//                        Body = msg.Body,
//                        GroupId = msgGroupID,
//                        DeDupId = deDupId,
//                        MsgId = msg.MessageId
//                    });

//                    try
//                    {
//                        var chessMessageFormat = msg.Body;
//                        if (!string.IsNullOrEmpty(chessMessageFormat) && chessMessageFormat.Substring(0, 16) == "E021180000010024")
//                        {
//                            //var obj = ChessMessageHelper.WriteMessage(chessMessageFormat, ChessEnums.MessageType.ApplicationOrderRequest);
//                            ApplicationMessageHandler.MT727(null);

//                            #region SQS message deletion 


//                            //var deleteRequest = new DeleteMessageRequest
//                            //{
//                            //    QueueUrl = queueUrl,
//                            //    ReceiptHandle = messageReceiptHandle
//                            //};

//                            //sqs.DeleteMessageAsync(deleteRequest);

//                            #endregion
//                            _logger.LogInformation("End of message");
//                        }
//                        else
//                        {
//                            return Task.CompletedTask;
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        _logger.LogError(ex.Message);
//                        var response = ReEnque(service, msg.Body, msgGroupID, deDupId);
//                        reEnqueMessageList.Remove(reEnqueMessageList.FirstOrDefault(x => x.MsgId == msg.MessageId));
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError("Error while retrieving the queue");
//                _logger.LogError(ex.Message);
//            }
//            return Task.CompletedTask;
//        }
//        private Amazon.SQS.Model.SendMessageResponse ReEnque(SqsMessagesService service, string body, string groupId, string deDupId)
//        {
//            var response = service.Enqueue(body, groupId, deDupId).Result;
//            return response;
//        }
//    }
//}
