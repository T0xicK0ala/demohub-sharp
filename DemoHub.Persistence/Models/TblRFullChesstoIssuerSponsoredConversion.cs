using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_FullCHESStoIssuerSponsoredConversion", Schema = "chsrep")]
    public partial class TblRFullChesstoIssuerSponsoredConversion
    {
        [Key]
        [Column("kFullCHESStoIssuerSponsoredConversion")]
        public int KFullChesstoIssuerSponsoredConversion { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Required]
        [Column("sSecurityCode")]
        [StringLength(12)]
        public string SSecurityCode { get; set; }
        [Column("sDeliveringHIN")]
        public int SDeliveringHin { get; set; }
        [Column("fkDeliveringPID")]
        public int FkDeliveringPid { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("fkHoldingTransactionStatus")]
        public int? FkHoldingTransactionStatus { get; set; }
        [Column("fkMovementReason")]
        public int FkMovementReason { get; set; }
        [Column("fkLocationofRegister")]
        public int? FkLocationofRegister { get; set; }
        [Column("sParticipantReference")]
        [StringLength(16)]
        public string SParticipantReference { get; set; }
        [Column("sSupplementaryReference")]
        [StringLength(16)]
        public string SSupplementaryReference { get; set; }
        [Column("fkBasisofMovement1")]
        public int? FkBasisofMovement1 { get; set; }
        [Column("fkBasisofMovement2")]
        public int? FkBasisofMovement2 { get; set; }
        [Column("fkBasisofMovement3")]
        public int? FkBasisofMovement3 { get; set; }
        [Column("fkBasisofMovement4")]
        public int? FkBasisofMovement4 { get; set; }
        [Column("fkBasisofMovement5")]
        public int? FkBasisofMovement5 { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Column("sSRN")]
        [StringLength(12)]
        public string SSrn { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("sReceivingRegistrationDetails")]
        [StringLength(180)]
        public string SReceivingRegistrationDetails { get; set; }
        [Column("dUnitQuantity", TypeName = "decimal(11, 0)")]
        public decimal? DUnitQuantity { get; set; }
        [Column("dNewHoldingBalance", TypeName = "decimal(11, 0)")]
        public decimal? DNewHoldingBalance { get; set; }
        [Column("sUnderlyingReference")]
        [StringLength(16)]
        public string SUnderlyingReference { get; set; }
        [Column("dtEffectedTimestamp", TypeName = "date")]
        public DateTime DtEffectedTimestamp { get; set; }
        [Column("tEffectedTimestamp", TypeName = "time(0)")]
        public TimeSpan TEffectedTimestamp { get; set; }
        [Column("fkGuaranteedForeignIndicator")]
        public int? FkGuaranteedForeignIndicator { get; set; }
        [Column("sTFN_ABN1")]
        [StringLength(12)]
        public string STfnAbn1 { get; set; }
        [Column("sTFN_ABN2")]
        [StringLength(12)]
        public string STfnAbn2 { get; set; }
        [Column("sTFN_ABN3")]
        [StringLength(12)]
        public string STfnAbn3 { get; set; }
        [Column("dNumberOfUnits", TypeName = "decimal(12, 6)")]
        public decimal? DNumberOfUnits { get; set; }
        [Column("dNewFundHoldingBalance", TypeName = "decimal(12, 6)")]
        public decimal? DNewFundHoldingBalance { get; set; }
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

        [ForeignKey(nameof(FkDeliveringPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRFullChesstoIssuerSponsoredConversion))]
        public virtual TblDChessmFundUser FkDeliveringP { get; set; }
        [ForeignKey(nameof(FkGuaranteedForeignIndicator))]
        [InverseProperty(nameof(TblSGuaranteedForeignIndicator.TblRFullChesstoIssuerSponsoredConversion))]
        public virtual TblSGuaranteedForeignIndicator FkGuaranteedForeignIndicatorNavigation { get; set; }
        [ForeignKey(nameof(FkHoldingTransactionStatus))]
        [InverseProperty(nameof(TblSHoldingTransactionStatus.TblRFullChesstoIssuerSponsoredConversion))]
        public virtual TblSHoldingTransactionStatus FkHoldingTransactionStatusNavigation { get; set; }
        [ForeignKey(nameof(FkLocationofRegister))]
        [InverseProperty(nameof(TblSAusState.TblRFullChesstoIssuerSponsoredConversion))]
        public virtual TblSAusState FkLocationofRegister1 { get; set; }
        [ForeignKey(nameof(FkLocationofRegister))]
        [InverseProperty(nameof(TblSCountry.TblRFullChesstoIssuerSponsoredConversion))]
        public virtual TblSCountry FkLocationofRegisterNavigation { get; set; }
        [ForeignKey(nameof(FkMovementReason))]
        [InverseProperty(nameof(TblSMovementReason.TblRFullChesstoIssuerSponsoredConversion))]
        public virtual TblSMovementReason FkMovementReasonNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRFullChesstoIssuerSponsoredConversion))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
        [ForeignKey(nameof(SDeliveringHin))]
        [InverseProperty(nameof(TblDHolder.TblRFullChesstoIssuerSponsoredConversion))]
        public virtual TblDHolder SDeliveringHinNavigation { get; set; }
    }
}
