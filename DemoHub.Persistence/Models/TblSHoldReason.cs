using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_HoldReason", Schema = "chs")]
    public partial class TblSHoldReason
    {
        [Key]
        [Column("kHoldReason")]
        public int KHoldReason { get; set; }
        [Required]
        [Column("sHoldReason")]
        [StringLength(3)]
        public string SHoldReason { get; set; }
        [Required]
        [Column("sHoldReasonDescription")]
        [StringLength(40)]
        public string SHoldReasonDescription { get; set; }
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
