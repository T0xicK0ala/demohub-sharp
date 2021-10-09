using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_RegistryIncomeStatementPartCCG", Schema = "chsrep")]
    public partial class TblRRegistryIncomeStatementPartCcg
    {
        [Key]
        [Column("kRegistryIncomeStatementPartCCG")]
        public int KRegistryIncomeStatementPartCcg { get; set; }
        [Required]
        [Column("sSecurityCode")]
        [StringLength(12)]
        public string SSecurityCode { get; set; }
        [Required]
        [Column("sHIN")]
        [StringLength(10)]
        public string SHin { get; set; }
        [Column("fkPID")]
        public int FkPid { get; set; }
        [Column("fkIncomeStatementStatus")]
        public int FkIncomeStatementStatus { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Required]
        [Column("sSetTransactionId")]
        [StringLength(16)]
        public string SSetTransactionId { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("dtAsAtDate", TypeName = "date")]
        public DateTime DtAsAtDate { get; set; }
        [Column("dCGDiscountCash", TypeName = "decimal(12, 2)")]
        public decimal? DCgdiscountCash { get; set; }
        [Column("dCGDiscountTax", TypeName = "decimal(12, 2)")]
        public decimal? DCgdiscountTax { get; set; }
        [Column("dCGDiscountTaxable", TypeName = "decimal(12, 2)")]
        public decimal? DCgdiscountTaxable { get; set; }
        [Column("dCGTaxConcessionCash", TypeName = "decimal(12, 2)")]
        public decimal? DCgtaxConcessionCash { get; set; }
        [Column("dCGTaxConcessionTaxable", TypeName = "decimal(12, 2)")]
        public decimal? DCgtaxConcessionTaxable { get; set; }
        [Column("sAPIRCode")]
        [StringLength(9)]
        public string SApircode { get; set; }
        [Column("dCGOtherMethodCash", TypeName = "decimal(12, 2)")]
        public decimal? DCgotherMethodCash { get; set; }
        [Column("dCGOtherMethodTax", TypeName = "decimal(12, 2)")]
        public decimal? DCgotherMethodTax { get; set; }
        [Column("dCGOtherMethodTaxable", TypeName = "decimal(12, 2)")]
        public decimal? DCgotherMethodTaxable { get; set; }
        [Column("dAIOtherIncomeTaxable", TypeName = "decimal(12, 2)")]
        public decimal? DAiotherIncomeTaxable { get; set; }
        [Column("dCGDistributedCash", TypeName = "decimal(12, 2)")]
        public decimal? DCgdistributedCash { get; set; }
        [Column("dCGDistributedTax", TypeName = "decimal(12, 2)")]
        public decimal? DCgdistributedTax { get; set; }
        [Column("dCGTrustDeductionsTaxable", TypeName = "decimal(12, 2)")]
        public decimal? DCgtrustDeductionsTaxable { get; set; }
        [Column("dCGNet", TypeName = "decimal(12, 2)")]
        public decimal? DCgnet { get; set; }
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

        [ForeignKey(nameof(FkIncomeStatementStatus))]
        [InverseProperty(nameof(TblSIncomeStatementStatus.TblRRegistryIncomeStatementPartCcg))]
        public virtual TblSIncomeStatementStatus FkIncomeStatementStatusNavigation { get; set; }
        [ForeignKey(nameof(FkPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRRegistryIncomeStatementPartCcg))]
        public virtual TblDChessmFundUser FkP { get; set; }
    }
}
