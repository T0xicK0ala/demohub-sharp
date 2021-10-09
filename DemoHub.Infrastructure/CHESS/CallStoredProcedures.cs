using System;
using System.Collections.Generic;
using System.Text;
using DemoHub.Common.Dictionaries;

namespace DemoHub.Infrastructure.CHESS
{
    public class CallStoredProcedures
    {
        public void MyResult()
        {
            ChessDictionaries dic = new ChessDictionaries("GetAllInvestors");
            dic.GetParameters();
        }
    }
}
