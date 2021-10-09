using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_UserType", Schema = "chs")]
    public partial class TblSUserType
    {
        public TblSUserType()
        {
            TblRUserDetailHistory = new HashSet<TblRUserDetailHistory>();
        }

        [Key]
        [Column("kUserType")]
        public int KUserType { get; set; }
        [Required]
        [Column("sUserType")]
        [StringLength(1)]
        public string SUserType { get; set; }
        [Required]
        [Column("sUserTypeDescription")]
        [StringLength(20)]
        public string SUserTypeDescription { get; set; }
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

        [InverseProperty("FkUserTypeNavigation")]
        public virtual ICollection<TblRUserDetailHistory> TblRUserDetailHistory { get; set; }
    }
}
