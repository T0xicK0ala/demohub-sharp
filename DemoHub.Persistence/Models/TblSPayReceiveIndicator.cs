using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_PayReceiveIndicator", Schema = "chs")]
    public partial class TblSPayReceiveIndicator
    {
        public TblSPayReceiveIndicator()
        {
            TblREffectedNetFundsMovement = new HashSet<TblREffectedNetFundsMovement>();
            TblRParticipantCounterpartyBalance = new HashSet<TblRParticipantCounterpartyBalance>();
        }

        [Key]
        [Column("kPayReceive")]
        public int KPayReceive { get; set; }
        [Required]
        [Column("sPayReceive")]
        [StringLength(1)]
        public string SPayReceive { get; set; }
        [Required]
        [Column("sPayReceiveDescription")]
        [StringLength(10)]
        public string SPayReceiveDescription { get; set; }
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

        [InverseProperty("FkPayReceiveIndicatorNavigation")]
        public virtual ICollection<TblREffectedNetFundsMovement> TblREffectedNetFundsMovement { get; set; }
        [InverseProperty("FkPayReceiveIndicatorNavigation")]
        public virtual ICollection<TblRParticipantCounterpartyBalance> TblRParticipantCounterpartyBalance { get; set; }
    }
}
