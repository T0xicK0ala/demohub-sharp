using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_TotalFeeAndTaxRequest", Schema = "ctn")]
    public partial class TblDTotalFeeAndTaxRequest
    {
        public TblDTotalFeeAndTaxRequest()
        {
            TblDCalastoneTransactionRequest = new HashSet<TblDCalastoneTransactionRequest>();
        }

        [Key]
        [Column("kCTNTotalFeeAndTaxRequest")]
        public int KCtntotalFeeAndTaxRequest { get; set; }
        [Column("fkChargeCommissionTypeCode")]
        public int? FkChargeCommissionTypeCode { get; set; }
        [Column("sProprietaryID")]
        [StringLength(4)]
        public string SProprietaryId { get; set; }
        [Column("sProprietaryIssuer")]
        [StringLength(35)]
        public string SProprietaryIssuer { get; set; }
        [Column("dChargeDiscountCommissionWaivedRate", TypeName = "decimal(18, 6)")]
        public decimal? DChargeDiscountCommissionWaivedRate { get; set; }
        [Column("dChargeCommissionRate", TypeName = "decimal(18, 6)")]
        public decimal? DChargeCommissionRate { get; set; }
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

        [ForeignKey(nameof(FkChargeCommissionTypeCode))]
        [InverseProperty(nameof(TblSChargeCommissionTypeCode.TblDTotalFeeAndTaxRequest))]
        public virtual TblSChargeCommissionTypeCode FkChargeCommissionTypeCodeNavigation { get; set; }
        [InverseProperty("FkTotalFeeAndTaxNavigation")]
        public virtual ICollection<TblDCalastoneTransactionRequest> TblDCalastoneTransactionRequest { get; set; }
    }
}
