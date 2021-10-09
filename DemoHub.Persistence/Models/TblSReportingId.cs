using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_ReportingId", Schema = "chsrep")]
    public partial class TblSReportingId
    {
        public TblSReportingId()
        {
            TblDReportRequestFkPreporting = new HashSet<TblDReportRequest>();
            TblDReportRequestFkReporting = new HashSet<TblDReportRequest>();
            TblDReportingRequestDetailFkPreporting = new HashSet<TblDReportingRequestDetail>();
            TblDReportingRequestDetailFkReporting = new HashSet<TblDReportingRequestDetail>();
        }

        [Key]
        [Column("kReportingId")]
        public int KReportingId { get; set; }
        [Required]
        [Column("sReportingId")]
        [StringLength(3)]
        public string SReportingId { get; set; }
        [Required]
        [Column("sReportName")]
        [StringLength(40)]
        public string SReportName { get; set; }
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

        [InverseProperty(nameof(TblDReportRequest.FkPreporting))]
        public virtual ICollection<TblDReportRequest> TblDReportRequestFkPreporting { get; set; }
        [InverseProperty(nameof(TblDReportRequest.FkReporting))]
        public virtual ICollection<TblDReportRequest> TblDReportRequestFkReporting { get; set; }
        [InverseProperty(nameof(TblDReportingRequestDetail.FkPreporting))]
        public virtual ICollection<TblDReportingRequestDetail> TblDReportingRequestDetailFkPreporting { get; set; }
        [InverseProperty(nameof(TblDReportingRequestDetail.FkReporting))]
        public virtual ICollection<TblDReportingRequestDetail> TblDReportingRequestDetailFkReporting { get; set; }
    }
}
