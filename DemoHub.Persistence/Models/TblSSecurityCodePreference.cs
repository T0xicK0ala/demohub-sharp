using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_SecurityCodePreference", Schema = "chs")]
    public partial class TblSSecurityCodePreference
    {
        public TblSSecurityCodePreference()
        {
            TblRUserDetailHistory = new HashSet<TblRUserDetailHistory>();
        }

        [Key]
        [Column("kSecurityCodePreference")]
        public int KSecurityCodePreference { get; set; }
        [Required]
        [Column("sSecurityCodePreference")]
        [StringLength(1)]
        public string SSecurityCodePreference { get; set; }
        [Required]
        [Column("sSecurityCodePreferenceDescription")]
        [StringLength(10)]
        public string SSecurityCodePreferenceDescription { get; set; }
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

        [InverseProperty("FkSecurityCodePreferenceNavigation")]
        public virtual ICollection<TblRUserDetailHistory> TblRUserDetailHistory { get; set; }
    }
}
