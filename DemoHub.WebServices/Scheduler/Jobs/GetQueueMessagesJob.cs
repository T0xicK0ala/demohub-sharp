using Amazon.SQS.Model;
using CalastoneServiceReference;
using DemoHub.Common;
using DemoHub.Infrastructure.MessageEngine;
using DemoHub.Persistence.Models;
using DemoHub.WebServices.Helpers;
using DemoHub.WebServices.MessageHandlers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DemoHub.WebServices.Scheduler.Jobs.SendCTNMessagesJob;

namespace DemoHub.WebServices.Scheduler.Jobs
{
    [DisallowConcurrentExecution]
    public class GetQueueMessagesJob : IJob
    {
        private readonly ILogger<GetQueueMessagesJob> _logger;
        private readonly IConfiguration _configuration;
        private readonly DemoHubDBContext _dbcontext;

        public GetQueueMessagesJob(
            ILogger<GetQueueMessagesJob> logger,
            IConfiguration configuration,
            DemoHubDBContext dbcontext)
        {
            _logger = logger;
            _configuration = configuration;
            _dbcontext = dbcontext;
        }
        public Task Execute(IJobExecutionContext context)
        {
            try
            {
                //save into SQS queue
                string queuename = _configuration.GetSection("MessageEngine").GetSection("CalastoneMQ").Value;
                string clientName = "client"; // get client name from appsettings
                SqsMessagesService service = new SqsMessagesService(queuename, clientName);

                var message = service.Dequeue().Result;
                _logger.LogInformation("Messages Received from Queue. Start writing message....");
                var reEnqueMessageList = new List<SQSMessage>();
                foreach (var msg in message.Messages)
                {
                    _logger.LogInformation(msg.Body);
                    var receiptHandle = msg.ReceiptHandle; // for delete message
                    var msgGroupID = service.GetGroupMessageId(msg?.MessageAttributes);
                    var deDupId = service.GetMessageDeduplicationId(msg?.MessageAttributes);
                    var deleteResponse = service.Delete(receiptHandle).Result;
                    reEnqueMessageList.Add(new SQSMessage()
                    {
                        Body = msg.Body,
                        GroupId = msgGroupID,
                        DeDupId = deDupId,
                        MsgId = msg.MessageId
                    });
                    GetMessagesResponse calastoneMessageFormat = null;
                    try
                    {
                        calastoneMessageFormat = XmlHelper.Deserialize<GetMessagesResponse>(msg.Body);
                    }
                    catch (Exception)
                    {
                        var response = ReEnque(service, msg.Body, msgGroupID, deDupId);
                        reEnqueMessageList.Remove(reEnqueMessageList.FirstOrDefault(x => x.MsgId == msg.MessageId));
                    }

                    if (calastoneMessageFormat != null)
                    {
                        foreach (var doc in calastoneMessageFormat?.GetMessagesResult?.Messages1?.Items)
                        {
                            string ackMessage = string.Empty;
                            //SqsMessagesService sendclient = new SqsMessagesService("DemoHubMQ.fifo", "client");
                            //SendMessageResponse enqueueResult;

                            switch (doc.GetType().Name)
                            {
                                #region Version 04
                                case "Document2":
                                    SubscriptionMessageHandler.OrderV04((Document2)doc);
                                    //_dbcontext
                                    break;
                                case "Document":
                                    RedemptionMessageHandler.OrderV04((Document)doc);
                                    break;
                                case "Document4":
                                    SwitchMessageHandler.OrderV04((Document4)doc);
                                    break;
                                #endregion

                                #region Version 03
                                case "Document15":
                                    SubscriptionMessageHandler.OrderV03((Document15)doc);
                                    break;
                                case "Document13":
                                    RedemptionMessageHandler.OrderV03((Document13)doc);
                                    break;
                                case "Document17":
                                    SwitchMessageHandler.OrderV03((Document17)doc);
                                    break;
                                #endregion
                                default:
                                    break;
                            }
                        }
                        // route to different clients

                        // get receiptHanlder



                        #region SQS message deletion 


                        //var deleteRequest = new DeleteMessageRequest
                        //{
                        //    QueueUrl = queueUrl,
                        //    ReceiptHandle = messageReceiptHandle
                        //};

                        //sqs.DeleteMessageAsync(deleteRequest);

                        #endregion
                        _logger.LogInformation("End of message");

                    }

                }

                ///TODO: Process these messages
            }
            catch (Exception ex)
            {
                _logger.LogError("Error while retrieving the queue");
                _logger.LogError(ex.Message);
            }
            return Task.CompletedTask;
        }

        private Amazon.SQS.Model.SendMessageResponse ReEnque(SqsMessagesService service, string body, string groupId, string deDupId)
        {
            var response = service.Enqueue(body, groupId, deDupId).Result;
            return response;
        }
    }
}
