using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_TranIndvTax", Schema = "ctn")]
    public partial class TblDTranIndvTax
    {
        [Key]
        [Column("kTranIndvTax")]
        public int KTranIndvTax { get; set; }
        [Column("fkTaxTypeCode")]
        public int? FkTaxTypeCode { get; set; }
        [Column("dTaxAmount", TypeName = "decimal(20, 6)")]
        public decimal? DTaxAmount { get; set; }
        [Column("dTaxRate", TypeName = "decimal(18, 6)")]
        public decimal DTaxRate { get; set; }
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

        [ForeignKey(nameof(FkTaxTypeCode))]
        [InverseProperty(nameof(TblSIndividualTaxTypeCode.TblDTranIndvTax))]
        public virtual TblSIndividualTaxTypeCode FkTaxTypeCodeNavigation { get; set; }
    }
}
