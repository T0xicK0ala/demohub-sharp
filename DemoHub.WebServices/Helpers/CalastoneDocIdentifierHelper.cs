using CalastoneServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHub.WebServices.Helpers
{
    public static class CalastoneDocIdentifierHelper
    {
        public static object GetDocument(string xmlString)
        {
            var docType = "";

            // subs
            if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.010.001.04"))
            {
                docType = typeof(Document2).Name;
                var obj = XmlHelper.Deserialize<Document2>(xmlString);
                return obj;
            }
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.010.001.03"))
            {
                docType = typeof(Document15).Name;
                var obj = XmlHelper.Deserialize<Document15>(xmlString);
                return obj;
            }
            //confirmation
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.012.001.03"))
            {
                docType = typeof(Document16).Name;
                var obj = XmlHelper.Deserialize<Document16>(xmlString);
                return obj;
            }
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.012.001.04"))
            {
                docType = typeof(Document3).Name;
                var obj = XmlHelper.Deserialize<Document3>(xmlString);
                return obj;
            }

            //subs end

            //red
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.004.001.03"))
            {
                docType = typeof(Document13).Name;
                var obj = XmlHelper.Deserialize<Document13>(xmlString);
                return obj;
            }
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.004.001.04"))
            {
                docType = typeof(Document).Name;
                var obj = XmlHelper.Deserialize<Document>(xmlString);
                return obj;
            }
            //confirmations
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.006.001.03"))
            {
                docType = typeof(Document14).Name;
                var obj = XmlHelper.Deserialize<Document14>(xmlString);
                return obj;
            }
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.006.001.04"))
            {
                docType = typeof(Document1).Name;
                var obj = XmlHelper.Deserialize<Document1>(xmlString);
                return obj;
            }
            //red end

            //switch order
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.013.001.03"))
            {
                docType = typeof(Document17).Name;
                var obj = XmlHelper.Deserialize<Document17>(xmlString);
                return obj;
            }
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.013.001.04"))
            {
                docType = typeof(Document4).Name;
                var obj = XmlHelper.Deserialize<Document4>(xmlString);
                return obj;
            }
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.015.001.03"))
            {
                docType = typeof(Document18).Name;
                var obj = XmlHelper.Deserialize<Document18>(xmlString);
                return obj;
            }
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.015.001.04"))
            {
                docType = typeof(Document5).Name;
                var obj = XmlHelper.Deserialize<Document5>(xmlString);
                return obj;
            }
            //switch order end

            //order status
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.016.001.03"))
            {
                docType = typeof(Document19).Name;
                var obj = XmlHelper.Deserialize<Document19>(xmlString);
                return obj;
            }
            else if (xmlString.Contains("urn:iso:std:iso:20022:tech:xsd:setr.016.001.04"))
            {
                docType = typeof(Document6).Name;
                var obj = XmlHelper.Deserialize<Document6>(xmlString, "Document");
                return obj;
            }

            return null;
        }
    }
}
