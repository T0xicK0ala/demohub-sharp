using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_EffectedNetFundsMovement", Schema = "chsrep")]
    public partial class TblREffectedNetFundsMovement
    {
        [Key]
        [Column("kEffectedNetFundsMovement")]
        public int KEffectedNetFundsMovement { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Column("dSettlementAmount", TypeName = "decimal(13, 2)")]
        public decimal DSettlementAmount { get; set; }
        [Column("dtSettlementDate", TypeName = "date")]
        public DateTime DtSettlementDate { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Required]
        [Column("sPaymentFacilityId")]
        [StringLength(6)]
        public string SPaymentFacilityId { get; set; }
        [Column("fkPayReceiveIndicator")]
        public int FkPayReceiveIndicator { get; set; }
        [Required]
        [Column("sTotalMessageCount")]
        [StringLength(11)]
        public string STotalMessageCount { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Required]
        [Column("sNetFundsTransactionId")]
        [StringLength(16)]
        public string SNetFundsTransactionId { get; set; }
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

        [ForeignKey(nameof(FkPayReceiveIndicator))]
        [InverseProperty(nameof(TblSPayReceiveIndicator.TblREffectedNetFundsMovement))]
        public virtual TblSPayReceiveIndicator FkPayReceiveIndicatorNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblREffectedNetFundsMovement))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
