using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_GuaranteedForeignIndicator", Schema = "chs")]
    public partial class TblSGuaranteedForeignIndicator
    {
        public TblSGuaranteedForeignIndicator()
        {
            TblRFullAdjustedSettlementInstructionFkPreviousGuaranteedForeignIndicatorNavigation = new HashSet<TblRFullAdjustedSettlementInstruction>();
            TblRFullAdjustedSettlementInstructionFkRevisedGuaranteedForeignIndicatorNavigation = new HashSet<TblRFullAdjustedSettlementInstruction>();
            TblRFullChesstoIssuerSponsoredConversion = new HashSet<TblRFullChesstoIssuerSponsoredConversion>();
            TblRFullIssuerSponsoredtoChessconversion = new HashSet<TblRFullIssuerSponsoredtoChessconversion>();
            TblRFullSettlementInstruction = new HashSet<TblRFullSettlementInstruction>();
        }

        [Key]
        [Column("kGuaranteedForeign")]
        public int KGuaranteedForeign { get; set; }
        [Required]
        [Column("sGuaranteedForeign")]
        [StringLength(2)]
        public string SGuaranteedForeign { get; set; }
        [Required]
        [Column("sGuaranteedForeignDescription")]
        [StringLength(40)]
        public string SGuaranteedForeignDescription { get; set; }
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

        [InverseProperty(nameof(TblRFullAdjustedSettlementInstruction.FkPreviousGuaranteedForeignIndicatorNavigation))]
        public virtual ICollection<TblRFullAdjustedSettlementInstruction> TblRFullAdjustedSettlementInstructionFkPreviousGuaranteedForeignIndicatorNavigation { get; set; }
        [InverseProperty(nameof(TblRFullAdjustedSettlementInstruction.FkRevisedGuaranteedForeignIndicatorNavigation))]
        public virtual ICollection<TblRFullAdjustedSettlementInstruction> TblRFullAdjustedSettlementInstructionFkRevisedGuaranteedForeignIndicatorNavigation { get; set; }
        [InverseProperty("FkGuaranteedForeignIndicatorNavigation")]
        public virtual ICollection<TblRFullChesstoIssuerSponsoredConversion> TblRFullChesstoIssuerSponsoredConversion { get; set; }
        [InverseProperty("FkGuaranteedForeignIndicatorNavigation")]
        public virtual ICollection<TblRFullIssuerSponsoredtoChessconversion> TblRFullIssuerSponsoredtoChessconversion { get; set; }
        [InverseProperty("FkGuaranteedForeignIndicatorNavigation")]
        public virtual ICollection<TblRFullSettlementInstruction> TblRFullSettlementInstruction { get; set; }
    }
}
