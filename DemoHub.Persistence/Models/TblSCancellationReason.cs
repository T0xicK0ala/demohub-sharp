using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_CancellationReason", Schema = "chs")]
    public partial class TblSCancellationReason
    {
        public TblSCancellationReason()
        {
            TblRCancelledSettlementInstruction = new HashSet<TblRCancelledSettlementInstruction>();
        }

        [Key]
        [Column("kCancellationReason")]
        public int KCancellationReason { get; set; }
        [Required]
        [Column("sCancellationReason")]
        [StringLength(1)]
        public string SCancellationReason { get; set; }
        [Required]
        [Column("sCancellationReasonDescription")]
        [StringLength(110)]
        public string SCancellationReasonDescription { get; set; }
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

        [InverseProperty("FkCancellationReasonNavigation")]
        public virtual ICollection<TblRCancelledSettlementInstruction> TblRCancelledSettlementInstruction { get; set; }
    }
}
