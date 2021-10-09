using System;
using System.Collections.Generic;
using System.Text;
using ZeroFormatter;

namespace DemoHub.Application.CTNTransactionRequests.Models
{
    [ZeroFormattable]
    public class CTNTransactionRequestDto
    {
        [Index(0)]
        public int Id { get; set; }
        [Index(1)]
        public DateTime CreDtTm { get; set; }
        [Index(2)]
        public string AcctId { get; set; }
        [Index(3)]
        public string AcctDsgnt { get; set; }
        [Index(4)]
        public string AcctSvcrId { get; set; }
        [Index(5)]
        public string OrdrRef { get; set; }
        [Index(6)]
        public string FundID { get; set; }
        [Index(7)]
        public int Nm { get; set; }
        [Index(8)]
        public int SplmtryId { get; set; }
        [Index(9)]
        public decimal? UnitsNb { get; set; }
        [Index(10)]
        public decimal? GrssAmt { get; set; }
        [Index(11)]
        public string GrssAmtCcy { get; set; }
        [Index(12)]
        public string Rndg { get; set; }
        [Index(13)]
        public bool PhysDlvryInd { get; set; }
        [Index(14)]
        public string ReqdSttlmCcy { get; set; }
        [Index(15)]
        public string ReqdNAVCcy { get; set; }
        [Index(16)]
        public string RltdPtyDtlsId { get; set; }
        [Index(17)]
        public string RltdPtyDtlsRole { get; set; }
        [Index(18)]
        public decimal? HldgsRedRate { get; set; }
        [Index(19)]
        public string Grp1Or2Units { get; set; }
    }
}
