using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_ProcessingPoint", Schema = "chsrep")]
    public partial class TblSProcessingPoint
    {
        public TblSProcessingPoint()
        {
            TblDReportRequest = new HashSet<TblDReportRequest>();
            TblDReportingRequestDetail = new HashSet<TblDReportingRequestDetail>();
        }

        [Key]
        [Column("kProcessingPoint")]
        public int KProcessingPoint { get; set; }
        [Required]
        [Column("sProcessingPoint")]
        [StringLength(2)]
        public string SProcessingPoint { get; set; }
        [Required]
        [Column("sProcessingPointDescription")]
        [StringLength(10)]
        public string SProcessingPointDescription { get; set; }
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

        [InverseProperty("FkProcessingPointNavigation")]
        public virtual ICollection<TblDReportRequest> TblDReportRequest { get; set; }
        [InverseProperty("FkProcessingPointNavigation")]
        public virtual ICollection<TblDReportingRequestDetail> TblDReportingRequestDetail { get; set; }
    }
}
