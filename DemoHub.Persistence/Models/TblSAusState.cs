using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_AusState")]
    public partial class TblSAusState
    {
        public TblSAusState()
        {
            TblRFullChesstoIssuerSponsoredConversion = new HashSet<TblRFullChesstoIssuerSponsoredConversion>();
            TblRFullIssuerSponsoredtoChessconversion = new HashSet<TblRFullIssuerSponsoredtoChessconversion>();
        }

        [Key]
        [Column("kState")]
        public int KState { get; set; }
        [Required]
        [Column("sStateCode")]
        [StringLength(3)]
        public string SStateCode { get; set; }
        [Required]
        [Column("sStateName")]
        [StringLength(30)]
        public string SStateName { get; set; }
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

        [InverseProperty("FkLocationofRegister1")]
        public virtual ICollection<TblRFullChesstoIssuerSponsoredConversion> TblRFullChesstoIssuerSponsoredConversion { get; set; }
        [InverseProperty("FkLocationofRegister1")]
        public virtual ICollection<TblRFullIssuerSponsoredtoChessconversion> TblRFullIssuerSponsoredtoChessconversion { get; set; }
    }
}
