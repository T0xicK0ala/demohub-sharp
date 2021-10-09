using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_AdjustmentReason", Schema = "chs")]
    public partial class TblSAdjustmentReason
    {
        public TblSAdjustmentReason()
        {
            TblRFullAdjustedSettlementInstruction = new HashSet<TblRFullAdjustedSettlementInstruction>();
        }

        [Key]
        [Column("kAdjustmentReason")]
        public int KAdjustmentReason { get; set; }
        [Required]
        [Column("sAdjustmentReason")]
        [StringLength(1)]
        public string SAdjustmentReason { get; set; }
        [Required]
        [Column("sAdjustmentReasonDescription")]
        [StringLength(25)]
        public string SAdjustmentReasonDescription { get; set; }
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

        [InverseProperty("FkAdjustmentReasonNavigation")]
        public virtual ICollection<TblRFullAdjustedSettlementInstruction> TblRFullAdjustedSettlementInstruction { get; set; }
    }
}
