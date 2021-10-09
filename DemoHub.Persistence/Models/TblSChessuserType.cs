using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_CHESSUserType", Schema = "chs")]
    public partial class TblSChessuserType
    {
        public TblSChessuserType()
        {
            TblDChessuser = new HashSet<TblDChessuser>();
        }

        [Key]
        [Column("kCHESSUserType")]
        public int KChessuserType { get; set; }
        [Required]
        [Column("sCHESSUserType")]
        [StringLength(4)]
        public string SChessuserType { get; set; }
        [Required]
        [Column("sCHESSUserTypeDescription")]
        [StringLength(50)]
        public string SChessuserTypeDescription { get; set; }
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

        [InverseProperty("FkChessuserTypeNavigation")]
        public virtual ICollection<TblDChessuser> TblDChessuser { get; set; }
    }
}
