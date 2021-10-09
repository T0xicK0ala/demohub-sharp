using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_IncomeStatementStatus", Schema = "chsrep")]
    public partial class TblSIncomeStatementStatus
    {
        public TblSIncomeStatementStatus()
        {
            TblRRegistryIncomeStatementPartA = new HashSet<TblRRegistryIncomeStatementPartA>();
            TblRRegistryIncomeStatementPartB = new HashSet<TblRRegistryIncomeStatementPartB>();
            TblRRegistryIncomeStatementPartCai = new HashSet<TblRRegistryIncomeStatementPartCai>();
            TblRRegistryIncomeStatementPartCcg = new HashSet<TblRRegistryIncomeStatementPartCcg>();
            TblRRegistryIncomeStatementPartCfi = new HashSet<TblRRegistryIncomeStatementPartCfi>();
            TblRRegistryIncomeStatementPartCna = new HashSet<TblRRegistryIncomeStatementPartCna>();
            TblRRegistryIncomeStatementPartCod = new HashSet<TblRRegistryIncomeStatementPartCod>();
        }

        [Key]
        [Column("kIncomeStatementStatus")]
        public int KIncomeStatementStatus { get; set; }
        [Required]
        [Column("sIncomeStatementStatus")]
        [StringLength(1)]
        public string SIncomeStatementStatus { get; set; }
        [Required]
        [Column("sIncomeStatementStatusDescription")]
        [StringLength(15)]
        public string SIncomeStatementStatusDescription { get; set; }
        [Column("bIsActive")]
        public bool BIsActive { get; set; }
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

        [InverseProperty("FkIncomeStatementStatusNavigation")]
        public virtual ICollection<TblRRegistryIncomeStatementPartA> TblRRegistryIncomeStatementPartA { get; set; }
        [InverseProperty("FkIncomeStatementStatusNavigation")]
        public virtual ICollection<TblRRegistryIncomeStatementPartB> TblRRegistryIncomeStatementPartB { get; set; }
        [InverseProperty("FkIncomeStatementStatusNavigation")]
        public virtual ICollection<TblRRegistryIncomeStatementPartCai> TblRRegistryIncomeStatementPartCai { get; set; }
        [InverseProperty("FkIncomeStatementStatusNavigation")]
        public virtual ICollection<TblRRegistryIncomeStatementPartCcg> TblRRegistryIncomeStatementPartCcg { get; set; }
        [InverseProperty("FkIncomeStatementStatusNavigation")]
        public virtual ICollection<TblRRegistryIncomeStatementPartCfi> TblRRegistryIncomeStatementPartCfi { get; set; }
        [InverseProperty("FkIncomeStatementStatusNavigation")]
        public virtual ICollection<TblRRegistryIncomeStatementPartCna> TblRRegistryIncomeStatementPartCna { get; set; }
        [InverseProperty("FkIncomeStatementStatusNavigation")]
        public virtual ICollection<TblRRegistryIncomeStatementPartCod> TblRRegistryIncomeStatementPartCod { get; set; }
    }
}
