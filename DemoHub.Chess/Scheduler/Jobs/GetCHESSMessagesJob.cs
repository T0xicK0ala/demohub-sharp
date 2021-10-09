//using Amazon;
//using Amazon.S3;
//using Amazon.S3.Model;
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

//namespace DemoHub.Chess.Scheduler.Jobs
//{
//    [DisallowConcurrentExecution]
//    public class GetCHESSMessagesJob : IJob
//    {
//        private readonly ILogger<GetCHESSMessagesJob> _logger;
//        private readonly IConfiguration _configuration;

//        public GetCHESSMessagesJob(ILogger<GetCHESSMessagesJob> logger, IConfiguration configuration)
//        {
//            _logger = logger;
//            _configuration = configuration;
//        }

//        public Task Execute(IJobExecutionContext context)
//        {
//            try
//            {
//                IAmazonS3 s3 = new AmazonS3Client(RegionEndpoint.APSoutheast2);
//                var bucketName = @"chess-messages";
//                var keyName = @"mt727.txt";

//                GetObjectRequest request = new GetObjectRequest
//                {
//                    BucketName = bucketName,
//                    Key = keyName
//                };

//                var response = s3.GetObjectAsync(request).Result;
//                var responseStream = response.ResponseStream;
//                using var reader = new StreamReader(responseStream);
//                string responseBody = reader.ReadToEnd();
//                if (!string.IsNullOrEmpty(responseBody))
//                {
//                    string queuename = _configuration.GetSection("MessageEngine").GetSection("ChessMQ").Value;
//                    string clientName = "client"; // get client name from appsettings
//                    SqsMessagesService service = new SqsMessagesService(queuename, clientName);

//                    try
//                    {
//                        var enqueueResult = service.Enqueue(responseBody, ChessMessageType.OrderRequest).Result;
//                        if (enqueueResult.HttpStatusCode.ToString() == "OK")
//                        {
//                            DeleteObjectRequest deleteReq = new DeleteObjectRequest();
//                            deleteReq.BucketName = bucketName;
//                            deleteReq.Key = keyName;
//                            var deleteResult = s3.DeleteObjectAsync(deleteReq).Result;
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        _logger.LogError("Error while sending to queue");
//                        _logger.LogError(ex.Message);
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
