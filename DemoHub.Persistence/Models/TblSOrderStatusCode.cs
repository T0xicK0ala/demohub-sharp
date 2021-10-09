using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_OrderStatusCode", Schema = "ctn")]
    public partial class TblSOrderStatusCode
    {
        [Key]
        [Column("kOrderStatusCode")]
        public int KOrderStatusCode { get; set; }
        [Required]
        [Column("sCode")]
        [StringLength(4)]
        public string SCode { get; set; }
        [Column("IsUsedByCTN")]
        public bool IsUsedByCtn { get; set; }
        [Column("sCTNDescription")]
        [StringLength(500)]
        public string SCtndescription { get; set; }
        [Column("sISO20022Desc")]
        [StringLength(500)]
        public string SIso20022desc { get; set; }
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
