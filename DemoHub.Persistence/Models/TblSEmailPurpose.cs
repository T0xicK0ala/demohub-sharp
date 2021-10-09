using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_EmailPurpose", Schema = "chs")]
    public partial class TblSEmailPurpose
    {
        public TblSEmailPurpose()
        {
            TblDHolder = new HashSet<TblDHolder>();
            TblRChessconversionRequesttoIssuerSponsoredFund = new HashSet<TblRChessconversionRequesttoIssuerSponsoredFund>();
            TblRHolderHistory = new HashSet<TblRHolderHistory>();
            TblRHoldingRegistrationDetails = new HashSet<TblRHoldingRegistrationDetails>();
        }

        [Key]
        [Column("kEmailPurpose")]
        public int KEmailPurpose { get; set; }
        [Required]
        [Column("sEmailPurpose")]
        [StringLength(1)]
        public string SEmailPurpose { get; set; }
        [Required]
        [Column("sEmailPurposeDescription")]
        [StringLength(60)]
        public string SEmailPurposeDescription { get; set; }
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

        [InverseProperty("FkEmailPurposeNavigation")]
        public virtual ICollection<TblDHolder> TblDHolder { get; set; }
        [InverseProperty("FkEmailPurposeNavigation")]
        public virtual ICollection<TblRChessconversionRequesttoIssuerSponsoredFund> TblRChessconversionRequesttoIssuerSponsoredFund { get; set; }
        [InverseProperty("FkEmailPurposeNavigation")]
        public virtual ICollection<TblRHolderHistory> TblRHolderHistory { get; set; }
        [InverseProperty("FkEmailPurposeNavigation")]
        public virtual ICollection<TblRHoldingRegistrationDetails> TblRHoldingRegistrationDetails { get; set; }
    }
}
