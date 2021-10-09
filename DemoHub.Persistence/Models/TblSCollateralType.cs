using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_CollateralType", Schema = "chs")]
    public partial class TblSCollateralType
    {
        [Key]
        [Column("kCollateralType")]
        public int KCollateralType { get; set; }
        [Required]
        [Column("sCollateralType")]
        [StringLength(3)]
        public string SCollateralType { get; set; }
        [Required]
        [Column("sCollateralTypeDescription")]
        [StringLength(40)]
        public string SCollateralTypeDescription { get; set; }
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
