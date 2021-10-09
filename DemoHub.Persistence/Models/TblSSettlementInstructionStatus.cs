using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_SettlementInstructionStatus", Schema = "chs")]
    public partial class TblSSettlementInstructionStatus
    {
        public TblSSettlementInstructionStatus()
        {
            TblRFullAdjustedSettlementInstructionFkPreviousStatusNavigation = new HashSet<TblRFullAdjustedSettlementInstruction>();
            TblRFullAdjustedSettlementInstructionFkRevisedStatusNavigation = new HashSet<TblRFullAdjustedSettlementInstruction>();
            TblRFullSettlementInstruction = new HashSet<TblRFullSettlementInstruction>();
        }

        [Key]
        [Column("kSettlementInstructionStatus")]
        public int KSettlementInstructionStatus { get; set; }
        [Required]
        [Column("sSettlementInstructionStatus")]
        [StringLength(1)]
        public string SSettlementInstructionStatus { get; set; }
        [Required]
        [Column("sSettlementInstructionStatusDescription")]
        [StringLength(20)]
        public string SSettlementInstructionStatusDescription { get; set; }
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

        [InverseProperty(nameof(TblRFullAdjustedSettlementInstruction.FkPreviousStatusNavigation))]
        public virtual ICollection<TblRFullAdjustedSettlementInstruction> TblRFullAdjustedSettlementInstructionFkPreviousStatusNavigation { get; set; }
        [InverseProperty(nameof(TblRFullAdjustedSettlementInstruction.FkRevisedStatusNavigation))]
        public virtual ICollection<TblRFullAdjustedSettlementInstruction> TblRFullAdjustedSettlementInstructionFkRevisedStatusNavigation { get; set; }
        [InverseProperty("FkSettlementInstructionStatusNavigation")]
        public virtual ICollection<TblRFullSettlementInstruction> TblRFullSettlementInstruction { get; set; }
    }
}
