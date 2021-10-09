using CalastoneServiceReference;
using DemoHub.Common;
using DemoHub.Infrastructure;
using DemoHub.Infrastructure.Calastone;
using DemoHub.Infrastructure.MessageEngine;
using DemoHub.WebServices.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHub.WebServices.Scheduler.Jobs
{
    public class SendCTNMessagesJob : IJob
    {
        private readonly ILogger<SendCTNMessagesJob> _logger;
        private readonly IConfiguration _configuration;

        public SendCTNMessagesJob(ILogger<SendCTNMessagesJob> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public Task Execute(IJobExecutionContext context)
        {
            try
            {
                var username = _configuration.GetSection("CalastoneCredentials:CTNusername").Value;
                var password = _configuration.GetSection("CalastoneCredentials:CTNpassword").Value;
                var endpointAddress = _configuration.GetSection("Iso20022BasicServiceClient").GetSection("endpoint:address").Value;

                var ctnService = new CalastoneCommunicationService(username, password, endpointAddress);
                Messages messages = new Messages();

                //save into SQS queue
                string queuename = _configuration.GetSection("MessageEngine").GetSection("DemoHubMQ").Value; //  add 
                string clientName = "client"; // get client name from appsettings
                SqsMessagesService service = new SqsMessagesService(queuename, clientName);
                var message = service.Dequeue().Result;

                var reEnqueMessageList = new List<SQSMessage>();
                if (message.Messages.Count > 0)
                {
                    try
                    {
                        //GetMessagesResponse calastoneMessageFormat = XmlHelper.Deserialize<GetMessagesResponse>(message.Messages[i].Body).Result;
                        var items = new object[message.Messages.Count];

                        for (int i = 0; i < message.Messages.Count; i++)
                        {
                            //    //first delete the message from the queue to process it
                            var receiptHandle = message.Messages[i].ReceiptHandle;
                            var msgGroupID = service.GetGroupMessageId(message.Messages[i]?.MessageAttributes);
                            var deDupId = service.GetMessageDeduplicationId(message.Messages[i]?.MessageAttributes);

                            var deleteResponse = service.Delete(receiptHandle).Result;
                            //    reEnqueMessageList.Add(new SQSMessage()
                            //    {
                            //        Body = message.Messages[i].Body,
                            //        GroupId = msgGroupID,
                            //        DeDupId = deDupId,
                            //        MsgId = message.Messages[i].MessageId
                            //    });
                            //    try
                            //    {                               
                            //var doc = CalastoneDocIdentifierHelper.GetDocument(message.Messages[i].Body);



                            SendMessagesRequest calastoneMessageFormat = XmlHelper.Deserialize<SendMessagesRequest>(message.Messages[i].Body);

                            messages = calastoneMessageFormat.message;
                            var result = ctnService.SendMessagesAsync(messages).Result;
                            _logger.LogInformation(result.ToString());
                            //foreach (var doc in calastoneMessageFormat?.GetMessagesResult?.Messages1?.Items)
                            //{
                            //    items[i] = doc; 
                            //}
                            //items[i] = doc; 

                            //    }
                            //    catch (Exception ex)
                            //    {
                            //        //save back to the same queue
                            //        var response = ReEnque(service,message.Messages[i].Body, msgGroupID, deDupId);
                            //        reEnqueMessageList.Remove(reEnqueMessageList.FirstOrDefault(x=>x.MsgId== message.Messages[i].MessageId));
                            //    }

                        }
                        //messages.Messages1 = new MessagesType();
                        //messages.Messages1.Items = new MessagesType[message.Messages.Count];
                        //messages.Messages1.Items = items;

                        //var des = XmlHelper.SerializeToXmlString(messages);




                        //var doc = CalastoneDocIdentifierHelper.GetDocument(message.Messages[0].Body);
                        //messages.Messages1.Items[0] = doc;


                    }
                    catch (Exception ex)
                    {
                        _logger.LogError("Error while getting messages from queue");
                        _logger.LogError(ex.Message);
                        foreach (var msg in reEnqueMessageList)
                        {
                            var response = ReEnque(service, msg.Body, msg.GroupId, msg.DeDupId);
                        }
                    }

                    _logger.LogInformation("Messages sent to Calastone. Start writing message....");
                    _logger.LogInformation("End of message");
                }


            }
            catch (Exception ex)
            {

                _logger.LogError("You have hit problem in the Send Calastone Job");
                _logger.LogError(ex.Message);
            }
            return Task.CompletedTask;
        }

        private Amazon.SQS.Model.SendMessageResponse ReEnque(SqsMessagesService service, string body, string groupId, string deDupId)
        {
            var response = service.Enqueue(body, groupId, deDupId).Result;
            return response;
        }
        public class SQSMessage
        {
            public string Body { get; set; }
            public string GroupId { get; set; }
            public string DeDupId { get; set; }

            public string MsgId { get; set; }
        }
    }
}
