using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_EffectedConversionIssuerSponsoredFundtoCHESS", Schema = "chsrep")]
    public partial class TblREffectedConversionIssuerSponsoredFundtoChess
    {
        [Key]
        [Column("kEffectedConversionIssuerSponsoredFundtoCHESS")]
        public int KEffectedConversionIssuerSponsoredFundtoChess { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("sRegistryReference")]
        [StringLength(16)]
        public string SRegistryReference { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("dNewFundHoldingBalance", TypeName = "decimal(12, 6)")]
        public decimal DNewFundHoldingBalance { get; set; }
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
        [InverseProperty(nameof(TblDReportRequest.TblREffectedConversionIssuerSponsoredFundtoChess))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
