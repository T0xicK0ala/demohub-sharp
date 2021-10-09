using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_RescheduleReason", Schema = "chs")]
    public partial class TblSRescheduleReason
    {
        public TblSRescheduleReason()
        {
            TblRRescheduledSettlementInstruction = new HashSet<TblRRescheduledSettlementInstruction>();
        }

        [Key]
        [Column("kRescheduleReason")]
        public int KRescheduleReason { get; set; }
        [Required]
        [Column("sRescheduleReason")]
        [StringLength(1)]
        public string SRescheduleReason { get; set; }
        [Required]
        [Column("sRescheduleReasonDescription")]
        [StringLength(30)]
        public string SRescheduleReasonDescription { get; set; }
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

        [InverseProperty("FkRescheduleReasonNavigation")]
        public virtual ICollection<TblRRescheduledSettlementInstruction> TblRRescheduledSettlementInstruction { get; set; }
    }
}
