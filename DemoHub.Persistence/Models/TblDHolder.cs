using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_Holder", Schema = "chs")]
    public partial class TblDHolder
    {
        public TblDHolder()
        {
            TblDChesstransactionRequest = new HashSet<TblDChesstransactionRequest>();
            TblLTransactionHolder = new HashSet<TblLTransactionHolder>();
            TblRFullChesstoIssuerSponsoredConversion = new HashSet<TblRFullChesstoIssuerSponsoredConversion>();
        }

        [Key]
        [Column("kHolder")]
        public int KHolder { get; set; }
        [Required]
        [Column("sHIN")]
        [StringLength(10)]
        public string SHin { get; set; }
        [Required]
        [Column("sSRN")]
        [StringLength(12)]
        public string SSrn { get; set; }
        [Column("fkControllingPID")]
        public int? FkControllingPid { get; set; }
        [Column("fkHolderStatus")]
        public int? FkHolderStatus { get; set; }
        [Column("fkHolderStatusChange")]
        public int? FkHolderStatusChange { get; set; }
        [Column("fkHolderType")]
        public int FkHolderType { get; set; }
        [Column("fkEntrepotType")]
        public int? FkEntrepotType { get; set; }
        [Column("sEmailAddress")]
        [StringLength(50)]
        public string SEmailAddress { get; set; }
        [Column("fkEmailPurpose")]
        public int? FkEmailPurpose { get; set; }
        [Column("bEmailCancellation")]
        public bool? BEmailCancellation { get; set; }
        [Column("fkRegistrationDetailsIndicator")]
        public int FkRegistrationDetailsIndicator { get; set; }
        [Required]
        [Column("sRegistrationDetail")]
        [StringLength(180)]
        public string SRegistrationDetail { get; set; }
        [Column("bResidency")]
        public bool? BResidency { get; set; }
        [Column("dtBusinessDate", TypeName = "date")]
        public DateTime? DtBusinessDate { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("bIsStatementRequired")]
        public bool BIsStatementRequired { get; set; }
        [Column("sRegistrationName")]
        [StringLength(10)]
        public string SRegistrationName { get; set; }
        [Column("sRegistrationAddress")]
        [StringLength(10)]
        public string SRegistrationAddress { get; set; }
        [Column("sTFN_ABN1")]
        [StringLength(12)]
        public string STfnAbn1 { get; set; }
        [Column("sTFN_ABN2")]
        [StringLength(12)]
        public string STfnAbn2 { get; set; }
        [Column("sTFN_ABN3")]
        [StringLength(12)]
        public string STfnAbn3 { get; set; }
        [Column("fkAccount")]
        public int FkAccount { get; set; }
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

        [ForeignKey(nameof(FkAccount))]
        [InverseProperty(nameof(TblDAccount.TblDHolder))]
        public virtual TblDAccount FkAccountNavigation { get; set; }
        [ForeignKey(nameof(FkControllingPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblDHolder))]
        public virtual TblDChessmFundUser FkControllingP { get; set; }
        [ForeignKey(nameof(FkEmailPurpose))]
        [InverseProperty(nameof(TblSEmailPurpose.TblDHolder))]
        public virtual TblSEmailPurpose FkEmailPurposeNavigation { get; set; }
        [ForeignKey(nameof(FkEntrepotType))]
        [InverseProperty(nameof(TblSEntrepotType.TblDHolder))]
        public virtual TblSEntrepotType FkEntrepotTypeNavigation { get; set; }
        [ForeignKey(nameof(FkHolderStatus))]
        [InverseProperty(nameof(TblSHolderStatus.TblDHolder))]
        public virtual TblSHolderStatus FkHolderStatusNavigation { get; set; }
        [ForeignKey(nameof(FkHolderType))]
        [InverseProperty(nameof(TblSHolderType.TblDHolder))]
        public virtual TblSHolderType FkHolderTypeNavigation { get; set; }
        [ForeignKey(nameof(FkRegistrationDetailsIndicator))]
        [InverseProperty(nameof(TblSRegistrationDetailsIndicator.TblDHolder))]
        public virtual TblSRegistrationDetailsIndicator FkRegistrationDetailsIndicatorNavigation { get; set; }
        [InverseProperty("FkHolderNavigation")]
        public virtual ICollection<TblDChesstransactionRequest> TblDChesstransactionRequest { get; set; }
        [InverseProperty("FkHolderNavigation")]
        public virtual ICollection<TblLTransactionHolder> TblLTransactionHolder { get; set; }
        [InverseProperty("SDeliveringHinNavigation")]
        public virtual ICollection<TblRFullChesstoIssuerSponsoredConversion> TblRFullChesstoIssuerSponsoredConversion { get; set; }
    }
}
