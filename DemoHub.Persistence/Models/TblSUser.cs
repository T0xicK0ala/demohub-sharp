using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_User", Schema = "cli")]
    public partial class TblSUser
    {
        public TblSUser()
        {
            TblDPublicApitoken = new HashSet<TblDPublicApitoken>();
        }

        [Key]
        [Column("kUser")]
        public int KUser { get; set; }
        [Required]
        [Column("sUserName")]
        [StringLength(20)]
        public string SUserName { get; set; }
        [Required]
        [Column("sDescription")]
        [StringLength(200)]
        public string SDescription { get; set; }
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

        [InverseProperty("FkUserNavigation")]
        public virtual ICollection<TblDPublicApitoken> TblDPublicApitoken { get; set; }
    }
}
