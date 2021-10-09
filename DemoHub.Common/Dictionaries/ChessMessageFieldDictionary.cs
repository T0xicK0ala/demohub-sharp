using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHub.Common.Dictionaries
{
    public class ChessMessageFieldDictionary
    {
        public readonly Dictionary<string, int> messageFieldDictionary = new Dictionary<string, int>()
        {
            { "FundCode", 2 },
            { "SecurityCode", 2 },
        };
    }
}
