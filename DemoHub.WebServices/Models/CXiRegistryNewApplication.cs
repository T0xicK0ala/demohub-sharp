using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHub.WebServices.Models
{
    public class TAURUSNewApplication
    {
        public DateTime ReceivedAt { get; set; }
        public int? ProductID { get; set; }
        public List<InvestmentDetails> investmentDetails { get; set; }
        public TAURUSNewApplication()
        {
            investmentDetails = new List<InvestmentDetails>();
        }
    }
    public class InvestmentDetails
    {
        public int? ClassID { get; set; }
        public decimal? InvestmentAmount { get; set; }
    }

    public class TAURUSNewRedemption
    {
        public DateTime ReceivedAt { get; set; }
        public string ProductID { get; set; }
        public int? ClassID { get; set; }
        public decimal? Units { get; set; }
        public decimal? Amount { get; set; }
    }
    public class TransactionNumbers
    {
        public string TransactionNumber { get; set; }
    }

    public class Switch
    {
        public string AccountNumber { get; set; }
        public SwitchFrom From { get; set; }
        public SwitchTo To { get; set; }
        public decimal? Units { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? ReceiptDateTime { get; set; }
    }

    public class SwitchFrom
    {
        public int? ClassID { get; set; }
    }
    public class SwitchTo
    {
        public int? ClassID { get; set; }
    }
}
