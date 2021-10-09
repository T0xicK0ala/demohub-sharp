using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_EffectedCHESSConversiontoIssuerSponsoredFund", Schema = "chsrep")]
    public partial class TblREffectedChessconversiontoIssuerSponsoredFund
    {
        [Key]
        [Column("kEffectedCHESSConversiontoIssuerSponsoredFund")]
        public int KEffectedChessconversiontoIssuerSponsoredFund { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Required]
        [Column("sFundCode")]
        [StringLength(12)]
        public string SFundCode { get; set; }
        [Required]
        [Column("sDeliveringHIN")]
        [StringLength(10)]
        public string SDeliveringHin { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("fkMovementReason")]
        public int? FkMovementReason { get; set; }
        [Column("sParticipantReference")]
        [StringLength(16)]
        public string SParticipantReference { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("dNumberofUnits", TypeName = "decimal(12, 6)")]
        public decimal DNumberofUnits { get; set; }
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

        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblREffectedChessconversiontoIssuerSponsoredFund))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
