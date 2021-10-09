using System;
using System.Text;

namespace DemoHub.Application.Infrastructure.CTNMessageFactory
{
    public class Messages
    {
        // Root element "Messages" is used for multiple messages to be sent to Calastone.
        public string AddRootElement(string messages)
        {
            string result = string.Empty;
            StringBuilder msg = new StringBuilder();
            try
            {
                msg.Append("<Messages>");
                msg.Append(messages);
                msg.Append("</Messages>");
                result = msg.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }
    }
}
