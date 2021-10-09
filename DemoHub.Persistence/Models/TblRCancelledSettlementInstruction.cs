using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_CancelledSettlementInstruction", Schema = "chsrep")]
    public partial class TblRCancelledSettlementInstruction
    {
        [Key]
        [Column("kCancelledSettlementInstruction")]
        public int KCancelledSettlementInstruction { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Required]
        [Column("sTargetTransactionId")]
        [StringLength(16)]
        public string STargetTransactionId { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Required]
        [Column("sCancellingTransactionId")]
        [StringLength(16)]
        public string SCancellingTransactionId { get; set; }
        [Column("sMatchingTransactionId")]
        [StringLength(16)]
        public string SMatchingTransactionId { get; set; }
        [Column("fkCancellationReason")]
        public int FkCancellationReason { get; set; }
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

        [ForeignKey(nameof(FkCancellationReason))]
        [InverseProperty(nameof(TblSCancellationReason.TblRCancelledSettlementInstruction))]
        public virtual TblSCancellationReason FkCancellationReasonNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRCancelledSettlementInstruction))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
