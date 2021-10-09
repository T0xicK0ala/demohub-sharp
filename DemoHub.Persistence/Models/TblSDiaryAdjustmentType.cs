using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_DiaryAdjustmentType", Schema = "chs")]
    public partial class TblSDiaryAdjustmentType
    {
        public TblSDiaryAdjustmentType()
        {
            TblRFullAdjustedSettlementInstruction = new HashSet<TblRFullAdjustedSettlementInstruction>();
        }

        [Key]
        [Column("kDiaryAdjustmentType")]
        public int KDiaryAdjustmentType { get; set; }
        [Required]
        [Column("sDiaryAdjustmentType")]
        [StringLength(1)]
        public string SDiaryAdjustmentType { get; set; }
        [Required]
        [Column("sDiaryAdjustmentTypeDescription")]
        [StringLength(30)]
        public string SDiaryAdjustmentTypeDescription { get; set; }
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

        [InverseProperty("FkDiaryAdjustmentTypeNavigation")]
        public virtual ICollection<TblRFullAdjustedSettlementInstruction> TblRFullAdjustedSettlementInstruction { get; set; }
    }
}
