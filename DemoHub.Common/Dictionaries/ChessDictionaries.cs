using System;
using System.Collections.Generic;

namespace DemoHub.Common.Dictionaries
{
    public class ChessDictionaries
    {
        public readonly string _spname;
        public ChessDictionaries(string spname)
        {
            _spname = spname;
        }

        private readonly Dictionary<string, List<string>> chessSprocDictionary = new Dictionary<string, List<string>>()
        {
            { "GetAllInvestors", null },
            { "GetAllCountries", null },
            { "GetTransactions", null }
        };

        public List<string> GetParameters()
        {
            List<string> parameters;
            try
            {
                chessSprocDictionary.TryGetValue(_spname, out parameters);
                return parameters;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}