using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_SubpositionType", Schema = "chs")]
    public partial class TblSSubpositionType
    {
        public TblSSubpositionType()
        {
            TblDReportRequest = new HashSet<TblDReportRequest>();
            TblDReportingRequestDetail = new HashSet<TblDReportingRequestDetail>();
        }

        [Key]
        [Column("kSubpositionType")]
        public int KSubpositionType { get; set; }
        [Required]
        [Column("sSubpositionType")]
        [StringLength(1)]
        public string SSubpositionType { get; set; }
        [Required]
        [Column("sSubpositionTypeDescription")]
        [StringLength(20)]
        public string SSubpositionTypeDescription { get; set; }
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

        [InverseProperty("FkPsubpositionTypeNavigation")]
        public virtual ICollection<TblDReportRequest> TblDReportRequest { get; set; }
        [InverseProperty("FkPsubpositionTypeNavigation")]
        public virtual ICollection<TblDReportingRequestDetail> TblDReportingRequestDetail { get; set; }
    }
}
