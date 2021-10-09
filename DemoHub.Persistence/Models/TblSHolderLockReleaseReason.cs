using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_HolderLockReleaseReason", Schema = "chs")]
    public partial class TblSHolderLockReleaseReason
    {
        [Key]
        [Column("kHolderLockReleaseReason")]
        public int KHolderLockReleaseReason { get; set; }
        [Required]
        [Column("sHolderLockReleaseReason")]
        [StringLength(1)]
        public string SHolderLockReleaseReason { get; set; }
        [Required]
        [Column("sHolderLockReleaseReasonDescription")]
        [StringLength(50)]
        public string SHolderLockReleaseReasonDescription { get; set; }
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
