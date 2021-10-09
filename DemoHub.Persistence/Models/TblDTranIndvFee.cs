using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_TranIndvFee", Schema = "ctn")]
    public partial class TblDTranIndvFee
    {
        [Key]
        [Column("kTranIndvFee")]
        public int KTranIndvFee { get; set; }
        [Column("fkChargeCommissionTypeCode")]
        public int FkChargeCommissionTypeCode { get; set; }
        [Column("fkChargeCommissionBasisCode")]
        public int FkChargeCommissionBasisCode { get; set; }
        [Column("dChargeCommissionAmount", TypeName = "decimal(20, 6)")]
        public decimal? DChargeCommissionAmount { get; set; }
        [Column("dChargeCommissionRate", TypeName = "decimal(18, 6)")]
        public decimal? DChargeCommissionRate { get; set; }
        [Column("dDiscountAmount", TypeName = "decimal(20, 6)")]
        public decimal? DDiscountAmount { get; set; }
        [Column("dDiscountRate", TypeName = "decimal(18, 6)")]
        public decimal? DDiscountRate { get; set; }
        [Column("dAppliedAmount", TypeName = "decimal(20, 6)")]
        public decimal? DAppliedAmount { get; set; }
        [Column("dAppliedRate", TypeName = "decimal(18, 6)")]
        public decimal? DAppliedRate { get; set; }
        [Column("bInformativeIndicator")]
        public bool BInformativeIndicator { get; set; }
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

        [ForeignKey(nameof(FkChargeCommissionBasisCode))]
        [InverseProperty(nameof(TblSTaxationBasisCode.TblDTranIndvFee))]
        public virtual TblSTaxationBasisCode FkChargeCommissionBasisCodeNavigation { get; set; }
        [ForeignKey(nameof(FkChargeCommissionTypeCode))]
        [InverseProperty(nameof(TblSChargeCommissionTypeCode.TblDTranIndvFee))]
        public virtual TblSChargeCommissionTypeCode FkChargeCommissionTypeCodeNavigation { get; set; }
    }
}
