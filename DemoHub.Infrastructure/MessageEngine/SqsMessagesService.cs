using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using DemoHub.Common;

namespace DemoHub.Infrastructure.MessageEngine
{

    public class SqsMessagesService
    {
        private string _queuename;
        private string _clientname;

        public SqsMessagesService(string queuename, string clientname)
        {
            _queuename = queuename;
            _clientname = clientname;
        }
        /// <Summary>
        /// Dequeue sqs messages
        /// </Summary>
        /// <returns>
        /// ReceiveMessageResponse
        /// </returns>
        public async Task<ReceiveMessageResponse> Dequeue()
        {
            try
            {
                var sqsClient = new AmazonSQSClient(RegionEndpoint.APSoutheast2);
                var queueUrl = sqsClient.GetQueueUrlAsync(_queuename).Result.QueueUrl;

                List<string> attributesList = new List<string>();
                attributesList.Add("MessageGroupId");
                attributesList.Add("MessageDeduplicationId");

                var request = new ReceiveMessageRequest
                {
                    QueueUrl = queueUrl,
                    MessageAttributeNames = attributesList
                };

                var response = await sqsClient.ReceiveMessageAsync(request);
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <Summary>
        /// Enqueue Calastone subscription/redemption/switch order confirmations from DemoHub.Core to SQS
        /// Enqueue Order status report from DemoHub.Core to SQS
        /// </Summary>
        /// <param name="clientid">Client ID from Dictionary</param>
        /// <param name="message">Orders received from Calastone by polling CTN Web Services</param>
        /// <returns>
        /// HTTP Status Code
        /// </returns>
        public async Task<SendMessageResponse> Enqueue(string message, string messageGroupId, string messageDeduplicationId = null)
        {
            try
            {
                IAmazonSQS sqsClient = new AmazonSQSClient(RegionEndpoint.APSoutheast2);
                var myQueueUrl = sqsClient.GetQueueUrlAsync(_queuename).Result.QueueUrl;

                var attributesList = new Dictionary<string, MessageAttributeValue>();
                var dedupId = String.IsNullOrEmpty(messageDeduplicationId) ? MessageDeduplicationIdGenerator.New(_clientname) : messageDeduplicationId;
                attributesList.Add("MessageGroupId", new MessageAttributeValue { DataType = "String", StringValue = messageGroupId });
                attributesList.Add("MessageDeduplicationId", new MessageAttributeValue { DataType = "String", StringValue = dedupId });


                var request = new SendMessageRequest()
                {
                    MessageAttributes = attributesList,
                    QueueUrl = myQueueUrl,
                    MessageBody = message,
                    MessageGroupId = messageGroupId,
                    MessageDeduplicationId = dedupId,
                };

                var result = await sqsClient.SendMessageAsync(request);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DeleteMessageResponse> Delete(string messageReceiptHandle)
        {
            try
            {
                IAmazonSQS sqsClient = new AmazonSQSClient(RegionEndpoint.APSoutheast2);
                var myQueueUrl = sqsClient.GetQueueUrlAsync(_queuename).Result.QueueUrl;
                var request = new DeleteMessageRequest()
                {
                    QueueUrl = myQueueUrl,
                    ReceiptHandle = messageReceiptHandle
                };

                var result = await sqsClient.DeleteMessageAsync(request);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetGroupMessageId(Dictionary<string, MessageAttributeValue> messageAttributes)
        {
            var messageGroupId = new MessageAttributeValue();
            if (messageAttributes.TryGetValue("MessageGroupId", out messageGroupId))
            {
                return messageGroupId?.StringValue;
            }
            else
            {
                return null;
            }

        }
        public string GetMessageDeduplicationId(Dictionary<string, MessageAttributeValue> messageAttributes)
        {
            var deDup = new MessageAttributeValue();
            if (messageAttributes.TryGetValue("MessageDeduplicationId", out deDup))
            {
                return deDup?.StringValue;
            }
            else
            {
                return null;
            }

        }
    }
}