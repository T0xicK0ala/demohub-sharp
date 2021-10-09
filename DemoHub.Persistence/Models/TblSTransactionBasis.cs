using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_TransactionBasis", Schema = "chs")]
    public partial class TblSTransactionBasis
    {
        public TblSTransactionBasis()
        {
            TblRFullAdjustedSettlementInstructionFkPreviousTransactionBasisNavigation = new HashSet<TblRFullAdjustedSettlementInstruction>();
            TblRFullAdjustedSettlementInstructionFkRevisedTransactionBasisNavigation = new HashSet<TblRFullAdjustedSettlementInstruction>();
            TblRFullSettlementInstruction = new HashSet<TblRFullSettlementInstruction>();
        }

        [Key]
        [Column("kTransactionBasis")]
        public int KTransactionBasis { get; set; }
        [Required]
        [Column("sTransactionBasis")]
        [StringLength(1)]
        public string STransactionBasis { get; set; }
        [Required]
        [Column("sTransactionBasisDescription")]
        [StringLength(40)]
        public string STransactionBasisDescription { get; set; }
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

        [InverseProperty(nameof(TblRFullAdjustedSettlementInstruction.FkPreviousTransactionBasisNavigation))]
        public virtual ICollection<TblRFullAdjustedSettlementInstruction> TblRFullAdjustedSettlementInstructionFkPreviousTransactionBasisNavigation { get; set; }
        [InverseProperty(nameof(TblRFullAdjustedSettlementInstruction.FkRevisedTransactionBasisNavigation))]
        public virtual ICollection<TblRFullAdjustedSettlementInstruction> TblRFullAdjustedSettlementInstructionFkRevisedTransactionBasisNavigation { get; set; }
        [InverseProperty("FkTransactionBasisNavigation")]
        public virtual ICollection<TblRFullSettlementInstruction> TblRFullSettlementInstruction { get; set; }
    }
}
