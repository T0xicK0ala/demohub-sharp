using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_CHESSmFundUser", Schema = "chs")]
    public partial class TblDChessmFundUser
    {
        public TblDChessmFundUser()
        {
            TblDHolder = new HashSet<TblDHolder>();
            TblDIncomeStatementAuthorisationRequestFkP = new HashSet<TblDIncomeStatementAuthorisationRequest>();
            TblDIncomeStatementAuthorisationRequestFkTargetUicNavigation = new HashSet<TblDIncomeStatementAuthorisationRequest>();
            TblDReportRequest = new HashSet<TblDReportRequest>();
            TblDReportingRequestDetail = new HashSet<TblDReportingRequestDetail>();
            TblRChessconversionRequesttoIssuerSponsoredFund = new HashSet<TblRChessconversionRequesttoIssuerSponsoredFund>();
            TblRFullChesstoIssuerSponsoredConversion = new HashSet<TblRFullChesstoIssuerSponsoredConversion>();
            TblRFullSettlementInstructionFkDeliveringP = new HashSet<TblRFullSettlementInstruction>();
            TblRFullSettlementInstructionFkReceivingP = new HashSet<TblRFullSettlementInstruction>();
            TblRHolderDetail = new HashSet<TblRHolderDetail>();
            TblRHolderHistory = new HashSet<TblRHolderHistory>();
            TblRHoldingRegistrationDetails = new HashSet<TblRHoldingRegistrationDetails>();
            TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest = new HashSet<TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest>();
            TblRParticipantCounterpartyBalance = new HashSet<TblRParticipantCounterpartyBalance>();
            TblRPaymentFacilityDetailHistory = new HashSet<TblRPaymentFacilityDetailHistory>();
            TblRPeriodicIncomeStatement = new HashSet<TblRPeriodicIncomeStatement>();
            TblRRegistryIncomeStatementPartA = new HashSet<TblRRegistryIncomeStatementPartA>();
            TblRRegistryIncomeStatementPartB = new HashSet<TblRRegistryIncomeStatementPartB>();
            TblRRegistryIncomeStatementPartCai = new HashSet<TblRRegistryIncomeStatementPartCai>();
            TblRRegistryIncomeStatementPartCcg = new HashSet<TblRRegistryIncomeStatementPartCcg>();
            TblRRegistryIncomeStatementPartCfi = new HashSet<TblRRegistryIncomeStatementPartCfi>();
            TblRRegistryIncomeStatementPartCna = new HashSet<TblRRegistryIncomeStatementPartCna>();
            TblRRegistryIncomeStatementPartCod = new HashSet<TblRRegistryIncomeStatementPartCod>();
            TblRUserDetailHistoryFkMasterUicNavigation = new HashSet<TblRUserDetailHistory>();
            TblRUserDetailHistoryFkUicNavigation = new HashSet<TblRUserDetailHistory>();
        }

        [Key]
        [Column("kCHESSmFundUser")]
        public int KChessmFundUser { get; set; }
        [Required]
        [Column("sUIC")]
        [StringLength(5)]
        public string SUic { get; set; }
        [Column("bIsParticipant")]
        public bool BIsParticipant { get; set; }
        [Column("fkCHESSmFundUserType")]
        public int FkChessmFundUserType { get; set; }
        [Column("fkUserStatus")]
        public int FkUserStatus { get; set; }
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

        [ForeignKey(nameof(FkChessmFundUserType))]
        [InverseProperty(nameof(TblIChessmFundUserType.TblDChessmFundUser))]
        public virtual TblIChessmFundUserType FkChessmFundUserTypeNavigation { get; set; }
        [InverseProperty("FkControllingP")]
        public virtual ICollection<TblDHolder> TblDHolder { get; set; }
        [InverseProperty(nameof(TblDIncomeStatementAuthorisationRequest.FkP))]
        public virtual ICollection<TblDIncomeStatementAuthorisationRequest> TblDIncomeStatementAuthorisationRequestFkP { get; set; }
        [InverseProperty(nameof(TblDIncomeStatementAuthorisationRequest.FkTargetUicNavigation))]
        public virtual ICollection<TblDIncomeStatementAuthorisationRequest> TblDIncomeStatementAuthorisationRequestFkTargetUicNavigation { get; set; }
        [InverseProperty("FkP")]
        public virtual ICollection<TblDReportRequest> TblDReportRequest { get; set; }
        [InverseProperty("FkP")]
        public virtual ICollection<TblDReportingRequestDetail> TblDReportingRequestDetail { get; set; }
        [InverseProperty("FkDeliveringP")]
        public virtual ICollection<TblRChessconversionRequesttoIssuerSponsoredFund> TblRChessconversionRequesttoIssuerSponsoredFund { get; set; }
        [InverseProperty("FkDeliveringP")]
        public virtual ICollection<TblRFullChesstoIssuerSponsoredConversion> TblRFullChesstoIssuerSponsoredConversion { get; set; }
        [InverseProperty(nameof(TblRFullSettlementInstruction.FkDeliveringP))]
        public virtual ICollection<TblRFullSettlementInstruction> TblRFullSettlementInstructionFkDeliveringP { get; set; }
        [InverseProperty(nameof(TblRFullSettlementInstruction.FkReceivingP))]
        public virtual ICollection<TblRFullSettlementInstruction> TblRFullSettlementInstructionFkReceivingP { get; set; }
        [InverseProperty("FkControllingP")]
        public virtual ICollection<TblRHolderDetail> TblRHolderDetail { get; set; }
        [InverseProperty("FkControllingP")]
        public virtual ICollection<TblRHolderHistory> TblRHolderHistory { get; set; }
        [InverseProperty("FkControllingP")]
        public virtual ICollection<TblRHoldingRegistrationDetails> TblRHoldingRegistrationDetails { get; set; }
        [InverseProperty("FkReceivingP")]
        public virtual ICollection<TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest> TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest { get; set; }
        [InverseProperty("FkP")]
        public virtual ICollection<TblRParticipantCounterpartyBalance> TblRParticipantCounterpartyBalance { get; set; }
        [InverseProperty("FkP")]
        public virtual ICollection<TblRPaymentFacilityDetailHistory> TblRPaymentFacilityDetailHistory { get; set; }
        [InverseProperty("FkP")]
        public virtual ICollection<TblRPeriodicIncomeStatement> TblRPeriodicIncomeStatement { get; set; }
        [InverseProperty("FkP")]
        public virtual ICollection<TblRRegistryIncomeStatementPartA> TblRRegistryIncomeStatementPartA { get; set; }
        [InverseProperty("FkP")]
        public virtual ICollection<TblRRegistryIncomeStatementPartB> TblRRegistryIncomeStatementPartB { get; set; }
        [InverseProperty("FkP")]
        public virtual ICollection<TblRRegistryIncomeStatementPartCai> TblRRegistryIncomeStatementPartCai { get; set; }
        [InverseProperty("FkP")]
        public virtual ICollection<TblRRegistryIncomeStatementPartCcg> TblRRegistryIncomeStatementPartCcg { get; set; }
        [InverseProperty("FkP")]
        public virtual ICollection<TblRRegistryIncomeStatementPartCfi> TblRRegistryIncomeStatementPartCfi { get; set; }
        [InverseProperty("FkP")]
        public virtual ICollection<TblRRegistryIncomeStatementPartCna> TblRRegistryIncomeStatementPartCna { get; set; }
        [InverseProperty("FkP")]
        public virtual ICollection<TblRRegistryIncomeStatementPartCod> TblRRegistryIncomeStatementPartCod { get; set; }
        [InverseProperty(nameof(TblRUserDetailHistory.FkMasterUicNavigation))]
        public virtual ICollection<TblRUserDetailHistory> TblRUserDetailHistoryFkMasterUicNavigation { get; set; }
        [InverseProperty(nameof(TblRUserDetailHistory.FkUicNavigation))]
        public virtual ICollection<TblRUserDetailHistory> TblRUserDetailHistoryFkUicNavigation { get; set; }
    }
}
