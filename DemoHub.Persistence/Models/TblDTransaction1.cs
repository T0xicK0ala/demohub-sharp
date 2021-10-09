using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_Transaction", Schema = "trn")]
    public partial class TblDTransaction1
    {
        public TblDTransaction1()
        {
            TblLTransactionHolder = new HashSet<TblLTransactionHolder>();
        }

        [Key]
        [Column("kTransaction")]
        public int KTransaction { get; set; }
        [Column("fkTransactionRequest")]
        public int FkTransactionRequest { get; set; }
        [Column("sRegTransactionNumber")]
        [StringLength(50)]
        public string SRegTransactionNumber { get; set; }
        [Column("fkTransactionType")]
        public int FkTransactionType { get; set; }
        [Column("fkHubTransactionStatus")]
        public int FkHubTransactionStatus { get; set; }
        [Column("sRegTransactionStatus")]
        [StringLength(20)]
        public string SRegTransactionStatus { get; set; }
        [Column("fkMessageOrigin")]
        public int FkMessageOrigin { get; set; }
        [Column("fkFundReason")]
        public int? FkFundReason { get; set; }
        [Column("fkHoldReason")]
        public int? FkHoldReason { get; set; }
        [Column("sRelatedReference")]
        [StringLength(35)]
        public string SRelatedReference { get; set; }
        [Column("sOrderReference")]
        [StringLength(35)]
        public string SOrderReference { get; set; }
        [Column("sDealReference")]
        [StringLength(35)]
        public string SDealReference { get; set; }
        [Column("sRegistryReference")]
        [StringLength(16)]
        public string SRegistryReference { get; set; }
        [Column("dUnit", TypeName = "decimal(20, 6)")]
        public decimal? DUnit { get; set; }
        [Column("dAdjustmentUnits", TypeName = "decimal(12, 6)")]
        public decimal? DAdjustmentUnits { get; set; }
        [Column("bIncreaseorDecrease")]
        public bool? BIncreaseorDecrease { get; set; }
        [Column("dUnitPrice", TypeName = "decimal(6, 6)")]
        public decimal? DUnitPrice { get; set; }
        [Column("dtUnitPricingDate", TypeName = "date")]
        public DateTime? DtUnitPricingDate { get; set; }
        [Column("dtUnitAllotmentDate", TypeName = "date")]
        public DateTime? DtUnitAllotmentDate { get; set; }
        [Column("dNetAmount", TypeName = "decimal(20, 6)")]
        public decimal? DNetAmount { get; set; }
        [Column("dFees", TypeName = "decimal(13, 2)")]
        public decimal? DFees { get; set; }
        [Column("dTaxDeducted", TypeName = "decimal(13, 2)")]
        public decimal? DTaxDeducted { get; set; }
        [Column("dIncome", TypeName = "decimal(13, 2)")]
        public decimal? DIncome { get; set; }
        [Column("dtPaymentDate", TypeName = "date")]
        public DateTime? DtPaymentDate { get; set; }
        [Column("dtEffectiveDate", TypeName = "date")]
        public DateTime? DtEffectiveDate { get; set; }
        [Column("fkDealingPriceTypeCode")]
        public int? FkDealingPriceTypeCode { get; set; }
        [Column("dDealingPriceAmount", TypeName = "decimal(20, 6)")]
        public decimal? DDealingPriceAmount { get; set; }
        [Column("dSettlementAmount", TypeName = "decimal(20, 6)")]
        public decimal? DSettlementAmount { get; set; }
        [Column("dtSettlementDate", TypeName = "date")]
        public DateTime? DtSettlementDate { get; set; }
        [Column("isPartiallyExecuted")]
        public bool? IsPartiallyExecuted { get; set; }
        [Column("isCumDividend")]
        public bool? IsCumDividend { get; set; }
        [Column("fkForeignExchangeDetail")]
        public int? FkForeignExchangeDetail { get; set; }
        [Column("fkIndvFee")]
        public int? FkIndvFee { get; set; }
        [Column("fkIndvTax")]
        public int? FkIndvTax { get; set; }
        [Column("fkInformativeTax")]
        public int? FkInformativeTax { get; set; }
        [Column("sLegDealReference")]
        [StringLength(35)]
        public string SLegDealReference { get; set; }
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

        [InverseProperty("FkTransactionNavigation")]
        public virtual ICollection<TblLTransactionHolder> TblLTransactionHolder { get; set; }
    }
}
