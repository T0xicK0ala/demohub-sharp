using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_SettledSettlementInstruction", Schema = "chsrep")]
    public partial class TblRSettledSettlementInstruction
    {
        [Key]
        [Column("kSettledSettlementInstruction")]
        public int KSettledSettlementInstruction { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("dtSettledTimestamp", TypeName = "date")]
        public DateTime DtSettledTimestamp { get; set; }
        [Column("tSettledTimestamp", TypeName = "time(0)")]
        public TimeSpan TSettledTimestamp { get; set; }
        [Column("sReceivingNetMovementTransactionId")]
        [StringLength(16)]
        public string SReceivingNetMovementTransactionId { get; set; }
        [Column("sDeliveringNetMovementTransactionId")]
        [StringLength(16)]
        public string SDeliveringNetMovementTransactionId { get; set; }
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

        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRSettledSettlementInstruction))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
