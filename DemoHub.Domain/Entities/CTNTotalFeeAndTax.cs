using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHub.Domain.Entities
{
    public class CTNTotalFeeAndTax
    {
        // Common properties
        public int CTNTotalFeeAndTaxID { get; set; }
        public string ChargeCommissionType { get; set; }

        #region Individual Fee

        public string ProprietaryID { get; set; }
        public string ProprietaryIssuer { get; set; }
        public decimal? ChargeDiscountOrCommissionWaivedRate { get; set; }
        public decimal? ChargeOrCommissionRate { get; set; }


        // below are for confirmation
        public string ChargeCommissionBasis { get; set; }
        public decimal? ChargeCommissionAmount { get; set; } // with currency
        public decimal? ChargeCommissionRate { get; set; }
        public decimal? DiscountAmount { get; set; } // with currency
        public decimal? DiscountRate { get; set; }
        public decimal? AppliedAmount { get; set; } // with currency
        public decimal? AppliedRate { get; set; }
        public bool InformativeIndicator { get; set; }
        #endregion

        #region Individual Tax
        public string TaxType { get; set; }
        public decimal TaxAmount { get; set; } // with currency
        public decimal? TaxRate { get; set; }

        #endregion

    }
}
