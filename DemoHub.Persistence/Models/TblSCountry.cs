using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_Country")]
    public partial class TblSCountry
    {
        public TblSCountry()
        {
            TblRFullChesstoIssuerSponsoredConversion = new HashSet<TblRFullChesstoIssuerSponsoredConversion>();
            TblRFullIssuerSponsoredtoChessconversion = new HashSet<TblRFullIssuerSponsoredtoChessconversion>();
        }

        [Key]
        [Column("kCountry")]
        public int KCountry { get; set; }
        [Column("vCountryCode")]
        [StringLength(3)]
        public string VCountryCode { get; set; }
        [Column("vCountryName")]
        [StringLength(60)]
        public string VCountryName { get; set; }
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

        [InverseProperty("FkLocationofRegisterNavigation")]
        public virtual ICollection<TblRFullChesstoIssuerSponsoredConversion> TblRFullChesstoIssuerSponsoredConversion { get; set; }
        [InverseProperty("FkLocationofRegisterNavigation")]
        public virtual ICollection<TblRFullIssuerSponsoredtoChessconversion> TblRFullIssuerSponsoredtoChessconversion { get; set; }
    }
}
