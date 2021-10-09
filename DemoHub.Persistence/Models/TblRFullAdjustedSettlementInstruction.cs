using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_FullAdjustedSettlementInstruction", Schema = "chsrep")]
    public partial class TblRFullAdjustedSettlementInstruction
    {
        [Key]
        [Column("kFullAdjustedSettlementInstruction")]
        public int KFullAdjustedSettlementInstruction { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Column("sPreviousSecurityCode")]
        [StringLength(12)]
        public string SPreviousSecurityCode { get; set; }
        [Column("dPreviousSettlementAmount", TypeName = "decimal(13, 2)")]
        public decimal? DPreviousSettlementAmount { get; set; }
        [Column("dRevisedSettlementAmount", TypeName = "decimal(13, 2)")]
        public decimal? DRevisedSettlementAmount { get; set; }
        [Column("fkCorporateActionTypeId")]
        public int? FkCorporateActionTypeId { get; set; }
        [Column("sRevisedSecurityCode")]
        [StringLength(12)]
        public string SRevisedSecurityCode { get; set; }
        [Column("fkPreviousTransactionBasis")]
        public int? FkPreviousTransactionBasis { get; set; }
        [Column("dtPreviousSettlementDate", TypeName = "date")]
        public DateTime? DtPreviousSettlementDate { get; set; }
        [Column("dtRevisedSettlementDate", TypeName = "date")]
        public DateTime? DtRevisedSettlementDate { get; set; }
        [Column("sPreviousDeliveringHIN")]
        [StringLength(10)]
        public string SPreviousDeliveringHin { get; set; }
        [Column("sPreviousReceivingHIN")]
        [StringLength(10)]
        public string SPreviousReceivingHin { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("fkRevisedStatus")]
        public int? FkRevisedStatus { get; set; }
        [Column("fkPreviousStatus")]
        public int? FkPreviousStatus { get; set; }
        [Column("fkPreviousOverrideBasisofMove1")]
        public int? FkPreviousOverrideBasisofMove1 { get; set; }
        [Column("fkPreviousOverrideBasisofMove2")]
        public int? FkPreviousOverrideBasisofMove2 { get; set; }
        [Column("fkPreviousOverrideBasisofMove3")]
        public int? FkPreviousOverrideBasisofMove3 { get; set; }
        [Column("fkPreviousOverrideBasisofMove4")]
        public int? FkPreviousOverrideBasisofMove4 { get; set; }
        [Column("fkPreviousOverrideBasisofMove5")]
        public int? FkPreviousOverrideBasisofMove5 { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Column("dPreviousUnitQuantity", TypeName = "decimal(11, 0)")]
        public decimal? DPreviousUnitQuantity { get; set; }
        [Column("dRevisedUnitQuantity", TypeName = "decimal(11, 0)")]
        public decimal? DRevisedUnitQuantity { get; set; }
        [Column("sRevisedUnderlyingReference")]
        [StringLength(16)]
        public string SRevisedUnderlyingReference { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("sRevisedDeliveringHIN")]
        [StringLength(10)]
        public string SRevisedDeliveringHin { get; set; }
        [Column("dPreviousStampingConsideration", TypeName = "decimal(12, 2)")]
        public decimal? DPreviousStampingConsideration { get; set; }
        [Column("dRevisedStampingConsideration", TypeName = "decimal(12, 2)")]
        public decimal? DRevisedStampingConsideration { get; set; }
        [Column("fkPreviousDutyType")]
        public int? FkPreviousDutyType { get; set; }
        [Column("sPreviousUnderlyingReference")]
        [StringLength(16)]
        public string SPreviousUnderlyingReference { get; set; }
        [Column("dtExDate", TypeName = "date")]
        public DateTime? DtExDate { get; set; }
        [Column("fkDiaryAdjustmentType")]
        public int? FkDiaryAdjustmentType { get; set; }
        [Column("sDiaryAdjustmentNumber")]
        [StringLength(1)]
        public string SDiaryAdjustmentNumber { get; set; }
        [Column("dtTimestamp", TypeName = "date")]
        public DateTime DtTimestamp { get; set; }
        [Column("tTimestamp", TypeName = "time(0)")]
        public TimeSpan TTimestamp { get; set; }
        [Column("sCancellingTransactionId")]
        [StringLength(16)]
        public string SCancellingTransactionId { get; set; }
        [Column("sMatchingTransactionId")]
        [StringLength(16)]
        public string SMatchingTransactionId { get; set; }
        [Column("dtMatchedTimestamp", TypeName = "date")]
        public DateTime? DtMatchedTimestamp { get; set; }
        [Column("tMatchedTimestamp", TypeName = "time(0)")]
        public TimeSpan? TMatchedTimestamp { get; set; }
        [Required]
        [Column("sUpdatingTransactionId")]
        [StringLength(16)]
        public string SUpdatingTransactionId { get; set; }
        [Column("fkAdjustmentHistoryStatus")]
        public int FkAdjustmentHistoryStatus { get; set; }
        [Column("sAccrualNumber")]
        [StringLength(2)]
        public string SAccrualNumber { get; set; }
        [Column("fkAdjustmentReason")]
        public int FkAdjustmentReason { get; set; }
        [Column("dtCancelledTimestamp", TypeName = "date")]
        public DateTime? DtCancelledTimestamp { get; set; }
        [Column("tCancelledTimestamp", TypeName = "time(0)")]
        public TimeSpan? TCancelledTimestamp { get; set; }
        [Column("fkRevisedOverrideBasisofMove1")]
        public int? FkRevisedOverrideBasisofMove1 { get; set; }
        [Column("fkRevisedOverrideBasisofMove2")]
        public int? FkRevisedOverrideBasisofMove2 { get; set; }
        [Column("fkRevisedOverrideBasisofMove3")]
        public int? FkRevisedOverrideBasisofMove3 { get; set; }
        [Column("fkRevisedOverrideBasisofMove4")]
        public int? FkRevisedOverrideBasisofMove4 { get; set; }
        [Column("fkRevisedOverrideBasisofMove5")]
        public int? FkRevisedOverrideBasisofMove5 { get; set; }
        [Column("fkRevisedDutyType")]
        public int? FkRevisedDutyType { get; set; }
        [Column("dPreviousDutyPayable", TypeName = "decimal(12, 2)")]
        public decimal? DPreviousDutyPayable { get; set; }
        [Column("dRevisedDutyPayable", TypeName = "decimal(12, 2)")]
        public decimal? DRevisedDutyPayable { get; set; }
        [Column("sRevisedReceivingHIN")]
        [StringLength(10)]
        public string SRevisedReceivingHin { get; set; }
        [Column("fkRevisedTransactionBasis")]
        public int? FkRevisedTransactionBasis { get; set; }
        [Column("fkPreviousGuaranteedForeignIndicator")]
        public int? FkPreviousGuaranteedForeignIndicator { get; set; }
        [Column("fkRevisedGuaranteedForeignIndicator")]
        public int? FkRevisedGuaranteedForeignIndicator { get; set; }
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

        [ForeignKey(nameof(FkAdjustmentHistoryStatus))]
        [InverseProperty(nameof(TblSAdjustmentHistoryStatus.TblRFullAdjustedSettlementInstruction))]
        public virtual TblSAdjustmentHistoryStatus FkAdjustmentHistoryStatusNavigation { get; set; }
        [ForeignKey(nameof(FkAdjustmentReason))]
        [InverseProperty(nameof(TblSAdjustmentReason.TblRFullAdjustedSettlementInstruction))]
        public virtual TblSAdjustmentReason FkAdjustmentReasonNavigation { get; set; }
        [ForeignKey(nameof(FkCorporateActionTypeId))]
        [InverseProperty(nameof(TblSCorporateActionTypeId.TblRFullAdjustedSettlementInstruction))]
        public virtual TblSCorporateActionTypeId FkCorporateActionType { get; set; }
        [ForeignKey(nameof(FkDiaryAdjustmentType))]
        [InverseProperty(nameof(TblSDiaryAdjustmentType.TblRFullAdjustedSettlementInstruction))]
        public virtual TblSDiaryAdjustmentType FkDiaryAdjustmentTypeNavigation { get; set; }
        [ForeignKey(nameof(FkPreviousDutyType))]
        [InverseProperty(nameof(TblSDutyType.TblRFullAdjustedSettlementInstructionFkPreviousDutyTypeNavigation))]
        public virtual TblSDutyType FkPreviousDutyTypeNavigation { get; set; }
        [ForeignKey(nameof(FkPreviousGuaranteedForeignIndicator))]
        [InverseProperty(nameof(TblSGuaranteedForeignIndicator.TblRFullAdjustedSettlementInstructionFkPreviousGuaranteedForeignIndicatorNavigation))]
        public virtual TblSGuaranteedForeignIndicator FkPreviousGuaranteedForeignIndicatorNavigation { get; set; }
        [ForeignKey(nameof(FkPreviousStatus))]
        [InverseProperty(nameof(TblSSettlementInstructionStatus.TblRFullAdjustedSettlementInstructionFkPreviousStatusNavigation))]
        public virtual TblSSettlementInstructionStatus FkPreviousStatusNavigation { get; set; }
        [ForeignKey(nameof(FkPreviousTransactionBasis))]
        [InverseProperty(nameof(TblSTransactionBasis.TblRFullAdjustedSettlementInstructionFkPreviousTransactionBasisNavigation))]
        public virtual TblSTransactionBasis FkPreviousTransactionBasisNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRFullAdjustedSettlementInstruction))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
        [ForeignKey(nameof(FkRevisedDutyType))]
        [InverseProperty(nameof(TblSDutyType.TblRFullAdjustedSettlementInstructionFkRevisedDutyTypeNavigation))]
        public virtual TblSDutyType FkRevisedDutyTypeNavigation { get; set; }
        [ForeignKey(nameof(FkRevisedGuaranteedForeignIndicator))]
        [InverseProperty(nameof(TblSGuaranteedForeignIndicator.TblRFullAdjustedSettlementInstructionFkRevisedGuaranteedForeignIndicatorNavigation))]
        public virtual TblSGuaranteedForeignIndicator FkRevisedGuaranteedForeignIndicatorNavigation { get; set; }
        [ForeignKey(nameof(FkRevisedStatus))]
        [InverseProperty(nameof(TblSSettlementInstructionStatus.TblRFullAdjustedSettlementInstructionFkRevisedStatusNavigation))]
        public virtual TblSSettlementInstructionStatus FkRevisedStatusNavigation { get; set; }
        [ForeignKey(nameof(FkRevisedTransactionBasis))]
        [InverseProperty(nameof(TblSTransactionBasis.TblRFullAdjustedSettlementInstructionFkRevisedTransactionBasisNavigation))]
        public virtual TblSTransactionBasis FkRevisedTransactionBasisNavigation { get; set; }
    }
}
