using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoHub.Chess.MessageHandlers
{
    public class MessageFields
    {
        // not exist
        //Distribution Amount Per Unit
        //Distribution Notification Flag
        //Full Transfer
        //Gross Distribution Amount
        //Message Status
        //Nett Distribution Amount
        //Payment Provider Reference
        //Payment Provider UIC
        //Payments from ASX Clear
        //Payments to ASX Clear
        //Rejected Cash Subrecord Reason
        //Superannuation Fund ABN
        //Transferee Holding Fund Balance
        //Transferor Holding Fund Balance
        //Trust Franked Distributions



        #region Bitmap Position 1

        #endregion

        #region Bitmap Position 2
        /// <summary>
        /// Security Code : Identifies the security or non-security payment type that is the subject of a message sent between a user and ASX Clear.May
        /// be either an ISIN security code or an ASX code.On input, either is accepted, on output, the previously requested format is used.
        /// Allowable Values: A valid ISIN code
        ///                   A valid security code issued by ASX
        ///                   Or one of the following ASX codes assigned to identify miscellaneous payments:
        ///                   PYYAPP: Application payment
        ///                   PYYCLM: Payment related to a type of claim, e.g. dividend
        ///                   PYYDER: Derivatives related payment
        ///                   PYYDIV: Dividend related payment
        ///                   PYYOTC: Payment for OTC derivatives instruments
        ///                   PYYPFT: Portfolio related payment
        ///                   PYYSET: Adjustment to settlement obligation
        ///                   PYYSLN: Security lending payment
        ///                   PYYTKO: Takeover proceeds payment
        ///                   PYYWAR: Warrant related payment
        ///                   
        /// Cross Reference                 
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //008-03 Effected CHESS to Registry Movement
        //009-03 Demand CHESS to Certificated Transfer Request
        //010-03 Applied Transferor Submitted Transfer
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //022-03 Effected Holding Adjustment
        //023-01 ACH Collateral Removal Request
        //025-01 Single Entry Transfer Request
        //027-03 Collateral Creation Request
        //029-03 Collateral Removal Request
        //031-02 Takeover Acceptance
        //034-04 Effected Takeover Transfer
        //036-01 Offeror Takeover Acceptance Notification
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //082-01 Adjusted Subposition
        //085-02 Takeover Acceptance Removal Request
        //090-03 Full Transferor Submitted Demand Transfer
        //092-01 Offeror Takeover Acceptance Removal Notification
        //093-01 Price Registration
        //096-01 Security Detail
        //097-02 Price Notification Registration
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //104-01 Collateral Removal Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //108-01 Collateral Creation Acceptance Advice
        //121-02 Change Settlement Instruction Request
        //130-02 Requested Settlement Instruction Change
        //134-01 Scheduled Net Obligation
        //142-02 Accrued Settlement Instruction
        //146-03 Effected Net Settlement Movement
        //148-01 Projected Cum Entitlement Position
        //152-01 Projected Holding Position
        //160-01 Collateral Removal Rejection Advice
        //161-02 Trade Registration Request
        //164-03 Notified Trade
        //168-01 CP Collateral Removal Authorisation Request
        //176-01 Collateral Creation Rejection Advice
        //180-02 Full Settlement Instruction
        //182-01 Collateral Removal to CP Notification
        //204-01 Locked CHESS Holding
        //206-01 Unlocked CHESS Holding
        //271-01 Loan Application
        //275-01 Loan Return Notification
        //276-02 Accrued Loan
        //278-01 Scheduled Loan Instruction
        //280-01 Bulk Loan Application
        //286-01 Full Loan Instruction
        //401-01 Registry to CHESS Conversion Authorisation
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //403-01 Registry to CHESS Conversion Rejection
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //405-01 Registry to CHESS Transfer Authorisation
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //407-01 Registry to CHESS Transfer Rejection
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //425-01 Holding Adjustment
        //431-01 Takeover Transfer
        //451-01 Participant to CHESS SRN Request
        //453-01 Registry to CHESS SRN Response
        //454-01 CHESS to Registry SRN Request
        //455-01 Registry to CHESS SRN Reject
        //457-01 Participant to CHESS Holding Balance Request
        //459-01 Registry to CHESS Holding Balance Response
        //461-01 Registry to CHESS Holding Balance Reject
        //466-01 CHESS to Registry Holding Balance Request
        //480-01 Requested RTGS Instruction Change
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //502-02 Holding Subposition Detail
        //504-01 Cum Entitlement Daily Balance
        //506-01 Cum Entitlement Net Movement
        //508-01 Holding Daily Balance
        //510-01 Holding Net Movement
        //512-04 Holding Registration Details
        //514-01 Aggregated Foreign to Foreign Allocations
        //516-01 Rights Accepted
        //520-02 Cum Entitlement Balance
        //522-02 Holding Balance
        //524-01 Total Cum Entitlement Balance
        //528-01 Archived Sub-Register
        //532-01 Total Security Balance
        //533-02 Tax File Number / Australian Business Number Advice
        //534-02 Notified Tax File Number / Australian Business Number
        //544-01 Levy Notification
        //546-01 Revised Holder Registration Details
        //554-01 Close Out Notification
        //560-01 Top Security Holder Report
        //561-01 CCMS CHESS Security Message
        //565-01 CCMS Reconciliation Balance
        //570-01 Pending Equity Settlement Balance
        //571-01 Collateral Source Account Movement Notification
        //572-01 Collateral Transfer Request
        //576-01 CCMS Collateral Transfer Notification
        //577-01 CMAX Settlement Balance Update
        //578-01 Position Update
        //581-01 Accepted Corporate Action Message Set
        //582-01 Rejected Corporate Action Message Set
        //583-01 CCMS Collateral Account Adjustment
        //584-01 CCMS Cum Entitlement Transfer
        //586-01 Linked Collateral Transfer Request
        //601-04 Collateral Release Request
        //610-04 Collateral Request
        //612-04 Collateral Removal Authorisation Request
        //651-01 ETC Trade Advice
        //652-01 ETC Trade
        //657-01 Contract Note Advice
        //663-01 ETC Settlement Advice
        //664-01 Contract Note
        //676-01 ETC Settlement
        //694-01 Cancelled Transfer or Conversion Request
        //702-02 Takeover Acceptance Removal Authorisation Request
        //704-02 Takeover Acceptance Notification
        //707-01 Offeror Takeover Acceptance Removal
        //711-01 Offeror Takeover Acceptance
        //754-01 RTGS Settlement Movement
        //757-02 Holding Advice
        //760-02 Holding Advice Notification
        //813-01 Income Statement
        //816-01 Income Statement Advice
        //863-01 Distribution Election Request
        //864-01 Distribution Election Authorisation Request
        //868-01 Income Statement Authorisation Request
        //869-01 Income Statement Request
        //871-01 Margin Cover Creation Request
        //872-01 Margin Cover Creation Authorisation Request
        //874-01 Effected Margin Cover Release and Transfer
        //877-01 Margin Cover Removal Request
        //882-01 Margin Cover Removal Authorisation Request
        //883-01 ASXCL Removal Margin Cover
        //885-01 ASXCL Margin Cover Removal Request
        //887-01 STP Collateral Removal Request
        //888-01 STP Collateral Removal Authorisation Request
        //890-01 Scheduled STP Transfer
        //894-01 STP Collateral Removal CP Authorisation Request
        //896-01 STP Collateral Removal CP Notification
        //927-01 Collateral Statement Notification
        //952-01 Collateral Statement
        //957-02Registry Income Statement Part A
        //959-01 Registry Income Statement Part B
        //961-01 Registry Income Statement Part C AI
        //962-02Participant Income Statement Part A
        //963-01 Registry Income Statement Part C CG
        //964-01 Participant Income Statement Part B
        //965-01 Registry Income Statement Part C FI
        //966-01 Participant Income Statement Part C AI
        //967-02Registry Income Statement Part C NA
        //968-01 Participant Income Statement Part C CG
        //969-01 Registry Income Statement Part C OD
        //970-01 Participant Income Statement Part C FI
        //972-02Participant Income Statement Part C NA
        //974-01 Participant Income Statement Part C OD
        #endregion Cross Reference End
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SecurityCode { get; set; }

        /// <summary>
        /// Fund Code : Identifies the fund that is the subject of a message sent between a user and ASX Clear.
        /// May be either an ISIN security code or an ASX code. On input, either is accepted, on output, the previously requested format is used.
        /// 
        /// Allowable Values A valid ISIN code in the format prescribed by ISO Standard 6166; or a valid security code issued by ASX, 
        /// left justified and followed by spaces.
        /// 
        /// Cross Reference
        #region Cross Reference
        //715-01 CHESS to Issuer Sponsored Fund Conversion Request
        //716-01 CHESS Conversion Request to Issuer Sponsored Fund
        //717-01 Effected CHESS Conversion to Issuer Sponsored Fund
        //718-02 Issuer Sponsored Fund to CHESS Conversion Request
        //719-02 Issuer Sponsored Fund to CHESS Conversion Authorisation Request
        //721-01 Conversion Authorisation Issuer Sponsored Fund to CHESS
        //724-01 Conversion Rejection Issuer Sponsored Fund to CHESS
        //726-02 Application Request
        //727-02 Application Order Request
        //729-02 Application Order/Payment Plan Application Response
        //730-02 Effected Application Order/Payment Plan Application Response
        //731-01 Scheduled Settlement Payment Instruction
        //732-02 Unit Adjustment
        //733-02 Effected Fund Unit Adjustment
        //735-01 Foreign Tax Status
        //736-01 Foreign Tax Status
        //800-02 Redemption Request
        //801-02 Redemption Order Request
        //802-02 Redemption Order Response
        //803-02 Effected Redemption Order Request
        //812-01 Reminder Notice
        //817-01 Distribution Re-investment Notification
        //818-01 Effected Distribution Re-investment Plan Advice
        //822-01 Cancelled Funds Settlement Payment Instruction
        //830-01 Holding Daily Fund Balance
        //831-01 Holding Net Fund Movement
        //832-01 Holding Fund Balance
        //833-01 Total Security Fund Balance
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        //837-01 Participant to CHESS Fund Balance Request
        //838-01 CHESS to Registry Fund Balance Request
        //839-01 Registry to CHESS Fund Balance Response
        //841-01 Registry to CHESS Fund Balance Rejection
        //844-01 Top Security Fund Holder Report
        //845-02 Unit Reversal Notification
        //846-02 Effected Unit Reversal Notification
        #endregion Cross Reference End
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string FundCode { get; set; }

        /// <summary>
        /// Previous Security Code : Specifies the security code of a settlement instruction or holding before it was altered.
        /// 
        /// 050-02 Effected Security Code Change
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// 274-01 Adjusted Loan
        /// 430-01 Applied Code Change
        /// 922-01 Adjusted Scheduled STP Release
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PreviousSecurityCode { get; set; }

        /// <summary>
        /// Redemption Fund Code : Identifies the fund that is the subject of a redemption request
        /// message sent between a user and ASX Clear. May be either an
        /// ISIN security code or an ASX code. On input, either is accepted,
        /// on output, the previously requested format is used.
        /// 
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// 808-02Switch Order Response
        /// 809-02Effected Switch Order Request
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RedemptionFundCode { get; set; }

        /// <summary>
        /// Reducing Security Code : The code of the security that, along with the HIN, identifies the
        /// CHESS holding that is to be reduced following the application of a registry transaction.
        /// 
        /// 018-02 Effected Holding Transformation
        /// 421-01 Holding Transformation
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ReducingSecurityCode { get; set; }

        /// <summary>
        /// Security Code Parameter : Restricts reporting to entities related to a particular security code.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SecurityCodeParameter { get; set; }
        #endregion

        #region Bitmap Position 3
        /// <summary>
        /// Format : 15 Signed Numerics, 2 decimal places
        /// 
        /// Authorised Amount : The dollar value of funds that a payment provider intermediary has authorised for settlement and placed in escrow pending transfer.
        /// 
        /// 154-01 Cancelled Funds Obligation
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AuthorisedAmount { get; set; }

        /// <summary>
        /// Excess Cash Standing Instruction : Indicates the Excess Cash Standing Instruction the Participant has/would like at ASX Clear.
        /// 
        /// Allowable Values CHESS will only accept a positive value for this message field
        /// 
        /// 909-01 Excess Cash Standing Instruction Request
        /// 917-01 Margin Settlement Notification
        /// 932-01 Excess Cash Standing Instruction Authorisation Request
        /// 942-01 Margin Settlement Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ExcessCashStandingInstruction { get; set; }

        /// <summary>
        /// Format : 15 Signed Numerics, 2 decimal places
        /// 
        /// Fund Amount : The dollar value of a fund transaction in CHESS.
        /// 
        /// Allowable Values The sign is always shown as positive (‘+’).
        /// 
        /// 726-02 Application Request
        /// 727-02 Application Order Request
        /// 729-02 Application Order/Payment Plan Application Response
        /// 730-02 Effected Application Order/Payment Plan Application Response
        /// 800-02 Redemption Request
        /// 801-02 Redemption Order Request
        /// 802-02 Redemption Order Response
        /// 803-02 Effected Redemption Order Request
        /// 806-02 Switch Request
        /// 807-02 Switch Order Request
        /// 808-02 Switch Order Response
        /// 809-02 Effected Switch Order Request
        /// 822-01 Cancelled Funds Settlement Payment Instruction
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string FundAmount { get; set; }

        /// <summary>
        /// Gross DRP Amount : The gross dollar value of a Fund dividend reinvestment in CHESS.
        /// 
        /// 817-01 Distribution Re-investment Notification
        /// 818-01 Effected Distribution Re-investment Plan Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string GrossDRPAmount { get; set; }

        /// <summary>
        /// Gross Income Amount : The gross dollar value of an income distribution in CHESS.
        /// 
        /// 813-01 Income Statement
        /// 816-01 Income Statement Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string GrossIncomeAmount { get; set; }

        /// <summary>
        /// Interest Amount : The calculated interest amount.
        /// 
        /// 911-01 Daily Interest Earned Notification
        /// 940-01 Daily Interest Earned Statement
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string InterestAmount { get; set; }

        /// <summary>
        /// Loan Consideration : The consideration provided for an SLS loan. The consideration
        /// includes any additional margins called during the period of the loan.
        /// 
        /// 276-02 Accrued Loan
        /// 278-01 Scheduled Loan Instruction
        /// 280-01 Bulk Loan Application
        /// 286-01 Full Loan Instruction
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string LoanConsideration { get; set; }

        /// <summary>
        /// New Settlement Amount : The new settlement after a margin settlement amount change has been effected in ASX Clear.
        /// 
        /// 923-01 Margin Settlement Amount Change Authorisation
        /// 948-01 Effected Margin Settlement Amount Change
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string NewSettlementAmount { get; set; }

        /// <summary>
        /// Previous Loan Consideration : Specifies the loan consideration of an SLS loan before it was altered.
        /// 
        /// 274-01 Adjusted Loan
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PreviousLoanConsideration { get; set; }

        /// <summary>
        /// Previous Settlement Amount : Specifies the settlement amount of a settlement instruction before it was altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// 192-01 Part-Settled Settlement Instruction
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PreviousSettlementAmount { get; set; }

        /// <summary>
        /// Projected Funds Position : The estimated funds position for a payment facility in a future
        /// settlement cycle. Positive (‘+’) indicates receiving funds, negative (‘-’)
        /// indicates paying funds.
        /// 
        /// 150-01 Projected Funds Obligation
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ProjectedFundsPosition { get; set; }

        /// <summary>
        /// Settlement Amount : The dollar value amount that is settled in a settlement instruction.
        /// 
        /// The sign is normally positive (‘+’) which indicates the value is moving
        /// contra to the units (ie., the receiving participant is paying the
        /// settlement amount). In unusual situations, the sign is negative (‘-’)
        /// which indicates the value moves with the units (ie., the delivering
        /// participant is paying the settlement amount). If no units are specified
        /// in the message, positive indicates receiving funds, negative
        /// indicates paying funds.
        /// 
        /// Cross Reference
        #region Cross Reference
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //121-02 Change Settlement Instruction Request
        //130-02 Requested Settlement Instruction Change
        //134-01 Scheduled Net Obligation
        //142-02 Accrued Settlement Instruction
        //161-02 Trade Registration Request
        //164-03 Notified Trade
        //166-01 Scheduled Dual Entry Settlement Instruction
        //170-01 Effected Net Funds Movement
        //180-02 Full Settlement Instruction
        //480-01 Requested RTGS Instruction Change
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //500-01 RTGS Instruction Ready to Settle Advice
        //550-01 Scheduled Payment Instruction
        //657-01 Contract Note Advice
        //663-01 ETC Settlement Advice
        //664-01 Contract Note
        //676-01 ETC Settlement
        //731-01 Scheduled Settlement Payment Instruction
        //756-01 RTGS Funds Movement
        //917-01 Margin Settlement Notification
        //921-01 Margin Settlement Amount Change Request
        //942-01 Margin Settlement Advice
        //944-01 Margin Settlement Amount Change Authorisation Request
        #endregion Cross Reference End
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SettlementAmount { get; set; }

        /// <summary>
        /// Shortfall Valuation : Specifies the current dollar value of the securities shortfall.
        /// 
        /// 544-01 Levy Notification
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ShortfallValuation { get; set; }
        #endregion

        #region Bitmap Position 4
        /// <summary> 
        /// Cash Balance Bought Forward : The cash balance prior to the previous settlement. Refer to Cash Balance Carried Forward.
        /// 
        /// 917-01 Margin Settlement Notification
        /// 942-01 Margin Settlement Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string CashBalanceBoughtForward { get; set; }

        /// <summary>
        /// Levy Value : The GST exclusive dollar value of the levy charged to the user.
        /// 
        /// 544-01 Levy Notification
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string LevyValue { get; set; }

        /// <summary>
        /// New Resultant Excess : The new resulting cash balance after a margin settlement amount change has been effected in ASX Clear.
        /// The cash balance that the Clearing Participant holds with ASX Clear, assuming settlement is successful.
        /// The New Resultant Excess will be calculated by ASX Clear when the Clearing Participant elects to change their Settlement Amount.
        /// 
        /// 923-01 Margin Settlement Amount Change Authorisation
        /// 948-01 Effected Margin Settlement Amount Change
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string NewResultantExcess { get; set; }

        /// <summary>
        /// Outstanding Settlement Amount : The dollar amount that remains to be settled for a settlement instruction.
        /// 
        /// 180-02 Full Settlement Instruction
        /// 554-01 Close Out Notification
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string OutstandingSettlementAmount { get; set; }

        /// <summary>
        /// Reversed Levy Value : The dollar value of the portion of a levy being reversed.
        /// 
        /// 548-02 Reversed Levy Notification
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ReversedLevyValue { get; set; }

        /// <summary>
        /// Revised Loan Consideration : Specifies the revised loan consideration of an SLS Loan after it has been altered.
        /// 
        /// 274-01 Adjusted Loan
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RevisedLoanConsideration { get; set; }

        /// <summary>
        /// Revised Settlement Amount : Specifies the revised settlement amount of a settlement instruction after it has been altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// 192-01 Part-Settled Settlement Instruction
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RevisedSettlementAmount { get; set; }
        #endregion

        #region Bitmap Position 5
        /// <summary>
        /// Balance Instruction : Participant instruction stating how the balance of a certificated holding should be 
        /// processed following the dematerialisation of a portion of a certificated holding.
        /// 
        /// Allowable Values 'H' = Hold
        ///                  'I' = Issue
        ///                  
        /// 021-02 Certificated to CHESS Transfer Request
        /// 056-03 Full Certificated to CHESS Transfer
        /// 406-02 Certificated to CHESS Transfer Authorisation Request
        /// </summary>
        public static readonly char[] BalanceInstruction = new char[2] { 'H', 'I' };

        /// <summary>
        /// Price Run Type : Identifies the type of price run being transmitted
        /// 
        /// Allowable Values ‘C’ = Closing
        ///                  ‘I’ = Intraday
        ///                  
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        public static readonly char[] PriceRunType = new char[2] { 'C', 'I' };
        #endregion

        #region Bitmap Position 6
        /// <summary>
        /// Registry Reject Reason : The reason that a registry has not been able to process an issuer sponsored/certificated transfer or enquiry.
        /// 
        /// Allowable Values ‘A’ = No Matching SRN
        ///                     will be returned to the submitting participant if the SRN specified as part of a holding Balance Enquiry is not found.
        ///                  ‘B’ = SRN and Verification Details do not Match
        ///                     will be returned to the submitting participant if the SRN specified as part of a Holding Balance Enquiry is found BUT
        ///                     the SRN verification details (i.e. surname / company name ) do not match the record found.)
        ///                  ‘C’= No Matching Registration Details Found
        ///                     will be returned to the submitting participant if the registration details specified as part of a SRN Enquiry are not found.)
        ///                  ‘D’ = Duplicate Registration Detail Records Exist
        ///                     will be returned to the submitting participant if the registration details specified as part of a SRN Enquiry are duplicated 
        ///                     in the issuer/registries records.)
        ///                  ‘E’ = Invalid Holder Status
        ///                     will be returned to the submitting participant if the holder status is invalid.
        ///                     
        /// 455-01 Registry to CHESS SRN Reject
        /// 461-01 Registry to CHESS Holding Balance Reject
        /// 462-01 CHESS to Participant SRN Reject
        /// 474-01 CHESS to Participant Holding Balance Reject
        /// 841-01 Registry to CHESS Fund Balance Rejection
        /// 842-01 CHESS to Participant Fund Balance Reject
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly char[] RegistryRejectReason = new char[5] { 'A', 'B', 'C', 'D', 'E' };
        #endregion

        #region Bitmap Position 7
        /// <summary>
        /// Corporate Action Type Id : Identifies a type of corporate action. Used in conjunction with Ex Date to identify a specific corporate action
        /// (eg., a dividend with an ex period commencing on the Ex Date).
        /// 
        /// Allowable Values 'CD' = Dividend
        ///                  ‘CQ’ = Equal Access Buyback
        ///                  'CR' = Rights issue
        ///                  'CB' = Bonus issue
        ///                  'CE' = Entitlement
        ///                  'CC' = Capital return
        ///                  'CM' = Premium return
        ///                  'CI' = Interest
        ///                  'CZ' = Non Pro Rata Balance
        ///                  
        /// 148-01 Projected Cum Entitlement Position
        /// 188-02 Full Adjusted Settlement Instruction
        /// 504-01 Cum Entitlement Daily Balance
        /// 506-01 Cum Entitlement Net Movement
        /// 520-02 Cum Entitlement Balance
        /// 524-01 Total Cum Entitlement Balance
        /// 544-01 Levy Notification
        /// </summary>
        public static readonly string[] CorporateActionTypeId = new string[9] { "CD", "CQ", "CR", "CB", "CE", "CC", "CM", "CI", "CZ" };

        /// <summary>
        /// Corporate Action Type Id Parameter : Restricts the scope of a reporting request to a specific corporate action. 
        /// Used in conjunction with Ex Date Parameter.
        /// 
        /// Allowable Values 'CD' = Dividend
        ///                  ‘CQ’ = Equal Access Buyback
        ///                  'CR' = Rights issue
        ///                  'CB' = Bonus issue
        ///                  'CE' = Entitlement
        ///                  'CC' = Capital return
        ///                  'CM' = Premium return
        ///                  'CI' = Interest
        ///                  'CZ' = Non Pro Rata Balance
        ///                  
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        public static readonly string[] CorporateActionTypeIdParameter = new string[9] { "CD", "CQ", "CR", "CB", "CE", "CC", "CM", "CI", "CZ" };
        #endregion

        #region Bitmap Position 8
        /// <summary>
        /// Certificate Number : The unique number of a certificate issued for a particular class of security, or the Held Balance Reference Number
        /// of a balance held at the issuer pursuant to a partial transfer, or the marking number of a marked transfer.
        /// 
        /// 019-02 Certificated to CHESS Conversion Request
        /// 021-02 Certificated to CHESS Transfer Request
        /// 056-03 Full Certificated to CHESS Transfer
        /// 058-03 Full Certificated to CHESS Conversion
        /// 402-02 Certificated to CHESS Conversion Authorisation Request
        /// 406-02 Certificated to CHESS Transfer Authorisation Request
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string CertificateNumber { get; set; }

        /// <summary>
        /// Marking Number : Reference number of a held balance on a certificated subregister.
        /// Allocated by the registry when a partial transfer of securities occurs.
        /// (Also called Held Balance Reference Number in ASX Business Rules and industry procedures.)
        /// 
        /// 174-02 Effected Registry to CHESS Transfer
        /// 405-01 Registry to CHESS Transfer Authorisation
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string MarkingNumber { get; set; }
        #endregion

        #region Bitmap Position 9
        /// <summary>
        /// Contact : Name of person or business unit within a participant organisation through which personal contact may be made.
        /// 
        /// 226-01 User Detail
        /// 228-01 User History
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Contact { get; set; }
        #endregion

        #region Bitmap Position 10
        /// <summary>
        /// Application Fund Code : Identifies the fund that is the subject of an application request message sent between a user and ASX Clear.
        /// May be either an ISIN security code or an ASX code. On input, either is accepted, on output, the previously requested format is used.
        /// 
        /// Allowable Values A valid ISIN code in the format prescribed by ISO Standard 6166;
        ///                  or a valid security code issued by ASX, left justified and followed by spaces.
        /// 
        /// 806-01Switch Request
        /// 806-02Switch Request
        /// 807-01Switch Order Request
        /// 807-02Switch Order Request
        /// 808-01Switch Order Response
        /// 808-02Switch Order Response
        /// 809-01Effected Switch Order Request
        /// 809-02Effected Switch Order Request
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ApplicationFundCode { get; set; }

        /// <summary>
        /// Increasing Security Code : The code of the security that, along with the HIN, identifies the
        /// CHESS holding that is to be increased following the application of a
        /// registry transaction.
        /// 
        /// 018-02 Effected Holding Transformation
        /// 421-01 Holding Transformation
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string IncreasingSecurityCode { get; set; }

        /// <summary>
        /// ISIN : The International Security Identification Number is a unique identifier for certain securities.
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ISIN { get; set; }

        /// <summary>
        /// Revised Security Code : Specifies the revised security code of a settlement instruction or holding after it has changed.
        /// 
        /// 050-02 Effected Security Code Change
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// 274-01 Adjusted Loan
        /// 430-01 Applied Code Change
        /// 583-01 CCMS Collateral Account Adjustment
        /// 922-01 Adjusted Scheduled STP Release
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RevisedSecurityCode { get; set; }

        #endregion

        #region Bitmap Position 11
        /// <summary>
        /// Foreign Residency Indicator : Definition Identifies where a party to an Account Type is foreign.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  ‘N’ = No
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] ForeignResidencyIndicator = new char[2] { 'Y', 'N' };

        /// <summary>
        /// Full Redemption : Indicates that the investor requests redemption of all units.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  ‘N’ = No
        /// 
        /// 800-02Redemption Request
        /// 801-02Redemption Order Request
        /// </summary>
        public static readonly char[] FullRedemption = new char[2] { 'Y', 'N' };

        /// <summary>
        /// Full Switch : Indicates that the investor requests to switch all units to another nominated fund.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  ‘N’ = No
        /// 
        /// 800-02Redemption Request
        /// 801-02Redemption Order Request
        /// </summary>
        public static readonly char[] FullSwitch = new char[2] { 'Y', 'N' };

        /// <summary>
        /// Income Notification Flag : The state of the Income Statement Advice; whether it is the advice or a subsequent amended advice.
        /// 
        /// Allowable Values ‘I’ = Income Statement
        ///                  ‘A’ = Amendment to an Income Statement
        ///                  
        /// 813-01 Income Statement
        /// 816-01 Income Statement Advice
        /// </summary>
        public static readonly char[] IncomeNotificationFlag = new char[2] { 'I', 'A' };

        /// <summary>
        /// Initial Application : Indicates, for an AMFS Application request, whether the investor is
        /// applying for units in a specified fund for the first time.
        /// 
        /// Allowable Values 'Y' = Yes
        ///                  'N' = No
        /// </summary>
        public static readonly char[] InitialApplication = new char[2] { 'Y', 'N' };

        /// <summary>
        /// Transaction Basis : Characterises a movement of securities.
        /// 
        /// Allowable Values ‘F’ = Facility for Non Reportable Transactions
        ///                  ‘I’ = IPO Transaction
        ///                  'M' = Market
        ///                  'O' = Off-Market
        ///                  'L' = Stock Lending Activity
        ///                  
        /// Cross Reference
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //010-03 Applied Transferor Submitted Transfer
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //021-02 Certificated to CHESS Transfer Request
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //121-02 Change Settlement Instruction Request
        //130-02 Requested Settlement Instruction Change
        //142-02 Accrued Settlement Instruction
        //164-03 Notified Trade
        //180-02 Full Settlement Instruction
        //480-01 Requested RTGS Instruction Change
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //554-01 Close Out Notification
        //601-04 Collateral Release Request
        //651-01 ETC Trade Advice
        //652-01 ETC Trade
        //663-01 ETC Settlement Advice
        //676-01 ETC Settlement
        #endregion Cross Reference End
        /// </summary>
        public static readonly char[] TransactionBasis = new char[5] { 'F', 'I', 'M', 'O', 'L' };

        /// <summary>
        /// Previous Transaction Basis : Specifies the transaction basis of a settlement instruction before it was altered.
        /// 
        /// Allowable Values ‘F’ = Facility for Non Reportable Transactions
        ///                  ‘I’ = IPO Transaction
        ///                  'M' = Market
        ///                  'O' = Off-Market
        ///                  'L' = Stock Lending Activity
        ///                  
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        public static readonly char[] PreviousTransactionBasis = new char[5] { 'F', 'I', 'M', 'O', 'L' };
        #endregion

        #region Bitmap Position 12
        /// <summary>
        /// Date : Specifies the date that an entity was created in CHESS. An entity may be a transaction (eg. transfer) 
        /// or a historical record (eg. holding daily balance).
        /// 
        /// Allowable Values A valid date in the format YYYYMMDD, eg. 19930625
        /// 
        /// 504-01 Cum Entitlement Daily Balance
        /// 506-01 Cum Entitlement Net Movement
        /// 508-01 Holding Daily Balance
        /// 510-01 Holding Net Movement
        /// 514-01 Aggregated Foreign to Foreign Allocations
        /// 562-01 CCMS End Message
        /// 587-01 End of Linked Transfer Message Set
        /// 830-01 Holding Daily Fund Balance
        /// 831-01 Holding Net Fund Movement
        /// 911-01 Daily Interest Earned Notification
        /// 927-01 Collateral Statement Notification
        /// 929-01 End Statement Notification
        /// 940-01 Daily Interest Earned Statement
        /// 952-01 Collateral Statement
        /// 954-01 End Statement
        /// 971-01 End Registry Income Statement Set
        /// 976-01 End Participant Income Statement Set
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Date { get; set; }

        /// <summary>
        /// Date of Event : Specifies the date of the holder status change event.
        /// 
        /// 203-04 Registration Details Update Request
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DateofEvent { get; set; }

        /// <summary>
        /// Dispatch Date : Identifies the nominated despatch date for a corporate action.
        /// 
        /// 544-01 Levy Notification
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DispatchDate { get; set; }

        /// <summary>
        /// ETC Settlement Date : Identifies the settlement date of the ETC transaction. 
        /// Must be included for all transactions for which the settlement date is known.
        /// 
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ETCSettlementDate { get; set; }

        /// <summary>
        /// First Listed Date : The date in which a security starts official quotation.
        /// 
        /// 096-01 Security Detail
        /// 561-01 CCMS CHESS Security Message
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string FirstListedDate { get; set; }

        /// <summary>
        /// Margin Payment Date : The date in which the margin is to be settled.
        /// 
        /// 917-01 Margin Settlement Notification
        /// 942-01 Margin Settlement Advice
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string MarginPaymentDate { get; set; }

        /// <summary>
        /// Opening Balance Date : Specifies the date on which the opening balance (total unit quantity registered for a CHESS holding) is based.
        /// 
        /// 560-01 Top Security Holder Report
        /// 844-01 Top Security Fund Holder Report
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string OpeningBalanceDate { get; set; }

        /// <summary>
        /// Original Settlement Date : Identifies an original settlement cycle in which a settlement instruction was scheduled to settle.
        /// 
        /// Allowable Values Any date specified by ASX as a Settlement Date.
        /// 
        /// 554-01 Close Out Notification
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string OriginalSettlementDate { get; set; }

        /// <summary>
        /// Previous Settlement Date : Specifies the settlement date of a settlement instruction before it was altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// 448-01 Adjusted Settlement Type
        /// 922-01 Adjusted Scheduled STP Release
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PreviousSettlementDate { get; set; }

        /// <summary>
        /// Price Run Date : Indicates the date for which the price data is applicable.
        /// 
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PriceRunDate { get; set; }

        /// <summary>
        /// Removal Date : Identifies the nominated removal date for a warrant series being held as collateral by derivatives.
        /// 
        /// 104-01 Collateral Removal Notification
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RemovalDate { get; set; }

        /// <summary>
        /// Reporting Start Date : The first date on which a reporting request is to be actioned.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ReportingStartDate { get; set; }

        /// <summary>
        /// Settlement Date : Identifies a settlement cycle in which settlement instructions are
        /// settled by effecting transfers on the CHESS subregister and the transfer of funds.
        /// 
        /// Allowable Values Any date specified by ASX as a settlement day.
        /// 
        /// Cross Reference
        #region Cross Reference
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //121-02 Change Settlement Instruction Request
        //124-01 Rescheduled Settlement Instruction
        //130-02 Requested Settlement Instruction Change
        //134-01 Scheduled Net Obligation
        //142-02 Accrued Settlement Instruction
        //148-01 Projected Cum Entitlement Position
        //150-01 Projected Funds Obligation
        //152-01 Projected Holding Position
        //154-01 Cancelled Funds Obligation
        //164-03 Notified Trade
        //170-01 Effected Net Funds Movement
        //180-02 Full Settlement Instruction
        //184-01 Trade Registration Acceptance
        //186-01 Net Trust Amount Movement
        //192-01 Part-Settled Settlement Instruction
        //278-01 Scheduled Loan Instruction
        //300-01 Participant Funds Notification
        //302-01 Payment Provider Funds Notification
        //310-02 Participant Funds Obligation
        //312-01 Payment Provider Funds Obligation
        //332-01 Payment Provider Transfer Request
        //350-01 Clearing Account Transfer Request
        //361-01 Zero Sum Notification
        //362-01 CHESS DvP Notification
        //398-01 Settlement Cancellation Notification
        //410-01 Requested Settlement Type Change
        //444-01 Unmatched Change Settlement Type Request
        //480-01 Requested RTGS Instruction Change
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //497-01 Settlement Type Change Request
        //544-01 Levy Notification
        //550-01 Scheduled Payment Instruction
        //551-01 Aggregated Payment Request
        //552-01 Accepted Payment Set
        //553-01 Payment Set Total Record
        //556-01 Cancelled Payment Set Notification
        //570-01 Pending Equity Settlement Balance
        //614-01 Cash Subrecord Details
        //616-01 Cash Subrecord Total
        //731-01 Scheduled Settlement Payment Instruction
        //756-01 RTGS Funds Movement
        //822-01 Cancelled Funds Settlement Payment Instruction
        //824-01 Change Settlement Date
        //888-01 STP Collateral Removal Authorisation Request
        //890-01 Scheduled STP Transfer
        //894-01 STP Collateral Removal CP Authorisation Request
        //896-01 STP Collateral Removal CP Notification
        //926-01 Scheduled STP Collateral Removal
        #endregion Cross Reference End
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SettlementDate { get; set; }
        #endregion

        #region Bitmap Position 13
        /// <summary>
        /// Closing Balance Date : Specifies the date on which the closing balance (total unit quantity registered for a CHESS holding) is based.
        /// 
        /// 560-01 Top Security Holder Report
        /// 844-01 Top Security Fund Holder Report
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ClosingBalanceDate { get; set; }

        /// <summary>
        /// Last Date Traded : Indicates the date the last on-market price was captured.
        /// 
        /// 097-02 Price Notification Registration
        /// 093-01 Price Registration
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string LastDateTraded { get; set; }

        /// <summary>
        /// Last Listed Date : The date in which the security ceases official quotation
        /// 
        /// 096-01 Security Detail
        /// 561-01 CCMS CHESS Security Message
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string LastListedDate { get; set; }

        /// <summary>
        /// Reporting End Date : The last date on which a scheduled reporting request is to be actioned.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ReportingEndDate { get; set; }

        /// <summary>
        /// Revised Settlement Date : Specifies the revised settlement date of a settlement instruction after it has been altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// 448-01 Adjusted Settlement Type
        /// 922-01 Adjusted Scheduled STP Release
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RevisedSettlementDate { get; set; }

        /// <summary>
        /// Trade Date : The date on which a trade was originally made and the basis for calculating settlement date.
        /// 
        /// Cross Reference
        #region Cross Reference
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //161-02 Trade Registration Request
        //164-03 Notified Trade
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //651-01 ETC Trade Advice
        //652-01 ETC Trade
        //657-01 Contract Note Advice
        //663-01 ETC Settlement Advice
        //664-01 Contract Note
        //676-01 ETC Settlement
        #endregion Cross Reference End
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TradeDate { get; set; }

        /// <summary>
        /// Transaction Date : Specifies the business date that a transaction was effected.
        /// 
        /// 544-01 Levy Notification
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TransactionDate { get; set; }
        #endregion

        #region Bitmap Position 14
        /// <summary>
        /// Account : Indicates whether the collateral is covering a House or Client obligation. Currently, only House is valid.
        /// 
        /// Allowable Values “HOUSE” – House Account
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        public static readonly string Account = "HOUSE";

        /// <summary>
        /// Payment Set Transaction Id : Identifies ‘Aggregated Payment Request’ messages in a unique
        /// Payment Set within CHESS. Allocated by the user on submission of
        /// ‘Aggregated Payment Request’ messages and the ‘Payment Set
        /// Total Record’ message. The same Payment Set Transaction Id must
        /// appear on all such messages submitted on the same settlement date.
        /// 
        /// Allowable Values ‘DDMMYY-NNN’, where ‘NNN’ is the batch number, initialised to 001
        /// at the start of each settlement date.
        /// 
        /// Cross Reference
        #region Cross Reference 1
        //551-01 Aggregated Payment Request
        //552-01 Accepted Payment Set
        //553-01 Payment Set Total Record
        #endregion Cross Reference 1 End

        #region Cross Reference 2
        //556-01 Cancelled Payment Set Notification
        #endregion Cross Reference 2 End
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PaymentSetTransactionId { get; set; }
        #endregion

        #region Bitmap Position 15

        #endregion

        #region Bitmap Position 16
        /// <summary>
        /// HIN : Holder Identification Number. Uniquely identifies a holder within CHESS.
        /// A holder may be associated with more than one HIN, eg. if sponsored by several brokers.
        /// Defaults to one of the participant's default HINs depending on the message type, 
        /// where the HIN is optional(and not specified) on a message.
        /// 
        /// Cross Reference
        #region Cross Reference
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //018-02 Effected Holding Transformation
        //022-03 Effected Holding Adjustment
        //023-01 ACH Collateral Removal Request
        //027-03 Collateral Creation Request
        //029-03 Collateral Removal Request
        //031-02 Takeover Acceptance
        //036-01 Offeror Takeover Acceptance Notification
        //050-02 Effected Security Code Change
        //082-01 Adjusted Subposition
        //085-02 Takeover Acceptance Removal Request
        //092-01 Offeror Takeover Acceptance Removal Notification
        //101-02 Dual Entry Settlement Notification
        //104-01 Collateral Removal Notification
        //108-01 Collateral Creation Acceptance Advice
        //125-01 Maintain Settlement Instruction Request
        //146-03 Effected Net Settlement Movement
        //148-01 Projected Cum Entitlement Position
        //152-01 Projected Holding Position
        //160-01 Collateral Removal Rejection Advice
        //168-01 CP Collateral Removal Authorisation Request
        //176-01 Collateral Creation Rejection Advice
        //182-01 Collateral Removal to CP Notification
        //202-01 Accepted New Registration Details
        //203-04 Registration Details Update Request
        //204-01 Locked CHESS Holding
        //206-01 Unlocked CHESS Holding
        //220-02 Authorised Registration Details
        //222-04 Holder Detail
        //224-03 Holder History
        //230-01 Payment Facility Detail
        //232-01 Payment Facility History
        //240-01 Created Payment Facility
        //242-01 Applied Payment Facility Update
        //245-01 Change Controlling Participant Request
        //248-01 Change Controlling Participant Authorisation Request
        //252-01 Effected Controlling Participant Change
        //421-01 Holding Transformation
        //425-01 Holding Adjustment
        //444-01 Unmatched Change Settlement Type Request
        //481-01 RTGS Dual Entry Notification
        //493-01 Maintain RTGS Instruction Request
        //497-01 Settlement Type Change Request
        //502-02 Holding Subposition Detail
        //504-01 Cum Entitlement Daily Balance
        //506-01 Cum Entitlement Net Movement
        //508-01 Holding Daily Balance
        //510-01 Holding Net Movement
        //512-04 Holding Registration Details
        //514-01 Aggregated Foreign to Foreign Allocations
        //516-01 Rights Accepted
        //520-02 Cum Entitlement Balance
        //522-02 Holding Balance
        //533-02 Tax File Number / Australian Business Number Advice
        //534-02 Notified Tax File Number / Australian Business Number
        //544-01 Levy Notification
        //546-01 Revised Holder Registration Details
        //560-01 Top Security Holder Report
        //565-01 CCMS Reconciliation Balance
        //583-01 CCMS Collateral Account Adjustment
        //584-01 CCMS Cum Entitlement Transfer
        //610-04 Collateral Request
        //612-04 Collateral Removal Authorisation Request
        //691-01 Controlling PID and Holder Status Request
        //692-01 Controlling PID and Holder Status Response
        //702-02 Takeover Acceptance Removal Authorisation Request
        //704-02 Takeover Acceptance Notification
        //707-01 Offeror Takeover Acceptance Removal
        //711-01 Offeror Takeover Acceptance
        //726-02Application Request
        //727-02Application Order Request
        //729-02Application Order/Payment Plan Application Response
        //730-02Effected Application Order/Payment Plan Application Response
        //732-02Unit Adjustment
        //733-02Effected Fund Unit Adjustment
        //735-01 Foreign Tax Status
        //736-01 Foreign Tax Status
        //754-01 RTGS Settlement Movement
        //757-02 Holding Advice
        //760-02 Holding Advice Notification
        //800-02Redemption Request
        //801-02Redemption Order Request
        //802-02Redemption Order Response
        //803-02Effected Redemption Order Request
        //806-02 Switch Request
        //807-02Switch Order Request
        //808-02Switch Order Response
        //809-02Effected Switch Order Request
        //812-01 Reminder Notice
        //813-01 Income Statement
        //816-01 Income Statement Advice
        //817-01 Distribution Re-investment Notification
        //818-01 Effected Distribution Re-investment Plan Advice
        //830-01 Holding Daily Fund Balance
        //831-01 Holding Net Fund Movement
        //832-01 Holding Fund Balance
        //844-01 Top Security Fund Holder Report
        //845-02Unit Reversal Notification
        //846-02Effected Unit Reversal Notification
        //863-01 Distribution Election Request
        //864-01 Distribution Election Authorisation Request
        //868-01 Income Statement Authorisation Request
        //869-01 Income Statement Request
        //871-01 Margin Cover Creation Request
        //872-01 Margin Cover Creation Authorisation Request
        //877-01 Margin Cover Removal Request
        //882-01 Margin Cover Removal Authorisation Request
        //883-01 ASXCL Removal Margin Cover
        //888-01 STP Collateral Removal Authorisation Request
        //922-01 Adjusted Scheduled STP Release
        //927-01 Collateral Statement Notification
        //952-01 Collateral Statement
        //957-02Registry Income Statement Part A
        //959-01 Registry Income Statement Part B
        //961-01 Registry Income Statement Part C AI
        //962-02Participant Income Statement Part A
        //963-01 Registry Income Statement Part C CG
        //964-01 Participant Income Statement Part B
        //965-01 Registry Income Statement Part C FI
        //966-01 Participant Income Statement Part C AI
        //967-02Registry Income Statement Part C NA
        //968-01 Participant Income Statement Part C CG
        //969-01 Registry Income Statement Part C OD
        //970-01 Participant Income Statement Part C FI
        //972-02Participant Income Statement Part C NA
        //974-01 Participant Income Statement Part C OD
        #endregion Cross Reference
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string HIN { get; set; }

        /// <summary>
        /// Default Settlement HIN : Specifies the HIN that is used as the target of all settlement instructions submitted by a participant
        /// that do not explicitly target another HIN. The HIN must be controlled by the participant or their Master user.
        /// 
        /// 226-01 User Detail
        /// 228-01 User History
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DefaultSettlementHIN { get; set; }

        /// <summary>
        /// HIN Parameter : Restricts the scope of a reporting request to a specific holder.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string HINParameter { get; set; }

        /// <summary>
        /// Payment HIN : The HIN associated with a Payment Facility
        /// 
        /// 731-01 Scheduled Settlement Payment Instruction
        /// 822-01 Cancelled Funds Settlement Payment Instruction
        /// 824-01 Change Settlement Date
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PaymentHIN { get; set; }

        /// <summary>
        /// Previous Delivering HIN : Specifies the delivering HIN of a settlement instruction before it was altered.
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PreviousDeliveringHIN { get; set; }

        /// <summary>
        /// Previous HIN : Specifies the previous HIN of a settlement instruction before it was altered.
        /// 
        /// 448-01 Adjusted Settlement Type
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PreviousHIN { get; set; }

        /// <summary>
        /// Receiving HIN : The HIN of the holder who is the registered owner of the holding
        /// which is to receive the securities. Defaults to the participant's default settlement HIN.
        /// 
        /// Cross Reference
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //010-03 Applied Transferor Submitted Transfer
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //025-01 Single Entry Transfer Request
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //142-02 Accrued Settlement Instruction
        //180-02 Full Settlement Instruction
        //271-01 Loan Application
        //278-01 Scheduled Loan Instruction
        //286-01 Full Loan Instruction
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //431-01 Takeover Transfer
        //572-01 Collateral Transfer Request
        //576-01 CCMS Collateral Transfer Notification
        //577-01 CMAX Settlement Balance Update
        //586-01 Linked Collateral Transfer Request
        //601-04 Collateral Release Request
        //718-02Issuer Sponsored Fund to CHESS Conversion Request
        //719-02Issuer Sponsored Fund to CHESS Conversion Authorisation Request
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //874-01 Effected Margin Cover Release and Transfer
        //885-01 ASXCL Margin Cover Removal Request
        //887-01 STP Collateral Removal Request
        //890-01 Scheduled STP Transfer
        //894-01 STP Collateral Removal CP Authorisation Request
        //896-01 STP Collateral Removal CP Notification
        #endregion Cross Reference End
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ReceivingHIN { get; set; }
        #endregion

        #region Bitmap Position 17
        /// <summary>
        /// Default Demand HIN : Specifies the HIN that is used as the target of all demand transactions (except 'Registry to CHESS' transfers)
        /// submitted by a participant that do not explicitly target another HIN. The HIN must be controlled by the participant.
        /// 
        /// 226-01 User Detail
        /// 228-01 User History
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DefaultDemandHIN { get; set; }

        /// <summary>
        /// Delivering HIN : The HIN of the holder who is the registered owner of the holding from which the securities are to be delivered.
        /// Defaults to the participant's default settlement HIN.
        /// 
        /// Cross Reference
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //008-03 Effected CHESS to Registry Movement
        //009-03 Demand CHESS to Certificated Transfer Request
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //013-02 CHESS to Certificated Conversion Request
        //025-01 Single Entry Transfer Request
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //142-02 Accrued Settlement Instruction
        //180-02 Full Settlement Instruction
        //275-01 Loan Return Notification
        //278-01 Scheduled Loan Instruction
        //281-01 Bulk Loan Approval
        //286-01 Full Loan Instruction
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //431-01 Takeover Transfer
        //572-01 Collateral Transfer Request
        //576-01 CCMS Collateral Transfer Notification
        //577-01 CMAX Settlement Balance Update
        //586-01 Linked Collateral Transfer Request
        //601-04 Collateral Release Request
        //715-01 CHESS to Issuer Sponsored Fund Conversion Request
        //716-01 CHESS Conversion Request to Issuer Sponsored Fund
        //717-01 Effected CHESS Conversion to Issuer Sponsored Fund
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        //874-01 Effected Margin Cover Release and Transfer
        //885-01 ASXCL Margin Cover Removal Request
        //887-01 STP Collateral Removal Request
        //890-01 Scheduled STP Transfer
        //894-01 STP Collateral Removal CP Authorisation Request
        //896-01 STP Collateral Removal CP Notification
        #endregion Cross Reference End
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DeliveringHIN { get; set; }

        /// <summary>
        /// Previous Receiving HIN : Specifies the receiving HIN of a settlement instruction before it was altered.
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PreviousReceivingHIN { get; set; }

        /// <summary>
        /// Revised HIN : Specifies the HIN of a settlement instruction before it was altered.
        /// 
        /// 448-01 Adjusted Settlement Type
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RevisedHIN { get; set; }
        #endregion

        #region Bitmap Position 18
        /// <summary>
        /// Holder Type : Defines the type of CHESS holder. Determines the service that CHESS provides for the holder.
        /// Allowable Values 'D' = Direct
        ///                  'E' = Entrepot
        ///                  'S' = Sponsored
        /// 
        /// 201-04 New Registration Details
        /// 220-02 Authorised Registration Details
        /// 222-04 Holder Detail
        /// 224-03 Holder History
        /// 512-04 Holding Registration Details
        /// 560-01 Top Security Holder Report
        /// 844-01 Top Security Fund Holder Report
        /// </summary>
        public static readonly char[] HolderType = new char[3] { 'D', 'E', 'S' };

        /// <summary>
        /// DRP Preference : Indicates that the investor has selected dividend reinvestment (Y) or cash (Y) for their entitlements.
        /// 
        /// Allowable Values 'Y' = Yes
        ///                  'N' = No
        ///                  
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        public static readonly char[] DRPPreference = new char[2] { 'Y', 'N' };
        #endregion

        #region Bitmap Position 19
        /// <summary>
        /// PID : Participant Identifier. Unique identifier of a CHESS participant allocated by ASX Clear.
        /// 
        /// Allowable Values Any value allocated by ASX to identify a CHESS participant
        /// 
        /// Cross Reference
        #region Cross Reference
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //148-01 Projected Cum Entitlement Position
        //152-01 Projected Holding Position
        //158-01 Participant Counterparty Balance
        //230-01 Payment Facility Detail
        //232-01 Payment Facility History
        //240-01 Created Payment Facility
        //242-01 Applied Payment Facility Update
        //300-01 Participant Funds Notification
        //310-02 Participant Funds Obligation
        //342-01 Create Net Position Record Authorisation Request
        //343-01 Create Net Position Authorisation
        //345-01 Create Net Position Rejection
        //352-01 Create Cash Subrecord Authorisation Request
        //353-01 Create Cash Subrecord Authorisation
        //357-01 Create Cash Subrecord Rejection
        //371-01 Change Net Position Attributes Request
        //373-01 Payment Provider Change Cash Subrecord Attributes Request
        //377-01 Participant Change Cash Subrecord Attributes Authorisation
        //379-01 Participant Change Cash Subrecord Attributes Rejection
        //380-01 Participant Change Cash Subrecord Attributes Authorisation Request
        //727-02Application Order Request
        //729-02Application Order/Payment Plan Application Response
        //732-02Unit Adjustment
        //736-01 Foreign Tax Status
        //801-02Redemption Order Request
        //802-02Redemption Order Response
        //805-01 Order Cancellation Request
        //807-02Switch Order Request
        //808-02Switch Order Response
        //810-01 Update Order
        //812-01 Reminder Notice
        //813-01 Income Statement
        //817-01 Distribution Re-investment Notification
        //845-02Unit Reversal Notification
        //846-02Effected Unit Reversal Notification
        //864-01 Distribution Election Authorisation Request
        //868-01 Income Statement Authorisation Request
        //872-01 Margin Cover Creation Authorisation Request
        //882-01 Margin Cover Removal Authorisation Request
        //911-01 Daily Interest Earned Notification
        //917-01 Margin Settlement Notification
        //927-01 Collateral Statement Notification
        //932-01 Excess Cash Standing Instruction Authorisation Request
        //944-01 Margin Settlement Amount Change Authorisation Request
        //957-02Registry Income Statement Part A
        //959-01 Registry Income Statement Part B
        //961-01 Registry Income Statement Part C AI
        //963-01 Registry Income Statement Part C CG
        //965-01 Registry Income Statement Part C FI
        //967-02Registry Income Statement Part C NA
        //969-01 Registry Income Statement Part C OD
        #endregion Cross Reference End
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PID { get; set; }

        /// <summary>
        /// PID Parameter : Restricts the scope of reporting to entities which relate to a specific user.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PIDParameter { get; set; }

        /// <summary>
        /// Target UIC : Identifies the CHESS user that is the target of the transaction.
        /// 
        /// 453-01 Registry to CHESS SRN Response
        /// 454-01 CHESS to Registry SRN Request
        /// 455-01 Registry to CHESS SRN Reject
        /// 459-01 Registry to CHESS Holding Balance Response
        /// 461-01 Registry to CHESS Holding Balance Reject
        /// 466-01 CHESS to Registry Holding Balance Request
        /// 759-01 Holding Advice Acceptance
        /// 760-02 Holding Advice Notification
        /// 761-01 Holding Advice Rejection
        /// 865-01 Distribution Election Registry Authorisation
        /// 867-01 Distribution Election Registry Rejection
        /// 881-01 Income Statement Authorisation
        /// 907-01 Income Statement Rejection
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TargetUIC { get; set; }

        /// <summary>
        /// Controlling PID : The PID of a participant which controls a CHESS holder.
        /// 
        /// 108-01 Collateral Creation Acceptance Advice
        /// 160-01 Collateral Removal Rejection Advice
        /// 168-01 CP Collateral Removal Authorisation Request
        /// 176-01 Collateral Creation Rejection Advice
        /// 182-01 Collateral Removal to CP Notification
        /// 222-04 Holder Detail
        /// 224-03 Holder History
        /// 245-01 Change Controlling Participant Request
        /// 512-04 Holding Registration Details
        /// 560-01 Top Security Holder Report
        /// 565-01 CCMS Reconciliation Balance
        /// 583-01 CCMS Collateral Account Adjustment
        /// 692-01 Controlling PID and Holder Status Response
        /// 844-01 Top Security Fund Holder Report
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ControllingPID { get; set; }

        /// <summary>
        /// Bank UIC : The PID of the Payment Provider acting on behalf of the participant.
        /// 
        /// 240-01 Created Payment Facility
        /// 242-01 Applied Payment Facility Update
        /// 350-01 Clearing Account Transfer Request
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string BankUIC { get; set; }

        /// <summary>
        /// ETC Source UIC : Identifies the CHESS user that initiated the type of transaction with which it is associated.
        /// 
        /// 652-01 ETC Trade
        /// 656-02 ETC Trade Allocation
        /// 660-01 ETC Trade Rejection
        /// 664-01 Contract Note
        /// 668-01 Contract Note Rejection
        /// 672-01 Allocation Cancellation
        /// 676-01 ETC Settlement
        /// 680-01 ETC Settlement Cancellation
        /// 684-01 ETC Trade Cancellation
        /// 688-01 ETC Contract Note Cancellation
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ETCSourceUIC { get; set; }

        /// <summary>
        /// ETC Target UIC : Identifies the CHESS user that is the target of the transaction with which it is associated.
        /// 
        /// 651-01 ETC Trade Advice
        /// 653-02 ETC Trade Allocation Advice
        /// 655-01 ETC Trade Rejection Advice
        /// 657-01 Contract Note Advice
        /// 659-01 Contract Note Rejection Advice
        /// 661-01 Allocation Cancellation Advice
        /// 663-01 ETC Settlement Advice
        /// 665-01 ETC Settlement Cancellation Advice
        /// 667-01 ETC Trade Cancellation Advice
        /// 669-01 ETC Contract Note Cancellation Advice
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ETCTargetUIC { get; set; }

        /// <summary>
        /// Old Controlling PID : Identifies the old controlling PID of a holder.
        /// 
        /// 252-01 Effected Controlling Participant Change
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string OldControllingPID { get; set; }

        /// <summary>
        /// Payer PID : Identifies the CHESS participant that is paying funds free of delivery.
        /// 
        /// Allowable Values Any value allocated by ASX to identify a CHESS participant.
        /// 
        /// 550-01 Scheduled Payment Instruction
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PayerPID { get; set; }

        /// <summary>
        /// Paying PID : Identifies the CHESS participant that is paying funds.
        /// 
        /// Allowable Values Any value allocated by ASX to identify a CHESS participant.
        /// 
        /// 731-01 Scheduled Settlement Payment Instruction
        /// 822-01 Cancelled Funds Settlement Payment Instruction
        /// 824-01 Change Settlement Date
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PayingPID { get; set; }

        /// <summary>
        /// Receiving PID : The PID of the participant which controls the receiving HIN of a securities movement.
        /// 
        /// Cross Reference
        #region Cross Reference
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //025-01 Single Entry Transfer Request
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //090-03 Full Transferor Submitted Demand Transfer
        //134-01 Scheduled Net Obligation
        //142-02 Accrued Settlement Instruction
        //161-02 Trade Registration Request
        //164-03 Notified Trade
        //180-02 Full Settlement Instruction
        //278-01 Scheduled Loan Instruction
        //286-01 Full Loan Instruction
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //431-01 Takeover Transfer
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //572-01 Collateral Transfer Request
        //576-01 CCMS Collateral Transfer Notification
        //577-01 CMAX Settlement Balance Update
        //586-01 Linked Collateral Transfer Request
        //719-02Issuer Sponsored Fund to CHESS Conversion Authorisation Request
        //731-01 Scheduled Settlement Payment Instruction
        //822-01 Cancelled Funds Settlement Payment Instruction
        //824-01 Change Settlement Date
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //874-01 Effected Margin Cover Release and Transfer
        #endregion Cross Reference End
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ReceivingPID { get; set; }

        /// <summary>
        /// Requesting Participant : The PID of the participant who initiated the transaction.
        /// 
        /// 248-01 Change Controlling Participant Authorisation Request
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RequestingParticipant { get; set; }

        /// <summary>
        /// UIC : The User Identification Code which is a unique identifier for a CHESS user. Superset of PID.
        /// 
        /// Allowable Values Any value allocated by ASX Settlement to identify a User.
        /// 
        /// 226-01 User Detail
        /// 228-01 User History
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string UIC { get; set; }
        #endregion

        #region Bitmap Position 20
        /// <summary>
        /// Delivering PID : The PID of the participant who controls the delivering HIN of a securities movement.
        /// 
        /// Cross Reference
        #region Cross Reference
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //010-03 Applied Transferor Submitted Transfer
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //025-01 Single Entry Transfer Request
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //090-03 Full Transferor Submitted Demand Transfer
        //134-01 Scheduled Net Obligation
        //142-02 Accrued Settlement Instruction
        //161-02 Trade Registration Request
        //164-03 Notified Trade
        //180-02 Full Settlement Instruction
        //278-01 Scheduled Loan Instruction
        //286-01 Full Loan Instruction
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //572-01 Collateral Transfer Request
        //576-01 CCMS Collateral Transfer Notification
        //577-01 CMAX Settlement Balance Update
        //586-01 Linked Collateral Transfer Request
        //716-01 CHESS Conversion Request to Issuer Sponsored Fund
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        //874-01 Effected Margin Cover Release and Transfer
        //894-01 STP Collateral Removal CP Authorisation Request
        //896-01 STP Collateral Removal CP Notification
        #endregion Cross Reference End
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DeliveringPID { get; set; }

        /// <summary>
        /// Master UIC : Identifies a CHESS user to which another CHESS user is related.
        /// CHESS users with the same Master UIC are considered to be
        /// related to each other through the Master UIC. A user who is a
        /// Master UIC cannot be related to another Master UIC.
        /// 
        /// 226-01 User Detail
        /// 228-01 User History
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string MasterUIC { get; set; }

        /// <summary>
        /// New Controlling PID : Identifies the new controlling PID of a holder.
        /// 
        /// 252-01 Effected Controlling Participant Change
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string NewControllingPID { get; set; }

        /// <summary>
        /// Payee PID : Identifies the CHESS participant that is receiving funds free of delivery.
        /// 
        /// Allowable Values Any value allocated by ASX to identify a CHESS participant.
        /// 
        /// 550-01 Scheduled Payment Instruction
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PayeePID { get; set; }

        /// <summary>
        /// Settlement Counterparty PID : Identifies the PID of the settlement counterparty for the target user.
        /// 
        /// 653-02 ETC Trade Allocation Advice
        /// 656-02 ETC Trade Allocation
        /// 663-01 ETC Settlement Advice
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SettlementCounterpartyPID { get; set; }
        #endregion

        #region Bitmap Position 21
        /// <summary>
        /// Processing Timestamp : The time at which a transaction was processed to the described state or 
        /// the time at which a reporting request was processed.
        /// (NB.If this value is part of a message created by a user - the timestamp is the time at which the transaction is processed by the user).
        /// 
        /// Cross Reference
        #region Cross Reference
        //002-02 Effected Demand Single Entry CHESS to CHESS Transfer
        //004-02 Effected Transferor Submitted Transfer
        //006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
        //008-03 Effected CHESS to Registry Movement
        //010-03 Applied Transferor Submitted Transfer
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //016-01 Accepted Registry to CHESS Movement Request
        //018-02 Effected Holding Transformation
        //020-01 ACH Accepted Collateral
        //022-03 Effected Holding Adjustment
        //024-01 Rejected Demand Dual Entry CHESS to CHESS Transfer
        //026-01 Single Entry Transfer Acknowledgement
        //028-01 Created Collateral
        //030-02 Reduced Collateral
        //032-01 Effected Takeover Acceptance
        //034-04 Effected Takeover Transfer
        //036-01 Offeror Takeover Acceptance Notification
        //038-01 Reversed Takeover Acceptance
        //040-01 Accepted Collateral Removal Request
        //042-05 Collateral Release
        //048-01 Cancelled Demand Dual Entry Transfer Request
        //050-02 Effected Security Code Change
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //076-02 Rejected Registry to CHESS Movement
        //078-02 Rejected Collateral Removal
        //080-02 Rejected Registration Details Update
        //082-01 Adjusted Subposition
        //084-01 Effected Participant Transaction
        //086-01 Accepted Takeover Acceptance Removal Request
        //088-01 Rejected Takeover Acceptance Removal Request
        //090-03 Full Transferor Submitted Demand Transfer
        //092-01 Offeror Takeover Acceptance Removal Notification
        //096-01 Security Detail
        //098-01 Price Notification Acceptance
        //100-01 Trade Removal Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //104-01 Collateral Removal Notification
        //106-01 Scheduled Single Entry Settlement CHESS to CHESS Transfer
        //108-01 Collateral Creation Acceptance Advice
        //110-01 CP Collateral Removal Acceptance Advice
        //112-01 Notified External Delivery Failure
        //114-01 Cancelled External Delivery Failure
        //116-01 Cancelled Settlement Instruction
        //118-01 Cancelled Change Settlement Instruction Request
        //120-01 CP Collateral Removal Rejection Advice
        //122-01 Unmatched Change Settlement Instruction Request
        //124-01 Rescheduled Settlement Instruction
        //126-01 Updated Settlement Instruction
        //128-02 Adjusted Settlement Instruction
        //130-02 Requested Settlement Instruction Change
        //132-01 Removed Dual Entry Settlement Instruction Cancellation Request
        //134-01 Scheduled Net Obligation
        //136-01 Reinstated Trade
        //138-01 Netted Trade
        //140-01 Cancelled Net Obligation
        //142-02 Accrued Settlement Instruction
        //144-01 Effected CP Transaction
        //146-03 Effected Net Settlement Movement
        //148-01 Projected Cum Entitlement Position
        //150-01 Projected Funds Obligation
        //152-01 Projected Holding Position
        //154-01 Cancelled Funds Obligation
        //156-01 Settled Settlement Instruction
        //158-01 Participant Counterparty Balance
        //160-01 Collateral Removal Rejection Advice
        //162-01 Suspended Settlement Instruction
        //164-03 Notified Trade
        //166-01 Scheduled Dual Entry Settlement Instruction
        //168-01 CP Collateral Removal Authorisation Request
        //170-01 Effected Net Funds Movement
        //172-02 Effected Registry to CHESS Conversion
        //174-02 Effected Registry to CHESS Transfer
        //176-01 Collateral Creation Rejection Advice
        //178-01 Unmatched Dual Entry Settlement Instruction Cancellation Request
        //180-02 Full Settlement Instruction
        //182-01 Collateral Removal to CP Notification
        //184-01 Trade Registration Acceptance
        //186-01 Net Trust Amount Movement
        //188-02 Full Adjusted Settlement Instruction
        //190-01 Predicted Partial Fail Advice
        //192-01 Part-Settled Settlement Instruction
        //194-01 Unmatched Dual Entry Request
        //196-01 Blocked Trade
        //198-01 Unblocked Trade
        //202-01 Accepted New Registration Details
        //204-01 Locked CHESS Holding
        //206-01 Unlocked CHESS Holding
        //218-01 Accepted Registration Details Update
        //220-02 Authorised Registration Details
        //222-04 Holder Detail
        //224-03 Holder History
        //226-01 User Detail
        //228-01 User History
        //230-01 Payment Facility Detail
        //232-01 Payment Facility History
        //234-03 Reporting Request Detail
        //240-01 Created Payment Facility
        //242-01 Applied Payment Facility Update
        //244-01 Cancelled Payment Facility
        //246-01 Accepted Change Controlling Participant Request
        //248-01 Change Controlling Participant Authorisation Request
        //250-01 Cancelled Change Controlling Participant Request
        //252-01 Effected Controlling Participant Change
        //254-01 Rejected Change Controlling Participant
        //256-01 Applied Change Controlling Participant Reject
        //272-01 Accepted Loan Instruction
        //274-01 Adjusted Loan
        //276-02 Accrued Loan
        //278-01 Scheduled Loan Instruction
        //280-01 Bulk Loan Application
        //282-01 Rejected Loan Application
        //284-01 Cancelled Loan Instruction
        //286-01 Full Loan Instruction
        //300-01 Participant Funds Notification
        //302-01 Payment Provider Funds Notification
        //310-02 Participant Funds Obligation
        //312-01 Payment Provider Funds Obligation
        //332-01 Payment Provider Transfer Request
        //340-01 Effected Create Net Position
        //342-01 Create Net Position Record Authorisation Request
        //344-01 Accepted Create Net Position Response
        //346-01 Applied Create Net Position Response
        //348-01 Rejected Create Net Position
        //350-01 Clearing Account Transfer Request
        //352-01 Create Cash Subrecord Authorisation Request
        //354-01 Accepted Create Cash Subrecord Response
        //356-01 Effected Create Cash Subrecord
        //358-01 Applied Create Cash Subrecord Response
        //360-01 Rejected Create Cash Subrecord
        //362-01 CHESS DvP Notification
        //372-01 Changed Net Position Attributes Notification
        //374-01 Changed Net Position Attributes Confirmation
        //376-01 Payment Provider Change Cash Subrecord Attributes Confirmation
        //378-01 Accepted Participant Change Cash Subrecord Attributes
        //380-01 Participant Change Cash Subrecord Attributes Authorisation Request
        //382-01 Effected Participant Change Cash Subrecord Attributes
        //384-01 Applied Participant Change Cash Subrecord Attributes
        //386-01 Rejected Participant Change Cash Subrecord Attributes
        //398-01 Settlement Cancellation Notification
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //410-01 Requested Settlement Type Change
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //422-02 Applied Registry Transaction
        //426-02 Applied Registry Authorisation Response
        //430-01 Applied Code Change
        //432-01 Cancelled Offeror Initiated TKO Acceptance Request
        //442-01 Cancelled Change RTGS Instruction Request
        //444-01 Unmatched Change Settlement Type Request
        //446-01 Updated RTGS Instruction
        //448-01 Adjusted Settlement Type
        //450-01 Cancelled Request to Change Settlement Type
        //452-01 CHESS to Participant SRN Request Acknowledgement
        //453-01 Registry to CHESS SRN Response
        //454-01 CHESS to Registry SRN Request
        //455-01 Registry to CHESS SRN Reject
        //456-01 CHESS to Registry SRN Response Acknowledgement
        //458-01 CHESS to Participant SRN Response
        //460-01 CHESS to Registry SRN Reject Acknowledgement
        //461-01 Registry to CHESS Holding Balance Reject
        //462-01 CHESS to Participant SRN Reject
        //464-01 CHESS to Participant Holding Balance Request Acknowledgement
        //466-01 CHESS to Registry Holding Balance Request
        //468-01 CHESS to Registry Holding Balance Response Acknowledgement
        //470-01 CHESS to Participant Holding Balance Response
        //472-01 CHESS to Registry Holding Balance Reject Acknowledgement
        //474-01 CHESS to Participant Holding Balance Reject
        //476-01 Authorise RTGS Instruction Confirmation
        //478-01 Unmatched Change RTGS Instruction Request
        //480-01 Requested RTGS Instruction Change
        //482-01 Unmatched RTGS Dual Entry Notification
        //484-01 Unmatched RTGS Dual Entry Request
        //490-01 Unmatched RTGS Instruction Cancellation Request
        //492-01 Removed RTGS Instruction Cancellation Request
        //496-01 Checking RBA Funds Queue Advice
        //500-01 RTGS Instruction Ready to Settle Advice
        //502-02 Holding Subposition Detail
        //504-01 Cum Entitlement Daily Balance
        //506-01 Cum Entitlement Net Movement
        //508-01 Holding Daily Balance
        //510-01 Holding Net Movement
        //512-04 Holding Registration Details
        //514-01 Aggregated Foreign to Foreign Allocations
        //516-01 Rights Accepted
        //518-01 Rejected Transaction
        //520-02 Cum Entitlement Balance
        //522-02 Holding Balance
        //524-01 Total Cum Entitlement Balance
        //526-01 Accepted Reporting Request
        //528-01 Archived Sub-Register
        //530-01 Cancelled Reporting Request
        //532-01 Total Security Balance
        //534-02 Notified Tax File Number / Australian Business Number
        //536-01 Accepted Tax File Number / Australian Business Number Advice
        //538-01 End of Reporting
        //542-01 CHESS Event Notification
        //544-01 Levy Notification
        //546-01 Revised Holder Registration Details
        //548-02 Reversed Levy Notification
        //550-01 Scheduled Payment Instruction
        //560-01 Top Security Holder Report
        //561-01 CCMS CHESS Security Message
        //562-01 CCMS End Message
        //563-01 CCMS CHESS Calendar Message
        //564-01 CHESS Processing Status Notification
        //565-01 CCMS Reconciliation Balance
        //566-01 Recorded Collateral Registration Details
        //568-01 Cancelled Collateral Registration Details
        //570-01 Pending Equity Settlement Balance
        //571-01 Collateral Source Account Movement Notification
        //573-01 Successful Collateral Transfer
        //574-01 Rejected Collateral Transfer
        //575-01 Pending Collateral Transfer
        //576-01 CCMS Collateral Transfer Notification
        //577-01 CMAX Settlement Balance Update
        //578-01 Position Update
        //580-01 Collateral Acount Details Verification
        //581-01 Accepted Corporate Action Message Set
        //582-01 Rejected Corporate Action Message Set
        //583-01 CCMS Collateral Account Adjustment
        //584-01 CCMS Cum Entitlement Transfer
        //587-01 End of Linked Transfer Message Set
        //588-01 Rejected Linked Collateral Transfer
        //589-01 Pending Linked Collateral Transfer
        //590-01 Finalise Linked Collateral Transfer
        //591-01 Successful Linked Collateral Transfer
        //592-01 Reject Linked Collateral Transfer Request
        //602-02 Effected ACH Transaction
        //610-04 Collateral Request
        //612-04 Collateral Removal Authorisation Request
        //614-01 Cash Subrecord Details
        //616-01 Cash Subrecord Total
        //652-01 ETC Trade
        //654-01 ETC Trade Advice Acknowledgement
        //656-02 ETC Trade Allocation
        //658-01 ETC Trade Allocation Acknowledgement
        //660-01 ETC Trade Rejection
        //662-01 ETC Trade Rejection Acknowledgement
        //664-01 Contract Note
        //666-01 Contract Note Advice Acknowledgement
        //668-01 Contract Note Rejection
        //670-01 Contract Note Rejection Acknowledgement
        //672-01 Allocation Cancellation
        //674-01 Allocation Cancellation Acknowledgement
        //676-01 ETC Settlement
        //678-01 ETC Settlement Advice Acknowledgement
        //680-01 ETC Settlement Cancellation
        //682-01 ETC Settlement Cancellation Acknowledgement
        //684-01 ETC Trade Cancellation
        //686-01 ETC Trade Cancellation Acknowledgement
        //688-01 ETC Contract Note Cancellation
        //690-01 ETC Contract Note Cancellation Acknowledgement
        //692-01 Controlling PID and Holder Status Response
        //694-01 Cancelled Transfer or Conversion Request
        //702-02 Takeover Acceptance Removal Authorisation Request
        //704-02 Takeover Acceptance Notification
        //706-02 Effected Offeror Transaction
        //710-01 Rejected Offeror Takeover Acceptance
        //716-01 CHESS Conversion Request to Issuer Sponsored Fund
        //717-01 Effected CHESS Conversion to Issuer Sponsored Fund
        //719-02Issuer Sponsored Fund to CHESS Conversion Authorisation Request
        //720-01 Accepted Participant Request
        //722-01 Fund Response
        //723-01 Effected Conversion Issuer Sponsored Fund to CHESS
        //725-01 Rejected Conversion Issuer Sponsored Fund to CHESS
        //727-02Application Order Request
        //729-02Application Order/Payment Plan Application Response
        //730-02Effected Application Order/Payment Plan Application Response
        //731-01 Scheduled Settlement Payment Instruction
        //735-01 Foreign Tax Status
        //752-01 Requesting Funds Approval
        //754-01 RTGS Settlement Movement
        //756-01 RTGS Funds Movement
        //758-01 Holding Advice Acknowledgement
        //759-01 Holding Advice Acceptance
        //760-02 Holding Advice Notification
        //761-01 Holding Advice Rejection
        //762-01 Effected Registry Transaction
        //764-01 Accepted Holding Advice
        //766-01 Rejected Holding Advice
        //801-02Redemption Order Request
        //802-02Redemption Order Response
        //803-02Effected Redemption Order Request
        //805-01 Order Cancellation Request
        //807-02Switch Order Request
        //808-02Switch Order Response
        //809-02Effected Switch Order Request
        //810-01 Update Order
        //811-01 Effected Update Order
        //816-01 Income Statement Advice
        //822-01 Cancelled Funds Settlement Payment Instruction
        //830-01 Holding Daily Fund Balance
        //831-01 Holding Net Fund Movement
        //832-01 Holding Fund Balance
        //833-01 Total Security Fund Balance
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        //838-01 CHESS to Registry Fund Balance Request
        //840-01 CHESS to Participant Fund Balance Response
        //841-01 Registry to CHESS Fund Balance Rejection
        //842-01 CHESS to Participant Fund Balance Reject
        //844-01 Top Security Fund Holder Report
        //845-02Unit Reversal Notification
        //846-02Effected Unit Reversal Notification
        //860-01 Rejected Registry Authorisation
        //864-01 Distribution Election Authorisation Request
        //866-01 Accepted Distribution Election Request
        //868-01 Income Statement Authorisation Request
        //870-01 Accepted Margin Cover Creation Request
        //872-01 Margin Cover Creation Authorisation Request
        //874-01 Effected Margin Cover Release and Transfer
        //876-01 Accepted Margin Cover Creation
        //878-01 Reduced Margin Cover
        //880-01 Accepted Margin Cover Removal Request
        //882-01 Margin Cover Removal Authorisation Request
        //884-01 Accepted Income Statement Request
        //886-01 Accepted STP Collateral Removal Request
        //888-01 STP Collateral Removal Authorisation Request
        //890-01 Scheduled STP Transfer
        //892-01 Rejected STP Collateral Removal Request
        //894-01 STP Collateral Removal CP Authorisation Request
        //896-01 STP Collateral Removal CP Notification
        //900-01 STP Collateral Removal CP Rejection Advice
        //904-01 STP Collateral Removal Cancellation Notification
        //906-01 Effected STP Collateral Removal Cancellation
        //908-01 Accepted STP Collateral Removal Cancellation Request
        //910-01 STP Collateral Removal CP Cancellation Authorisation Request
        //912-01 STP Collateral Removal CP Cancellation Notification
        //916-01 Rejected STP Collateral Removal Cancellation
        //920-01 STP Collateral Removal Cancellation Rejection Advice
        //922-01 Adjusted Scheduled STP Release
        //924-01 STP Reduced Collateral Notification
        //926-01 Scheduled STP Collateral Removal
        //928-01 Scheduled STP Collateral Removal CP Advice
        //930-01 Scheduled STP Collateral Rejection CP Advice
        //932-01 Excess Cash Standing Instruction Authorisation Request
        //934-01 Accepted Excess Cash Standing Instruction Request
        //936-01 Effected Excess Cash Standing Instruction Request
        //938-01 Rejected Excess Cash Standing Instruction Request
        //940-01 Daily Interest Earned Statement
        //942-01 Margin Settlement Advice
        //944-01 Margin Settlement Amount Change Authorisation Request
        //946-01 Accepted Margin Settlement Amount Change Request
        //948-01 Effected Margin Settlement Amount Change
        //950-01 Rejected Margin Settlement Amount Change
        //952-01 Collateral Statement
        //954-01 End Statement
        //956-01 Rejected Margin Cover Removal Request
        //958-01 Accepted Registry Income Statement Set
        //960-01 Rejected Registry Income Statement Set
        //962-02Participant Income Statement Part A
        //964-01 Participant Income Statement Part B
        //966-01 Participant Income Statement Part C AI
        //968-01 Participant Income Statement Part C CG
        //970-01 Participant Income Statement Part C FI
        //972-02Participant Income Statement Part C NA
        //974-01 Participant Income Statement Part C OD
        //976-01 End Participant Income Statement Set
        #endregion Cross Reference End
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ProcessingTimestamp { get; set; }
        #endregion

        #region Bitmap Position 22
        /// <summary>
        /// Address Type : Indicates the type of address entered for foreign tax purposes. This depends on the Account Type.
        /// 
        /// Allowable Values ‘G’ = Registered
        ///                  ‘R’ = Residential
        ///                  ‘T’ = Trust
        ///                  
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] AddressType = new char[3] { 'G', 'R', 'T' };

        /// <summary>
        /// Holding Transaction Status : Identifies the current status of a securities movement in CHESS.
        /// 
        /// Allowable Values 'A' = Unauthorised
        ///                  'C' = Cancelled
        ///                  'E' = Effected
        ///                  'R' = Rejected
        ///                  'U' = Unmatched
        ///                  
        /// 052-03 Full Dual Entry CHESS to CHESS Transfer
        /// 056-03 Full Certificated to CHESS Transfer
        /// 058-03 Full Certificated to CHESS Conversion
        /// 060-03 Full Issuer Sponsored to CHESS Transfer
        /// 062-03 Full Issuer Sponsored to CHESS Conversion
        /// 834-01 Full Issuer Sponsored Fund to CHESS Conversion
        /// 835-01 Full CHESS to Issuer Sponsored Fund Conversion
        /// </summary>
        public static readonly char[] HoldingTransactionStatus = new char[5] { 'A', 'C', 'E', 'R', 'U' };

        /// <summary>
        /// Income Statement Report Frequency : Identifies whether the income statement details are to be provided as
        /// an on-demand report or as a regular standing report. The regular
        /// standing option applies to periodic income statements only. Where a
        /// regular standing report is nominated, the frequency is dependant on
        /// the PISP/registry offering.
        /// 
        /// Allowable Values ‘A” = On-demand
        ///                  ‘S’ = Standing
        ///                  
        /// 868-01 Income Statement Authorisation Request
        /// 869-01 Income Statement Request
        /// </summary>
        public static readonly char[] IncomeStatementReportFrequency = new char[2] { 'A', 'S' };

        /// <summary>
        /// Income Statement Status : Identifies whether the annual income statement details provided are Provisional or Final.
        /// 
        /// Allowable Values ‘F” = Final
        ///                  ‘P’ = Provisional
        ///                  
        /// Cross Reference
        #region Cross Reference
        //957-02Registry Income Statement Part A
        //959-01 Registry Income Statement Part B
        //961-01 Registry Income Statement Part C AI
        //962-02Participant Income Statement Part A
        //963-01 Registry Income Statement Part C CG
        //964-01 Participant Income Statement Part B
        //965-01 Registry Income Statement Part C FI
        //966-01 Participant Income Statement Part C AI
        //967-02 Registry Income Statement Part C NA
        //968-01 Participant Income Statement Part C CG
        //969-01 Registry Income Statement Part C OD
        //970-01 Participant Income Statement Part C FI
        //972-02Participant Income Statement Part C NA
        //974-01 Participant Income Statement Part C OD
        #endregion Cross Reference End
        /// </summary>
        public static readonly char[] IncomeStatementStatus = new char[2] { 'F', 'P' };

        /// <summary>
        /// Margin Lender : Indicates to ASX Clear that the securities lodged as collateral are subject to a margin lender agreement.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  ‘N’ = No
        ///                  Space = No (default)
        ///                  
        /// 027-03 Collateral Creation Request
        /// 108-01 Collateral Creation Acceptance Advice
        /// 176-01 Collateral Creation Rejection Advice
        /// 610-04 Collateral Request
        /// </summary>
        public static readonly char[] MarginLender = new char[3] { 'Y', 'N', ' ' };

        /// <summary>
        /// Transaction Status : Indicates the status of a Fund transaction.
        /// 
        /// Allowable Values ‘A’ = Accepted
        ///                  ‘C’ = Cancel Order
        ///                  ‘H’ = Order on-hold with the Product Issuer Settlement Participant
        ///                  ‘P’ = Reapply the corrected Unit Adjustment
        ///                  ‘R’ = Rejected
        ///                  ‘U’ = Update Payment or Unit Allotment Date
        ///                  ‘V’ = Reverse the original Unit Adjustment
        ///                  
        /// Cross Reference
        #region Cross Reference
        //729-01 Application Order/Payment Plan Application Response
        //730-02 Effected Application Order/Payment Plan Application Response
        //802-02 Redemption Order Response
        //803-02 Effected Redemption Order Request
        //808-02 Switch Order Response
        //809-02 Effected Switch Order Request
        //810-01 Update Order
        //811-01 Effected Update Order
        //845-02 Unit Reversal Notification
        //846-02 Effected Unit Reversal Notification
        #endregion Cross Reference End
        /// </summary>
        public static readonly char[] TransactionStatus = new char[7] { 'A', 'C', 'H', 'P', 'R', 'U', 'V' };
        #endregion

        #region Bitmap Position 23
        /// <summary>
        /// ASX Clear Account : Identifies the ASX Clear account (first 10 characters) held by a clearing member of ASX Clearing Pty Ltd (ASX Clear)
        /// to enable ASX Clear to correctly record the collateral against an open position. (The final 2 characters are currently space filled.)
        /// 
        /// 027-03 Collateral Creation Request
        /// 028-01 Created Collateral
        /// 029-03 Collateral Removal Request
        /// 042-05 Collateral Release
        /// 108-01 Collateral Creation Acceptance Advice
        /// 160-01 Collateral Removal Rejection Advice
        /// 168-01 CP Collateral Removal Authorisation Request
        /// 176-01 Collateral Creation Rejection Advice
        /// 182-01 Collateral Removal to CP Notification
        /// 601-04 Collateral Release Request
        /// 610-04 Collateral Request
        /// 612-04 Collateral Removal Authorisation Request
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ASXClearAccount { get; set; }
        #endregion

        #region Bitmap Position 24
        /// <summary>
        /// ASX Clearing Member : Unique identifier of a clearing member of ASX Clear Pty Ltd (ASX Clear).
        /// 
        /// 027-03 Collateral Creation Request
        /// 028-01 Created Collateral
        /// 029-03 Collateral Removal Request
        /// 042-05 Collateral Release
        /// 108-01 Collateral Creation Acceptance Advice
        /// 160-01 Collateral Removal Rejection Advice
        /// 168-01 CP Collateral Removal Authorisation Request
        /// 176-01 Collateral Creation Rejection Advice
        /// 182-01 Collateral Removal to CP Notification
        /// 601-04 Collateral Release Request
        /// 610-04 Collateral Request
        /// 612-04 Collateral Removal Authorisation Request
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ASXClearingMember { get; set; }

        /// <summary>
        /// Cash Account Identifier : An RTGS related value which stands for the 35-char Cash Subrecord ID, and is only used in RTGS related participant
        /// messaging with CHESS once the Cash Subrecord is set up. (This value allows for additional security in internal participant handling.)
        /// The Cash Account Identifier is unique to a payment facility; therefore, the Payment Facility ID is always required wherever the
        /// Cash Account Identifier is supplied.
        /// 
        /// 356-01 Effected Create Cash Subrecord
        /// 375-01 Participant Change Cash Subrecord Attributes Request
        /// 382-01 Effected Participant Change Cash Subrecord Attributes
        /// 386-01 Rejected Participant Change Cash Subrecord Attributes
        /// 444-01 Unmatched Change Settlement Type Request
        /// 448-01 Adjusted Settlement Type
        /// 481-01 RTGS Dual Entry Notification
        /// 493-01 Maintain RTGS Instruction Request
        /// 497-01 Settlement Type Change Request
        /// 614-01 Cash Subrecord Details
        /// 616-01 Cash Subrecord Total
        /// 756-01 RTGS Funds Movement
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string CashAccountIdentifier { get; set; }

        /// <summary>
        /// Last Traded Time : Indicates the time the last on-market price was captured.
        /// 
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string LastTradedTime { get; set; }

        /// <summary>
        /// Total Messages in Set : The number of Single Entry Transfer Requests in the set. A set is a
        /// group of messages used to process a specific action. This value is
        /// used in conjunction with the Set Transaction Id value to link the
        /// associated requests prior to processing.
        /// 
        /// 025-01 Single Entry Transfer Request
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TotalMessagesinSet { get; set; }

        /// <summary>
        /// Trade Execution Time : Time the trade was executed on the AMOs trading platform.
        /// 
        /// Allowable Values A valid time in the format of HHMMSS
        /// 
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TradeExecutionTime { get; set; }
        #endregion

        #region Bitmap Position 25
        /// <summary>
        /// Holder DRP Preference : Investor election for Distribution Reinvestment Plan (DRP).
        /// 
        /// Allowable Values ‘F’ = Full
        ///                  ‘P’ = Partial
        ///                  ‘N’ = No
        ///                  
        /// 863-01 Distribution Election Request
        /// 864-01 Distribution Election Authorisation Request
        /// </summary>
        public static readonly char[] HolderDRPPreference = new char[3] { 'F', 'P', 'N' };

        /// <summary>
        /// Income Statement Report Type : Identifies the type of income statement requested.
        /// 
        /// Allowable Values ‘A’ = Annual
        ///                  ‘P” = Periodic
        ///                  
        /// 868-01 Income Statement Authorisation Request
        /// 869-01 Income Statement Request
        /// </summary>
        public static readonly char[] IncomeStatementReportType = new char[2] { 'A', 'P' };

        /// <summary>
        /// Movement Reason : The reason for the movement of securities between two subregisters.
        /// 
        /// Allowable Values 'A' = Holder in liquidation
        ///                  'B' = Balance transfer
        ///                  'C' = Holder request
        ///                  'D' = Deceased Estate
        ///                  'E' = Holder Bankrupt
        ///                  ‘F’ = CHESS Subregister Closed
        ///                  ‘G’ = Withdrawal of Participant
        ///                  ‘I’ = IPO Transaction
        ///                  ‘Z’ = Action by Market Support
        ///                  
        /// Cross Reference
        #region Cross Reference
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //008-03 Effected CHESS to Registry Movement
        //009-03 Demand CHESS to Certificated Transfer Request
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //715-01 CHESS to Issuer Sponsored Fund Conversion Request
        //716-01 CHESS Conversion Request to Issuer Sponsored Fund
        //717-01 Effected CHESS Conversion to Issuer Sponsored Fund
        //718-02Issuer Sponsored Fund to CHESS Conversion Request
        //719-02Issuer Sponsored Fund to CHESS Conversion Authorisation Request
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        #endregion Cross Reference End
        /// </summary>
        public static readonly char[] MovementReason = new char[9] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'I', 'Z' };
        #endregion

        #region Bitmap Position 26
        /// <summary>
        /// Registration Details Indicator : Indicates to the registry whether the registration details should be added to,
        /// deleted from, or changed on the company's list of members.
        /// 
        /// Allowable Values 'C' = Change
        ///                  ‘E” = Email Detail Only
        ///                  'N' = New
        ///                  'P' = Change of Controlling Participant
        ///                  'R' = Reporting
        ///                  ‘X’ = ASX Clear Registration Address Standardisation
        ///                  'Z' = Zero balance
        ///                  
        /// 512-04 Holding Registration Details
        /// </summary>
        public static readonly char[] RegistrationDetailsIndicator = new char[7] { 'C', 'E', 'N', 'P', 'R', 'X', 'Z' };
        #endregion

        #region Bitmap Position 27
        /// <summary>
        /// Settlement Instruction Status : The current status of a settlement instruction.
        /// 
        /// Allowable Values 'B' = Committed
        ///                  'C' = Cancelled
        ///                  ‘I’ = Information Only
        ///                  'N' = Netted
        ///                  'P' = Suspended
        ///                  'S' = Scheduled
        ///                  'T' = Settled
        ///                  'U' = Unmatched
        ///                  
        /// 121-02 Change Settlement Instruction Request
        /// 130-02 Requested Settlement Instruction Change
        /// 164-03 Notified Trade
        /// 180-02 Full Settlement Instruction
        /// 480-01 Requested RTGS Instruction Change
        /// 489-01 Change RTGS Instruction Request
        /// </summary>
        public static readonly char[] SettlementInstructionStatus = new char[8] { 'B', 'C', 'I', 'N', 'P', 'S', 'T', 'U' };

        /// <summary>
        /// Revised Status : Specifies the revised Status of a settlement instruction after it has been altered.
        /// 
        /// Allowable Values 'B' = Committed
        ///                  'C' = Cancelled
        ///                  ‘I’ = Information Only
        ///                  'N' = Netted
        ///                  'P' = Suspended
        ///                  'S' = Scheduled
        ///                  'T' = Settled
        ///                  'U' = Unmatched
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        public static readonly char[] RevisedStatus = new char[8] { 'B', 'C', 'I', 'N', 'P', 'S', 'T', 'U' };
        #endregion

        #region Bitmap Position 28
        /// <summary>
        /// Location of Register : Identifies the non-CHESS register on which the participant wishes
        /// the securities to be registered or on which they are currently registered.
        /// 
        /// Allowable Values 'NSW', 'VIC', 'QLD', 'SA', 'WA', 'TAS', 'ACT', 'NT'
        ///                  All country codes;
        ///                  
        /// Cross Reference
        #region Cross Reference
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        #endregion Cross Reference End
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string LocationofRegister { get; set; }
        #endregion

        #region Bitmap Position 29
        /// <summary>
        /// Payment Facility Id : Unique identifier of a payment facility allocated by ASX Clear on request from a participant.
        /// 
        /// Allowable Values Any value allocated by ASX as an identifier of a payment facility.
        /// 
        /// Cross Reference
        #region Cross Reference
        //150-01 Projected Funds Obligation
        //154-01 Cancelled Funds Obligation
        //170-01 Effected Net Funds Movement
        //186-01 Net Trust Amount Movement
        //230-01 Payment Facility Detail
        //232-01 Payment Facility History
        //240-01 Created Payment Facility
        //242-01 Applied Payment Facility Update
        //244-01 Cancelled Payment Facility
        //300-01 Participant Funds Notification
        //310-02 Participant Funds Obligation
        //311-01 Participant Funds Obligation Acknowledgement
        //313-01 Participant Funds Obligation Rejection
        //340-01 Effected Create Net Position
        //341-01 Create Net Position Request
        //342-01 Create Net Position Record Authorisation Request
        //343-01 Create Net Position Authorisation
        //345-01 Create Net Position Rejection
        //348-01 Rejected Create Net Position
        //351-01 Create Cash Subrecord Request
        //352-01 Create Cash Subrecord Authorisation Request
        //353-01 Create Cash Subrecord Authorisation
        //356-01 Effected Create Cash Subrecord
        //357-01 Create Cash Subrecord Rejection
        //360-01 Rejected Create Cash Subrecord
        //371-01 Change Net Position Attributes Request
        //372-01 Changed Net Position Attributes Notification
        //373-01 Payment Provider Change Cash Subrecord Attributes Request
        //375-01 Participant Change Cash Subrecord Attributes Request
        //377-01 Participant Change Cash Subrecord Attributes Authorisation
        //379-01 Participant Change Cash Subrecord Attributes Rejection
        //380-01 Participant Change Cash Subrecord Attributes Authorisation Request
        //382-01 Effected Participant Change Cash Subrecord Attributes
        //386-01 Rejected Participant Change Cash Subrecord Attributes
        //550-01 Scheduled Payment Instruction
        //614-01 Cash Subrecord Details
        //616-01 Cash Subrecord Total
        //756-01 RTGS Funds Movement
        #endregion Cross Reference End
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PaymentFacilityId { get; set; }

        /// <summary>
        /// Payment Facility Parameter : Restricts the scope of reporting to entities which relate to a specific payment facility.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PaymentFacilityParameter { get; set; }
        #endregion

        #region Bitmap Position 30
        /// <summary>
        /// Previous Status : Specifies the previous status of a settlement instruction before it was altered.
        /// 
        /// Allowable Values 'B' = Committed
        ///                  'C' = Cancelled
        ///                  ‘I’ = Information Only
        ///                  'N' = Netted
        ///                  'P' = Suspended
        ///                  'S' = Scheduled
        ///                  'T' = Settled
        ///                  'U' = Unmatched
        ///                  
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        public static readonly char[] PreviousStatus = new char[8] { 'B', 'C', 'I', 'N', 'P', 'S', 'T', 'U' };
        #endregion

        #region Bitmap Position 31
        /// <summary>
        /// ASX Clear Lodgement Number : Identifies the ASX Clear Lodgement Number, to enable ASX Clear Pty Ltd (ASX Clear)
        /// to correctly record the collateral into an account of the clearing participant.
        /// 
        /// Allowable Values ASX Clear participants may use the following values:
        ///                  * The pre-printed number appearing on the ‘Notice of Lodgement/Withdrawal of Securities as Collateral’ (C3) form.
        ///                  * The value ‘P0000000’ indicating pooled paperless collateral lodgement.
        ///                  * The value ‘Pnnnnnnn’ indicating numbered paperless collateral lodgement (where ‘nnnnnnn’ is a participant defined number).
        ///                  * No value, where no value is submitted, ASX Clear will assign an ASX Clear Lodgement Number.
        /// 
        /// 027-03 Collateral Creation Request
        /// 028-01 Created Collateral
        /// 029-03 Collateral Removal Request
        /// 042-05 Collateral Release
        /// 108-01 Collateral Creation Acceptance Advice
        /// 160-01 Collateral Removal Rejection Advice
        /// 168-01 CP Collateral Removal Authorisation Request
        /// 176-01 Collateral Creation Rejection Advice
        /// 182-01 Collateral Removal to CP Notification
        /// 601-04 Collateral Release Request
        /// 610-04 Collateral Request
        /// 612-04 Collateral Removal Authorisation Request
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ASXClearLodgementNumber { get; set; }
        #endregion

        #region Bitmap Position 32
        /// <summary>
        /// Issuer : The name of the Issuer, where applicable (e.g. RBA).
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Issuer { get; set; }
        #endregion

        #region Bitmap Position 33
        /// <summary>
        /// Cancel Reason : The transaction cancellation reason
        /// 
        /// Allowable Values ‘OCF’ = Order cannot be fulfilled
        /// 
        /// 810-01 Update Order
        /// 811-01 Effected Update Order
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] CancelReason = new string[1] { "OCF" };

        /// <summary>
        /// Exchange : The listed exchange for the associated security code
        /// 
        /// Allowable values ‘APX’ – Asia Pacific Exchange Limited
        ///                  ‘ASX’ – Australian Securities Exchange Limited
        ///                  'CXA’ – Chi-X Australia Limited
        ///                  ‘NSX’ – National Stock Exchange
        ///                  ‘SIM’ – Sim Venture Securities Exchange Limited
        ///                  
        /// 096-01 Security Detail
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] Exchange = new string[5] { "APX", "ASX", "CXA", "NSX", "SIM" };

        /// <summary>
        /// Fund Reason : The transaction type underlying the request.
        /// 
        /// Allowable Values ‘ADJ’ = Miscellaneous Adjustment
        ///                  ‘APP’ = Application
        ///                  ‘DRP’ = Distribution Re-Investment Plan
        ///                  ‘ORP’ = Order Reapply
        ///                  ‘ORV’ = Order Reversal
        ///                  ‘RED’ = Redemption
        ///                  ‘RPP’ = Regular Payment Plan
        ///                  ‘SWI’ = Switch
        ///                  
        /// 732-02Unit Adjustment
        /// 733-02Effected Fund Unit Adjustment
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] FundReason = new string[8] { "ADJ", "APP", "DRP", "ORP", "ORV", "RED", "RPP", "SWI" };

        /// <summary>
        /// Hold Reason : Indicates the reason that the Product Issuer Settlement Participant
        /// has for not effecting a request from a Participant. This is not a
        /// rejection, the request will be effected at a later date.
        /// 
        /// Allowable Values ‘FCR’ = Fund is currently closed for redemptions
        /// 
        /// 802-02Redemption Order Response
        /// 803-02Effected Redemption Order Request
        /// 808-02Switch Order Response
        /// 809-02Effected Switch Order Request
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] HoldReason = new string[1] { "FCR" };

        /// <summary>
        /// Reason : The reason for a holding transaction.
        /// 
        /// Allowable Values
        #region Allowable Values
        //ADJ Adjustment
        //AFO Adjustment for Foreign Ownership
        //ALT Miscellaneous Allotment
        //BON Bonus Issue Allotment
        //BSP Bonus Plan Allotment
        //BYB Buy-back
        //CAL Call Paid
        //CAQ Compulsory Acquisition by Offeror
        //CNA Convertible Note Allotment
        //CNR Convertible Note Redemption / Maturity
        //CNV Miscellaneous Conversion
        //CRI Security No Longer Meets Criteria for Eligibility as Collateral
        //CSC CHESS Subregister Closed
        //DIS Distribution in Specie
        //DRP Dividend Plan Allotment
        //DVM Divestment
        //EXP Imminent Expiry of Security used as Collateral
        //FLT Float
        //FOR Forfeiture of Partly Paid Shares
        //IDA Income Distribution Allotment
        //MER Company Merger
        //NCN Convertible Note Conversion
        //NRE Non-Renounceable Issue Allotment
        //OCN Options Conversion
        //ODR ASX Clear Directive
        //OEX Option Exercised
        //OLP Option Lapsed
        //OPT Option Allotment
        //PLC Placement
        //PRI Non Pro Rata Balance
        //REC Reconstruction
        //RED Miscellaneous Redemption
        //REV Allotment Reversal
        //RHA Renounceable Rights Accepted
        //RHE Renounceable Rights Entitlement Allotment
        //RHT Renounceable Rights Issue Allotment
        //SAR Subregister Archived
        //SCD Scrip Dividend
        //SPP Share Purchase Plan
        //SOA Scheme of Arrangement
        //STP Share Top-up Plan
        //TKA Takeover Consideration Allotment
        //WAL Warrant Allotment
        //WDL Warrant Delivery
        //WEX Warrant Exercise
        //WRL Warrant Rollover Application
        //WUX Warrant Underlying Exercise
        #endregion Allowable Values End
        /// 
        /// Cross Reference
        #region Cross Reference
        //018-02 Effected Holding Transformation
        //022-03 Effected Holding Adjustment
        //023-01 ACH Collateral Removal Request
        //025-01 Single Entry Transfer Request
        //082-01 Adjusted Subposition
        //104-01 Collateral Removal Notification
        //421-01 Holding Transformation
        //425-01 Holding Adjustment
        //883-01 ASXCL Removal Margin Cover
        //922-01 Adjusted Scheduled STP Release
        #endregion Cross Reference End
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] Reason = new string[47]
        {
            "ADJ", "AFO", "ALT",
            "BON", "BSP", "BYB",
            "CAL", "CAQ", "CNA", "CNR", "CNV", "CRI", "CSC",
            "DIS", "DRP", "DVM",
            "EXP", "FLT", "FOR",
            "IDA", "MER", "NCN", "NRE",
            "OCN", "ODR", "OEX", "OLP", "OPT",
            "PLC", "PRI",
            "REC", "RED", "REV", "RHA", "RHE", "RHT",
            "SAR", "SCD", "SPP", "SOA", "STP",
            "TKA", "WAL", "WDL", "WEX", "WRL", "WUX",
        };
        #endregion

        #region Bitmap Position 34
        /// <summary>
        /// Bank Reference : A reference supplied by the Payment Provider for their own reference that is passed on to ASX Clear.
        /// 
        /// Allowable Values Any alphabetic, numeric or special characters
        /// 
        /// 311-01 Participant Funds Obligation Acknowledgement
        /// 313-01 Participant Funds Obligation Rejection
        /// 333-01 Payment Provider Transfer Response
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string BankReference { get; set; }

        /// <summary>
        /// Contact Reference : A contact value supplied by the participant. May be a name, phone, Email or other.
        /// This value may be used by Market Operations to contact the appropriate individual within the participant organisation.
        /// 
        /// 203-04 Registration Details Update Request
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ContactReference { get; set; }

        /// <summary>
        /// Participant Reference : The identifier allocated to a securities movement by a participant, eg.
        /// this field may be used to hold contract note numbers.
        /// 
        /// Cross Reference
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //002-02 Effected Demand Single Entry CHESS to CHESS Transfer
        //003-02 Transferor Submitted Demand Transfer
        //004-02 Effected Transferor Submitted Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //008-03 Effected CHESS to Registry Movement
        //009-03 Demand CHESS to Certificated Transfer Request
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //024-01 Rejected Demand Dual Entry CHESS to CHESS Transfer
        //025-01 Single Entry Transfer Request
        //027-03 Collateral Creation Request
        //034-04 Effected Takeover Transfer
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //101-02 Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //106-01 Scheduled Single Entry Settlement CHESS to CHESS Transfer
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //166-01 Scheduled Dual Entry Settlement Instruction
        //180-02 Full Settlement Instruction
        //271-01 Loan Application
        //286-01 Full Loan Instruction
        //431-01 Takeover Transfer
        //481-01 RTGS Dual Entry Notification
        //657-01 Contract Note Advice
        //663-01 ETC Settlement Advice
        //664-01 Contract Note
        //676-01 ETC Settlement
        //715-01 CHESS to Issuer Sponsored Fund Conversion Request
        //716-01 CHESS Conversion Request to Issuer Sponsored Fund
        //717-01 Effected CHESS Conversion to Issuer Sponsored Fund
        //718-02Issuer Sponsored Fund to CHESS Conversion Request
        //726-02 Application Request
        //731-01 Scheduled Settlement Payment Instruction
        //800-02Redemption Request
        //806-02Switch Request
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        //871-01 Margin Cover Creation Request
        //872-01 Margin Cover Creation Authorisation Request
        #endregion Cross Reference End
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ParticipantReference { get; set; }

        /// <summary>
        /// Reference : A pricing reference to the expiry and series of non-cash collateral
        /// that has been lodged, where applicable.
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Reference { get; set; }

        /// <summary>
        /// Registry Reference : The identifier allocated by a registry to a transaction which is
        /// submitted by a registry. Used for identification purposes between
        /// registry, ASX Clear and the controlling participant of the holder.
        /// 
        /// Cross Reference
        #region Cross Reference
        //018-02 Effected Holding Transformation
        //022-03 Effected Holding Adjustment
        //076-02 Rejected Registry to CHESS Movement
        //172-02 Effected Registry to CHESS Conversion
        //174-02 Effected Registry to CHESS Transfer
        //401-01 Registry to CHESS Conversion Authorisation
        //403-01 Registry to CHESS Conversion Rejection
        //405-01 Registry to CHESS Transfer Authorisation
        //407-01 Registry to CHESS Transfer Rejection
        //421-01 Holding Transformation
        //425-01 Holding Adjustment
        //721-01 Conversion Authorisation Issuer Sponsored Fund to CHESS
        //723-01 Effected Conversion Issuer Sponsored Fund to CHESS
        //724-01 Conversion Rejection Issuer Sponsored Fund to CHESS
        //725-01 Rejected Conversion Issuer Sponsored Fund to CHESS
        //732-02Unit Adjustment
        //733-02Effected Fund Unit Adjustment
        //860-01 Rejected Registry Authorisation
        //865-01 Distribution Election Registry Authorisation
        //866-01 Accepted Distribution Election Request
        //867-01 Distribution Election Registry Rejection
        //881-01 Income Statement Authorisation
        //884-01 Accepted Income Statement Request
        //907-01 Income Statement Rejection
        #endregion Cross Reference End
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RegistryReference { get; set; }
        #endregion

        #region Bitmap Position 35
        /// <summary>
        /// Receiving Supplementary Reference : The supplementary reference provided by the receiving participant.
        /// 
        /// 052-03 Full Dual Entry CHESS to CHESS Transfer
        /// 180-02 Full Settlement Instruction
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ReceivingSupplementaryReference { get; set; }

        /// <summary>
        /// Supplementary Reference : A reference supplied by the participant for their own reference that is
        /// passed on to the counterparty of a dual entry transaction to assist in
        /// the matching process and printed on a holding statement. An
        /// example of its use may be to identify the client on a trade that is to
        /// be settled between a broker and a custodian.
        /// 
        /// Allowable Values Any alphabetic, numeric or special characters.
        /// 
        /// Cross Reference
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //010-03 Applied Transferor Submitted Transfer
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //024-01 Rejected Demand Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //166-01 Scheduled Dual Entry Settlement Instruction
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //657-01 Contract Note Advice
        //663-01 ETC Settlement Advice
        //664-01 Contract Note
        //676-01 ETC Settlement
        //715-01 CHESS to Issuer Sponsored Fund Conversion Request
        //716-01 CHESS Conversion Request to Issuer Sponsored Fund
        //718-02Issuer Sponsored Fund to CHESS Conversion Request
        //726-02 Application Request
        //727-02 Application Order Request
        //731-01 Scheduled Settlement Payment Instruction
        //800-02Redemption Request
        //801-02Redemption Order Request
        //806-02Switch Request
        //807-02Switch Order Request
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        #endregion Cross Reference End
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SupplementaryReference { get; set; }
        #endregion

        #region Bitmap Position 36
        /// <summary>
        /// Broker/Non-Broker Indicator : Indicates if the CHESS participant involved in the intersubregister securities movement is a market or non-market participant.
        /// 
        /// Allowable Values 'B' = Broker
        ///                  'N' = Non-Broker
        ///                  
        /// 402-02 Certificated to CHESS Conversion Authorisation Request
        /// 404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        /// 406-02 Certificated to CHESS Transfer Authorisation Request
        /// 408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        /// 412-03 CHESS to Certificated Conversion
        /// 414-04 CHESS to Certificated Transfer
        /// 416-03 CHESS to Issuer Sponsored Conversion
        /// 418-04 CHESS to Issuer Sponsored Transfer
        /// 716-01 CHESS Conversion Request to Issuer Sponsored Fund
        /// 719-02 Issuer Sponsored Fund to CHESS Conversion Authorisation Request
        /// </summary>
        public static readonly char[] BrokerNonBrokerIndicator = new char[2] { 'B', 'N' };

        /// <summary>
        /// Holder RPP Preference : Investor preference for Regular Payment Plan (RPP).
        /// 
        /// Allowable Values SPACE only
        /// 
        /// 863-01 Distribution Election Request
        /// 864-01 Distribution Election Authorisation Request
        /// </summary>
        [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string HolderRPPPreference { get; set; } = " ";
        #endregion

        #region Bitmap Position 37
        /// <summary>
        /// Change Cash Subrecord Reject Reason : The reason that a change to the attributes of a Cash Subrecord has been rejected by the Payment Provider.
        /// 
        /// Allowable Values ‘A’ = Cash Subrecord ID does not match Payment Provider for which Payment Facility ID is supplied
        ///                  ‘B’ = Debit cap limit amount is incorrect
        ///                  ‘C’ = Debit cap activity value is incorrect
        ///                  ‘D’ = Cash Subrecord ID is incorrect
        ///                  ‘E’ = Payment Facility ID is incorrect
        ///                  ‘F’ = Exclusion Flag is incorrect for this Cash Subrecord
        ///                  ‘G’ = Cannot nominate this Cash Subrecord as sell default
        ///                  ‘H’ = Cannot nominate this Cash Subrecord as buy default
        ///                  
        /// 379-01 Participant Change Cash Subrecord Attributes Rejection
        /// 386-01 Rejected Participant Change Cash Subrecord Attributes
        /// </summary>
        public static readonly char[] ChangeCashSubrecordRejectReason = new char[8] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

        /// <summary>
        /// Collateral Rejected Reason : Indicates the reason ASX Clear or the clearing participant has rejected a participant’s request.
        /// 
        /// 
        /// 030-02 Reduced Collateral
        /// 078-02 Rejected Collateral Removal
        /// 109-01 CP Collateral Removal Rejection
        /// 120-01 CP Collateral Removal Rejection Advice
        /// 160-01 Collateral Removal Rejection Advice
        /// 176-01 Collateral Creation Rejection Advice
        /// 605-02 Collateral Removal Rejection
        /// 609-02 Rejected Collateral
        /// 875-01 Margin Cover Creation Rejection
        /// 878-01 Reduced Margin Cover
        /// 891-01 STP Collateral Removal Rejection
        /// 892-01 Rejected STP Collateral Removal Request
        /// 895-01 STP CP Collateral Removal Rejection
        /// 900-01 STP Collateral Removal CP Rejection Advice
        /// 930-01 Scheduled STP Collateral Rejection CP Advice
        /// 931-01 Margin Cover Removal Rejection
        /// 956-01 Rejected Margin Cover Removal Request
        /// </summary>
        /// 
        ////TODO: finish the definition in table.
        public static readonly char[] CollateralRejectedReason;


        /// <summary>
        /// Create Cash Subrecord Reject Reason : The reason that the creation of a Cash Subrecord has been rejected by the Payment Provider.
        /// 
        /// Allowable Values ‘A’ = Cash Subrecord ID does not match Payment Provider for which Payment Facility ID is supplied
        ///                  ‘B’ = Debit cap limit amount is incorrect
        ///                  ‘C’ = Debit cap activity value is incorrect
        ///                  ‘D’ = Cash Subrecord ID is incorrect
        ///                  ‘E’ = Payment Facility ID is incorrect
        ///                  ‘F’ = Exclusion Flag is incorrect for this Cash Subrecord
        ///                  ‘G’ = Cannot nominate this Cash Subrecord as sell default
        ///                  ‘H’ = Cannot nominate this Cash Subrecord as buy default
        ///                  
        /// 357-01 Create Cash Subrecord Rejection
        /// 360-01 Rejected Create Cash Subrecord
        /// </summary>
        public static readonly char[] CreateCashSubrecordRejectReason = new char[8] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

        /// <summary>
        /// Income Statement Cancellation : Allows a regular standing Income Statement Report request, based
        /// on the selected Income Statement Report Type, to be cancelled.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  Space
        ///                  
        /// 868-01 Income Statement Authorisation Request
        /// 869-01 Income Statement Request
        /// </summary>
        [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly char? IncomeStatementCancellation = 'Y';

        /// <summary>
        /// Rejected Income Statement Set Reason : Identifies the reason CHESS has rejected an Income Statement
        /// message set received from a Registry
        /// 
        /// Allowable Values ‘A’ = Stated number of messages in the set is incorrect
        /// 
        /// 960-01 Rejected Registry Income Statement Set
        /// </summary>
        [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly char RejectedIncomeStatementSetReason = 'A';

        /// <summary>
        /// Rejected Net Position Reason : Indicates reason why payment provider could not authorise creation
        /// of Net Position Record in order to sponsor a client participant for RTGS settlement.
        /// 
        /// Allowable Values ‘A’ = Cash Subrecord ID does not match payment provider for which Payment Facility ID is supplied
        ///                  ‘B’ = Debit cap limit amount is incorrect
        ///                  ‘C’ = Debit cap activity value is incorrect
        ///                  ‘D’ = Cash Subrecord ID is incorrect
        ///                  ‘E’ = Payment Facility ID is incorrect
        ///                  ‘F’ = Exclusion Flag is incorrect for this Cash Subrecord
        ///                  ‘G’ = Cannot nominate this Cash Subrecord as sell default
        ///                  ‘H’ = Cannot nominate this Cash Subrecord as buy default
        ///                  
        /// 345-01 Create Net Position Rejection
        /// 348-01 Rejected Create Net Position
        /// </summary>
        public static readonly char[] RejectedNetPositionReason = new char[8] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

        /// <summary>
        /// Rejected Movement Reason : The reason that a movement of securities from an issuer controlled
        /// subregister to the CHESS subregister has been rejected by the registry.
        /// 
        /// Note: For mFund related conversions not all reasons presented
        /// below are applicable. mFund applicable reasons are marked with an asterisk (*).
        /// 
        /// Allowable Values
        #region Allowable Values
        //'A' = Issuer holding locked*
        //'B' = Certificate invalid
        //'C' = Unauthorised access
        //'D' = Certificate declared lost
        //'E' = Insufficient securities *
        //'F' = Registration Details do not match *
        //'G' = Invalid PIN
        //'H' = Invalid Registry client identifier/SRN*
        //'J' = Documentation not received
        //'K' = Registry certificate quantity different to certificate quantity supplied
        //'L' = Duplicate certificate number detected by registry - SRN must be supplied
        //'M' = Insufficient Cum Entitlement
        //'N' = Probate not noted*
        //‘O’ = Invalid Foreign Guarantee
        //‘P’ = Insufficient Foreign Units
        //‘R’ = Documentation incorrectly signed
        #endregion Allowable Values End
        /// 
        /// 076-02 Rejected Registry to CHESS Movement
        /// 403-01 Registry to CHESS Conversion Rejection
        /// 407-01 Registry to CHESS Transfer Rejection
        /// 724-01 Conversion Rejection Issuer Sponsored Fund to CHESS
        /// 725-01 Rejected Conversion Issuer Sponsored Fund to CHESS
        /// </summary>
        public static readonly char[] RejectedMovementReason = new char[16]
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
            'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R'
        };

        /// <summary>
        /// Rejected Registry Reason : Identifies the reason a Registry has rejected an mFund request.
        /// 
        /// Allowable Values ‘A’ = DRP is not offered for this fund
        ///                  ‘C’ = Partial DRP is not offered
        ///                  ‘F’ = PDS issue date does not reflect the latest PDS
        ///                  ‘G’ = Periodic Income Statements are not offered
        ///                  ‘H’ = Periodic Income Statements are currently not available
        ///                  ‘I’ = Annual Income Statements are currently not available
        ///                  ‘Z’ = Please contact registry directly for further detail
        ///                  
        /// 860-01 Rejected Registry Authorisation
        /// 867-01 Distribution Election Registry Rejection
        /// 907-01 Income Statement Rejection
        /// </summary>
        public static readonly char[] RejectedRegistryReason = new char[7] { 'A', 'C', 'F', 'G', 'H', 'I', 'Z' };
        #endregion

        #region Bitmap Position 38
        /// <summary>
        /// Basis Of Movement 1 : States the actual relationship of an effected securities movement to current corporate actions for the underlying security.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// Cross Refernece
        #region Cross Refernece
        //002-02 Effected Demand Single Entry CHESS to CHESS Transfer
        //004-02 Effected Transferor Submitted Transfer
        //006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
        //008-03 Effected CHESS to Registry Movement
        //010-03 Applied Transferor Submitted Transfer
        //022-03 Effected Holding Adjustment
        //025-01 Single Entry Transfer Request
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //146-03 Effected Net Settlement Movement
        //172-02 Effected Registry to CHESS Conversion
        //174-02 Effected Registry to CHESS Transfer
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //422-02 Applied Registry Transaction
        //426-02 Applied Registry Authorisation Response
        //584-01 CCMS Cum Entitlement Transfer
        //602-02 Effected ACH Transaction
        //706-02 Effected Offeror Transaction
        //754-01 RTGS Settlement Movement
        //874-01 Effected Margin Cover Release and Transfer
        //890-01 Scheduled STP Transfer
        #endregion Cross Refernece End
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] BasisOfMovement1 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };

        /// <summary>
        /// Override Basis Of Movement 1 : States the relationship of a securities movement to current corporate actions for the underlying security
        /// if the relationship is not the default.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// Cross Refernece
        #region Cross Refernece
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //121-02 Change Settlement Instruction Request
        //130-02 Requested Settlement Instruction Change
        //142-02 Accrued Settlement Instruction
        //164-03 Notified Trade
        //180-02 Full Settlement Instruction
        //271-01 Loan Application
        //276-02 Accrued Loan
        //278-01 Scheduled Loan Instruction
        //280-01 Bulk Loan Application
        //286-01 Full Loan Instruction
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //425-01 Holding Adjustment
        //431-01 Takeover Transfer
        //480-01 Requested RTGS Instruction Change
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //576-01 CCMS Collateral Transfer Notification
        #endregion Cross Refernece End
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] OverrideBasisOfMovement1 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };

        /// <summary>
        /// Previous Override Basis Of Move 1 : Specifies the override basis of movement of a settlement instruction before it was altered.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] PreviousOverrideBasisOfMove1 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };
        #endregion

        #region Bitmap Position 39
        /// <summary>
        /// Basis Of Movement 2 : States the actual relationship of an effected securities movement to current corporate actions for the underlying security.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// Cross Refernece
        #region Cross Refernece
        //002-02 Effected Demand Single Entry CHESS to CHESS Transfer
        //004-02 Effected Transferor Submitted Transfer
        //006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
        //008-03 Effected CHESS to Registry Movement
        //010-03 Applied Transferor Submitted Transfer
        //022-03 Effected Holding Adjustment
        //025-01 Single Entry Transfer Request
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //146-03 Effected Net Settlement Movement
        //172-02 Effected Registry to CHESS Conversion
        //174-02 Effected Registry to CHESS Transfer
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //422-02 Applied Registry Transaction
        //426-02 Applied Registry Authorisation Response
        //584-01 CCMS Cum Entitlement Transfer
        //602-02 Effected ACH Transaction
        //706-02 Effected Offeror Transaction
        //754-01 RTGS Settlement Movement
        //874-01 Effected Margin Cover Release and Transfer
        //890-01 Scheduled STP Transfer
        #endregion Cross Refernece End
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] BasisOfMovement2 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };

        /// <summary>
        /// Override Basis Of Movement 2 : States the relationship of a securities movement to current corporate actions for the underlying security
        /// if the relationship is not the default.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// Cross Refernece
        #region Cross Refernece
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //121-02 Change Settlement Instruction Request
        //130-02 Requested Settlement Instruction Change
        //142-02 Accrued Settlement Instruction
        //164-03 Notified Trade
        //180-02 Full Settlement Instruction
        //271-01 Loan Application
        //276-02 Accrued Loan
        //278-01 Scheduled Loan Instruction
        //280-01 Bulk Loan Application
        //286-01 Full Loan Instruction
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //425-01 Holding Adjustment
        //431-01 Takeover Transfer
        //480-01 Requested RTGS Instruction Change
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //576-01 CCMS Collateral Transfer Notification
        #endregion Cross Refernece End
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] OverrideBasisOfMovement2 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };

        /// <summary>
        /// Previous Override Basis Of Move 2 : Specifies the override basis of movement of a settlement instruction before it was altered.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] PreviousOverrideBasisOfMove2 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };
        #endregion

        #region Bitmap Position 40
        /// <summary>
        /// Basis Of Movement 3 : States the actual relationship of an effected securities movement to current corporate actions for the underlying security.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// Cross Refernece
        #region Cross Refernece
        //002-02 Effected Demand Single Entry CHESS to CHESS Transfer
        //004-02 Effected Transferor Submitted Transfer
        //006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
        //008-03 Effected CHESS to Registry Movement
        //010-03 Applied Transferor Submitted Transfer
        //022-03 Effected Holding Adjustment
        //025-01 Single Entry Transfer Request
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //146-03 Effected Net Settlement Movement
        //172-02 Effected Registry to CHESS Conversion
        //174-02 Effected Registry to CHESS Transfer
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //422-02 Applied Registry Transaction
        //426-02 Applied Registry Authorisation Response
        //584-01 CCMS Cum Entitlement Transfer
        //602-02 Effected ACH Transaction
        //706-02 Effected Offeror Transaction
        //754-01 RTGS Settlement Movement
        //874-01 Effected Margin Cover Release and Transfer
        //890-01 Scheduled STP Transfer
        //890-01 Scheduled STP Transfer
        #endregion Cross Refernece End
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] BasisOfMovement3 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };

        /// <summary>
        /// Override Basis Of Movement 3 : States the relationship of a securities movement to current corporate actions for the underlying security
        /// if the relationship is not the default.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// Cross Refernece
        #region Cross Refernece
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //121-02 Change Settlement Instruction Request
        //130-02 Requested Settlement Instruction Change
        //142-02 Accrued Settlement Instruction
        //164-03 Notified Trade
        //180-02 Full Settlement Instruction
        //271-01 Loan Application
        //276-02 Accrued Loan
        //278-01 Scheduled Loan Instruction
        //280-01 Bulk Loan Application
        //286-01 Full Loan Instruction
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //425-01 Holding Adjustment
        //431-01 Takeover Transfer
        //480-01 Requested RTGS Instruction Change
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //576-01 CCMS Collateral Transfer Notification
        #endregion Cross Refernece End
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] OverrideBasisOfMovement3 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };

        /// <summary>
        /// Previous Override Basis Of Move 3 : Specifies the override basis of movement of a settlement instruction before it was altered.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] PreviousOverrideBasisOfMove3 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };
        #endregion

        #region Bitmap Position 41
        /// <summary>
        /// Basis Of Movement 4 : States the actual relationship of an effected securities movement to current corporate actions for the underlying security.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// Cross Refernece
        #region Cross Refernece
        //002-02 Effected Demand Single Entry CHESS to CHESS Transfer
        //004-02 Effected Transferor Submitted Transfer
        //006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
        //008-03 Effected CHESS to Registry Movement
        //010-03 Applied Transferor Submitted Transfer
        //022-03 Effected Holding Adjustment
        //025-01 Single Entry Transfer Request
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //146-03 Effected Net Settlement Movement
        //172-02 Effected Registry to CHESS Conversion
        //174-02 Effected Registry to CHESS Transfer
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //422-02 Applied Registry Transaction
        //426-02 Applied Registry Authorisation Response
        //584-01 CCMS Cum Entitlement Transfer
        //602-02 Effected ACH Transaction
        //706-02 Effected Offeror Transaction
        //754-01 RTGS Settlement Movement
        //874-01 Effected Margin Cover Release and Transfer
        //890-01 Scheduled STP Transfer
        #endregion Cross Refernece End
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] BasisOfMovement4 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };

        /// <summary>
        /// Override Basis Of Movement 4 : States the relationship of a securities movement to current corporate actions for the underlying security
        /// if the relationship is not the default.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// Cross Refernece
        #region Cross Refernece
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //121-02 Change Settlement Instruction Request
        //130-02 Requested Settlement Instruction Change
        //142-02 Accrued Settlement Instruction
        //164-03 Notified Trade
        //180-02 Full Settlement Instruction
        //271-01 Loan Application
        //276-02 Accrued Loan
        //278-01 Scheduled Loan Instruction
        //280-01 Bulk Loan Application
        //286-01 Full Loan Instruction
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //425-01 Holding Adjustment
        //431-01 Takeover Transfer
        //480-01 Requested RTGS Instruction Change
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //576-01 CCMS Collateral Transfer Notification
        #endregion Cross Refernece End
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] OverrideBasisOfMovement4 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };

        /// <summary>
        /// Previous Override Basis Of Move 4 : Specifies the override basis of movement of a settlement instruction before it was altered.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] PreviousOverrideBasisOfMove4 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };
        #endregion

        #region Bitmap Position 42
        /// <summary>
        /// Basis Of Movement 5 : States the actual relationship of an effected securities movement to current corporate actions for the underlying security.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// Cross Refernece
        #region Cross Refernece
        //002-02 Effected Demand Single Entry CHESS to CHESS Transfer
        //004-02 Effected Transferor Submitted Transfer
        //006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
        //008-03 Effected CHESS to Registry Movement
        //010-03 Applied Transferor Submitted Transfer
        //022-03 Effected Holding Adjustment
        //025-01 Single Entry Transfer Request
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //146-03 Effected Net Settlement Movement
        //172-02 Effected Registry to CHESS Conversion
        //174-02 Effected Registry to CHESS Transfer
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //422-02 Applied Registry Transaction
        //426-02 Applied Registry Authorisation Response
        //584-01 CCMS Cum Entitlement Transfer
        //602-02 Effected ACH Transaction
        //706-02 Effected Offeror Transaction
        //754-01 RTGS Settlement Movement
        //874-01 Effected Margin Cover Release and Transfer
        //890-01 Scheduled STP Transfer
        #endregion Cross Refernece End
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] BasisOfMovement5 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };

        /// <summary>
        /// Override Basis Of Movement 5 : States the relationship of a securities movement to current corporate actions for the underlying security
        /// if the relationship is not the default.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// Cross Refernece
        #region Cross Refernece
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //121-02 Change Settlement Instruction Request
        //130-02 Requested Settlement Instruction Change
        //142-02 Accrued Settlement Instruction
        //164-03 Notified Trade
        //180-02 Full Settlement Instruction
        //271-01 Loan Application
        //276-02 Accrued Loan
        //278-01 Scheduled Loan Instruction
        //280-01 Bulk Loan Application
        //286-01 Full Loan Instruction
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //425-01 Holding Adjustment
        //431-01 Takeover Transfer
        //480-01 Requested RTGS Instruction Change
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //576-01 CCMS Collateral Transfer Notification
        #endregion Cross Refernece End
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] OverrideBasisOfMovement5 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };

        /// <summary>
        /// Previous Override Basis Of Move 5 : Specifies the override basis of movement of a settlement instruction before it was altered.
        /// 
        /// Allowable Values 'CD' = Cum Dividend
        ///                  'XD' = Ex Dividend
        ///                  'CR' = Cum Rights issue
        ///                  'XR' = Ex Rights issue
        ///                  'CB' = Cum Bonus issue
        ///                  'XB' = Ex Bonus issue
        ///                  'CE' = Cum Entitlement
        ///                  'XE' = Ex Entitlement
        ///                  'CC' = Cum Capital return
        ///                  'XC' = Ex Capital return
        ///                  'CM' = Cum Premium return
        ///                  'XM' = Ex Premium return
        ///                  'CI' = Cum Interest
        ///                  'XI' = Ex Interest
        ///                  ‘CQ’ = Cum Equal Access Buyback
        ///                  ‘XQ’ = Ex Equal Access Buyback
        ///                  ‘CZ’ = Cum Non Pro Rata Balance
        ///                  ‘XZ’ = Ex Non Pro Rata Balance
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] PreviousOverrideBasisOfMove5 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };
        #endregion

        #region Bitmap Position 43
        /// <summary>
        /// Increase or Decrease : Indicates if the unit quantity is an addition or removal of securities from a CHESS holding.
        /// 
        /// Allowable Values '+' = Increase
        ///                  '-' = Decrease
        ///                  
        /// 022-03 Effected Holding Adjustment
        /// 082-01 Adjusted Subposition
        /// 146-03 Effected Net Settlement Movement
        /// 425-01 Holding Adjustment
        /// 584-01 CCMS Cum Entitlement Transfer
        /// 732-02Unit Adjustment
        /// 733-02Effected Fund Unit Adjustment
        /// 754-01 RTGS Settlement Movement
        /// </summary>
        public static readonly char[] IncreaseorDecrease = new char[2] { '+', '-' };

        /// <summary>
        /// Sign : Identifies if a value is positive or negative.
        /// 
        /// Allowable Values '+'
        /// 
        /// 148-01 Projected Cum Entitlement Position
        /// 152-01 Projected Holding Position
        /// </summary>
        public static readonly char[] Sign = new char[1] { '+' };
        #endregion

        #region Bitmap Position 44
        /// <summary>
        /// Pay Receive Indicator : Indicates if funds are received or paid by a user.
        /// 
        /// Allowable Values ‘P’ = Pay
        ///                  ‘R’ = Receive
        ///                  
        /// Cross Reference
        #region Cross Reference
        //150-01 Projected Funds Obligation
        //158-01 Participant Counterparty Balance
        //170-01 Effected Net Funds Movement
        //300-01 Participant Funds Notification
        //302-01 Payment Provider Funds Notification
        //310-02 Participant Funds Obligation
        //312-01 Payment Provider Funds Obligation
        //332-01 Payment Provider Transfer Request
        //350-01 Clearing Account Transfer Request
        //614-01 Cash Subrecord Details
        //616-01 Cash Subrecord Total
        //663-01 ETC Settlement Advice
        //676-01 ETC Settlement
        //756-01 RTGS Funds Movement
        #endregion Cross Reference End
        /// </summary>
        public static readonly char[] PayReceiveIndicator = new char[2] { 'P', 'R' };
        #endregion

        #region Bitmap Position 45
        /// <summary>
        /// Statement Type : Indicates to CHESS the type of statement this message relates.
        /// 
        /// Allowable Values 'I' = Daily Interest Earned Statement
        ///                  'C' = Collateral Statement
        ///                  
        /// 929-01 End Statement Notification
        /// </summary>
        public static readonly char[] StatementType = new char[2] { 'I', 'C' };

        /// <summary>
        /// Subposition Type : Identifies the type of a holding subposition.
        /// 
        /// Allowable Values 'A' = Takeover Accepted
        ///                  'O' = Options Cover
        ///                  ‘M’ = Margin Cover
        ///                  
        /// 082-01 Adjusted Subposition
        /// 502-02 Holding Subposition Detail
        /// </summary>
        public static readonly char[] SubpositionType = new char[3] { 'A', 'O', 'M' };

        /// <summary>
        /// Subposition Type Parameter : Restricts reporting to entities related to a specific subposition type.
        /// 
        /// Allowable Values 'A' = Takeover Accepted
        ///                  'O' = Options Cover
        ///                  ‘M’ = Margin Cover
        ///  
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        public static readonly char[] SubpositionTypeParameter = new char[3] { 'A', 'O', 'M' };
        #endregion

        #region Bitmap Position 46
        /// <summary>
        /// PIN : Authorisation code on an issuer sponsored holding allocated by the
        /// registry. The PIN (Personal Identification Number) may need to be
        /// provided for authorisation purposes to move securities from an
        /// issuer sponsored holding to a CHESS holding depending on the
        /// issuer's procedures.
        /// 
        /// Allowable Values
        /// NB: This field is no longer in use. If a non-zero value is present, the message is rejected.
        /// 
        /// 015-03 Issuer Sponsored to CHESS Transfer Request
        /// 017-03 Issuer Sponsored to CHESS Conversion Request
        /// 404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        /// 408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        /// </summary>
        [StringLength(4, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PIN { get; set; }
        #endregion

        #region Bitmap Position 47
        /// <summary>
        /// Takeover Code : Unique identifier of a takeover or equal access buyback allocated by ASX.
        /// 
        /// Allowable Values Any value allocated by ASX to identify a takeover.
        /// 
        /// Cross Reference
        #region Cross Reference
        //031-02 Takeover Acceptance
        //034-04 Effected Takeover Transfer
        //035-01 Offeror Takeover Acceptance Rejection
        //036-01 Offeror Takeover Acceptance Notification
        //082-01 Adjusted Subposition
        //085-02 Takeover Acceptance Removal Request
        //092-01 Offeror Takeover Acceptance Removal Notification
        //431-01 Takeover Transfer
        //502-02 Holding Subposition Detail
        //546-01 Revised Holder Registration Details
        //701-01 Takeover Acceptance Rejection
        //702-02 Takeover Acceptance Removal Authorisation Request
        //704-02 Takeover Acceptance Notification
        //707-01 Offeror Takeover Acceptance Removal
        //710-01 Rejected Offeror Takeover Acceptance
        //711-01 Offeror Takeover Acceptance
        #endregion Cross Reference End
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TakeoverCode { get; set; }

        /// <summary>
        /// Takeover Code Parameter : Restricts reporting to entities relating to a specific takeover or equal access buyback.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TakeoverCodeParameter { get; set; }
        #endregion

        #region Bitmap Position 48
        /// <summary>
        /// Transaction Id : Uniquely identifies a transaction within CHESS. Allocated by the user on submission of a transaction to ASX Clear.
        /// 
        /// Cross Reference
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //002-02 Effected Demand Single Entry CHESS to CHESS Transfer
        //003-02 Transferor Submitted Demand Transfer
        //004-02 Effected Transferor Submitted Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //008-03 Effected CHESS to Registry Movement
        //009-03 Demand CHESS to Certificated Transfer Request
        //010-03 Applied Transferor Submitted Transfer
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //016-01 Accepted Registry to CHESS Movement Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //018-02 Effected Holding Transformation
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //022-03 Effected Holding Adjustment
        //023-01 ACH Collateral Removal Request
        //024-01 Rejected Demand Dual Entry CHESS to CHESS Transfer
        //025-01 Single Entry Transfer Request
        //026-01 Single Entry Transfer Acknowledgement
        //027-03 Collateral Creation Request
        //028-01 Created Collateral
        //029-03 Collateral Removal Request
        //031-02 Takeover Acceptance
        //032-01 Effected Takeover Acceptance
        //034-04 Effected Takeover Transfer
        //035-01 Offeror Takeover Acceptance Rejection
        //036-01 Offeror Takeover Acceptance Notification
        //037-01 Demand Dual Entry CHESS to CHESS Transfer Cancellation Request
        //040-01 Accepted Collateral Removal Request
        //042-05 Collateral Release
        //050-02 Effected Security Code Change
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //082-01 Adjusted Subposition
        //084-01 Effected Participant Transaction
        //085-02 Takeover Acceptance Removal Request
        //086-01 Accepted Takeover Acceptance Removal Request
        //090-03 Full Transferor Submitted Demand Transfer
        //092-01 Offeror Takeover Acceptance Removal Notification
        //093-01 Price Registration
        //097-02 Price Notification Registration
        //098-01 Price Notification Acceptance
        //100-01 Trade Removal Notification
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //103-01 CP Collateral Removal Authorisation
        //104-01 Collateral Removal Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //106-01 Scheduled Single Entry Settlement CHESS to CHESS Transfer
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //108-01 Collateral Creation Acceptance Advice
        //109-01 CP Collateral Removal Rejection
        //110-01 CP Collateral Removal Acceptance Advice
        //111-01 External Delivery Fail Notification
        //113-01 External Delivery Fail Cancellation
        //119-01 Single Entry Settlement CHESS to CHESS Transfer Cancellation Request
        //120-01 CP Collateral Removal Rejection Advice
        //121-02 Change Settlement Instruction Request
        //123-01 Change Settlement Instruction Cancellation Request
        //125-01 Maintain Settlement Instruction Request
        //129-01 Dual Entry Settlement Cancellation Request
        //131-01 Dual Entry Settlement Instruction Cancellation Removal
        //134-01 Scheduled Net Obligation
        //135-01 Dual Entry Settlement Notification Cancellation Request
        //136-01 Reinstated Trade
        //138-01 Netted Trade
        //139-01 Isolate Counterparty Request
        //142-02 Accrued Settlement Instruction
        //144-01 Effected CP Transaction
        //146-03 Effected Net Settlement Movement
        //156-01 Settled Settlement Instruction
        //160-01 Collateral Removal Rejection Advice
        //161-02 Trade Registration Request
        //164-03 Notified Trade
        //166-01 Scheduled Dual Entry Settlement Instruction
        //168-01 CP Collateral Removal Authorisation Request
        //176-01 Collateral Creation Rejection Advice
        //180-02 Full Settlement Instruction
        //182-01 Collateral Removal to CP Notification
        //184-01 Trade Registration Acceptance
        //188-02 Full Adjusted Settlement Instruction
        //192-01 Part-Settled Settlement Instruction
        //194-01 Unmatched Dual Entry Request
        //195-01 Block Trade Request
        //197-01 Unblock Trade Request
        //201-04 New Registration Details
        //202-01 Accepted New Registration Details
        //203-04 Registration Details Update Request
        //218-01 Accepted Registration Details Update
        //234-03 Reporting Request Detail
        //240-01 Created Payment Facility
        //242-01 Applied Payment Facility Update
        //244-01 Cancelled Payment Facility
        //245-01 Change Controlling Participant Request
        //246-01 Accepted Change Controlling Participant Request
        //247-01 Change Controlling Participant Cancellation Request
        //248-01 Change Controlling Participant Authorisation Request
        //251-01 Change Controlling Participant Authorisation
        //252-01 Effected Controlling Participant Change
        //253-01 Change Controlling Participant Rejection
        //256-01 Applied Change Controlling Participant Reject
        //271-01 Loan Application
        //272-01 Accepted Loan Instruction
        //273-01 Loan Application Cancellation Request
        //275-01 Loan Return Notification
        //277-01 Loan Return Cancellation Request
        //278-01 Scheduled Loan Instruction
        //280-01 Bulk Loan Application
        //281-01 Bulk Loan Approval
        //286-01 Full Loan Instruction
        //300-01 Participant Funds Notification
        //310-02 Participant Funds Obligation
        //311-01 Participant Funds Obligation Acknowledgement
        //313-01 Participant Funds Obligation Rejection
        //332-01 Payment Provider Transfer Request
        //333-01 Payment Provider Transfer Response
        //340-01 Effected Create Net Position
        //341-01 Create Net Position Request
        //342-01 Create Net Position Record Authorisation Request
        //343-01 Create Net Position Authorisation
        //344-01 Accepted Create Net Position Response
        //345-01 Create Net Position Rejection
        //346-01 Applied Create Net Position Response
        //348-01 Rejected Create Net Position
        //351-01 Create Cash Subrecord Request
        //352-01 Create Cash Subrecord Authorisation Request
        //353-01 Create Cash Subrecord Authorisation
        //354-01 Accepted Create Cash Subrecord Response
        //356-01 Effected Create Cash Subrecord
        //357-01 Create Cash Subrecord Rejection
        //358-01 Applied Create Cash Subrecord Response
        //360-01 Rejected Create Cash Subrecord
        //361-01 Zero Sum Notification
        //371-01 Change Net Position Attributes Request
        //372-01 Changed Net Position Attributes Notification
        //373-01 Payment Provider Change Cash Subrecord Attributes Request
        //374-01 Changed Net Position Attributes Confirmation
        //375-01 Participant Change Cash Subrecord Attributes Request
        //376-01 Payment Provider Change Cash Subrecord Attributes Confirmation
        //377-01 Participant Change Cash Subrecord Attributes Authorisation
        //378-01 Accepted Participant Change Cash Subrecord Attributes
        //379-01 Participant Change Cash Subrecord Attributes Rejection
        //380-01 Participant Change Cash Subrecord Attributes Authorisation Request
        //382-01 Effected Participant Change Cash Subrecord Attributes
        //384-01 Applied Participant Change Cash Subrecord Attributes
        //386-01 Rejected Participant Change Cash Subrecord Attributes
        //398-01 Settlement Cancellation Notification
        //399-01 Settlement Cancellation Acknowledgement
        //401-01 Registry to CHESS Conversion Authorisation
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //403-01 Registry to CHESS Conversion Rejection
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //405-01 Registry to CHESS Transfer Authorisation
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //407-01 Registry to CHESS Transfer Rejection
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //421-01 Holding Transformation
        //422-02 Applied Registry Transaction
        //425-01 Holding Adjustment
        //426-02 Applied Registry Authorisation Response
        //431-01 Takeover Transfer
        //432-01 Cancelled Offeror Initiated TKO Acceptance Request
        //441-01 Cancel Settlement Type Change Request
        //451-01 Participant to CHESS SRN Request
        //452-01 CHESS to Participant SRN Request Acknowledgement
        //453-01 Registry to CHESS SRN Response
        //454-01 CHESS to Registry SRN Request
        //455-01 Registry to CHESS SRN Reject
        //456-01 CHESS to Registry SRN Response Acknowledgement
        //457-01 Participant to CHESS Holding Balance Request
        //458-01 CHESS to Participant SRN Response
        //459-01 Registry to CHESS Holding Balance Response
        //460-01 CHESS to Registry SRN Reject Acknowledgement
        //461-01 Registry to CHESS Holding Balance Reject
        //462-01 CHESS to Participant SRN Reject
        //464-01 CHESS to Participant Holding Balance Request Acknowledgement
        //466-01 CHESS to Registry Holding Balance Request
        //468-01 CHESS to Registry Holding Balance Response Acknowledgement
        //470-01 CHESS to Participant Holding Balance Response
        //472-01 CHESS to Registry Holding Balance Reject Acknowledgement
        //474-01 CHESS to Participant Holding Balance Reject
        //476-01 Authorise RTGS Instruction Confirmation
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //483-01 RTGS Notification Cancellation Request
        //484-01 Unmatched RTGS Dual Entry Request
        //485-01 RTGS Dual Entry Cancellation Request
        //487-01 RTGS Dual Entry Cancellation Removal
        //489-01 Change RTGS Instruction Request
        //491-01 Change RTGS Instruction Cancellation Request
        //493-01 Maintain RTGS Instruction Request
        //495-01 Authorise Scheduled RTGS Instruction
        //496-01 Checking RBA Funds Queue Advice
        //497-01 Settlement Type Change Request
        //500-01 RTGS Instruction Ready to Settle Advice
        //503-04 Reporting Request
        //505-01 Reporting Request Cancellation
        //518-01 Rejected Transaction
        //526-01 Accepted Reporting Request
        //528-01 Archived Sub-Register
        //530-01 Cancelled Reporting Request
        //533-02 Tax File Number / Australian Business Number Advice
        //536-01 Accepted Tax File Number / Australian Business Number Advice
        //544-01 Levy Notification
        //548-02 Reversed Levy Notification
        //550-01 Scheduled Payment Instruction
        //551-01 Aggregated Payment Request
        //553-01 Payment Set Total Record
        //554-01 Close Out Notification
        //561-01 CCMS CHESS Security Message
        //562-01 CCMS End Message
        //563-01 CCMS CHESS Calendar Message
        //564-01 CHESS Processing Status Notification
        //565-01 CCMS Reconciliation Balance
        //566-01 Recorded Collateral Registration Details
        //567-01 Collateral Giver Registration Details
        //568-01 Cancelled Collateral Registration Details
        //569-01 Collateral Giver Registration Cancellation
        //570-01 Pending Equity Settlement Balance
        //571-01 Collateral Source Account Movement Notification
        //572-01 Collateral Transfer Request
        //573-01 Successful Collateral Transfer
        //574-01 Rejected Collateral Transfer
        //575-01 Pending Collateral Transfer
        //576-01 CCMS Collateral Transfer Notification
        //577-01 CMAX Settlement Balance Update
        //578-01 Position Update
        //579-01 Collateral Acount Details
        //580-01 Collateral Acount Details Verification
        //581-01 Accepted Corporate Action Message Set
        //582-01 Rejected Corporate Action Message Set
        //583-01 CCMS Collateral Account Adjustment
        //584-01 CCMS Cum Entitlement Transfer
        //585-01 Collateral Transfer Request Cancellation
        //586-01 Linked Collateral Transfer Request
        //587-01 End of Linked Transfer Message Set
        //588-01 Rejected Linked Collateral Transfer
        //589-01 Pending Linked Collateral Transfer
        //590-01 Finalise Linked Collateral Transfer
        //591-01 Successful Linked Collateral Transfer
        //592-01 Reject Linked Collateral Transfer Request
        //601-04 Collateral Release Request
        //602-02 Effected ACH Transaction
        //603-01 Collateral Removal Authorisation
        //605-02 Collateral Removal Rejection
        //607-01 Accepted Collateral
        //609-02 Rejected Collateral
        //610-04 Collateral Request
        //612-04 Collateral Removal Authorisation Request
        //614-01 Cash Subrecord Details
        //651-01 ETC Trade Advice
        //652-01 ETC Trade
        //653-02 ETC Trade Allocation Advice
        //654-01 ETC Trade Advice Acknowledgement
        //655-01 ETC Trade Rejection Advice
        //656-02 ETC Trade Allocation
        //657-01 Contract Note Advice
        //658-01 ETC Trade Allocation Acknowledgement
        //659-01 Contract Note Rejection Advice
        //660-01 ETC Trade Rejection
        //661-01 Allocation Cancellation Advice
        //662-01 ETC Trade Rejection Acknowledgement
        //663-01 ETC Settlement Advice
        //664-01 Contract Note
        //665-01 ETC Settlement Cancellation Advice
        //666-01 Contract Note Advice Acknowledgement
        //667-01 ETC Trade Cancellation Advice
        //668-01 Contract Note Rejection
        //669-01 ETC Contract Note Cancellation Advice
        //670-01 Contract Note Rejection Acknowledgement
        //672-01 Allocation Cancellation
        //674-01 Allocation Cancellation Acknowledgement
        //676-01 ETC Settlement
        //678-01 ETC Settlement Advice Acknowledgement
        //680-01 ETC Settlement Cancellation
        //682-01 ETC Settlement Cancellation Acknowledgement
        //684-01 ETC Trade Cancellation
        //686-01 ETC Trade Cancellation Acknowledgement
        //688-01 ETC Contract Note Cancellation
        //690-01 ETC Contract Note Cancellation Acknowledgement
        //691-01 Controlling PID and Holder Status Request
        //692-01 Controlling PID and Holder Status Response
        //694-01 Cancelled Transfer or Conversion Request
        //701-01 Takeover Acceptance Rejection
        //702-02 Takeover Acceptance Removal Authorisation Request
        //703-01 Takeover Acceptance Removal Authorisation
        //704-02 Takeover Acceptance Notification
        //705-01 Takeover Acceptance Removal Rejection
        //706-02 Effected Offeror Transaction
        //707-01 Offeror Takeover Acceptance Removal
        //711-01 Offeror Takeover Acceptance
        //715-01 CHESS to Issuer Sponsored Fund Conversion Request
        //716-01 CHESS Conversion Request to Issuer Sponsored Fund
        //717-01 Effected CHESS Conversion to Issuer Sponsored Fund
        //718-02Issuer Sponsored Fund to CHESS Conversion Request
        //719-02Issuer Sponsored Fund to CHESS Conversion Authorisation Request
        //720-01 Accepted Participant Request
        //721-01 Conversion Authorisation Issuer Sponsored Fund to CHESS
        //722-01 Fund Response
        //723-01 Effected Conversion Issuer Sponsored Fund to CHESS
        //724-01 Conversion Rejection Issuer Sponsored Fund to CHESS
        //725-01 Rejected Conversion Issuer Sponsored Fund to CHESS
        //726-02 Application Request
        //727-02 Application Order Request
        //729-01 Application Order/Payment Plan Application Response
        //730-02Effected Application Order/Payment Plan Application Response
        //731-01 Scheduled Settlement Payment Instruction
        //732-02Unit Adjustment
        //733-02Effected Fund Unit Adjustment
        //735-01 Foreign Tax Status
        //736-01 Foreign Tax Status
        //752-01 Requesting Funds Approval
        //754-01 RTGS Settlement Movement
        //756-01 RTGS Funds Movement
        //757-02 Holding Advice
        //758-01 Holding Advice Acknowledgement
        //759-01 Holding Advice Acceptance
        //760-02 Holding Advice Notification
        //761-01 Holding Advice Rejection
        //762-01 Effected Registry Transaction
        //764-01 Accepted Holding Advice
        //766-01 Rejected Holding Advice
        //800-02Redemption Request
        //801-02Redemption Order Request
        //802-02Redemption Order Response
        //803-02Effected Redemption Order Request
        //804-01 Funds Order Cancellation Request
        //805-01 Order Cancellation Request
        //806-02Switch Request
        //807-02Switch Order Request
        //808-02Switch Order Response
        //809-02Effected Switch Order Request
        //810-01 Update Order
        //811-01 Effected Update Order
        //812-01 Reminder Notice
        //813-01 Income Statement
        //816-01 Income Statement Advice
        //817-01 Distribution Re-investment Notification
        //818-01 Effected Distribution Re-investment Plan Advice
        //822-01 Cancelled Funds Settlement Payment Instruction
        //824-01 Change Settlement Date
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        //837-01 Participant to CHESS Fund Balance Request
        //838-01 CHESS to Registry Fund Balance Request
        //839-01 Registry to CHESS Fund Balance Response
        //840-01 CHESS to Participant Fund Balance Response
        //841-01 Registry to CHESS Fund Balance Rejection
        //842-01 CHESS to Participant Fund Balance Reject
        //845-02Unit Reversal Notification
        //846-02Effected Unit Reversal Notification
        //860-01 Rejected Registry Authorisation
        //863-01 Distribution Election Request
        //864-01 Distribution Election Authorisation Request
        //865-01 Distribution Election Registry Authorisation
        //866-01 Accepted Distribution Election Request
        //867-01 Distribution Election Registry Rejection
        //868-01 Income Statement Authorisation Request
        //869-01 Income Statement Request
        //870-01 Accepted Margin Cover Creation Request
        //871-01 Margin Cover Creation Request
        //872-01 Margin Cover Creation Authorisation Request
        //873-01 Margin Cover Creation Authorisation
        //874-01 Effected Margin Cover Release and Transfer
        //875-01 Margin Cover Creation Rejection
        //877-01 Margin Cover Removal Request
        //879-01 Margin Cover Removal Authorisation
        //880-01 Accepted Margin Cover Removal Request
        //881-01 Income Statement Authorisation
        //882-01 Margin Cover Removal Authorisation Request
        //883-01 ASXCL Removal Margin Cover
        //884-01 Accepted Income Statement Request
        //885-01 ASXCL Margin Cover Removal Request
        //886-01 Accepted STP Collateral Removal Request
        //887-01 STP Collateral Removal Request
        //888-01 STP Collateral Removal Authorisation Request
        //889-01 STP Collateral Removal Authorisation
        //890-01 Scheduled STP Transfer
        //891-01 STP Collateral Removal Rejection
        //893-01 STP CP Collateral Removal Authorisation
        //894-01 STP Collateral Removal CP Authorisation Request
        //895-01 STP CP Collateral Removal Rejection
        //896-01 STP Collateral Removal CP Notification
        //897-01 STP Collateral Removal Cancellation Request
        //900-01 STP Collateral Removal CP Rejection Advice
        //903-01 STP CP Collateral Removal Cancellation Authorisation
        //905-01 STP CP Collateral Removal Cancellation Rejection
        //907-01 Income Statement Rejection
        //909-01 Excess Cash Standing Instruction Request
        //911-01 Daily Interest Earned Notification
        //913-01 Excess Cash Standing Instruction Authorisation
        //915-01 Excess Cash Standing Instruction Rejection
        //917-01 Margin Settlement Notification
        //921-01 Margin Settlement Amount Change Request
        //923-01 Margin Settlement Amount Change Authorisation
        //924-01 STP Reduced Collateral Notification
        //925-01 Margin Settlement Amount Change Rejection
        //927-01 Collateral Statement Notification
        //929-01 End Statement Notification
        //930-01 Scheduled STP Collateral Rejection CP Advice
        //931-01 Margin Cover Removal Rejection
        //932-01 Excess Cash Standing Instruction Authorisation Request
        //934-01 Accepted Excess Cash Standing Instruction Request
        //940-01 Daily Interest Earned Statement
        //942-01 Margin Settlement Advice
        //944-01 Margin Settlement Amount Change Authorisation Request
        //946-01 Accepted Margin Settlement Amount Change Request
        //952-01 Collateral Statement
        //954-01 End Statement
        //957-02Registry Income Statement Part A
        //958-01 Accepted Registry Income Statement Set
        //959-01 Registry Income Statement Part B
        //960-01 Rejected Registry Income Statement Set
        //961-01 Registry Income Statement Part C AI
        //962-02Participant Income Statement Part A
        //963-01 Registry Income Statement Part C CG
        //964-01 Participant Income Statement Part B
        //965-01 Registry Income Statement Part C FI
        //966-01 Participant Income Statement Part C AI
        //967-02Registry Income Statement Part C NA
        //968-01 Participant Income Statement Part C CG
        //969-01 Registry Income Statement Part C OD
        //970-01 Participant Income Statement Part C FI
        //971-01 End Registry Income Statement Set
        //972-02Participant Income Statement Part C NA
        //974-01 Participant Income Statement Part C OD
        //976-01 End Participant Income Statement Set
        #endregion Cross Reference End
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TransactionId { get; set; }
        #endregion

        #region Bitmap Position 49
        /// <summary>
        /// Target Transaction Id : The identifier of the transaction which is the target of the required action, 
        /// e.g.a settlement date update, a cancellation message.
        /// Cross Reference
        #region Cross Reference
        //020-01 ACH Accepted Collateral
        //030-02 Reduced Collateral
        //031-02 Takeover Acceptance
        //035-01 Offeror Takeover Acceptance Rejection
        //037-01 Demand Dual Entry CHESS to CHESS Transfer Cancellation Request
        //038-01 Reversed Takeover Acceptance
        //048-01 Cancelled Demand Dual Entry Transfer Request
        //050-02 Effected Security Code Change
        //076-02 Rejected Registry to CHESS Movement
        //078-02 Rejected Collateral Removal
        //080-02 Rejected Registration Details Update
        //088-01 Rejected Takeover Acceptance Removal Request
        //103-01 CP Collateral Removal Authorisation
        //109-01 CP Collateral Removal Rejection
        //110-01 CP Collateral Removal Acceptance Advice
        //111-01 External Delivery Fail Notification
        //112-01 Notified External Delivery Failure
        //113-01 External Delivery Fail Cancellation
        //114-01 Cancelled External Delivery Failure
        //116-01 Cancelled Settlement Instruction
        //118-01 Cancelled Change Settlement Instruction Request
        //119-01 Single Entry Settlement CHESS to CHESS Transfer Cancellation Request
        //120-01 CP Collateral Removal Rejection Advice
        //121-02 Change Settlement Instruction Request
        //122-01 Unmatched Change Settlement Instruction Request
        //123-01 Change Settlement Instruction Cancellation Request
        //124-01 Rescheduled Settlement Instruction
        //125-01 Maintain Settlement Instruction Request
        //126-01 Updated Settlement Instruction
        //128-02 Adjusted Settlement Instruction
        //129-01 Dual Entry Settlement Cancellation Request
        //130-02 Requested Settlement Instruction Change
        //131-01 Dual Entry Settlement Instruction Cancellation Removal
        //132-01 Removed Dual Entry Settlement Instruction Cancellation Request
        //135-01 Dual Entry Settlement Notification Cancellation Request
        //136-01 Reinstated Trade
        //138-01 Netted Trade
        //139-01 Isolate Counterparty Request
        //140-01 Cancelled Net Obligation
        //160-01 Collateral Removal Rejection Advice
        //162-01 Suspended Settlement Instruction
        //172-02 Effected Registry to CHESS Conversion
        //174-02 Effected Registry to CHESS Transfer
        //178-01 Unmatched Dual Entry Settlement Instruction Cancellation Request
        //190-01 Predicted Partial Fail Advice
        //195-01 Block Trade Request
        //196-01 Blocked Trade
        //197-01 Unblock Trade Request
        //198-01 Unblocked Trade
        //220-02 Authorised Registration Details
        //247-01 Change Controlling Participant Cancellation Request
        //250-01 Cancelled Change Controlling Participant Request
        //251-01 Change Controlling Participant Authorisation
        //252-01 Effected Controlling Participant Change
        //253-01 Change Controlling Participant Rejection
        //254-01 Rejected Change Controlling Participant
        //273-01 Loan Application Cancellation Request
        //277-01 Loan Return Cancellation Request
        //281-01 Bulk Loan Approval
        //282-01 Rejected Loan Application
        //284-01 Cancelled Loan Instruction
        //311-01 Participant Funds Obligation Acknowledgement
        //313-01 Participant Funds Obligation Rejection
        //333-01 Payment Provider Transfer Response
        //340-01 Effected Create Net Position
        //343-01 Create Net Position Authorisation
        //345-01 Create Net Position Rejection
        //348-01 Rejected Create Net Position
        //353-01 Create Cash Subrecord Authorisation
        //356-01 Effected Create Cash Subrecord
        //357-01 Create Cash Subrecord Rejection
        //360-01 Rejected Create Cash Subrecord
        //377-01 Participant Change Cash Subrecord Attributes Authorisation
        //379-01 Participant Change Cash Subrecord Attributes Rejection
        //382-01 Effected Participant Change Cash Subrecord Attributes
        //386-01 Rejected Participant Change Cash Subrecord Attributes
        //399-01 Settlement Cancellation Acknowledgement
        //401-01 Registry to CHESS Conversion Authorisation
        //403-01 Registry to CHESS Conversion Rejection
        //405-01 Registry to CHESS Transfer Authorisation
        //407-01 Registry to CHESS Transfer Rejection
        //410-01 Requested Settlement Type Change
        //441-01 Cancel Settlement Type Change Request
        //442-01 Cancelled Change RTGS Instruction Request
        //444-01 Unmatched Change Settlement Type Request
        //446-01 Updated RTGS Instruction
        //448-01 Adjusted Settlement Type
        //450-01 Cancelled Request to Change Settlement Type
        //453-01 Registry to CHESS SRN Response
        //454-01 CHESS to Registry SRN Request
        //455-01 Registry to CHESS SRN Reject
        //458-01 CHESS to Participant SRN Response
        //459-01 Registry to CHESS Holding Balance Response
        //461-01 Registry to CHESS Holding Balance Reject
        //462-01 CHESS to Participant SRN Reject
        //466-01 CHESS to Registry Holding Balance Request
        //470-01 CHESS to Participant Holding Balance Response
        //474-01 CHESS to Participant Holding Balance Reject
        //476-01 Authorise RTGS Instruction Confirmation
        //478-01 Unmatched Change RTGS Instruction Request
        //480-01 Requested RTGS Instruction Change
        //483-01 RTGS Notification Cancellation Request
        //485-01 RTGS Dual Entry Cancellation Request
        //487-01 RTGS Dual Entry Cancellation Removal
        //489-01 Change RTGS Instruction Request
        //490-01 Unmatched RTGS Instruction Cancellation Request
        //491-01 Change RTGS Instruction Cancellation Request
        //492-01 Removed RTGS Instruction Cancellation Request
        //493-01 Maintain RTGS Instruction Request
        //495-01 Authorise Scheduled RTGS Instruction
        //496-01 Checking RBA Funds Queue Advice
        //497-01 Settlement Type Change Request
        //500-01 RTGS Instruction Ready to Settle Advice
        //505-01 Reporting Request Cancellation
        //544-01 Levy Notification
        //548-02 Reversed Levy Notification
        //554-01 Close Out Notification
        //585-01 Collateral Transfer Request Cancellation
        //603-01 Collateral Removal Authorisation
        //605-02 Collateral Removal Rejection
        //607-01 Accepted Collateral
        //609-02 Rejected Collateral
        //653-02 ETC Trade Allocation Advice
        //655-01 ETC Trade Rejection Advice
        //656-02 ETC Trade Allocation
        //657-01 Contract Note Advice
        //659-01 Contract Note Rejection Advice
        //660-01 ETC Trade Rejection
        //661-01 Allocation Cancellation Advice
        //664-01 Contract Note
        //665-01 ETC Settlement Cancellation Advice
        //667-01 ETC Trade Cancellation Advice
        //668-01 Contract Note Rejection
        //669-01 ETC Contract Note Cancellation Advice
        //672-01 Allocation Cancellation
        //680-01 ETC Settlement Cancellation
        //684-01 ETC Trade Cancellation
        //688-01 ETC Contract Note Cancellation
        //701-01 Takeover Acceptance Rejection
        //703-01 Takeover Acceptance Removal Authorisation
        //705-01 Takeover Acceptance Removal Rejection
        //710-01 Rejected Offeror Takeover Acceptance
        //759-01 Holding Advice Acceptance
        //761-01 Holding Advice Rejection
        //764-01 Accepted Holding Advice
        //766-01 Rejected Holding Advice
        //804-01 Funds Order Cancellation Request
        //805-01 Order Cancellation Request
        //810-01 Update Order
        //811-01 Effected Update Order
        //812-01 Reminder Notice
        //824-01 Change Settlement Date
        //873-01 Margin Cover Creation Authorisation
        //875-01 Margin Cover Creation Rejection
        //876-01 Accepted Margin Cover Creation
        //878-01 Reduced Margin Cover
        //879-01 Margin Cover Removal Authorisation
        //889-01 STP Collateral Removal Authorisation
        //891-01 STP Collateral Removal Rejection
        //892-01 Rejected STP Collateral Removal Request
        //893-01 STP CP Collateral Removal Authorisation
        //895-01 STP CP Collateral Removal Rejection
        //897-01 STP Collateral Removal Cancellation Request
        //900-01 STP Collateral Removal CP Rejection Advice
        //903-01 STP CP Collateral Removal Cancellation Authorisation
        //904-01 STP Collateral Removal Cancellation Notification
        //905-01 STP CP Collateral Removal Cancellation Rejection
        //906-01 Effected STP Collateral Removal Cancellation
        //908-01 Accepted STP Collateral Removal Cancellation Request
        //910-01 STP Collateral Removal CP Cancellation Authorisation Request
        //912-01 STP Collateral Removal CP Cancellation Notification
        //913-01 Excess Cash Standing Instruction Authorisation
        //915-01 Excess Cash Standing Instruction Rejection
        //916-01 Rejected STP Collateral Removal Cancellation
        //920-01 STP Collateral Removal Cancellation Rejection Advice
        //922-01 Adjusted Scheduled STP Release
        //923-01 Margin Settlement Amount Change Authorisation
        //925-01 Margin Settlement Amount Change Rejection
        //926-01 Scheduled STP Collateral Removal
        //928-01 Scheduled STP Collateral Removal CP Advice
        //930-01 Scheduled STP Collateral Rejection CP Advice
        //931-01 Margin Cover Removal Rejection
        //936-01 Effected Excess Cash Standing Instruction Request
        //938-01 Rejected Excess Cash Standing Instruction Request
        //948-01 Effected Margin Settlement Amount Change
        //950-01 Rejected Margin Settlement Amount Change
        //956-01 Rejected Margin Cover Removal Request
        #endregion Cross Reference End
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TargetTransactionId { get; set; }

        /// <summary>
        /// Linking Transaction Id : mFund specific. When used in an ‘Initial’ application request this field
        /// equals the Transaction Id of the MT726 Application Request. When
        /// used in a ‘Subsequent’ application request or as a standalone request
        /// this field equals the Transaction Id of the requesting message. When
        /// used in a transfer request this value is the Transaction Id of the
        /// originating MT851 CHESS To CHESS Fund Transfer Request.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// 738-01 Participant Investor Details
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string LinkingTransactionId { get; set; }

        /// <summary>
        /// Parent Transaction Id : Identifies the transaction which was originally diary adjusted
        /// resulting in the creation of the accrued settlement instruction.
        /// 
        /// 142-02 Accrued Settlement Instruction
        /// 180-02 Full Settlement Instruction
        /// 276-02 Accrued Loan
        /// 286-01 Full Loan Instruction
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ParentTransactionId { get; set; }

        /// <summary>
        /// Part-Settled Transaction Id : The identifier of the transaction under which the part-settlement of a
        /// settlement instruction is recorded. This identifier is CHESS CHESSallocated.
        /// 
        /// 192-01 Part-Settled Settlement Instruction
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Part_SettledTransactionId { get; set; }

        /// <summary>
        /// Set Transaction Id : Uniquely identifies a transaction set within CHESS. Allocated by the
        /// user on submission of each transaction in the set to ASX Clear. This
        /// value will be used to link a series of messages for processing.
        /// 
        /// Cross Reference
        #region Cross Reference
        //025-01 Single Entry Transfer Request
        //026-01 Single Entry Transfer Acknowledgement
        //911-01 Daily Interest Earned Notification
        //927-01 Collateral Statement Notification
        //929-01 End Statement Notification
        //940-01 Daily Interest Earned Statement
        //952-01 Collateral Statement
        //954-01 End Statement
        //957-02Registry Income Statement Part A
        //958-01 Accepted Registry Income Statement Set
        //959-01 Registry Income Statement Part B
        //960-01 Rejected Registry Income Statement Set
        //961-01 Registry Income Statement Part C AI
        //962-02Participant Income Statement Part A
        //963-01 Registry Income Statement Part C CG
        //964-01 Participant Income Statement Part B
        //965-01 Registry Income Statement Part C FI
        //966-01 Participant Income Statement Part C AI
        //967-02Registry Income Statement Part C NA
        //968-01 Participant Income Statement Part C CG
        //969-01 Registry Income Statement Part C OD
        //970-01 Participant Income Statement Part C FI
        //971-01 End Registry Income Statement Set
        //972-02Participant Income Statement Part C NA
        //974-01 Participant Income Statement Part C OD
        //976-01 End Participant Income Statement Set
        #endregion Cross Reference End
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SetTransactionId { get; set; }

        /// <summary>
        /// Transaction Id Parameter : Restricts reporting to a specific transaction.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TransactionIdParameter { get; set; }
        #endregion

        #region Bitmap Position 50
        /// <summary>
        /// Verification Name : This value is used to verify that a holding record identified as
        /// belonging to a SRN at the registry, matches with the holder name
        /// provided by the participant.
        /// 
        /// Allowable Values The first 12 bytes of the holder registration details.
        /// 
        /// 457-01 Participant to CHESS Holding Balance Request
        /// 461-01 Registry to CHESS Holding Balance Reject
        /// 466-01 CHESS to Registry Holding Balance Request
        /// 837-01 Participant to CHESS Fund Balance Request
        /// 838-01 CHESS to Registry Fund Balance Request
        /// 841-01 Registry to CHESS Fund Balance Rejection
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string VerificationName { get; set; }
        #endregion

        #region Bitmap Position 51
        /// <summary>
        /// Securityholder Reference Number : Unique identifier of a holder on an issuer controlled subregister allocated by the issuer or its registry.
        /// 
        /// Cross Reference
        #region Cross Reference
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //453-01 Registry to CHESS SRN Response
        //457-01 Participant to CHESS Holding Balance Request
        //458-01 CHESS to Participant SRN Response
        //459-01 Registry to CHESS Holding Balance Response
        //461-01 Registry to CHESS Holding Balance Reject
        //466-01 CHESS to Registry Holding Balance Request
        //718-02Issuer Sponsored Fund to CHESS Conversion Request
        //719-02Issuer Sponsored Fund to CHESS Conversion Authorisation Request
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        //837-01 Participant to CHESS Fund Balance Request
        //838-01 CHESS to Registry Fund Balance Request
        //839-01 Registry to CHESS Fund Balance Response
        //841-01 Registry to CHESS Fund Balance Rejection
        #endregion Cross Reference End
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SecurityholderReferenceNumber { get; set; }
        #endregion

        #region Bitmap Position 52
        /// <summary>
        /// Allocation Quantity : The quantity of units of a security for a specific allocation.
        /// 
        /// Allowable Values Greater or equal to zero (ie >= 0)
        /// 
        /// 653-02 ETC Trade Allocation Advice
        /// 656-02 ETC Trade Allocation
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AllocationQuantity { get; set; }

        /// <summary>
        /// Entitlement Balance : The number of units of a security for which the holder is eligible to 
        /// receive entitlements in respect of a specific corporate action.
        /// 
        /// 520-02 Cum Entitlement Balance
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string EntitlementBalance { get; set; }

        /// <summary>
        /// Failing Unit Quantity : The number of units that have not been delivered for a given settlement instruction.
        /// 
        /// 111-01 External Delivery Fail Notification
        /// 112-01 Notified External Delivery Failure
        /// 190-01 Predicted Partial Fail Advice
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string FailingUnitQuantity { get; set; }

        /// <summary>
        /// Guaranteed Foreign Net Offs : The total foreign guaranteed unit quantity of holding transactions
        /// effected during the day that reduced the CHESS foreign holding
        /// balance. Applicable only to securities subject to CHESS foreign
        /// ownership restrictions.
        /// 
        /// 514-01 Aggregated Foreign to Foreign Allocations
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string GuaranteedForeignNetOffs { get; set; }

        /// <summary>
        /// Net Offs : The total unit quantity of holding transactions effected during the day
        /// that reduced the CHESS holding balance.
        /// 
        /// 506-01 Cum Entitlement Net Movement
        /// 510-01 Holding Net Movement
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string NetOffs { get; set; }

        /// <summary>
        /// Previous Unit Quantity : Specifies the unit quantity of a settlement instruction before it was altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// 192-01 Part-Settled Settlement Instruction
        /// 274-01 Adjusted Loan
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PreviousUnitQuantity { get; set; }

        /// <summary>
        /// Projected Security Position : The estimated securities position for a holding in a future settlement cycle.
        /// 
        /// 148-01 Projected Cum Entitlement Position
        /// 152-01 Projected Holding Position
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ProjectedSecurityPosition { get; set; }

        /// <summary>
        /// Reducing Unit Quantity : The unit quantity that is to be subtracted from a CHESS holding
        /// following the application of a registry transaction.
        /// 
        /// 018-02 Effected Holding Transformation
        /// 421-01 Holding Transformation
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ReducingUnitQuantity { get; set; }

        /// <summary>
        /// Securities Shortfall : The number of units that the specified holding was short by in the
        /// Settlement cycle in order to fulfil its aggregate delivery obligation.
        /// 
        /// 544-01 Levy Notification
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SecuritiesShortfall { get; set; }

        /// <summary>
        /// Total Movements Off : The total number of units of a particular security that have been
        /// moved off the CHESS sub-register during a selected date range.
        /// 
        /// 560-01 Top Security Holder Report
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TotalMovementsOff { get; set; }

        /// <summary>
        /// Total Units On Sub-Register : The total units of a particular security that are registered on the
        /// CHESS subregister. NB: represents the total of the total unit
        /// balance of all holdings in a particular security.
        /// 
        /// 532-01 Total Security Balance
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TotalUnitsOnSub_Register { get; set; }

        /// <summary>
        /// Unit Quantity : The number of units of a security that a particular transaction moves.
        /// 
        /// Cross Reference
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //008-03 Effected CHESS to Registry Movement
        //009-03 Demand CHESS to Certificated Transfer Request
        //010-03 Applied Transferor Submitted Transfer
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //022-03 Effected Holding Adjustment
        //023-01 ACH Collateral Removal Request
        //025-01 Single Entry Transfer Request
        //027-03 Collateral Creation Request
        //029-03 Collateral Removal Request
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //050-02 Effected Security Code Change
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //082-01 Adjusted Subposition
        //090-03 Full Transferor Submitted Demand Transfer
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //108-01 Collateral Creation Acceptance Advice
        //121-02 Change Settlement Instruction Request
        //130-02 Requested Settlement Instruction Change
        //134-01 Scheduled Net Obligation
        //139-01 Isolate Counterparty Request
        //142-02 Accrued Settlement Instruction
        //146-03 Effected Net Settlement Movement
        //160-01 Collateral Removal Rejection Advice
        //161-02 Trade Registration Request
        //164-03 Notified Trade
        //168-01 CP Collateral Removal Authorisation Request
        //176-01 Collateral Creation Rejection Advice
        //180-02 Full Settlement Instruction
        //182-01 Collateral Removal to CP Notification
        //271-01 Loan Application
        //275-01 Loan Return Notification
        //276-02 Accrued Loan
        //278-01 Scheduled Loan Instruction
        //280-01 Bulk Loan Application
        //281-01 Bulk Loan Approval
        //286-01 Full Loan Instruction
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //425-01 Holding Adjustment
        //431-01 Takeover Transfer
        //480-01 Requested RTGS Instruction Change
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //502-02 Holding Subposition Detail
        //516-01 Rights Accepted
        //524-01 Total Cum Entitlement Balance
        //570-01 Pending Equity Settlement Balance
        //571-01 Collateral Source Account Movement Notification
        //572-01 Collateral Transfer Request
        //576-01 CCMS Collateral Transfer Notification
        //577-01 CMAX Settlement Balance Update
        //584-01 CCMS Cum Entitlement Transfer
        //586-01 Linked Collateral Transfer Request
        //601-04 Collateral Release Request
        //610-04 Collateral Request
        //612-04 Collateral Removal Authorisation Request
        //651-01 ETC Trade Advice
        //652-01 ETC Trade
        //657-01 Contract Note Advice
        //663-01 ETC Settlement Advice
        //664-01 Contract Note
        //676-01 ETC Settlement
        //754-01 RTGS Settlement Movement
        //871-01 Margin Cover Creation Request
        //872-01 Margin Cover Creation Authorisation Request
        //874-01 Effected Margin Cover Release and Transfer
        //877-01 Margin Cover Removal Request
        //882-01 Margin Cover Removal Authorisation Request
        //883-01 ASXCL Removal Margin Cover
        //885-01 ASXCL Margin Cover Removal Request
        //887-01 STP Collateral Removal Request
        //888-01 STP Collateral Removal Authorisation Request
        //890-01 Scheduled STP Transfer
        //894-01 STP Collateral Removal CP Authorisation Request
        //896-01 STP Collateral Removal CP Notification
        //927-01 Collateral Statement Notification
        //952-01 Collateral Statement
        #endregion Cross Reference End
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string UnitQuantity { get; set; }

        /// <summary>
        /// Unit Quantity Accepted : The unit quantity for which a holder accepts the takeover terms.
        /// 
        /// 031-02 Takeover Acceptance
        /// 036-01 Offeror Takeover Acceptance Notification
        /// 085-02 Takeover Acceptance Removal Request
        /// 092-01 Offeror Takeover Acceptance Removal Notification
        /// 702-02 Takeover Acceptance Removal Authorisation Request
        /// 704-02 Takeover Acceptance Notification
        /// 707-01 Offeror Takeover Acceptance Removal
        /// 711-01 Offeror Takeover Acceptance
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string UnitQuantityAccepted { get; set; }
        #endregion

        #region Bitmap Position 53
        /// <summary>
        /// Guaranteed Foreign Net Ons : The total foreign guaranteed unit quantity of holding transactions that
        /// have been effected during the processing day that increased the
        /// CHESS foreign holding. Applicable only to securities subject to
        /// CHESS foreign ownership restrictions.
        /// 
        /// 514-01 Aggregated Foreign to Foreign Allocations
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string GuaranteedForeignNetOns { get; set; }

        /// <summary>
        /// Holding Balance : The unit balance of a holding.
        /// 
        /// 459-01 Registry to CHESS Holding Balance Response
        /// 470-01 CHESS to Participant Holding Balance Response
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string HoldingBalance { get; set; }

        /// <summary>
        /// Increasing Unit Quantity : The unit quantity that is to be added to a CHESS holding following the application of a registry transaction.
        /// 
        /// 018-02 Effected Holding Transformation
        /// 421-01 Holding Transformation
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string IncreasingUnitQuantity { get; set; }

        /// <summary>
        /// Net Ons : The total unit quantity of holding transactions that have been
        /// effected during the processing day that increased the CHESS holding.
        /// 
        /// 506-01 Cum Entitlement Net Movement
        /// 510-01 Holding Net Movement
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string NetOns { get; set; }

        /// <summary>
        /// New Holding Balance : The resulting unit balance of a holding following the application of a holding transaction.
        /// 
        /// Cross Reference
        #region Cross Reference
        //004-02 Effected Transferor Submitted Transfer
        //006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
        //008-03 Effected CHESS to Registry Movement
        //010-03 Applied Transferor Submitted Transfer
        //022-03 Effected Holding Adjustment
        //050-02 Effected Security Code Change
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //146-03 Effected Net Settlement Movement
        //172-02 Effected Registry to CHESS Conversion
        //174-02 Effected Registry to CHESS Transfer
        //706-02 Effected Offeror Transaction
        //754-01 RTGS Settlement Movement
        #endregion Cross Reference End
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string NewHoldingBalance { get; set; }

        /// <summary>
        /// New Subposition Balance : The resulting balance of a subposition associated with a holding
        /// following the application of a transaction that adjusts the balance.
        /// 
        /// 082-01 Adjusted Subposition
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string NewSubpositionBalance { get; set; }

        /// <summary>
        /// Outstanding Unit Quantity : The number of units of a security which remain to be settled for a settlement instruction.
        /// 
        /// 180-02 Full Settlement Instruction
        /// 286-01 Full Loan Instruction
        /// 554-01 Close Out Notification
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string OutstandingUnitQuantity { get; set; }

        /// <summary>
        /// Revised Unit Quantity : Specifies the revised unit quantity of a settlement instruction after it has been altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// 192-01 Part-Settled Settlement Instruction
        /// 274-01 Adjusted Loan
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RevisedUnitQuantity { get; set; }

        /// <summary>
        /// Total Margin Cover : The total number of units that has been pledged as margin cover on a specific CHESS holding
        /// 
        /// 870-01 Accepted Margin Cover Creation Request
        /// 878-01 Reduced Margin Cover
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TotalMarginCover { get; set; }

        /// <summary>
        /// Total Movements On : The total number of units of a particular security that have been
        /// moved onto the CHESS sub-register during a selected date range.
        /// 
        /// 560-01 Top Security Holder Report
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TotalMovementsOn { get; set; }

        /// <summary>
        /// Total Options Cover : The number of units of a security that are pledged as options cover on a specific CHESS holding.
        /// 
        /// 028-01 Created Collateral
        /// 030-02 Reduced Collateral
        /// 924-01 STP Reduced Collateral Notification
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TotalOptionsCover { get; set; }

        /// <summary>
        /// Total Unit Balance : The sum of the unit quantity of all transactions that target the
        /// CHESS holding (as either the delivering or receiving holding).
        /// 
        /// 522-02 Holding Balance
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TotalUnitBalance { get; set; }

        /// <summary>
        /// Transferor Holding Balance : The resulting holding balance of the transferor's holding following the application of a transfer.
        /// 
        /// 002-02 Effected Demand Single Entry CHESS to CHESS Transfer
        /// 034-04 Effected Takeover Transfer
        /// 042-05 Collateral Release
        /// 052-03 Full Dual Entry CHESS to CHESS Transfer
        /// 090-03 Full Transferor Submitted Demand Transfer
        /// 874-01 Effected Margin Cover Release and Transfer
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TransferorHoldingBalance { get; set; }
        #endregion

        #region Bitmap Position 54
        /// <summary>
        /// Certificate Quantity : The number of units in a security for which a certificate is issued or the held balance of a balance,
        /// held at the issuer, pursuant to a partial transfer, or the unit quantity on a marked transfer.
        /// 
        /// 021-02 Certificated to CHESS Transfer Request
        /// 056-03 Full Certificated to CHESS Transfer
        /// 406-02 Certificated to CHESS Transfer Authorisation Request
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string CertificateQuantity { get; set; }

        /// <summary>
        /// Closing Balance : The total unit quantity registered for a CHESS holding at the end of a processing day or at the end of a reporting period.
        /// 
        /// 504-01 Cum Entitlement Daily Balance
        /// 506-01 Cum Entitlement Net Movement
        /// 508-01 Holding Daily Balance
        /// 510-01 Holding Net Movement
        /// 560-01 Top Security Holder Report
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ClosingBalance { get; set; }

        /// <summary>
        /// Guaranteed Foreign Closing Balance : The total foreign guaranteed unit quantity registered for a CHESS foreign holding at the end of a processing day.
        /// Applicable only for securities subject to CHESS foreign ownership restrictions.
        /// 
        /// 514-01 Aggregated Foreign to Foreign Allocations
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string GuaranteedForeignClosingBalance { get; set; }

        /// <summary>
        /// On-Market Volume : The buy-side on-market volume for the current business day
        /// 
        /// 093-01 Price Registration
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string On_MarketVolume { get; set; }

        /// <summary>
        /// Reducing Holding Balance : The resulting unit balance of the holding which is reduced following
        /// the application of a registry transaction.
        /// 
        /// 018-02 Effected Holding Transformation
        /// 074-03 Full Single Entry CHESS to CHESS Transfer
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ReducingHoldingBalance { get; set; }

        /// <summary>
        /// Transferee Holding Balance : The resulting holding balance of the transferee's holding following
        /// the application of a transfer.
        /// 
        /// 002-02 Effected Demand Single Entry CHESS to CHESS Transfer
        /// 034-04 Effected Takeover Transfer
        /// 042-05 Collateral Release
        /// 052-03 Full Dual Entry CHESS to CHESS Transfer
        /// 090-03 Full Transferor Submitted Demand Transfer
        /// 874-01 Effected Margin Cover Release and Transfer
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TransfereeHoldingBalance { get; set; }
        #endregion

        #region Bitmap Position 55
        /// <summary>
        /// Guaranteed Movement from Registry : The total foreign guaranteed units added to a CHESS holding or a
        /// Cum Entitlement balance during a business day as a result of an
        /// authorised registry transaction. Authorised registry transactions that
        /// can cause an increase are :
        /// * an authorisation for a registry/CHESS movement; and
        /// * a holding adjustment.
        /// Applicable only for securities subject to CHESS foreign ownership restrictions.
        /// 
        /// 514-01 Aggregated Foreign to Foreign Allocations
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string GuaranteedMovementfromRegistry { get; set; }

        /// <summary>
        /// Increasing Holding Balance : The resulting unit balance of the holding which is increased following the application of a registry transaction.
        /// 
        /// 018-02 Effected Holding Transformation
        /// 074-03 Full Single Entry CHESS to CHESS Transfer
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string IncreasingHoldingBalance { get; set; }

        /// <summary>
        /// Movement from Registry : The total units added to a CHESS holding or a Cum Entitlement
        /// Balance during a business day as a result of an authorised registry
        /// transaction. Authorised registry transactions that can cause an increase are :
        /// * an authorisation for a registry/CHESS movement;
        /// * a holding adjustment; and
        /// * a holding transformation.
        /// 
        /// 506-01 Cum Entitlement Net Movement
        /// 510-01 Holding Net Movement
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string MovementfromRegistry { get; set; }

        /// <summary>
        /// Off-Market Volume : The buy-side off-market volume for the current business day
        /// 
        /// 093-01 Price Registration
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Off_MarketVolume { get; set; }

        /// <summary>
        /// Opening Balance : The total unit quantity registered for a CHESS holding at the start of a reporting period.
        /// 
        /// 560-01 Top Security Holder Report
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string OpeningBalance { get; set; }

        /// <summary>
        /// Takeover Acceptance Balance : The number of units that are pledged to the offeror on a specific
        /// CHESS holding as acceptance of their takeover offer.
        /// 
        /// 032-01 Effected Takeover Acceptance
        /// 034-04 Effected Takeover Transfer
        /// 038-01 Reversed Takeover Acceptance
        /// 092-01 Offeror Takeover Acceptance Removal Notification
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TakeoverAcceptanceBalance { get; set; }

        /// <summary>
        /// Transferor Margin Cover : The number of units pledged as margin cover on the transferor’s
        /// holding following the release of pledged units.
        /// 
        /// 874-01 Effected Margin Cover Release and Transfer
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TransferorMarginCover { get; set; }

        /// <summary>
        /// Transferor Options Cover : The number of units pledged as collateral on the transferor's holding
        /// following the release of pledged units.
        /// 
        /// 042-05 Collateral Release
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TransferorOptionsCover { get; set; }
        #endregion

        #region Bitmap Position 56
        /// <summary>
        /// Authorisation Required : Indicates if a Payment provider is required to explicitly authorise a participant funds obligation.
        /// Authorisation is required for any short participant funds obligation that is greater than any previous amount authorised.
        /// 
        /// Allowable values ‘Y’ = Yes
        ///                  ‘N’ = No
        ///                  
        /// 310-01 Participant Funds Obligation
        /// 310-02 Participant Funds Obligation
        /// </summary>
        public static readonly char[] AuthorisationRequired = new char[2] { 'Y', 'N' };

        /// <summary>
        /// Default Payment Facility Indicator : Indicates if a payment facility is used as a default for all of a 
        /// participant’s funds obligations in a settlement process apart from any specific payment facility.
        /// 
        /// Allowable values ‘Y’ = Yes
        ///                  ‘N’ = No
        /// 
        /// 230-01 Payment Facility Detail
        /// 232-01 Payment Facility History
        /// 240-01 Created Payment Facility
        /// </summary>
        public static readonly char[] DefaultPaymentFacilityIndicator = new char[2] { 'Y', 'N' };

        /// <summary>
        /// Distinct Portion Indicator : 
        #region Description
        //An indicator to be used in the acceptance of a takeover offer stating
        //that the number of securities covered by the acceptance relates to a
        //distinct portion of a security holding within the terms of Section
        //650(3) of the Corporations Law.The distinct portion indicator is to
        //be used when an offeror makes a takeover bid for securities in a
        //security holder's name and the security holder holds the securities
        //on behalf of one or more persons and only one or some of those
        //persons wish to accept the offer.
        //Defaults to 'N'.
        #endregion
        /// 
        /// Allowable Values 'Y' = Yes (This acceptance relates to a distinct portion)
        ///                  'N' = No
        ///                  
        /// 031-02 Takeover Acceptance
        /// 036-01 Offeror Takeover Acceptance Notification
        /// 704-02 Takeover Acceptance Notification
        /// 711-01 Offeror Takeover Acceptance
        /// </summary>
        public static readonly char[] DistinctPortionIndicator = new char[2] { 'Y', 'N' };

        /// <summary>
        /// Part-Settlement : Indicates that the settlement instruction can be part settled or not. Defaults to 'Y'.
        /// 
        /// Allowable Values 'Y' = Yes
        ///                  'N' = No
        ///                  
        /// 101-02 Dual Entry Settlement Notification
        /// 105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        /// 125-01 Maintain Settlement Instruction Request
        /// 444-01 Unmatched Change Settlement Type Request
        /// 448-01 Adjusted Settlement Type
        /// 497-01 Settlement Type Change Request
        /// </summary>
        public static readonly char[] Part_Settlement = new char[2] { 'Y', 'N' };

        /// <summary>
        /// Specific Cover : Indicates whether the participant (margin lenders only) request to
        /// create collateral will be to cover a single lodgement (Y) or to cover a
        /// number of lodgements (pooled) (N).
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  ‘N’ = No
        ///                  Space = No (default)
        ///                  
        /// 027-03 Collateral Creation Request
        /// 610-04 Collateral Request
        /// </summary>
        public static readonly char[] SpecificCover = new char[3] { 'Y', 'N', ' ' };

        /// <summary>
        /// Statement Required : Indicates if holding statements must be issued by ASX Clear for
        /// holdings associated with a CHESS holder.
        /// 
        /// Allowable Values 'Y' = Yes
        ///                  'N' = No
        ///                  
        /// 222-04 Holder Detail
        /// 224-03 Holder History
        /// </summary>
        public static readonly char[] StatementRequired = new char[2] { 'Y', 'N' };
        #endregion

        #region Bitmap Position 57
        /// <summary>
        /// Number Holders Affected : The number of holders that were affected by the actions of the user.
        /// 
        /// 544-01 Levy Notification
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string NumberHoldersAffected { get; set; }

        /// <summary>
        /// Total Message Count : The total number of messages sent to a user as a result of a single
        /// process. This total appears in the trailer message that summarises
        /// the previous related messages.
        /// 
        /// Cross Reference
        #region Cross Reference
        //134-01 Scheduled Net Obligation
        //140-01 Cancelled Net Obligation
        //146-03 Effected Net Settlement Movement
        //170-01 Effected Net Funds Movement
        //302-01 Payment Provider Funds Notification
        //312-01 Payment Provider Funds Obligation
        //538-01 End of Reporting
        //562-01 CCMS End Message
        //587-01 End of Linked Transfer Message Set
        //958-01 Accepted Registry Income Statement Set
        //960-01 Rejected Registry Income Statement Set
        //971-01 End Registry Income Statement Set
        //976-01 End Participant Income Statement Set
        #endregion Cross Reference End
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TotalMessageCount { get; set; }

        /// <summary>
        /// Total Reminder Count : The total number of Fund unit allotment reminders (MT812)
        /// messages transmitted for a given target Transaction Id.
        /// 
        /// 812-01 Reminder Notice
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TotalReminderCount { get; set; }

        /// <summary>
        /// Total Statement Count : The number of statements that have been sent in a related series.
        /// The count includes the End Statement Notification message.
        /// 
        /// 929-01 End Statement Notification
        /// 954-01 End Statement
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TotalStatementCount { get; set; }
        #endregion

        #region Bitmap Position 58
        /// <summary>
        /// Delivering Supplementary Reference : The supplementary reference provided by the delivering participant.
        /// 
        /// 052-03 Full Dual Entry CHESS to CHESS Transfer
        /// 180-02 Full Settlement Instruction
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DeliveringSupplementaryReference { get; set; }

        /// <summary>
        /// Revised Underlying Reference : Specifies the revised underlying reference of a settlement instruction after it has been altered.
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RevisedUnderlyingReference { get; set; }
        #endregion

        #region Bitmap Position 59
        /// <summary>
        /// Registration Details : The registered name and address of a security holder.
        /// 
        /// Cross Reference
        #region Cross Reference
        //036-01 Offeror Takeover Acceptance Notification
        //201-04 New Registration Details
        //203-04 Registration Details Update Request
        //220-02 Authorised Registration Details
        //222-04 Holder Detail
        //224-03 Holder History
        //451-01 Participant to CHESS SRN Request
        //453-01 Registry to CHESS SRN Response
        //454-01 CHESS to Registry SRN Request
        //458-01 CHESS to Participant SRN Response
        //459-01 Registry to CHESS Holding Balance Response
        //470-01 CHESS to Participant Holding Balance Response
        //512-04 Holding Registration Details
        //546-01 Revised Holder Registration Details
        //560-01 Top Security Holder Report
        //610-04 Collateral Request
        //704-02 Takeover Acceptance Notification
        //727-02 Application Order Request
        //839-01 Registry to CHESS Fund Balance Response
        //840-01 CHESS to Participant Fund Balance Response
        //844-01 Top Security Fund Holder Report
        //872-01 Margin Cover Creation Authorisation Request
        #endregion Cross Reference End
        /// </summary>
        /// 
        //// TODO: section 8.2.2 Validation
        [StringLength(180, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RegistrationDetails { get; set; }

        /// <summary>
        /// Address Details 1 : Describes a residential, registered or trust address for foreign tax purposes.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(180, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AddressDetails1 { get; set; }

        /// <summary>
        /// Delivering Registration Details : The details under which the securities involved in a movement are currently registered.
        /// 
        /// 070-03 Full CHESS to Certificated Conversion
        /// 072-03 Full CHESS to Issuer Sponsored Conversion
        /// 174-02 Effected Registry to CHESS Transfer
        /// 405-01 Registry to CHESS Transfer Authorisation
        /// 412-03 CHESS to Certificated Conversion
        /// 416-03 CHESS to Issuer Sponsored Conversion
        /// 716-01 CHESS Conversion Request to Issuer Sponsored Fund
        /// </summary>
        [StringLength(180, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DeliveringRegistrationDetails { get; set; }

        /// <summary>
        /// Initiator Name and Address : Name and address details of the initiator of the contract note.
        /// 
        /// 657-01 Contract Note Advice
        /// 664-01 Contract Note
        /// </summary>
        [StringLength(180, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string InitiatorNameandAddress { get; set; }

        /// <summary>
        /// Receiving Registration Details : The details under which the securities involved in a movement are to be registered.
        /// 
        /// Cross Reference
        #region Cross Reference
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //054-04 Full CHESS to Certificated Transfer
        //058-03 Full Certificated to CHESS Conversion
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //414-04 CHESS to Certificated Transfer
        //418-04 CHESS to Issuer Sponsored Transfer
        //719-02Issuer Sponsored Fund to CHESS Conversion Authorisation Request
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        #endregion Cross Reference End
        /// </summary>
        [StringLength(180, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ReceivingRegistrationDetails { get; set; }
        #endregion

        #region Bitmap Position 60
        /// <summary>
        /// Reschedule Reason : The cause of the rescheduling of a settlement instruction.
        /// 
        /// Allowable Values 'B' = Barred from movement
        ///                  'C' = Change of Despatch Date
        ///                  'D' = Delivering HIN not Foreign
        ///                  'F' = Failed Settlement
        ///                  'G' = Insufficient Foreign Units
        ///                  'H' = Holder Lock Applied
        ///                  'L' = Holding Lock Applied
        ///                  'P' = Participant request
        ///                  'R' = Reversal
        ///                  'S' = Subregister suspended
        ///                  'Y' = Security Not Foreign
        ///                  
        /// 124-01 Rescheduled Settlement Instruction
        /// </summary>
        public static readonly char[] RescheduleReason = new char[11] { 'B', 'C', 'D', 'F', 'G', 'H', 'L', 'P', 'R', 'S', 'Y' };
        #endregion

        #region Bitmap Position 61
        /// <summary>
        /// Rejected Order Reason : The reason why a message submitted to a Product Issuer Settlement
        /// Participant has been rejected.
        /// 
        /// Allowable Values
        #region Allowable Values
        //50000 Order Amount is less than minimum value
        //50005 Account is a Deceased Estate
        //50006 Account has insufficient units
        //50011 AML/CTF Check Flag is not Y(Yes)
        //50013 Fund is closed to Existing Accounts
        //50014 Fund is closed to New Accounts
        //50020 Current PDS Provided indicator is not Y(Yes)
        //50021 Order amount results in holding below the minimum balance
        //50023 TFN, ABN or exemption code required for Australian residents
        //50024 Date of Birth is mandatory for Individual Applicants
        //50026 Foreign Residence Indicator is incorrect
        //50027 DRP not offered for this fund
        //50029 Invalid BSB or Bank Account Details
        //50031 PDS Issue Date supplied is not the latest issued PDS
        //50032 Switch Orders not accepted by Fund Manager
        //50033 Fund pricing is currently not available
        //50034 Fund is classified as illiquid
        //50035 ABN required for superannuation funds(account type S)
        //50036 Incomplete details provided for Individual/Joint account with Foreign Tax Status
        //50037 Residential/trust/registered address for foreign resident is invalid
        //50038 Registry client identifier/SRN invalid
        //50039 Order amount is invalid
        //50040 Applications from Companies or Trusts are not accepted
        //50041 Applications from foreign tax residents are not accepted
        //50042 Fund available to restricted investors only
        #endregion Allowable Values End
        /// 
        /// 729-02 Application Order/Payment Plan Application Response
        /// 730-02 Effected Application Order/Payment Plan Application Response
        /// 802-02 Redemption Order Response
        /// 803-02 Effected Redemption Order Request
        /// 808-02 Switch Order Response
        /// 809-02 Effected Switch Order Request
        /// 810-01 Update Order
        /// 811-01 Effected Update Order
        /// </summary>
        public static readonly string[] RejectedOrderReason = new string[25]
        {
            "50000", "50005", "50006", "50011", "50013",
            "50014", "50020", "50021", "50023", "50024",
            "50026", "50027", "50029", "50031", "50032",
            "50033", "50034", "50035", "50036", "50037",
            "50038", "50039", "50040", "50041", "50042"
        };

        /// <summary>
        /// Rejected Reason : Explains the reason why a message submitted to CHESS by a user has been rejected.
        /// 
        /// Allowable Values (See section 8.5 for a list of codes and meanings.)
        /// 
        /// 518-01 Rejected Transaction
        /// </summary>
        ////TODO: fill in the list
        public static readonly string[] RejectedReason;
        #endregion

        #region Bitmap Position 62
        /// <summary>
        /// Origin Transaction Id : The identifier of the originating transaction which has caused the output message to be sent to a CHESS user.
        /// The message may be sent in response to a primary transaction submitted by a user, a reporting request submitted by a user, 
        /// a primary transaction submitted by a third party, or as a result of a CHESS process, eg. settlement.
        /// 
        /// Cross References
        #region Cross Reference 1
        //020-01 ACH Accepted Collateral
        //026-01 Single Entry Transfer Acknowledgement
        //036-01 Offeror Takeover Acceptance Notification
        //084-01 Effected Participant Transaction
        //092-01 Offeror Takeover Acceptance Removal Notification
        //108-01 Collateral Creation Acceptance Advice
        //110-01 CP Collateral Removal Acceptance Advice
        //120-01 CP Collateral Removal Rejection Advice
        //144-01 Effected CP Transaction
        //160-01 Collateral Removal Rejection Advice
        //168-01 CP Collateral Removal Authorisation Request
        //176-01 Collateral Creation Rejection Advice
        //182-01 Collateral Removal to CP Notification
        //432-01 Cancelled Offeror Initiated TKO Acceptance Request
        //536-01 Accepted Tax File Number / Australian Business Number Advice
        //584-01 CCMS Cum Entitlement Transfer
        //692-01 Controlling PID and Holder Status Response
        //694-01 Cancelled Transfer or Conversion Request
        //710-01 Rejected Offeror Takeover Acceptance
        //758-01 Holding Advice Acknowledgement
        //760-02 Holding Advice Notification
        //762-01 Effected Registry Transaction
        //764-01 Accepted Holding Advice
        //766-01 Rejected Holding Advice
        #endregion Cross Reference 1 End

        #region Cross Reference 2
        //002-02 Effected Demand Single Entry CHESS to CHESS Transfer
        //004-02 Effected Transferor Submitted Transfer
        //006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
        //008-03 Effected CHESS to Registry Movement
        //010-03 Applied Transferor Submitted Transfer
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //016-01 Accepted Registry to CHESS Movement Request
        //018-02 Effected Holding Transformation
        //022-03 Effected Holding Adjustment
        //024-01 Rejected Demand Dual Entry CHESS to CHESS Transfer
        //028-01 Created Collateral
        //030-02 Reduced Collateral
        //032-01 Effected Takeover Acceptance
        //034-04 Effected Takeover Transfer
        //038-01 Reversed Takeover Acceptance
        //040-01 Accepted Collateral Removal Request
        //042-05 Collateral Release
        //048-01 Cancelled Demand Dual Entry Transfer Request
        //050-02 Effected Security Code Change
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //076-02 Rejected Registry to CHESS Movement
        //078-02 Rejected Collateral Removal
        //080-02 Rejected Registration Details Update
        //082-01 Adjusted Subposition
        //086-01 Accepted Takeover Acceptance Removal Request
        //088-01 Rejected Takeover Acceptance Removal Request
        //090-03 Full Transferor Submitted Demand Transfer
        //096-01 Security Detail
        //098-01 Price Notification Acceptance
        //100-01 Trade Removal Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //106-01 Scheduled Single Entry Settlement CHESS to CHESS Transfer
        //112-01 Notified External Delivery Failure
        //114-01 Cancelled External Delivery Failure
        //116-01 Cancelled Settlement Instruction
        //118-01 Cancelled Change Settlement Instruction Request
        //122-01 Unmatched Change Settlement Instruction Request
        //124-01 Rescheduled Settlement Instruction
        //126-01 Updated Settlement Instruction
        //128-02 Adjusted Settlement Instruction
        //130-02 Requested Settlement Instruction Change
        //132-01 Removed Dual Entry Settlement Instruction Cancellation Request
        //134-01 Scheduled Net Obligation
        //136-01 Reinstated Trade
        //138-01 Netted Trade
        //140-01 Cancelled Net Obligation
        //142-02 Accrued Settlement Instruction
        //146-03 Effected Net Settlement Movement
        //148-01 Projected Cum Entitlement Position
        //150-01 Projected Funds Obligation
        //152-01 Projected Holding Position
        //154-01 Cancelled Funds Obligation
        //156-01 Settled Settlement Instruction
        //158-01 Participant Counterparty Balance
        //162-01 Suspended Settlement Instruction
        //164-03 Notified Trade
        //166-01 Scheduled Dual Entry Settlement Instruction
        //170-01 Effected Net Funds Movement
        //172-02 Effected Registry to CHESS Conversion
        //174-02 Effected Registry to CHESS Transfer
        //178-01 Unmatched Dual Entry Settlement Instruction Cancellation Request
        //180-02 Full Settlement Instruction
        //184-01 Trade Registration Acceptance
        //186-01 Net Trust Amount Movement
        //188-02 Full Adjusted Settlement Instruction
        //190-01 Predicted Partial Fail Advice
        //192-01 Part-Settled Settlement Instruction
        //194-01 Unmatched Dual Entry Request
        //196-01 Blocked Trade
        //198-01 Unblocked Trade
        //202-01 Accepted New Registration Details
        //204-01 Locked CHESS Holding
        //206-01 Unlocked CHESS Holding
        //218-01 Accepted Registration Details Update
        //220-02 Authorised Registration Details
        //222-04 Holder Detail
        //224-03 Holder History
        //226-01 User Detail
        //228-01 User History
        //230-01 Payment Facility Detail
        //232-01 Payment Facility History
        //234-03 Reporting Request Detail
        //240-01 Created Payment Facility
        //242-01 Applied Payment Facility Update
        //244-01 Cancelled Payment Facility
        //246-01 Accepted Change Controlling Participant Request
        //248-01 Change Controlling Participant Authorisation Request
        //250-01 Cancelled Change Controlling Participant Request
        //252-01 Effected Controlling Participant Change
        //254-01 Rejected Change Controlling Participant
        //256-01 Applied Change Controlling Participant Reject
        //272-01 Accepted Loan Instruction
        //274-01 Adjusted Loan
        //276-02 Accrued Loan
        //278-01 Scheduled Loan Instruction
        //280-01 Bulk Loan Application
        //282-01 Rejected Loan Application
        //284-01 Cancelled Loan Instruction
        //286-01 Full Loan Instruction
        //342-01 Create Net Position Record Authorisation Request
        //344-01 Accepted Create Net Position Response
        //346-01 Applied Create Net Position Response
        //352-01 Create Cash Subrecord Authorisation Request
        //354-01 Accepted Create Cash Subrecord Response
        //358-01 Applied Create Cash Subrecord Response
        //372-01 Changed Net Position Attributes Notification
        //374-01 Changed Net Position Attributes Confirmation
        //376-01 Payment Provider Change Cash Subrecord Attributes Confirmation
        //378-01 Accepted Participant Change Cash Subrecord Attributes
        //380-01 Participant Change Cash Subrecord Attributes Authorisation Request
        //384-01 Applied Participant Change Cash Subrecord Attributes
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //410-01 Requested Settlement Type Change
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //422-02 Applied Registry Transaction
        //426-02 Applied Registry Authorisation Response
        //430-01 Applied Code Change
        //442-01 Cancelled Change RTGS Instruction Request
        //444-01 Unmatched Change Settlement Type Request
        //446-01 Updated RTGS Instruction
        //448-01 Adjusted Settlement Type
        //450-01 Cancelled Request to Change Settlement Type
        //452-01 CHESS to Participant SRN Request Acknowledgement
        //456-01 CHESS to Registry SRN Response Acknowledgement
        //458-01 CHESS to Participant SRN Response
        //460-01 CHESS to Registry SRN Reject Acknowledgement
        //462-01 CHESS to Participant SRN Reject
        //464-01 CHESS to Participant Holding Balance Request Acknowledgement
        //468-01 CHESS to Registry Holding Balance Response Acknowledgement
        //470-01 CHESS to Participant Holding Balance Response
        //472-01 CHESS to Registry Holding Balance Reject Acknowledgement
        //474-01 CHESS to Participant Holding Balance Reject
        //476-01 Authorise RTGS Instruction Confirmation
        //478-01 Unmatched Change RTGS Instruction Request
        //480-01 Requested RTGS Instruction Change
        //482-01 Unmatched RTGS Dual Entry Notification
        //484-01 Unmatched RTGS Dual Entry Request
        //490-01 Unmatched RTGS Instruction Cancellation Request
        //492-01 Removed RTGS Instruction Cancellation Request
        //500-01 RTGS Instruction Ready to Settle Advice
        //502-02 Holding Subposition Detail
        //504-01 Cum Entitlement Daily Balance
        //506-01 Cum Entitlement Net Movement
        //508-01 Holding Daily Balance
        //510-01 Holding Net Movement
        //512-04 Holding Registration Details
        //514-01 Aggregated Foreign to Foreign Allocations
        //516-01 Rights Accepted
        //518-01 Rejected Transaction
        //520-02 Cum Entitlement Balance
        //522-02 Holding Balance
        //524-01 Total Cum Entitlement Balance
        //526-01 Accepted Reporting Request
        //528-01 Archived Sub-Register
        //530-01 Cancelled Reporting Request
        //532-01 Total Security Balance
        //534-02 Notified Tax File Number / Australian Business Number
        //538-01 End of Reporting
        //542-01 CHESS Event Notification
        //544-01 Levy Notification
        //546-01 Revised Holder Registration Details
        //548-02 Reversed Levy Notification
        //566-01 Recorded Collateral Registration Details
        //568-01 Cancelled Collateral Registration Details
        //573-01 Successful Collateral Transfer
        //574-01 Rejected Collateral Transfer
        //575-01 Pending Collateral Transfer
        //576-01 CCMS Collateral Transfer Notification
        //577-01 CMAX Settlement Balance Update
        //580-01 Collateral Acount Details Verification
        //583-01 CCMS Collateral Account Adjustment
        //602-02 Effected ACH Transaction
        //610-04 Collateral Request
        //612-04 Collateral Removal Authorisation Request
        //614-01 Cash Subrecord Details
        //616-01 Cash Subrecord Total
        //652-01 ETC Trade
        //654-01 ETC Trade Advice Acknowledgement
        //656-02 ETC Trade Allocation
        //658-01 ETC Trade Allocation Acknowledgement
        //660-01 ETC Trade Rejection
        //662-01 ETC Trade Rejection Acknowledgement
        //664-01 Contract Note
        //666-01 Contract Note Advice Acknowledgement
        //668-01 Contract Note Rejection
        //670-01 Contract Note Rejection Acknowledgement
        //672-01 Allocation Cancellation
        //674-01 Allocation Cancellation Acknowledgement
        //676-01 ETC Settlement
        //678-01 ETC Settlement Advice Acknowledgement
        //680-01 ETC Settlement Cancellation
        //682-01 ETC Settlement Cancellation Acknowledgement
        //684-01 ETC Trade Cancellation
        //686-01 ETC Trade Cancellation Acknowledgement
        //688-01 ETC Contract Note Cancellation
        //690-01 ETC Contract Note Cancellation Acknowledgement
        //702-02 Takeover Acceptance Removal Authorisation Request
        //704-02 Takeover Acceptance Notification
        //706-02 Effected Offeror Transaction
        //716-01 CHESS Conversion Request to Issuer Sponsored Fund
        //717-01 Effected CHESS Conversion to Issuer Sponsored Fund
        //719-02Issuer Sponsored Fund to CHESS Conversion Authorisation Request
        //720-01 Accepted Participant Request
        //721-01 Conversion Authorisation Issuer Sponsored Fund to CHESS
        //722-01 Fund Response
        //723-01 Effected Conversion Issuer Sponsored Fund to CHESS
        //724-01 Conversion Rejection Issuer Sponsored Fund to CHESS
        //725-01 Rejected Conversion Issuer Sponsored Fund to CHESS
        //727-02Application Order Request
        //729-02Application Order/Payment Plan Application Response
        //730-02Effected Application Order/Payment Plan Application Response
        //731-01 Scheduled Settlement Payment Instruction
        //732-02Unit Adjustment
        //733-02Effected Fund Unit Adjustment
        //752-01 Requesting Funds Approval
        //754-01 RTGS Settlement Movement
        //756-01 RTGS Funds Movement
        //801-02Redemption Order Request
        //802-02Redemption Order Response
        //803-02Effected Redemption Order Request
        //807-02Switch Order Request
        //808-02Switch Order Response
        //809-02Effected Switch Order Request
        //816-01 Income Statement Advice
        //818-01 Effected Distribution Re-investment Plan Advice
        //822-01 Cancelled Funds Settlement Payment Instruction
        //830-01 Holding Daily Fund Balance
        //831-01 Holding Net Fund Movement
        //832-01 Holding Fund Balance
        //833-01 Total Security Fund Balance
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        //838-01 CHESS to Registry Fund Balance Request
        //839-01 Registry to CHESS Fund Balance Response
        //840-01 CHESS to Participant Fund Balance Response
        //841-01 Registry to CHESS Fund Balance Rejection
        //842-01 CHESS to Participant Fund Balance Reject
        //844-01 Top Security Fund Holder Report
        //845-02Unit Reversal Notification
        //846-02Effected Unit Reversal Notification
        //860-01 Rejected Registry Authorisation
        //864-01 Distribution Election Authorisation Request
        //865-01 Distribution Election Registry Authorisation
        //866-01 Accepted Distribution Election Request
        //867-01 Distribution Election Registry Rejection
        //868-01 Income Statement Authorisation Request
        //870-01 Accepted Margin Cover Creation Request
        //872-01 Margin Cover Creation Authorisation Request
        //874-01 Effected Margin Cover Release and Transfer
        //876-01 Accepted Margin Cover Creation
        //878-01 Reduced Margin Cover
        //880-01 Accepted Margin Cover Removal Request
        //881-01 Income Statement Authorisation
        //882-01 Margin Cover Removal Authorisation Request
        //884-01 Accepted Income Statement Request
        //886-01 Accepted STP Collateral Removal Request
        //888-01 STP Collateral Removal Authorisation Request
        //890-01 Scheduled STP Transfer
        //892-01 Rejected STP Collateral Removal Request
        //894-01 STP Collateral Removal CP Authorisation Request
        //896-01 STP Collateral Removal CP Notification
        //900-01 STP Collateral Removal CP Rejection Advice
        //904-01 STP Collateral Removal Cancellation Notification
        //906-01 Effected STP Collateral Removal Cancellation
        //907-01 Income Statement Rejection
        //908-01 Accepted STP Collateral Removal Cancellation Request
        //910-01 STP Collateral Removal CP Cancellation Authorisation Request
        //912-01 STP Collateral Removal CP Cancellation Notification
        //916-01 Rejected STP Collateral Removal Cancellation
        //920-01 STP Collateral Removal Cancellation Rejection Advice
        //922-01 Adjusted Scheduled STP Release
        //924-01 STP Reduced Collateral Notification
        //926-01 Scheduled STP Collateral Removal
        //928-01 Scheduled STP Collateral Removal CP Advice
        //930-01 Scheduled STP Collateral Rejection CP Advice
        //932-01 Excess Cash Standing Instruction Authorisation Request
        //934-01 Accepted Excess Cash Standing Instruction Request
        //936-01 Effected Excess Cash Standing Instruction Request
        //938-01 Rejected Excess Cash Standing Instruction Request
        //940-01 Daily Interest Earned Statement
        //942-01 Margin Settlement Advice
        //944-01 Margin Settlement Amount Change Authorisation Request
        //946-01 Accepted Margin Settlement Amount Change Request
        //948-01 Effected Margin Settlement Amount Change
        //950-01 Rejected Margin Settlement Amount Change
        //952-01 Collateral Statement
        //954-01 End Statement
        //956-01 Rejected Margin Cover Removal Request
        //957-02 Registry Income Statement Part A
        //958-01 Accepted Registry Income Statement Set
        //959-01 Registry Income Statement Part B
        //960-01 Rejected Registry Income Statement Set
        //961-01 Registry Income Statement Part C AI
        //962-02Participant Income Statement Part A
        //963-01 Registry Income Statement Part C CG
        //964-01 Participant Income Statement Part B
        //965-01 Registry Income Statement Part C FI
        //966-01 Participant Income Statement Part C AI
        //967-02Registry Income Statement Part C NA
        //968-01 Participant Income Statement Part C CG
        //969-01 Registry Income Statement Part C OD
        //970-01 Participant Income Statement Part C FI
        //971-01 End Registry Income Statement Set
        //972-02Participant Income Statement Part C NA
        //974-01 Participant Income Statement Part C OD
        //976-01 End Participant Income Statement Set
        #endregion Cross Reference 2

        #region Cross Reference 3
        //560-01 Top Security Holder Report
        #endregion Cross Reference 3 End
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string OriginTransactionId { get; set; }
        #endregion

        #region Bitmap Position 63
        /// <summary>
        /// Market : The Market to which the information relates.
        /// 
        /// Allowable Values “CMM” – ASX Clear(Cash)
        /// 
        /// Cross Reference
        #region Cross Reference
        //871-01 Margin Cover Creation Request
        //872-01 Margin Cover Creation Authorisation Request
        //874-01 Effected Margin Cover Release and Transfer
        //877-01 Margin Cover Removal Request
        //882-01 Margin Cover Removal Authorisation Request
        //883-01 ASXCL Removal Margin Cover
        //885-01 ASXCL Margin Cover Removal Request
        //909-01 Excess Cash Standing Instruction Request
        //911-01 Daily Interest Earned Notification
        //917-01 Margin Settlement Notification
        //921-01 Margin Settlement Amount Change Request
        //927-01 Collateral Statement Notification
        //932-01 Excess Cash Standing Instruction Authorisation Request
        //940-01 Daily Interest Earned Statement
        //942-01 Margin Settlement Advice
        //944-01 Margin Settlement Amount Change Authorisation Request
        //952-01 Collateral Statement
        #endregion Cross Reference End
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Market { get; set; } = "CMM";

        /// <summary>
        /// Tax Residence 1 : The country in which the Fund investor is a resident for tax purposes.
        /// 
        /// Allowable Values : 3 Character ISIN Country Codes.
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TaxResidence1 { get; set; }
        #endregion

        #region Bitmap Position 64
        /// <summary>
        /// Guaranteed Movement to Registry : The total foreign guaranteed units subtracted from a CHESS holding
        /// or a Cum Entitlement balance during a business day as a result of
        /// an authorised registry transaction or a CHESS/registry movement.
        /// Authorised registry transactions that can cause a decrease are :
        /// * an authorisation for a registry/CHESS movement; and
        /// * a holding adjustment.
        /// Applicable only for securities subject to CHESS foreign ownership restrictions.
        /// 
        /// 514-01 Aggregated Foreign to Foreign Allocations
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string GuaranteedMovementtoRegistry { get; set; }

        /// <summary>
        /// Movement to Registry : The total units subtracted from a CHESS holding or a Cum
        /// Entitlement balance during a business day as a result of an
        /// authorised registry transaction or a CHESS/registry movement.
        /// Authorised registry transactions that can cause a decrease are :
        /// * a holding adjustment; and
        /// * a holding transformation.
        /// 
        /// 506-01 Cum Entitlement Net Movement
        /// 510-01 Holding Net Movement
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string MovementtoRegistry { get; set; }
        #endregion

        #region Bitmap Position 65

        #endregion

        #region Bitmap Position 66
        /// <summary>
        /// Default Accumulation HIN : Specifies the HIN that is used as the target of all 'Registry to CHESS' transfers submitted by a participant
        /// that do not explicitly target another HIN. The HIN must be controlled by the participant.
        /// 
        /// 226-01 User Detail
        /// 228-01 User History
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DefaultAccumulationHIN { get; set; }

        /// <summary>
        /// Revised Delivering HIN : Specifies the revised delivering HIN of a settlement instruction after it has been altered.
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RevisedDeliveringHIN { get; set; }
        #endregion

        #region Bitmap Position 67
        /// <summary>
        /// Amount : The dollar value of a transaction in CHESS.
        /// 
        /// 158-01 Participant Counterparty Balance
        /// 300-01 Participant Funds Notification
        /// 302-01 Payment Provider Funds Notification
        /// 310-02 Participant Funds Obligation
        /// 312-01 Payment Provider Funds Obligation
        /// 332-01 Payment Provider Transfer Request
        /// 350-01 Clearing Account Transfer Request
        /// 551-01 Aggregated Payment Request
        /// 614-01 Cash Subrecord Details
        /// </summary>
        public static decimal Amount { get; set; }

        /// <summary>
        /// Balance : The balance of each Cash Record held under the Net Position Record associated with the nominated Payment Facility. For RTGS.
        /// 
        /// 565-01 CCMS Reconciliation Balance
        /// 570-01 Pending Equity Settlement Balance
        /// 571-01 Collateral Source Account Movement Notification
        /// 616-01 Cash Subrecord Total
        /// </summary>
        public static decimal Balance { get; set; }

        /// <summary>
        /// Face Value : Date of expiry for some types of non-cash collateral (e.g. CGS has an expiry date).
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        public static decimal FaceValue { get; set; }

        /// <summary>
        /// Previous Stamping Consideration : Specifies the stamping consideration of a settlement instruction before it was altered.
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        public static decimal PreviousStampingConsideration { get; set; }

        /// <summary>
        /// Principal : The principal amount used in the calculation of an interest amount.
        /// 
        /// 911-01 Daily Interest Earned Notification
        /// 940-01 Daily Interest Earned Statement
        /// </summary>
        public static decimal Principal { get; set; }

        /// <summary>
        /// Stamping Consideration ; The consideration paid in respect of the securities transfer or the
        /// unencumbered market value of the securities whichever is higher.
        /// 
        /// Cross Reference
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //010-03 Applied Transferor Submitted Transfer
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //021-02 Certificated to CHESS Transfer Request
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //101-02 Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //121-02 Change Settlement Instruction Request
        //125-01 Maintain Settlement Instruction Request
        //142-02 Accrued Settlement Instruction
        //180-02 Full Settlement Instruction
        //431-01 Takeover Transfer
        //481-01 RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //493-01 Maintain RTGS Instruction Request
        //601-04 Collateral Release Request
        #endregion Cross Reference End
        /// </summary>
        public static decimal StampingConsideration { get; set; }

        /// <summary>
        /// Trade Amount : The dollar amount of a block trade.
        /// 
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        public static decimal TradeAmount { get; set; }
        #endregion

        #region Bitmap Position 68
        /// <summary>
        /// Duty Payable : The amount of duty payable for an off-market transfer as calculated by the liable participant.
        /// 
        /// Cross Reference
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //010-03 Applied Transferor Submitted Transfer
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //021-02 Certificated to CHESS Transfer Request
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //101-02 Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //121-02 Change Settlement Instruction Request
        //125-01 Maintain Settlement Instruction Request
        //142-02 Accrued Settlement Instruction
        //180-02 Full Settlement Instruction
        //431-01 Takeover Transfer
        //481-01 RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //493-01 Maintain RTGS Instruction Request
        //601-04 Collateral Release Request
        //651-01 ETC Trade Advice
        //652-01 ETC Trade
        //657-01 Contract Note Advice
        //663-01 ETC Settlement Advice
        //664-01 Contract Note
        //676-01 ETC Settlement
        #endregion Cross Reference End
        /// </summary>
        [StringLength(14, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DutyPayable { get; set; }

        /// <summary>
        /// Market Value : The current market value of the collateral.
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        [StringLength(14, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string MarketValue { get; set; }

        /// <summary>
        /// Revised Stamping Consideration : Specifies the revised stamping consideration of a settlement instruction after it has been altered.
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(14, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RevisedStampingConsideration { get; set; }
        #endregion

        #region Bitmap Position 69
        /// <summary>
        /// Duty Type : Identifies the duty category of an off-market transfer.
        /// 
        /// Allowable Values 'A' = Ad Valorem
        ///                  'C' = Concessional - NCBO
        ///                  'D' = Concessional - other
        ///                  'E' = Exempt - Entrepot Account Transfer
        ///                  'F' = Exempt - Charitable Body
        ///                  'G' = Exempt - Government Body
        ///                  'K' = Exempt - Duty Paid
        ///                  'L' = Exempt - Stock Loan
        ///                  'M' = Exempt - Stock Loan Return
        ///                  'N' = Exempt - NCBO
        ///                  'O' = Exempt - other
        ///                  'P' = Exempt - Passing Entitlement following the Parent Shares
        ///                  'R' = Reversal
        ///                  
        /// Cross Reference
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //010-03 Applied Transferor Submitted Transfer
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //021-02 Certificated to CHESS Transfer Request
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //101-02 Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //121-02 Change Settlement Instruction Request
        //125-01 Maintain Settlement Instruction Request
        //142-02 Accrued Settlement Instruction
        //180-02 Full Settlement Instruction
        //431-01 Takeover Transfer
        //481-01 RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //493-01 Maintain RTGS Instruction Request
        //601-04 Collateral Release Request
        //651-01 ETC Trade Advice
        //652-01 ETC Trade
        //663-01 ETC Settlement Advice
        //676-01 ETC Settlement
        #endregion Cross Reference End
        /// </summary>
        public static readonly char[] DutyType = new char[13] { 'A', 'C', 'D', 'E', 'F', 'G', 'K', 'L', 'M', 'N', 'O', 'P', 'R' };

        /// <summary>
        /// Previous Duty Type : Specifies the duty type of a settlement instruction before it was altered.
        /// 
        /// Allowable Values 'A' = Ad Valorem
        ///                  'C' = Concessional - NCBO
        ///                  'D' = Concessional - other
        ///                  'E' = Exempt - Entrepot Account Transfer
        ///                  'F' = Exempt - Charitable Body
        ///                  'G' = Exempt - Government Body
        ///                  'K' = Exempt - Duty Paid
        ///                  'L' = Exempt - Stock Loan
        ///                  'M' = Exempt - Stock Loan Return
        ///                  'N' = Exempt - NCBO
        ///                  'O' = Exempt - other
        ///                  'P' = Exempt - Passing Entitlement following the Parent Shares
        ///                  'R' = Reversal
        ///  
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        public static readonly char[] PreviousDutyType = new char[13] { 'A', 'C', 'D', 'E', 'F', 'G', 'K', 'L', 'M', 'N', 'O', 'P', 'R' };

        /// <summary>
        /// Remove Excess Cash Standing Instruction : To be used when the Participant wants to cancel their Excess Cash Standing Instruction.
        /// 
        /// 909-01 Excess Cash Standing Instruction Request
        /// 932-01 Excess Cash Standing Instruction Authorisation Request
        /// </summary>
        [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly char RemoveExcessCashStandingInstruction = 'Y';
        #endregion

        #region Bitmap Position 70
        /// <summary>
        /// Previous Underlying Reference : Specifies the underlying reference of a settlement instruction before it was altered.
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PreviousUnderlyingReference { get; set; }

        /// <summary>
        /// Underlying Reference : This field may be used to transmit additional details as required.
        /// 
        /// Cross Reference
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //010-03 Applied Transferor Submitted Transfer
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //021-02 Certificated to CHESS Transfer Request
        //025-01 Single Entry Transfer Request
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //101-02 Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //121-02 Change Settlement Instruction Request
        //125-01 Maintain Settlement Instruction Request
        //142-02 Accrued Settlement Instruction
        //180-02 Full Settlement Instruction
        //431-01 Takeover Transfer
        //481-01 RTGS Dual Entry Notification
        //489-01 Change RTGS Instruction Request
        //493-01 Maintain RTGS Instruction Request
        //601-04 Collateral Release Request
        //718-02Issuer Sponsored Fund to CHESS Conversion Request
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        //874-01 Effected Margin Cover Release and Transfer
        //885-01 ASXCL Margin Cover Removal Request
        #endregion Cross Reference End
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string UnderlyingReference { get; set; }
        #endregion

        #region Bitmap Position 71
        /// <summary>
        /// Entrepot Type : Defines a type of entrepot holding.
        /// 
        /// Allowable Values 'A' = Accumulation
        ///                  ‘P’ = Payment
        ///                  'S' = Settlement
        ///                  
        /// 201-04 New Registration Details
        /// 220-02 Authorised Registration Details
        /// 222-04 Holder Detail
        /// 224-03 Holder History
        /// </summary>
        public static readonly char[] EntrepotType = new char[3] { 'A', 'P', 'S' };
        #endregion

        #region Bitmap Position 72
        /// <summary>
        /// Reporting Request Status : Identifies the current status of a reporting request submitted by a user.
        /// 
        /// Allowable Values 'A' = Current
        ///                  'B' = Cancelled
        ///                  'C' = Completed
        ///                  
        /// 234-03 Reporting Request Detail
        /// </summary>
        public static readonly char[] ReportingRequestStatus = new char[3] { 'A', 'B', 'C' };
        #endregion

        #region Bitmap Position 73
        /// <summary> 
        /// Cash Payment / Withdrawal : The cash flow resulting from the payment or withdrawal made in the previous settlement.
        /// 
        /// 917-01 Margin Settlement Notification
        /// 942-01 Margin Settlement Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string CashPaymentWithdrawal { get; set; }

        /// <summary>
        /// Outstanding Loan Consideration : The dollar amount that is the current collateral for an active SLS loan.
        /// 
        /// 286-01 Full Loan Instruction
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string OutstandingLoanConsideration { get; set; }

        /// <summary>
        /// Trust Amount : To schedule a transfer of units from the participant Accumulation
        /// Account to the participants Settlement Account or from the
        /// participants Settlement Account to a Sponsored or Direct HIN under
        /// their control, the message needs to identify the ‘trust’ component.
        /// 
        /// 107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        /// 186-01 Net Trust Amount Movement
        /// 310-02 Participant Funds Obligation
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TrustAmount { get; set; }
        #endregion

        #region Bitmap Position 74
        /// <summary>
        /// Loan Transaction Id : The identifier of an SLS loan. The Transaction Id of the message
        /// that initially requests the SLS loan is used as the Loan Transaction Id.
        /// 
        /// 274-01 Adjusted Loan
        /// 275-01 Loan Return Notification
        /// 276-02 Accrued Loan
        /// 278-01 Scheduled Loan Instruction
        /// 286-01 Full Loan Instruction
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string LoanTransactionId { get; set; }
        #endregion

        #region Bitmap Position 75
        /// <summary>
        /// Suspension Reason : The reason a settlement instruction has been suspended from the settlement process.
        /// 
        /// Allowable Values ‘A’ = Subregister closed
        /// 
        /// 162-01 Suspended Settlement Instruction
        /// </summary>
        public static readonly char[] SuspensionReason = new char[1] { 'A' };
        #endregion

        #region Bitmap Position 76
        /// <summary>
        /// Payment Facility Change Reason : The reason that a payment facility has changed.
        /// 
        /// Allowable Values ‘A’ = Associate HIN
        ///                  ‘B’ = Disassociate HIN
        ///                  ‘C’ = Default Payment Facility
        ///                  ‘D’ = Change Payment Provider
        ///                  ‘E’ = Cancel Payment Facility
        ///                  ‘M’ = Move Payment Facility
        ///                  ‘R’ = Reactivate Payment Facility
        ///                  ‘S’ = Suspend Payment Facility
        ///                  
        /// 232-01 Payment Facility History
        /// 242-01 Applied Payment Facility Update
        /// </summary>
        public static readonly char[] PaymentFacilityChangeReason = new char[8] { 'A', 'B', 'C', 'D', 'E', 'M', 'R', 'S' };
        #endregion

        #region Bitmap Position 77
        /// <summary>
        /// Participant Type : Defines the type of participant. Determines the services that are available to the participant.
        /// 
        /// Allowable Values 'B' = Broker
        ///                  'N' = Non-broker
        ///                  
        /// 226-01 User Detail
        /// 228-01 User History
        /// </summary>
        public static readonly char[] ParticipantType = new char[2] { 'B', 'N' };
        #endregion

        #region Bitmap Position 78
        /// <summary>
        /// Currency : The collateral currency of denomination.
        /// 
        /// Allowable Values “AUD” – Australian Dollars
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Currency { get; set; } = "AUD";

        /// <summary>
        /// Payment Type : Identifies the type of payment free of delivery
        /// 
        /// Allowable Values ‘DER’ = Derivatives Settlement Payment
        /// 
        /// 550-01 Scheduled Payment Instruction
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PaymentType { get; set; } = "DER";

        /// <summary>
        /// Reporting Id : The unique identifier with which to select a report.
        /// 
        /// Allowable Values
        #region Allowable Values
        //'CEB' = Cum entitlement balance
        //'CFB' = Counterparty Funds Balance
        //'CMV' = Cum Entitlement Movement
        //'CSI' = Cancelled Instruction
        //‘DSM’ = Demand CHESS Holding Statement
        //‘FGM’ = Foreign Guaranteed Net Movement
        //'FHT' = Full Holding Transaction
        //'FLN' = Full SLS Loan
        //'FSI' = Full Settlement Instruction
        //'HBL' = Holding balance
        //'HCT' = Holding control
        //'HLD' = Holder Detail
        //'HLH' = Holder History
        //'HMV' = Holding Movement
        //'HRD' = Holding Registration Details
        //'HSB' = Holding Subposition Balance
        //'HSP' = Holding subposition detail
        //'HTX' = Holding transaction
        //'OBL' = Obligation
        //'OSL' = Outstanding SLS Loan
        //'PFD' = Payment Facility Detail
        //'PFH' = Payment Facility History
        //'PPS' = Projected Position
        //'RAC' = Rights Accepted
        //'RPD' = Reporting Detail
        //'SCE' = Subregister Closure Exceptions
        //‘SDR’ = Security Detail Report
        //'SET' = Settlement
        //'SMP' = Subregister Movement - Participant
        //'SMR' = Subregister Movement - Registry
        //'TCB' = Total Cum Entitlement Balance
        //'TPB' = Third Party Subposition Balance
        //'TPD' = Third Party Subposition Detail
        //'TSB' = Total Security Balance
        //‘TSH’ = Top Security Holder
        //'URT' = Unauthorised Registry Transactions
        //'USD' = User Detail
        //'USH' = User History
        //'USI' = Unmatched Instruction
        #endregion Allowable Values End
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] ReportingId = new string[39]
        {
            "CEB" , "CFB" , "CMV" , "CSI" , "DSM" , "FGM" , "FHT" , "FLN" , "FSI" , "HBL" , "HCT" , "HLD" , "HLH" ,
            "HMV" , "HRD" , "HSB" , "HSP" , "HTX" , "OBL" , "OSL" , "PFD" , "PFH" , "PPS" , "RAC" , "RPD" , "SCE" ,
            "SDR" , "SET" , "SMP" , "SMR" , "TCB" , "TPB" , "TPD" , "TSB" , "TSH" , "URT" , "USD" , "USH" , "USI"
        };

        /// <summary>
        /// Tax Residence 2 : The country in which the Fund investor is a resident for tax purposes.
        /// 
        /// Allowable Values : 3 Character ISIN Country Codes.
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TaxResidence2 { get; set; }
        #endregion

        #region Bitmap Position 79
        /// <summary>
        /// Message Type : Identifies the type of message being transmitted (Acceptance or Cancellation)
        /// 
        /// Allowable Values ‘TA’ = Trade Acceptance Registration
        ///                  ‘TG’ = Trade Cancellation Registration
        ///                  
        /// 161-02 Trade Registration Request
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] MessageType = new string[2] { "TA", "TG" };

        /// <summary>
        /// Processing Frequency : Determines how often a scheduled reporting request must be actioned.
        /// 
        /// Allowable Values 'DL' = Daily
        ///                  'WK = Weekly
        ///                  'FO' = Fortnightly
        ///                  'ML' = Monthly
        ///                  ‘YR’ = Yearly
        ///                  'OO' = One-off
        ///                  
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] ProcessingFrequency = new string[6] { "DL", "WK", "FO", "ML", "YR", "OO" };
        #endregion

        #region Bitmap Position 80
        /// <summary>
        /// Ex Date : The date from which the holder of a security retains their rights to benefits associated with owning the security.
        /// 
        /// 148-01 Projected Cum Entitlement Position
        /// 188-02 Full Adjusted Settlement Instruction
        /// 504-01 Cum Entitlement Daily Balance
        /// 506-01 Cum Entitlement Net Movement
        /// 520-02 Cum Entitlement Balance
        /// 524-01 Total Cum Entitlement Balance
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ExDate { get; set; }

        /// <summary>
        /// Ex Date Parameter : Restricts the scope of a reporting request to a specific corporate action.
        /// Used in conjunction with Corporate Action Type Id Parameter.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ExDateParameter { get; set; }
        #endregion

        #region Bitmap Position 81
        /// <summary>
        /// Diary Adjustment Type : Indicate the type of corporate action.
        /// 
        /// Allowable Values ‘A’ = Code Change
        ///                  ‘B’ = Bonus
        ///                  ‘C’ = Consolidation
        ///                  ‘D’ = Dividend
        ///                  ‘E’ = Non-Renounceable
        ///                  ‘I’ = Interest Payment
        ///                  ‘L’ = Call
        ///                  ‘M’ = Application Money - General
        ///                  ‘R’ = Renounceable
        ///                  ‘S’ = Share Split
        ///                  ‘T’ = Capital Return
        ///                  
        /// 128-02 Adjusted Settlement Instruction
        /// 142-02 Accrued Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// 274-01 Adjusted Loan
        /// 276-02 Accrued Loan
        /// </summary>
        public static readonly char[] DiaryAdjustmentType = new char[11] { 'A', 'B', 'C', 'D', 'E', 'I', 'L', 'M', 'R', 'S', 'T' };

        /// <summary>
        /// Subregister Status : The current status of the sub-register in CHESS for a security code.
        /// 
        /// Allowable Values ‘B’ = Barred
        ///                  ‘C’ = Closed
        ///                  ‘O’ = Open
        ///                  ‘S’ = Suspended
        ///                  
        /// 096-01 Security Detail
        /// 561-01 CCMS CHESS Security Message
        /// </summary>
        public static readonly char[] SubregisterStatus = new char[4] { 'B', 'C', 'O', 'S' };
        #endregion

        #region Bitmap Position 82
        /// <summary>
        /// Number Of Days Parameter : Restricts the data to be included in the reporting to a number of days
        /// in the past or the future according to the reporting type.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string NumberOfDaysParameter { get; set; }
        #endregion

        #region Bitmap Position 83
        /// <summary>
        /// ESA Status : Identifies the liquidity approval setting selected by the payment provider for all buy transactions on a given
        /// Cash Subrecord which are to be sent to the RBA (i.e. RITS) for RTGS settlement.
        /// 
        /// Allowable Values ‘A’ = Active
        ///                  ‘D’ = Deferred
        ///                  
        /// 353-01 Create Cash Subrecord Authorisation
        /// 373-01 Payment Provider Change Cash Subrecord Attributes Request
        /// </summary>
        public static readonly char[] ESAStatus = new char[2] { 'A', 'D' };

        /// <summary>
        /// Position Type Parameter : Restricts the scope of reporting to a specific type of projected position.
        /// 
        /// Allowable Values 'C' = Cum Entitlements
        ///                  'F' = Funds
        ///                  'S' = Securities
        ///                  
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        public static readonly char[] PositionTypeParameter = new char[3] { 'C', 'F', 'S' };
        #endregion

        #region Bitmap Position 84
        /// <summary>
        /// Processing Point : The day of the week or day of the month, or month of the year, on which a scheduled reporting request should be actioned.
        /// 
        /// Allowable Values 'MO' = Monday
        ///                  'TU' = Tuesday
        ///                  'WE' = Wednesday
        ///                  'TH' = Thursday
        ///                  'FR' = Friday
        ///                  '01' thru '31'
        ///                  
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        public static readonly string[] ProcessingPoint = new string[] { "MO", "TU", "WE", "TH", "FR" };
        #endregion

        #region Bitmap Position 85
        /// <summary>
        /// Credit Status : Identifies the client credit approval setting selected by the payment provider for all buy transactions
        /// on a given Cash Subrecord which are to be sent to the RBA (i.e. RITS) for RTGS settlement.
        /// 
        /// Allowable Values ‘A’ = Active
        ///                  ‘D’ = Deferred
        ///                  
        /// 353-01 Create Cash Subrecord Authorisation
        /// 373-01 Payment Provider Change Cash Subrecord Attributes Request
        /// </summary>
        public static readonly char[] CreditStatus = new char[2] { 'A', 'D' };

        /// <summary>
        /// Notification Type : Indicates the purpose of the notification.
        /// (e.g. Whether the message relates to an end of day or intraday transaction).
        /// 
        /// Allowable Values “I” - Intraday
        ///                  “E” - End of Day
        ///                  “U” – Update to End of Day
        ///                  “R” – Reporting
        ///                  
        /// (Note: Allowable values “I” and “R” are not currently supported in this phase of Cash Market
        /// Margining. The addition of this functionality may be added at a later stage).
        /// 
        /// 911-01 Daily Interest Earned Notification
        /// 917-01 Margin Settlement Notification
        /// 927-01 Collateral Statement Notification
        /// 929-01 End Statement Notification
        /// 940-01 Daily Interest Earned Statement
        /// 942-01 Margin Settlement Advice
        /// 952-01 Collateral Statement
        /// </summary>
        public static readonly char[] NotificationType = new char[4] { 'I', 'E', 'U', 'R' };

        /// <summary>
        /// Processing Period : Identifies the CHESS processing period after which a reporting request must be actioned.
        /// 
        /// Allowable Values ‘C’ = Period following processing of CHESS RTGS End-of-Day Recalls
        ///                  'E' = End of day
        ///                  Blank = Immediate
        ///                  
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        public static readonly char[] ProcessingPeriod = new char[2] { 'C', 'E' };
        #endregion

        #region Bitmap Position 86
        /// <summary>
        /// Diary Adjustment Number : The identifier of the diary adjustment within a corporate action which 
        /// caused a settlement instruction to be adjusted.
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// 274-01 Adjusted Loan
        /// </summary>
        [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DiaryAdjustmentNumber { get; set; }
        #endregion

        #region Bitmap Position 87
        /// <summary>
        /// Allocation Cancellation Timestamp : Records the business date, processing date and processing time on
        /// which the sending UIC completes the processing of an allocation cancellation.
        ///                
        /// 661-01 Allocation Cancellation Advice
        /// 672-01 Allocation Cancellation
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AllocationCancellationTimestamp { get; set; }

        /// <summary>
        /// Allocation Timestamp : Records the business date, processing date and processing time 
        /// on which the sending UIC completes the processing of an allocation.
        /// 
        /// 653-02 ETC Trade Allocation Advice
        /// 656-02 ETC Trade Allocation
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AllocationTimestamp { get; set; }

        /// <summary>
        /// Approved Timestamp : The time that an SLS loan is recorded as approved in the CHESS database.
        /// 
        /// 286-01 Full Loan Instruction
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ApprovedTimestamp { get; set; }

        /// <summary>
        /// Contract Note Timestamp : Records the business date, processing date and processing time on which the sending UIC 
        /// completes the processing of a contract note advice.
        ///                 
        /// 657-01 Contract Note Advice
        /// 664-01 Contract Note
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ContractNoteTimestamp { get; set; }

        /// <summary>
        /// DvP Declaration Timestamp : The time that the CHESS Clearing payment provider declares that the interbank payments occur.
        /// 
        /// 361-01 Zero Sum Notification
        /// 362-01 CHESS DvP Notification
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DvPDeclarationTimestamp { get; set; }

        /// <summary>
        /// Holding Balance Timestamp : The time at which the registry interrogated its records to retrieve the issuer sponsored holding balance.
        /// 
        /// 459-01 Registry to CHESS Holding Balance Response
        /// 470-01 CHESS to Participant Holding Balance Response
        /// 839-01 Registry to CHESS Fund Balance Response
        /// 840-01 CHESS to Participant Fund Balance Response
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string HoldingBalanceTimestamp { get; set; }

        /// <summary>
        /// Initial Timestamp : The time at which a transaction which requires an action by another
        /// party before it can be processed to completion is first recorded in the
        /// CHESS database.
        /// 
        /// 052-03 Full Dual Entry CHESS to CHESS Transfer
        /// 056-03 Full Certificated to CHESS Transfer
        /// 058-03 Full Certificated to CHESS Conversion
        /// 060-03 Full Issuer Sponsored to CHESS Transfer
        /// 062-03 Full Issuer Sponsored to CHESS Conversion
        /// 180-02 Full Settlement Instruction
        /// 834-01 Full Issuer Sponsored Fund to CHESS Conversion
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string InitialTimestamp { get; set; }

        /// <summary>
        /// Rejection Timestamp : Records the business date, processing date and processing time on
        /// which the sending UIC completes the processing of a rejection.
        /// 
        /// 655-01 ETC Trade Rejection Advice
        /// 659-01 Contract Note Rejection Advice
        /// 660-01 ETC Trade Rejection
        /// 668-01 Contract Note Rejection
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RejectionTimestamp { get; set; }

        /// <summary>
        /// Settlement Advice Timestamp : Records the business date, processing date and processing time on
        /// which the sending UIC completes the processing of a settlement advice.
        /// 
        /// 663-01 ETC Settlement Advice
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SettlementAdviceTimestamp { get; set; }

        /// <summary>
        /// Trade Timestamp : Records the business date, processing date and processing time on
        /// which the Sending UIC completes the processing of a [block] trade.
        /// 
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TradeTimestamp { get; set; }
        #endregion

        #region Bitmap Position 88
        /// <summary>
        /// Effected Timestamp : The time that a holding transaction is applied to a CHESS holding and is recorded in the CHESS database.
        /// 
        /// Cross Reference
        #region Cross Reference
        //018-02 Effected Holding Transformation
        //022-03 Effected Holding Adjustment
        //034-04 Effected Takeover Transfer
        //042-05 Collateral Release
        //050-02 Effected Security Code Change
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //146-03 Effected Net Settlement Movement
        //286-01 Full Loan Instruction
        //733-02Effected Fund Unit Adjustment
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        //874-01 Effected Margin Cover Release and Transfer
        #endregion Cross Reference End
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string EffectedTimestamp { get; set; }

        /// <summary>
        /// Response Timestamp : The time that the response of ASX Clear to authorise or reject a
        /// change to a transaction is recorded in the CHESS database.
        /// 
        /// 224-03 Holder History
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ResponseTimestamp { get; set; }

        /// <summary>
        /// Timestamp : Records the business date, processing date and processing time
        /// that a transaction is applied to the CHESS database.
        /// 
        /// Allowable Values A valid timestamp in the format:
        ///                  YYYYMMDDYYYYMMDDHHMMSS
        ///                  Where the first YYYYMMDD is the business date; and the next
        ///                  YYYYMMDDHHMMSS is the processing date and time.
        ///                  
        /// 188-02 Full Adjusted Settlement Instruction
        /// 224-03 Holder History
        /// 228-01 User History
        /// 232-01 Payment Facility History
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Timestamp { get; set; }
        #endregion

        #region Bitmap Position 89
        /// <summary>
        /// Blocking Transaction Id : The identifier of the transaction which blocks a Trade from the netting process.
        /// 
        /// 196-01 Blocked Trade
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string BlockingTransactionId { get; set; }

        /// <summary>
        /// Cancelling Transaction Id : The identifier of the transaction which cancels another transaction which has not been processed to completion.
        /// 
        /// 048-01 Cancelled Demand Dual Entry Transfer Request
        /// 052-03 Full Dual Entry CHESS to CHESS Transfer
        /// 116-01 Cancelled Settlement Instruction
        /// 118-01 Cancelled Change Settlement Instruction Request
        /// 132-01 Removed Dual Entry Settlement Instruction Cancellation Request
        /// 140-01 Cancelled Net Obligation
        /// 178-01 Unmatched Dual Entry Settlement Instruction Cancellation Request
        /// 180-02 Full Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// 250-01 Cancelled Change Controlling Participant Request
        /// 284-01 Cancelled Loan Instruction
        /// 286-01 Full Loan Instruction
        /// 442-01 Cancelled Change RTGS Instruction Request
        /// 450-01 Cancelled Request to Change Settlement Type
        /// 490-01 Unmatched RTGS Instruction Cancellation Request
        /// 492-01 Removed RTGS Instruction Cancellation Request
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string CancellingTransactionId { get; set; }
        #endregion

        #region Bitmap Position 90
        /// <summary>
        /// Matching Transaction Id : The identifier of the transaction which matches another transaction and allows it to be processed to completion.
        /// 
        /// 006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
        /// 024-01 Rejected Demand Dual Entry CHESS to CHESS Transfer
        /// 052-03 Full Dual Entry CHESS to CHESS Transfer
        /// 116-01 Cancelled Settlement Instruction
        /// 128-02 Adjusted Settlement Instruction
        /// 166-01 Scheduled Dual Entry Settlement Instruction
        /// 180-02 Full Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// 448-01 Adjusted Settlement Type
        /// 450-01 Cancelled Request to Change Settlement Type
        /// 
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string MatchingTransactionId { get; set; }

        /// <summary>
        /// Unblocking Transaction Id : The identifier of the transaction which removes the block on a trade from the netting process.
        /// 
        /// 198-01 Unblocked Trade
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string UnblockingTransactionId { get; set; }
        #endregion

        #region Bitmap Position 91
        /// <summary>
        /// Matched Timestamp : The time at which the matching of two sides of a transaction is recorded in the CHESS database.
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string MatchedTimestamp { get; set; }

        /// <summary>
        /// Settled Timestamp : The time at which a settlement instruction is settled and recorded in the CHESS database.
        /// 
        /// 156-01 Settled Settlement Instruction
        /// 180-02 Full Settlement Instruction
        /// 192-01 Part-Settled Settlement Instruction
        /// 614-01 Cash Subrecord Details
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SettledTimestamp { get; set; }
        #endregion

        #region Bitmap Position 92
        /// <summary>
        /// Advisor Mobile : The mobile phone number for an Advisor. Include mobile country code prefix where appropriate.
        /// 
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AdvisorMobile { get; set; }

        /// <summary>
        /// Receiving Net Movement Transaction Id : The identifier of the transaction which transferred securities from a
        /// holding in the settlement process.
        /// 
        /// 156-01 Settled Settlement Instruction
        /// 180-02 Full Settlement Instruction
        /// 192-01 Part-Settled Settlement Instruction
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ReceivingNetMovementTransactionId { get; set; }

        /// <summary>
        /// Approved Transaction Id : The identifier of the transaction that approves a requested SLS loan.
        /// 
        /// 286-01 Full Loan Instruction
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ApprovedTransactionId { get; set; }

        /// <summary>
        /// Updating Transaction Id : The identifier of the transaction which updates another transaction that has not been processed to completion.
        /// 
        /// Cross Reference
        #region Cross Reference
        //122-01 Unmatched Change Settlement Instruction Request
        //124-01 Rescheduled Settlement Instruction
        //126-01 Updated Settlement Instruction
        //128-02 Adjusted Settlement Instruction
        //130-02 Requested Settlement Instruction Change
        //142-02 Accrued Settlement Instruction
        //162-01 Suspended Settlement Instruction
        //188-02 Full Adjusted Settlement Instruction
        //274-01 Adjusted Loan
        //276-02 Accrued Loan
        //446-01 Updated RTGS Instruction
        //448-01 Adjusted Settlement Type
        //478-01 Unmatched Change RTGS Instruction Request
        //480-01 Requested RTGS Instruction Change
        #endregion Cross Reference End
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string UpdatingTransactionId { get; set; }
        #endregion

        #region Bitmap Position 93
        /// <summary>
        /// Scheduled Timestamp : The time at which the scheduling of a settlement instruction is recorded in the CHESS database.
        /// 
        /// 180-02 Full Settlement Instruction
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ScheduledTimestamp { get; set; }
        #endregion

        #region Bitmap Position 94
        /// <summary>
        /// As At Date : Specifies the date on which a trade was transacted.
        /// 
        /// Cross Reference
        #region Cross Reference
        //161-02 Trade Registration Request
        //164-03 Notified Trade
        //651-01 ETC Trade Advice
        //652-01 ETC Trade
        //657-01 Contract Note Advice
        //664-01 Contract Note
        //957-02Registry Income Statement Part A
        //959-01 Registry Income Statement Part B
        //961-01 Registry Income Statement Part C AI
        //962-02Participant Income Statement Part A
        //963-01 Registry Income Statement Part C CG
        //964-01 Participant Income Statement Part B
        //965-01 Registry Income Statement Part C FI
        //966-01 Participant Income Statement Part C AI
        //967-02Registry Income Statement Part C NA
        //968-01 Participant Income Statement Part C CG
        //969-01 Registry Income Statement Part C OD
        //970-01 Participant Income Statement Part C FI
        //972-02Participant Income Statement Part C NA
        //974-01 Participant Income Statement Part C OD
        #endregion Cross Reference End
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AsAtDate { get; set; }

        /// <summary>
        /// Date of Birth 1 : Specifies the birth date of the requesting Fund investor.
        /// 
        /// Allowable Values A valid date in the format YYYYMMDD, eg. 19930625
        /// 
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DateofBirth1 { get; set; }

        /// <summary>
        /// Start Date Parameter : Restricts reporting to transactions processed to the required status
        /// on or after this date, eg. if the reporting relates to settled settlement
        /// instructions, all settlement instructions which have been settled on or
        /// after the specified date are included in the reporting.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string StartDateParameter { get; set; }
        #endregion

        #region Bitmap Position 95
        /// <summary>
        /// Date of Birth 2 : Specifies the birth date of the requesting Fund investor.
        /// 
        /// Allowable Values A valid date in the format YYYYMMDD, eg. 19930625
        /// 
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DateofBirth2 { get; set; }

        /// <summary>
        /// End Date Parameter : Restricts reporting to transactions processed to the required status on or before this date,
        /// eg. if the reporting relates to settled settlement Instructions, all settlement instructions which have been
        /// settled on or before the specified date are included.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string EndDateParameter { get; set; }
        #endregion

        #region Bitmap Position 96
        /// <summary>
        /// Name : Full title of a CHESS user that interfaces to the ASX Clear.
        /// 
        /// 226-01 User Detail
        /// 228-01 User History
        /// 350-01 Clearing Account Transfer Request
        /// </summary>
        [StringLength(90, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Name { get; set; }

        /// <summary>
        /// Participant Name : Full title of a CHESS participant that interfaces to ASX Clear.
        /// 
        /// 300-01 Participant Funds Notification
        /// 310-02 Participant Funds Obligation
        /// </summary>
        [StringLength(90, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ParticipantName { get; set; }
        #endregion

        #region Bitmap Position 97
        /// <summary>
        /// Address : Destination of all communication with a CHESS user when using non-electronic means.
        /// 
        /// 226-01 User Detail
        /// 228-01 User History
        /// </summary>
        [StringLength(90, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Address { get; set; }
        #endregion

        #region Bitmap Position 98
        /// <summary>
        /// As At Date Parameter : Specifies the date to which snapshot reporting relates, 
        /// e.g. Holding Balance Reporting can be for a specified date in the past.
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AsAtDateParameter { get; set; }

        /// <summary>
        /// Date of Birth 3 : Specifies the birth date of the requesting Fund investor.
        /// 
        /// Allowable Values A valid date in the format YYYYMMDD, eg. 19930625
        /// 
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DateofBirth3 { get; set; }

        /// <summary>
        /// Expiry Date : Date of expiry for some types of non-cash collateral (e.g. CGS has an expiry date).
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ExpiryDate { get; set; }
        #endregion

        #region Bitmap Position 99
        /// <summary>
        /// Collateral Type : The type of collateral that is being lodged by the Clearing Participant.
        /// 
        /// Allowable Values “ACC” – ASX Collateral
        ///                  “BKG” – Bank Guarantee
        ///                  “CGS” – Commonwealth Government Security
        ///                  “CSH” – Cash
        ///                  “EQY” – Equity Collateral
        ///                  
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] CollateralType = new string[5] { "ACC", "BKG", "CGS", "CSH", "EQY" };

        /// <summary>
        /// Reporting Id Parameter : Restricts the scope of reporting to a specific type of reporting (used
        /// only for reporting on current reporting requests).
        /// 
        /// Allowable Values
        #region Allowable Values
        //'CEB' = Cum entitlement balance
        //'CFB' = Counterparty Funds Balance
        //'CMV' = Cum Entitlement Movement
        //'CSI' = Cancelled Instruction
        //‘DSM’ = Demand CHESS Holding Statement
        //‘FGM’ = Foreign Guaranteed Net Movement
        //'FHT' = Full Holding Transaction
        //'FLN' = Full SLS Loan
        //'FSI' = Full Settlement Instruction
        //'HBL' = Holding balance
        //'HCT' = Holding control
        //'HLD' = Holder Detail
        //'HLH' = Holder History
        //'HMV' = Holding Movement
        //'HRD' = Holding Registration Details
        //'HSB' = Holding Subposition Balance
        //'HSP' = Holding subposition detail
        //'HTX' = Holding transaction
        //'OBL' = Obligation
        //'OSL' = Outstanding SLS Loan
        //'PFD' = Payment Facility Detail
        //'PFH' = Payment Facility History
        //'PPS' = Projected Position
        //'RAC' = Rights Accepted
        //'RPD' = Reporting Detail
        //'SCE' = Subregister Closure Exceptions
        //‘SDR’ = Security Detail Report
        //'SET' = Settlement
        //'SMP' = Subregister Movement - Participant
        //'SMR' = Subregister Movement - Registry
        //'TCB' = Total Cum Entitlement Balance
        //'TPB' = Third Party Subposition Balance
        //'TPD' = Third Party Subposition Detail
        //'TSB' = Total Security Balance
        //‘TSH’ = Top Security Holder
        //'URT' = Unauthorised Registry Transactions
        //'USD' = User Detail
        //'USH' = User History
        //'USI' = Unmatched Instruction
        #endregion Allowable Values End
        /// 
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] ReportingIdParameter = new string[39]
        {
            "CEB" , "CFB" , "CMV" , "CSI" , "DSM" , "FGM" , "FHT" , "FLN" , "FSI" , "HBL" , "HCT" , "HLD" , "HLH" ,
            "HMV" , "HRD" , "HSB" , "HSP" , "HTX" , "OBL" , "OSL" , "PFD" , "PFH" , "PPS" , "RAC" , "RPD" , "SCE" ,
            "SDR" , "SET" , "SMP" , "SMR" , "TCB" , "TPB" , "TPD" , "TSB" , "TSH" , "URT" , "USD" , "USH" , "USI"
        };

        /// <summary>
        /// Tax Residence 3 : The country in which the Fund investor is a resident for tax purposes.
        /// 
        /// Allowable Values : 3 Character ISIN Country Codes.
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TaxResidence3 { get; set; }
        #endregion

        #region Bitmap Position 100
        /// <summary>
        /// Tax File Number / ABN 1 : The Australian Business Number, Tax File Number or exemption code of an individual holder or the first joint holder.
        /// The Australian Business Number, Tax File Number/Exemption Code should be left-justified (with trailing spaces if necessary) and no
        /// delimiter characters should be included. The Investor Type should be the 12th character if included.
        /// 
        /// 007-03 Demand CHESS to Issuer Sponsored Transfer Request
        /// 009-03 Demand CHESS to Certificated Transfer Request
        /// 054-04 Full CHESS to Certificated Transfer
        /// 068-04 Full CHESS to Issuer Sponsored Transfer
        /// 414-04 CHESS to Certificated Transfer
        /// 418-04 CHESS to Issuer Sponsored Transfer
        /// 533-02 Tax File Number / Australian Business Number Advice
        /// 534-02 Notified Tax File Number / Australian Business Number
        /// 715-01 CHESS to Issuer Sponsored Fund Conversion Request
        /// 716-01 CHESS Conversion Request to Issuer Sponsored Fund
        /// 835-01 Full CHESS to Issuer Sponsored Fund Conversion
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TFN_ABN_1 { get; set; }
        #endregion

        #region Bitmap Position 101
        /// <summary>
        /// Tax File Number / ABN 2 : The Australian Business Number, Tax File Number or exemption code of the second joint holder.
        /// 
        /// 007-03 Demand CHESS to Issuer Sponsored Transfer Request
        /// 009-03 Demand CHESS to Certificated Transfer Request
        /// 054-04 Full CHESS to Certificated Transfer
        /// 068-04 Full CHESS to Issuer Sponsored Transfer
        /// 414-04 CHESS to Certificated Transfer
        /// 418-04 CHESS to Issuer Sponsored Transfer
        /// 533-02 Tax File Number / Australian Business Number Advice
        /// 534-02 Notified Tax File Number / Australian Business Number
        /// 715-01 CHESS to Issuer Sponsored Fund Conversion Request
        /// 716-01 CHESS Conversion Request to Issuer Sponsored Fund
        /// 835-01 Full CHESS to Issuer Sponsored Fund Conversion
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TFN_ABN_2 { get; set; }
        #endregion

        #region Bitmap Position 102
        /// <summary>
        /// Tax File Number / ABN 3 : The Australian Business Number, Tax File Number or exemption code of the third joint holder.
        /// 
        /// 007-03 Demand CHESS to Issuer Sponsored Transfer Request
        /// 009-03 Demand CHESS to Certificated Transfer Request
        /// 054-04 Full CHESS to Certificated Transfer
        /// 068-04 Full CHESS to Issuer Sponsored Transfer
        /// 414-04 CHESS to Certificated Transfer
        /// 418-04 CHESS to Issuer Sponsored Transfer
        /// 533-02 Tax File Number / Australian Business Number Advice
        /// 534-02 Notified Tax File Number / Australian Business Number
        /// 715-01 CHESS to Issuer Sponsored Fund Conversion Request
        /// 716-01 CHESS Conversion Request to Issuer Sponsored Fund
        /// 835-01 Full CHESS to Issuer Sponsored Fund Conversion
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TFN_ABN_3 { get; set; }
        #endregion

        #region Bitmap Position 103
        /// <summary>
        /// Security Code Preference : Determines the type of security which is used in messages sent to a user.
        /// 
        /// Allowable Values 'A' = ASX Code
        ///                  'I' = ISIN Code.
        ///                  
        /// 226-01 User Detail
        /// 228-01 User History
        /// </summary>
        public static readonly char[] SecurityCodePreference = new char[2] { 'A', 'I' };
        #endregion

        #region Bitmap Position 104
        /// <summary>
        /// User Status : The current status of a CHESS user.
        /// 
        /// Allowable Values 'A' = Active
        ///                  'B' = Non-active
        ///                  'C' = Cancelled
        ///                  'S' = Suspended
        ///                  
        /// 226-01 User Detail
        /// 228-01 User History
        /// </summary>
        public static readonly char[] UserStatus = new char[4] { 'A', 'B', 'C', 'S' };

        /// <summary>
        /// Controlling PID Status : The current status of a CHESS PID.
        /// 
        /// Allowable Values 'A' = Active
        ///                  'B' = Non-active
        ///                  'C' = Cancelled
        ///                  'S' = Suspended
        ///                  
        /// 692-01 Controlling PID and Holder Status Response
        /// </summary>
        public static readonly char[] ControllingPIDStatus = new char[4] { 'A', 'B', 'C', 'S' };
        #endregion

        #region Bitmap Position 105
        /// <summary>
        /// User Type : Defines the service and functions available to a user.
        /// 
        /// Allowable Values 'B' = Payment Provider
        ///                  'C' = ASX Clear
        ///                  ‘H’ = CHESS Clearing Bank
        ///                  'I' = Issuer registry
        ///                  'O' = Derivatives
        ///                  'P' = Participant
        ///                  'S' = SLS Provider
        ///                  
        /// 226-01 User Detail
        /// 228-01 User History
        /// </summary>
        public static readonly char[] UserType = new char[7] { 'B', 'C', 'H', 'I', 'O', 'P', 'S' };
        #endregion

        #region Bitmap Position 106
        /// <summary>
        /// Price Run Time : Indicates the time for which the price data is applicable.
        /// 
        /// Allowable Values A valid time in the format of HHMMSS
        /// 
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PriceRunTime { get; set; }
        #endregion

        #region Bitmap Position 107
        /// <summary>
        /// Adjustment History Status : The current status of an adjustment to a settlement instruction.
        /// 
        /// Allowable Values 'A' = Applied
        ///                  'U' = Unmatched
        ///                  
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        public static readonly char[] AdjustmentHistoryStatus = new char[2] { 'A', 'U' };
        #endregion

        #region Bitmap Position 108
        /// <summary>
        /// Accrual Number : Identifies the accrual number appended to the transaction id of the parent transaction 
        /// to uniquely identify an accrual transaction created as a result of a diary adjustment.
        /// 
        /// Allowable Values 01 to 99
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// 274-01 Adjusted Loan
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AccrualNumber { get; set; }
        #endregion

        #region Bitmap Position 109
        /// <summary>
        /// Adjustment Reason : The cause of an adjustment to a settlement instruction.
        /// 
        /// Allowable Values 'D' = Diary adjustment
        ///                  'I' = Isolated counterparty
        ///                  'P' = Participant request
        ///  
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        public static readonly char[] AdjustmentReason = new char[3] { 'D', 'I', 'P' };
        #endregion

        #region Bitmap Position 110
        /// <summary>
        /// Invalid Reason : The reason code explaining the nature of the error which made the user's message unprocessable.
        /// 
        /// 540-01 Invalid Transaction
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string InvalidReason { get; set; }
        #endregion

        #region Bitmap Position 111
        /// <summary>
        /// Invalid Message Header : The fixed header section of an unprocessable message. The fixed
        /// header consists of Length to Message Identifier inclusive as defined
        /// in section 10.5.3. From this the user can extract the MSN (as
        /// defined in section 10.8.3) and locate and examine the offending
        /// message in his own system.
        /// 
        /// 540-01 Invalid Transaction
        /// </summary>
        [StringLength(32, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string InvalidMessageHeader { get; set; }
        #endregion

        #region Bitmap Position 112
        /// <summary>
        /// Delivering Net Movement Transaction Id : The identifier of the transaction which transferred securities to a
        /// holding via the settlement process.
        /// 
        /// 156-01 Settled Settlement Instruction
        /// 180-02 Full Settlement Instruction
        /// 192-01 Part-Settled Settlement Instruction
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DeliveringNetMovementTransactionId { get; set; }
        #endregion

        #region Bitmap Position 113
        /// <summary>
        /// Netted Obligation Transaction Id : The identifier of the transaction generated as a result of a trade being netted.
        /// 
        /// 180-02 Full Settlement Instruction
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string NettedObligationTransactionId { get; set; }
        #endregion

        #region Bitmap Position 114
        /// <summary>
        /// Net Funds Transaction Id : The identifier of the transaction which confirmed that the requested
        /// funds transfer has been initiated by the financial intermediary.
        /// 
        /// 156-01 Settled Settlement Instruction
        /// 170-01 Effected Net Funds Movement
        /// 180-02 Full Settlement Instruction
        /// 192-01 Part-Settled Settlement Instruction
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string NetFundsTransactionId { get; set; }
        #endregion

        #region Bitmap Position 115
        /// <summary>
        /// Condition Code 1 : Indicates the condition under which the sale was effected.
        /// 
        /// Allowable Values
        #region Allowable Values
        //A1 Reserved for admittance of Approved Market Operator
        //A2 Reserved for admittance of Approved Market Operator
        //A3 Reserved for admittance of Approved Market Operator
        //A4 Reserved for admittance of Approved Market Operator
        //A5 Reserved for admittance of Approved Market Operator
        //A6 Reserved for admittance of Approved Market Operator
        //A7 Reserved for admittance of Approved Market Operator
        //A8 Reserved for admittance of Approved Market Operator
        //A9 Reserved for admittance of Approved Market Operator
        //AB ASX Bookbuild
        //AM ASX Match
        //BB Bulletin Board Trade
        //BC Preferenced Any Price Block Trade
        //BK Buy Back
        //BL Blocked from Transaction Netting
        //BP Booking Purposes Only
        //BT Any Price Block Trade
        //BV Book Value Switch
        //BW Buy Write
        //BZ Board Broker Sale
        //CM Single Sided Combination
        //CP Centre Point Preference Trade
        //CT Combination Trade
        //CX Centre Point Trade
        //DR Directed Reporting
        //EC Exercise of Call
        //EF Delivery of a Future
        //EQ Equity/Option Combination
        //EP Exercise of Put
        //ET EFT Special Trades
        //FD Forward Delivery
        //FM Foreign Market
        //IA Interstate Accounting
        //LN Loan
        //LR Loan Return
        //LT Late Trade - Post 5PM
        //L1 Late Trade - Book Squaring
        //L2 Late Trade - Hedging Trades
        //L3 Late Trade - Order Completion
        //L4 Late Trade - Error Rectification
        //L5 Late Trade - Put Through
        //MI Market Information
        //NX NBBO Crossing Trade Report
        //OC OTC Contingent Equity Trade
        //OD Overseas Delivery
        //OL Odd Lot
        //ON Overnight
        //OR Overseas Resident(Foreign to Foreign)
        //OS Overseas
        //PR Prompt Re-booking
        //PS Prompt Sale
        //P1 Put Through - $1M
        //P2 Put Through - $0.5M
        //SA Special Crossing Sale
        //SH Short
        //SM SMSF Crossing Trade Report
        //SO Other Special Sale
        //SP Special - Derivatives
        //S1 Special - $2.5M
        //S2 Special - $1M
        //S3 Special - $0.5M
        //ST Price Stabilisation
        //SX Special Sale Portfolio
        //TM Tailor Made Combination
        //VM Volume Match Trade
        //VW VWAP Trade
        //XT Crossed Trade
        #endregion Allowable Values End
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] ConditionCode1 = new string[67]
        {
            "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AB", "AM",
            "BB", "BC", "BK", "BL", "BP", "BT", "BV", "BW", "BZ",
            "CM", "CP", "CT", "CX",
            "DR",
            "EC", "EF", "EQ", "EP", "ET",
            "FD", "FM",
            "IA",
            "LN", "LR", "LT", "L1", "L2", "L3", "L4", "L5",
            "MI",
            "NX",
            "OC", "OD", "OL", "ON", "OR", "OS",
            "PR", "PS", "P1", "P2",
            "SA", "SH", "SM", "SO", "SP", "S1", "S2", "S3", "ST", "SX",
            "TM",
            "VM", "VW",
            "XT"
        };
        #endregion

        #region Bitmap Position 116
        /// <summary>
        /// Condition Code 2 : Indicates the condition under which the sale was effected.
        /// 
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] ConditionCode2 = new string[58]
        {
            "AB", "AM",
            "BB", "BC", "BK", "BL", "BP", "BT", "BV", "BW", "BZ",
            "CM", "CP", "CT", "CX",
            "DR",
            "EC", "EF", "EQ", "EP", "ET",
            "FD", "FM",
            "IA",
            "LN", "LR", "LT", "L1", "L2", "L3", "L4", "L5",
            "MI",
            "NX",
            "OC", "OD", "OL", "ON", "OR", "OS",
            "PR", "PS", "P1", "P2",
            "SA", "SH", "SM", "SO", "SP", "S1", "S2", "S3", "ST", "SX",
            "TM",
            "VM", "VW",
            "XT"
        };
        #endregion

        #region Bitmap Position 117
        /// <summary>
        /// Condition Code 3 : Indicates the condition under which the sale was effected.
        /// 
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] ConditionCode3 = new string[58]
        {
            "AB", "AM",
            "BB", "BC", "BK", "BL", "BP", "BT", "BV", "BW", "BZ",
            "CM", "CP", "CT", "CX",
            "DR",
            "EC", "EF", "EQ", "EP", "ET",
            "FD", "FM",
            "IA",
            "LN", "LR", "LT", "L1", "L2", "L3", "L4", "L5",
            "MI",
            "NX",
            "OC", "OD", "OL", "ON", "OR", "OS",
            "PR", "PS", "P1", "P2",
            "SA", "SH", "SM", "SO", "SP", "S1", "S2", "S3", "ST", "SX",
            "TM",
            "VM", "VW",
            "XT"
        };
        #endregion

        #region Bitmap Position 118
        /// <summary>
        /// Condition Code 4 : Indicates the condition under which the sale was effected.
        /// 
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] ConditionCode4 = new string[58]
        {
            "AB", "AM",
            "BB", "BC", "BK", "BL", "BP", "BT", "BV", "BW", "BZ",
            "CM", "CP", "CT", "CX",
            "DR",
            "EC", "EF", "EQ", "EP", "ET",
            "FD", "FM",
            "IA",
            "LN", "LR", "LT", "L1", "L2", "L3", "L4", "L5",
            "MI",
            "NX",
            "OC", "OD", "OL", "ON", "OR", "OS",
            "PR", "PS", "P1", "P2",
            "SA", "SH", "SM", "SO", "SP", "S1", "S2", "S3", "ST", "SX",
            "TM",
            "VM", "VW",
            "XT"
        };
        #endregion

        #region Bitmap Position 119
        /// <summary>
        /// Condition Code 5 : Indicates the condition under which the sale was effected.
        /// 
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] ConditionCode5 = new string[58]
        {
            "AB", "AM",
            "BB", "BC", "BK", "BL", "BP", "BT", "BV", "BW", "BZ",
            "CM", "CP", "CT", "CX",
            "DR",
            "EC", "EF", "EQ", "EP", "ET",
            "FD", "FM",
            "IA",
            "LN", "LR", "LT", "L1", "L2", "L3", "L4", "L5",
            "MI",
            "NX",
            "OC", "OD", "OL", "ON", "OR", "OS",
            "PR", "PS", "P1", "P2",
            "SA", "SH", "SM", "SO", "SP", "S1", "S2", "S3", "ST", "SX",
            "TM",
            "VM", "VW",
            "XT"
        };
        #endregion

        #region Bitmap Position 120
        /// <summary>
        /// Condition Code 6 : Indicates the condition under which the sale was effected.
        /// 
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] ConditionCode6 = new string[58]
        {
            "AB", "AM",
            "BB", "BC", "BK", "BL", "BP", "BT", "BV", "BW", "BZ",
            "CM", "CP", "CT", "CX",
            "DR",
            "EC", "EF", "EQ", "EP", "ET",
            "FD", "FM",
            "IA",
            "LN", "LR", "LT", "L1", "L2", "L3", "L4", "L5",
            "MI",
            "NX",
            "OC", "OD", "OL", "ON", "OR", "OS",
            "PR", "PS", "P1", "P2",
            "SA", "SH", "SM", "SO", "SP", "S1", "S2", "S3", "ST", "SX",
            "TM",
            "VM", "VW",
            "XT"
        };
        #endregion

        #region Bitmap Position 121
        /// <summary>
        /// Condition Code 7 : Indicates the condition under which the sale was effected.
        /// 
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] ConditionCode7 = new string[58]
        {
            "AB", "AM",
            "BB", "BC", "BK", "BL", "BP", "BT", "BV", "BW", "BZ",
            "CM", "CP", "CT", "CX",
            "DR",
            "EC", "EF", "EQ", "EP", "ET",
            "FD", "FM",
            "IA",
            "LN", "LR", "LT", "L1", "L2", "L3", "L4", "L5",
            "MI",
            "NX",
            "OC", "OD", "OL", "ON", "OR", "OS",
            "PR", "PS", "P1", "P2",
            "SA", "SH", "SM", "SO", "SP", "S1", "S2", "S3", "ST", "SX",
            "TM",
            "VM", "VW",
            "XT"
        };
        #endregion

        #region Bitmap Position 122
        /// <summary>
        /// Condition Code 8 : Indicates the condition under which the sale was effected.
        /// 
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] ConditionCode8 = new string[58]
        {
            "AB", "AM",
            "BB", "BC", "BK", "BL", "BP", "BT", "BV", "BW", "BZ",
            "CM", "CP", "CT", "CX",
            "DR",
            "EC", "EF", "EQ", "EP", "ET",
            "FD", "FM",
            "IA",
            "LN", "LR", "LT", "L1", "L2", "L3", "L4", "L5",
            "MI",
            "NX",
            "OC", "OD", "OL", "ON", "OR", "OS",
            "PR", "PS", "P1", "P2",
            "SA", "SH", "SM", "SO", "SP", "S1", "S2", "S3", "ST", "SX",
            "TM",
            "VM", "VW",
            "XT"
        };
        #endregion

        #region Bitmap Position 123
        /// <summary>
        /// Buyer Id : Identifies the buying broker who made the trade.
        /// 
        /// Allowable Values 01 to 99
        /// 
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// </summary>
        [StringLength(4, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string BuyerId { get; set; }
        #endregion

        #region Bitmap Position 124
        /// <summary>
        /// Seller Id : Identifies the selling broker who made the trade.
        /// 
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// </summary>
        [StringLength(4, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SellerId { get; set; }
        #endregion

        #region Bitmap Position 125
        /// <summary>
        /// Cancellation Timestamp : The time that the cancellation of an ETC transaction is recorded in the CHESS Database.
        /// 
        /// 667-01 ETC Trade Cancellation Advice
        /// 669-01 ETC Contract Note Cancellation Advice
        /// 684-01 ETC Trade Cancellation
        /// 688-01 ETC Contract Note Cancellation
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string CancellationTimestamp { get; set; }

        /// <summary>
        /// Cancelled Timestamp : The time that the cancellation of a transaction is recorded in the CHESS database.
        /// 
        /// 052-03 Full Dual Entry CHESS to CHESS Transfer
        /// 180-02 Full Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// 286-01 Full Loan Instruction
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string CancelledTimestamp { get; set; }

        /// <summary>
        /// ETC Settlement Cancel Timestamp : Records the business date, processing date and processing time on which
        /// the sending UIC completes the processing of an ETC settlement cancellation advice.
        /// 
        /// 665-01 ETC Settlement Cancellation Advice
        /// 680-01 ETC Settlement Cancellation
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ETCSettlementCancelTimestamp { get; set; }
        #endregion

        #region Bitmap Position 126
        /// <summary>
        /// Authorisation Reason : Indicates why a participant funds obligation authorisation is being requested from a Payment provider.
        /// 
        /// Allowable values ‘PRIMARY’
        ///                  ‘FAILURE’
        ///                  
        /// 310-01 Participant Funds Obligation
        /// 310-02 Participant Funds Obligation
        /// 312-01 Payment Provider Funds Obligation
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] AuthorisationReason = new string[2] { "PRIMARY", "FAILURE" };
        #endregion

        #region Bitmap Position 127
        /// <summary>
        /// Cancellation Reason : The reason a settlement instruction has been cancelled.
        /// 
        /// Allowable Values ‘A’ = Invalid Trade – ASX Clear Discretion  *Value applies to Approved Market Operator (other than ASX) only.
        ///                  ‘C’ = CHESS housekeeping
        ///                  'D' = Cancelled Diary Adjustment
        ///                  'I' = Isolated counterparty
        ///                  ‘P’ = Participant request
        ///                  'S' = ASX Trading System Cancellation
        ///                  'T’ = Invalid Trade Receipt Time  *Value applies to Approved Market Operator (other than ASX) only.
        ///                  ‘V’ = Invalid Price Variance  *Value applies to Approved Market Operator (other than ASX) only.
        ///                  ‘W’= TBA  *Value applies to Approved Market Operator (other than ASX) only.
        ///                  ‘X’ = TBA  *Value applies to Approved Market Operator (other than ASX) only.
        ///                  ‘Y’ = TBA  *Value applies to Approved Market Operator (other than ASX) only.
        ///                  ‘Z’ = TBA  *Value applies to Approved Market Operator (other than ASX) only.
        ///                  
        /// 048-01 Cancelled Demand Dual Entry Transfer Request
        /// 116-01 Cancelled Settlement Instruction
        /// 118-01 Cancelled Change Settlement Instruction Request
        /// 132-01 Removed Dual Entry Settlement Instruction Cancellation Request
        /// 442-01 Cancelled Change RTGS Instruction Request
        /// 450-01 Cancelled Request to Change Settlement Type
        /// 492-01 Removed RTGS Instruction Cancellation Request
        /// </summary>
        public static readonly char[] CancellationReason = new char[12] { 'A', 'C', 'D', 'I', 'P', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
        #endregion

        #region Bitmap Position 128
        /// <summary>
        /// Rejected Transfer Reason : The reason that a demand dual entry transfer failed despite both
        /// sides of the transfer being matched or where an mFund CHESS to
        /// CHESS transfer has been rejected by either a PISP or by CHESS.
        /// 
        /// Allowable Values
        #region Allowable Values
        //'A’ = Insufficient Units
        //'B’ = Insufficient Entitlements
        //'C’ = Delivering Holding / Holder Locked
        //'D’ = Receiving Holding Locked
        //‘E’ = Insufficient Foreign Units
        //‘F’ = Account is a Deceased Estate
        //‘G’ = Request cannot be accepted as AML/CTF Check Flag is not ‘Y’ (Yes)
        //‘H’ = TFN, ABN or exemption code required for Australian residents
        //‘I’ = Tax Residence is mandatory for applicants
        //‘J’ = DRP Preference is mandatory for an Initial Application
        //‘K’ = Invalid BSB or Bank Account Details
        //‘L’ = PDS Issue Date supplied is not the latest issued PDS
        //‘M’ = Transfer to Companies and Trusts are not accepted
        //‘N’ = Transfers to foreign tax residents are not accepted
        //‘O’ = Fund available to restricted investors only
        //‘P’ = Fund Manager does not accept transfers
        #endregion Allowable Values End
        /// 
        /// 024-01 Rejected Demand Dual Entry CHESS to CHESS Transfer
        /// </summary>
        public static readonly char[] RejectedTransferReason = new char[16]
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
            'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P'
        };
        #endregion

        #region Bitmap Position 129

        #endregion

        #region Bitmap Position 130
        /// <summary>
        /// Revised Override Basis Of Move 1 : Specifies the revised override basis of movement of a settlement instruction after it has been altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] RevisedOverrideBasisOfMove1 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };
        #endregion

        #region Bitmap Position 131
        /// <summary>
        /// Revised Override Basis Of Move 2 : Specifies the revised override basis of movement of a settlement instruction after it has been altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] RevisedOverrideBasisOfMove2 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };
        #endregion

        #region Bitmap Position 132
        /// <summary>
        /// Revised Override Basis Of Move 3 : Specifies the revised override basis of movement of a settlement instruction after it has been altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] RevisedOverrideBasisOfMove3 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };
        #endregion

        #region Bitmap Position 133
        /// <summary>
        /// Revised Override Basis Of Move 4 : Specifies the revised override basis of movement of a settlement instruction after it has been altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] RevisedOverrideBasisOfMove4 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };
        #endregion

        #region Bitmap Position 134
        /// <summary>
        /// Revised Override Basis Of Move 5 : Specifies the revised override basis of movement of a settlement instruction after it has been altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] RevisedOverrideBasisOfMove5 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CI", "XI",
            "CQ", "XQ",
            "CZ", "XZ",
        };
        #endregion

        #region Bitmap Position 135
        /// <summary>
        /// Revised Duty Type : Specifies the revised duty type of a settlement instruction after it has been altered.
        /// 
        /// Allowable Values 'A' = Ad Valorem
        ///                  'C' = Concessional - NCBO
        ///                  'D' = Concessional - other
        ///                  'E' = Exempt - Entrepot Account Transfer
        ///                  'F' = Exempt - Charitable Body
        ///                  'G' = Exempt - Government Body
        ///                  'K' = Exempt - Duty Paid
        ///                  'L' = Exempt - Stock Loan
        ///                  'M' = Exempt - Stock Loan Return
        ///                  'N' = Exempt - NCBO
        ///                  'O' = Exempt - other
        ///                  'P' = Exempt - Passing Entitlement following the Parent Shares
        ///                  'R' = Reversal
        ///  
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        public static readonly char[] RevisedDutyType = new char[13] { 'A', 'C', 'D', 'E', 'F', 'G', 'K', 'L', 'M', 'N', 'O', 'P', 'R' };
        #endregion

        #region Bitmap Position 136
        /// <summary>
        /// AI Dividends Franked Amount Cash : Australian Income: Total net cash amount for franked dividends. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AIDividendsFrankedAmountCash { get; set; }

        /// <summary>
        /// Capital Gain Discounted : Total capital gain using a discounted method. An ATO Tax Statement value.
        /// 
        /// 959-01 Registry Income Statement Part B
        /// 964-01 Participant Income Statement Part B
        /// </summary>
        public static decimal CapitalGainDiscount { get; set; }

        /// <summary>
        /// CG Discount Cash : Capital Gain: Total net cash reductions made to the taxable Australian property component of capital gain. 
        /// An ATO Tax Statement value.
        /// 
        /// 963-01 Registry Income Statement Part C CG
        /// 968-01 Participant Income Statement Part C CG
        /// </summary>
        public static decimal CGDiscountCash { get; set; }

        /// <summary>
        /// FI Assessable Income Cash : Foreign Income: Total net cash amount for foreign sourced income. An ATO Tax Statement value.
        /// 
        /// 965-01 Registry Income Statement Part C FI
        /// 970-01 Participant Income Statement Part C FI
        /// </summary>
        public static decimal FIAssessableIncomeCash { get; set; }

        /// <summary>
        /// NA Tax Exempted Amounts Cash : Non Assessable: Total of net cash amount exempted from taxation. An ATO Tax Statement value.
        /// 
        /// 967-02Registry Income Statement Part C NA
        /// 972-02Participant Income Statement Part C NA
        /// </summary>
        public static decimal NATaxExemptedAmountsCash { get; set; }

        /// <summary>
        /// Non Primary Income : Total share of non-primary production income. An ATO Tax Statement value.
        /// 
        /// 957-02Registry Income Statement Part A
        /// 962-02Participant Income Statement Part A
        /// </summary>
        public static decimal NonPrimaryIncome { get; set; }

        /// <summary>
        /// OD TFN Amounts Withheld : Other Deductions: Total of net cash amounts withheld against a TFN. An ATO Tax Statement value.
        /// 
        /// 969-01 Registry Income Statement Part C OD
        /// 974-01 Participant Income Statement Part C OD
        /// </summary>
        public static decimal ODTFNAmountsWithheld { get; set; }

        /// <summary>
        /// Previous Duty Payable : Specifies the duty payable of a settlement instruction before it was altered.
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        public static decimal PreviousDutyPayable { get; set; }
        #endregion

        #region Bitmap Position 137
        /// <summary>
        /// AI Dividends Franked Amount Tax : Australian Income: Total tax credit for franked dividends. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AIDividendsFrankedAmountTax { get; set; }

        /// <summary>
        /// Capital Gain Other : Total capital gain using another method. An ATO Tax Statement value.
        /// 
        /// 959-01 Registry Income Statement Part B
        /// 964-01 Participant Income Statement Part B
        /// </summary>
        public static decimal CapitalGainOther { get; set; }

        /// <summary>
        /// CG Discount Tax : Capital Gain: Total tax paid or tax offset reductions made to the taxable Australian property component of capital gain.
        /// An ATO Tax Statement value.
        /// 
        /// 963-01 Registry Income Statement Part C CG
        /// 968-01 Participant Income Statement Part C CG
        /// </summary>
        public static decimal CGDiscountTax { get; set; }

        /// <summary>
        /// FI Assessable Income Tax : Foreign Income: Total tax paid or tax offset for foreign sourced income. An ATO Tax Statement value.
        /// 
        /// 965-01 Registry Income Statement Part C FI
        /// 970-01 Participant Income Statement Part C FI
        /// </summary>
        public static decimal FIAssessableIncomeTax { get; set; }

        /// <summary>
        /// NA Tax Deferred Amounts Cash : Non Assessable: Total of net cash amount deferred from taxation. An ATO Tax Statement value.
        /// 
        /// 967-02Registry Income Statement Part C NA
        /// 972-02Participant Income Statement Part C NA
        /// </summary>
        public static decimal NATaxDeferredAmountsCash { get; set; }

        /// <summary>
        /// OD Other Expenses : Other Deductions: Total of other net cash expenses incurred by the investor. An ATO Tax Statement value.
        /// 
        /// 969-01 Registry Income Statement Part C OD
        /// 974-01 Participant Income Statement Part C OD
        /// </summary>
        public static decimal ODOtherExpenses { get; set; }

        /// <summary>
        /// Revised Duty Payable : Specifies the revised duty payable of a settlement instruction after it has been altered.
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        public static decimal RevisedDutyPayable { get; set; }
        #endregion

        #region Bitmap Position 138
        /// <summary>
        /// Revised Receiving HIN : Specifies the revised receiving HIN of a settlement instruction after it has been altered.
        /// 
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RevisedReceivingHIN { get; set; }
        #endregion

        #region Bitmap Position 139
        /// <summary>
        /// Revised Transaction Basis : Specifies the revised transaction basis of a settlement instruction after it has been altered.
        /// 
        /// Allowable Values ‘F’ = Facility for Non Reportable Transactions
        ///                  ‘I’ = IPO Transaction
        ///                  'M' = Market
        ///                  'O' = Off-Market
        ///                  'L' = Stock Lending Activity
        ///                  
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        public static readonly char[] RevisedTransactionBasis = new char[5] { 'F', 'I', 'M', 'O', 'L' };
        #endregion

        #region Bitmap Position 140
        /// <summary>
        /// Rejected Registration Update Reason : The reason that a registration details update request has been rejected by Market Support.
        /// 
        /// Allowable Values 'A' = Insufficient documentation
        ///                  'B' = Incorrect Reason Code
        ///                  'C' = Mismatch between documentation and message
        ///                  'D' = Spelling error on message
        ///                  'E' = Participant request
        ///                  'F' = Change of Legal Title – New HIN setup required
        ///                  ‘G’ = Incorrect Holder Status
        ///                  ‘Z’ = Rejected by Market Support
        ///                  
        /// 080-02 Rejected Registration Details Update
        /// </summary>
        public static readonly char[] RejectedRegistrationUpdateReason = new char[8] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'Z' };
        #endregion

        #region Bitmap Position 141
        /// <summary>
        /// SLS Loan Instruction Status : The current status of a loan instruction
        /// 
        /// Allowable Values 'A' = Active
        ///                  'C' = Cancelled
        ///                  'E' = Effected
        ///                  'R' = Requested
        ///                  'X' = Rejected
        ///                  
        /// 286-01 Full Loan Instruction
        /// </summary>
        public static readonly char[] SLSLoanInstructionStatus = new char[5] { 'A', 'C', 'E', 'R', 'X' };
        #endregion

        #region Bitmap Position 142
        /// <summary>
        /// CHESS Event Type : The type of event that has occurred during CHESS processing.
        /// 
        /// Allowable Values ‘N’ = End of Netting Reporting
        ///                  ‘O’ = End of Overnight Reporting
        ///                  ‘R’ = End of Netting Reversal Reporting
        ///                  'S' = End of Settlement Reporting
        ///                  ‘A’ = Settlement Cut-Off extended to 11:45
        ///                  ‘B’ = Settlement Cut-Off extended to 12:00
        ///                  ‘C’ = Settlement Cut-Off extended to 12:15
        ///                  ‘D’ = Settlement Cut-Off extended to 12:30
        ///                  ‘E’ = Settlement Cut-Off extension to be advised
        ///                  
        /// 542-01 CHESS Event Notification
        /// </summary>
        public static readonly char[] CHESSEventType = new char[9] { 'N', 'O', 'R', 'S', 'A', 'B', 'C', 'D', 'E' };

        /// <summary>
        /// Registration Name Update Reason 1 : Indicates the reason for a name change to registration details.
        /// 
        /// Allowable Values ‘A’ = Account Designation Changes
        ///                  'C' = Change of Company Name
        ///                  'E’ = Error
        ///                  ‘F’ = First Name Extended / Shortened
        ///                  ‘I’ = Adding / Removing Middle Name
        ///                  'L' = Legal Change of Name
        ///                  'M' = Marriage
        ///                  ‘R’ = Revert to Maiden Name
        ///                  'S' = Salutation / Title Change
        ///                  
        /// 203-04 Registration Details Update Request
        /// </summary>
        public static readonly char[] RegistrationNameUpdateReason1 = new char[9] { 'A', 'C', 'E', 'F', 'I', 'L', 'M', 'R', 'S' };
        #endregion

        #region Bitmap Position 143
        /// <summary>
        /// Settlement Step : Identifies the step of the settlement process in which the message is
        /// generated. Is not used when messages are used for reporting purposes.
        /// 
        /// Allowable Values 'A' = Authorisation-1st
        ///                  'B' = Authorisation-2nd
        ///                  'N' = Notification
        ///                  'T' = Transfer
        ///                  
        /// 150-01 Projected Funds Obligation
        /// 350-01 Clearing Account Transfer Request
        /// </summary>
        public static readonly char[] SettlementStep = new char[4] { 'A', 'B', 'N', 'T' };
        #endregion

        #region Bitmap Position 144
        /// <summary>
        /// Pre-Settlement Advice - ESA Level : Identifies whether, for all RTGS buy transactions targeting a given
        /// Cash Subrecord, the paying payment provider (i.e. the payment
        /// provider sponsoring the buyer participant) requires CHESS to advise
        /// RITS to send the paying payment provider a pre-settlement advice
        /// for payment provider liquidity on that transaction.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  ‘N’ = No
        ///                  
        /// 353-01 Create Cash Subrecord Authorisation
        /// 373-01 Payment Provider Change Cash Subrecord Attributes Request
        /// </summary>
        public static readonly char[] Pre_SettlementAdvice_ESALevel = new char[2] { 'Y', 'N' };

        /// <summary>
        /// Transaction Class Parameter : Restricts the scope of reporting to a specific transaction class.
        /// 
        /// Allowable Values 'A' = Registry to CHESS transactions
        ///                  'B' = CHESS to Registry transactions
        ///                  'C' = CHESS to CHESS transactions
        ///                  'D' = Registry Initiated transactions
        ///                  
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        public static readonly char[] TransactionClassParameter = new char[4] { 'A', 'B', 'C', 'D' };
        #endregion

        #region Bitmap Position 145
        /// <summary>
        /// Levy Type : The type of levy charged to the user.
        /// 
        /// Allowable Values 'A' = Settlement Fail - Net Batch
        ///                  ‘B’ = RTGS Settlement Fail
        ///                  ‘C’ = Reserved for future use
        ///                  ‘D’ = Reserved for future use
        ///                  ‘E’ = Reserved for future use
        ///                  
        /// 544-01 Levy Notification
        /// 548-02 Reversed Levy Notification
        /// </summary>
        public static readonly char[] LevyType = new char[5] { 'A', 'B', 'C', 'D', 'E' };

        /// <summary>
        /// Registration Name Update Reason 2 : Indicates the reason for a name change to registration details.
        /// 
        /// Allowable Values ‘A’ = Account Designation Changes
        ///                  'C' = Change of Company Name
        ///                  'E’ = Error
        ///                  ‘F’ = First Name Extended / Shortened
        ///                  ‘I’ = Adding / Removing Middle Name
        ///                  'L' = Legal Change of Name
        ///                  'M' = Marriage
        ///                  ‘R’ = Revert to Maiden Name
        ///                  'S' = Salutation / Title Change
        ///                  
        /// 203-04 Registration Details Update Request
        /// </summary>
        public static readonly char[] RegistrationNameUpdateReason2 = new char[9] { 'A', 'C', 'E', 'F', 'I', 'L', 'M', 'R', 'S' };
        #endregion

        #region Bitmap Position 146
        /// <summary>
        /// Basis Of Quotation 1 : States the basis of quotation of a trade if effected outside the default basis of quotation.
        /// 
        /// Allowable Values - 'CD' Cum Dividend 
        ///                    'XD' Ex Dividend 
        ///                    'CR' Cum Rights Issue 
        ///                    'XR' Ex Rights Issue 
        ///                    'CB' Cum Bonus Issue 
        ///                    'XB' Ex Bonus Issue 
        ///                    'CE' Cum Entitlement 
        ///                    'XE' Ex Entitlement 
        ///                    'CC' Cum Capital return 
        ///                    'XC' Ex Capital return 
        ///                    'CM' Cum Premium return 
        ///                    'XM' Ex Premium return 
        ///                    'CF' Cum Takeover Offer 
        ///                    'XF' Ex Takeover Offer 
        ///                    'CZ' Cum Non Pro Rata Balance 
        ///                    'XZ' Ex Non Pro Rata Balance 
        ///                    'CI' Cum Interest
        ///                    'XI' Ex Interest
        ///                    ‘CQ’ Cum Equal Access Buyback
        ///                    ‘XQ’ Ex Equal Access Buyback
        ///                    'CL' Call Due
        ///                    'CP' Call Paid
        ///                    'CT' Conditional Trading
        ///                    'NX' New Ex Interest
        ///                    'PA' Protection Available
        ///                    'PU' Protection Unavailable
        ///                    'RA' Receiver Appointed
        ///                    'RE' Reconstructed
        ///                    'T1' Trade Date Plus 1 Business Day
        ///                    'T2' Trade Date Plus 2 Business Days
        ///                    'T3' Trade Date Plus 3 Business Days
        ///                    'TA' Trade Date Plus 10 Business Days
        ///                    'TB' Trade Date Plus 15 Business Days
        ///                    'TC' Trade Date Plus 20 Business Days
        ///                    'TD' Trade Date Plus 25 Business Days
        ///                    'TE' Trade Date Plus 30 or over Business Days
        ///                    
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 554-01 Close Out Notification
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] BasisOfQuotation1 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CF", "XF",
            "CZ", "XZ",
            "CI", "XI",
            "CQ", "XQ",
            "CL", "CP", "CT",
            "NX",
            "PA", "PU",
            "RA", "RE",
            "T1", "T2", "T3",
            "TB", "TC",
            "TD", "TE",
        };
        #endregion

        #region Bitmap Position 147
        /// <summary>
        /// Basis Of Quotation 2 : States the basis of quotation of a trade if effected outside the default basis of quotation.
        /// 
        /// Allowable Values - 'CD' Cum Dividend 
        ///                    'XD' Ex Dividend 
        ///                    'CR' Cum Rights Issue 
        ///                    'XR' Ex Rights Issue 
        ///                    'CB' Cum Bonus Issue 
        ///                    'XB' Ex Bonus Issue 
        ///                    'CE' Cum Entitlement 
        ///                    'XE' Ex Entitlement 
        ///                    'CC' Cum Capital return 
        ///                    'XC' Ex Capital return 
        ///                    'CM' Cum Premium return 
        ///                    'XM' Ex Premium return 
        ///                    'CF' Cum Takeover Offer 
        ///                    'XF' Ex Takeover Offer 
        ///                    'CZ' Cum Non Pro Rata Balance 
        ///                    'XZ' Ex Non Pro Rata Balance 
        ///                    'CI' Cum Interest
        ///                    'XI' Ex Interest
        ///                    ‘CQ’ Cum Equal Access Buyback
        ///                    ‘XQ’ Ex Equal Access Buyback
        ///                    'CL' Call Due
        ///                    'CP' Call Paid
        ///                    'CT' Conditional Trading
        ///                    'NX' New Ex Interest
        ///                    'PA' Protection Available
        ///                    'PU' Protection Unavailable
        ///                    'RA' Receiver Appointed
        ///                    'RE' Reconstructed
        ///                    'T1' Trade Date Plus 1 Business Day
        ///                    'T2' Trade Date Plus 2 Business Days
        ///                    'T3' Trade Date Plus 3 Business Days
        ///                    'TA' Trade Date Plus 10 Business Days
        ///                    'TB' Trade Date Plus 15 Business Days
        ///                    'TC' Trade Date Plus 20 Business Days
        ///                    'TD' Trade Date Plus 25 Business Days
        ///                    'TE' Trade Date Plus 30 or over Business Days
        ///                    
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 554-01 Close Out Notification
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] BasisOfQuotation2 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CF", "XF",
            "CZ", "XZ",
            "CI", "XI",
            "CQ", "XQ",
            "CL", "CP", "CT",
            "NX",
            "PA", "PU",
            "RA", "RE",
            "T1", "T2", "T3",
            "TB", "TC",
            "TD", "TE",
        };
        #endregion

        #region Bitmap Position 148
        /// <summary>
        /// Basis Of Quotation 3 : States the basis of quotation of a trade if effected outside the default basis of quotation.
        /// 
        /// Allowable Values - 'CD' Cum Dividend 
        ///                    'XD' Ex Dividend 
        ///                    'CR' Cum Rights Issue 
        ///                    'XR' Ex Rights Issue 
        ///                    'CB' Cum Bonus Issue 
        ///                    'XB' Ex Bonus Issue 
        ///                    'CE' Cum Entitlement 
        ///                    'XE' Ex Entitlement 
        ///                    'CC' Cum Capital return 
        ///                    'XC' Ex Capital return 
        ///                    'CM' Cum Premium return 
        ///                    'XM' Ex Premium return 
        ///                    'CF' Cum Takeover Offer 
        ///                    'XF' Ex Takeover Offer 
        ///                    'CZ' Cum Non Pro Rata Balance 
        ///                    'XZ' Ex Non Pro Rata Balance 
        ///                    'CI' Cum Interest
        ///                    'XI' Ex Interest
        ///                    ‘CQ’ Cum Equal Access Buyback
        ///                    ‘XQ’ Ex Equal Access Buyback
        ///                    'CL' Call Due
        ///                    'CP' Call Paid
        ///                    'CT' Conditional Trading
        ///                    'NX' New Ex Interest
        ///                    'PA' Protection Available
        ///                    'PU' Protection Unavailable
        ///                    'RA' Receiver Appointed
        ///                    'RE' Reconstructed
        ///                    'T1' Trade Date Plus 1 Business Day
        ///                    'T2' Trade Date Plus 2 Business Days
        ///                    'T3' Trade Date Plus 3 Business Days
        ///                    'TA' Trade Date Plus 10 Business Days
        ///                    'TB' Trade Date Plus 15 Business Days
        ///                    'TC' Trade Date Plus 20 Business Days
        ///                    'TD' Trade Date Plus 25 Business Days
        ///                    'TE' Trade Date Plus 30 or over Business Days
        ///                    
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 554-01 Close Out Notification
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] BasisOfQuotation3 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CF", "XF",
            "CZ", "XZ",
            "CI", "XI",
            "CQ", "XQ",
            "CL", "CP", "CT",
            "NX",
            "PA", "PU",
            "RA", "RE",
            "T1", "T2", "T3",
            "TB", "TC",
            "TD", "TE",
        };
        #endregion

        #region Bitmap Position 149
        /// <summary>
        /// Basis Of Quotation 4 : States the basis of quotation of a trade if effected outside the default basis of quotation.
        /// 
        /// Allowable Values - 'CD' Cum Dividend 
        ///                    'XD' Ex Dividend 
        ///                    'CR' Cum Rights Issue 
        ///                    'XR' Ex Rights Issue 
        ///                    'CB' Cum Bonus Issue 
        ///                    'XB' Ex Bonus Issue 
        ///                    'CE' Cum Entitlement 
        ///                    'XE' Ex Entitlement 
        ///                    'CC' Cum Capital return 
        ///                    'XC' Ex Capital return 
        ///                    'CM' Cum Premium return 
        ///                    'XM' Ex Premium return 
        ///                    'CF' Cum Takeover Offer 
        ///                    'XF' Ex Takeover Offer 
        ///                    'CZ' Cum Non Pro Rata Balance 
        ///                    'XZ' Ex Non Pro Rata Balance 
        ///                    'CI' Cum Interest
        ///                    'XI' Ex Interest
        ///                    ‘CQ’ Cum Equal Access Buyback
        ///                    ‘XQ’ Ex Equal Access Buyback
        ///                    'CL' Call Due
        ///                    'CP' Call Paid
        ///                    'CT' Conditional Trading
        ///                    'NX' New Ex Interest
        ///                    'PA' Protection Available
        ///                    'PU' Protection Unavailable
        ///                    'RA' Receiver Appointed
        ///                    'RE' Reconstructed
        ///                    'T1' Trade Date Plus 1 Business Day
        ///                    'T2' Trade Date Plus 2 Business Days
        ///                    'T3' Trade Date Plus 3 Business Days
        ///                    'TA' Trade Date Plus 10 Business Days
        ///                    'TB' Trade Date Plus 15 Business Days
        ///                    'TC' Trade Date Plus 20 Business Days
        ///                    'TD' Trade Date Plus 25 Business Days
        ///                    'TE' Trade Date Plus 30 or over Business Days
        ///                    
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 554-01 Close Out Notification
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] BasisOfQuotation4 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CF", "XF",
            "CZ", "XZ",
            "CI", "XI",
            "CQ", "XQ",
            "CL", "CP", "CT",
            "NX",
            "PA", "PU",
            "RA", "RE",
            "T1", "T2", "T3",
            "TB", "TC",
            "TD", "TE",
        };
        #endregion

        #region Bitmap Position 150
        /// <summary>
        /// Basis Of Quotation 5 : States the basis of quotation of a trade if effected outside the default basis of quotation.
        /// 
        /// Allowable Values - 'CD' Cum Dividend 
        ///                    'XD' Ex Dividend 
        ///                    'CR' Cum Rights Issue 
        ///                    'XR' Ex Rights Issue 
        ///                    'CB' Cum Bonus Issue 
        ///                    'XB' Ex Bonus Issue 
        ///                    'CE' Cum Entitlement 
        ///                    'XE' Ex Entitlement 
        ///                    'CC' Cum Capital return 
        ///                    'XC' Ex Capital return 
        ///                    'CM' Cum Premium return 
        ///                    'XM' Ex Premium return 
        ///                    'CF' Cum Takeover Offer 
        ///                    'XF' Ex Takeover Offer 
        ///                    'CZ' Cum Non Pro Rata Balance 
        ///                    'XZ' Ex Non Pro Rata Balance 
        ///                    'CI' Cum Interest
        ///                    'XI' Ex Interest
        ///                    ‘CQ’ Cum Equal Access Buyback
        ///                    ‘XQ’ Ex Equal Access Buyback
        ///                    'CL' Call Due
        ///                    'CP' Call Paid
        ///                    'CT' Conditional Trading
        ///                    'NX' New Ex Interest
        ///                    'PA' Protection Available
        ///                    'PU' Protection Unavailable
        ///                    'RA' Receiver Appointed
        ///                    'RE' Reconstructed
        ///                    'T1' Trade Date Plus 1 Business Day
        ///                    'T2' Trade Date Plus 2 Business Days
        ///                    'T3' Trade Date Plus 3 Business Days
        ///                    'TA' Trade Date Plus 10 Business Days
        ///                    'TB' Trade Date Plus 15 Business Days
        ///                    'TC' Trade Date Plus 20 Business Days
        ///                    'TD' Trade Date Plus 25 Business Days
        ///                    'TE' Trade Date Plus 30 or over Business Days
        ///                    
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// 554-01 Close Out Notification
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] BasisOfQuotation5 = new string[] {
            "CD", "XD",
            "CR", "XR",
            "CB", "XB",
            "CE", "XE",
            "CC", "XC",
            "CM", "XM",
            "CF", "XF",
            "CZ", "XZ",
            "CI", "XI",
            "CQ", "XQ",
            "CL", "CP", "CT",
            "NX",
            "PA", "PU",
            "RA", "RE",
            "T1", "T2", "T3",
            "TB", "TC",
            "TD", "TE",
        };
        #endregion

        #region Bitmap Position 151
        /// <summary>
        /// Trade Reason : Specifies the reason for the creation of a broker obligation.
        /// 
        /// Allowable Values 'I' = Isolated Counterparty
        ///                  'T' = ASX Market Trade
        ///                  ‘W’= TBA*
        ///                  ‘X’ = TBA*
        ///                  ‘Y’ = TBA*
        ///                  ‘Z’ = TBA*
        /// * Value applies to Approved Market Operator (other than ASX) only.
        /// 
        /// 164-03 Notified Trade
        /// </summary>
        public static readonly char[] TradeReason = new char[6] { 'I', 'T', 'W', 'X', 'Y', 'Z' };
        #endregion

        #region Bitmap Position 152
        /// <summary>
        /// Additional Reporting Parameter : The form of suppression required on a report request to restrict the output received.
        /// 
        /// Allowable Values ‘A’ = Suppress Zero Balances
        ///                  ‘B’ = Select Scheduled and Suspended Settlement Instructions Only
        ///                  The following values only apply when requesting a ‘TSH’ report:
        ///                  ‘1’ = Top 100 Securityholders
        ///                  ‘2’ = Top 200 Securityholders
        ///                  ‘3’ = Top 300 Securityholders
        ///                  ‘4’ = Top 400 Securityholders
        ///                  ‘5’ = Top 500 Securityholders
        ///                  ‘6’ = Top 600 Securityholders
        ///                  ‘7’ = Top 700 Securityholders
        ///                  ‘8’ = Top 800 Securityholders
        ///                  ‘9’ = Top 900 Securityholders
        ///                  ‘0’ = Top 1000 Securityholders
        ///                  ‘T’ = For Chi-X use only
        ///                  
        /// 234-03 Reporting Request Detail
        /// 503-04 Reporting Request
        /// </summary>
        public static readonly char[] AdditionalReportingParameter = new char[13] { 'A', 'B', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'T' };

        /// <summary>
        /// Pre-Settlement Advice - Credit Level : Identifies whether, for all RTGS buy transactions targeting a given
        /// Cash Subrecord, the paying payment provider (i.e. the payment
        /// provider sponsoring the buyer participant) requires CHESS to advise
        /// RITS to send the paying payment provider a pre-settlement advice
        /// for client credit on that transaction.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  ‘N’ = No
        ///                  
        /// 353-01 Create Cash Subrecord Authorisation
        /// 373-01 Payment Provider Change Cash Subrecord Attributes Request
        /// </summary>
        public static readonly char[] Pre_SettlementAdvice_CreditLevel = new char[2] { 'Y', 'N' };
        #endregion

        #region Bitmap Position 153
        /// <summary>
        /// Rejected Change Reason : The reason for the rejection
        /// 
        /// Allowable Values 'A' = Outstanding transactions targeting HIN
        ///                  'B' = Non-advice by client
        ///                  'C' = Client request
        ///                  ‘E’ = Attempted to remove a non-existent Excess Cash Standing Instruction
        ///                  ‘L’ = Request received after settlement locked.
        ///                  ‘M’ = Maximum allowed Excess Cash exceeded
        ///                  ‘S’ = Amount resulted in Shortage
        ///                  
        /// 253-01 Change Controlling Participant Rejection
        /// 254-01 Rejected Change Controlling Participant
        /// 915-01 Excess Cash Standing Instruction Rejection
        /// 925-01 Margin Settlement Amount Change Rejection
        /// 938-01 Rejected Excess Cash Standing Instruction Request
        /// 950-01 Rejected Margin Settlement Amount Change
        /// </summary>
        public static readonly char[] RejectedChangeReason = new char[7] { 'A', 'B', 'C', 'E', 'L', 'M', 'S' };
        #endregion

        #region Bitmap Position 154
        /// <summary>
        /// Advice Reason : Indicates the reason for the transmission of information.
        /// 
        /// Allowable Values 'A' = Reporting
        ///                  'B' = Change of Controlling Participant
        ///                  ‘C’ = Archived Sub-Register
        ///                  
        /// 222-04 Holder Detail
        /// 502-02 Holding Subposition Detail
        /// 520-02 Cum Entitlement Balance
        /// 522-02 Holding Balance
        /// 832-01 Holding Fund Balance
        /// </summary>
        public static readonly char[] AdviceReason = new char[3] { 'A', 'B', 'C' };

        /// <summary>
        /// Removal Reason : Reason that the Settlement Instruction was removed.
        /// 
        /// Allowable Values ‘A’ = Invalid Trade – ASX Clear discretion
        ///                  ‘T’ = Invalid Trade Receipt Time
        ///                  ‘V’ = Invalid Price Variance
        ///                  
        /// 100-01 Trade Removal Notification
        /// </summary>
        public static readonly char[] RemovalReason = new char[3] { 'A', 'T', 'V' };
        #endregion

        #region Bitmap Position 155
        /// <summary>
        /// Redemption Unit Price : The unit price in cents of a Fund unit targeted for Fund redemptions.
        /// 
        /// 808-02Switch Order Response
        /// 809-02Effected Switch Order Request
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RedemptionUnitPrice { get; set; }

        /// <summary>
        /// Unit Price : The dollar unit price of a security or a unit in a Fund.
        /// 
        /// Cross Reference
        #region Cross Reference
        //651-01 ETC Trade Advice
        //652-01 ETC Trade
        //657-01 Contract Note Advice
        //663-01 ETC Settlement Advice
        //664-01 Contract Note
        //676-01 ETC Settlement
        //729-01 Application Order/Payment Plan Application Response
        //730-02Effected Application Order/Payment Plan Application Response
        //732-02 Unit Adjustment
        //733-02 Effected Fund Unit Adjustment
        //802-02Redemption Order Response
        //803-02Effected Redemption Order Request
        //817-01 Distribution Re-investment Notification
        //818-01 Effected Distribution Re-investment Plan Advice
        //845-02Unit Reversal Notification
        //846-02Effected Unit Reversal Notification
        //927-01 Collateral Statement Notification
        //952-01 Collateral Statement
        #endregion Cross Reference End
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string UnitPrice { get; set; }
        #endregion

        #region Bitmap Position 156
        /// <summary>
        /// Buy/Sell Indicator : Indicates whether the transaction is for a “Buy” or “Sell.”
        /// 
        /// Allowable Values ‘B’ = Buy
        ///                  ‘S’ = Sell
        ///                  
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 664-01 Contract Note
        /// </summary>
        public static readonly char[] BuySellIndicator = new char[2] { 'B', 'S' };
        #endregion

        #region Bitmap Position 157
        /// <summary>
        /// Investor Mobile Contact : The mobile phone number for the investor. Include country code where appropriate.
        /// 
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string InvestorMobileContact { get; set; }

        /// <summary>
        /// Order Reference : Internal reference used between parties to a trade.
        /// 
        /// Cross Reference
        #region Cross Reference
        //651-01 ETC Trade Advice
        //652-01 ETC Trade
        //729-02Application Order/Payment Plan Application Response
        //730-02Effected Application Order/Payment Plan Application Response
        //731-01 Scheduled Settlement Payment Instruction
        //802-02Redemption Order Response
        //803-02Effected Redemption Order Request
        //808-02Switch Order Response
        //809-02Effected Switch Order Request
        //845-02Unit Reversal Notification
        //846-02Effected Unit Reversal Notification
        #endregion Cross Reference End
        /// </summary>
        [StringLength(16, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string OrderReference { get; set; }
        #endregion

        #region Bitmap Position 158
        /// <summary>
        /// Trading Broker : Identifies the broker that executed a [block] trade, using it’s Trading System identifier.
        /// 
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// </summary>
        [StringLength(4, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TradingBroker { get; set; }
        #endregion

        #region Bitmap Position 159
        /// <summary>
        /// Crossing Indicator : Indicates whether the transaction has been crossed.
        /// 
        /// Allowable Values 'C' = Crossed
        ///                  ‘P’ = Part-crossed
        ///                  
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 664-01 Contract Note
        /// </summary>
        public static readonly char[] CrossingIndicator = new char[2] { 'C', 'P' };
        #endregion

        #region Bitmap Position 160
        /// <summary>
        /// Principal Indicator : Indicates that the participant was acting as principal for the transaction.
        /// 
        /// Allowable Values ‘A’ = Part-principal
        ///                  'P' = Principal
        ///                  
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 664-01 Contract Note
        /// </summary>
        public static readonly char[] PrincipalIndicator = new char[2] { 'A', 'P' };
        #endregion

        #region Bitmap Position 161
        /// <summary>
        /// Account Id : Identifies the account to which an allocation is to be made. The Account Id is known to the parties of the allocation.
        /// 
        /// 653-02 ETC Trade Allocation Advice
        /// 656-02 ETC Trade Allocation
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AccountId { get; set; }

        /// <summary>
        /// Issue : The name of the Issue (e.g. BHP, APR12-COL).
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Issue { get; set; }
        #endregion

        #region Bitmap Position 162
        /// <summary>
        /// Allocation Status : Identifies the position of the allocation within the overall set of allocations for a specific block trade.
        /// An “intermediate” allocation refers to any allocation that is not the “final” allocation for that same block trade.
        /// 
        /// Allowable Values ‘I’ = Intermediate
        ///                  ‘F’ = Final
        ///                  
        /// 653-02 ETC Trade Allocation Advice
        /// 656-02 ETC Trade Allocation
        /// </summary>
        public static readonly char[] AllocationStatus = new char[2] { 'I', 'F' };

        /// <summary>
        /// Contract Note Status : Specifies the status of the contract note.
        /// 
        /// Allowable Values 'C' = Complete
        ///                  'P' = Paper Contract Note to follow
        ///                  
        /// 657-01 Contract Note Advice
        /// 664-01 Contract Note
        /// </summary>
        public static readonly char[] ContractNoteStatus = new char[2] { 'C', 'P' };

        /// <summary>
        /// Post-Settlement Advice : Identifies whether, for all RTGS buy and sell transactions targeting a
        /// given Cash Subrecord, the payment provider (i.e. the payment
        /// provider sponsoring the buyer participant) requires CHESS to advise
        /// RITS to send the payment provider a post-settlement advice to
        /// indicate completion of RITS funds movement/s on that transaction.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  ‘N’ = No
        ///                  
        /// 353-01 Create Cash Subrecord Authorisation
        /// 373-01 Payment Provider Change Cash Subrecord Attributes Request
        /// </summary>
        public static readonly char[] Post_SettlementAdvice = new char[2] { 'Y', 'N' };
        #endregion

        #region Bitmap Position 163
        /// <summary>
        /// ETC Rejection Reason : Identifies the reason for the rejection of a specific transaction.
        /// 
        /// Allowable Values 'A' = Other (ie not covered by reason in remainder of list)
        ///                  ‘B’ = Trade Date
        ///                  ‘C’ = Settlement Date
        ///                  ‘D’ = Security Code
        ///                  ‘E’ = Buy/Sell Indicator
        ///                  ‘F’ = Unit Quantity
        ///                  ‘G’ = Unit Price
        ///                  ‘H’ = Trade Value
        ///                  ‘I’ = Brokerage
        ///                  ‘J’ = Duty Payable
        ///                  ‘K’ = Settlement Value
        ///                  ‘L’ = Account Id
        ///                  ‘M’ = Condition Code(s)
        ///                  ‘N’ = Basis of Quote(s)
        ///                  ‘O’ = Name and Address details
        ///                  ‘P’ = Contract Note Status
        ///                  ‘Q’ = Crossing Indicator
        ///                  ‘R’ = Principal Indicator
        ///                  ‘S’ = Settlement Matching Date
        ///                  ‘T’ = Other Amount
        ///                  ‘U’ = Invalid Foreign Guarantee
        ///                  
        /// 655-01 ETC Trade Rejection Advice
        /// 659-01 Contract Note Rejection Advice
        /// 660-01 ETC Trade Rejection
        /// 668-01 Contract Note Rejection
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly char[] ETCRejectionReason = new char[21]
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U'
        };
        #endregion

        #region Bitmap Position 164
        /// <summary>
        /// Settlement Matching Date : The date by which the participant requires matching of settlement
        /// instructions for settlement of the transaction. Must be included for all
        /// transactions for which the settlement date is known.
        /// 
        /// 651-01 ETC Trade Advice
        /// 652-01 ETC Trade
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SettlementMatchingDate { get; set; }
        #endregion

        #region Bitmap Position 165
        /// <summary>
        /// AI Dividends Franked Amount Taxable : Australian Income: Total taxable amount for franked dividends. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AIDividendsFrankedAmountTaxable { get; set; }

        /// <summary>
        /// Annual Capital Gain Total : Total capital gain for the current financial year. An ATO Tax Statement value. 
        /// 
        /// 959-01 Registry Income Statement Part B
        /// 964-01 Participant Income Statement Part B
        /// </summary>
        public static decimal AnnualCapitalGainTotal { get; set; }

        /// <summary>
        /// Brokerage : The dollar amount of the brokerage associated with a specific contract advice.
        /// 
        /// 653-02 ETC Trade Allocation Advice
        /// 656-02 ETC Trade Allocation
        /// 657-01 Contract Note Advice
        /// 663-01 ETC Settlement Advice
        /// 664-01 Contract Note
        /// 676-01 ETC Settlement
        /// </summary>
        public static decimal Brokerage { get; set; }

        /// <summary>
        /// CG Discount Taxable : Capital Gain: Total taxable reductions made to the taxable Australian property component of capital gain.
        /// An ATO Tax Statement value.
        /// 
        /// 963-01 Registry Income Statement Part C CG
        /// 968-01 Participant Income Statement Part C CG
        /// </summary>
        public static decimal CGDiscountTaxable { get; set; }

        /// <summary>
        /// FI Assessable Income Taxable : Foreign Income: Total taxable amount for foreign sourced income. An ATO Tax Statement value.
        /// 
        /// 965-01 Registry Income Statement Part C FI
        /// 970-01 Participant Income Statement Part C FI
        /// </summary>
        public static decimal FIAssessableIncomeTaxable { get; set; }

        /// <summary>
        /// Franking Credit : Share of franking credit from franked dividends. An ATO Tax Statement value.
        /// 
        /// 957-02Registry Income Statement Part A
        /// 962-02Participant Income Statement Part A
        /// </summary>
        public static decimal FrankingCredit { get; set; }

        /// <summary>
        /// NA Gross Cash : Definition Gross Total: Total gross cash amount for s. An ATO Tax Statement value.
        /// 
        /// 967-02Registry Income Statement Part C NA
        /// 972-02Participant Income Statement Part C NA
        /// </summary>
        public static decimal NAGrossCash { get; set; }

        /// <summary>
        /// OD Net Cash : Net Total: Total net cash amount for s. An ATO Tax Statement value.
        /// 
        /// 969-01 Registry Income Statement Part C OD
        /// 974-01 Participant Income Statement Part C OD
        /// </summary>
        public static decimal ODNetCash { get; set; }
        #endregion

        #region Bitmap Position 166
        /// <summary>
        /// AI Dividends Unfranked Amount Cash : Australian Income: Total net cash amount for unfranked dividends. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AIDividendsUnfrankedAmountCash { get; set; }

        /// <summary>
        /// CG Tax Concession Cash : Capital Gain: Total net cash concessions applicable to the taxable Australian property component of capital gain.
        /// An ATO Tax Statement value.
        /// 
        /// 963-01 Registry Income Statement Part C CG
        /// 968-01 Participant Income Statement Part C CG
        /// </summary>
        public static decimal CGTaxConcessionCash { get; set; }

        /// <summary>
        /// CGT Concession : The amount of CGT (Capital Gains Tax) concession. An ATO Tax Statement value.
        /// 
        /// 959-01 Registry Income Statement Part B
        /// 964-01 Participant Income Statement Part B
        /// </summary>
        public static decimal CGTConcession { get; set; }

        /// <summary>
        /// FI Cash Distribution Cash : Foreign Income: Total net cash amount for cash distributions. An ATO Tax Statement value.
        /// 
        /// 965-01 Registry Income Statement Part C FI
        /// 970-01 Participant Income Statement Part C FI
        /// </summary>
        public static decimal FICashDistributionCash { get; set; }

        /// <summary>
        /// NA Tax Free Amounts Cash : Non Assessable: Total of net cash amount free from taxation. An ATO Tax Statement value.
        /// 
        /// 967-02Registry Income Statement Part C NA
        /// 972-02Participant Income Statement Part C NA
        /// </summary>
        public static decimal NATaxFreeAmountsCash { get; set; }

        /// <summary>
        /// Other Amount : The dollar amount of an unspecified charge payable by the funds/investment manager.
        /// 
        /// 657-01 Contract Note Advice
        /// 664-01 Contract Note
        /// </summary>
        public static decimal OtherAmount { get; set; }

        /// <summary>
        /// TFN Withholding : Share of credit for TFN amounts withheld from interest, dividends
        /// and unit trusts. An ATO Tax Statement value.
        /// 
        /// 957-02Registry Income Statement Part A
        /// 962-02Participant Income Statement Part A
        /// </summary>
        public static decimal TFNWithholding { get; set; }
        #endregion

        #region Bitmap Position 167
        /// <summary>
        /// Recipient Name : Name of the recipient of the contract note.
        /// 
        /// 657-01 Contract Note Advice
        /// 664-01 Contract Note
        /// </summary>
        [StringLength(80, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RecipientName { get; set; }
        #endregion

        #region Bitmap Position 168
        /// <summary>
        /// Member ASX Indicator : Indicates whether the initiator of the contract note is a member of an
        /// exchange. If the initiator is a member of ASX and/or a member of
        /// another exchange, the electronic contract note must be followed up by a paper contract note.
        /// 
        /// Allowable Values 'A' = Member of Australian Stock Exchange (ASX) only
        ///                  ‘B’ = Member of ASX plus other Stock Exchange(s)
        ///                  ‘C’ = Member of Other Stock Exchange(s)
        ///                  'X' = Not a member of any Stock Exchange
        ///                  
        /// 657-01 Contract Note Advice
        /// 664-01 Contract Note
        /// </summary>
        public static readonly char[] MemberASXIndicator = new char[4] { 'A', 'B', 'C', 'X' };
        #endregion

        #region Bitmap Position 169
        /// <summary>
        /// Allocation Cancellation Level : Specifies the level of allocation cancellation that has been carried out 
        /// by the sending fund/investment manager(usually an investment manager).
        /// The sending fund/investment manager can cancel a specific allocation or all allocations associated with a specific [block] trade.
        /// 
        /// Allowable Values 'C' = Cancellation of a specific allocation
        ///                  'T' = Cancellation of all allocations associated with a specific [block] trade
        ///                  
        /// 661-01 Allocation Cancellation Advice
        /// 672-01 Allocation Cancellation
        /// </summary>
        public static readonly char[] AllocationCancellationLevel = new char[2] { 'C', 'T' };

        /// <summary>
        /// Contract Note Rejection Level : Specifies the level of rejection that has been carried out by the sending fund/investment manager
        /// (usually an investment manager). The sending fund/investment manager can reject a specific contract
        /// or all contracts associated with a specific [block] trade.
        /// 
        /// Allowable Values 'C' = Rejection of a specific contract
        ///                  'T' = Rejection of all contracts associated with a specific [block] trade
        ///                  
        /// 659-01 Contract Note Rejection Advice
        /// 668-01 Contract Note Rejection
        /// </summary>
        public static readonly char[] ContractNoteRejectionLevel = new char[2] { 'C', 'T' };
        #endregion

        #region Bitmap Position 170
        /// <summary>
        /// Deliver/Receive Units Indicator : Identifies whether the party that is the target (eg as specified in the associated ETC Target UIC)
        /// of this message is to deliver or receive a specified number of securities.
        /// 
        /// Allowable Values 'D' = Target entity is to deliver securities
        ///                  'R' = Target entity is to receive securities
        ///                  
        /// 663-01 ETC Settlement Advice
        /// 676-01 ETC Settlement
        /// </summary>
        public static readonly char[] Deliver_ReceiveUnitsIndicator = new char[2] { 'D', 'R' };
        #endregion

        #region Bitmap Position 171

        #endregion

        #region Bitmap Position 172
        /// <summary>
        /// Remarks : Extra comments, special instructions, etc. that should appear on the contract note.
        /// 
        /// 657-01 Contract Note Advice
        /// 664-01 Contract Note
        /// </summary>
        [StringLength(40, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Remarks { get; set; }
        #endregion

        #region Bitmap Position 173
        /// <summary>
        /// Holder Status Change : Indicates the required status of a holder and the reason for that status change.
        /// Allowable Values ‘B’ = Notified as Bankrupt - Lock Holder
        ///                  ‘C’ = Cancel Holder
        ///                  ‘D’ = Notified as Deceased - Lock Holder
        ///                  ‘E’ = Bankrupt - Release Holder Lock
        ///                  ‘R’ = Deceased - Release Holder Lock
        ///                  ‘Y’ = Error - Release Holder Lock
        ///                  
        /// 203-04 Registration Details Update Request
        /// </summary>
        public static readonly char[] HolderStatusChange = new char[6] { 'B', 'C', 'D', 'E', 'R', 'Y' };
        #endregion

        #region Bitmap Position 174
        /// <summary>
        /// Holder Status : Identifies the current status of a CHESS holder. Determines the transactions permitted on the holders’ CHESS holdings.
        /// 
        /// Allowable Values ‘A’ = Normal
        ///                  ‘B’ = Notified as bankrupt - Holder Locked
        ///                  ‘C’ = Cancelled
        ///                  ‘D’ = Notified as deceased - Holder Locked
        ///                  ‘E’ = Bankrupt - Holder Lock released 
        ///                  ‘H’ = Non-specific Holder Lock 
        ///                  ‘L’ = Holding Lock applied (512-Holding Registration Details only) 
        ///                  ‘M’ = Holding Lock released (512-Holding Registration Details only) 
        ///                  ‘O’ = Subject of Court Order - Holder Locked
        ///                  ‘R’ = Deceased - Holder Lock released 
        ///                  ‘U’ = Unauthorised
        ///                  ‘X’ = Action by ASX Clear - Holder Locked
        ///                  
        /// 220-02 Authorised Registration Details
        /// 222-04 Holder Detail
        /// 224-03 Holder History
        /// 512-04 Holding Registration Details
        /// 692-01 Controlling PID and Holder Status Response
        /// </summary>
        public static readonly char[] HolderStatus = new char[12] { 'A', 'B', 'C', 'D', 'E', 'H', 'L', 'M', 'O', 'R', 'U', 'X' };
        #endregion

        #region Bitmap Position 175
        /// <summary>
        /// Residency Indicator : Indicates the residency of the holder for securities subject to CHESS foreign ownership restrictions.
        /// 
        /// Allowable Values ‘D' = Domestic
        ///                  'F' = Foreign
        ///                  'M' = Mixed
        ///                  
        /// 201-04 New Registration Details
        /// 203-04 Registration Details Update Request
        /// 220-02 Authorised Registration Details
        /// 222-04 Holder Detail
        /// 224-03 Holder History
        /// 512-04 Holding Registration Details
        /// 560-01 Top Security Holder Report
        /// 844-01 Top Security Fund Holder Report
        /// </summary>
        public static readonly char[] ResidencyIndicator = new char[3] { 'D', 'F', 'M' };

        /// <summary>
        /// Receiving Residency Indicator : Indicates the residency of the holder for securities subject to CHESS foreign ownership restrictions.
        /// 
        /// Allowable Values ‘D' = Domestic
        ///                  'F' = Foreign
        ///                  'M' = Mixed
        /// 
        /// Cross Reference
        #region Cross Reference
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //054-04 Full CHESS to Certificated Transfer
        //058-03 Full Certificated to CHESS Conversion
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //414-04 CHESS to Certificated Transfer
        //418-04 CHESS to Issuer Sponsored Transfer
        #endregion Cross Reference End
        /// </summary>
        public static readonly char[] ReceivingResidencyIndicator = new char[3] { 'D', 'F', 'M' };
        #endregion

        #region Bitmap Position 176
        /// <summary>
        /// Guaranteed Foreign Indicator : Indicates whether the transaction is to be processed as a foreign to foreign transaction
        /// for securities subject to CHESS foreign ownership restrictions.
        /// 
        /// Allowable Values ‘OR’ = Overseas Resident (Foreign to Foreign)
        /// 
        /// Cross Reference
        #region Cross Reference
        //001-02 Demand Single Entry CHESS to CHESS Transfer Request
        //003-02 Transferor Submitted Demand Transfer
        //005-03 Demand Dual Entry CHESS to CHESS Transfer Request
        //007-03 Demand CHESS to Issuer Sponsored Transfer Request
        //009-03 Demand CHESS to Certificated Transfer Request
        //010-03 Applied Transferor Submitted Transfer
        //011-02 CHESS to Issuer Sponsored Conversion Request
        //012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
        //013-02 CHESS to Certificated Conversion Request
        //015-03 Issuer Sponsored to CHESS Transfer Request
        //017-03 Issuer Sponsored to CHESS Conversion Request
        //019-02 Certificated to CHESS Conversion Request
        //021-02 Certificated to CHESS Transfer Request
        //052-03 Full Dual Entry CHESS to CHESS Transfer
        //054-04 Full CHESS to Certificated Transfer
        //056-03 Full Certificated to CHESS Transfer
        //058-03 Full Certificated to CHESS Conversion
        //060-03 Full Issuer Sponsored to CHESS Transfer
        //062-03 Full Issuer Sponsored to CHESS Conversion
        //068-04 Full CHESS to Issuer Sponsored Transfer
        //070-03 Full CHESS to Certificated Conversion
        //072-03 Full CHESS to Issuer Sponsored Conversion
        //074-03 Full Single Entry CHESS to CHESS Transfer
        //090-03 Full Transferor Submitted Demand Transfer
        //101-02 Dual Entry Settlement Notification
        //102-02 Unmatched Dual Entry Settlement Notification
        //105-02 Single Entry Settlement CHESS to CHESS Transfer Request
        //107-01 Scheduled Settlement CHESS to CHESS Transfer Request
        //142-02 Accrued Settlement Instruction
        //146-03 Effected Net Settlement Movement
        //180-02 Full Settlement Instruction
        //402-02 Certificated to CHESS Conversion Authorisation Request
        //404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
        //406-02 Certificated to CHESS Transfer Authorisation Request
        //408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
        //412-03 CHESS to Certificated Conversion
        //414-04 CHESS to Certificated Transfer
        //416-03 CHESS to Issuer Sponsored Conversion
        //418-04 CHESS to Issuer Sponsored Transfer
        //481-01 RTGS Dual Entry Notification
        //482-01 Unmatched RTGS Dual Entry Notification
        //754-01 RTGS Settlement Movement
        //890-01 Scheduled STP Transfer
        #endregion Cross Reference End
        /// </summary>
        public static string GuaranteedForeignIndicator { get; set; } = "OR";

        /// <summary>
        /// Previous Guaranteed Foreign Indicator : Indicates the status of the foreign guarantee indicator before it was altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PreviousGuaranteedForeignIndicator { get; set; }
        #endregion

        #region Bitmap Position 177
        /// <summary>
        /// Revised Guaranteed Foreign Indicator : Indicates the status of the foreign guarantee indicator after it has been altered.
        /// 
        /// 128-02 Adjusted Settlement Instruction
        /// 188-02 Full Adjusted Settlement Instruction
        /// </summary>
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RevisedGuaranteedForeignIndicator { get; set; }
        #endregion

        #region Bitmap Position 178
        /// <summary>
        /// Takeover Acceptance Removal Reason : Indicates the reason for the takeover acceptance removal request.
        /// 
        /// Allowable Values ‘A’ = Legal Entitlement
        /// 
        /// 085-02 Takeover Acceptance Removal Request
        /// 092-01 Offeror Takeover Acceptance Removal Notification
        /// 702-02 Takeover Acceptance Removal Authorisation Request
        /// 707-01 Offeror Takeover Acceptance Removal
        /// </summary>
        public static readonly char[] TakeoverAcceptanceRemovalReason = new char[1] { 'A' };
        #endregion

        #region Bitmap Position 179
        /// <summary>
        /// Holder Lock Release Reason : Indicates the reason for a request to change the status of a holder.
        /// 
        /// Allowable Values ‘A’ = Annulment
        ///                  ‘G’ = Grant of Probate or Letters of Administration
        ///                  ‘L’ = Legal Trustee request
        ///                  ‘N’ = No holdings
        ///                  ‘S’ = Small Estate Statement and Indemnity
        ///                  ‘T’ = Transfer Indemnity Bond
        ///                  
        /// 203-04 Registration Details Update Request
        /// </summary>
        public static readonly char[] HolderLockReleaseReason = new char[6] { 'A', 'G', 'L', 'N', 'S', 'T' };

        /// <summary>
        /// Registration Details Update Reason : Indicates the reason for the registration detail update.
        /// 
        /// Allowable Values ‘A’ = Participant request
        ///                  ‘B’ = Market Support
        ///                  ‘C’ = ASX Clear Registration Address Standardisation
        ///                  
        /// 220-02 Authorised Registration Details
        /// </summary>
        public static readonly char[] RegistrationDetailsUpdateReason = new char[3] { 'A', 'B', 'C' };
        #endregion

        #region Bitmap Position 180
        /// <summary>
        /// Net Position Activity Flag : Indicates whether the Net Position Record is active or inactive. This
        /// value is determined at set-up of a Net Position Record and may be
        /// modified from Active to Inactive or vice versa. Modification requests
        /// may only be submitted and processed between CHESS RTGS End
        /// of Business Day and normal End of Day.
        /// 
        /// Allowable Values ‘A’ = Active
        ///                  ‘I’ = Inactive
        ///                  
        /// 371-01 Change Net Position Attributes Request
        /// 372-01 Changed Net Position Attributes Notification
        /// </summary>
        public static readonly char[] NetPositionActivityFlag = new char[2] { 'A', 'I' };

        /// <summary>
        /// Update Guaranteed Foreign Indicator : Adds or deletes the Guaranteed Foreign Indicator to a scheduled
        /// settlement instruction for securities subject to CHESS foreign ownership restrictions.
        /// 
        /// Allowable Values ‘A’ = Add Indicator
        ///                  ‘D’ = Delete Indicator
        ///                  
        /// 121-02 Change Settlement Instruction Request
        /// 130-02 Requested Settlement Instruction Change
        /// 480-01 Requested RTGS Instruction Change
        /// 489-01 Change RTGS Instruction Request
        /// </summary>
        public static readonly char[] UpdateGuaranteedForeignIndicator = new char[2] { 'A', 'D' };
        #endregion

        #region Bitmap Position 181
        /// <summary>
        /// AI Dividends Unfranked Amount Taxable : Australian Income: Total taxable amount of unfranked dividends. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AIDividendsUnfrankedAmountTaxable { get; set; }

        /// <summary>
        /// Annual Capital Gain : Total capital gain for the current financial year. An ATO Tax Statement value.
        /// 
        /// 957-02Registry Income Statement Part A
        /// 962-02Participant Income Statement Part A
        /// </summary>
        public static decimal AnnualCapitalGain { get; set; }

        /// <summary>
        /// CG Tax Concession Taxable : Capital Gain: Total taxable concessions applicable to the taxable Australian property component of capital gain.
        /// An ATO Tax Statement value.
        /// 
        /// 963-01 Registry Income Statement Part C CG
        /// 968-01 Participant Income Statement Part C CG
        /// </summary>
        public static decimal CGTaxConcessionTaxable { get; set; }

        /// <summary>
        /// Current or New Debit Cap Limit : Indicates current or new debit cap limit amount where a change to Net Position Record is required.
        /// 
        /// 371-01 Change Net Position Attributes Request
        /// 372-01 Changed Net Position Attributes Notification
        /// </summary>
        public static decimal CurrentorNewDebitCapLimit { get; set; }

        /// <summary>
        /// Debit Cap Limit : The debit cap is an RTGS related structure which may be active or
        /// inactive on a Net Position Record. The debit cap limit is the net total
        /// amount of a participant’s pending and finalised debits, and finalised
        /// credits, for transactions targeting a Cash Subrecord associated with
        /// that Net Position Record, which is not allowed to exceed the limit.
        /// This value is specified at the time of Net Position Record set-up, and
        /// may be modified intraday by the payment provider. Where this
        /// optional value is not specified at set up and the Debit Cap Activity
        /// Flag is subsequently set to ‘A’ (active), the default value is zero; i.e.
        /// the participant’s transaction obligations may not fall into a debit
        /// amount. Zero is also an allowable value at set-up.
        /// 
        /// 341-01 Create Net Position Request
        /// 342-01 Create Net Position Record Authorisation Request
        /// </summary>
        public static decimal DebitCapLimit { get; set; }

        /// <summary>
        /// FI Cash Distribution Tax : Foreign Income: Total tax paid or tax offset for cash distributions. An ATO Tax Statement value.
        /// 
        /// 965-01 Registry Income Statement Part C FI
        /// 970-01 Participant Income Statement Part C FI
        /// </summary>
        public static decimal FICashDistributionTax { get; set; }

        /// <summary>
        /// Tax Deferred : The amount of tax deferred. An ATO Tax Statement value.
        /// 
        /// 959-01 Registry Income Statement Part B
        /// 964-01 Participant Income Statement Part B
        /// </summary>
        public static decimal TaxDeferred { get; set; }
        #endregion

        #region Bitmap Position 182
        /// <summary>
        /// Debit Cap Activity Flag : Indicates whether the debit cap on a Net Position Record is active or inactive.
        /// This value is determined at set-up of a Net Position Record and may be modified from Active to Inactive or vice versa intraday.
        /// (Debit Cap Limit may be supplied whether the Debit Cap Activity Flag is Active or Inactive.)
        /// 
        /// Allowable Values ‘A’ = Active
        ///                  ‘I’ = Inactive
        ///                  
        /// 341-01 Create Net Position Request
        /// 342-01 Create Net Position Record Authorisation Request
        /// 371-01 Change Net Position Attributes Request
        /// 372-01 Changed Net Position Attributes Notification
        /// </summary>
        public static readonly char[] DebitCapActivityFlag = new char[2] { 'A', 'I' };
        #endregion

        #region Bitmap Position 183

        #endregion

        #region Bitmap Position 184
        /// <summary>
        /// BIC : SWIFT identification code for a payment provider, supplied upon submission of an authorisation request for creation of a client
        /// participant’s Net Position Record. This value is used by CHESS when submitting settlement requests to RITS for RTGS settlement.
        /// 
        /// Allowable Values This field must comprise the following:
        ///                  chars 1-4 SWIFT allocated payment provider (financial institution) Code
        ///                  5-6 Country Code
        ///                  7-8 Location Code
        ///                  9-11 Branch code or XXX if no branch code is defined
        ///                  12 Space
        ///                  
        /// 343-01 Create Net Position Authorisation
        /// </summary>
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string BIC { get; set; }
        #endregion

        #region Bitmap Position 185
        /// <summary>
        /// Cash Subrecord ID : A value which stands for an actual account maintained for the Participant by the payment provider sponsoring the Participant to
        /// participate in RTGS settlement. This value is only used in Participant messaging with CHESS once, when the Cash Subrecord is set up.
        /// The Cash Subrecord ID must begin with the BSB (6 numeric). The remainder of the Cash Subrecord iD is composed of up to 29 characters.
        /// (Cash Account Identifier is the account reference used between the Participant and CHESS. Cash Subrecord ID is the account reference used between 
        /// the payment provider and CHESS.) Currently RITS is limited to 19 characters only
        /// 
        /// 351-01 Create Cash Subrecord Request
        /// 352-01 Create Cash Subrecord Authorisation Request
        /// 353-01 Create Cash Subrecord Authorisation
        /// 356-01 Effected Create Cash Subrecord
        /// 357-01 Create Cash Subrecord Rejection
        /// 360-01 Rejected Create Cash Subrecord
        /// 373-01 Payment Provider Change Cash Subrecord Attributes Request
        /// 377-01 Participant Change Cash Subrecord Attributes Authorisation
        /// 379-01 Participant Change Cash Subrecord Attributes Rejection
        /// 380-01 Participant Change Cash Subrecord Attributes Authorisation Request
        /// 614-01 Cash Subrecord Details
        /// 616-01 Cash Subrecord Total
        /// </summary>
        [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string CashSubrecordID { get; set; }
        #endregion

        #region Bitmap Position 186
        /// <summary>
        /// Cash Subrecord Type : Identifies whether the Cash Subrecord is the default Cash Subrecord which CHESS will apply for buy RTGS transactions,
        /// or the default Cash Subrecord which CHESS will apply for sell RTGS transactions, or a nominated Cash Subrecord.
        /// A Cash Subrecord must be designated as either default, a common buy and sell default, or neither default.
        /// A maximum of one sell default type Cash Subrecord and one buy default type Cash Subrecord (or one common default)
        /// can be nominated for a given Net Position Record.
        /// 
        /// Allowable Values ‘B’ = Default buy
        ///                  ‘C’ = Common default: both buy and sell
        ///                  ‘N’ = Nominated: neither buy nor sell
        ///                  ‘S’ = Default sell
        ///                  
        /// 351-01 Create Cash Subrecord Request
        /// 352-01 Create Cash Subrecord Authorisation Request
        /// 375-01 Participant Change Cash Subrecord Attributes Request
        /// 380-01 Participant Change Cash Subrecord Attributes Authorisation Request
        /// </summary>
        public static readonly char[] CashSubrecordType = new char[4] { 'B', 'C', 'N', 'S' };
        #endregion

        #region Bitmap Position 187
        /// <summary>
        /// Debit Cap Exclusion Flag : Identifies whether the Cash Subrecord is included or excluded from RTGS debit cap consideration
        /// when credit and debit amounts on transactions targeting this Cash Subrecord are added to available credit.
        /// Only effective where the debit cap is Active.
        /// 
        /// Allowable Values ‘X’ = Exclude
        ///                  ‘I’ = Include
        /// </summary>
        public static readonly char[] DebitCapExclusionFlag = new char[2] { 'X', 'I' };
        #endregion

        #region Bitmap Position 188
        /// <summary>
        /// Movement Type : Indicates whether securities have been reserved for the RTGS
        /// settlement instruction pending successful funds movement at RITS;
        /// securities have been transferred following successful settlement; or
        /// securities have been unreserved due to unsuccessful funds
        /// movement at RITS resulting from participant-initiated cancellation,
        /// ASX Clear-initiated recall, or end-of-day RTGS settlement failure of
        /// the scheduled settlement instruction.
        /// 
        /// Allowable Values ‘R’ = Unit reservation
        ///                  ‘S’ = Effected settlement
        ///                  ‘V’ = Unit reservation reversal
        ///                  
        /// 754-01 RTGS Settlement Movement
        /// </summary>
        public static readonly char[] MovementType = new char[3] { 'R', 'S', 'V' };
        #endregion

        #region Bitmap Position 189
        /// <summary>
        /// Schedule Transaction for Settlement : Indicates whether the submitting participant wishes the settlement
        /// instruction, once matched, to enter active RTGS processing
        /// immediately upon settlement date, or does not wish the transaction
        /// to be scheduled for settlement until they submit, later on that
        /// settlement date, an authorisation message.
        /// 
        /// Allowable Values ‘Y ‘ = yes, schedule transaction for immediate RTGS settlement
        ///                  ‘N’ = no, do not schedule the transaction for immediate RTGS settlement)
        ///                  
        /// 444-01 Unmatched Change Settlement Type Request
        /// 448-01 Adjusted Settlement Type
        /// 481-01 RTGS Dual Entry Notification
        /// 484-01 Unmatched RTGS Dual Entry Request
        /// 493-01 Maintain RTGS Instruction Request
        /// 497-01 Settlement Type Change Request
        /// </summary>
        public static readonly char[] ScheduleTransactionforSettlement = new char[2] { 'Y', 'N' };
        #endregion

        #region Bitmap Position 190
        /// <summary>
        /// Destination Settlement System : Identifies the settlement system to which a scheduled settlement instruction is to be 
        /// ‘switched’ from its current settlement system. Examples are net batch processing, and Real Time Gross 
        /// Settlement (RTGS) settlement systems within CHESS.
        /// 
        /// Allowable Values ‘N’ = Net batch processing
        ///                  ‘R’ = RTGS
        ///                  
        /// 410-01 Requested Settlement Type Change
        /// 444-01 Unmatched Change Settlement Type Request
        /// 497-01 Settlement Type Change Request
        /// </summary>
        public static readonly char[] DestinationSettlementSystem = new char[2] { 'X', 'I' };

        /// <summary>
        /// Nett or Gross : Indicates whether the values presented are Nett or Gross
        /// 
        /// Allowable Values 'N' = Nett
        ///                  'G' = Gross
        ///                  
        /// 800-02Redemption Request
        /// 801-02Redemption Order Request
        /// 802-02Redemption Order Response
        /// 803-02Effected Redemption Order Request
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// 808-02Switch Order Response
        /// 809-02Effected Switch Order Request
        /// </summary>
        public static readonly char[] NettorGross = new char[2] { 'N', 'G' };

        /// <summary>
        /// Previous Destination Settlement System : Identifies the settlement system to which a scheduled settlement
        /// instruction had belonged prior to submission of a successful
        /// matched request to change settlement type.
        /// 
        /// Allowable Values ‘N’ = Net batch processing
        ///                  ‘R’ = RTGS
        ///                  
        /// 448-01 Adjusted Settlement Type
        /// </summary>
        public static readonly char[] PreviousDestinationSettlementSystem = new char[2] { 'N', 'R' };

        /// <summary>
        /// Revised Destination Settlement System : Identifies the settlement system to which a scheduled settlement
        /// instruction now belongs, following processing of matched requests to
        /// change settlement type.
        /// 
        /// Allowable Values ‘N’ = net batch processing
        ///                  ‘R’ = RTGS
        ///                  
        /// 448-01 Adjusted Settlement Type
        /// </summary>
        public static readonly char[] RevisedDestinationSettlementSystem = new char[2] { 'N', 'R' };
        #endregion

        #region Bitmap Position 191
        /// <summary>
        /// Redemption Request Reason : The reason for the redemption request.
        /// 
        /// Allowable Values ‘C’ = Cooling Off Period
        ///                  ‘R’ = Fund Unit Redemption
        ///                  
        /// 800-02 Redemption Request
        /// 801-02Redemption Order Request
        /// </summary>
        public static readonly char[] RedemptionRequestReason = new char[2] { 'C', 'R' };
        #endregion

        #region Bitmap Position 192

        #endregion

        #region Bitmap Position 193

        #endregion

        #region Bitmap Position 194
        /// <summary>
        /// Bid Time : Actual time at which the Bid Price was generated.
        /// 
        /// Allowable Values A valid time in the format of HHMMSS
        /// 
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string BidTime { get; set; }

        /// <summary>
        /// Payer Clearing Member : Identifies the clearing participant (or ASX Clear) that is paying funds in the daily settlement obligation.
        /// 
        /// Allowable Values Any value allocated by ASX to identify a clearing participant (or ASX Clear).
        /// 
        /// 551-01 Aggregated Payment Request
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PayerClearingMember { get; set; }
        #endregion

        #region Bitmap Position 195
        /// <summary>
        /// Payer Payment Category : Identifies the account type from which the payment is made.
        /// 
        /// Allowable Values ‘OPT ’ = Options account (House and Client accounts administratively netted).
        ///                  ‘FUTH’ = Futures House account
        ///                  ‘FUTC’ = Futures Client account
        ///                  
        /// 551-01 Aggregated Payment Request
        /// </summary>
        [StringLength(4, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] PayerPaymentCategory = new string[] { "OPT ", "FUTH", "FUTC" };

        /// <summary>
        /// Serial Trade Qualifier : Specifically assists in the identification of trades.
        /// 
        /// Allowable Values Note: For Approved Market Operators (AMO) other than the
        /// ASX the first position of this field will be an assigned value of A
        /// through to Z. A unique value will relate to a specific AMO.
        /// 
        /// 161-02 Trade Registration Request
        /// </summary>
        [StringLength(4, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SerialTradeQualifier { get; set; }
        #endregion

        #region Bitmap Position 196
        /// <summary>
        /// Ask Time : Actual time in which the Ask Price was generated.
        /// 
        /// Allowable Values A valid time in the format of HHMMSS
        /// 
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AskTime { get; set; }

        /// <summary>
        /// Payee Clearing Member : Identifies the clearing participant (or ASX Clear) that is receiving funds in the daily settlement obligation.
        /// 
        /// Allowable Values Any value allocated by ASX to identify a clearing participant (or ASX Clear).
        /// 
        /// 551-01 Aggregated Payment Request
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PayeeClearingMember { get; set; }

        /// <summary>
        /// Trade Serial Number : A unique sales slip number generated by the AMOs trading
        /// platform. Note: This trade serial number is to be unique during
        /// the current business day.
        /// 
        /// 161-02 Trade Registration Request
        /// </summary>
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TradeSerialNumber { get; set; }
        #endregion

        #region Bitmap Position 197
        /// <summary>
        /// Payee Payment Category : Identifies the account type to which the payment is made.
        /// 
        /// Allowable Values ‘OPT ’ = Options account (House and Client accounts administratively netted).
        ///                  ‘FUTH’ = Futures House account
        ///                  ‘FUTC’ = Futures Client account
        ///                  
        /// 551-01 Aggregated Payment Request
        /// </summary>
        [StringLength(4, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] PayeePaymentCategory = new string[] { "OPT ", "FUTH", "FUTC" };
        #endregion

        #region Bitmap Position 198
        /// <summary>
        /// Total Payment Records : The number of ‘Aggregated Payment Request’ messages submitted in the same ‘Payment Set’.
        /// </summary>
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TotalPaymentRecords { get; set; }
        #endregion

        #region Bitmap Position 199
        /// <summary>
        /// Bid Price : The price in which someone is prepared to buy the security.
        /// 
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        public static decimal BidPrice { get; set; }

        /// <summary>
        /// Trade Price : The price at which the trade was executed on the AMO’s trading platform.
        /// 
        /// 161-02 Trade Registration Request
        /// </summary>
        public static decimal TradePrice { get; set; }
        #endregion

        #region Bitmap Position 200
        /// <summary>
        /// Email Address : An Email address specified for a HIN.
        /// 
        /// 201-04 New Registration Details
        /// 203-04 Registration Details Update Request
        /// 222-04 Holder Detail
        /// 224-03 Holder History
        /// 512-04 Holding Registration Details
        /// 716-01 CHESS Conversion Request to Issuer Sponsored Fund
        /// </summary>
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string EmailAddress { get; set; }

        /// <summary>
        /// Application Product Name : The name used to define a Fund targeted for Fund applications
        /// 
        /// 806-01Switch Request
        /// 806-02Switch Request
        /// 807-01Switch Order Request
        /// 807-02Switch Order Request
        /// </summary>
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ApplicationProductName { get; set; }

        /// <summary>
        /// Investor Email Address : An Email address specified for an investor.
        /// 
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string InvestorEmailAddress { get; set; }
        #endregion

        #region Bitmap Position 201
        /// <summary>
        /// BSB Number : The Bank/State/Branch identifying the financial institution at which a bank account is held.
        /// 
        /// 757-02 Holding Advice
        /// 760-02 Holding Advice Notification
        /// 863-01 Distribution Election Request
        /// 864-01 Distribution Election Authorisation Request
        /// </summary>
        [RegularExpression("/[0-9]{3}-?[0-9]{3}/", ErrorMessage = "Invalid BSB number.")]
        [StringLength(7, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string BSBNumber { get; set; }
        #endregion

        #region Bitmap Position 202
        /// <summary>
        /// FI Code : The code of the financial institution at which a Bank Account is held.
        /// 
        /// 760-02 Holding Advice Notification
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string FICode { get; set; }
        #endregion

        #region Bitmap Position 203
        /// <summary>
        /// Account Number : A number used to identify the Bank Account of an entity held by a financial institution.
        /// 
        /// 757-02 Holding Advice
        /// 760-02 Holding Advice Notification
        /// 863-01 Distribution Election Request
        /// 864-01 Distribution Election Authorisation Request
        /// </summary>
        [StringLength(9, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AccountNumber { get; set; }
        #endregion

        #region Bitmap Position 204
        /// <summary>
        /// Account Name : A name used to identify the Bank Account of an entity held by a financial institution.
        /// This is the standard APCA direct credit format.
        /// 
        /// 757-02 Holding Advice
        /// 760-02 Holding Advice Notification
        /// 863-01 Distribution Election Request
        /// 864-01 Distribution Election Authorisation Request
        /// </summary>
        [StringLength(32, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AccountName { get; set; }
        #endregion

        #region Bitmap Position 205
        /// <summary>
        /// Account Purpose : The purpose for which this Bank Account may be used by an issuer registry.
        /// 
        /// Allowable Values ‘E’ = Electronic Direct Credit
        /// 
        /// 757-02 Holding Advice
        /// 760-02 Holding Advice Notification
        /// 863-01 Distribution Election Request
        /// 864-01 Distribution Election Authorisation Request
        /// </summary>
        public static readonly char AccountPurpose = 'E';
        #endregion

        #region Bitmap Position 206
        /// <summary>
        /// Account Cancellation : Denotes that the nominated Bank Account is to be cancelled.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  Blank
        ///                  
        /// 757-02 Holding Advice
        /// 760-02 Holding Advice Notification
        /// </summary>
        public static readonly char? AccountCancellation = 'Y';

        /// <summary>
        /// RPP Frequency : Identifies the frequency with which an investor wishes to invest in additional units. Do not populate.
        /// 
        /// Allowable Values ‘W’ = Weekly
        ///                  ‘M’ = Monthly
        ///                  ‘Q’ = Quarterly
        ///                  
        /// 863-01 Distribution Election Request
        /// 864-01 Distribution Election Authorisation Request
        /// </summary>
        public static readonly char[] RPPFrequency = new char[3] { 'W', 'M', 'Q' };
        #endregion

        #region Bitmap Position 207
        /// <summary>
        /// Interest Description : A description applying to interest.
        /// 
        /// Allowable Values This field allows the input of free text.
        /// Some examples of Interest Descriptions may include descriptions similar to the following:
        ///                  “Excess Cash”
        ///                  “Cash used to cover AUD IM”
        ///                  “Adjustment applied due to incorrect values previously being notified”.
        ///                  
        /// 911-01 Daily Interest Earned Notification
        /// 940-01 Daily Interest Earned Statement
        /// </summary>
        [StringLength(129, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string InterestDescription { get; set; }
        #endregion

        #region Bitmap Position 208
        /// <summary>
        /// Email Purpose : The purpose for which an Email address may be used by an issuer registry.
        /// 
        /// Allowable Values ‘A’ = Preference for all electronic communication
        ///                  ‘B’ = Preference for electronic ASX Settlement communication
        ///                  ‘C’ = Preference for all electronic Issuer communication
        ///                  
        /// 201-04 New Registration Details
        /// 203-04 Registration Details Update Request
        /// 222-04 Holder Detail
        /// 224-03 Holder History
        /// 512-04 Holding Registration Details
        /// 716-01 CHESS Conversion Request to Issuer Sponsored Fund
        /// </summary>
        public static readonly char[] EmailPurpose = new char[3] { 'A', 'B', 'C' };

        /// <summary>
        /// Investor Email Purpose : The purpose for which an Email address may be used.
        /// 
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        public static readonly char[] InvestorEmailPurpose = new char[3] { 'A', 'B', 'C' };
        #endregion

        #region Bitmap Position 209
        /// <summary>
        /// Email Cancellation : Indicates that the existing Email Address must be removed from the Holder’s record.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  Blank
        /// 
        /// 203-04 Registration Details Update Request
        /// 512-04 Holding Registration Details
        /// </summary>
        public static readonly char? EmailCancellation = 'Y';

        /// <summary>
        /// AML/CTF Check Flag : Indicates that the appropriate AML (Anti-Money Laundering) and CTF (Counter Terrorism Financing) checks
        /// have been conducted by the Sponsoring Participant
        /// 
        /// Allowable Values 'Y' = Yes
        ///                  'N' = No
        ///                  
        /// 726-02 Application Request
        /// 727-02 Application Order Request
        /// 800-02Redemption Request
        /// 801-02Redemption Order Request
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// </summary>
        public static readonly char[] AML_CTFFlag = new char[2] { 'Y', 'N' };
        #endregion

        #region Bitmap Position 210
        /// <summary>
        /// Rejected Holding Advice Reason : The reason the registry has rejected a holder advice request.
        /// 
        /// Allowable Values 'B' = Issuer does not support electronic direct credit
        ///                  'D' = Cancellation Bank Account details do not match recorded Bank Account details
        ///                  ‘H’ = Failed requirements for Bank A/C structure or format
        ///                  
        /// 761-01 Holding Advice Rejection
        /// 766-01 Rejected Holding Advice
        /// </summary>
        public static readonly char[] RejectedHoldingAdviceReason = new char[3] { 'B', 'D', 'H' };

        /// <summary>
        /// FATCA Questions : Indicates that the appropriate FATCA checks have been conducted by the Sponsoring Participant
        /// 
        /// Allowable Values 1 = Not Applicable
        ///                  2 = US Citizen or US Tax Resident
        ///                  3 = Entity other than a Superannuation Fund
        ///                  
        /// 800-01Redemption Request
        /// 801-01Redemption Order Request
        /// 806-01Switch Request
        /// 807-01Switch Order Request
        /// </summary>
        public static readonly char[] FATCAQuestions = new char[3] { '1', '2', '3' };

        /// <summary>
        /// Novation Indicator : Identifies the novation status of a cash market transaction
        /// 
        /// Allowable Values “N” – Non-Novated Transaction
        ///                  “Y” – Novated Transaction
        ///                  
        /// 164-03 Notified Trade
        /// </summary>
        public static readonly char[] NovationIndicator = new char[2] { 'N', 'Y' };
        #endregion

        #region Bitmap Position 211
        /// <summary>
        /// Ask Price : The price in which someone is prepared to sell the security.
        /// 
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        public static decimal AskPrice { get; set; }
        #endregion

        #region Bitmap Position 212
        /// <summary>
        /// First Trade Price : The price of the first on market trade for current business day for the specified security.
        /// 
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string FirstTradePrice { get; set; }
        #endregion

        #region Bitmap Position 213
        /// <summary>
        /// Highest Trade Price : The highest price at which the security has been sold on the market for the current business day.
        /// 
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string HighestTradePrice { get; set; }
        #endregion

        #region Bitmap Position 214
        /// <summary>
        /// Lowest Trade Price : The lowest price at which the security has been traded on the market for the current business day.
        /// 
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string LowestTradePrice { get; set; }
        #endregion

        #region Bitmap Position 215
        /// <summary>
        /// Last Trade Price : The last price at which a sale occurred for specified security.
        /// 
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string LastTradePrice { get; set; }
        #endregion

        #region Bitmap Position 216
        /// <summary>
        /// Buyer Order Reference Number : The buying brokers own reference for in-house processing of the trade
        /// (Example: relate a trade to a particular account or client).
        /// 
        /// 093-01 Price Registration
        /// 097-02 Price Notification Registration
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string BuyerOrderReferenceNumber { get; set; }
        #endregion

        #region Bitmap Position 217
        /// <summary>
        /// Dealer Group AFSL Number : Identifies a Dealer Group by their Dealer’s AFSL (Australian Financial Services License) identification number.
        /// 
        /// Allowable Values ‘N/A’ is allowable.
        /// 
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DealerGroupAFSLNumber { get; set; }

        /// <summary>
        /// Seller Order Reference Number : The selling brokers own reference for in-house processing of the trade
        /// (Example: relate a trade to a particular account or client).
        /// 
        /// 161-02 Trade Registration Request
        /// 164-03 Notified Trade
        /// </summary>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string SellerOrderReferenceNumber { get; set; }
        #endregion

        #region Bitmap Position 218
        /// <summary>
        /// Participant Advisor Name : Identifies an advisor by name within a Participant organisation
        /// 
        /// 800-02Redemption Request
        /// 801-02Redemption Order Request
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ParticipantAdvisorName { get; set; }
        #endregion

        #region Bitmap Position 219
        /// <summary>
        /// Participant Advisor Code : Identifies an advisor within a Participant organisation
        /// 
        /// 800-02Redemption Request
        /// 801-02Redemption Order Request
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ParticipantAdvisorCode { get; set; }
        #endregion

        #region Bitmap Position 220
        /// <summary>
        /// Additional Units : The number of units described for Fund adjustments resulting from a DRP
        /// 
        /// 817-01 Distribution Re-investment Notification
        /// 818-01 Effected Distribution Re-investment Plan Advice
        /// </summary>
        public static decimal AdditionalUnits { get; set; }

        /// <summary>
        /// Fund Net Offs : The total unit quantity of holding transactions effected during the processing day that reduced the CHESS Fund holding balance.
        /// 
        /// 831-01 Holding Net Fund Movement
        /// </summary>
        public static decimal FundNetOffs { get; set; }

        /// <summary>
        /// Total Fund Movements Off : The total units subtracted from a CHESS Fund holding during a
        /// business day as a result of an authorised transaction.
        /// 
        /// 844-01 Top Security Fund Holder Report
        /// </summary>
        public static decimal TotalFundMovementsOff { get; set; }
        #endregion

        #region Bitmap Position 221
        /// <summary>
        /// Haircut Rate : The haircut rate that has been applied by ASX Clear in the calculation of the collateral value.
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string HaircutRate { get; set; }

        /// <summary>
        /// Income Amount per Unit : The amount in cents that will be applied to each unit held by a holder as the result of an income distribution payment.
        /// 
        /// 813-01 Income Statement
        /// 816-01 Income Statement Advice
        /// </summary>
        [StringLength(11, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string IncomeAmountperUnit { get; set; }
        #endregion

        #region Bitmap Position 222
        /// <summary>
        /// Order Type : Defines the type of Fund order requested by the user.
        /// 
        /// Allowable Values ‘ADJ’ = Miscellaneous Adjustment
        ///                  ‘APP’ = Application
        ///                  ‘DIS’ = Distribution
        ///                  ‘DRP’ = Distribution Reinvestment Plan
        ///                  ‘RED’ = Redemption
        ///                  ‘RPP’ = Regular Payment Plan
        ///                  ‘SWI’ = Switch
        ///                  
        /// 729-02 Application Order/Payment Plan Application Response
        /// 730-02 Effected Application Order/Payment Plan Application Response
        /// 805-01 Order Cancellation Request
        /// 810-01 Update Order
        /// 811-01 Effected Update Order
        /// 845-02 Unit Reversal Notification
        /// 846-02 Effected Unit Reversal Notification
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static readonly string[] OrderType = new string[7] { "ADJ", "APP", "DIS", "DRP", "RED", "RPP", "SWI" };
        #endregion

        #region Bitmap Position 223
        /// <summary>
        /// On-Market Value : The buy-side on-market value for the current business day
        /// 
        /// 093-01 Price Registration
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string On_MarketValue
        {
            get;
            set;
        }

        /// <summary>
        /// Tax Deducted : The dollar amount of tax deducted from the holder as the result of a Fund distribution payment.
        /// 
        /// 802-02Redemption Order Response
        /// 803-02Effected Redemption Order Request
        /// 808-02Switch Order Response
        /// 809-02Effected Switch Order Request
        /// 813-01 Income Statement
        /// 816-01 Income Statement Advice
        /// 817-01 Distribution Re-investment Notification
        /// 818-01 Effected Distribution Re-investment Plan Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TaxDeducted
        {
            get;
            set;
        }
        #endregion

        #region Bitmap Position 224
        /// <summary>
        /// Income : The designated value of income.
        /// 
        /// 802-02Redemption Order Response
        /// 803-02Effected Redemption Order Request
        /// 808-02Switch Order Response
        /// 809-02Effected Switch Order Request
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Income
        {
            get;
            set;
        }

        /// <summary>
        /// Nett DRP Amount : The nett dollar value of a Fund dividend reinvestment in CHESS.
        /// 
        /// 817-01 Distribution Re-investment Notification
        /// 818-01 Effected Distribution Re-investment Plan Advice
        /// </summary>
        [StringLength(14, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string NettDRPAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Off-Market Value : The buy-side off-market value for the current business day
        /// 
        /// 093-01 Price Registration
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Off_MarketValue
        {
            get;
            set;
        }
        #endregion

        #region Bitmap Position 225
        /// <summary>
        /// Closing Fund Balance : The total unit quantity registered for a CHESS Fund holding at the end of a processing day.
        /// 
        /// 830-01 Holding Daily Fund Balance
        /// 831-01 Holding Net Fund Movement
        /// 844-01 Top Security Fund Holder Report
        /// </summary>
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ClosingFundBalance { get; set; }

        /// <summary>
        /// Total Fund Unit Balance : The total unit balance of a particular fund registered on the
        /// CHESS Sub-register NB: represents the total of the total unit
        /// balance of a HIN in a particular fund.
        /// 
        /// 832-01 Holding Fund Balance
        /// </summary>
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TotalFundUnitBalance { get; set; }
        #endregion

        #region Bitmap Position 226
        /// <summary>
        /// Address Details 2 : Describes a residential address for foreign tax purposes for additional parties to Account Type of ‘Joint’.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(180, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AddressDetails2 { get; set; }
        #endregion

        #region Bitmap Position 227
        /// <summary>
        /// Address Details 3 : Describes a residential address for foreign tax purposes for additional parties to Account Type of ‘Joint’.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(180, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AddressDetails3 { get; set; }
        #endregion

        #region Bitmap Position 228

        #endregion

        #region Bitmap Position 229

        #endregion

        #region Bitmap Position 230
        /// <summary>
        /// Fund Net Ons : The total unit quantity of holding transactions effected during the processing day that increased the CHESS Fund holding balance.
        /// 
        /// 831-01 Holding Net Fund Movement
        /// </summary>
        public static decimal FundNetOns { get; set; }

        /// <summary>
        /// Total Fund Movements On : The total units added to a CHESS Fund holding during a
        /// business day as a result of an authorised transaction.
        /// 
        /// 844-01 Top Security Fund Holder Report
        /// </summary>
        public static decimal TotalFundMovementsOn { get; set; }
        #endregion

        #region Bitmap Position 231
        /// <summary>
        /// Current PDS Provided : Indicates that the investor has been provided with the latest copy of the fund PDS
        /// (Product Disclosure Statement), including any supplements, that have been lodged on the ASX website.
        /// Applies to all Application and Switch requests.
        /// 
        /// Allowable Values 'Y' = Yes
        ///                  'N' = No
        ///                  ‘I’ = Not applicable
        ///                  
        /// 726-02 Application Request
        /// 727-02 Application Order Request
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// 863-01 Distribution Election Request
        /// 864-01 Distribution Election Authorisation Request
        /// </summary>
        public static readonly char[] CurrentPDSProvided = new char[3] { 'Y', 'N', 'I' };
        #endregion

        #region Bitmap Position 232
        /// <summary>
        /// Adjustment Units : The number of units described for Fund adjustments
        /// 
        /// 732-02Unit Adjustment
        /// 733-02Effected Fund Unit Adjustment
        /// </summary>
        public static decimal AdjustmentUnits { get; set; }

        /// <summary>
        /// Fund Movement from Registry : The total units added to a CHESS Fund holding during a business day as a result of authorised transactions.
        /// 
        /// 831-01 Holding Net Fund Movement
        /// </summary>
        public static decimal FundMovementfromRegistry { get; set; }

        /// <summary>
        /// Number of Units : The number of units described for Fund applications and redemptions.
        /// 
        /// Cross Reference
        #region Cross Reference
        //715-01 CHESS to Issuer Sponsored Fund Conversion Request
        //716-01 CHESS Conversion Request to Issuer Sponsored Fund
        //717-01 Effected CHESS Conversion to Issuer Sponsored Fund
        //718-02Issuer Sponsored Fund to CHESS Conversion Request
        //719-02Issuer Sponsored Fund to CHESS Conversion Authorisation Request
        //729-02Application Order/Payment Plan Application Response
        //730-02Effected Application Order/Payment Plan Application Response
        //800-02Redemption Request
        //801-02Redemption Order Request
        //802-02Redemption Order Response
        //803-02Effected Redemption Order Request
        //812-01 Reminder Notice
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        //845-02Unit Reversal Notification
        //846-02Effected Unit Reversal Notification
        #endregion Cross Reference End
        /// </summary>
        public static decimal NumberofUnits { get; set; }

        /// <summary>
        /// Total Fund Units on Register : The total units of particular fund registered on the CHESS sub register.
        /// NB: represents the total of the total unit balance of all holdings in a particular fund.
        /// 
        /// 833-01 Total Security Fund Balance
        /// </summary>
        public static decimal TotalFundUnitsonRegister { get; set; }

        /// <summary>
        /// Units Participating : The number of Fund units for a holder that are eligible for Fund distribution payments.
        /// 
        /// 813-01 Income Statement
        /// 816-01 Income Statement Advice
        /// 817-01 Distribution Re-investment Notification
        /// 818-01 Effected Distribution Re-investment Plan Advice
        /// </summary>
        public static decimal UnitsParticipating { get; set; }

        /// <summary>
        /// Units Redeemed : The number of units described for Fund redemptions.
        /// 
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// 808-02Switch Order Response
        /// 809-02Effected Switch Order Request
        /// </summary>
        public static decimal UnitsRedeemed { get; set; }
        #endregion

        #region Bitmap Position 233
        /// <summary>
        /// Fund Holding Balance : The unit balance of a holding in a particular fund.
        /// 
        /// 839-01 Registry to CHESS Fund Balance Response
        /// 840-01 CHESS to Participant Fund Balance Response
        /// </summary>
        public static decimal FundHoldingBalance { get; set; }

        /// <summary>
        /// Fund Movement to Registry : The total units subtracted from a CHESS Fund holding during a business day as a result of authorised transactions.
        /// 
        /// 831-01 Holding Net Fund Movement
        /// </summary>
        public static decimal FundMovementtoRegistry { get; set; }

        /// <summary>
        /// New Fund Holding Balance : The resulting unit balance of a holding in a particular fund following the application of a holding transaction.
        /// 
        /// 717-01 Effected CHESS Conversion to Issuer Sponsored Fund
        /// 723-01 Effected Conversion Issuer Sponsored Fund to CHESS
        /// 733-02Effected Fund Unit Adjustment
        /// 834-01 Full Issuer Sponsored Fund to CHESS Conversion
        /// 835-01 Full CHESS to Issuer Sponsored Fund Conversion
        /// </summary>
        public static decimal NewFundHoldingBalance { get; set; }

        /// <summary>
        /// Opening Fund Balance : The total unit quantity registered for a CHESS Fund holding at the start of a processing day.
        /// 
        /// 844-01 Top Security Fund Holder Report
        /// </summary>
        public static decimal OpeningFundBalance { get; set; }
        #endregion

        #region Bitmap Position 234
        /// <summary>
        /// Product Name : The name used to define a Fund targeted for Fund redemptions.
        /// 
        /// 726-02 Application Request
        /// 800-02Redemption Request
        /// 801-02Redemption Order Request
        /// </summary>
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ProductName { get; set; }

        /// <summary>
        /// Redemption Product Name : The name used to define a Fund.
        /// 
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// </summary>
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RedemptionProductName { get; set; }
        #endregion

        #region Bitmap Position 235
        /// <summary>
        /// Application Unit Price : The unit price in cents of a Fund unit targeted for Fund applications
        /// 
        /// 808-01Switch Order Response
        /// 808-02Switch Order Response
        /// 809-01Effected Switch Order Request
        /// 809-02Effected Switch Order Request
        /// </summary>
        public static decimal ApplicationUnitPrice { get; set; }
        #endregion

        #region Bitmap Position 236
        /// <summary>
        /// Application Unit Pricing Date : The date on which a Product Issuer Settlement Participant will provide pricing details 
        /// for Fund units requested via a Participant Fund application request.
        /// 
        /// 808-01Switch Order Response
        /// 808-02Switch Order Response
        /// 809-01Effected Switch Order Request
        /// 809-02Effected Switch Order Request
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ApplicationUnitPricingDate { get; set; }

        /// <summary>
        /// Lodgement Date : The date that the collateral was effectively lodged with ASX Clear.
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string LodgementDate { get; set; }

        /// <summary>
        /// PDS Issue Date : The date of publication (issue) of a PDS associated with an AMFS security.
        /// 
        /// 726-02 Application Request
        /// 727-02 Application Order Request
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// 863-01 Distribution Election Request
        /// 864-01 Distribution Election Authorisation Request
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PDSIssueDate { get; set; }

        /// <summary>
        /// Unit Pricing Date : The date on which a Product Issuer Settlement Participant will
        /// price Fund units for an application, redemption or switch request.
        /// 
        /// 729-02Application Order/Payment Plan Application Response
        /// 730-02Effected Application Order/Payment Plan Application Response
        /// 802-02Redemption Order Response
        /// 803-02Effected Redemption Order Request
        /// 845-02Unit Reversal Notification
        /// 846-02Effected Unit Reversal Notification
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string UnitPricingDate { get; set; }
        #endregion

        #region Bitmap Position 237
        /// <summary>
        /// Fees : The total fee that is to be levied against this request by the Product Issuer Settlement Participant.
        /// Applies to both Fund redemptions and distributions
        /// 
        /// 729-02Application Order/Payment Plan Application Response
        /// 730-02Effected Application Order/Payment Plan Application Response
        /// 802-02Redemption Order Response
        /// 803-02Effected Redemption Order Request
        /// 808-02Switch Order Response
        /// 809-02Effected Switch Order Request
        /// 813-01 Income Statement
        /// 816-01 Income Statement Advice
        /// 817-01 Distribution Re-investment Notification
        /// 818-01 Effected Distribution Re-investment Plan Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Fees { get; set; }

        /// <summary>
        /// RPP Amount : The RPP amount that an investor wishes to invest in additional units
        /// based on the RPP Frequency. Do not populate.
        /// 
        /// 863-01 Distribution Election Request
        /// 864-01 Distribution Election Authorisation Request
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RPPAmount { get; set; }
        #endregion

        #region Bitmap Position 238
        /// <summary>
        /// Application Units : The number of units described for Fund applications.
        /// 
        /// 808-01Switch Order Response
        /// 808-02Switch Order Response
        /// 809-01Effected Switch Order Request
        /// 809-02Effected Switch Order Request
        /// </summary>
        public static decimal ApplicationUnits { get; set; }
        #endregion

        #region Bitmap Position 239
        /// <summary>
        /// Unit Allotment Date : The date on which an Product Issuer Settlement Participant will
        /// allot Fund units requested via a Participant Fund application request.
        /// 
        /// Cross Reference
        #region Cross Reference
        //729-01 Application Order/Payment Plan Application Response
        //730-02Effected Application Order/Payment Plan Application Response
        //808-02Switch Order Response
        //809-02Effected Switch Order Request
        //810-01 Update Order
        //811-01 Effected Update Order
        //812-01 Reminder Notice
        //817-01 Distribution Re-investment Notification
        //818-01 Effected Distribution Re-investment Plan Advice
        #endregion Cross Reference End
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string UnitAllotmentDate { get; set; }
        #endregion

        #region Bitmap Position 240
        /// <summary>
        /// Participant Advisor Email : An Email address specified for a Participant Advisor.
        /// 
        /// Allowable Values : Must include an @ symbol, at least one full stop and no spaces
        /// 
        /// 800-02Redemption Request
        /// 801-02Redemption Order Request
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// </summary>
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ParticipantAdvisorEmail { get; set; }
        #endregion

        #region Bitmap Position 241
        /// <summary>
        /// Redemption Unit Pricing Date : The date on which an Product Issuer Settlement Participant will
        /// provide pricing details for Fund units requested via a Participant Fund redemption request.
        /// 
        /// 808-02Switch Order Response
        /// 809-02Effected Switch Order Request
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RedemptionUnitPricingDate { get; set; }
        #endregion

        #region Bitmap Position 242
        /// <summary>
        /// Payment Date : The date on which an Product Issuer Settlement Participant will
        /// provide payment for redeemed Fund units requested via a
        /// Participant Fund redemption request.
        /// 
        /// 802-02Redemption Order Response
        /// 803-02Effected Redemption Order Request
        /// 810-01 Update Order
        /// 811-01 Effected Update Order
        /// 813-01 Income Statement
        /// 816-01 Income Statement Advice
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string PaymentDate { get; set; }
        #endregion

        #region Bitmap Position 243
        /// <summary>
        /// Advisor Email : An Email address specified for an Advisor.
        /// 
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AdvisorEmail { get; set; }

        /// <summary>
        /// Dealer Group Advisor Email : An Email address specified for a Dealer Group Advisor.
        /// 
        /// Allowable Values : Must include an @ symbol, at least one full stop and no spaces
        /// 
        /// 800-02Redemption Request
        /// 801-02Redemption Order Request
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// </summary>
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DealerGroupAdvisorEmail { get; set; }
        #endregion

        #region Bitmap Position 244
        /// <summary>
        /// Record Date : The date on which an Issuer of financial products determines which
        /// holders are entitled to participate and/or receive a benefit or entitlement.
        /// 
        /// 813-01 Income Statement
        /// 816-01 Income Statement Advice
        /// 817-01 Distribution Re-investment Notification
        /// 818-01 Effected Distribution Re-investment Plan Advice
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RecordDate { get; set; }
        #endregion

        #region Bitmap Position 245
        /// <summary>
        /// APIR Code : An independently assigned Code widely used within the Funds industry
        /// 
        /// Cross Reference
        #region Cross Reference
        //715-01 CHESS to Issuer Sponsored Fund Conversion Request
        //716-01 CHESS Conversion Request to Issuer Sponsored Fund
        //717-01 Effected CHESS Conversion to Issuer Sponsored Fund
        //718-02ssuer Sponsored Fund to CHESS Conversion Request
        //719-02Issuer Sponsored Fund to CHESS Conversion Authorisation Request
        //721-01 Conversion Authorisation Issuer Sponsored Fund to CHESS
        //724-01 Conversion Rejection Issuer Sponsored Fund to CHESS
        //726-02 Application Request
        //727-02 Application Order Request
        //729-01 Application Order/Payment Plan Application Response
        //730-02Effected Application Order/Payment Plan Application Response
        //731-01 Scheduled Settlement Payment Instruction
        //732-02Unit Adjustment
        //733-02Effected Fund Unit Adjustment
        //800-02Redemption Request
        //801-02Redemption Order Request
        //802-02Redemption Order Response
        //803-02Effected Redemption Order Request
        //812-01 Reminder Notice
        //813-01 Income Statement
        //816-01 Income Statement Advice
        //817-01 Distribution Re-investment Notification
        //818-01 Effected Distribution Re-investment Plan Advice
        //822-01 Cancelled Funds Settlement Payment Instruction
        //830-01 Holding Daily Fund Balance
        //831-01 Holding Net Fund Movement
        //832-01 Holding Fund Balance
        //833-01 Total Security Fund Balance
        //834-01 Full Issuer Sponsored Fund to CHESS Conversion
        //835-01 Full CHESS to Issuer Sponsored Fund Conversion
        //837-01 Participant to CHESS Fund Balance Request
        //838-01 CHESS to Registry Fund Balance Request
        //839-01 Registry to CHESS Fund Balance Response
        //841-01 Registry to CHESS Fund Balance Rejection
        //844-01 Top Security Fund Holder Report
        //845-02Unit Reversal Notification
        //846-02Effected Unit Reversal Notification
        //863-01 Distribution Election Request
        //864-01 Distribution Election Authorisation Request
        //868-01 Income Statement Authorisation Request
        //869-01 Income Statement Request
        //957-02Registry Income Statement Part A
        //959-01 Registry Income Statement Part B
        //961-01 Registry Income Statement Part C AI
        //962-02Participant Income Statement Part A
        //963-01 Registry Income Statement Part C CG
        //964-01 Participant Income Statement Part B
        //965-01 Registry Income Statement Part C FI
        //966-01 Participant Income Statement Part C AI
        //967-02Registry Income Statement Part C NA
        //968-01 Participant Income Statement Part C CG
        //969-01 Registry Income Statement Part C OD
        //970-01 Participant Income Statement Part C FI
        //972-02Participant Income Statement Part C NA
        //974-01 Participant Income Statement Part C OD
        #endregion Cross Reference End
        /// </summary>
        [StringLength(9, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string APIRCode { get; set; }

        /// <summary>
        /// Redemption APIR Code : An independently assigned Code widely used within the Funds
        /// industry. May be used where a Switch request is initiated
        /// 
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// 808-02Switch Order Response
        /// 809-02Effected Switch Order Request
        /// </summary>
        [StringLength(9, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string RedemptionAPIRCode { get; set; }
        #endregion

        #region Bitmap Position 246
        /// <summary>
        /// Application APIR Code : An independently assigned Code widely used within the Funds industry.
        /// May be used where a Switch request is initiated
        /// 
        /// 806-01Switch Request
        /// 806-02Switch Request
        /// 807-01Switch Order Request
        /// 807-02Switch Order Request
        /// 808-01Switch Order Response
        /// 808-02Switch Order Response
        /// 809-01Effected Switch Order Request
        /// 809-02Effected Switch Order Request
        /// </summary>
        [StringLength(9, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ApplicationAPIRCode { get; set; }
        #endregion

        #region Bitmap Position 247
        /// <summary>
        /// Dealer Group Name : Identifies a Dealer Group by name.
        /// 
        /// Allowable Values ‘N/A’ is allowable.
        /// 
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DealerGroupName { get; set; }
        #endregion

        #region Bitmap Position 248
        /// <summary>
        /// Advisor Name : Identifies an Advisor by name.
        /// 
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AdvisorName { get; set; }

        /// <summary>
        /// Dealer Group Advisor Name : Identifies a Dealer Group Advisor by name.
        /// 
        /// 800-02Redemption Request
        /// 801-02Redemption Order Request
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DealerGroupAdvisorName { get; set; }
        #endregion

        #region Bitmap Position 249
        /// <summary>
        /// Advisor Code : Identifies an Advisor by code.
        /// 
        /// 737-01 Investor Details
        /// 738-01 Participant Investor Details
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string AdvisorCode { get; set; }

        /// <summary>
        /// Dealer Group Advisor Code : Identifies a Dealer Group Advisor by code.
        /// 
        /// 800-02Redemption Request
        /// 801-02Redemption Order Request
        /// 806-02Switch Request
        /// 807-02Switch Order Request
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string DealerGroupAdvisorCode { get; set; }
        #endregion

        #region Bitmap Position 250
        /// <summary>
        /// Tax Credit Amount : The dollar amount of tax credited to the holder as the result of a Fund distribution payment.
        /// 
        /// 813-01 Income Statement
        /// 816-01 Income Statement Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string TaxCreditAmount { get; set; }
        #endregion

        #region Bitmap Position 251
        /// <summary>
        /// Interest Rate : The interest rate applied in the calculation of an interest amount, for example, interest on excess cash balances.
        /// 
        /// 911-01 Daily Interest Earned Notification
        /// 940-01 Daily Interest Earned Statement
        /// </summary>
        [StringLength(13, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string InterestRate { get; set; }

        /// <summary>
        /// Yield : The yield applicable for debt securities.
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        [StringLength(13, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Yield { get; set; }
        #endregion

        #region Bitmap Position 252
        /// <summary> 
        /// Cash Balance Carried Forward : The cash balance prior to today’s settlement. This is equal to the cash balance 
        /// prior to yesterday’s settlement plus or minus any cash flow resulting from settlement on the previous day.
        /// Cash Balance Carried Forward” = “Cash Balance Brought Forward” + “Cash Payment”
        /// 
        /// 917-01 Margin Settlement Notification
        /// 942-01 Margin Settlement Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string CashBalanceCarriedForward { get; set; }

        /// <summary>
        /// Collateral Value : The value of the collateral determined by ASX Clear after a haircut is applied to the current Market Value.
        /// 
        /// 927-01 Collateral Statement Notification
        /// 952-01 Collateral Statement
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string CollateralValue { get; set; }
        #endregion

        #region Bitmap Position 253
        /// <summary>
        /// Initial Margin : The margin obligation due for settlement that day, as calculated by Cash Market Margining Methodology.
        /// 
        /// 917-01 Margin Settlement Notification
        /// 942-01 Margin Settlement Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string InitialMargin { get; set; }
        #endregion

        #region Bitmap Position 254
        /// <summary>
        /// Other Margin : Any other margin that may be called from the Participant (e.g. Additional Cover).
        /// 
        /// 917-01 Margin Settlement Notification
        /// 942-01 Margin Settlement Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string OtherMargin { get; set; }
        #endregion

        #region Bitmap Position 255
        /// <summary>
        /// Utilised Non-Cash Collateral : The value of non-cash collateral that was utilised to cover margin.
        /// 
        /// 917-01 Margin Settlement Notification
        /// 942-01 Margin Settlement Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string UtilisedNon_CashCollateral { get; set; }
        #endregion

        #region Bitmap Position 256
        /// <summary>
        /// Excess / Shortage : The excess that is available for withdrawal or the shortage must be covered in a cash deposit.
        /// Only excess cash can be withdrawn as part of settlement. Non-cash collateral can only be withdrawn outside of the settlement process.
        /// “Excess / Shortage” = “Cash Balance Carried Forward” + “Utilised Non-Cash Collateral” – “Initial Margin” – “Other Margin”
        /// 
        /// 917-01 Margin Settlement Notification
        /// 942-01 Margin Settlement Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string Excess_Shortage { get; set; }
        #endregion

        // Bitmap Over 256
        // Message fields outside byte array
        #region Bitmap Position 257

        #endregion

        #region Bitmap Position 258

        #endregion

        #region Bitmap Position 259
        /// <summary>
        /// Resultant Cash Balance : The cash balance the participant will have at ASX Clear, assuming settlement is successful.
        /// 
        /// “Resultant Cash Balance” = “Cash Balance Carried Forward” + “Settlement Amount”
        /// 
        /// 917-01 Margin Settlement Notification
        /// 942-01 Margin Settlement Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ResultantCashBalance { get; set; }
        #endregion

        #region Bitmap Position 260
        /// <summary>
        /// Resultant Excess : The resulting excess that the Clearing Participant has with the ASX Clear assuming settlement is successful.
        /// 
        /// 917-01 Margin Settlement Notification
        /// 942-01 Margin Settlement Advice
        /// </summary>
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ResultantExcess { get; set; }
        #endregion

        #region Bitmap Position 261

        #endregion

        #region Bitmap Position 262

        #endregion

        #region Bitmap Position 263

        #endregion

        #region Bitmap Position 264

        #endregion

        #region Bitmap Position 265
        /// <summary>
        /// Account Type : Indicates the type of entity for regulatory foreign tax status determination.
        /// 
        /// Allowable Values ‘C’ = Company
        ///                  ‘I’ = Individual
        ///                  ‘J’ = Joint
        ///                  ‘S’ = Superannuation Fund (includes SMSF)
        ///                  ‘T’ = Trust
        ///            
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] AccountType = new char[5] { 'C', 'I', 'J', 'S', 'T' };
        #endregion

        #region Bitmap Position 266
        /// <summary>
        /// Entity Type : Specifies the type of entity for Foreign Tax purposes.
        /// 
        /// Allowable Values ‘A’ = Active NFE
        ///                  ‘F’ = Financial Institution
        ///                  ‘P’ = Passive NFE
        ///                  
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] EntityType = new char[3] { 'A', 'F', 'P' };
        #endregion

        #region Bitmap Position 267

        #endregion

        #region Bitmap Position 268
        /// <summary>
        /// AI Interest Cash : Australian Income: Total net cash amount for interest paid. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AIInterestCash { get; set; }

        /// <summary>
        /// CG Other Method Cash : Capital Gain: Total net cash reductions made to the taxable Australian property component 
        /// of capital gain using neither the discount nor the indexation method. An ATO Tax Statement value.
        /// 
        /// 963-01 Registry Income Statement Part C CG
        /// 968-01 Participant Income Statement Part C CG
        /// </summary>
        public static decimal CGOtherMethodCash { get; set; }

        /// <summary>
        /// FI Cash Distribution Cash Sub-Total : Sub-Total: Total net cash amount for Data Reference items (10a, 15a, 19a, 22a). 
        /// An ATO Tax Statement value.
        /// 
        /// 965-01 Registry Income Statement Part C FI
        /// 970-01 Participant Income Statement Part C FI
        /// </summary>
        public static decimal FICashDistributionCashSubTotal { get; set; }

        /// <summary>
        /// Net Capital Gain : Net capital gain for the current financial year. An ATO Tax Statement value.
        /// 
        /// 957-02Registry Income Statement Part A
        /// 962-02Participant Income Statement Part A
        /// </summary>
        public static decimal NetCapitalGain { get; set; }
        #endregion

        #region Bitmap Position 269
        /// <summary>
        /// AI Interest Taxable : Australian Income: Total taxable amount for interest paid. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AIInterestTaxable { get; set; }

        /// <summary>
        /// Assessable Foreign Income : Assessable foreign sourced income. An ATO Tax Statement value.
        /// 
        /// 957-02Registry Income Statement Part A
        /// 962-02Participant Income Statement Part A
        /// </summary>
        public static decimal AssessableForeignIncome { get; set; }

        /// <summary>
        /// CG Other Method Tax : Capital Gain: Total tax paid or tax offset reductions made to the taxable Australian property component of capital gain
        /// using neither the discount nor the indexation method. An ATO Tax Statement value.
        /// 
        /// 963-01 Registry Income Statement Part C CG
        /// 968-01 Participant Income Statement Part C CG
        /// </summary>
        public static decimal CGOtherMethodTax { get; set; }
        #endregion

        #region Bitmap Position 270
        /// <summary>
        /// AI Other Income Cash : Australian Income: Total net cash amount for other income paid. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AIOtherIncomeCash { get; set; }

        /// <summary>
        /// CG Other Method Taxable : Capital Gain: Total taxable reductions made to the taxable Australian property component of capital gain
        /// using neither the discount nor the indexation method. An ATO Tax Statement value.
        /// 
        /// 963-01 Registry Income Statement Part C CG
        /// 968-01 Participant Income Statement Part C CG
        /// </summary>
        public static decimal CGOtherMethodTaxable { get; set; }

        /// <summary>
        /// Other Foreign Income : Additional net foreign sourced income. An ATO Tax Statement value.
        /// 
        /// 957-02Registry Income Statement Part A
        /// 962-02Participant Income Statement Part A
        /// </summary>
        public static decimal OtherForeignIncome { get; set; }
        #endregion

        #region Bitmap Position 271
        /// <summary>
        /// AI Other Income Taxable : Australian Income: Total taxable amount for other income paid. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AIOtherIncomeTaxable { get; set; }

        /// <summary>
        /// CG Distributed Cash : Capital Gain: Total net cash payments made for distributions. An ATO Tax Statement value.
        /// 
        /// 963-01 Registry Income Statement Part C CG
        /// 968-01 Participant Income Statement Part C CG
        /// </summary>
        public static decimal CGDistributedCash { get; set; }

        /// <summary>
        /// Foreign Income Tax Offsets : Foreign sourced income tax offsets. An ATO Tax Statement value.
        /// 
        /// 957-02Registry Income Statement Part A
        /// 962-02Participant Income Statement Part A
        /// </summary>
        public static decimal ForeignIncomeTaxOffsets { get; set; }
        #endregion

        #region Bitmap Position 272
        /// <summary>
        /// AI Trust Deductions Cash : Australian Income: Total net cash amount for trust related deductions. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AITrustDeductionsCash { get; set; }

        /// <summary>
        /// CG Distributed Tax : Capital Gain: Total tax paid or tax offset made for distributions. An ATO Tax Statement value.
        /// 
        /// 963-01 Registry Income Statement Part C CG
        /// 968-01 Participant Income Statement Part C CG
        /// </summary>
        public static decimal CGDistributedTax { get; set; }

        /// <summary>
        /// Non Primary Distribution Deductions : Total deductions from non-primary production income. An ATO Tax Statement value.
        /// 
        /// 957-02Registry Income Statement Part A
        /// 962-02Participant Income Statement Part A
        /// </summary>
        public static decimal NonPrimaryDistributionDeductions { get; set; }
        #endregion

        #region Bitmap Position 273
        /// <summary>
        /// AI Trust Deductions Taxable : Australian Income: Total taxable amount for trust related deductions. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AITrustDeductionsTaxable { get; set; }

        // CG Distributed Taxable is not in message type definition
        // CG Distributed Taxable : Capital Gain: Total taxable payments made for distributions. An ATO Tax Statement value.
        /// <summary>
        /// CG Trust Deductions Taxable
        /// 
        /// 963-01 Registry Income Statement Part C CG
        /// 968-01 Participant Income Statement Part C CG
        /// </summary>
        public static decimal CGTrustDeductionsTaxable { get; set; }
        #endregion

        #region Bitmap Position 274
        /// <summary>
        /// AI Non Primary Income Cash : Australian Income: Total net cash amount of non-primary income. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AINonPrimaryIncomeCash { get; set; }

        /// <summary>
        /// CG Net : Capital Gain: Total capital gain. An ATO Tax Statement value.
        /// 
        /// 963-01 Registry Income Statement Part C CG
        /// 968-01 Participant Income Statement Part C CG
        /// </summary>
        public static decimal CGNet { get; set; }
        #endregion

        #region Bitmap Position 275
        /// <summary>
        /// AI Non Primary Income Taxable : Australian Income: Total taxable amount of non-primary income. An ATO Tax Statement value.
        /// 
        /// 961-01 Registry Income Statement Part C AI
        /// 966-01 Participant Income Statement Part C AI
        /// </summary>
        public static decimal AINonPrimaryIncomeTaxable { get; set; }
        #endregion

        #region Bitmap Position 276
        /// <summary>
        /// Foreign Person 1 : Identifies an investor as foreign for tax reporting purposes.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  ‘N’ = No
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] ForeignPerson1 = new char[2] { 'Y', 'N' };
        #endregion

        #region Bitmap Position 277
        /// <summary>
        /// Foreign Person Date of Birth 1 : Specifies the birth date of a Foreign Tax Resident.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignPersonDateofBirth1 { get; set; }
        #endregion

        #region Bitmap Position 278
        /// <summary>
        /// Foreign Country Code (1A - 3C) : Identifies the country of the foreign tax residency.
        /// 
        /// Allowable Values 3 Character ISO Country Code.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignCountryCode1A { get; set; }
        #endregion

        #region Bitmap Position 279
        /// <summary>
        /// Foreign Country Code (1A - 3C) : Identifies the country of the foreign tax residency.
        /// 
        /// Allowable Values 3 Character ISO Country Code.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignCountryCode1B { get; set; }
        #endregion

        #region Bitmap Position 280
        /// <summary>
        /// Foreign Country Code (1A - 3C) : Identifies the country of the foreign tax residency.
        /// 
        /// Allowable Values 3 Character ISO Country Code.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignCountryCode1C { get; set; }
        #endregion

        #region Bitmap Position 281
        /// <summary>
        /// Foreign TIN 1A : Identifies the foreign tax identifier (TIN). Note that TIN is used here as a generic term for any Tax File Identifier
        /// assigned within any foreign jurisdiction.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignTIN1A { get; set; }
        #endregion

        #region Bitmap Position 282
        /// <summary>
        /// Foreign TIN 1B : Identifies the foreign tax identifier (TIN). Note that TIN is used here as a generic term for any Tax File Identifier
        /// assigned within any foreign jurisdiction.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignTIN1B { get; set; }
        #endregion

        #region Bitmap Position 283
        /// <summary>
        /// Foreign TIN 1C : Identifies the foreign tax identifier (TIN). Note that TIN is used here as a generic term for any Tax File Identifier
        /// assigned within any foreign jurisdiction.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignTIN1C { get; set; }
        #endregion

        #region Bitmap Position 284
        /// <summary>
        /// TIN Absent 1A : Indicates the reason why a foreign TIN has not been provided by the nominated foreign tax jurisdiction.
        /// 
        /// Allowable Values ‘A’ = Country of tax residency does not issue TINs to tax residents.
        ///                  ‘B’ = Investor has not been issued with a TIN.
        ///                  ‘C’ = Country of tax residency does not require a TIN to be disclosed.
        ///                  
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] TINAbsent1A = new char[3] { 'A', 'B', 'C' };
        #endregion

        #region Bitmap Position 285
        /// <summary>
        /// TIN Absent 1B : Indicates the reason why a foreign TIN has not been provided by the nominated foreign tax jurisdiction.
        /// 
        /// Allowable Values ‘A’ = Country of tax residency does not issue TINs to tax residents.
        ///                  ‘B’ = Investor has not been issued with a TIN.
        ///                  ‘C’ = Country of tax residency does not require a TIN to be disclosed.
        ///                  
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] TINAbsent1B = new char[3] { 'A', 'B', 'C' };
        #endregion

        #region Bitmap Position 286
        /// <summary>
        /// TIN Absent 1C : Indicates the reason why a foreign TIN has not been provided by the nominated foreign tax jurisdiction.
        /// 
        /// Allowable Values ‘A’ = Country of tax residency does not issue TINs to tax residents.
        ///                  ‘B’ = Investor has not been issued with a TIN.
        ///                  ‘C’ = Country of tax residency does not require a TIN to be disclosed.
        ///                  
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] TINAbsent1C = new char[3] { 'A', 'B', 'C' };
        #endregion

        #region Bitmap Position 287
        /// <summary>
        /// Foreign Person 2 : Identifies an investor as foreign for tax reporting purposes.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  ‘N’ = No
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] ForeignPerson2 = new char[2] { 'Y', 'N' };
        #endregion

        #region Bitmap Position 288
        /// <summary>
        /// Foreign Person Date of Birth 2 : Specifies the birth date of a Foreign Tax Resident.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignPersonDateofBirth2 { get; set; }
        #endregion

        #region Bitmap Position 289
        /// <summary>
        /// Foreign Country Code (1A - 3C) : Identifies the country of the foreign tax residency.
        /// 
        /// Allowable Values 3 Character ISO Country Code.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignCountryCode2A { get; set; }
        #endregion

        #region Bitmap Position 290
        /// <summary>
        /// Foreign Country Code (1A - 3C) : Identifies the country of the foreign tax residency.
        /// 
        /// Allowable Values 3 Character ISO Country Code.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignCountryCode2B { get; set; }
        #endregion

        #region Bitmap Position 291
        /// <summary>
        /// Foreign Country Code (1A - 3C) : Identifies the country of the foreign tax residency.
        /// 
        /// Allowable Values 3 Character ISO Country Code.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignCountryCode2C { get; set; }
        #endregion

        #region Bitmap Position 292
        /// <summary>
        /// Foreign TIN 2A : Identifies the foreign tax identifier (TIN). Note that TIN is used here as a generic term for any Tax File Identifier
        /// assigned within any foreign jurisdiction.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignTIN2A { get; set; }
        #endregion

        #region Bitmap Position 293
        /// <summary>
        /// Foreign TIN 2B : Identifies the foreign tax identifier (TIN). Note that TIN is used here as a generic term for any Tax File Identifier
        /// assigned within any foreign jurisdiction.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignTIN2B { get; set; }
        #endregion

        #region Bitmap Position 294
        /// <summary>
        /// Foreign TIN 2C : Identifies the foreign tax identifier (TIN). Note that TIN is used here as a generic term for any Tax File Identifier
        /// assigned within any foreign jurisdiction.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignTIN2C { get; set; }
        #endregion

        #region Bitmap Position 295
        /// <summary>
        /// TIN Absent 2A : Indicates the reason why a foreign TIN has not been provided by the nominated foreign tax jurisdiction.
        /// 
        /// Allowable Values ‘A’ = Country of tax residency does not issue TINs to tax residents.
        ///                  ‘B’ = Investor has not been issued with a TIN.
        ///                  ‘C’ = Country of tax residency does not require a TIN to be disclosed.
        ///                  
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] TINAbsent2A = new char[3] { 'A', 'B', 'C' };
        #endregion

        #region Bitmap Position 296
        /// <summary>
        /// TIN Absent 2B : Indicates the reason why a foreign TIN has not been provided by the nominated foreign tax jurisdiction.
        /// 
        /// Allowable Values ‘A’ = Country of tax residency does not issue TINs to tax residents.
        ///                  ‘B’ = Investor has not been issued with a TIN.
        ///                  ‘C’ = Country of tax residency does not require a TIN to be disclosed.
        ///                  
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] TINAbsent2B = new char[3] { 'A', 'B', 'C' };
        #endregion

        #region Bitmap Position 297
        /// <summary>
        /// TIN Absent 2C : Indicates the reason why a foreign TIN has not been provided by the nominated foreign tax jurisdiction.
        /// 
        /// Allowable Values ‘A’ = Country of tax residency does not issue TINs to tax residents.
        ///                  ‘B’ = Investor has not been issued with a TIN.
        ///                  ‘C’ = Country of tax residency does not require a TIN to be disclosed.
        ///                  
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] TINAbsent2C = new char[3] { 'A', 'B', 'C' };
        #endregion

        #region Bitmap Position 298
        /// <summary>
        /// Foreign Person 3 : Identifies an investor as foreign for tax reporting purposes.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  ‘N’ = No
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] ForeignPerson3 = new char[2] { 'Y', 'N' };
        #endregion

        #region Bitmap Position 299
        /// <summary>
        /// Foreign Person Date of Birth 3 : Specifies the birth date of a Foreign Tax Resident.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(8, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignPersonDateofBirth3 { get; set; }
        #endregion

        #region Bitmap Position 300
        /// <summary>
        /// Foreign Country Code (1A - 3C) : Identifies the country of the foreign tax residency.
        /// 
        /// Allowable Values 3 Character ISO Country Code.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignCountryCode3A { get; set; }
        #endregion

        #region Bitmap Position 301
        /// <summary>
        /// Foreign Country Code (1A - 3C) : Identifies the country of the foreign tax residency.
        /// 
        /// Allowable Values 3 Character ISO Country Code.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignCountryCode3B { get; set; }
        #endregion

        #region Bitmap Position 302
        /// <summary>
        /// Foreign Country Code (1A - 3C) : Identifies the country of the foreign tax residency.
        /// 
        /// Allowable Values 3 Character ISO Country Code.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignCountryCode3C { get; set; }
        #endregion

        #region Bitmap Position 303
        /// <summary>
        /// Foreign TIN 3A : Identifies the foreign tax identifier (TIN). Note that TIN is used here as a generic term for any Tax File Identifier
        /// assigned within any foreign jurisdiction.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignTIN3A { get; set; }
        #endregion

        #region Bitmap Position 304
        /// <summary>
        /// Foreign TIN 3B : Identifies the foreign tax identifier (TIN). Note that TIN is used here as a generic term for any Tax File Identifier
        /// assigned within any foreign jurisdiction.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignTIN3B { get; set; }
        #endregion

        #region Bitmap Position 305
        /// <summary>
        /// Foreign TIN 3C : Identifies the foreign tax identifier (TIN). Note that TIN is used here as a generic term for any Tax File Identifier
        /// assigned within any foreign jurisdiction.
        /// 
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public static string ForeignTIN3C { get; set; }
        #endregion

        #region Bitmap Position 306
        /// <summary>
        /// TIN Absent 3A : Indicates the reason why a foreign TIN has not been provided by the nominated foreign tax jurisdiction.
        /// 
        /// Allowable Values ‘A’ = Country of tax residency does not issue TINs to tax residents.
        ///                  ‘B’ = Investor has not been issued with a TIN.
        ///                  ‘C’ = Country of tax residency does not require a TIN to be disclosed.
        ///                  
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] TINAbsent3A = new char[3] { 'A', 'B', 'C' };
        #endregion

        #region Bitmap Position 307
        /// <summary>
        /// TIN Absent 3B : Indicates the reason why a foreign TIN has not been provided by the nominated foreign tax jurisdiction.
        /// 
        /// Allowable Values ‘A’ = Country of tax residency does not issue TINs to tax residents.
        ///                  ‘B’ = Investor has not been issued with a TIN.
        ///                  ‘C’ = Country of tax residency does not require a TIN to be disclosed.
        ///                  
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] TINAbsent3B = new char[3] { 'A', 'B', 'C' };
        #endregion

        #region Bitmap Position 308
        /// <summary>
        /// TIN Absent 3C : Indicates the reason why a foreign TIN has not been provided by the nominated foreign tax jurisdiction.
        /// 
        /// Allowable Values ‘A’ = Country of tax residency does not issue TINs to tax residents.
        ///                  ‘B’ = Investor has not been issued with a TIN.
        ///                  ‘C’ = Country of tax residency does not require a TIN to be disclosed.
        ///                  
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] TINAbsent3C = new char[3] { 'A', 'B', 'C' };
        #endregion

        #region Bitmap Position 309
        /// <summary>
        /// Additional Foreign Parties : Indicates that there are more than 3 Foreign Tax Residents associated with an Account Type.
        /// 
        /// Allowable Values ‘Y’ = Yes
        ///                  ‘N’ = No
        ///                  
        /// 735-01 Foreign Tax Status
        /// 736-01 Foreign Tax Status Details
        /// </summary>
        public static readonly char[] AdditionalForeignParties = new char[2] { 'Y', 'N' };
        #endregion

        #region Bitmap Position 310

        #endregion

        #region Bitmap Position 311

        #endregion

        #region Bitmap Position 312

        #endregion

        #region Bitmap Position 313

        #endregion

        #region Bitmap Position 314

        #endregion

        #region Bitmap Position 315

        #endregion

        #region Bitmap Position 316

        #endregion

        #region Bitmap Position 317

        #endregion

        #region Bitmap Position 318

        #endregion

        #region Bitmap Position 319

        #endregion

        #region Bitmap Position 320

        #endregion
    }
}

