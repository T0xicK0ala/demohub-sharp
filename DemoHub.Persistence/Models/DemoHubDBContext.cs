using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoHub.Persistence.Models
{
    public partial class DemoHubDBContext : DbContext
    {
        public DemoHubDBContext()
        {
        }

        public DemoHubDBContext(DbContextOptions<DemoHubDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDAccount> TblDAccount { get; set; }
        public virtual DbSet<TblDCalastoneTransactionRequest> TblDCalastoneTransactionRequest { get; set; }
        public virtual DbSet<TblDChessmFundUser> TblDChessmFundUser { get; set; }
        public virtual DbSet<TblDChesstransactionRequest> TblDChesstransactionRequest { get; set; }
        public virtual DbSet<TblDForeignExchangeDetail> TblDForeignExchangeDetail { get; set; }
        public virtual DbSet<TblDHolder> TblDHolder { get; set; }
        public virtual DbSet<TblDIncomeStatementAuthorisationRequest> TblDIncomeStatementAuthorisationRequest { get; set; }
        public virtual DbSet<TblDIncomeStatementSet> TblDIncomeStatementSet { get; set; }
        public virtual DbSet<TblDInformativeTax> TblDInformativeTax { get; set; }
        public virtual DbSet<TblDPublicApitoken> TblDPublicApitoken { get; set; }
        public virtual DbSet<TblDRawMessage> TblDRawMessage { get; set; }
        public virtual DbSet<TblDReportRequest> TblDReportRequest { get; set; }
        public virtual DbSet<TblDReportingRequestDetail> TblDReportingRequestDetail { get; set; }
        public virtual DbSet<TblDTotalFeeAndTaxRequest> TblDTotalFeeAndTaxRequest { get; set; }
        public virtual DbSet<TblDTranIndvFee> TblDTranIndvFee { get; set; }
        public virtual DbSet<TblDTranIndvTax> TblDTranIndvTax { get; set; }
        public virtual DbSet<TblDTransaction> TblDTransaction { get; set; }
        public virtual DbSet<TblIChessmFundUserType> TblIChessmFundUserType { get; set; }
        public virtual DbSet<TblIChessmessageTypes> TblIChessmessageTypes { get; set; }
        public virtual DbSet<TblIFundIdtype> TblIFundIdtype { get; set; }
        public virtual DbSet<TblITransactionRequestStatus> TblITransactionRequestStatus { get; set; }
        public virtual DbSet<TblITransactionType> TblITransactionType { get; set; }
        public virtual DbSet<TblITransactionType1> TblITransactionType1 { get; set; }
        public virtual DbSet<TblLTransactionHolder> TblLTransactionHolder { get; set; }
        public virtual DbSet<TblRCancelledSettlementInstruction> TblRCancelledSettlementInstruction { get; set; }
        public virtual DbSet<TblRChessconversionRequesttoIssuerSponsoredFund> TblRChessconversionRequesttoIssuerSponsoredFund { get; set; }
        public virtual DbSet<TblREffectedChessconversiontoIssuerSponsoredFund> TblREffectedChessconversiontoIssuerSponsoredFund { get; set; }
        public virtual DbSet<TblREffectedConversionIssuerSponsoredFundtoChess> TblREffectedConversionIssuerSponsoredFundtoChess { get; set; }
        public virtual DbSet<TblREffectedFundUnitAdjustment> TblREffectedFundUnitAdjustment { get; set; }
        public virtual DbSet<TblREffectedNetFundsMovement> TblREffectedNetFundsMovement { get; set; }
        public virtual DbSet<TblRFullAdjustedSettlementInstruction> TblRFullAdjustedSettlementInstruction { get; set; }
        public virtual DbSet<TblRFullChesstoIssuerSponsoredConversion> TblRFullChesstoIssuerSponsoredConversion { get; set; }
        public virtual DbSet<TblRFullIssuerSponsoredtoChessconversion> TblRFullIssuerSponsoredtoChessconversion { get; set; }
        public virtual DbSet<TblRFullSettlementInstruction> TblRFullSettlementInstruction { get; set; }
        public virtual DbSet<TblRHolderDetail> TblRHolderDetail { get; set; }
        public virtual DbSet<TblRHolderHistory> TblRHolderHistory { get; set; }
        public virtual DbSet<TblRHoldingBalance> TblRHoldingBalance { get; set; }
        public virtual DbSet<TblRHoldingDailyBalance> TblRHoldingDailyBalance { get; set; }
        public virtual DbSet<TblRHoldingNetMovement> TblRHoldingNetMovement { get; set; }
        public virtual DbSet<TblRHoldingRegistrationDetails> TblRHoldingRegistrationDetails { get; set; }
        public virtual DbSet<TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest> TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest { get; set; }
        public virtual DbSet<TblRParticipantCounterpartyBalance> TblRParticipantCounterpartyBalance { get; set; }
        public virtual DbSet<TblRPaymentFacilityDetailHistory> TblRPaymentFacilityDetailHistory { get; set; }
        public virtual DbSet<TblRPeriodicIncomeStatement> TblRPeriodicIncomeStatement { get; set; }
        public virtual DbSet<TblRRegistryIncomeStatementPartA> TblRRegistryIncomeStatementPartA { get; set; }
        public virtual DbSet<TblRRegistryIncomeStatementPartB> TblRRegistryIncomeStatementPartB { get; set; }
        public virtual DbSet<TblRRegistryIncomeStatementPartCai> TblRRegistryIncomeStatementPartCai { get; set; }
        public virtual DbSet<TblRRegistryIncomeStatementPartCcg> TblRRegistryIncomeStatementPartCcg { get; set; }
        public virtual DbSet<TblRRegistryIncomeStatementPartCfi> TblRRegistryIncomeStatementPartCfi { get; set; }
        public virtual DbSet<TblRRegistryIncomeStatementPartCna> TblRRegistryIncomeStatementPartCna { get; set; }
        public virtual DbSet<TblRRegistryIncomeStatementPartCod> TblRRegistryIncomeStatementPartCod { get; set; }
        public virtual DbSet<TblRRescheduledSettlementInstruction> TblRRescheduledSettlementInstruction { get; set; }
        public virtual DbSet<TblRSettledSettlementInstruction> TblRSettledSettlementInstruction { get; set; }
        public virtual DbSet<TblRTopSecurityHolderReport> TblRTopSecurityHolderReport { get; set; }
        public virtual DbSet<TblRTotalSecurityBalance> TblRTotalSecurityBalance { get; set; }
        public virtual DbSet<TblRUserDetailHistory> TblRUserDetailHistory { get; set; }
        public virtual DbSet<TblSAccountPurpose> TblSAccountPurpose { get; set; }
        public virtual DbSet<TblSAccountType> TblSAccountType { get; set; }
        public virtual DbSet<TblSAdditionalReportingParameter> TblSAdditionalReportingParameter { get; set; }
        public virtual DbSet<TblSAddressType> TblSAddressType { get; set; }
        public virtual DbSet<TblSAdjustmentHistoryStatus> TblSAdjustmentHistoryStatus { get; set; }
        public virtual DbSet<TblSAdjustmentReason> TblSAdjustmentReason { get; set; }
        public virtual DbSet<TblSAdviceReason> TblSAdviceReason { get; set; }
        public virtual DbSet<TblSAusState> TblSAusState { get; set; }
        public virtual DbSet<TblSAuthorisationReason> TblSAuthorisationReason { get; set; }
        public virtual DbSet<TblSBalanceInstruction> TblSBalanceInstruction { get; set; }
        public virtual DbSet<TblSBasisOfMovement> TblSBasisOfMovement { get; set; }
        public virtual DbSet<TblSBrokerNonBrokerIndicator> TblSBrokerNonBrokerIndicator { get; set; }
        public virtual DbSet<TblSCancelReason> TblSCancelReason { get; set; }
        public virtual DbSet<TblSCancellationReason> TblSCancellationReason { get; set; }
        public virtual DbSet<TblSChangeCashSubrecordRejectReason> TblSChangeCashSubrecordRejectReason { get; set; }
        public virtual DbSet<TblSChargeCommissionTypeCode> TblSChargeCommissionTypeCode { get; set; }
        public virtual DbSet<TblSChesseventType> TblSChesseventType { get; set; }
        public virtual DbSet<TblSCollateralType> TblSCollateralType { get; set; }
        public virtual DbSet<TblSConditionCode> TblSConditionCode { get; set; }
        public virtual DbSet<TblSControllingPidstatus> TblSControllingPidstatus { get; set; }
        public virtual DbSet<TblSCorporateActionTypeId> TblSCorporateActionTypeId { get; set; }
        public virtual DbSet<TblSCountry> TblSCountry { get; set; }
        public virtual DbSet<TblSCreditStatus> TblSCreditStatus { get; set; }
        public virtual DbSet<TblSCurrency> TblSCurrency { get; set; }
        public virtual DbSet<TblSDiaryAdjustmentType> TblSDiaryAdjustmentType { get; set; }
        public virtual DbSet<TblSDutyType> TblSDutyType { get; set; }
        public virtual DbSet<TblSEmailPurpose> TblSEmailPurpose { get; set; }
        public virtual DbSet<TblSEntrepotType> TblSEntrepotType { get; set; }
        public virtual DbSet<TblSEsastatus> TblSEsastatus { get; set; }
        public virtual DbSet<TblSExchange> TblSExchange { get; set; }
        public virtual DbSet<TblSFatcaquestions> TblSFatcaquestions { get; set; }
        public virtual DbSet<TblSFicode> TblSFicode { get; set; }
        public virtual DbSet<TblSFundReason> TblSFundReason { get; set; }
        public virtual DbSet<TblSGroupUnitCode> TblSGroupUnitCode { get; set; }
        public virtual DbSet<TblSGuaranteedForeignIndicator> TblSGuaranteedForeignIndicator { get; set; }
        public virtual DbSet<TblSHoldReason> TblSHoldReason { get; set; }
        public virtual DbSet<TblSHolderDrppreference> TblSHolderDrppreference { get; set; }
        public virtual DbSet<TblSHolderLockReleaseReason> TblSHolderLockReleaseReason { get; set; }
        public virtual DbSet<TblSHolderStatus> TblSHolderStatus { get; set; }
        public virtual DbSet<TblSHolderStatusChange> TblSHolderStatusChange { get; set; }
        public virtual DbSet<TblSHolderType> TblSHolderType { get; set; }
        public virtual DbSet<TblSHoldingTransactionStatus> TblSHoldingTransactionStatus { get; set; }
        public virtual DbSet<TblSIncomeNotificationFlag> TblSIncomeNotificationFlag { get; set; }
        public virtual DbSet<TblSIncomeStatementReportFrequency> TblSIncomeStatementReportFrequency { get; set; }
        public virtual DbSet<TblSIncomeStatementReportType> TblSIncomeStatementReportType { get; set; }
        public virtual DbSet<TblSIncomeStatementStatus> TblSIncomeStatementStatus { get; set; }
        public virtual DbSet<TblSIndividualTaxTypeCode> TblSIndividualTaxTypeCode { get; set; }
        public virtual DbSet<TblSInvestmentFundRoleCode> TblSInvestmentFundRoleCode { get; set; }
        public virtual DbSet<TblSInvestorType> TblSInvestorType { get; set; }
        public virtual DbSet<TblSLevyType> TblSLevyType { get; set; }
        public virtual DbSet<TblSMarket> TblSMarket { get; set; }
        public virtual DbSet<TblSMessageCategory> TblSMessageCategory { get; set; }
        public virtual DbSet<TblSMessageOrigin> TblSMessageOrigin { get; set; }
        public virtual DbSet<TblSMessageType> TblSMessageType { get; set; }
        public virtual DbSet<TblSMovementReason> TblSMovementReason { get; set; }
        public virtual DbSet<TblSNettOrGross> TblSNettOrGross { get; set; }
        public virtual DbSet<TblSNotificationType> TblSNotificationType { get; set; }
        public virtual DbSet<TblSOrderStatusCode> TblSOrderStatusCode { get; set; }
        public virtual DbSet<TblSOrderType> TblSOrderType { get; set; }
        public virtual DbSet<TblSParticipantType> TblSParticipantType { get; set; }
        public virtual DbSet<TblSPayReceiveIndicator> TblSPayReceiveIndicator { get; set; }
        public virtual DbSet<TblSPaymentFacilityChangeReason> TblSPaymentFacilityChangeReason { get; set; }
        public virtual DbSet<TblSPaymentType> TblSPaymentType { get; set; }
        public virtual DbSet<TblSPositionTypeParameter> TblSPositionTypeParameter { get; set; }
        public virtual DbSet<TblSPreviousStatus> TblSPreviousStatus { get; set; }
        public virtual DbSet<TblSPriceRunType> TblSPriceRunType { get; set; }
        public virtual DbSet<TblSPriceTypeCode> TblSPriceTypeCode { get; set; }
        public virtual DbSet<TblSProcessingFrequency> TblSProcessingFrequency { get; set; }
        public virtual DbSet<TblSProcessingPeriod> TblSProcessingPeriod { get; set; }
        public virtual DbSet<TblSProcessingPoint> TblSProcessingPoint { get; set; }
        public virtual DbSet<TblSReason> TblSReason { get; set; }
        public virtual DbSet<TblSRedemptionRequestReason> TblSRedemptionRequestReason { get; set; }
        public virtual DbSet<TblSRegistrationDetailsIndicator> TblSRegistrationDetailsIndicator { get; set; }
        public virtual DbSet<TblSRegistrationDetailsUpdateReason> TblSRegistrationDetailsUpdateReason { get; set; }
        public virtual DbSet<TblSRegistrationNameUpdateReason> TblSRegistrationNameUpdateReason { get; set; }
        public virtual DbSet<TblSRegistryRejectReason> TblSRegistryRejectReason { get; set; }
        public virtual DbSet<TblSRejectedChangeReason> TblSRejectedChangeReason { get; set; }
        public virtual DbSet<TblSRejectedHoldingAdviceReason> TblSRejectedHoldingAdviceReason { get; set; }
        public virtual DbSet<TblSRejectedIncomeStatementSetReason> TblSRejectedIncomeStatementSetReason { get; set; }
        public virtual DbSet<TblSRejectedOrderReason> TblSRejectedOrderReason { get; set; }
        public virtual DbSet<TblSRejectedReason> TblSRejectedReason { get; set; }
        public virtual DbSet<TblSRejectedReasonCode> TblSRejectedReasonCode { get; set; }
        public virtual DbSet<TblSRejectedRegistrationUpdateReason> TblSRejectedRegistrationUpdateReason { get; set; }
        public virtual DbSet<TblSRejectedRegistryReason> TblSRejectedRegistryReason { get; set; }
        public virtual DbSet<TblSRejectedTransferReason> TblSRejectedTransferReason { get; set; }
        public virtual DbSet<TblSRemovalReason> TblSRemovalReason { get; set; }
        public virtual DbSet<TblSReportingId> TblSReportingId { get; set; }
        public virtual DbSet<TblSReportingRequestStatus> TblSReportingRequestStatus { get; set; }
        public virtual DbSet<TblSRescheduleReason> TblSRescheduleReason { get; set; }
        public virtual DbSet<TblSResidencyIndicator> TblSResidencyIndicator { get; set; }
        public virtual DbSet<TblSRevisedStatus> TblSRevisedStatus { get; set; }
        public virtual DbSet<TblSRoundingCode> TblSRoundingCode { get; set; }
        public virtual DbSet<TblSSecurityCodePreference> TblSSecurityCodePreference { get; set; }
        public virtual DbSet<TblSSettlementInstructionStatus> TblSSettlementInstructionStatus { get; set; }
        public virtual DbSet<TblSSettlementStep> TblSSettlementStep { get; set; }
        public virtual DbSet<TblSSlsloanInstructionStatus> TblSSlsloanInstructionStatus { get; set; }
        public virtual DbSet<TblSSubpositionType> TblSSubpositionType { get; set; }
        public virtual DbSet<TblSSubregisterStatus> TblSSubregisterStatus { get; set; }
        public virtual DbSet<TblSTaxExemptionReasonCode> TblSTaxExemptionReasonCode { get; set; }
        public virtual DbSet<TblSTaxationBasisCode> TblSTaxationBasisCode { get; set; }
        public virtual DbSet<TblSTradeReason> TblSTradeReason { get; set; }
        public virtual DbSet<TblSTransactionBasis> TblSTransactionBasis { get; set; }
        public virtual DbSet<TblSTransactionClassParameter> TblSTransactionClassParameter { get; set; }
        public virtual DbSet<TblSTransactionStatus> TblSTransactionStatus { get; set; }
        public virtual DbSet<TblSUser> TblSUser { get; set; }
        public virtual DbSet<TblSUserStatus> TblSUserStatus { get; set; }
        public virtual DbSet<TblSUserType> TblSUserType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("connectionString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblDAccount>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAccountName).IsUnicode(false);

                entity.Property(e => e.SAccountNumber).IsUnicode(false);

                entity.Property(e => e.SRegAccountNumber).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkAccountPurposeNavigation)
                    .WithMany(p => p.TblDAccount)
                    .HasForeignKey(d => d.FkAccountPurpose)
                    .HasConstraintName("FK_tbl_D_Account_tbl_S_AccountPurpose");

                entity.HasOne(d => d.FkAccountTypeNavigation)
                    .WithMany(p => p.TblDAccount)
                    .HasForeignKey(d => d.FkAccountType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_Account_tbl_S_AccountType");
            });

            modelBuilder.Entity<TblDCalastoneTransactionRequest>(entity =>
            {
                entity.HasKey(e => e.KTransactionRequest)
                    .HasName("PK_tblTransactionRequest");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAccountDesignation).IsUnicode(false);

                entity.Property(e => e.SAccountId).IsUnicode(false);

                entity.Property(e => e.SAdditionalRejectedReason).IsUnicode(false);

                entity.Property(e => e.SAgentCode).IsUnicode(false);

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SFundId).IsUnicode(false);

                entity.Property(e => e.SFundManagerId).IsUnicode(false);

                entity.Property(e => e.SFundName).IsUnicode(false);

                entity.Property(e => e.SLegOrderReference).IsUnicode(false);

                entity.Property(e => e.SMessageId).IsUnicode(false);

                entity.Property(e => e.SOrderReference).IsUnicode(false);

                entity.Property(e => e.SProductCode).IsUnicode(false);

                entity.Property(e => e.SRegProductName).IsUnicode(false);

                entity.Property(e => e.SRegTransactionNumber).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkDistributorCodeNavigation)
                    .WithMany(p => p.TblDCalastoneTransactionRequest)
                    .HasForeignKey(d => d.FkDistributorCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_TransactionRequest_tbl_S_InvestmentFundRoleCode");

                entity.HasOne(d => d.FkFundIdtypeNavigation)
                    .WithMany(p => p.TblDCalastoneTransactionRequest)
                    .HasForeignKey(d => d.FkFundIdtype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_TransactionRequest_tbl_S_FundIDType");

                entity.HasOne(d => d.FkRoundingCodeNavigation)
                    .WithMany(p => p.TblDCalastoneTransactionRequest)
                    .HasForeignKey(d => d.FkRoundingCode)
                    .HasConstraintName("FK_tbl_D_TransactionRequest_tbl_S_RoundingCode");

                entity.HasOne(d => d.FkTotalFeeAndTaxNavigation)
                    .WithMany(p => p.TblDCalastoneTransactionRequest)
                    .HasForeignKey(d => d.FkTotalFeeAndTax)
                    .HasConstraintName("FK_tbl_D_TransactionRequest_tbl_D_TotalFeeAndTaxRequest");

                entity.HasOne(d => d.FkTransactionRequestRejectedReasonCodeNavigation)
                    .WithMany(p => p.TblDCalastoneTransactionRequest)
                    .HasForeignKey(d => d.FkTransactionRequestRejectedReasonCode)
                    .HasConstraintName("FK_tbl_D_TransactionRequest_tbl_S_RejectedReasonCode");

                entity.HasOne(d => d.FkTransactionRequestStatusNavigation)
                    .WithMany(p => p.TblDCalastoneTransactionRequest)
                    .HasForeignKey(d => d.FkTransactionRequestStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_TransactionRequest_tbl_S_TransactionRequestStatus");

                entity.HasOne(d => d.FkTransactionTypeNavigation)
                    .WithMany(p => p.TblDCalastoneTransactionRequest)
                    .HasForeignKey(d => d.FkTransactionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_TransactionRequest_tbl_S_TransactionType");

                entity.HasOne(d => d.FkUnitGroupCodeNavigation)
                    .WithMany(p => p.TblDCalastoneTransactionRequest)
                    .HasForeignKey(d => d.FkUnitGroupCode)
                    .HasConstraintName("FK_tbl_D_TransactionRequest_tbl_S_GroupUnitCode");
            });

            modelBuilder.Entity<TblDChessmFundUser>(entity =>
            {
                entity.HasKey(e => e.KChessmFundUser)
                    .HasName("PK_tbl_D_Participant");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SUic)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkChessmFundUserTypeNavigation)
                    .WithMany(p => p.TblDChessmFundUser)
                    .HasForeignKey(d => d.FkChessmFundUserType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_Participant_tbl_S_ParticipantType");
            });

            modelBuilder.Entity<TblDChesstransactionRequest>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IHin).IsUnicode(false);

                entity.Property(e => e.IPid).IsUnicode(false);

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SFundCode).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SProductName).IsUnicode(false);

                entity.Property(e => e.SRegistrationDetails).IsUnicode(false);

                entity.Property(e => e.SSrn).IsUnicode(false);

                entity.Property(e => e.SSupplementaryReference).IsUnicode(false);

                entity.Property(e => e.STargetTransactionId).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkFatcaquestionsNavigation)
                    .WithMany(p => p.TblDChesstransactionRequest)
                    .HasForeignKey(d => d.FkFatcaquestions)
                    .HasConstraintName("FK_tbl_D_CHESSTransactionRequest_tbl_S_FATCAQuestions");

                entity.HasOne(d => d.FkHolderNavigation)
                    .WithMany(p => p.TblDChesstransactionRequest)
                    .HasForeignKey(d => d.FkHolder)
                    .HasConstraintName("FK_tbl_D_CHESSTransactionRequest_tbl_D_Holder");

                entity.HasOne(d => d.FkNettOrGrossNavigation)
                    .WithMany(p => p.TblDChesstransactionRequest)
                    .HasForeignKey(d => d.FkNettOrGross)
                    .HasConstraintName("FK_tbl_D_CHESSTransactionRequest_tbl_S_NettOrGross");

                entity.HasOne(d => d.FkOrderTypeNavigation)
                    .WithMany(p => p.TblDChesstransactionRequest)
                    .HasForeignKey(d => d.FkOrderType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_CHESSTransactionRequest_tbl_S_OrderType");

                entity.HasOne(d => d.FkRedemptionRequestReasonNavigation)
                    .WithMany(p => p.TblDChesstransactionRequest)
                    .HasForeignKey(d => d.FkRedemptionRequestReason)
                    .HasConstraintName("FK_tbl_D_CHESSTransactionRequest_tbl_S_RedemptionRequestReason");

                entity.HasOne(d => d.FkTransactionStatusNavigation)
                    .WithMany(p => p.TblDChesstransactionRequest)
                    .HasForeignKey(d => d.FkTransactionStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_CHESSTransactionRequest_tbl_S_TransactionStatus");
            });

            modelBuilder.Entity<TblDForeignExchangeDetail>(entity =>
            {
                entity.HasKey(e => e.KForeignExchangeDetail)
                    .HasName("PK_tblForeignExchangeDetail");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblDHolder>(entity =>
            {
                entity.HasKey(e => e.KHolder)
                    .HasName("PK_tbl_D_CHESSHolderRegistration");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SEmailAddress).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SRegistrationAddress).IsFixedLength();

                entity.Property(e => e.SRegistrationDetail).IsUnicode(false);

                entity.Property(e => e.SRegistrationName).IsFixedLength();

                entity.Property(e => e.SSrn).IsUnicode(false);

                entity.Property(e => e.STfnAbn1).IsUnicode(false);

                entity.Property(e => e.STfnAbn2).IsUnicode(false);

                entity.Property(e => e.STfnAbn3).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkAccountNavigation)
                    .WithMany(p => p.TblDHolder)
                    .HasForeignKey(d => d.FkAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_Holder_tbl_D_Account");

                entity.HasOne(d => d.FkControllingP)
                    .WithMany(p => p.TblDHolder)
                    .HasForeignKey(d => d.FkControllingPid)
                    .HasConstraintName("FK_tbl_D_Holder_tbl_D_Participant");

                entity.HasOne(d => d.FkEmailPurposeNavigation)
                    .WithMany(p => p.TblDHolder)
                    .HasForeignKey(d => d.FkEmailPurpose)
                    .HasConstraintName("FK_tbl_D_Holder_tbl_S_EmailPurpose");

                entity.HasOne(d => d.FkEntrepotTypeNavigation)
                    .WithMany(p => p.TblDHolder)
                    .HasForeignKey(d => d.FkEntrepotType)
                    .HasConstraintName("FK_tbl_D_CHESSHolderRegistration_tbl_S_EntrepotType");

                entity.HasOne(d => d.FkHolderStatusNavigation)
                    .WithMany(p => p.TblDHolder)
                    .HasForeignKey(d => d.FkHolderStatus)
                    .HasConstraintName("FK_tbl_D_CHESSHolderRegistration_tbl_S_HolderStatus");

                entity.HasOne(d => d.FkHolderTypeNavigation)
                    .WithMany(p => p.TblDHolder)
                    .HasForeignKey(d => d.FkHolderType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_Holder_tbl_S_HolderType");

                entity.HasOne(d => d.FkRegistrationDetailsIndicatorNavigation)
                    .WithMany(p => p.TblDHolder)
                    .HasForeignKey(d => d.FkRegistrationDetailsIndicator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_Holder_tbl_S_RegistrationDetailsIndicator");
            });

            modelBuilder.Entity<TblDIncomeStatementAuthorisationRequest>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SRegistryReference).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkIncomeStatementReportFrequencyNavigation)
                    .WithMany(p => p.TblDIncomeStatementAuthorisationRequest)
                    .HasForeignKey(d => d.FkIncomeStatementReportFrequency)
                    .HasConstraintName("FK_tbl_D_IncomeStatementAuthorisationRequest_tbl_S_IncomeStatementReportFrequency");

                entity.HasOne(d => d.FkIncomeStatementReportTypeNavigation)
                    .WithMany(p => p.TblDIncomeStatementAuthorisationRequest)
                    .HasForeignKey(d => d.FkIncomeStatementReportType)
                    .HasConstraintName("FK_tbl_D_IncomeStatementAuthorisationRequest_tbl_S_IncomeStatementReportType");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblDIncomeStatementAuthorisationRequestFkP)
                    .HasForeignKey(d => d.FkPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_IncomeStatementAuthorisationRequest_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkRejectedRegistryReasonNavigation)
                    .WithMany(p => p.TblDIncomeStatementAuthorisationRequest)
                    .HasForeignKey(d => d.FkRejectedRegistryReason)
                    .HasConstraintName("FK_tbl_D_IncomeStatementAuthorisationRequest_tbl_S_RejectedRegistryReason");

                entity.HasOne(d => d.FkTargetUicNavigation)
                    .WithMany(p => p.TblDIncomeStatementAuthorisationRequestFkTargetUicNavigation)
                    .HasForeignKey(d => d.FkTargetUic)
                    .HasConstraintName("FK_tbl_D_IncomeStatementAuthorisationRequest_tbl_D_CHESSUser1");
            });

            modelBuilder.Entity<TblDIncomeStatementSet>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSetTransactionId).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblDInformativeTax>(entity =>
            {
                entity.HasKey(e => e.KCtninformativeTax)
                    .HasName("PK_tblInformativeTax");

                entity.HasOne(d => d.FkTaxExemptionReasonCodeNavigation)
                    .WithMany(p => p.TblDInformativeTax)
                    .HasForeignKey(d => d.FkTaxExemptionReasonCode)
                    .HasConstraintName("FK_tbl_D_InformativeTax_tbl_S_TaxExemptionReasonCode");

                entity.HasOne(d => d.FkTaxTypeCodeNavigation)
                    .WithMany(p => p.TblDInformativeTax)
                    .HasForeignKey(d => d.FkTaxTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_InformativeTax_tbl_S_IndividualTaxTypeCode");
            });

            modelBuilder.Entity<TblDPublicApitoken>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.TblDPublicApitoken)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_PublicAPIToken_tbl_S_User");
            });

            modelBuilder.Entity<TblDRawMessage>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRawMessage).IsFixedLength();

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkMessageTypeNavigation)
                    .WithMany(p => p.TblDRawMessage)
                    .HasForeignKey(d => d.FkMessageType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_RawMessage_tbl_S_MessageTypes");
            });

            modelBuilder.Entity<TblDReportRequest>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SPhin).IsUnicode(false);

                entity.Property(e => e.SPnumberofDays).IsUnicode(false);

                entity.Property(e => e.SPpaymentFacility).IsUnicode(false);

                entity.Property(e => e.SPsecurityCode).IsUnicode(false);

                entity.Property(e => e.SPtakeoverCode).IsUnicode(false);

                entity.Property(e => e.SPtransactionId).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkPadditionalReportingNavigation)
                    .WithMany(p => p.TblDReportRequest)
                    .HasForeignKey(d => d.FkPadditionalReporting)
                    .HasConstraintName("FK_tbl_D_ReportRequest_tbl_S_AdditionalReportingParameter");

                entity.HasOne(d => d.FkPcorporateActionType)
                    .WithMany(p => p.TblDReportRequest)
                    .HasForeignKey(d => d.FkPcorporateActionTypeId)
                    .HasConstraintName("FK_tbl_D_ReportRequest_tbl_S_CorporateActionTypeId");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblDReportRequest)
                    .HasForeignKey(d => d.FkPid)
                    .HasConstraintName("FK_tbl_D_ReportRequest_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkPpositionTypeNavigation)
                    .WithMany(p => p.TblDReportRequest)
                    .HasForeignKey(d => d.FkPpositionType)
                    .HasConstraintName("FK_tbl_D_ReportRequest_tbl_S_PositionTypeParameter");

                entity.HasOne(d => d.FkPreporting)
                    .WithMany(p => p.TblDReportRequestFkPreporting)
                    .HasForeignKey(d => d.FkPreportingId)
                    .HasConstraintName("FK_tbl_D_ReportRequest_tbl_S_ReportingId1");

                entity.HasOne(d => d.FkProcessingFrequencyNavigation)
                    .WithMany(p => p.TblDReportRequest)
                    .HasForeignKey(d => d.FkProcessingFrequency)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_ReportRequest_tbl_S_ProcessingFrequency");

                entity.HasOne(d => d.FkProcessingPeriodNavigation)
                    .WithMany(p => p.TblDReportRequest)
                    .HasForeignKey(d => d.FkProcessingPeriod)
                    .HasConstraintName("FK_tbl_D_ReportRequest_tbl_S_ProcessingPeriod");

                entity.HasOne(d => d.FkProcessingPointNavigation)
                    .WithMany(p => p.TblDReportRequest)
                    .HasForeignKey(d => d.FkProcessingPoint)
                    .HasConstraintName("FK_tbl_D_ReportRequest_tbl_S_ProcessingPoint");

                entity.HasOne(d => d.FkPsubpositionTypeNavigation)
                    .WithMany(p => p.TblDReportRequest)
                    .HasForeignKey(d => d.FkPsubpositionType)
                    .HasConstraintName("FK_tbl_D_ReportRequest_tbl_S_SubpositionType");

                entity.HasOne(d => d.FkPtransactionClassNavigation)
                    .WithMany(p => p.TblDReportRequest)
                    .HasForeignKey(d => d.FkPtransactionClass)
                    .HasConstraintName("FK_tbl_D_ReportRequest_tbl_S_TransactionClassParameter");

                entity.HasOne(d => d.FkReporting)
                    .WithMany(p => p.TblDReportRequestFkReporting)
                    .HasForeignKey(d => d.FkReportingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_ReportRequest_tbl_S_ReportingId");
            });

            modelBuilder.Entity<TblDReportingRequestDetail>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SPhin).IsUnicode(false);

                entity.Property(e => e.SPnumberofDays).IsUnicode(false);

                entity.Property(e => e.SPpaymentFacility).IsUnicode(false);

                entity.Property(e => e.SPsecurityCode).IsUnicode(false);

                entity.Property(e => e.SPtakeoverCode).IsUnicode(false);

                entity.Property(e => e.SPtransactionId).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkPadditionalReportingNavigation)
                    .WithMany(p => p.TblDReportingRequestDetail)
                    .HasForeignKey(d => d.FkPadditionalReporting)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_S_AdditionalReportingParameter");

                entity.HasOne(d => d.FkPcorporateActionType)
                    .WithMany(p => p.TblDReportingRequestDetail)
                    .HasForeignKey(d => d.FkPcorporateActionTypeId)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_S_CorporateActionTypeId");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblDReportingRequestDetail)
                    .HasForeignKey(d => d.FkPid)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkPpositionTypeNavigation)
                    .WithMany(p => p.TblDReportingRequestDetail)
                    .HasForeignKey(d => d.FkPpositionType)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_S_PositionTypeParameter");

                entity.HasOne(d => d.FkPreporting)
                    .WithMany(p => p.TblDReportingRequestDetailFkPreporting)
                    .HasForeignKey(d => d.FkPreportingId)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_S_ReportingId1");

                entity.HasOne(d => d.FkProcessingFrequencyNavigation)
                    .WithMany(p => p.TblDReportingRequestDetail)
                    .HasForeignKey(d => d.FkProcessingFrequency)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_S_ProcessingFrequency");

                entity.HasOne(d => d.FkProcessingPeriodNavigation)
                    .WithMany(p => p.TblDReportingRequestDetail)
                    .HasForeignKey(d => d.FkProcessingPeriod)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_S_ProcessingPeriod");

                entity.HasOne(d => d.FkProcessingPointNavigation)
                    .WithMany(p => p.TblDReportingRequestDetail)
                    .HasForeignKey(d => d.FkProcessingPoint)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_S_ProcessingPoint");

                entity.HasOne(d => d.FkPsubpositionTypeNavigation)
                    .WithMany(p => p.TblDReportingRequestDetail)
                    .HasForeignKey(d => d.FkPsubpositionType)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_S_SubpositionType");

                entity.HasOne(d => d.FkPtransactionClassNavigation)
                    .WithMany(p => p.TblDReportingRequestDetail)
                    .HasForeignKey(d => d.FkPtransactionClass)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_S_TransactionClassParameter");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblDReportingRequestDetail)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_D_ReportRequest");

                entity.HasOne(d => d.FkReporting)
                    .WithMany(p => p.TblDReportingRequestDetailFkReporting)
                    .HasForeignKey(d => d.FkReportingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_S_ReportingId");

                entity.HasOne(d => d.FkReportingRequestStatusNavigation)
                    .WithMany(p => p.TblDReportingRequestDetail)
                    .HasForeignKey(d => d.FkReportingRequestStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_ReportingRequestDetail_tbl_S_ReportingRequestStatus");
            });

            modelBuilder.Entity<TblDTotalFeeAndTaxRequest>(entity =>
            {
                entity.HasKey(e => e.KCtntotalFeeAndTaxRequest)
                    .HasName("PK_tblTotalFeeAndTaxRequest");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SProprietaryId)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SProprietaryIssuer).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkChargeCommissionTypeCodeNavigation)
                    .WithMany(p => p.TblDTotalFeeAndTaxRequest)
                    .HasForeignKey(d => d.FkChargeCommissionTypeCode)
                    .HasConstraintName("FK_tbl_D_TotalFeeAndTaxRequest_tbl_S_ChargeCommissionTypeCode");
            });

            modelBuilder.Entity<TblDTranIndvFee>(entity =>
            {
                entity.HasKey(e => e.KTranIndvFee)
                    .HasName("PK_tblTranIndvFee");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkChargeCommissionBasisCodeNavigation)
                    .WithMany(p => p.TblDTranIndvFee)
                    .HasForeignKey(d => d.FkChargeCommissionBasisCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_TranIndvFee_tbl_S_TaxationBasisCode");

                entity.HasOne(d => d.FkChargeCommissionTypeCodeNavigation)
                    .WithMany(p => p.TblDTranIndvFee)
                    .HasForeignKey(d => d.FkChargeCommissionTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_TranIndvFee_tbl_S_ChargeCommissionTypeCode");
            });

            modelBuilder.Entity<TblDTranIndvTax>(entity =>
            {
                entity.HasKey(e => e.KTranIndvTax)
                    .HasName("PK_tblTranIndvTax");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkTaxTypeCodeNavigation)
                    .WithMany(p => p.TblDTranIndvTax)
                    .HasForeignKey(d => d.FkTaxTypeCode)
                    .HasConstraintName("FK_tbl_D_TranIndvTax_tbl_S_IndividualTaxTypeCode");
            });

            modelBuilder.Entity<TblDTransaction>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SDealReference).IsUnicode(false);

                entity.Property(e => e.SLegDealReference).IsUnicode(false);

                entity.Property(e => e.SOrderReference).IsUnicode(false);

                entity.Property(e => e.SRegTransactionNumber).IsUnicode(false);

                entity.Property(e => e.SRegTransactionStatus).IsUnicode(false);

                entity.Property(e => e.SRegistryReference).IsUnicode(false);

                entity.Property(e => e.SRelatedReference).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkTransactionRequestNavigation)
                    .WithMany(p => p.TblDTransaction)
                    .HasForeignKey(d => d.FkTransactionRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_D_Transaction_tbl_D_CHESSTransactionRequest");
            });

            modelBuilder.Entity<TblIChessmFundUserType>(entity =>
            {
                entity.HasKey(e => e.KChessmFundUserType)
                    .HasName("PK_tbl_S_Role");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SChessmFundUserType).IsUnicode(false);

                entity.Property(e => e.SChessmFundUserTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblIChessmessageTypes>(entity =>
            {
                entity.HasKey(e => e.KChessmessageType)
                    .HasName("PK_MessageTypes");

                entity.Property(e => e.CChessmessageTypeIndex)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblIFundIdtype>(entity =>
            {
                entity.HasKey(e => e.KFundIdtype)
                    .HasName("PK_tblFundIDType");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SFundIdtype).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblITransactionRequestStatus>(entity =>
            {
                entity.HasKey(e => e.KTransactionRequestStatus)
                    .HasName("PK_tblTransactionRequestStatus");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.STransactionRequestStatus).IsUnicode(false);

                entity.Property(e => e.STransactionRequestStatusDesc).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblITransactionType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRegTransactionType).IsUnicode(false);

                entity.Property(e => e.STransactionType).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblITransactionType1>(entity =>
            {
                entity.HasKey(e => e.KTransactionType)
                    .HasName("PK_tblTransactionType");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRegTransactionType).IsUnicode(false);

                entity.Property(e => e.STransactionType).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblLTransactionHolder>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkHolderNavigation)
                    .WithMany(p => p.TblLTransactionHolder)
                    .HasForeignKey(d => d.FkHolder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_L_TransactionHolder_tbl_D_Holder");

                entity.HasOne(d => d.FkTransactionNavigation)
                    .WithMany(p => p.TblLTransactionHolder)
                    .HasForeignKey(d => d.FkTransaction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_L_TransactionHolder_tbl_D_Transaction");
            });

            modelBuilder.Entity<TblRCancelledSettlementInstruction>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCancellingTransactionId).IsUnicode(false);

                entity.Property(e => e.SMatchingTransactionId).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.STargetTransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkCancellationReasonNavigation)
                    .WithMany(p => p.TblRCancelledSettlementInstruction)
                    .HasForeignKey(d => d.FkCancellationReason)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_CancelledSettlementInstruction_tbl_S_CancellationReason");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRCancelledSettlementInstruction)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_CancelledSettlementInstruction_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblRChessconversionRequesttoIssuerSponsoredFund>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SDeliveringHin).IsUnicode(false);

                entity.Property(e => e.SEmailAddress).IsUnicode(false);

                entity.Property(e => e.SFundCode).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SParticipantReference).IsUnicode(false);

                entity.Property(e => e.SSrn).IsUnicode(false);

                entity.Property(e => e.SSupplementaryReference).IsUnicode(false);

                entity.Property(e => e.STfnAbn1).IsUnicode(false);

                entity.Property(e => e.STfnAbn2).IsUnicode(false);

                entity.Property(e => e.STfnAbn3).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkBrokerNonbrokerIndicatorNavigation)
                    .WithMany(p => p.TblRChessconversionRequesttoIssuerSponsoredFund)
                    .HasForeignKey(d => d.FkBrokerNonbrokerIndicator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_CHESSConversionRequesttoIssuerSponsoredFund_tbl_S_BrokerNonBrokerIndicator");

                entity.HasOne(d => d.FkDeliveringP)
                    .WithMany(p => p.TblRChessconversionRequesttoIssuerSponsoredFund)
                    .HasForeignKey(d => d.FkDeliveringPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_CHESSConversionRequesttoIssuerSponsoredFund_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkEmailPurposeNavigation)
                    .WithMany(p => p.TblRChessconversionRequesttoIssuerSponsoredFund)
                    .HasForeignKey(d => d.FkEmailPurpose)
                    .HasConstraintName("FK_tbl_R_CHESSConversionRequesttoIssuerSponsoredFund_tbl_S_EmailPurpose");

                entity.HasOne(d => d.FkMovementReasonNavigation)
                    .WithMany(p => p.TblRChessconversionRequesttoIssuerSponsoredFund)
                    .HasForeignKey(d => d.FkMovementReason)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_CHESSConversionRequesttoIssuerSponsoredFund_tbl_S_MovementReason");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRChessconversionRequesttoIssuerSponsoredFund)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_CHESSConversionRequesttoIssuerSponsoredFund_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblREffectedChessconversiontoIssuerSponsoredFund>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SDeliveringHin).IsUnicode(false);

                entity.Property(e => e.SFundCode).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SParticipantReference).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblREffectedChessconversiontoIssuerSponsoredFund)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_EffectedCHESSConversiontoIssuerSponsoredFund_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblREffectedConversionIssuerSponsoredFundtoChess>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SRegistryReference).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblREffectedConversionIssuerSponsoredFundtoChess)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_EffectedConversionIssuerSponsoredFundtoCHESS_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblREffectedFundUnitAdjustment>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SFundCode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SRegistryReference).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkFundReasonNavigation)
                    .WithMany(p => p.TblREffectedFundUnitAdjustment)
                    .HasForeignKey(d => d.FkFundReason)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_EffectedFundUnitAdjustment_tbl_S_FundReason");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblREffectedFundUnitAdjustment)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_EffectedFundUnitAdjustment_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblREffectedNetFundsMovement>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SNetFundsTransactionId).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SPaymentFacilityId).IsUnicode(false);

                entity.Property(e => e.STotalMessageCount).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkPayReceiveIndicatorNavigation)
                    .WithMany(p => p.TblREffectedNetFundsMovement)
                    .HasForeignKey(d => d.FkPayReceiveIndicator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_EffectedNetFundsMovement_tbl_S_PayReceiveIndicator");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblREffectedNetFundsMovement)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_EffectedNetFundsMovement_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblRFullAdjustedSettlementInstruction>(entity =>
            {
                entity.Property(e => e.KFullAdjustedSettlementInstruction).ValueGeneratedNever();

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAccrualNumber)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCancellingTransactionId).IsUnicode(false);

                entity.Property(e => e.SDiaryAdjustmentNumber)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SMatchingTransactionId).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SPreviousDeliveringHin).IsUnicode(false);

                entity.Property(e => e.SPreviousReceivingHin).IsUnicode(false);

                entity.Property(e => e.SPreviousSecurityCode).IsUnicode(false);

                entity.Property(e => e.SPreviousUnderlyingReference).IsUnicode(false);

                entity.Property(e => e.SRevisedDeliveringHin).IsUnicode(false);

                entity.Property(e => e.SRevisedReceivingHin).IsUnicode(false);

                entity.Property(e => e.SRevisedSecurityCode).IsUnicode(false);

                entity.Property(e => e.SRevisedUnderlyingReference).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.SUpdatingTransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkAdjustmentHistoryStatusNavigation)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstruction)
                    .HasForeignKey(d => d.FkAdjustmentHistoryStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_S_AdjustmentHistoryStatus");

                entity.HasOne(d => d.FkAdjustmentReasonNavigation)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstruction)
                    .HasForeignKey(d => d.FkAdjustmentReason)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_S_AdjustmentReason");

                entity.HasOne(d => d.FkCorporateActionType)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstruction)
                    .HasForeignKey(d => d.FkCorporateActionTypeId)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_S_CorporateActionTypeId");

                entity.HasOne(d => d.FkDiaryAdjustmentTypeNavigation)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstruction)
                    .HasForeignKey(d => d.FkDiaryAdjustmentType)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_S_DiaryAdjustmentType");

                entity.HasOne(d => d.FkPreviousDutyTypeNavigation)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstructionFkPreviousDutyTypeNavigation)
                    .HasForeignKey(d => d.FkPreviousDutyType)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_S_DutyType");

                entity.HasOne(d => d.FkPreviousGuaranteedForeignIndicatorNavigation)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstructionFkPreviousGuaranteedForeignIndicatorNavigation)
                    .HasForeignKey(d => d.FkPreviousGuaranteedForeignIndicator)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_S_GuaranteedForeignIndicator");

                entity.HasOne(d => d.FkPreviousStatusNavigation)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstructionFkPreviousStatusNavigation)
                    .HasForeignKey(d => d.FkPreviousStatus)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_S_SettlementInstructionStatus1");

                entity.HasOne(d => d.FkPreviousTransactionBasisNavigation)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstructionFkPreviousTransactionBasisNavigation)
                    .HasForeignKey(d => d.FkPreviousTransactionBasis)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_S_TransactionBasis");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstruction)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_D_ReportRequest");

                entity.HasOne(d => d.FkRevisedDutyTypeNavigation)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstructionFkRevisedDutyTypeNavigation)
                    .HasForeignKey(d => d.FkRevisedDutyType)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_S_DutyType1");

                entity.HasOne(d => d.FkRevisedGuaranteedForeignIndicatorNavigation)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstructionFkRevisedGuaranteedForeignIndicatorNavigation)
                    .HasForeignKey(d => d.FkRevisedGuaranteedForeignIndicator)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_S_GuaranteedForeignIndicator1");

                entity.HasOne(d => d.FkRevisedStatusNavigation)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstructionFkRevisedStatusNavigation)
                    .HasForeignKey(d => d.FkRevisedStatus)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_S_SettlementInstructionStatus");

                entity.HasOne(d => d.FkRevisedTransactionBasisNavigation)
                    .WithMany(p => p.TblRFullAdjustedSettlementInstructionFkRevisedTransactionBasisNavigation)
                    .HasForeignKey(d => d.FkRevisedTransactionBasis)
                    .HasConstraintName("FK_tbl_R_FullAdjustedSettlementInstruction_tbl_S_TransactionBasis1");
            });

            modelBuilder.Entity<TblRFullChesstoIssuerSponsoredConversion>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SParticipantReference).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.SSrn).IsUnicode(false);

                entity.Property(e => e.SSupplementaryReference).IsUnicode(false);

                entity.Property(e => e.STfnAbn1).IsUnicode(false);

                entity.Property(e => e.STfnAbn2).IsUnicode(false);

                entity.Property(e => e.STfnAbn3).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.SUnderlyingReference).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkDeliveringP)
                    .WithMany(p => p.TblRFullChesstoIssuerSponsoredConversion)
                    .HasForeignKey(d => d.FkDeliveringPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullCHESStoIssuerSponsoredConversion_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkGuaranteedForeignIndicatorNavigation)
                    .WithMany(p => p.TblRFullChesstoIssuerSponsoredConversion)
                    .HasForeignKey(d => d.FkGuaranteedForeignIndicator)
                    .HasConstraintName("FK_tbl_R_FullCHESStoIssuerSponsoredConversion_tbl_S_GuaranteedForeignIndicator");

                entity.HasOne(d => d.FkHoldingTransactionStatusNavigation)
                    .WithMany(p => p.TblRFullChesstoIssuerSponsoredConversion)
                    .HasForeignKey(d => d.FkHoldingTransactionStatus)
                    .HasConstraintName("FK_tbl_R_FullCHESStoIssuerSponsoredConversion_tbl_S_HoldingTransactionStatus");

                entity.HasOne(d => d.FkLocationofRegisterNavigation)
                    .WithMany(p => p.TblRFullChesstoIssuerSponsoredConversion)
                    .HasForeignKey(d => d.FkLocationofRegister)
                    .HasConstraintName("FK_tbl_R_FullCHESStoIssuerSponsoredConversion_tbl_S_Country");

                entity.HasOne(d => d.FkLocationofRegister1)
                    .WithMany(p => p.TblRFullChesstoIssuerSponsoredConversion)
                    .HasForeignKey(d => d.FkLocationofRegister)
                    .HasConstraintName("FK_tbl_R_FullCHESStoIssuerSponsoredConversion_tbl_S_AusState");

                entity.HasOne(d => d.FkMovementReasonNavigation)
                    .WithMany(p => p.TblRFullChesstoIssuerSponsoredConversion)
                    .HasForeignKey(d => d.FkMovementReason)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullCHESStoIssuerSponsoredConversion_tbl_S_MovementReason");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRFullChesstoIssuerSponsoredConversion)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullCHESStoIssuerSponsoredConversion_tbl_D_ReportRequest");

                entity.HasOne(d => d.SDeliveringHinNavigation)
                    .WithMany(p => p.TblRFullChesstoIssuerSponsoredConversion)
                    .HasForeignKey(d => d.SDeliveringHin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullCHESStoIssuerSponsoredConversion_tbl_D_Holder");
            });

            modelBuilder.Entity<TblRFullIssuerSponsoredtoChessconversion>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SParticipantReference).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.SSrn).IsUnicode(false);

                entity.Property(e => e.SSupplementaryReference).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkGuaranteedForeignIndicatorNavigation)
                    .WithMany(p => p.TblRFullIssuerSponsoredtoChessconversion)
                    .HasForeignKey(d => d.FkGuaranteedForeignIndicator)
                    .HasConstraintName("FK_tbl_R_FullIssuerSponsoredtoCHESSConversion_tbl_S_GuaranteedForeignIndicator");

                entity.HasOne(d => d.FkHoldingTransactionStatusNavigation)
                    .WithMany(p => p.TblRFullIssuerSponsoredtoChessconversion)
                    .HasForeignKey(d => d.FkHoldingTransactionStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullIssuerSponsoredtoCHESSConversion_tbl_S_HoldingTransactionStatus");

                entity.HasOne(d => d.FkLocationofRegisterNavigation)
                    .WithMany(p => p.TblRFullIssuerSponsoredtoChessconversion)
                    .HasForeignKey(d => d.FkLocationofRegister)
                    .HasConstraintName("FK_tbl_R_FullIssuerSponsoredtoCHESSConversion_tbl_S_Country");

                entity.HasOne(d => d.FkLocationofRegister1)
                    .WithMany(p => p.TblRFullIssuerSponsoredtoChessconversion)
                    .HasForeignKey(d => d.FkLocationofRegister)
                    .HasConstraintName("FK_tbl_R_FullIssuerSponsoredtoCHESSConversion_tbl_S_AusState");

                entity.HasOne(d => d.FkReceivingResidencyIndicatorNavigation)
                    .WithMany(p => p.TblRFullIssuerSponsoredtoChessconversion)
                    .HasForeignKey(d => d.FkReceivingResidencyIndicator)
                    .HasConstraintName("FK_tbl_R_FullIssuerSponsoredtoCHESSConversion_tbl_S_ResidencyIndicator");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRFullIssuerSponsoredtoChessconversion)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullIssuerSponsoredtoCHESSConversion_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblRFullSettlementInstruction>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCancellingTransactionId).IsUnicode(false);

                entity.Property(e => e.SDeliveringHin).IsUnicode(false);

                entity.Property(e => e.SDeliveringNetMovementTransactionId).IsUnicode(false);

                entity.Property(e => e.SDeliveringSupplementaryReference).IsUnicode(false);

                entity.Property(e => e.SMatchingTransactionId).IsUnicode(false);

                entity.Property(e => e.SNetFundsTransactionId).IsUnicode(false);

                entity.Property(e => e.SNettedObligationTransactionId).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SParentTransactionId).IsUnicode(false);

                entity.Property(e => e.SParticipantReference).IsUnicode(false);

                entity.Property(e => e.SReceivingHin).IsUnicode(false);

                entity.Property(e => e.SReceivingNetMovementTransactionId).IsUnicode(false);

                entity.Property(e => e.SReceivingSupplementaryReference).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.SUnderlyingReference).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkDeliveringP)
                    .WithMany(p => p.TblRFullSettlementInstructionFkDeliveringP)
                    .HasForeignKey(d => d.FkDeliveringPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullSettlementInstruction_tbl_D_CHESSUser1");

                entity.HasOne(d => d.FkDutyTypeNavigation)
                    .WithMany(p => p.TblRFullSettlementInstruction)
                    .HasForeignKey(d => d.FkDutyType)
                    .HasConstraintName("FK_tbl_R_FullSettlementInstruction_tbl_S_DutyType");

                entity.HasOne(d => d.FkGuaranteedForeignIndicatorNavigation)
                    .WithMany(p => p.TblRFullSettlementInstruction)
                    .HasForeignKey(d => d.FkGuaranteedForeignIndicator)
                    .HasConstraintName("FK_tbl_R_FullSettlementInstruction_tbl_S_GuaranteedForeignIndicator");

                entity.HasOne(d => d.FkReceivingP)
                    .WithMany(p => p.TblRFullSettlementInstructionFkReceivingP)
                    .HasForeignKey(d => d.FkReceivingPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullSettlementInstruction_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRFullSettlementInstruction)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullSettlementInstruction_tbl_D_ReportRequest");

                entity.HasOne(d => d.FkSettlementInstructionStatusNavigation)
                    .WithMany(p => p.TblRFullSettlementInstruction)
                    .HasForeignKey(d => d.FkSettlementInstructionStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullSettlementInstruction_tbl_S_SettlementInstructionStatus");

                entity.HasOne(d => d.FkTransactionBasisNavigation)
                    .WithMany(p => p.TblRFullSettlementInstruction)
                    .HasForeignKey(d => d.FkTransactionBasis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_FullSettlementInstruction_tbl_S_TransactionBasis");
            });

            modelBuilder.Entity<TblRHolderDetail>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SEmailAddress).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkAdviceReasonNavigation)
                    .WithMany(p => p.TblRHolderDetail)
                    .HasForeignKey(d => d.FkAdviceReason)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HolderDetail_tbl_S_AdviceReason");

                entity.HasOne(d => d.FkControllingP)
                    .WithMany(p => p.TblRHolderDetail)
                    .HasForeignKey(d => d.FkControllingPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HolderDetail_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkEntrepotTypeNavigation)
                    .WithMany(p => p.TblRHolderDetail)
                    .HasForeignKey(d => d.FkEntrepotType)
                    .HasConstraintName("FK_tbl_R_HolderDetail_tbl_S_EntrepotType");

                entity.HasOne(d => d.FkHolderStatusNavigation)
                    .WithMany(p => p.TblRHolderDetail)
                    .HasForeignKey(d => d.FkHolderStatus)
                    .HasConstraintName("FK_tbl_R_HolderDetail_tbl_S_HolderStatus");

                entity.HasOne(d => d.FkHolderTypeNavigation)
                    .WithMany(p => p.TblRHolderDetail)
                    .HasForeignKey(d => d.FkHolderType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HolderDetail_tbl_S_HolderType");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRHolderDetail)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HolderDetail_tbl_D_ReportRequest");

                entity.HasOne(d => d.FkResidencyIndicatorNavigation)
                    .WithMany(p => p.TblRHolderDetail)
                    .HasForeignKey(d => d.FkResidencyIndicator)
                    .HasConstraintName("FK_tbl_R_HolderDetail_tbl_S_ResidencyIndicator");
            });

            modelBuilder.Entity<TblRHolderHistory>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SEmailAddress).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkControllingP)
                    .WithMany(p => p.TblRHolderHistory)
                    .HasForeignKey(d => d.FkControllingPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HolderHistory_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkEmailPurposeNavigation)
                    .WithMany(p => p.TblRHolderHistory)
                    .HasForeignKey(d => d.FkEmailPurpose)
                    .HasConstraintName("FK_tbl_R_HolderHistory_tbl_S_EmailPurpose");

                entity.HasOne(d => d.FkEntrepotTypeNavigation)
                    .WithMany(p => p.TblRHolderHistory)
                    .HasForeignKey(d => d.FkEntrepotType)
                    .HasConstraintName("FK_tbl_R_HolderHistory_tbl_S_EntrepotType");

                entity.HasOne(d => d.FkHolderStatusNavigation)
                    .WithMany(p => p.TblRHolderHistory)
                    .HasForeignKey(d => d.FkHolderStatus)
                    .HasConstraintName("FK_tbl_R_HolderHistory_tbl_S_HolderStatus");

                entity.HasOne(d => d.FkHolderTypeNavigation)
                    .WithMany(p => p.TblRHolderHistory)
                    .HasForeignKey(d => d.FkHolderType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HolderHistory_tbl_S_HolderType");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRHolderHistory)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HolderHistory_tbl_D_ReportRequest");

                entity.HasOne(d => d.FkResidencyIndicatorNavigation)
                    .WithMany(p => p.TblRHolderHistory)
                    .HasForeignKey(d => d.FkResidencyIndicator)
                    .HasConstraintName("FK_tbl_R_HolderHistory_tbl_S_ResidencyIndicator");
            });

            modelBuilder.Entity<TblRHoldingBalance>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkAdviceReasonNavigation)
                    .WithMany(p => p.TblRHoldingBalance)
                    .HasForeignKey(d => d.FkAdviceReason)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HoldingBalance_tbl_S_AdviceReason");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRHoldingBalance)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HoldingBalance_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblRHoldingDailyBalance>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRHoldingDailyBalance)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HoldingDailyBalance_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblRHoldingNetMovement>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRHoldingNetMovement)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HoldingNetMovement_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblRHoldingRegistrationDetails>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SEmailAddress).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkControllingP)
                    .WithMany(p => p.TblRHoldingRegistrationDetails)
                    .HasForeignKey(d => d.FkControllingPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HoldingRegistrationDetails_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkEmailPurposeNavigation)
                    .WithMany(p => p.TblRHoldingRegistrationDetails)
                    .HasForeignKey(d => d.FkEmailPurpose)
                    .HasConstraintName("FK_tbl_R_HoldingRegistrationDetails_tbl_S_EmailPurpose");

                entity.HasOne(d => d.FkHolderStatusNavigation)
                    .WithMany(p => p.TblRHoldingRegistrationDetails)
                    .HasForeignKey(d => d.FkHolderStatus)
                    .HasConstraintName("FK_tbl_R_HoldingRegistrationDetails_tbl_S_HolderStatus");

                entity.HasOne(d => d.FkHolderTypeNavigation)
                    .WithMany(p => p.TblRHoldingRegistrationDetails)
                    .HasForeignKey(d => d.FkHolderType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HoldingRegistrationDetails_tbl_S_HolderType");

                entity.HasOne(d => d.FkRegistrationDetailsIndicatorNavigation)
                    .WithMany(p => p.TblRHoldingRegistrationDetails)
                    .HasForeignKey(d => d.FkRegistrationDetailsIndicator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HoldingRegistrationDetails_tbl_S_RegistrationDetailsIndicator");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRHoldingRegistrationDetails)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_HoldingRegistrationDetails_tbl_D_ReportRequest");

                entity.HasOne(d => d.FkResidencyIndicatorNavigation)
                    .WithMany(p => p.TblRHoldingRegistrationDetails)
                    .HasForeignKey(d => d.FkResidencyIndicator)
                    .HasConstraintName("FK_tbl_R_HoldingRegistrationDetails_tbl_S_ResidencyIndicator");
            });

            modelBuilder.Entity<TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SFundCode).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SReceivingHin).IsUnicode(false);

                entity.Property(e => e.SSrn).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkBrokerNonbrokerIndicatorNavigation)
                    .WithMany(p => p.TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest)
                    .HasForeignKey(d => d.FkBrokerNonbrokerIndicator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_IssuerSponsoredFundtoCHESSConversionAuthorisationRequest_tbl_S_BrokerNonBrokerIndicator");

                entity.HasOne(d => d.FkReceivingP)
                    .WithMany(p => p.TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest)
                    .HasForeignKey(d => d.FkReceivingPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_IssuerSponsoredFundtoCHESSConversionAuthorisationRequest_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_IssuerSponsoredFundtoCHESSConversionAuthorisationRequest_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblRParticipantCounterpartyBalance>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkPayReceiveIndicatorNavigation)
                    .WithMany(p => p.TblRParticipantCounterpartyBalance)
                    .HasForeignKey(d => d.FkPayReceiveIndicator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_ParticipantCounterpartyBalance_tbl_S_PayReceiveIndicator");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblRParticipantCounterpartyBalance)
                    .HasForeignKey(d => d.FkPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_ParticipantCounterpartyBalance_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRParticipantCounterpartyBalance)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_ParticipantCounterpartyBalance_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblRPaymentFacilityDetailHistory>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkPaymentFacilityChangeReasonNavigation)
                    .WithMany(p => p.TblRPaymentFacilityDetailHistory)
                    .HasForeignKey(d => d.FkPaymentFacilityChangeReason)
                    .HasConstraintName("FK_tbl_R_PaymentFacilityDetailHistory_tbl_S_PaymentFacilityChangeReason");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblRPaymentFacilityDetailHistory)
                    .HasForeignKey(d => d.FkPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_PaymentFacilityDetailHistory_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRPaymentFacilityDetailHistory)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_PaymentFacilityDetailHistory_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblRPeriodicIncomeStatement>(entity =>
            {
                entity.HasKey(e => e.KPeriodicIncomeStatement)
                    .HasName("PK_tbl_R_IncomeStatement");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkIncomeNotificationFlagNavigation)
                    .WithMany(p => p.TblRPeriodicIncomeStatement)
                    .HasForeignKey(d => d.FkIncomeNotificationFlag)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_PeriodicIncomeStatement_tbl_S_IncomeNotificationFlag");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblRPeriodicIncomeStatement)
                    .HasForeignKey(d => d.FkPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_PeriodicIncomeStatement_tbl_D_CHESSUser");
            });

            modelBuilder.Entity<TblRRegistryIncomeStatementPartA>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.SSetTransactionId).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkIncomeStatementStatusNavigation)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartA)
                    .HasForeignKey(d => d.FkIncomeStatementStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartA_tbl_S_IncomeStatementStatus");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartA)
                    .HasForeignKey(d => d.FkPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartA_tbl_D_CHESSUser");
            });

            modelBuilder.Entity<TblRRegistryIncomeStatementPartB>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.SSetTransactionId).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkIncomeStatementStatusNavigation)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartB)
                    .HasForeignKey(d => d.FkIncomeStatementStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartB_tbl_S_IncomeStatementStatus");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartB)
                    .HasForeignKey(d => d.FkPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartB_tbl_D_CHESSUser");
            });

            modelBuilder.Entity<TblRRegistryIncomeStatementPartCai>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.SSetTransactionId).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkIncomeStatementStatusNavigation)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartCai)
                    .HasForeignKey(d => d.FkIncomeStatementStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartCAI_tbl_S_IncomeStatementStatus");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartCai)
                    .HasForeignKey(d => d.FkPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartCAI_tbl_D_CHESSUser");
            });

            modelBuilder.Entity<TblRRegistryIncomeStatementPartCcg>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.SSetTransactionId).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkIncomeStatementStatusNavigation)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartCcg)
                    .HasForeignKey(d => d.FkIncomeStatementStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartCCG_tbl_S_IncomeStatementStatus");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartCcg)
                    .HasForeignKey(d => d.FkPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartCCG_tbl_D_CHESSUser");
            });

            modelBuilder.Entity<TblRRegistryIncomeStatementPartCfi>(entity =>
            {
                entity.Property(e => e.KRegistryIncomeStatementPartCfi).ValueGeneratedNever();

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.SSetTransactionId).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkIncomeStatementStatusNavigation)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartCfi)
                    .HasForeignKey(d => d.FkIncomeStatementStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartCFI_tbl_S_IncomeStatementStatus");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartCfi)
                    .HasForeignKey(d => d.FkPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartCFI_tbl_D_CHESSUser");
            });

            modelBuilder.Entity<TblRRegistryIncomeStatementPartCna>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.SSetTransactionId).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkIncomeStatementStatusNavigation)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartCna)
                    .HasForeignKey(d => d.FkIncomeStatementStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartCNA_tbl_S_IncomeStatementStatus");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartCna)
                    .HasForeignKey(d => d.FkPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartCNA_tbl_D_CHESSUser");
            });

            modelBuilder.Entity<TblRRegistryIncomeStatementPartCod>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.SSetTransactionId).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkIncomeStatementStatusNavigation)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartCod)
                    .HasForeignKey(d => d.FkIncomeStatementStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartCOD_tbl_S_IncomeStatementStatus");

                entity.HasOne(d => d.FkP)
                    .WithMany(p => p.TblRRegistryIncomeStatementPartCod)
                    .HasForeignKey(d => d.FkPid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RegistryIncomeStatementPartCOD_tbl_D_CHESSUser");
            });

            modelBuilder.Entity<TblRRescheduledSettlementInstruction>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.STargetTransactionId).IsUnicode(false);

                entity.Property(e => e.SUpdatingTransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRRescheduledSettlementInstruction)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RescheduledSettlementInstruction_tbl_D_ReportRequest");

                entity.HasOne(d => d.FkRescheduleReasonNavigation)
                    .WithMany(p => p.TblRRescheduledSettlementInstruction)
                    .HasForeignKey(d => d.FkRescheduleReason)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_RescheduledSettlementInstruction_tbl_S_RescheduleReason");
            });

            modelBuilder.Entity<TblRSettledSettlementInstruction>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SDeliveringNetMovementTransactionId).IsUnicode(false);

                entity.Property(e => e.SNetFundsTransactionId).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SReceivingNetMovementTransactionId).IsUnicode(false);

                entity.Property(e => e.STransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRSettledSettlementInstruction)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_SettledSettlementInstruction_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblRTopSecurityHolderReport>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRTopSecurityHolderReport)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_TopSecurityHolderReport_tbl_D_ReportRequest");

                entity.HasOne(d => d.FkResidencyIndicatorNavigation)
                    .WithMany(p => p.TblRTopSecurityHolderReport)
                    .HasForeignKey(d => d.FkResidencyIndicator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_TopSecurityHolderReport_tbl_S_ResidencyIndicator");
            });

            modelBuilder.Entity<TblRTotalSecurityBalance>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SApircode).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.SSecurityCode).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRTotalSecurityBalance)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_TotalSecurityBalance_tbl_D_ReportRequest");
            });

            modelBuilder.Entity<TblRUserDetailHistory>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SDefaultAccumulationHin).IsUnicode(false);

                entity.Property(e => e.SDefaultDemandHin).IsUnicode(false);

                entity.Property(e => e.SDefaultSettlementHin).IsUnicode(false);

                entity.Property(e => e.SOriginTransactionId).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FkMasterUicNavigation)
                    .WithMany(p => p.TblRUserDetailHistoryFkMasterUicNavigation)
                    .HasForeignKey(d => d.FkMasterUic)
                    .HasConstraintName("FK_tbl_R_UserDetailHistory_tbl_D_CHESSUser1");

                entity.HasOne(d => d.FkParticipantTypeNavigation)
                    .WithMany(p => p.TblRUserDetailHistory)
                    .HasForeignKey(d => d.FkParticipantType)
                    .HasConstraintName("FK_tbl_R_UserDetailHistory_tbl_S_ParticipantType");

                entity.HasOne(d => d.FkReportRequestNavigation)
                    .WithMany(p => p.TblRUserDetailHistory)
                    .HasForeignKey(d => d.FkReportRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_UserDetailHistory_tbl_D_ReportRequest");

                entity.HasOne(d => d.FkSecurityCodePreferenceNavigation)
                    .WithMany(p => p.TblRUserDetailHistory)
                    .HasForeignKey(d => d.FkSecurityCodePreference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_UserDetailHistory_tbl_S_SecurityCodePreference");

                entity.HasOne(d => d.FkUicNavigation)
                    .WithMany(p => p.TblRUserDetailHistoryFkUicNavigation)
                    .HasForeignKey(d => d.FkUic)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_UserDetailHistory_tbl_D_CHESSUser");

                entity.HasOne(d => d.FkUserStatusNavigation)
                    .WithMany(p => p.TblRUserDetailHistory)
                    .HasForeignKey(d => d.FkUserStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_UserDetailHistory_tbl_S_UserStatus");

                entity.HasOne(d => d.FkUserTypeNavigation)
                    .WithMany(p => p.TblRUserDetailHistory)
                    .HasForeignKey(d => d.FkUserType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_R_UserDetailHistory_tbl_S_UserType");
            });

            modelBuilder.Entity<TblSAccountPurpose>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAccountPurpose)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SAccountPurposeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSAccountType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAccountType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SAccountTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSAdditionalReportingParameter>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAdditionalReportingParameter)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SAdditionalReportingParameterDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSAddressType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddressType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SAddressTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSAdjustmentHistoryStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAdjustmentHistoryStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SAdjustmentHistoryStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSAdjustmentReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAdjustmentReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SAdjustmentReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSAdviceReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAdviceReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SAdviceReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSAusState>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SStateCode).IsUnicode(false);

                entity.Property(e => e.SStateName).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSAuthorisationReason>(entity =>
            {
                entity.HasComment("Indicates why a participant funds obligation authorisation is being requested from a Payment provider.");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAuthorisationReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSBalanceInstruction>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SBalanceInstruction)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SBalanceInstructionDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSBasisOfMovement>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SBasisOfMovement)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SBasisOfMovementDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSBrokerNonBrokerIndicator>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SBrokerNonBroker)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SBrokerNonBrokerDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSCancelReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCancelReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCancelReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSCancellationReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCancellationReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCancellationReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSChangeCashSubrecordRejectReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SChangeCashSubrecordRejectReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SChangeCashSubrecordRejectReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSChargeCommissionTypeCode>(entity =>
            {
                entity.HasKey(e => e.KChargeCommissionTypeCode)
                    .HasName("PK_ChargeCommissionTypeCode");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCodeName).IsUnicode(false);

                entity.Property(e => e.SCtndescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSChesseventType>(entity =>
            {
                entity.HasComment("The type of event that has occurred during CHESS processing.");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SChesseventType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SChesseventTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSCollateralType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCollateralType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCollateralTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSConditionCode>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SConditionCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SConditionCodeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSControllingPidstatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SControllingPidstatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SControllingPidstatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSCorporateActionTypeId>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCorporateActionTypeId)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCorporateActionTypeIdDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSCountry>(entity =>
            {
                entity.HasKey(e => e.KCountry)
                    .HasName("PK_Country");

                entity.HasIndex(e => e.VCountryCode)
                    .HasName("UQ__tbl_C_Co__20D1203E1D1FD7C9")
                    .IsUnique();

                entity.HasIndex(e => e.VCountryName)
                    .HasName("UQ__tbl_C_Co__564E5D80D9C4EEEC")
                    .IsUnique();

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VCountryCode).IsUnicode(false);

                entity.Property(e => e.VCountryName).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSCreditStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCreditStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCreditStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSCurrency>(entity =>
            {
                entity.HasKey(e => e.KCurrency)
                    .HasName("PK_Currency");

                entity.HasIndex(e => e.VCurrencyCode)
                    .HasName("UQ__tbl_C_Cu__719A7C51CA9737E7")
                    .IsUnique();

                entity.HasIndex(e => e.VCurrencyName)
                    .HasName("UQ__tbl_C_Cu__14AB30AC9915A56C")
                    .IsUnique();

                entity.Property(e => e.VCurrencyCode).IsUnicode(false);

                entity.Property(e => e.VCurrencyName).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSDiaryAdjustmentType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SDiaryAdjustmentType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SDiaryAdjustmentTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSDutyType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SDutyType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SDutyTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSEmailPurpose>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SEmailPurpose)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SEmailPurposeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSEntrepotType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SEntrepotType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SEntrepotTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSEsastatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SEsastatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SEsastatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSExchange>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SExchange)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SExchangeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSFatcaquestions>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SFatcaquestions)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SFatcaquestionsDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSFicode>(entity =>
            {
                entity.HasKey(e => e.KFicode)
                    .HasName("PK_BankCodes");

                entity.Property(e => e.IIdentityCode).IsUnicode(false);

                entity.Property(e => e.VFicode).IsUnicode(false);

                entity.Property(e => e.VFiname).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSFundReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SFundReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SFundReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSGroupUnitCode>(entity =>
            {
                entity.HasKey(e => e.KGroupUnitCode)
                    .HasName("PK_tblUnitGroupCode");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSGuaranteedForeignIndicator>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SGuaranteedForeign)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SGuaranteedForeignDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSHoldReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SHoldReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SHoldReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSHolderDrppreference>(entity =>
            {
                entity.HasKey(e => e.KHolderDrppreference)
                    .HasName("PK_tbl_S_HolderDRPReference");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SHolderDrppreference)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SHolderDrppreferenceDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSHolderLockReleaseReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SHolderLockReleaseReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SHolderLockReleaseReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSHolderStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SHolderStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SHolderStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSHolderStatusChange>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SHolderStatusChange)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SHolderStatusChangeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSHolderType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SHolderType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SHolderTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSHoldingTransactionStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SHoldingTransactionStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SHoldingTransactionStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSIncomeNotificationFlag>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SIncomeNotificationFlag)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SIncomeNotificationFlagDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSIncomeStatementReportFrequency>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SIncomeStatementReportFrequency)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSIncomeStatementReportType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SIncomeStatementReportType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SIncomeStatementReportTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSIncomeStatementStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SIncomeStatementStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SIncomeStatementStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSIndividualTaxTypeCode>(entity =>
            {
                entity.HasKey(e => e.KIndividualTaxTypeCode)
                    .HasName("PK_IndividualTaxTypeCode");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCodeName).IsUnicode(false);

                entity.Property(e => e.SCtndescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSInvestmentFundRoleCode>(entity =>
            {
                entity.HasKey(e => e.KInvestmentFundRoleCode)
                    .HasName("PK_InvestmentFundRoleCode");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCodeName).IsUnicode(false);

                entity.Property(e => e.SDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSInvestorType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SInvestorType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SInvestorTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSLevyType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SLevyType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SLevyTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSMarket>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SMarket)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SMarketDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSMessageCategory>(entity =>
            {
                entity.HasKey(e => e.KMessageCategory)
                    .HasName("PK_tbl_S_MessageType");

                entity.Property(e => e.SMessageCategory).IsUnicode(false);
            });

            modelBuilder.Entity<TblSMessageOrigin>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SMessageOrigin).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSMessageType>(entity =>
            {
                entity.HasKey(e => e.KMessageType)
                    .HasName("PK_tbl_S_MessageType_1");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SMessageType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SMessageTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSMovementReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SMovementReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SMovementReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSNettOrGross>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SNettOrGross)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SNettOrGrossDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSNotificationType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SNotificationType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SNotificationTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSOrderStatusCode>(entity =>
            {
                entity.HasKey(e => e.KOrderStatusCode)
                    .HasName("PK_Setr016OrderStatusCode");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCtndescription).IsUnicode(false);

                entity.Property(e => e.SIso20022desc).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSOrderType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SOrderType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SOrderTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSParticipantType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SParticipantType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SParticipantTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSPayReceiveIndicator>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SPayReceive)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SPayReceiveDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSPaymentFacilityChangeReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SPaymentFacilityChangeReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SPaymentFacilityChangeReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSPaymentType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SPaymentType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SPaymentTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSPositionTypeParameter>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SPositionTypeParameter)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SPositionTypeParameterDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSPreviousStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SPreviousStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SPreviousStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSPriceRunType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SPriceRunType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SPriceRunTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSPriceTypeCode>(entity =>
            {
                entity.HasKey(e => e.KPriceTypeCode)
                    .HasName("PK_PriceTypeCode");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCodeName).IsUnicode(false);

                entity.Property(e => e.SCtndescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSProcessingFrequency>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SProcessingFrequency)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSProcessingPeriod>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SFprocessingPeriodDescription).IsUnicode(false);

                entity.Property(e => e.SProcessingPeriod)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSProcessingPoint>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SProcessingPoint)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SProcessingPointDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRedemptionRequestReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRedemptionRequestReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRedemptionRequestReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRegistrationDetailsIndicator>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRegistrationDetails)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRegistrationDetailsDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRegistrationDetailsUpdateReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRegistrationDetailsUpdateReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRegistrationDetailsUpdateReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRegistrationNameUpdateReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRegistrationNameUpdateReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRegistrationNameUpdateReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRegistryRejectReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRegistryRejectReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRegistryRejectReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRejectedChangeReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRejectedChangeReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRejectedChangeReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRejectedHoldingAdviceReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRejectedHoldingAdviceReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRejectedHoldingAdviceReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRejectedIncomeStatementSetReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRejectedIncomeStatementSetReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRejectedIncomeStatementSetReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRejectedOrderReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRejectedReason>(entity =>
            {
                entity.HasKey(e => e.KRejectedReason)
                    .HasName("PK_tbl_S_RejectedReasonCode");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRejectedReasonCode>(entity =>
            {
                entity.HasKey(e => e.KRejectedReasonCode)
                    .HasName("PK_Setr016RejectedReasonCode");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCodeName).IsUnicode(false);

                entity.Property(e => e.SDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRejectedRegistrationUpdateReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRejectedRegistrationUpdateReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRejectedRegistrationUpdateReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRejectedRegistryReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRejectedRegistryReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRejectedRegistryReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRejectedTransferReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRejectedTransferReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRejectedTransferReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRemovalReason>(entity =>
            {
                entity.HasComment("Reason that the Settlement Instruction was removed.");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRemovalReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRemovalReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSReportingId>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SReportName).IsUnicode(false);

                entity.Property(e => e.SReportingId)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSReportingRequestStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SReportingRequestStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SReportingRequestStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRescheduleReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRescheduleReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRescheduleReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSResidencyIndicator>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SResidency)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SResidencyDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRevisedStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SRevisedStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SRevisedStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSRoundingCode>(entity =>
            {
                entity.HasKey(e => e.KRoundingCode)
                    .HasName("PK_tblRoundingCode");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCodeName).IsUnicode(false);

                entity.Property(e => e.SDescription).IsUnicode(false);

                entity.Property(e => e.SRoundingCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSSecurityCodePreference>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SSecurityCodePreference)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SSecurityCodePreferenceDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSSettlementInstructionStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SSettlementInstructionStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SSettlementInstructionStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSSettlementStep>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SSettlementStep)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SSettlementStepDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSSlsloanInstructionStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SSlsloanInstructionStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SSlsloanInstructionStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSSubpositionType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SSubpositionType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SSubpositionTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSSubregisterStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SSubregisterStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SSubregisterStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSTaxExemptionReasonCode>(entity =>
            {
                entity.HasKey(e => e.KTaxExemptionResonCode)
                    .HasName("PK_TaxExemptionReasonCode");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCodeName).IsUnicode(false);

                entity.Property(e => e.SCtndescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSTaxationBasisCode>(entity =>
            {
                entity.HasKey(e => e.KTaxationBasisCode)
                    .HasName("PK_TaxationBasisCode");

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCodeName).IsUnicode(false);

                entity.Property(e => e.SDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSTradeReason>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.STradeReason)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STradeReasonDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSTransactionBasis>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.STransactionBasis)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STransactionBasisDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSTransactionClassParameter>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.STransactionClassParameter)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STransactionClassParameterDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSTransactionStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.STransactionStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STransactionStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSUser>(entity =>
            {
                entity.HasIndex(e => e.SUserName)
                    .HasName("UQ_tbl_S_User_sUserName")
                    .IsUnique();

                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SDescription).IsUnicode(false);

                entity.Property(e => e.SUserName).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSUserStatus>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SUserStatus)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SUserStatusDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblSUserType>(entity =>
            {
                entity.Property(e => e.Dt2CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dt2UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SUserType)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SUserTypeDescription).IsUnicode(false);

                entity.Property(e => e.ZVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
