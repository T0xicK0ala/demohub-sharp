using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_ForeignExchangeDetail", Schema = "ctn")]
    public partial class TblDForeignExchangeDetail
    {
        [Key]
        [Column("kForeignExchangeDetail")]
        public int KForeignExchangeDetail { get; set; }
        [Column("dToAmount", TypeName = "decimal(20, 6)")]
        public decimal? DToAmount { get; set; }
        [Column("dFromAmount", TypeName = "decimal(20, 6)")]
        public decimal? DFromAmount { get; set; }
        [Column("fkUnitCurrency")]
        public int FkUnitCurrency { get; set; }
        [Column("fkQuotedCurrency")]
        public int FkQuotedCurrency { get; set; }
        [Column("dExchangeRate", TypeName = "decimal(18, 6)")]
        public decimal DExchangeRate { get; set; }
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
