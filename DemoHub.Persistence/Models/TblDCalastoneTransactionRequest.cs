using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_CalastoneTransactionRequest", Schema = "trn")]
    public partial class TblDCalastoneTransactionRequest
    {
        [Key]
        [Column("kTransactionRequest")]
        public int KTransactionRequest { get; set; }
        [Column("fkTransactionType")]
        public int FkTransactionType { get; set; }
        [Column("fkTransactionRequestStatus")]
        public int FkTransactionRequestStatus { get; set; }
        [Column("fkTransactionRequestRejectedReasonCode")]
        public int? FkTransactionRequestRejectedReasonCode { get; set; }
        [Column("sAdditionalRejectedReason")]
        [StringLength(350)]
        public string SAdditionalRejectedReason { get; set; }
        [Column("sRegTransactionNumber")]
        [StringLength(50)]
        public string SRegTransactionNumber { get; set; }
        [Required]
        [Column("sMessageID")]
        [StringLength(35)]
        public string SMessageId { get; set; }
        [Column("dtMessageCreationDateTime")]
        public DateTime DtMessageCreationDateTime { get; set; }
        [Required]
        [Column("sAccountID")]
        [StringLength(35)]
        public string SAccountId { get; set; }
        [Column("sAccountDesignation")]
        [StringLength(35)]
        public string SAccountDesignation { get; set; }
        [Column("sAgentCode")]
        [StringLength(35)]
        public string SAgentCode { get; set; }
        [Required]
        [Column("sOrderReference")]
        [StringLength(35)]
        public string SOrderReference { get; set; }
        [Column("fkFundIDType")]
        public int FkFundIdtype { get; set; }
        [Required]
        [Column("sFundID")]
        [StringLength(35)]
        public string SFundId { get; set; }
        [Column("sAPIRCode")]
        [StringLength(9)]
        public string SApircode { get; set; }
        [Column("iRegFundClassID")]
        public int? IRegFundClassId { get; set; }
        [Column("sFundName")]
        [StringLength(35)]
        public string SFundName { get; set; }
        [Column("sProductCode")]
        [StringLength(35)]
        public string SProductCode { get; set; }
        [Column("iRegProductID")]
        public int? IRegProductId { get; set; }
        [Column("sRegProductName")]
        [StringLength(100)]
        public string SRegProductName { get; set; }
        [Column("dUnit", TypeName = "decimal(20, 6)")]
        public decimal? DUnit { get; set; }
        [Column("dGrossAmount", TypeName = "decimal(20, 6)")]
        public decimal? DGrossAmount { get; set; }
        [Column("fkGrossAmountCurrency")]
        public int? FkGrossAmountCurrency { get; set; }
        [Column("dHoldingsRedemptionRate", TypeName = "decimal(18, 6)")]
        public decimal? DHoldingsRedemptionRate { get; set; }
        [Column("dPercentageOfRedemptionAmount", TypeName = "decimal(18, 6)")]
        public decimal? DPercentageOfRedemptionAmount { get; set; }
        [Column("fkRoundingCode")]
        public int? FkRoundingCode { get; set; }
        [Column("fkUnitGroupCode")]
        public int? FkUnitGroupCode { get; set; }
        [Column("isPhysicalDeliverable")]
        public bool IsPhysicalDeliverable { get; set; }
        [Column("fkRequestedSettlementCurrency")]
        public int? FkRequestedSettlementCurrency { get; set; }
        [Column("fkRequestedPricingCurrency")]
        public int? FkRequestedPricingCurrency { get; set; }
        [Required]
        [Column("sFundManagerID")]
        [StringLength(35)]
        public string SFundManagerId { get; set; }
        [Column("sLegOrderReference")]
        [StringLength(35)]
        public string SLegOrderReference { get; set; }
        [Column("dtExpectedEffectivateDate", TypeName = "date")]
        public DateTime? DtExpectedEffectivateDate { get; set; }
        [Column("dtExpectedSettlementDate", TypeName = "date")]
        public DateTime? DtExpectedSettlementDate { get; set; }
        [Column("fkDistributorCode")]
        public int FkDistributorCode { get; set; }
        [Column("fkTotalFeeAndTax")]
        public int? FkTotalFeeAndTax { get; set; }
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

        [ForeignKey(nameof(FkDistributorCode))]
        [InverseProperty(nameof(TblSInvestmentFundRoleCode.TblDCalastoneTransactionRequest))]
        public virtual TblSInvestmentFundRoleCode FkDistributorCodeNavigation { get; set; }
        [ForeignKey(nameof(FkFundIdtype))]
        [InverseProperty(nameof(TblIFundIdtype.TblDCalastoneTransactionRequest))]
        public virtual TblIFundIdtype FkFundIdtypeNavigation { get; set; }
        [ForeignKey(nameof(FkRoundingCode))]
        [InverseProperty(nameof(TblSRoundingCode.TblDCalastoneTransactionRequest))]
        public virtual TblSRoundingCode FkRoundingCodeNavigation { get; set; }
        [ForeignKey(nameof(FkTotalFeeAndTax))]
        [InverseProperty(nameof(TblDTotalFeeAndTaxRequest.TblDCalastoneTransactionRequest))]
        public virtual TblDTotalFeeAndTaxRequest FkTotalFeeAndTaxNavigation { get; set; }
        [ForeignKey(nameof(FkTransactionRequestRejectedReasonCode))]
        [InverseProperty(nameof(TblSRejectedReasonCode.TblDCalastoneTransactionRequest))]
        public virtual TblSRejectedReasonCode FkTransactionRequestRejectedReasonCodeNavigation { get; set; }
        [ForeignKey(nameof(FkTransactionRequestStatus))]
        [InverseProperty(nameof(TblITransactionRequestStatus.TblDCalastoneTransactionRequest))]
        public virtual TblITransactionRequestStatus FkTransactionRequestStatusNavigation { get; set; }
        [ForeignKey(nameof(FkTransactionType))]
        [InverseProperty(nameof(TblITransactionType1.TblDCalastoneTransactionRequest))]
        public virtual TblITransactionType1 FkTransactionTypeNavigation { get; set; }
        [ForeignKey(nameof(FkUnitGroupCode))]
        [InverseProperty(nameof(TblSGroupUnitCode.TblDCalastoneTransactionRequest))]
        public virtual TblSGroupUnitCode FkUnitGroupCodeNavigation { get; set; }
    }
}
