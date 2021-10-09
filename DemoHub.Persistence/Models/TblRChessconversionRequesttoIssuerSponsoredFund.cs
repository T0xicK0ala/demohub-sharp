using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_CHESSConversionRequesttoIssuerSponsoredFund", Schema = "chsrep")]
    public partial class TblRChessconversionRequesttoIssuerSponsoredFund
    {
        [Key]
        [Column("kCHESSConversionRequesttoIssuerSponsoredFund")]
        public int KChessconversionRequesttoIssuerSponsoredFund { get; set; }
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
        [Column("fkDeliveringPID")]
        public int FkDeliveringPid { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("fkMovementReason")]
        public int FkMovementReason { get; set; }
        [Column("sParticipantReference")]
        [StringLength(16)]
        public string SParticipantReference { get; set; }
        [Column("sSupplementaryReference")]
        [StringLength(16)]
        public string SSupplementaryReference { get; set; }
        [Column("fkBrokerNonbrokerIndicator")]
        public int FkBrokerNonbrokerIndicator { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Column("sSRN")]
        [StringLength(12)]
        public string SSrn { get; set; }
        [Required]
        [Column("sDeliveringRegistrationDetails")]
        [StringLength(180)]
        public string SDeliveringRegistrationDetails { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("sTFN_ABN1")]
        [StringLength(12)]
        public string STfnAbn1 { get; set; }
        [Column("sTFN_ABN2")]
        [StringLength(12)]
        public string STfnAbn2 { get; set; }
        [Column("sTFN_ABN3")]
        [StringLength(12)]
        public string STfnAbn3 { get; set; }
        [Column("sEmailAddress")]
        [StringLength(50)]
        public string SEmailAddress { get; set; }
        [Column("fkEmailPurpose")]
        public int? FkEmailPurpose { get; set; }
        [Column("dNumberOfUnits", TypeName = "decimal(12, 6)")]
        public decimal DNumberOfUnits { get; set; }
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

        [ForeignKey(nameof(FkBrokerNonbrokerIndicator))]
        [InverseProperty(nameof(TblSBrokerNonBrokerIndicator.TblRChessconversionRequesttoIssuerSponsoredFund))]
        public virtual TblSBrokerNonBrokerIndicator FkBrokerNonbrokerIndicatorNavigation { get; set; }
        [ForeignKey(nameof(FkDeliveringPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRChessconversionRequesttoIssuerSponsoredFund))]
        public virtual TblDChessmFundUser FkDeliveringP { get; set; }
        [ForeignKey(nameof(FkEmailPurpose))]
        [InverseProperty(nameof(TblSEmailPurpose.TblRChessconversionRequesttoIssuerSponsoredFund))]
        public virtual TblSEmailPurpose FkEmailPurposeNavigation { get; set; }
        [ForeignKey(nameof(FkMovementReason))]
        [InverseProperty(nameof(TblSMovementReason.TblRChessconversionRequesttoIssuerSponsoredFund))]
        public virtual TblSMovementReason FkMovementReasonNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRChessconversionRequesttoIssuerSponsoredFund))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
