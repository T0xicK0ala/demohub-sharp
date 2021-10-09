using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_HolderStatus", Schema = "chs")]
    public partial class TblSHolderStatus
    {
        public TblSHolderStatus()
        {
            TblDHolder = new HashSet<TblDHolder>();
            TblRHolderDetail = new HashSet<TblRHolderDetail>();
            TblRHolderHistory = new HashSet<TblRHolderHistory>();
            TblRHoldingRegistrationDetails = new HashSet<TblRHoldingRegistrationDetails>();
        }

        [Key]
        [Column("kHolderStatus")]
        public int KHolderStatus { get; set; }
        [Required]
        [Column("sHolderStatus")]
        [StringLength(1)]
        public string SHolderStatus { get; set; }
        [Required]
        [Column("sHolderStatusDescription")]
        [StringLength(65)]
        public string SHolderStatusDescription { get; set; }
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

        [InverseProperty("FkHolderStatusNavigation")]
        public virtual ICollection<TblDHolder> TblDHolder { get; set; }
        [InverseProperty("FkHolderStatusNavigation")]
        public virtual ICollection<TblRHolderDetail> TblRHolderDetail { get; set; }
        [InverseProperty("FkHolderStatusNavigation")]
        public virtual ICollection<TblRHolderHistory> TblRHolderHistory { get; set; }
        [InverseProperty("FkHolderStatusNavigation")]
        public virtual ICollection<TblRHoldingRegistrationDetails> TblRHoldingRegistrationDetails { get; set; }
    }
}
