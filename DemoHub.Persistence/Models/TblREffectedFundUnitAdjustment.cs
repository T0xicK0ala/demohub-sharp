using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_EffectedFundUnitAdjustment", Schema = "chsrep")]
    public partial class TblREffectedFundUnitAdjustment
    {
        [Key]
        [Column("kEffectedFundUnitAdjustment")]
        public int KEffectedFundUnitAdjustment { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Required]
        [Column("sFundCode")]
        [StringLength(12)]
        public string SFundCode { get; set; }
        [Required]
        [Column("sHIN")]
        [StringLength(10)]
        public string SHin { get; set; }
        [Column("fkFundReason")]
        public int FkFundReason { get; set; }
        [Column("bIncreaseorDecrease")]
        public bool BIncreaseorDecrease { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("dtEffectedTimestamp", TypeName = "date")]
        public DateTime DtEffectedTimestamp { get; set; }
        [Column("tEffectedTimestamp", TypeName = "time(0)")]
        public TimeSpan TEffectedTimestamp { get; set; }
        [Column("dUnitPrice", TypeName = "decimal(6, 6)")]
        public decimal? DUnitPrice { get; set; }
        [Column("sRegistryReference")]
        [StringLength(16)]
        public string SRegistryReference { get; set; }
        [Column("dAdjustmentUnits", TypeName = "decimal(12, 6)")]
        public decimal DAdjustmentUnits { get; set; }
        [Column("dNewFundHoldingBalance", TypeName = "decimal(12, 6)")]
        public decimal DNewFundHoldingBalance { get; set; }
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

        [ForeignKey(nameof(FkFundReason))]
        [InverseProperty(nameof(TblSFundReason.TblREffectedFundUnitAdjustment))]
        public virtual TblSFundReason FkFundReasonNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblREffectedFundUnitAdjustment))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
