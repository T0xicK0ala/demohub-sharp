using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_IncomeStatementReportType", Schema = "chsrep")]
    public partial class TblSIncomeStatementReportType
    {
        public TblSIncomeStatementReportType()
        {
            TblDIncomeStatementAuthorisationRequest = new HashSet<TblDIncomeStatementAuthorisationRequest>();
        }

        [Key]
        [Column("kIncomeStatementReportType")]
        public int KIncomeStatementReportType { get; set; }
        [Required]
        [Column("sIncomeStatementReportType")]
        [StringLength(1)]
        public string SIncomeStatementReportType { get; set; }
        [Required]
        [Column("sIncomeStatementReportTypeDescription")]
        [StringLength(10)]
        public string SIncomeStatementReportTypeDescription { get; set; }
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

        [InverseProperty("FkIncomeStatementReportTypeNavigation")]
        public virtual ICollection<TblDIncomeStatementAuthorisationRequest> TblDIncomeStatementAuthorisationRequest { get; set; }
    }
}
