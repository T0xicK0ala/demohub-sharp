﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHub.Chess.MessageHandlers
{
    public class MessageTypeHandler
    {
        /// <Summary>
        /// Represents an MFund message type.
        /// </Summary>
        #region MFund Message Types
        public enum MessageType
        {
            /// <summary>
            /// 001-02 Demand Single Entry CHESS to CHESS Transfer Request
            /// 
            /// <para>Purpose:
            /// 
            /// To enable a Participant to transfer securities between two CHESS holdings under
            /// its control, e.g. between a Participant's direct and controlled holdings. The
            /// destination account cannot be the participants default Settlement account.
            /// The Participant is advised whether the transfer request was effected or rejected.
            /// Either the Receiving HIN or the Delivering HIN must be present in the message.
            /// Where only one HIN is present, it must not be the same as the default HIN. If both
            /// are present, they must be different.
            /// 
            /// </para>
            /// </summary>
            DemandSingleEntryCHESStoCHESSTransferRequest = 1,
            EffectedDemandSingleEntryCHESStoCHESSTransfer = 2,

            /// <summary>
            /// 003-02 Transferor Submitted Demand Transfer
            /// 
            /// <para>Purpose:
            /// 
            /// To enable two Participants within a Related Participant Structure to transfer
            /// securities between holdings under their control. The ‘Parent Participant’ may
            /// deliver securities to a ‘Related Participant’; the ‘Related Participant’ may deliver
            /// securities to the ‘Parent Participant’.
            /// The transferor Participant is advised whether the transfer request was effected or
            /// rejected. If the transfer is effected, the transferee Participant is advised the details
            /// of the transfer.
            /// The destination account cannot be the participants Settlement account. Participants
            /// should use the new MT107 CHESS message.
            /// 
            /// </para>
            /// </summary>
            TransferorSubmittedDemandTransfer = 3,

            EffectedTransferorSubmittedTransfer = 4,

            /// <summary>
            /// 005-03 Demand Dual Entry CHESS to CHESS Transfer Request
            /// 
            /// <para>Purpose:
            /// 
            /// To transfer securities between CHESS holdings controlled by different Participants
            /// in CHESS. Both Participants are required to enter requests which are then
            /// matched.
            /// If the transfer is originating from the Accumulation Account then there has to be
            /// sufficient units to cover all previously accepted MT107 messages.
            /// If a match is made the transfer is effected immediately and the result is advised to
            ///            both Participants. The Basis of Movement is determined at the point the transfer is
            ///effected.
            ///If no match is made the request is flagged as unmatched, the submitting
            ///Participant is advised that the request is unmatched and the counterparty is
            ///advised of the details.
            ///If Secondary Matching Flag is used, i.e. populated with Y, the Supplementary
            ///Reference field becomes mandatory and populated data must match with
            ///counterparty. Supplementary Reference field must not contain spaces.
            /// 
            /// </para>
            /// </summary>
            DemandDualEntryCHESStoCHESSTransferRequest = 5,

            EffectedDemandDualEntryCHESStoCHESSTransfer = 6,

            /// <summary>
            /// 007-03 Demand CHESS to Issuer Sponsored Transfer Request
            /// 
            /// <para>Purpose:
            /// 
            /// To enable securities in a CHESS holding to be transferred to Issuer sponsored
            ///            form. The Participant is advised that the transfer has been either effected or
            ///rejected.
            ///If the transfer is effected, the transfer details are advised to the Registry.
            /// 
            /// </para>
            /// </summary>
            DemandCHESStoIssuerSponsoredTransferRequest = 7,


            EffectedCHESStoRegistryMovement = 8,
            DemandCHESStoCertificatedTransferRequest = 9,
            AppliedTransferorSubmittedTransfer = 10,
            CHESStoIssuerSponsoredConversionRequest = 11,
            UnmatchedDemandDualEntryCHESStoCHESSTransfer = 12,
            CHESStoCertificatedConversionRequest = 13,
            IssuerSponsoredtoCHESSTransferRequest = 15,
            AcceptedRegistrytoCHESSMovementRequest = 16,
            IssuerSponsoredtoCHESSConversionRequest = 17,
            EffectedSecuritiesTransformation = 18,
            CertificatedtoCHESSConversionRequest = 19,
            ASXClearAcceptedCollateral = 20,
            CertificatedtoCHESSTransferRequest = 21,
            EffectedHoldingAdjustment = 22,
            ASXClearCollateralRemovalRequest = 23,
            RejectedDemandDualEntryCHESStoCHESSTransfer = 24,
            NewSingleEntryTransferRequest = 25,
            CollateralCreationRequest = 27,
            CreatedCollateral = 28,
            CollateralRemovalRequest = 29,
            ReducedCollateral = 30,
            TakeoverAcceptance = 31,
            EffectedTakeoverAcceptance = 32,
            EffectedTakeoverTransfer = 34,
            OfferorTakeoverAcceptanceRejection = 36,
            DemandDualEntryCHESStoCHESSTransferCancellationRequest = 37,
            ReversedTakeoverAcceptance = 38,
            AcceptedCollateralRemovalRequest = 40,
            CollateralRelease = 42,
            CancelledDemandDualEntryTransferRequest = 48,
            EffectedSecurityCodeChange = 50,
            FullDualEntryCHESStoCHESSTransfer = 52,
            FullCHESStoCertificatedTransfer = 54,
            FullCertificatedtoCHESSTransfer = 56,
            FullCertificatedtoCHESSConversion = 58,
            FullIssuerSponsoredtoCHESSTransfer = 60,
            FullIssuerSponsoredtoCHESSConversion = 62,
            FullCHESStoIssuerSponsoredTransfer = 68,
            FullCHESStoCertificatedConversion = 70,
            FullCHESStoIssuerSponsoredConversion = 72,
            FullSingleEntryCHESStoCHESSTransfer = 74,
            RejectedRegistrytoCHESSMovement = 76,
            RejectedCollateralRemoval = 78,
            RejectedRegistrationDetailsUpdate = 80,
            AdjustedSubposition = 82,
            EffectedParticipantTransaction = 84,
            TakeoverAcceptanceRemovalRequest = 85,
            AcceptedTakeoverAcceptanceRemovalRequest = 86,
            RejectedTakeoverAcceptanceRemovalRequest = 88,
            FullTransferorSubmittedDemandTransfer = 90,
            OfferorTakeoverAcceptanceRemovalNotification = 92,
            PriceRegistration = 93,
            SecurityDetail = 96,
            PriceNotificationRegistration = 97,
            PriceNotificationAcceptance = 98,
            TradeRemovalNotification = 100,
            DualEntrySettlementNotification = 101,
            UnmatchedDualEntrySettlementNotification = 102,
            CPCollateralRemovalAuthorisation = 103,
            CollateralRemovalNotification = 104,
            SingleEntrySettlementCHESStoCHESSTransferRequest = 105,
            ScheduledSingleEntrySettlementCHESStoCHESSTransfer = 106,
            ScheduledSettlementCHESStoCHESSTransferRequest = 107,
            CollateralCreationAcceptanceAdvice = 108,
            CPCollateralRemovalRejection = 109,
            CPCollateralRemovalAcceptanceAdvice = 110,
            CancelledSettlementInstruction = 116,
            CancelledChangeSettlementInstructionRequest = 118,
            SingleEntrySettlementCHESStoCHESSTransferCancellationRequest = 119,
            CPCollateralRemovalRejectionAdvice = 120,
            ChangeSettlementInstructionRequest = 121,
            UnmatchedChangeSettlementInstructionRequest = 122,
            ChangeSettlementInstructionCancellationRequest = 123,
            RescheduledSettlementInstruction = 124,
            MaintainSettlementInstructionRequest = 125,
            UpdatedSettlementInstruction = 126,
            AdjustedSettlementInstruction = 128,
            DualEntrySettlementCancellationRequest = 129,
            RequestedSettlementInstructionChange = 130,
            DualEntrySettlementInstructionCancellationRemoval = 131,
            RemovedDualEntrySettlementInstructionCancellationRequest = 132,
            ScheduledNetBrokerBrokerObligation = 134,
            DualEntrySettlementNotificationCancellationRequest = 135,
            ReinstatedBrokerBrokerTrade = 136,
            NettedBrokerBrokerTrade = 138,
            IsolateCounterpartyRequest = 139,
            CancelledNetBrokerBrokerObligation = 140,
            AccruedSettlementInstruction = 142,
            EffectedCPTransaction = 144,
            EffectedNetSettlementMovement = 146,
            ProjectedCumEntitlementPosition = 148,
            ProjectedFundsObligation = 150,
            ProjectedSecuritiesPosition = 152,
            CancelledFundsObligation = 154,
            SettledSettlementInstruction = 156,
            ParticipantCounterpartyBalance = 158,
            CollateralRemovalRejectionAdvice = 160,
            TradeRegistrationRequest = 161,
            SuspendedSettlementInstruction = 162,
            NotifiedBrokerBrokerTrade = 164,
            ScheduledDualEntrySettlementInstruction = 166,
            CPCollateralRemovalAuthorisationRequest = 168,
            EffectedNetFundsMovement = 170,
            EffectedRegistrytoCHESSConversion = 172,
            EffectedRegistrytoCHESSTransfer = 174,
            CollateralCreationRejectionAdvice = 176,
            UnmatchedDualEntrySettlementInstructionCancellationRequest = 178,
            FullSettlementInstruction = 180,
            CollateralRemovaltoCPNotification = 182,
            TradeRegistrationAcceptance = 184,
            NetTrustAmountMovement = 186,
            FullAdjustedSettlementInstruction = 188,
            PredictedPartialFailAdvice = 190,
            Part_SettledSettlementInstruction = 192,
            UnmatchedDualEntryRequest = 194,
            BlockTradeRequest = 195,
            BlockedBrokerBrokerTrade = 196,
            UnblockTradeRequest = 197,
            UnblockedBrokerBrokerTrade = 198,
            NewRegistrationDetails = 201,
            AcceptedNewRegistrationDetails = 202,
            RegistrationDetailsUpdateRequest = 203,
            LockedCHESSHolding = 204,
            UnlockedCHESSHolding = 206,
            AcceptedRegistrationDetailsUpdate = 218,
            AuthorisedRegistrationDetails = 220,
            HolderDetail = 222,
            HolderHistory = 224,
            UserDetail = 226,
            UserHistory = 228,
            PaymentFacilityDetail = 230,
            PaymentFacilityHistory = 232,
            ReportingRequestDetail = 234,
            CreatedPaymentFacility = 240,
            AppliedPaymentFacilityUpdate = 242,
            CancelledPaymentFacilityUpdate = 244,
            ChangeControllingParticipantRequest = 245,
            AcceptedChangeControllingParticipantRequest = 246,
            ChangeControllingParticipantCancellationRequest = 247,
            ChangeControllingParticipantAuthorisationRequest = 248,
            CancelledChangeControllingParticipantRequest = 250,
            ChangeControllingParticipantAuthorisation = 251,
            EffectedChangeControllingParticipant = 252,
            ChangeControllingParticipantRejection = 253,
            RejectedChangeControllingParticipant = 254,
            AppliedChangeControllingParticipantReject = 256,
            LoanApplication = 271,
            AcceptedLoanInstruction = 272,
            LoanApplicationCancellationRequest = 273,
            AdjustedLoan = 274,
            LoanReturnNotification = 275,
            AccruedLoan = 276,
            LoanReturnCancellationRequest = 277,
            ScheduledLoanInstruction = 278,
            BulkLoanApplication280 = 280,
            BulkLoanApplication = 281,
            RejectedLoanApplication = 282,
            CancelledLoanInstruction = 284,
            FullLoanInstruction = 286,
            ParticipantFundsNotification = 300,
            BankFundsNotification = 302,
            ParticipantFundsObligation = 310,
            ParticipantFundsObligationAcknowledgement = 311,
            BankFundsObligation = 312,
            ParticipantFundsObligationRejection = 313,
            BankFundsTransferRequest = 332,
            BankFundsTransferResponse = 333,
            EffectedCreateNetPosition = 340,
            CreateNetPositionRequest = 341,
            CreateNetPositionRecordAuthorisationRequest = 342,
            CreateNetPositionAuthorisation = 343,
            AcceptedCreateNetPositionResponse = 344,
            CreateNetPositionRejection = 345,
            AppliedCreateNetPositionResponse = 346,
            RejectedCreateNetPosition = 348,
            ClearingAccountTransferRequest = 350,
            CreateCashSubrecordRequest = 351,
            CreateCashSubrecordAuthorisationRequest = 352,
            CreateCashSubrecordAuthorisation = 353,
            AcceptedCreateCashSubrecordResponse = 354,
            EffectedCreateCashSubrecord = 356,
            CreateCashSubrecordRejection = 357,
            AppliedCreateCashSubrecordResponse = 358,
            RejectedCreateCashSubrecord = 360,
            ZeroSumNotification = 361,
            CHESSDvPNotification = 362,
            ChangeNetPositionAttributesRequest = 371,
            ChangedNetPositionAttributesNotification = 372,
            BankChangeCashSubrecordAttributesRequest = 373,
            ChangedNetPositionAttributesConfirmation = 374,
            ParticipantChangeCashSubrecordAttributesRequest = 375,
            BankChangeCashSubrecordAttributesConfirmation = 376,
            ParticipantChangeCashSubrecordAttributesAuthorisation = 377,
            AcceptedParticipantChangeCashSubrecordAttributes = 378,
            ParticipantChangeCashSubrecordAttributesRejection = 379,
            ParticipantChangeCashSubrecordAttributesAuthorisationRequest = 380,
            EffectedParticipantChangeCashSubrecordAttributes = 382,
            AppliedParticipantChangeCashSubrecordAttributes = 384,
            RejectedParticipantChangeCashSubrecordAttributes = 386,
            SettlementCancellationNotification = 398,
            SettlementCancellationAcknowledgement = 399,
            RegistrytoCHESSConversionAuthorisation = 401,
            CertificatedtoCHESSConversionAuthorisationRequest = 402,
            RegistrytoCHESSConversionRejection = 403,
            IssuerSponsoredtoCHESSConversionAuthorisationRequest = 404,
            RegistrytoCHESSTransferAuthorisation = 405,
            CertificatedtoCHESSTransferAuthorisationRequest = 406,
            RegistrytoCHESSTransferRejection = 407,
            IssuerSponsoredtoCHESSTransferAuthorisationRequest = 408,
            RequestedSettlementTypeChange = 410,
            CHESStoCertificatedConversion = 412,
            CHESStoCertificatedTransfer = 414,
            CHESStoIssuerSponsoredConversion = 416,
            CHESStoIssuerSponsoredTransfer = 418,
            SecuritiesTransformation = 421,
            AppliedRegistryTransaction = 422,
            HoldingAdjustment = 425,
            AppliedRegistryAuthorisationResponse = 426,
            AppliedCodeChange = 430,
            TakeoverTransfer = 431,
            CancelledOfferorInitiatedTKOAcceptanceRequest = 432,
            CancelSettlementTypeChangeRequest = 441,
            CancelledChangeRTGSInstructionRequest = 442,
            UnmatchedChangeSettlementTypeRequest = 444,
            UpdatedRTGSInstruction = 446,
            AdjustedSettlementType = 448,
            CancelledRequesttoChangeSettlementType = 450,
            ParticipanttoCHESSSRNRequest = 451,
            CHESStoParticipantSRNRequestAcknowledgment = 452,
            RegistrytoCHESSSRNResponse = 453,
            CHESStoRegistrySRNRequest = 454,
            RegistrytoCHESSSRNReject = 455,
            CHESStoRegistrySRNResponseAcknowledgment = 456,
            ParticipanttoCHESSHoldingBalanceRequest = 457,
            CHESStoParticipantSRNResponse = 458,
            RegistrytoCHESSHoldingBalanceResponse = 459,
            CHESStoRegistrySRNRejectAcknowledgment = 460,
            RegistrytoCHESSHoldingBalanceReject = 461,
            CHESStoParticipantSRNReject = 462,
            CHESStoParticipantHoldingBalanceRequestAcknowledgment = 464,
            CHESStoRegistryHoldingBalanceRequest = 466,
            CHESStoRegistryHoldingBalanceResponseAcknowledgment = 468,
            CHESStoParticipantHoldingBalanceResponse = 470,
            CHESStoRegistryHoldingBalanceRejectAcknowledgment = 472,
            CHESStoParticipantHoldingBalanceReject = 474,
            AuthoriseRTGSInstructionConfirmation = 476,
            UnmatchedChangeRTGSInstructionRequest = 478,
            RequestedRTGSInstructionChange = 480,
            RTGSDualEntryNotification = 481,
            UnmatchedRTGSDualEntryNotification = 482,
            RTGSNotificationCancellationRequest = 483,
            UnmatchedRTGSDualEntryRequest = 484,
            RTGSDualEntryCancellationRequest = 485,
            RTGSDualEntryCancellationRemoval = 487,
            ChangeRTGSInstructionRequest = 489,
            UnmatchedRTGSInstructionCancellationRequest = 490,
            ChangeRTGSInstructionCancellationRequest = 491,
            RemovedRTGSInstructionCancellationRequest = 492,
            MaintainRTGSInstructionRequest = 493,
            AuthoriseScheduledRTGSInstruction = 495,
            CheckingRBAFundsQueueAdvice = 496,
            SettlementTypeChangeRequest = 497,
            RTGSInstructionReadytoSettleAdvice = 500,
            HoldingSubpositionDetail = 502,
            ReportingRequest = 503,
            CumEntitlementDailyBalance = 504,
            ReportRequestCancellation = 505,
            CumEntitlementNetMovement = 506,
            HoldingDailyBalance = 508,
            HoldingNetMovement = 510,
            HoldingRegistrationDetails = 512,
            AggregatedForeigntoForeignAllocations = 514,
            RightsAccepted = 516,
            RejectedTransaction = 518,
            CumEntitlementBalance = 520,
            HoldingBalance = 522,
            TotalCumEntitlementBalance = 524,
            AcceptedReportingRequest = 526,
            ArchivedSubRegister = 528,
            CancelledReportingRequest = 530,
            TotalSecurityBalance = 532,
            TaxFileNumberOrAustralianBusinessNumberAdvice = 533,
            NotifiedTaxNumberOrAustralianBusinessNumberAdvice = 534,
            AcceptedTaxNumberOrAustralianBusinessNumberAdvice = 536,
            EndofReporting = 538,
            InvalidTransaction = 540,
            CHESSEventNotification = 542,
            LevyNotification = 544,
            RevisedHolderRegistrationDetails = 546,
            ReversedLevyNotification = 548,
            ScheduledPaymentInstruction = 550,
            AggregatedPaymentRequest = 551,
            AcceptedPaymentSet = 552,
            PaymentSetTotalRecord = 553,
            CloseOutNotification = 554,
            CancelledPaymentSetNotification = 556,
            TopSecurityHolderReport = 560,
            CollateralReleaseRequest = 601,
            EffectedASXClearTransaction = 602,
            CollateralRemovalAuthorisation = 603,
            CollateralRemovalRejection = 605,
            AcceptedCollateral = 607,
            RejectedCollateral = 609,
            CollateralRequest = 610,
            CollateralRemovalAuthorisationRequest = 612,
            CashSubrecordDetails = 614,
            CashSubrecordTotal = 616,
            ETCTradeAdvice = 651,
            ETCTrade = 652,
            ETCTradeAllocationAdvice = 653,
            ETCTradeAdviceAcknowledgment = 654,
            ETCTradeRejectionAdvice = 655,
            ETCTradeAllocation = 656,
            ContractNoteAdvice = 657,
            ETCTradeAllocationAcknowledgment = 658,
            ContractNoteRejectionAdvice = 659,
            ETCTradeRejection = 660,
            AllocationCancellationAdvice = 661,
            ETCTradeRejectionAcknowledgment = 662,
            ETCSettlementAdvice = 663,
            ContractNote = 664,
            ETCSettlementCancellationAdvice = 665,
            ContractNoteAdviceAcknowledgment = 666,
            ETCTradeCancellationAdvice = 667,
            ContractNoteRejection = 668,
            ETCContractNoteCancellationAdvice = 669,
            ContractNoteRejectionAcknowledgment = 670,
            AllocationCancellation = 672,
            AllocationCancellationAcknowledgment = 674,
            ETCSettlement = 676,
            ETCSettlementAdviceAcknowledgment = 678,
            ETCSettlementCancellation = 680,
            ETCSettlementCancellationAcknowledgment = 682,
            ETCTradeCancellation = 684,
            ETCTradeCancellationAcknowledgment = 686,
            ETCContractNoteCancellation = 688,
            ETCContractNoteCancellationAcknowledgment = 690,
            ControllingPIDandHolderStatusRequest = 691,
            ControllingPIDandHolderStatusResponse = 692,
            CancelledConversionorConversionRequest = 694,
            TakeoverAcceptanceRejection = 701,
            TakeoverAcceptanceRemovalAuthorisationRequest = 702,
            TakeoverAcceptanceRemovalAuthorisation = 703,
            TakeoverAcceptanceNotification = 704,
            TakeoverAcceptanceRemovalRejection = 705,
            EffectedOfferorTransaction = 706,
            OfferorTakeoverAcceptanceRemoval = 707,
            RejectedOfferorTakeoverAcceptance = 710,
            OfferorTakeoverAcceptance = 711,
            CHESStoIssuerSponsoredFundConversionRequest = 715,
            CHESSConversionRequesttoIssuerSponsoredFund = 716,
            EffectedCHESSConversionRequesttoIssuerSponsoredFund = 717,
            IssuerSponsoredFundtoCHESSConversionRequest = 718,
            IssuerSponsoredFundtoCHESSConversionAuthorisationRequest = 719,
            AcceptedParticipantRequest = 720,
            ConversionAuthorisationIssuerSponsoredFundtoCHESS = 721,
            FundResponse = 722,
            EffectedConversionIssuerSponsoredFundtoCHESS = 723,
            ConversionRejectionIssuerSponsoredFundtoCHESS = 724,
            RejectedConversionIssuerSponsoredFundtoCHESS = 725,
            ApplicationRequest = 726,
            ApplicationOrderRequest = 727,
            ApplicationOrderOrPaymentPlanApplicationResponse = 729,
            EffectedApplicationOrderOrPaymentPlanApplicationResponse = 730,
            ScheduledSettlementPaymentInstruction = 731,
            UnitAdjustment = 732,
            EffectedFundUnitAdjustment = 733,
            ForeignTaxStatus = 735,
            ForeignTaxStatusDetails = 736,
            InvestorDetails = 737,
            ParticipantInvestorDetails = 738,
            CancelledFundRequest = 740,
            RequestingFundsApproval = 752,
            RTGSSettlementMovement = 754,
            RTGSFundsMovement = 756,
            HoldingAdvice = 757,
            HoldingAdviceAcknowledgment = 758,
            HoldingAdviceAcceptance = 759,
            HoldingAdviceNotification = 760,
            HoldingAdviceRejection = 761,
            EffectedRegistryTransaction = 762,
            AcceptedHoldingAdvice = 764,
            RejectedHoldingAdvice = 766,
            RedemptionRequest = 800,
            RedemptionOrderRequest = 801,
            RedemptionOrderResponse = 802,
            EffectedRedemptionOrderRequest = 803,
            FundOrderCancellationRequest = 804,
            OrderCancellationRequest = 805,
            SwitchRequest = 806,
            SwitchOrderRequest = 807,
            SwitchOrderResponse = 808,
            EffectedSwitchOrderRequest = 809,
            UpdateOrder = 810,
            EffectedUpdateOrder = 811,
            ReminderNotice = 812,
            IncomeStatement = 813,
            IncomeStatementAdvice = 816,
            DistributionReinvestmentNotification = 817,
            EffectedDistributionReinvestmentPlanAdvice = 818,
            CancelledFundsSettlementPaymentInstruction = 822,
            ChangeSettlementDate = 824,
            HoldingDailyFundBalance = 830,
            HoldingNetFundBalance = 831,
            HoldingFundBalance = 832,
            TotalSecurityFundBalance = 833,
            FullIssuerSponsoredFundtoCHESSConversion834 = 834,
            FullCHESStoIssuerSponsoredFundConversion835 = 835,
            ParticipanttoCHESSFundBalanceRequest = 837,
            CHESStoRegistryFundBalanceRequest = 838,
            RegistrytoCHESSFundBalanceResponse = 839,
            CHESStoParticipantFundBalanceResponse = 840,
            RegistrytoCHESSFundBalanceRejection = 841,
            CHESStoParticipantFundBalanceReject = 842,
            TopSecurityFundHolderReport = 844,
            UnitReversalNotification = 845,
            EffectedUnitReversalNotification = 846,
            RejectedRegistryAuthorisation = 860,
            DistributionElectionRequest = 863,
            DistributionElectionAuthorisationRequest = 864,
            DistributionRegistryAuthorisation = 865,
            AcceptedDistributionElectionRequest = 866,
            DistributionRegistryRejection = 867,
            IncomeStatementAuthorisationRequest = 868,
            IncomeStatementRequest = 869,
            AcceptedMarginCoverCreationRequest = 870,
            MarginCoverCreationRequest = 871,
            MarginCoverCreationAuthorisationRequest = 872,
            MarginCoverCreationAuthorisation = 873,
            EffectedMarginCoverReleaseandTransfer = 874,
            MarginCoverCreationRejection = 875,
            AcceptedMarginCoverCreation = 876,
            MarginCoverRemovalRequest = 877,
            ReducedMarginCover = 878,
            MarginCoverRemovalAuthorisation = 879,
            AcceptedMarginCoverRemovalRequest = 880,
            IncomeStatementAuthorisation = 881,
            MarginCoverRemovalAuthorisationRequest = 882,
            ASXClearRemovalMarginCover = 883,
            AcceptedIncomeStatementRequest = 884,
            ASXClearMarginCoverRemovalRequest = 885,
            FullCHESStoIssuerSponsoredFundConversion902 = 902,
            IncomeStatementRejection = 907,
            ExcessCashStandingInstructionRequest = 909,
            DailyInterestEarnedNotification = 911,
            ExcessCashStandingInstructionAuthorisation = 913,
            FullIssuerSponsoredFundtoCHESSConversion914 = 914,
            ExcessCashStandingInstructionRejection = 915,
            MarginSettlementNotification = 917,
            MarginSettlementAmountChangeRequest = 921,
            MarginSettlementAmountChangeAuthorisation = 923,
            MarginSettlementAmountChangeRejection = 925,
            CollateralStatementNotification = 927,
            EndStatementNotification = 929,
            MarginCoverRemovalRejection = 931,
            ExcessCashStandingInstructionAuthorisationRequest = 932,
            AcceptedExcessCashStandingInstructionRequest = 934,
            EffectedExcessCashStandingInstructionRequest = 936,
            RejectedExcessCashStandingInstructionRequest = 938,
            DailyInterestEarnedStatement = 940,
            MarginSettlementAdvice = 942,
            MarginSettlementAmountChangeAuthorisationRequest = 944,
            AcceptedMarginSettlementAmountChangeRequest = 946,
            EffectedMarginSettlementAmountChange = 948,
            RejectedMarginSettlementAmountChange = 950,
            CollateralStatement = 952,
            EndStatement = 954,
            RejectedMarginCoverRemovalRequest = 956,
            RegistryIncomeStatementPartA = 957,
            AcceptedRegistryIncomeStatementSet = 958,
            RegistryIncomeStatementPartB = 959,
            RejectedRegistryIncomeStatementSet = 960,
            RegistryIncomeStatementPartCAi = 961,
            RegistryIncomeStatementPartCCG = 963,
            RegistryIncomeStatementPartCFI = 965,
            RegistryIncomeStatementPartCNA = 967,
            RegistryIncomeStatementPartCOD = 969,
            EndRegistryIncomeStatementSet = 971,
            ParticipantIncomeStatementPartA = 962,
            ParticipantIncomeStatementPartB = 964,
            ParticipantIncomeStatementPartCAi = 966,
            ParticipantIncomeStatementPartCCG = 968,
            ParticipantIncomeStatementPartCFI = 970,
            ParticipantIncomeStatementPartCNA = 972,
            ParticipantIncomeStatementPartCOD = 974,
            EndParticipantIncomeStatementSet = 976
        }
        #endregion MFund Message Types
    }
}