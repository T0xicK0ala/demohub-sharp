using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_Reason", Schema = "chs")]
    public partial class TblSReason
    {
        [Key]
        [Column("kReason")]
        public int KReason { get; set; }
        [Required]
        [Column("sReason")]
        [StringLength(3)]
        public string SReason { get; set; }
        [Required]
        [Column("sReasonDescription")]
        [StringLength(65)]
        public string SReasonDescription { get; set; }
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
