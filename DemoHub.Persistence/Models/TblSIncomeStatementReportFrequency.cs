using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_IncomeStatementReportFrequency", Schema = "chsrep")]
    public partial class TblSIncomeStatementReportFrequency
    {
        public TblSIncomeStatementReportFrequency()
        {
            TblDIncomeStatementAuthorisationRequest = new HashSet<TblDIncomeStatementAuthorisationRequest>();
        }

        [Key]
        [Column("kIncomeStatementReportFrequency")]
        public int KIncomeStatementReportFrequency { get; set; }
        [Required]
        [Column("sIncomeStatementReportFrequency")]
        [StringLength(1)]
        public string SIncomeStatementReportFrequency { get; set; }
        [Required]
        [Column("sIncomeStatementReportFrequencyDescription")]
        [StringLength(10)]
        public string SIncomeStatementReportFrequencyDescription { get; set; }
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

        [InverseProperty("FkIncomeStatementReportFrequencyNavigation")]
        public virtual ICollection<TblDIncomeStatementAuthorisationRequest> TblDIncomeStatementAuthorisationRequest { get; set; }
    }
}
