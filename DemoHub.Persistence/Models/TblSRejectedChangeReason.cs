using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_RejectedChangeReason", Schema = "chs")]
    public partial class TblSRejectedChangeReason
    {
        [Key]
        [Column("kRejectedChangeReason")]
        public int KRejectedChangeReason { get; set; }
        [Required]
        [Column("sRejectedChangeReason")]
        [StringLength(1)]
        public string SRejectedChangeReason { get; set; }
        [Required]
        [Column("sRejectedChangeReasonDescription")]
        [StringLength(70)]
        public string SRejectedChangeReasonDescription { get; set; }
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
