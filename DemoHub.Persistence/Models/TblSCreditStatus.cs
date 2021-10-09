using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_CreditStatus", Schema = "chs")]
    public partial class TblSCreditStatus
    {
        [Key]
        [Column("kCreditStatus")]
        public int KCreditStatus { get; set; }
        [Required]
        [Column("sCreditStatus")]
        [StringLength(1)]
        public string SCreditStatus { get; set; }
        [Required]
        [Column("sCreditStatusDescription")]
        [StringLength(10)]
        public string SCreditStatusDescription { get; set; }
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
