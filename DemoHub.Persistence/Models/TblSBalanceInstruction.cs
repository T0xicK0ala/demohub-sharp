using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_BalanceInstruction", Schema = "chs")]
    public partial class TblSBalanceInstruction
    {
        [Key]
        [Column("kBalanceInstruction")]
        public int KBalanceInstruction { get; set; }
        [Required]
        [Column("sBalanceInstruction")]
        [StringLength(1)]
        public string SBalanceInstruction { get; set; }
        [Required]
        [Column("sBalanceInstructionDescription")]
        [StringLength(5)]
        public string SBalanceInstructionDescription { get; set; }
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
