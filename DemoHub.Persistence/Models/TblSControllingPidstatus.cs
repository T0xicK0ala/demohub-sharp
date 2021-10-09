using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_ControllingPIDStatus", Schema = "chs")]
    public partial class TblSControllingPidstatus
    {
        [Key]
        [Column("kControllingPIDStatus")]
        public int KControllingPidstatus { get; set; }
        [Required]
        [Column("sControllingPIDStatus")]
        [StringLength(1)]
        public string SControllingPidstatus { get; set; }
        [Required]
        [Column("sControllingPIDStatusDescription")]
        [StringLength(10)]
        public string SControllingPidstatusDescription { get; set; }
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
    }
}
