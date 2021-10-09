using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_HoldingBalance", Schema = "chsrep")]
    public partial class TblRHoldingBalance
    {
        [Key]
        [Column("kHoldingBalance")]
        public int KHoldingBalance { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Required]
        [Column("sSecurityCode")]
        [StringLength(12)]
        public string SSecurityCode { get; set; }
        [Required]
        [Column("sHIN")]
        [StringLength(10)]
        public string SHin { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("dTotalUnitBalance", TypeName = "decimal(11, 0)")]
        public decimal? DTotalUnitBalance { get; set; }
        [Column("dTotalFundUnitBalance", TypeName = "decimal(12, 6)")]
        public decimal? DTotalFundUnitBalance { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("fkAdviceReason")]
        public int FkAdviceReason { get; set; }
        [Column("sAPIRCode")]
        [StringLength(9)]
        public string SApircode { get; set; }
        [Column("vCreatedBy")]
        public int VCreatedBy { get; set; }
        [Column("dt2CreatedAt")]
        public DateTime Dt2CreatedAt { get; set; }
        [Column("vUpdatedBy")]
        public int? VUpdatedBy { get; set; }
        [Column("dt2UpdatedAt")]
        public DateTime Dt2UpdatedAt { get; set; }
        [Required]
        [Column("zVersion")]
        public byte[] ZVersion { get; set; }

        [ForeignKey(nameof(FkAdviceReason))]
        [InverseProperty(nameof(TblSAdviceReason.TblRHoldingBalance))]
        public virtual TblSAdviceReason FkAdviceReasonNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRHoldingBalance))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
