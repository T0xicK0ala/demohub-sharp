using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_Currency")]
    public partial class TblSCurrency
    {
        [Key]
        [Column("kCurrency")]
        public int KCurrency { get; set; }
        [Column("vCurrencyCode")]
        [StringLength(3)]
        public string VCurrencyCode { get; set; }
        [Column("vCurrencyName")]
        [StringLength(60)]
        public string VCurrencyName { get; set; }
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
