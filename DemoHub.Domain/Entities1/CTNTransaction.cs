//using System;
//using System.Collections.Generic;

//namespace DemoHub.Domain.Entities
//{
//    /// <Summary>
//    /// 1. Abstraction of all message formats
//    /// </Summary>
//    public class CTNTransaction
//    {
//        #region test transaction type
//        public ICollection<TransactionType> TransactionTypes { get; private set; }
//        #endregion

//        public CTNTransaction()
//        {
//            CTNTotalFeeAndTaxes = new HashSet<CTNTotalFeeAndTax>();
//            CTNForeignExchangeDetail = new HashSet<CTNForeignExchangeDetail>();
//            CTNInformativeTax = new HashSet<CTNInformativeTax>();
//            CTNInvestmentAccountDetail = new HashSet<CTNInvestmentAccountDetail>();
//        }

//        #region Calastone message properties
//        // Transaction identifier
//        public int CTNTransactionID { get; set; }
//        // Calastone message identifier
//        public string MessageID { get; set; }
//        // Calastone message creation date and time
//        public DateTime MessageCreationDateTime { get; set; }
//        // Order reference 
//        public string OrderReference { get; set; }
//        // Related Reference
//        // Status report: to reference the order reference number of orders and order confirmations
//        // Order confirmation: to reference the order reference number of orders
//        public string RelatedReference { get; set; }
//        // Deal Reference
//        // Status report and order confirmation
//        public string DealReference { get; set; }
//        // Switch order or switch order confirmation
//        public string LegOrderReference { get; set; }
//        // Switch order confirmation only
//        public string LegDealReference { get; set; }
//        #endregion

//        #region TAURUS properties
//        // TAURUS Transaction Number
//        public string RegTransactionNumber { get; set; }
//        // TAURUS Product Name
//        public string RegProductName { get; set; }
//        #endregion

//        #region Financial Instrument Details
//        // Fund identifier - ISIN, SEDOL, APIR
//        public string FundID { get; set; }
//        // Fund name - TAURUS class name
//        public string FundName { get; set; }
//        // Product code
//        public string ProductCode { get; set; }
//        #endregion

//        #region Amount or units or percentage
//        // Unit number
//        // Subscription/Redemption orders
//        // Subscription/Redemption/Switch order confirmations
//        public decimal? Unit { get; set; }
//        // Gross amount
//        // Subscription/Redemption orders
//        // Subscription/Redemption/Switch order confirmations
//        public decimal? GrossAmount { get; set; }
//        // Redemption order
//        // Switch out order
//        public decimal? HoldingsRedemptionRate { get; set; }
//        // Switch in order
//        public decimal? HoldingsRedemptionAmount { get; set; }
//        #endregion

//        #region Other properties
//        // Rounding code
//        // Subscription/Redemption orders
//        public string RoundingCode { get; set; }
//        // Unit group code
//        // Redemption/Switch orders
//        public string UnitGroupCode { get; set; }
//        // Physical Deliverable Indicator
//        // Subscription/Redemption/Switch orders
//        public bool IsPhysicalDeliverable { get; set; }
//        // Requested Settlement Currency
//        // Subscription/Redemption/Switch orders
//        public string RequestedSettlementCurrency { get; set; }
//        // Requested Pricing Currency
//        // Subscription/Redemption/Switch orders
//        public string RequestedPricingCurrency { get; set; }
//        // Fund Manager ID
//        // Subscription/Redemption/Switch orders
//        public string FundManagerID { get; set; }
//        // Distributor Code
//        // Subscription/Redemption/Switch orders
//        public string Distributor { get; set; }
//        #endregion

//        #region Status report and order confirmation properties
//        // Status code
//        // Status report only
//        public string StatusCode { get; set; }
//        // Rejected reason code
//        // Status report - business reject only
//        public string RejectedReasonCode { get; set; }
//        // Rejected reason additional description
//        // Status report - business reject only
//        public string AdditionalRejectedReason { get; set; }
//        // Net amount
//        // Subscription/Redemption/Switch order confirmations
//        public decimal? NetAmount { get; set; }
//        // Effective Date
//        // Expected trade date (time) in status report
//        // Trade date (time) in Subscription/Redemption/Switch order confirmations
//        public DateTime EffectiveDate { get; set; }
//        // Settlement Date
//        // Expected settlement date (time) in status report
//        // Settlement date (time) in Subscription/Redemption/Switch order confirmations
//        public DateTime SettlementDate { get; set; }
//        // Dealing price type code
//        // Subscription/Redemption order confirmations only
//        public string DealingPriceType { get; set; }
//        // Dealing price type amount
//        // Subscription/Redemption order confirmations only
//        public decimal DealingPriceAmount { get; set; }
//        // Settlement amount
//        // Subscription/Redemption order confirmations only
//        public decimal SettlementAmount { get; set; }
//        // Partially executed indicator
//        // Subscription/Redemption order confirmations only
//        // Calastone's footnote: The value in this tag should contain "false".
//        public bool IsPartiallyExecuted { get; set; } = false;
//        // Cum dividend indicator
//        // Subscription/Redemption order confirmations only
//        // Calastone's footnote: The value in this tag should contain "false".
//        public bool IsCumDividend { get; set; } = false;
//        // Foreign Exchange Details
//        // The relationship between Foreign Exchange Details and Transaction is 0:n.
//        public ICollection<CTNForeignExchangeDetail> CTNForeignExchangeDetail { get; private set; }
//        // Informative Taxes
//        // The relationship between Informative Taxes and Transaction is 0:n.
//        public ICollection<CTNInformativeTax> CTNInformativeTax { get; private set; }
//        #endregion

//        // Investment Account Details
//        // The relationship between Investment Account Details and Transaction is 1:1.
//        public ICollection<CTNInvestmentAccountDetail> CTNInvestmentAccountDetail { get; private set; }
//        // Total Fees And Taxes
//        // The relationship between Total Fees And Taxes and Transaction is 0:n.
//        public ICollection<CTNTotalFeeAndTax> CTNTotalFeeAndTaxes { get; private set; }
//    }
//}