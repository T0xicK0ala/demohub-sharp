using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_RegistryRejectReason", Schema = "chs")]
    public partial class TblSRegistryRejectReason
    {
        [Key]
        [Column("kRegistryRejectReason")]
        public int KRegistryRejectReason { get; set; }
        [Required]
        [Column("sRegistryRejectReason")]
        [StringLength(1)]
        public string SRegistryRejectReason { get; set; }
        [Required]
        [Column("sRegistryRejectReasonDescription")]
        [StringLength(300)]
        public string SRegistryRejectReasonDescription { get; set; }
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
