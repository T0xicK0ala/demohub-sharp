using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_SettlementStep", Schema = "chs")]
    public partial class TblSSettlementStep
    {
        [Key]
        [Column("kSettlementStep")]
        public int KSettlementStep { get; set; }
        [Required]
        [Column("sSettlementStep")]
        [StringLength(1)]
        public string SSettlementStep { get; set; }
        [Required]
        [Column("sSettlementStepDescription")]
        [StringLength(20)]
        public string SSettlementStepDescription { get; set; }
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
    }
}
