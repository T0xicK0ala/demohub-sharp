using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_PaymentType", Schema = "chs")]
    public partial class TblSPaymentType
    {
        [Key]
        [Column("kPaymentType")]
        public int KPaymentType { get; set; }
        [Required]
        [Column("sPaymentType")]
        [StringLength(3)]
        public string SPaymentType { get; set; }
        [Required]
        [Column("sPaymentTypeDescription")]
        [StringLength(30)]
        public string SPaymentTypeDescription { get; set; }
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
