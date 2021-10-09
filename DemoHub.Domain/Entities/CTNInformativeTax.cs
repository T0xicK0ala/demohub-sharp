using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHub.Domain.Entities
{
    public class CTNInformativeTax
    {
        // Common properties
        public int CTNInformativeTaxID { get; set; }
        public string TaxType { get; set; }
        public bool IsTaxExempted { get; set; }
        public string TaxExemptionReason { get; set; }
    }
}
