using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_AdviceReason", Schema = "chs")]
    public partial class TblSAdviceReason
    {
        public TblSAdviceReason()
        {
            TblRHolderDetail = new HashSet<TblRHolderDetail>();
            TblRHoldingBalance = new HashSet<TblRHoldingBalance>();
        }

        [Key]
        [Column("kAdviceReason")]
        public int KAdviceReason { get; set; }
        [Required]
        [Column("sAdviceReason")]
        [StringLength(1)]
        public string SAdviceReason { get; set; }
        [Required]
        [Column("sAdviceReasonDescription")]
        [StringLength(35)]
        public string SAdviceReasonDescription { get; set; }
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

        [InverseProperty("FkAdviceReasonNavigation")]
        public virtual ICollection<TblRHolderDetail> TblRHolderDetail { get; set; }
        [InverseProperty("FkAdviceReasonNavigation")]
        public virtual ICollection<TblRHoldingBalance> TblRHoldingBalance { get; set; }
    }
}
