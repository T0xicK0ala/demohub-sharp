using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoHub.WebServices.Helpers
{
    public static class XmlHelper
    {
        public static string SerializeToXmlString<T>(T toSerialize)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());
                using (StringWriter textWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(textWriter, toSerialize);
                    return textWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T Deserialize<T>(string xmlString, string root = null) where T : class
        {
            try
            {
                XmlSerializer serializableDocument;
                if (root == null)
                {
                    serializableDocument = new XmlSerializer(typeof(T));
                }
                else
                {
                    serializableDocument = new XmlSerializer(typeof(T), new XmlRootAttribute(root));
                }

                using (TextReader reader = new StringReader(xmlString))
                {
                    var result = (T)serializableDocument.Deserialize(reader);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
