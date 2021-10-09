using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_CHESSTransactionRequest", Schema = "trn")]
    public partial class TblDChesstransactionRequest
    {
        public TblDChesstransactionRequest()
        {
            TblDTransaction = new HashSet<TblDTransaction>();
        }

        [Key]
        [Column("kTransactionRequest")]
        public int KTransactionRequest { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Column("fkTransactionStatus")]
        public int FkTransactionStatus { get; set; }
        [Column("fkHubTransactionStatus")]
        public int FkHubTransactionStatus { get; set; }
        [Column("fkRejectedOrderReason")]
        public int? FkRejectedOrderReason { get; set; }
        [Column("iHIN")]
        [StringLength(10)]
        public string IHin { get; set; }
        [Required]
        [Column("iPID")]
        [StringLength(5)]
        public string IPid { get; set; }
        [Column("sSRN")]
        [StringLength(12)]
        public string SSrn { get; set; }
        [Required]
        [Column("sFundCode")]
        [StringLength(12)]
        public string SFundCode { get; set; }
        [Column("fkFundIDType")]
        public int FkFundIdtype { get; set; }
        [Column("dFundAmount", TypeName = "decimal(13, 2)")]
        public decimal? DFundAmount { get; set; }
        [Column("dNumberOfUnits", TypeName = "decimal(12, 6)")]
        public decimal? DNumberOfUnits { get; set; }
        [Column("fkNettOrGross")]
        public int? FkNettOrGross { get; set; }
        [Column("fkOrderType")]
        public int FkOrderType { get; set; }
        [Column("bIsInitialApplication")]
        public bool? BIsInitialApplication { get; set; }
        [Column("bIsFullRedemption")]
        public bool? BIsFullRedemption { get; set; }
        [Column("fkRedemptionRequestReason")]
        public int? FkRedemptionRequestReason { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("sSupplementaryReference")]
        [StringLength(16)]
        public string SSupplementaryReference { get; set; }
        [Column("sRegistrationDetails")]
        [StringLength(180)]
        public string SRegistrationDetails { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("sTargetTransactionId")]
        [StringLength(16)]
        public string STargetTransactionId { get; set; }
        [Column("bFlagAML_CTF")]
        public bool? BFlagAmlCtf { get; set; }
        [Column("bIsCurrentPDSProvided")]
        public bool? BIsCurrentPdsprovided { get; set; }
        [Column("sProductName")]
        [StringLength(50)]
        public string SProductName { get; set; }
        [Column("dtPDSIssueDate", TypeName = "date")]
        public DateTime? DtPdsissueDate { get; set; }
        [Column("sAPIRCode")]
        [StringLength(9)]
        public string SApircode { get; set; }
        [Column("fkHolder")]
        public int? FkHolder { get; set; }
        [Column("fkAdvisor")]
        public int? FkAdvisor { get; set; }
        [Column("bDRPPreference")]
        public bool? BDrppreference { get; set; }
        [Column("fkFATCAQuestions")]
        public int? FkFatcaquestions { get; set; }
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

        [ForeignKey(nameof(FkFatcaquestions))]
        [InverseProperty(nameof(TblSFatcaquestions.TblDChesstransactionRequest))]
        public virtual TblSFatcaquestions FkFatcaquestionsNavigation { get; set; }
        [ForeignKey(nameof(FkHolder))]
        [InverseProperty(nameof(TblDHolder.TblDChesstransactionRequest))]
        public virtual TblDHolder FkHolderNavigation { get; set; }
        [ForeignKey(nameof(FkNettOrGross))]
        [InverseProperty(nameof(TblSNettOrGross.TblDChesstransactionRequest))]
        public virtual TblSNettOrGross FkNettOrGrossNavigation { get; set; }
        [ForeignKey(nameof(FkOrderType))]
        [InverseProperty(nameof(TblSOrderType.TblDChesstransactionRequest))]
        public virtual TblSOrderType FkOrderTypeNavigation { get; set; }
        [ForeignKey(nameof(FkRedemptionRequestReason))]
        [InverseProperty(nameof(TblSRedemptionRequestReason.TblDChesstransactionRequest))]
        public virtual TblSRedemptionRequestReason FkRedemptionRequestReasonNavigation { get; set; }
        [ForeignKey(nameof(FkTransactionStatus))]
        [InverseProperty(nameof(TblSTransactionStatus.TblDChesstransactionRequest))]
        public virtual TblSTransactionStatus FkTransactionStatusNavigation { get; set; }
        [InverseProperty("FkTransactionRequestNavigation")]
        public virtual ICollection<TblDTransaction> TblDTransaction { get; set; }
    }
}
