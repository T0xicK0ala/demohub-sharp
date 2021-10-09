using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_ReportRequest", Schema = "chsrep")]
    public partial class TblDReportRequest
    {
        public TblDReportRequest()
        {
            TblDReportingRequestDetail = new HashSet<TblDReportingRequestDetail>();
            TblRCancelledSettlementInstruction = new HashSet<TblRCancelledSettlementInstruction>();
            TblRChessconversionRequesttoIssuerSponsoredFund = new HashSet<TblRChessconversionRequesttoIssuerSponsoredFund>();
            TblREffectedChessconversiontoIssuerSponsoredFund = new HashSet<TblREffectedChessconversiontoIssuerSponsoredFund>();
            TblREffectedConversionIssuerSponsoredFundtoChess = new HashSet<TblREffectedConversionIssuerSponsoredFundtoChess>();
            TblREffectedFundUnitAdjustment = new HashSet<TblREffectedFundUnitAdjustment>();
            TblREffectedNetFundsMovement = new HashSet<TblREffectedNetFundsMovement>();
            TblRFullAdjustedSettlementInstruction = new HashSet<TblRFullAdjustedSettlementInstruction>();
            TblRFullChesstoIssuerSponsoredConversion = new HashSet<TblRFullChesstoIssuerSponsoredConversion>();
            TblRFullIssuerSponsoredtoChessconversion = new HashSet<TblRFullIssuerSponsoredtoChessconversion>();
            TblRFullSettlementInstruction = new HashSet<TblRFullSettlementInstruction>();
            TblRHolderDetail = new HashSet<TblRHolderDetail>();
            TblRHolderHistory = new HashSet<TblRHolderHistory>();
            TblRHoldingBalance = new HashSet<TblRHoldingBalance>();
            TblRHoldingDailyBalance = new HashSet<TblRHoldingDailyBalance>();
            TblRHoldingNetMovement = new HashSet<TblRHoldingNetMovement>();
            TblRHoldingRegistrationDetails = new HashSet<TblRHoldingRegistrationDetails>();
            TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest = new HashSet<TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest>();
            TblRParticipantCounterpartyBalance = new HashSet<TblRParticipantCounterpartyBalance>();
            TblRPaymentFacilityDetailHistory = new HashSet<TblRPaymentFacilityDetailHistory>();
            TblRRescheduledSettlementInstruction = new HashSet<TblRRescheduledSettlementInstruction>();
            TblRSettledSettlementInstruction = new HashSet<TblRSettledSettlementInstruction>();
            TblRTopSecurityHolderReport = new HashSet<TblRTopSecurityHolderReport>();
            TblRTotalSecurityBalance = new HashSet<TblRTotalSecurityBalance>();
            TblRUserDetailHistory = new HashSet<TblRUserDetailHistory>();
        }

        [Key]
        [Column("kReportRequest")]
        public int KReportRequest { get; set; }
        [Column("bIsAccepted")]
        public bool? BIsAccepted { get; set; }
        [Column("bEndofReporting")]
        public bool? BEndofReporting { get; set; }
        [Column("sPSecurityCode")]
        [StringLength(12)]
        public string SPsecurityCode { get; set; }
        [Column("fkPCorporateActionTypeId")]
        public int? FkPcorporateActionTypeId { get; set; }
        [Column("dtReportingStartDate", TypeName = "date")]
        public DateTime? DtReportingStartDate { get; set; }
        [Column("dtReportingEndDate", TypeName = "date")]
        public DateTime? DtReportingEndDate { get; set; }
        [Column("sPHIN")]
        [StringLength(10)]
        public string SPhin { get; set; }
        [Column("fkPID")]
        public int? FkPid { get; set; }
        [Column("sPPaymentFacility")]
        [StringLength(6)]
        public string SPpaymentFacility { get; set; }
        [Column("fkPSubpositionType")]
        public int? FkPsubpositionType { get; set; }
        [Column("sPTakeoverCode")]
        [StringLength(6)]
        public string SPtakeoverCode { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Column("sPTransactionId")]
        [StringLength(16)]
        public string SPtransactionId { get; set; }
        [Column("fkReportingId")]
        public int FkReportingId { get; set; }
        [Column("fkProcessingFrequency")]
        public int FkProcessingFrequency { get; set; }
        [Column("dtPExDate", TypeName = "date")]
        public DateTime? DtPexDate { get; set; }
        [Column("sPNumberofDays")]
        [StringLength(3)]
        public string SPnumberofDays { get; set; }
        [Column("fkPPositionType")]
        public int? FkPpositionType { get; set; }
        [Column("fkProcessingPoint")]
        public int? FkProcessingPoint { get; set; }
        [Column("fkProcessingPeriod")]
        public int? FkProcessingPeriod { get; set; }
        [Column("dtPStartDate", TypeName = "date")]
        public DateTime? DtPstartDate { get; set; }
        [Column("dtPEndDate", TypeName = "date")]
        public DateTime? DtPendDate { get; set; }
        [Column("dtPAsAtDate", TypeName = "date")]
        public DateTime? DtPasAtDate { get; set; }
        [Column("fkPReportingId")]
        public int? FkPreportingId { get; set; }
        [Column("fkPTransactionClass")]
        public int? FkPtransactionClass { get; set; }
        [Column("fkPAdditionalReporting")]
        public int? FkPadditionalReporting { get; set; }
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

        [ForeignKey(nameof(FkPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblDReportRequest))]
        public virtual TblDChessmFundUser FkP { get; set; }
        [ForeignKey(nameof(FkPadditionalReporting))]
        [InverseProperty(nameof(TblSAdditionalReportingParameter.TblDReportRequest))]
        public virtual TblSAdditionalReportingParameter FkPadditionalReportingNavigation { get; set; }
        [ForeignKey(nameof(FkPcorporateActionTypeId))]
        [InverseProperty(nameof(TblSCorporateActionTypeId.TblDReportRequest))]
        public virtual TblSCorporateActionTypeId FkPcorporateActionType { get; set; }
        [ForeignKey(nameof(FkPpositionType))]
        [InverseProperty(nameof(TblSPositionTypeParameter.TblDReportRequest))]
        public virtual TblSPositionTypeParameter FkPpositionTypeNavigation { get; set; }
        [ForeignKey(nameof(FkPreportingId))]
        [InverseProperty(nameof(TblSReportingId.TblDReportRequestFkPreporting))]
        public virtual TblSReportingId FkPreporting { get; set; }
        [ForeignKey(nameof(FkProcessingFrequency))]
        [InverseProperty(nameof(TblSProcessingFrequency.TblDReportRequest))]
        public virtual TblSProcessingFrequency FkProcessingFrequencyNavigation { get; set; }
        [ForeignKey(nameof(FkProcessingPeriod))]
        [InverseProperty(nameof(TblSProcessingPeriod.TblDReportRequest))]
        public virtual TblSProcessingPeriod FkProcessingPeriodNavigation { get; set; }
        [ForeignKey(nameof(FkProcessingPoint))]
        [InverseProperty(nameof(TblSProcessingPoint.TblDReportRequest))]
        public virtual TblSProcessingPoint FkProcessingPointNavigation { get; set; }
        [ForeignKey(nameof(FkPsubpositionType))]
        [InverseProperty(nameof(TblSSubpositionType.TblDReportRequest))]
        public virtual TblSSubpositionType FkPsubpositionTypeNavigation { get; set; }
        [ForeignKey(nameof(FkPtransactionClass))]
        [InverseProperty(nameof(TblSTransactionClassParameter.TblDReportRequest))]
        public virtual TblSTransactionClassParameter FkPtransactionClassNavigation { get; set; }
        [ForeignKey(nameof(FkReportingId))]
        [InverseProperty(nameof(TblSReportingId.TblDReportRequestFkReporting))]
        public virtual TblSReportingId FkReporting { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblDReportingRequestDetail> TblDReportingRequestDetail { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRCancelledSettlementInstruction> TblRCancelledSettlementInstruction { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRChessconversionRequesttoIssuerSponsoredFund> TblRChessconversionRequesttoIssuerSponsoredFund { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblREffectedChessconversiontoIssuerSponsoredFund> TblREffectedChessconversiontoIssuerSponsoredFund { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblREffectedConversionIssuerSponsoredFundtoChess> TblREffectedConversionIssuerSponsoredFundtoChess { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblREffectedFundUnitAdjustment> TblREffectedFundUnitAdjustment { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblREffectedNetFundsMovement> TblREffectedNetFundsMovement { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRFullAdjustedSettlementInstruction> TblRFullAdjustedSettlementInstruction { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRFullChesstoIssuerSponsoredConversion> TblRFullChesstoIssuerSponsoredConversion { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRFullIssuerSponsoredtoChessconversion> TblRFullIssuerSponsoredtoChessconversion { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRFullSettlementInstruction> TblRFullSettlementInstruction { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRHolderDetail> TblRHolderDetail { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRHolderHistory> TblRHolderHistory { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRHoldingBalance> TblRHoldingBalance { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRHoldingDailyBalance> TblRHoldingDailyBalance { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRHoldingNetMovement> TblRHoldingNetMovement { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRHoldingRegistrationDetails> TblRHoldingRegistrationDetails { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest> TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRParticipantCounterpartyBalance> TblRParticipantCounterpartyBalance { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRPaymentFacilityDetailHistory> TblRPaymentFacilityDetailHistory { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRRescheduledSettlementInstruction> TblRRescheduledSettlementInstruction { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRSettledSettlementInstruction> TblRSettledSettlementInstruction { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRTopSecurityHolderReport> TblRTopSecurityHolderReport { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRTotalSecurityBalance> TblRTotalSecurityBalance { get; set; }
        [InverseProperty("FkReportRequestNavigation")]
        public virtual ICollection<TblRUserDetailHistory> TblRUserDetailHistory { get; set; }
    }
}
