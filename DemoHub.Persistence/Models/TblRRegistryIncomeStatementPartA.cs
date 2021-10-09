using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_RegistryIncomeStatementPartA", Schema = "chsrep")]
    public partial class TblRRegistryIncomeStatementPartA
    {
        [Key]
        [Column("kRegistryIncomeStatementPartA")]
        public int KRegistryIncomeStatementPartA { get; set; }
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
        [Column("dNonPrimaryIncome", TypeName = "decimal(12, 2)")]
        public decimal? DNonPrimaryIncome { get; set; }
        [Column("dTrustFrankedDistributions", TypeName = "decimal(12, 2)")]
        public decimal? DTrustFrankedDistributions { get; set; }
        [Column("dFrankingCredit", TypeName = "decimal(12, 2)")]
        public decimal? DFrankingCredit { get; set; }
        [Column("dTFNWithholding", TypeName = "decimal(12, 2)")]
        public decimal? DTfnwithholding { get; set; }
        [Column("dAnnualCapitalGain", TypeName = "decimal(12, 2)")]
        public decimal? DAnnualCapitalGain { get; set; }
        [Column("sAPIRCode")]
        [StringLength(9)]
        public string SApircode { get; set; }
        [Column("dNetCapitalGain", TypeName = "decimal(12, 2)")]
        public decimal? DNetCapitalGain { get; set; }
        [Column("dAssessableForeignIncome", TypeName = "decimal(12, 2)")]
        public decimal? DAssessableForeignIncome { get; set; }
        [Column("dOtherForeignIncome", TypeName = "decimal(12, 2)")]
        public decimal? DOtherForeignIncome { get; set; }
        [Column("dForeignIncomeTaxOffsets", TypeName = "decimal(12, 2)")]
        public decimal? DForeignIncomeTaxOffsets { get; set; }
        [Column("dNonPrimaryDistributionDeductions", TypeName = "decimal(12, 2)")]
        public decimal? DNonPrimaryDistributionDeductions { get; set; }
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
        [InverseProperty(nameof(TblSIncomeStatementStatus.TblRRegistryIncomeStatementPartA))]
        public virtual TblSIncomeStatementStatus FkIncomeStatementStatusNavigation { get; set; }
        [ForeignKey(nameof(FkPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRRegistryIncomeStatementPartA))]
        public virtual TblDChessmFundUser FkP { get; set; }
    }
}
