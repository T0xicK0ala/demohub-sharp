using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_HoldingNetMovement", Schema = "chsrep")]
    public partial class TblRHoldingNetMovement
    {
        [Key]
        [Column("kHoldingNetMovement")]
        public int KHoldingNetMovement { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Required]
        [Column("sSecurityCode")]
        [StringLength(12)]
        public string SSecurityCode { get; set; }
        [Column("dtDate", TypeName = "date")]
        public DateTime DtDate { get; set; }
        [Required]
        [Column("sHIN")]
        [StringLength(10)]
        public string SHin { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("dNetOffs", TypeName = "decimal(11, 0)")]
        public decimal? DNetOffs { get; set; }
        [Column("dFundNetOffs", TypeName = "decimal(12, 6)")]
        public decimal? DFundNetOffs { get; set; }
        [Column("dNetOns", TypeName = "decimal(11, 0)")]
        public decimal? DNetOns { get; set; }
        [Column("dFundNetOns", TypeName = "decimal(12, 6)")]
        public decimal? DFundNetOns { get; set; }
        [Column("dClosingBalance", TypeName = "decimal(11, 0)")]
        public decimal? DClosingBalance { get; set; }
        [Column("dClosingFundBalance", TypeName = "decimal(12, 6)")]
        public decimal? DClosingFundBalance { get; set; }
        [Column("dMovementFromRegistry", TypeName = "decimal(11, 0)")]
        public decimal? DMovementFromRegistry { get; set; }
        [Column("dFundMovementFromRegistry", TypeName = "decimal(12, 6)")]
        public decimal? DFundMovementFromRegistry { get; set; }
        [Column("dMovementToRegistry", TypeName = "decimal(11, 0)")]
        public decimal? DMovementToRegistry { get; set; }
        [Column("dFundMovementToRegistry", TypeName = "decimal(12, 6)")]
        public decimal? DFundMovementToRegistry { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
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

        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRHoldingNetMovement))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
