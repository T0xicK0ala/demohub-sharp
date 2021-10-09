using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_AdjustmentHistoryStatus", Schema = "chs")]
    public partial class TblSAdjustmentHistoryStatus
    {
        public TblSAdjustmentHistoryStatus()
        {
            TblRFullAdjustedSettlementInstruction = new HashSet<TblRFullAdjustedSettlementInstruction>();
        }

        [Key]
        [Column("kAdjustmentHistoryStatus")]
        public int KAdjustmentHistoryStatus { get; set; }
        [Required]
        [Column("sAdjustmentHistoryStatus")]
        [StringLength(1)]
        public string SAdjustmentHistoryStatus { get; set; }
        [Required]
        [Column("sAdjustmentHistoryStatusDescription")]
        [StringLength(10)]
        public string SAdjustmentHistoryStatusDescription { get; set; }
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

        [InverseProperty("FkAdjustmentHistoryStatusNavigation")]
        public virtual ICollection<TblRFullAdjustedSettlementInstruction> TblRFullAdjustedSettlementInstruction { get; set; }
    }
}
