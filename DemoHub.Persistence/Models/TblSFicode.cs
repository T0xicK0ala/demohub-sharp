using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_FICode", Schema = "chs")]
    public partial class TblSFicode
    {
        [Key]
        [Column("kFICode")]
        public int KFicode { get; set; }
        [Required]
        [Column("vFICode")]
        [StringLength(11)]
        public string VFicode { get; set; }
        [Column("vFIName")]
        [StringLength(200)]
        public string VFiname { get; set; }
        [Column("dt2CreatedAt")]
        public DateTime Dt2CreatedAt { get; set; }
        [Column("vCreatedBy")]
        public int? VCreatedBy { get; set; }
        [Column("vUpdatedBy")]
        public int? VUpdatedBy { get; set; }
        [Column("dt2UpdatedAt")]
        public DateTime Dt2UpdatedAt { get; set; }
        [Required]
        [Column("zVersion")]
        public byte[] ZVersion { get; set; }
        [Column("iIdentityCode")]
        [StringLength(20)]
        public string IIdentityCode { get; set; }
    }
}
