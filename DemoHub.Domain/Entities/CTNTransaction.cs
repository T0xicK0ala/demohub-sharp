using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHub.Domain.Entities
{
    public class CTNTransaction
    {
        public CTNTransaction()
        {
            CTNTotalFeeAndTaxes = new HashSet<CTNTotalFeeAndTax>(); // Order and order confirmation
            CTNForeignExchangeDetail = new HashSet<CTNForeignExchangeDetail>(); // Order confirmation
            CTNInformativeTax = new HashSet<CTNInformativeTax>(); // Order confirmation
            CTNInvestmentAccountDetail = new HashSet<CTNInvestmentAccountDetail>();
        }

        public int CTNTransactionID { get; set; } // Transaction identifier
        public string MessageID { get; set; }
        public DateTime? MessageCreationDateTime { get; set; }

        /// <Summary>
        /// 1. Required properties for Subscription and Redemption orders
        /// 2. Switch order, if values are the same for redemption and subscription legs, then they will be provided at the parent level, if they are different then they are provided at child level.
        /// </Summary>
        public ICollection<CTNInvestmentAccountDetail> CTNInvestmentAccountDetail { get; private set; } // Nullable object

        public string OrderReference { get; set; }
        public string FundID { get; set; }
        public string FundName { get; set; }
        public string ProductCode { get; set; }
        public decimal? Unit { get; set; }
        public decimal? GrossAmount { get; set; } // with currency
        public string LegOrderReference { get; set; } // Switch order or switch order confirmation
        public decimal? HoldingsRedemptionRate { get; set; } // Redemption and Switch (out) order
        public decimal? HoldingsRedemptionAmount { get; set; } // Switch (in) order only
        public string RoundingCode { get; set; }
        public string UnitGroupCode { get; set; }
        public bool IsPhysicalDeliverable { get; set; }
        public string RequestedSettlementCurrency { get; set; }
        public string RequestedPricingCurrency { get; set; }
        public string FundManagerID { get; set; }
        public string Distributor { get; set; }

        #region Order Instruction Status and Order Confirmation
        public string RelatedReference { get; set; }
        public string DealReference { get; set; } // both
        public string StatusCode { get; set; } // order status only
        public string RejectedReason { get; set; } // order status only
        public decimal? NetAmount { get; set; } // with currency, order confirmation only
        public DateTime EffectiveDate { get; set; } // both
        public DateTime SettlementDate { get; set; } // both
        public string DealingPriceType { get; set; } // order confirmation only
        public decimal DealingPriceAmount { get; set; } // with currency, order confirmation only
        public decimal SettlementAmount { get; set; } // with currency, order confirmation only
        public string LegDealReference { get; set; } // Switch order confirmation only
        public bool IsPartiallyExecuted { get; set; } = false; // Calastone's footnote: The value in this tag should contain "false".
        public bool IsCumDividend { get; set; } = false; // Calastone's footnote: The value in this tag should contain "false".
        public ICollection<CTNForeignExchangeDetail> CTNForeignExchangeDetail { get; private set; } // Nullable object
        public ICollection<CTNInformativeTax> CTNInformativeTax { get; private set; } // Nullable object
        #endregion

        public ICollection<CTNTotalFeeAndTax> CTNTotalFeeAndTaxes { get; private set; } // Nullable object

    }
}
