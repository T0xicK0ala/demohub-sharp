using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_RegistryIncomeStatementPartCAI", Schema = "chsrep")]
    public partial class TblRRegistryIncomeStatementPartCai
    {
        [Key]
        [Column("kRegistryIncomeStatementPartCAI")]
        public int KRegistryIncomeStatementPartCai { get; set; }
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
        [Column("dAIDividendsFrankedAmountCash", TypeName = "decimal(12, 2)")]
        public decimal? DAidividendsFrankedAmountCash { get; set; }
        [Column("dAIDividendsFrankedAmountTax", TypeName = "decimal(12, 2)")]
        public decimal? DAidividendsFrankedAmountTax { get; set; }
        [Column("dAIDividendsFrankedAmountTaxable", TypeName = "decimal(12, 2)")]
        public decimal? DAidividendsFrankedAmountTaxable { get; set; }
        [Column("dAIDividendsUnFrankedAmountCash", TypeName = "decimal(12, 2)")]
        public decimal? DAidividendsUnFrankedAmountCash { get; set; }
        [Column("dAIDividendsUnFrankedAmountTaxable", TypeName = "decimal(12, 2)")]
        public decimal? DAidividendsUnFrankedAmountTaxable { get; set; }
        [Column("sAPIRCode")]
        [StringLength(9)]
        public string SApircode { get; set; }
        [Column("dAIInterestCash", TypeName = "decimal(12, 2)")]
        public decimal? DAiinterestCash { get; set; }
        [Column("dAIInterestTaxable", TypeName = "decimal(12, 2)")]
        public decimal? DAiinterestTaxable { get; set; }
        [Column("dAIOtherIncomeCash", TypeName = "decimal(12, 2)")]
        public decimal? DAiotherIncomeCash { get; set; }
        [Column("dAIOtherIncomeTaxable", TypeName = "decimal(12, 2)")]
        public decimal? DAiotherIncomeTaxable { get; set; }
        [Column("dAITrustDeductionsCash", TypeName = "decimal(12, 2)")]
        public decimal? DAitrustDeductionsCash { get; set; }
        [Column("dAITrustDeductionsTaxable", TypeName = "decimal(12, 2)")]
        public decimal? DAitrustDeductionsTaxable { get; set; }
        [Column("dAINonPrimaryIncomeCash", TypeName = "decimal(12, 2)")]
        public decimal? DAinonPrimaryIncomeCash { get; set; }
        [Column("dAINonPrimaryIncomeTaxable", TypeName = "decimal(12, 2)")]
        public decimal? DAinonPrimaryIncomeTaxable { get; set; }
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
        [InverseProperty(nameof(TblSIncomeStatementStatus.TblRRegistryIncomeStatementPartCai))]
        public virtual TblSIncomeStatementStatus FkIncomeStatementStatusNavigation { get; set; }
        [ForeignKey(nameof(FkPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRRegistryIncomeStatementPartCai))]
        public virtual TblDChessmFundUser FkP { get; set; }
    }
}
