using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_ReportingRequestStatus", Schema = "chsrep")]
    public partial class TblSReportingRequestStatus
    {
        public TblSReportingRequestStatus()
        {
            TblDReportingRequestDetail = new HashSet<TblDReportingRequestDetail>();
        }

        [Key]
        [Column("kReportingRequestStatus")]
        public int KReportingRequestStatus { get; set; }
        [Required]
        [Column("sReportingRequestStatus")]
        [StringLength(1)]
        public string SReportingRequestStatus { get; set; }
        [Required]
        [Column("sReportingRequestStatusDescription")]
        [StringLength(10)]
        public string SReportingRequestStatusDescription { get; set; }
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

        [InverseProperty("FkReportingRequestStatusNavigation")]
        public virtual ICollection<TblDReportingRequestDetail> TblDReportingRequestDetail { get; set; }
    }
}
