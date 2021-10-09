using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_RejectedReason", Schema = "chs")]
    public partial class TblSRejectedReason
    {
        [Key]
        [Column("kRejectedReason")]
        public int KRejectedReason { get; set; }
        [Required]
        [Column("sCode")]
        [StringLength(5)]
        public string SCode { get; set; }
        [Required]
        [Column("sDescription")]
        [StringLength(200)]
        public string SDescription { get; set; }
        [Column("bIsHighlighted")]
        public bool? BIsHighlighted { get; set; }
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
