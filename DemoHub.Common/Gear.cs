using System;
using System.Linq;

namespace DemoHub.Common
{
    public class Gear
    {
        public const string UNAUTHORIZED = "Unauthorized";
        public const string REJECT_REASON = "Rejected by TAURUS";
        public const string REJECT_REASON_UNUNITISED = "Failed in unitising a transaction request.";
        public const string REJECT_REASON_PROCESS = "Failed in processing a transaction request.";
        public static readonly int MULTI_THREAD_NUMBER = 10;


        private static Random random = new Random();
        public static string RandomString(int length) // CHESS Transaction ID - UDI is 9 chars
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
