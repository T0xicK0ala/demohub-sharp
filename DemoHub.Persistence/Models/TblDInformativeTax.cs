using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_InformativeTax", Schema = "ctn")]
    public partial class TblDInformativeTax
    {
        [Key]
        [Column("kCTNInformativeTax")]
        public int KCtninformativeTax { get; set; }
        [Column("fkTaxTypeCode")]
        public int FkTaxTypeCode { get; set; }
        public bool IsTaxExempted { get; set; }
        [Column("fkTaxExemptionReasonCode")]
        public int? FkTaxExemptionReasonCode { get; set; }
        [Column("vCreatedBy")]
        public int VCreatedBy { get; set; }
        [Column("dt2CreatedAt")]
        public DateTime Dt2CreatedAt { get; set; }
        [Column("vUpdatedBy")]
        public int? VUpdatedBy { get; set; }
        [Column("dt2UpdatedAt")]
        public DateTime Dt2UpdatedAt { get; set; }

        [ForeignKey(nameof(FkTaxExemptionReasonCode))]
        [InverseProperty(nameof(TblSTaxExemptionReasonCode.TblDInformativeTax))]
        public virtual TblSTaxExemptionReasonCode FkTaxExemptionReasonCodeNavigation { get; set; }
        [ForeignKey(nameof(FkTaxTypeCode))]
        [InverseProperty(nameof(TblSIndividualTaxTypeCode.TblDInformativeTax))]
        public virtual TblSIndividualTaxTypeCode FkTaxTypeCodeNavigation { get; set; }
    }
}
