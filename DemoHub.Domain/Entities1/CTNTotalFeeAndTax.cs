//namespace DemoHub.Domain.Entities
//{
//    /// <Summary>
//    /// 1. Required properties for Subscription/Redemption/Switch order confirmations.
//    /// 2. Optional fields
//    /// </Summary>
//    public class CTNTotalFeeAndTax
//    {
//        #region Re-working area
//        // Common properties
//        public int CTNTotalFeeAndTaxID { get; set; }
//        public string ChargeCommissionTypeCode { get; set; }

//        #region Individual Fee
//        // Subscription/Redemption/Switch orders
//        public string ProprietaryID { get; set; }
//        public string ProprietaryIssuer { get; set; }
//        public decimal? ChargeDiscountCommissionWaivedRate { get; set; }
//        public decimal? ChargeCommissionRate { get; set; }

//        // Subscription/Redemption/Switch order confirmations
//        //public string ChargeCommissionBasis { get; set; }
//        //public decimal? ChargeCommissionAmount { get; set; }
//        //public decimal? DiscountAmount { get; set; }
//        //public decimal? DiscountRate { get; set; }
//        //public decimal? AppliedAmount { get; set; }
//        //public decimal? AppliedRate { get; set; }
//        //public bool InformativeIndicator { get; set; }
//        #endregion

//        #region Individual Tax
//        // Subscription/Redemption/Switch order confirmations
//        //public string TaxType { get; set; }
//        //public decimal TaxAmount { get; set; }
//        //public decimal? TaxRate { get; set; }
//        #endregion
//        #endregion
//    }
//}
