using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_IndividualTaxTypeCode", Schema = "ctn")]
    public partial class TblSIndividualTaxTypeCode
    {
        public TblSIndividualTaxTypeCode()
        {
            TblDInformativeTax = new HashSet<TblDInformativeTax>();
            TblDTranIndvTax = new HashSet<TblDTranIndvTax>();
        }

        [Key]
        [Column("kIndividualTaxTypeCode")]
        public int KIndividualTaxTypeCode { get; set; }
        [Required]
        [Column("sCode")]
        [StringLength(4)]
        public string SCode { get; set; }
        [Required]
        [Column("sCodeName")]
        [StringLength(50)]
        public string SCodeName { get; set; }
        [Required]
        [Column("sCTNDescription")]
        [StringLength(500)]
        public string SCtndescription { get; set; }
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

        [InverseProperty("FkTaxTypeCodeNavigation")]
        public virtual ICollection<TblDInformativeTax> TblDInformativeTax { get; set; }
        [InverseProperty("FkTaxTypeCodeNavigation")]
        public virtual ICollection<TblDTranIndvTax> TblDTranIndvTax { get; set; }
    }
}
