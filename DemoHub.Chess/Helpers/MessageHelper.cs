using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DemoHub.Persistence.Models;
using DemoHub.Common;
using DemoHub.Common.Enums;
using static DemoHub.Chess.MessageHandlers.MessageFieldHandler;

namespace DemoHub.Chess.Helpers
{
    public class MessageHelper
    {


        public static Tuple<string, string, bool>[] FillInFields(string msg, List<Tuple<int, bool>> abc)
        {
            Tuple<string, string, bool>[] a = new Tuple<string, string, bool>[256];
            abc.ForEach(i => a[i.Item1 - 1] = new Tuple<string, string, bool>(Enum.GetName(typeof(MessageField), i.Item1),
                SetFieldValue(msg, Enum.GetName(typeof(MessageField), i.Item1)), i.Item2));

            a[64] = new Tuple<string, string, bool>(null, "1000000000000000", true);
            a[128] = new Tuple<string, string, bool>(null, "1000000000000000", true);
            a[192] = new Tuple<string, string, bool>(null, "0000000B01085840", true);
            return a;
        }

        //public static Tuple<string, string, bool>[] RetrieveFields(string msg, List<Tuple<int, bool>> abc)
        //{
        //    Tuple<string, string, bool>[] a = new Tuple<string, string, bool>[256];
        //    abc.ForEach(i => a[i.Item1 - 1] = new Tuple<string, string, bool>(Enum.GetName(typeof(MessageField), i.Item1),
        //        GetFieldValue(msg, Enum.GetName(typeof(MessageField), i.Item1)), i.Item2));
        //    return a;
        //}

        public static string SetFieldValue(string msg, string fieldname)
        {
            string abcde = string.Empty;
            if (msg.Substring(0, 1) == "C")
            {
                var fundcode = $"IE0000123456";
                var amount = $"100000.00";
                var initialApplication = $"Y";
                var TranId = $"1099042042042100";
                var AMLCTFCheckFlag = $"Y";
                var FATCAQuestions = $"N";
                var CurrentPDSProvided = $"Y";
                var PDSIssueDate = $"20190925";

                abcde = fieldname switch
                {
                    "fundcode" => fundcode,
                    "amount" => amount,
                    "initialApplication" => initialApplication,
                    "TranId" => TranId,
                    "AMLCTFCheckFlag" => AMLCTFCheckFlag,
                    "FATCAQuestions" => FATCAQuestions,
                    "CurrentPDSProvided" => CurrentPDSProvided,
                    "PDSIssueDate" => PDSIssueDate,
                    _ => ""
                };
            }
            //else if (msg.Substring(0, 1) == "E")
            //{
            //    var fundcode = $"IE0000876543";
            //    var amount = $"880000.00";
            //    var initialApplication = $"Y";
            //    var hin = "1234567890";
            //    var PID = "00111";
            //    var TranId = $"1099042042042100";
            //    var PaymentDate = "20190926";
            //    var RecordDate = "20190926";

            //    abcde = fieldname switch
            //    {
            //        "fundcode" => fundcode,
            //        "amount" => amount,
            //        "initialApplication" => initialApplication,
            //        "hin" => hin,
            //        "PID" => PID,
            //        "TranId" => TranId,
            //        "PaymentDate" => PaymentDate,
            //        "RecordDate" => RecordDate,
            //        _ => ""
            //    };
            //}
            else if (msg.Substring(0, 16) == "E0001C0000010004")
            {
                DemoHubDBContext dc = new DemoHubDBContext();
                var tran = dc.TblDTransaction.FirstOrDefault(
                    //t => t.FkTransactionResource == 3
                    ); // example transaction
                abcde = fieldname switch
                {
                    "fundcode" => "",//tran.SFundId,
                    "amount" => tran.DNetAmount.ToString(),
                    "hin" => "0035102468",
                    "PID" => "57924",
                    "timestamp" => DateTime.Now.ToString("yyyymmdd"),
                    "TransactionStatus" => "A",
                    "TranId" => tran.SRegTransactionNumber,
                    "transactionid" => "R3000021R00",
                    "OrderType" => "APP",
                    _ => ""
                };
            }
            //return fieldname + "_value";
            return abcde;
        }

        //public static string GetFieldValue(string msg, string fieldname)
        //{
        //    string abcde = string.Empty;
        //    var bitmap = msg.Substring(0, 16);

        //    if (bitmap == "4001080000000804")
        //    {
        //        abcde = fieldname switch
        //        {
        //            "hin" => msg.Substring(16, 10),
        //            "pid" => msg.Substring(26, 5),
        //            "timestamp" => msg.Substring(31, 22),
        //            "facilityid" => msg.Substring(53, 6),
        //            "indicator" => msg.Substring(59, 1),
        //            "transactionid" => msg.Substring(60, 16),
        //            _ => ""
        //        };
        //    }
        //    else if (bitmap == "5001080000000804")
        //    {
        //        abcde = fieldname switch
        //        {
        //            "fundcode" => msg.Substring(16, 12),
        //            "timestamp" => msg.Substring(28, 22),
        //            "TranId" => msg.Substring(50, 16),
        //            "transactionid" => msg.Substring(66, 16),
        //            _ => ""
        //        };
        //    }
        //    else if (bitmap == "E021180000010024")
        //    {
        //        abcde = fieldname switch
        //        {
        //            "FundCode" => msg.Substring(16, 12),
        //            "GrossDistributionAmount" => msg.Substring(28, 15),
        //            "InitialApplication" => msg.Substring(43, 1),
        //            "Hin" => msg.Substring(44, 10),
        //            "PID" => msg.Substring(54, 5),
        //            "timestamp" => msg.Substring(59, 22),
        //            "TranId" => msg.Substring(81, 16),
        //            "RegistrationDetails" => msg.Substring(97, 180),
        //            "transactionid" => msg.Substring(277, 16),

        //            "AMLCTFCheckFlag" => msg.Substring(325, 1), // 2 bitmap placeholders = 32
        //            "CurrentPDSProvided" => msg.Substring(326, 1),
        //            "ProductName" => msg.Substring(327, 50),
        //            "PDSIssueDate" => msg.Substring(377, 8),
        //            "APIRCode" => msg.Substring(385, 9),
        //            _ => ""
        //        };
        //    }
        //    //return fieldname + "_value";
        //    return abcde;
        //}


        //public static string SendChessMessage(List<TblDTransaction> t)
        //{
        //    Tuple<string, string, bool>[] result = null;
        //    //if (msg.Substring(0, 1) == "C")
        //    //{
        //    //    result = WriteMessage(msg, ChessEnums.MessageType.ApplicationRequest);
        //    //}
        //    //else if (msg.Substring(0, 1) == "E")
        //    //{
        //    //    result = WriteMessage(msg, ChessEnums.MessageType.IncomeStatement);
        //    //}
        //    var msg = $"E0001C0000010004";
        //    result = WriteMessage(msg, ChessEnums.MessageType.ApplicationOrderOrPaymentPlanApplicationResponse);


        //    foreach (var item in result)
        //    {
        //        if (item != null)
        //        {
        //            msg += item.Item2;
        //        }
        //    }
        //    //return bitmap + msg;
        //    return msg;
        //}
    }
}
