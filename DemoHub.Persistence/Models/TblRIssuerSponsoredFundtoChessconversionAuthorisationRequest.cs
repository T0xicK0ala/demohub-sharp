using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_IssuerSponsoredFundtoCHESSConversionAuthorisationRequest", Schema = "chsrep")]
    public partial class TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest
    {
        [Key]
        [Column("kIssuerSponsoredFundtoCHESSConversionAuthorisationRequest")]
        public int KIssuerSponsoredFundtoChessconversionAuthorisationRequest { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Required]
        [Column("sFundCode")]
        [StringLength(12)]
        public string SFundCode { get; set; }
        [Required]
        [Column("sReceivingHIN")]
        [StringLength(10)]
        public string SReceivingHin { get; set; }
        [Column("fkReceivingPID")]
        public int FkReceivingPid { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("fkMovementReason")]
        public int FkMovementReason { get; set; }
        [Column("fkBrokerNonbrokerIndicator")]
        public int FkBrokerNonbrokerIndicator { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Required]
        [Column("sSRN")]
        [StringLength(12)]
        public string SSrn { get; set; }
        [Required]
        [Column("sReceivingRegistrationDetails")]
        [StringLength(180)]
        public string SReceivingRegistrationDetails { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
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
        [InverseProperty(nameof(TblSBrokerNonBrokerIndicator.TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest))]
        public virtual TblSBrokerNonBrokerIndicator FkBrokerNonbrokerIndicatorNavigation { get; set; }
        [ForeignKey(nameof(FkReceivingPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest))]
        public virtual TblDChessmFundUser FkReceivingP { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
