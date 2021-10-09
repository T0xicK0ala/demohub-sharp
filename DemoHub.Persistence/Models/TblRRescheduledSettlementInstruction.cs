using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_RescheduledSettlementInstruction", Schema = "chsrep")]
    public partial class TblRRescheduledSettlementInstruction
    {
        [Key]
        [Column("kRescheduledSettlementInstruction")]
        public int KRescheduledSettlementInstruction { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Column("dtSettlementDate", TypeName = "date")]
        public DateTime DtSettlementDate { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Required]
        [Column("sTargetTransactionId")]
        [StringLength(16)]
        public string STargetTransactionId { get; set; }
        [Column("fkRescheduleReason")]
        public int FkRescheduleReason { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Required]
        [Column("sUpdatingTransactionId")]
        [StringLength(16)]
        public string SUpdatingTransactionId { get; set; }
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

        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRRescheduledSettlementInstruction))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
        [ForeignKey(nameof(FkRescheduleReason))]
        [InverseProperty(nameof(TblSRescheduleReason.TblRRescheduledSettlementInstruction))]
        public virtual TblSRescheduleReason FkRescheduleReasonNavigation { get; set; }
    }
}
