using System;
using System.IO;
using System.Xml;
using System.Text;

namespace DemoHub.Common
{
    public class XMLPrinter
    {
        public static string Print(string xmlstr)
        {
            string result = string.Empty;

            MemoryStream mStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode);
            XmlDocument document = new XmlDocument();

            try
            {
                document.LoadXml(xmlstr);
                writer.Formatting = Formatting.Indented;
                document.WriteContentTo(writer);
                writer.Flush();
                mStream.Flush();
                mStream.Position = 0;
                StreamReader sReader = new StreamReader(mStream);
                string formattedXml = sReader.ReadToEnd();
                result = formattedXml;
            }
            catch (XmlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            mStream.Close();
            writer.Close();
            return result;
        }
    }
}
