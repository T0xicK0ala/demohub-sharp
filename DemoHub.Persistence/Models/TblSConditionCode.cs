using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_ConditionCode", Schema = "chs")]
    public partial class TblSConditionCode
    {
        [Key]
        [Column("kConditionCode")]
        public int KConditionCode { get; set; }
        [Required]
        [Column("sConditionCode")]
        [StringLength(2)]
        public string SConditionCode { get; set; }
        [Required]
        [Column("sConditionCodeDescription")]
        [StringLength(80)]
        public string SConditionCodeDescription { get; set; }
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
