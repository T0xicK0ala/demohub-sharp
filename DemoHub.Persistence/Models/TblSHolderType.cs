using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_HolderType", Schema = "chs")]
    public partial class TblSHolderType
    {
        public TblSHolderType()
        {
            TblDHolder = new HashSet<TblDHolder>();
            TblRHolderDetail = new HashSet<TblRHolderDetail>();
            TblRHolderHistory = new HashSet<TblRHolderHistory>();
            TblRHoldingRegistrationDetails = new HashSet<TblRHoldingRegistrationDetails>();
        }

        [Key]
        [Column("kHolderType")]
        public int KHolderType { get; set; }
        [Required]
        [Column("sHolderType")]
        [StringLength(1)]
        public string SHolderType { get; set; }
        [Required]
        [Column("sHolderTypeDescription")]
        [StringLength(10)]
        public string SHolderTypeDescription { get; set; }
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

        [InverseProperty("FkHolderTypeNavigation")]
        public virtual ICollection<TblDHolder> TblDHolder { get; set; }
        [InverseProperty("FkHolderTypeNavigation")]
        public virtual ICollection<TblRHolderDetail> TblRHolderDetail { get; set; }
        [InverseProperty("FkHolderTypeNavigation")]
        public virtual ICollection<TblRHolderHistory> TblRHolderHistory { get; set; }
        [InverseProperty("FkHolderTypeNavigation")]
        public virtual ICollection<TblRHoldingRegistrationDetails> TblRHoldingRegistrationDetails { get; set; }
    }
}
