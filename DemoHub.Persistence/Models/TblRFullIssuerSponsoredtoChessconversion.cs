using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_FullIssuerSponsoredtoCHESSConversion", Schema = "chsrep")]
    public partial class TblRFullIssuerSponsoredtoChessconversion
    {
        [Key]
        [Column("kFullIssuerSponsoredtoCHESSConversion")]
        public int KFullIssuerSponsoredtoChessconversion { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Required]
        [Column("sSecurityCode")]
        [StringLength(12)]
        public string SSecurityCode { get; set; }
        [Column("fkReceivingHIN")]
        public int FkReceivingHin { get; set; }
        [Column("fkReceivingPID")]
        public int FkReceivingPid { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("fkHoldingTransactionStatus")]
        public int FkHoldingTransactionStatus { get; set; }
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
        [Required]
        [Column("sSRN")]
        [StringLength(12)]
        public string SSrn { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("dtInitialTimestamp", TypeName = "date")]
        public DateTime DtInitialTimestamp { get; set; }
        [Column("tInitialTimestamp", TypeName = "time(0)")]
        public TimeSpan TInitialTimestamp { get; set; }
        [Column("dtEffectedTimestamp", TypeName = "date")]
        public DateTime? DtEffectedTimestamp { get; set; }
        [Column("tEffectedTimestamp", TypeName = "time(0)")]
        public TimeSpan? TEffectedTimestamp { get; set; }
        [Column("dUnitQuantity", TypeName = "decimal(11, 0)")]
        public decimal? DUnitQuantity { get; set; }
        [Column("dNewHoldingBalance", TypeName = "decimal(11, 0)")]
        public decimal? DNewHoldingBalance { get; set; }
        [Column("sReceivingRegistrationDetails")]
        [StringLength(180)]
        public string SReceivingRegistrationDetails { get; set; }
        [Column("fkOverrideBasisofMovement1")]
        public int? FkOverrideBasisofMovement1 { get; set; }
        [Column("fkOverrideBasisofMovement2")]
        public int? FkOverrideBasisofMovement2 { get; set; }
        [Column("fkOverrideBasisofMovement3")]
        public int? FkOverrideBasisofMovement3 { get; set; }
        [Column("fkOverrideBasisofMovement4")]
        public int? FkOverrideBasisofMovement4 { get; set; }
        [Column("fkOverrideBasisofMovement5")]
        public int? FkOverrideBasisofMovement5 { get; set; }
        [Column("fkReceivingResidencyIndicator")]
        public int? FkReceivingResidencyIndicator { get; set; }
        [Column("fkGuaranteedForeignIndicator")]
        public int? FkGuaranteedForeignIndicator { get; set; }
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

        [ForeignKey(nameof(FkGuaranteedForeignIndicator))]
        [InverseProperty(nameof(TblSGuaranteedForeignIndicator.TblRFullIssuerSponsoredtoChessconversion))]
        public virtual TblSGuaranteedForeignIndicator FkGuaranteedForeignIndicatorNavigation { get; set; }
        [ForeignKey(nameof(FkHoldingTransactionStatus))]
        [InverseProperty(nameof(TblSHoldingTransactionStatus.TblRFullIssuerSponsoredtoChessconversion))]
        public virtual TblSHoldingTransactionStatus FkHoldingTransactionStatusNavigation { get; set; }
        [ForeignKey(nameof(FkLocationofRegister))]
        [InverseProperty(nameof(TblSAusState.TblRFullIssuerSponsoredtoChessconversion))]
        public virtual TblSAusState FkLocationofRegister1 { get; set; }
        [ForeignKey(nameof(FkLocationofRegister))]
        [InverseProperty(nameof(TblSCountry.TblRFullIssuerSponsoredtoChessconversion))]
        public virtual TblSCountry FkLocationofRegisterNavigation { get; set; }
        [ForeignKey(nameof(FkReceivingResidencyIndicator))]
        [InverseProperty(nameof(TblSResidencyIndicator.TblRFullIssuerSponsoredtoChessconversion))]
        public virtual TblSResidencyIndicator FkReceivingResidencyIndicatorNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRFullIssuerSponsoredtoChessconversion))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
