using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_HolderStatusChange", Schema = "chs")]
    public partial class TblSHolderStatusChange
    {
        [Key]
        [Column("kHolderStatusChange")]
        public int KHolderStatusChange { get; set; }
        [Required]
        [Column("sHolderStatusChange")]
        [StringLength(1)]
        public string SHolderStatusChange { get; set; }
        [Required]
        [Column("sHolderStatusChangeDescription")]
        [StringLength(40)]
        public string SHolderStatusChangeDescription { get; set; }
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
