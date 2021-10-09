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
    [DisallowConcurrentExecution]
    public class GetCTNMessagesJob : IJob
    {
        private readonly ILogger<GetCTNMessagesJob> _logger;
        private readonly IConfiguration _configuration;

        public GetCTNMessagesJob(ILogger<GetCTNMessagesJob> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public Task Execute(IJobExecutionContext context)
        {
            var username = _configuration.GetSection("CalastoneCredentials:CTNusername").Value;
            var password = _configuration.GetSection("CalastoneCredentials:CTNpassword").Value;
            var endpointAddress = _configuration.GetSection("Iso20022BasicServiceClient").GetSection("endpoint:address").Value;
            var ctnService = new CalastoneCommunicationService(username, password, endpointAddress);

            try
            {
                var result = ctnService.GetMessagesAsync().Result;

                if (result == null || result.GetMessagesResult == null || result.GetMessagesResult.Messages1 == null)
                {
                    return Task.CompletedTask;
                }
                //convert the result into xml string
                var xmlString = XmlHelper.SerializeToXmlString(result);
                //now that we have the raw message, save the raw information into queue and/or log file and/or s3 bucket
                //TODO: save into s3 if necessary
                _logger.LogInformation("Messages Received from Calastone. Start writing message....");
                _logger.LogInformation(xmlString);
                _logger.LogInformation("End of message");

                //save into SQS queue
                string queuename = _configuration.GetSection("MessageEngine").GetSection("CalastoneMQ").Value;
                string clientName = "client"; // get client name from appsettings
                SqsMessagesService service = new SqsMessagesService(queuename, clientName);

                try
                {
                    ////TODO: Break the message into several multiple messages and send to queue, or we can send the whole thing to queue

                    var enqueueResult = service.Enqueue(xmlString, MessageType.Order).Result;
                    return Task.CompletedTask;
                }
                catch (Exception ex)
                {
                    _logger.LogError("Error while sending to queue");
                    _logger.LogError(ex.Message);
                }

            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message ?? ex.InnerException.Message;
                string errorReason = "You have hit problem in the Get Calastone Job";

                _logger.LogError(errorReason);
                _logger.LogError(errorMessage);

                var errorResult = ctnService.SignalErrorAsync(errorMessage, errorReason).Result;
                if (errorResult != null)
                    _logger.LogError(errorResult.ToString());
            }
            return Task.CompletedTask;
        }
    }
}
