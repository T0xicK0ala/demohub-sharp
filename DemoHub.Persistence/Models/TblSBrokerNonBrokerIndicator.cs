using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_BrokerNonBrokerIndicator", Schema = "chs")]
    public partial class TblSBrokerNonBrokerIndicator
    {
        public TblSBrokerNonBrokerIndicator()
        {
            TblRChessconversionRequesttoIssuerSponsoredFund = new HashSet<TblRChessconversionRequesttoIssuerSponsoredFund>();
            TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest = new HashSet<TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest>();
        }

        [Key]
        [Column("kBrokerNonBroker")]
        public int KBrokerNonBroker { get; set; }
        [Required]
        [Column("sBrokerNonBroker")]
        [StringLength(1)]
        public string SBrokerNonBroker { get; set; }
        [Required]
        [Column("sBrokerNonBrokerDescription")]
        [StringLength(10)]
        public string SBrokerNonBrokerDescription { get; set; }
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

        [InverseProperty("FkBrokerNonbrokerIndicatorNavigation")]
        public virtual ICollection<TblRChessconversionRequesttoIssuerSponsoredFund> TblRChessconversionRequesttoIssuerSponsoredFund { get; set; }
        [InverseProperty("FkBrokerNonbrokerIndicatorNavigation")]
        public virtual ICollection<TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest> TblRIssuerSponsoredFundtoChessconversionAuthorisationRequest { get; set; }
    }
}
