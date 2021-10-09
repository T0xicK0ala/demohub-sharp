using System;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace DemoHub.Infrastructure.MessageEngine
{
    class SqsPOCSampleCode
    {
        public static string GetSQSMessage()
        {
            string result = string.Empty;

            var sqs = new AmazonSQSClient(RegionEndpoint.APSoutheast2);

            var queueUrl = sqs.GetQueueUrlAsync("CalasonePOC.fifo").Result.QueueUrl;

            var receiveMessageRequest = new ReceiveMessageRequest
            {
                QueueUrl = queueUrl
            };

            var receiveMessageResponse = sqs.ReceiveMessageAsync(receiveMessageRequest).Result;

            foreach (var message in receiveMessageResponse.Messages)
            {
                Console.WriteLine("Message \n");
                Console.WriteLine($"..MessageId: {message.MessageId} \n");
                Console.WriteLine($"...ReceiptHandle: {message.ReceiptHandle} \n");
                Console.WriteLine($"...MD5Body {message.MD5OfBody} \n");
                Console.WriteLine($"...Body {message.Body} \n");
                result = message.Body;

                foreach (var attribute in message.Attributes)
                {
                    Console.WriteLine("Attribute \n");
                    Console.WriteLine($"...Name {attribute.Key} \n");
                    Console.WriteLine($"...Value {attribute.Value} \n");
                }

                //var messageReceiptHandle = receiveMessageResponse.Messages.FirstOrDefault()?.ReceiptHandle;

                //var deleteRequest = new DeleteMessageRequest
                //{
                //    QueueUrl = queueUrl,
                //    ReceiptHandle = messageReceiptHandle
                //};

                //sqs.DeleteMessageAsync(deleteRequest);


            }

            return result;
        }

        public static void SendSQSMessage(string xmlstr)
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("Amazon SQS");
            Console.WriteLine("**********************************\n");


            IAmazonSQS sqs = new AmazonSQSClient(RegionEndpoint.APSoutheast2);

            var myQueueUrl = @"queueurl";

            Console.WriteLine("Sending a message to our queue.\n");
            var sqsmessageRequest = new SendMessageRequest
            {
                QueueUrl = myQueueUrl,
                MessageBody = xmlstr,
                MessageGroupId = "order2",
                MessageDeduplicationId = "order2"
            };

            sqs.SendMessageAsync(sqsmessageRequest);

            Console.WriteLine("Finished sending message to our queue.\n");
            Console.ReadLine();
        }
    }
}
