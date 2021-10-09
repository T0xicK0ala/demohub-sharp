//using Amazon;
//using Amazon.S3;
//using Amazon.S3.Model;
//using Amazon.SQS.Model;
//using DemoHub.Common;
//using DemoHub.Infrastructure;
//using DemoHub.Infrastructure.Calastone;
//using DemoHub.Infrastructure.MessageEngine;
//using DemoHub.WebServices.Helpers;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Logging;
//using Quartz;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;
//using static DemoHub.WebServices.Scheduler.Jobs.SendCTNMessagesJob;

//namespace DemoHub.Chess.Scheduler.Jobs
//{
//    [DisallowConcurrentExecution]
//    public class SendCHESSMessagesJob : IJob
//    {
//        private readonly ILogger<SendCHESSMessagesJob> _logger;
//        private readonly IConfiguration _configuration;

//        public SendCHESSMessagesJob(ILogger<SendCHESSMessagesJob> logger, IConfiguration configuration)
//        {
//            _logger = logger;
//            _configuration = configuration;
//        }

//        public Task Execute(IJobExecutionContext context)
//        {
//            try
//            {
//                string queuename = _configuration.GetSection("MessageEngine").GetSection("DemoHubMQ").Value; //  add 
//                string clientName = "client"; // get client name from appsettings
//                SqsMessagesService service = new SqsMessagesService(queuename, clientName);
//                var message = service.Dequeue().Result;

//                var reEnqueMessageList = new List<SQSMessage>();
//                if (message.Messages.Count > 0)
//                {
//                    var items = new object[message.Messages.Count];
//                    for (int i = 0; i < message.Messages.Count; i++)
//                    {
//                        var receiptHandle = message.Messages[i].ReceiptHandle;
//                        var msgGroupID = service.GetGroupMessageId(message.Messages[i]?.MessageAttributes);
//                        var deDupId = service.GetMessageDeduplicationId(message.Messages[i]?.MessageAttributes);
//                        var deleteResponse = service.Delete(receiptHandle).Result;

//                        IAmazonS3 s3 = new AmazonS3Client(RegionEndpoint.APSoutheast2);
//                        PutObjectRequest request = new PutObjectRequest();
//                        request.BucketName = @"chess-messages";
//                        request.Key = @"MT729.txt";
//                        request.ContentType = "text/plain";
//                        request.ContentBody = message.Messages[i].Body;
//                        var result = s3.PutObjectAsync(request).Result;

//                        #region Send MT722
//                        if (result.HttpStatusCode.ToString() == "OK")
//                        {
//                            var MT722 = @"00000800000100042019100820191008120500T4021896        R3000021R00     ";
//                            var MT731 = @"E011380000010004BFL0002AU+0000000100000020191008003510246857924579242019100820191008120500T4021896                R3000021R00     ";
//                            PutObjectRequest newrequest = new PutObjectRequest();
//                            newrequest.BucketName = @"chess-messages";
//                            newrequest.Key = @"MT722.txt";
//                            newrequest.ContentType = "text/plain";
//                            newrequest.ContentBody = MT722;
//                            var result1 = s3.PutObjectAsync(newrequest).Result;

//                            newrequest = new PutObjectRequest();
//                            newrequest.BucketName = @"chess-messages";
//                            newrequest.Key = @"MT731.txt";
//                            newrequest.ContentType = "text/plain";
//                            newrequest.ContentBody = MT731;
//                            var result2 = s3.PutObjectAsync(newrequest).Result;
//                        }
//                        #endregion
//                        _logger.LogInformation(result.HttpStatusCode.ToString());
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex.Message);
//            }
//            return Task.CompletedTask;
//        }
//    }
//}
