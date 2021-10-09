using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_RegistryIncomeStatementPartB", Schema = "chsrep")]
    public partial class TblRRegistryIncomeStatementPartB
    {
        [Key]
        [Column("kRegistryIncomeStatementPartB")]
        public int KRegistryIncomeStatementPartB { get; set; }
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
        [Column("dCapitalGainDiscount", TypeName = "decimal(12, 2)")]
        public decimal? DCapitalGainDiscount { get; set; }
        [Column("dCapitalGainOther", TypeName = "decimal(12, 2)")]
        public decimal? DCapitalGainOther { get; set; }
        [Column("dAnnualCapitalGainTotal", TypeName = "decimal(12, 2)")]
        public decimal? DAnnualCapitalGainTotal { get; set; }
        [Column("dCGTConcession", TypeName = "decimal(12, 2)")]
        public decimal? DCgtconcession { get; set; }
        [Column("dTaxDeferred", TypeName = "decimal(12, 2)")]
        public decimal? DTaxDeferred { get; set; }
        [Column("sAPIRCode")]
        [StringLength(9)]
        public string SApircode { get; set; }
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
        [InverseProperty(nameof(TblSIncomeStatementStatus.TblRRegistryIncomeStatementPartB))]
        public virtual TblSIncomeStatementStatus FkIncomeStatementStatusNavigation { get; set; }
        [ForeignKey(nameof(FkPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRRegistryIncomeStatementPartB))]
        public virtual TblDChessmFundUser FkP { get; set; }
    }
}
