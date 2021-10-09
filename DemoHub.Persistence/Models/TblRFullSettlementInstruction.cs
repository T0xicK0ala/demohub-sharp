using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_FullSettlementInstruction", Schema = "chsrep")]
    public partial class TblRFullSettlementInstruction
    {
        [Key]
        [Column("kFullSettlementInstruction")]
        public int KFullSettlementInstruction { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Required]
        [Column("sSecurityCode")]
        [StringLength(12)]
        public string SSecurityCode { get; set; }
        [Column("dSettlementAmount", TypeName = "decimal(13, 2)")]
        public decimal? DSettlementAmount { get; set; }
        [Column("dOutstandingSettlementAmount", TypeName = "decimal(13, 2)")]
        public decimal? DOutstandingSettlementAmount { get; set; }
        [Column("fkTransactionBasis")]
        public int FkTransactionBasis { get; set; }
        [Column("dtSettlementDate", TypeName = "date")]
        public DateTime DtSettlementDate { get; set; }
        [Column("sReceivingHIN")]
        [StringLength(10)]
        public string SReceivingHin { get; set; }
        [Column("sDeliveringHIN")]
        [StringLength(10)]
        public string SDeliveringHin { get; set; }
        [Column("fkReceivingPID")]
        public int FkReceivingPid { get; set; }
        [Column("fkDeliveringPID")]
        public int FkDeliveringPid { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("fkSettlementInstructionStatus")]
        public int FkSettlementInstructionStatus { get; set; }
        [Column("sParticipantReference")]
        [StringLength(16)]
        public string SParticipantReference { get; set; }
        [Column("sReceivingSupplementaryReference")]
        [StringLength(16)]
        public string SReceivingSupplementaryReference { get; set; }
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
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Column("sParentTransactionId")]
        [StringLength(16)]
        public string SParentTransactionId { get; set; }
        [Column("dUnitQuantity", TypeName = "decimal(11, 0)")]
        public decimal DUnitQuantity { get; set; }
        [Column("dOutstandingUnitQuantity", TypeName = "decimal(11, 0)")]
        public decimal? DOutstandingUnitQuantity { get; set; }
        [Column("sDeliveringSupplementaryReference")]
        [StringLength(16)]
        public string SDeliveringSupplementaryReference { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("dStampingConsideration", TypeName = "decimal(12, 2)")]
        public decimal? DStampingConsideration { get; set; }
        [Column("dDutyPayable", TypeName = "decimal(12, 2)")]
        public decimal? DDutyPayable { get; set; }
        [Column("fkDutyType")]
        public int? FkDutyType { get; set; }
        [Column("sUnderlyingReference")]
        [StringLength(16)]
        public string SUnderlyingReference { get; set; }
        [Column("dtInitialTimestamp", TypeName = "date")]
        public DateTime DtInitialTimestamp { get; set; }
        [Column("tInitialTimestamp", TypeName = "time(0)")]
        public TimeSpan TInitialTimestamp { get; set; }
        [Column("sCancellingTransactionId")]
        [StringLength(16)]
        public string SCancellingTransactionId { get; set; }
        [Column("sMatchingTransactionId")]
        [StringLength(16)]
        public string SMatchingTransactionId { get; set; }
        [Column("dtSettledTimestamp", TypeName = "date")]
        public DateTime? DtSettledTimestamp { get; set; }
        [Column("tSettledTimestamp", TypeName = "time(0)")]
        public TimeSpan? TSettledTimestamp { get; set; }
        [Column("sReceivingNetMovementTransactionId")]
        [StringLength(16)]
        public string SReceivingNetMovementTransactionId { get; set; }
        [Column("dtScheduledTimestamp", TypeName = "date")]
        public DateTime? DtScheduledTimestamp { get; set; }
        [Column("tScheduledTimestamp", TypeName = "time(0)")]
        public TimeSpan? TScheduledTimestamp { get; set; }
        [Column("sDeliveringNetMovementTransactionId")]
        [StringLength(16)]
        public string SDeliveringNetMovementTransactionId { get; set; }
        [Column("sNettedObligationTransactionId")]
        [StringLength(16)]
        public string SNettedObligationTransactionId { get; set; }
        [Column("sNetFundsTransactionId")]
        [StringLength(16)]
        public string SNetFundsTransactionId { get; set; }
        [Column("dtCancelledTimestamp", TypeName = "date")]
        public DateTime? DtCancelledTimestamp { get; set; }
        [Column("tCancelledTimestamp", TypeName = "time(0)")]
        public TimeSpan? TCancelledTimestamp { get; set; }
        [Column("fkGuaranteedForeignIndicator")]
        public int? FkGuaranteedForeignIndicator { get; set; }
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
        [InverseProperty(nameof(TblDChessmFundUser.TblRFullSettlementInstructionFkDeliveringP))]
        public virtual TblDChessmFundUser FkDeliveringP { get; set; }
        [ForeignKey(nameof(FkDutyType))]
        [InverseProperty(nameof(TblSDutyType.TblRFullSettlementInstruction))]
        public virtual TblSDutyType FkDutyTypeNavigation { get; set; }
        [ForeignKey(nameof(FkGuaranteedForeignIndicator))]
        [InverseProperty(nameof(TblSGuaranteedForeignIndicator.TblRFullSettlementInstruction))]
        public virtual TblSGuaranteedForeignIndicator FkGuaranteedForeignIndicatorNavigation { get; set; }
        [ForeignKey(nameof(FkReceivingPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRFullSettlementInstructionFkReceivingP))]
        public virtual TblDChessmFundUser FkReceivingP { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRFullSettlementInstruction))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
        [ForeignKey(nameof(FkSettlementInstructionStatus))]
        [InverseProperty(nameof(TblSSettlementInstructionStatus.TblRFullSettlementInstruction))]
        public virtual TblSSettlementInstructionStatus FkSettlementInstructionStatusNavigation { get; set; }
        [ForeignKey(nameof(FkTransactionBasis))]
        [InverseProperty(nameof(TblSTransactionBasis.TblRFullSettlementInstruction))]
        public virtual TblSTransactionBasis FkTransactionBasisNavigation { get; set; }
    }
}
