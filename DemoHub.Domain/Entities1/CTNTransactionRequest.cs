//using System;
//using System.Collections.Generic;

//namespace DemoHub.Domain.Entities
//{
//    /// <Summary>
//    /// Subscription and Redemption order entities
//    /// </Summary>
//    public class CTNTransactionRequest
//    {
//        public CTNTransactionRequest()
//        {
//            CTNTotalFeeAndTaxRequests = new HashSet<CTNTotalFeeAndTaxRequest>();
//            CTNInvestmentAccountDetails = new HashSet<CTNInvestmentAccountDetail>();
//        }

//        #region DemoHub properties
//        // Transaction request identifier
//        public int CTNTransactionRequestID { get; set; }

//        // Transaction type
//        public string TransactionType { get; set; }
//        // Transaction request status
//        public string TransactionRequestStatus { get; set; }
//        // Transaction request Resource
//        public string TransactionRequestResource { get; set; }
//        // Transaction rejected reason code
//        public string TransactionRequestRejectedReasonCode { get; set; }
//        #endregion DemoHub properties

//        #region TAURUS properties
//        // TAURUS transaction number
//        public string RegTransactionNumber { get; set; }
//        // TAURUS product name
//        public string RegProductName { get; set; }
//        #endregion TAURUS properties

//        #region Calastone message properties
//        // Calastone message identifier
//        public string MessageID { get; set; }
//        // Calastone message creation timestamp
//        public DateTime MessageCreationDateTime { get; set; }
//        // Order reference 
//        public string OrderReference { get; set; }
//        #endregion Calastone message properties

//        #region Financial instrument details
//        // Fund identifier - ISIN, SEDOL, APIR
//        public string FundIDType { get; set; }
//        // Fund ID
//        public string FundID { get; set; }
//        // Fund name - TAURUS class name
//        public string FundName { get; set; }
//        // Product code
//        public string ProductCode { get; set; }
//        #endregion Financial instrument details

//        #region Amount or units or percentages
//        // Unit number
//        public decimal? Unit { get; set; }
//        // Gross amount
//        public decimal? GrossAmount { get; set; }
//        // Gross amount currency
//        public string GrossAmountCurrency { get; set; }
//        // Percentage of holdings to be redeemed
//        // Redemption order
//        public decimal? HoldingsRedemptionRate { get; set; }
//        #endregion Amount or units or percentages

//        #region Other properties
//        // Rounding code
//        public string RoundingCode { get; set; }
//        // Unit group code
//        // Redemption order
//        public string UnitGroupCode { get; set; }
//        // Physical deliverable indicator
//        public bool IsPhysicalDeliverable { get; set; }
//        // Requested Settlement Currency
//        public string RequestedSettlementCurrency { get; set; }
//        // Requested Pricing Currency
//        public string RequestedPricingCurrency { get; set; }
//        // Fund Manager ID
//        public string FundManagerID { get; set; }
//        // Distributor Code
//        public string DistributorCode { get; set; }
//        #endregion Other properties

//        // Investment Account Details
//        // The relationship between Investment Account Detail and Transaction request is 1:1.
//        public ICollection<CTNInvestmentAccountDetail> CTNInvestmentAccountDetails { get; private set; }
//        // Total Fees And Tax Requests
//        // The relationship between Total Fee And Tax Request and Transaction request is 0:n.
//        public ICollection<CTNTotalFeeAndTaxRequest> CTNTotalFeeAndTaxRequests { get; private set; }
//    }
//}
