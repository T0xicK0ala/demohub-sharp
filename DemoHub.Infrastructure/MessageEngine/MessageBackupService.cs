using System;
using System.Collections.Generic;
using System.Text;
using Amazon.S3;
using Amazon;
using Amazon.S3.Model;
using Amazon.S3.Transfer;

namespace DemoHub.Infrastructure.MessageEngine
{
    public class MessageBackupService
    {
        public static void GetMessage()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("Amazon S3");
            Console.WriteLine("**********************************\n");

            IAmazonS3 s3 = new AmazonS3Client(RegionEndpoint.APSoutheast2);
            var bucketName = @"bucketname";
            const string keyName = @"setr.010.001.04.xml";

            var request = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = keyName
            };

            string responseBody;


            try
            {
                var response = s3.GetObjectAsync(request).Result;
                var responseStream = response.ResponseStream;
                using (var reader = new System.IO.StreamReader(responseStream))

                {
                    string title = response.Metadata["x-amz-meta-title"]; // Assume you have "title" as medata added to the object.
                    string contentType = response.Headers["Content-Type"];
                    Console.WriteLine("Object metadata, Title: {0}", title);
                    Console.WriteLine("Content type: {0}", contentType);

                    responseBody = reader.ReadToEnd(); // Now you process the response body.

                    // pass to SQS
                    //SQSMessage.Program.SendSQSMessage(responseBody);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }

        public static void SendMessage()
        {
            // get from SQS
            //string msg = SQSMessage.Program.GetSQSMessage();

            IAmazonS3 s3 = new AmazonS3Client(RegionEndpoint.APSoutheast2);
            var bucketName = @"bucketname";
            var keyName = @"neworder.xml";

            try
            {
                var request = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = keyName,
                    ContentBody = ""//msg
                };

                PutObjectResponse response = s3.PutObjectAsync(request).Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
