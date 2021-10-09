using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_LevyType", Schema = "chs")]
    public partial class TblSLevyType
    {
        [Key]
        [Column("kLevyType")]
        public int KLevyType { get; set; }
        [Required]
        [Column("sLevyType")]
        [StringLength(1)]
        public string SLevyType { get; set; }
        [Required]
        [Column("sLevyTypeDescription")]
        [StringLength(30)]
        public string SLevyTypeDescription { get; set; }
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
