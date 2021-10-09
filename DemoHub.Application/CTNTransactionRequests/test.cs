using DemoHub.Application.CTNTransactionRequests.Models;
using System.Xml.Serialization;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using ZeroFormatter;

namespace DemoHub.Application.CTNTransactionRequests
{
    public class test
    {
        public void Des(string fileName)
        {
            fileName = @"CTNTransactionRequests/setr.010.001.04.xml";
            using (var file = File.OpenRead(fileName))
            {
                var document = ZeroFormatterSerializer.Deserialize<CTNTransactionRequestDto>(file);
                // test speed 
            }

        }
    }
}