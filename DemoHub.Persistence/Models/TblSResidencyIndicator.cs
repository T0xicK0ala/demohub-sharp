using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_ResidencyIndicator", Schema = "chs")]
    public partial class TblSResidencyIndicator
    {
        public TblSResidencyIndicator()
        {
            TblRFullIssuerSponsoredtoChessconversion = new HashSet<TblRFullIssuerSponsoredtoChessconversion>();
            TblRHolderDetail = new HashSet<TblRHolderDetail>();
            TblRHolderHistory = new HashSet<TblRHolderHistory>();
            TblRHoldingRegistrationDetails = new HashSet<TblRHoldingRegistrationDetails>();
            TblRTopSecurityHolderReport = new HashSet<TblRTopSecurityHolderReport>();
        }

        [Key]
        [Column("kResidency")]
        public int KResidency { get; set; }
        [Required]
        [Column("sResidency")]
        [StringLength(1)]
        public string SResidency { get; set; }
        [Required]
        [Column("sResidencyDescription")]
        [StringLength(10)]
        public string SResidencyDescription { get; set; }
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

        [InverseProperty("FkReceivingResidencyIndicatorNavigation")]
        public virtual ICollection<TblRFullIssuerSponsoredtoChessconversion> TblRFullIssuerSponsoredtoChessconversion { get; set; }
        [InverseProperty("FkResidencyIndicatorNavigation")]
        public virtual ICollection<TblRHolderDetail> TblRHolderDetail { get; set; }
        [InverseProperty("FkResidencyIndicatorNavigation")]
        public virtual ICollection<TblRHolderHistory> TblRHolderHistory { get; set; }
        [InverseProperty("FkResidencyIndicatorNavigation")]
        public virtual ICollection<TblRHoldingRegistrationDetails> TblRHoldingRegistrationDetails { get; set; }
        [InverseProperty("FkResidencyIndicatorNavigation")]
        public virtual ICollection<TblRTopSecurityHolderReport> TblRTopSecurityHolderReport { get; set; }
    }
}
