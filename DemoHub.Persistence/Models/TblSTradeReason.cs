using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_TradeReason", Schema = "chs")]
    public partial class TblSTradeReason
    {
        [Key]
        [Column("kTradeReason")]
        public int KTradeReason { get; set; }
        [Required]
        [Column("sTradeReason")]
        [StringLength(1)]
        public string STradeReason { get; set; }
        [Required]
        [Column("sTradeReasonDescription")]
        [StringLength(25)]
        public string STradeReasonDescription { get; set; }
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
