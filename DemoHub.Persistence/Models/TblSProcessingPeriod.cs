using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_ProcessingPeriod", Schema = "chsrep")]
    public partial class TblSProcessingPeriod
    {
        public TblSProcessingPeriod()
        {
            TblDReportRequest = new HashSet<TblDReportRequest>();
            TblDReportingRequestDetail = new HashSet<TblDReportingRequestDetail>();
        }

        [Key]
        [Column("kProcessingPeriod")]
        public int KProcessingPeriod { get; set; }
        [Column("sProcessingPeriod")]
        [StringLength(1)]
        public string SProcessingPeriod { get; set; }
        [Required]
        [Column("sFProcessingPeriodDescription")]
        [StringLength(60)]
        public string SFprocessingPeriodDescription { get; set; }
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

        [InverseProperty("FkProcessingPeriodNavigation")]
        public virtual ICollection<TblDReportRequest> TblDReportRequest { get; set; }
        [InverseProperty("FkProcessingPeriodNavigation")]
        public virtual ICollection<TblDReportingRequestDetail> TblDReportingRequestDetail { get; set; }
    }
}
