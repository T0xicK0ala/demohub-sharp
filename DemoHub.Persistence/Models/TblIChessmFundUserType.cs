using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_I_CHESSmFundUserType", Schema = "chs")]
    public partial class TblIChessmFundUserType
    {
        public TblIChessmFundUserType()
        {
            TblDChessmFundUser = new HashSet<TblDChessmFundUser>();
        }

        [Key]
        [Column("kCHESSmFundUserType")]
        public int KChessmFundUserType { get; set; }
        [Required]
        [Column("sCHESSmFundUserType")]
        [StringLength(4)]
        public string SChessmFundUserType { get; set; }
        [Required]
        [Column("sCHESSmFundUserTypeDescription")]
        [StringLength(50)]
        public string SChessmFundUserTypeDescription { get; set; }
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

        [InverseProperty("FkChessmFundUserTypeNavigation")]
        public virtual ICollection<TblDChessmFundUser> TblDChessmFundUser { get; set; }
    }
}
