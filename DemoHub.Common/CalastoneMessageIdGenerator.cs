using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHub.Common
{
    public class CalastoneMessageIdGenerator
    {
        public static string NewMessageId()
        {
            //return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            return DateTime.Now.ToFileTime().ToString();
        }

        public static string NewOrderReference()
        {
            // return $"OrdrRef-{Convert.ToBase64String(Guid.NewGuid().ToByteArray())}";
            return $"OrdrRef-{ DateTime.Now.ToFileTime().ToString()} ";
        }

        public static string NewDealReference()
        {
            return $"DealRef-{DateTime.Now.ToFileTime().ToString()}";
        }
    }
}
