using System;
using Quartz;
using System.Linq;
using DemoHub.Common.Enums;
using System.Threading.Tasks;
using System.Collections.Generic;
using DemoHub.Persistence.Models;
using DemoHub.WebServices.Helpers;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using DemoHub.Infrastructure.MessageEngine;

namespace DemoHub.WebServices.Scheduler.Jobs
{
    [DisallowConcurrentExecution]
    public class SendQueueOrderConfirmationsJob : IJob
    {
        private readonly ILogger<SendQueueOrderConfirmationsJob> _logger;
        private readonly IConfiguration _configuration;
        private readonly DemoHubDBContext _dbcontext;

        public SendQueueOrderConfirmationsJob(ILogger<SendQueueOrderConfirmationsJob> logger, IConfiguration configuration, DemoHubDBContext dbcontext)
        {
            _logger = logger;
            _configuration = configuration;
            _dbcontext = dbcontext;
        }

        public Task Execute(IJobExecutionContext context)
        {
            try
            {
                var subtransactions = BusinessLogicHelper.GetAllReadyToBeSentToCTNTransactionSub();
                var redtransactions = BusinessLogicHelper.GetAllReadyToBeSentToCTNTransactionRed();
                var switchtransactions = BusinessLogicHelper.GetAllReadyToBeSentToCTNTransactionSwitch();

                string queuename = _configuration.GetSection("MessageEngine").GetSection("DemoHubMQ").Value;
                string clientName = "client"; // get client name from appsettings
                SqsMessagesService service = new SqsMessagesService(queuename, clientName);

                //// TODO: check business accept message arrived Calastone before sending an order confirmation
                //foreach(var trn in switchtransactions)
                //{
                //    var switchConfOrder = SwitchMessageHandler.OrderConfirmationV04(trn.Item1, trn.Item2);
                //    var response = service.Enqueue(switchConfOrder, MessageType.OrderConfirmation).Result;
                //    BusinessLogicHelper.SentToCalastone(trn.Item1);
                //    BusinessLogicHelper.SentToCalastone(trn.Item2);
                //}

                if (subtransactions.Count > 0)
                {
                    string messageresult = MessageHelper.SendOrderConfirmationV04(subtransactions);
                    if (messageresult == "OK")
                        UpdateStatus(subtransactions);
                    _logger.LogInformation(messageresult);
                }
                if (redtransactions.Count > 0)
                {
                    string messageresult = MessageHelper.SendOrderConfirmationV04(redtransactions);
                    if (messageresult == "OK")
                        UpdateStatus(redtransactions);
                    _logger.LogInformation(messageresult);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Error while sending queue order confirmations");
                _logger.LogError(ex.Message);
            }
            return Task.CompletedTask;
        }

        private void UpdateStatus(List<TblDTransaction> t)
        {
            //t.ForEach(t => t.FkTransactionStatus = (int)CalastoneEnums.TransactionStatus.SentToCTN);
            _dbcontext.TblDCalastoneTransactionRequest
                .Where(r => t.Any(t => t.FkTransactionRequest == r.KTransactionRequest))
                .ToList().ForEach(r => r.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.SentToCTN);
            _dbcontext.UpdateRange(t);
            _dbcontext.UpdateRange(_dbcontext.TblDCalastoneTransactionRequest);
            _dbcontext.SaveChanges();
        }
    }
}