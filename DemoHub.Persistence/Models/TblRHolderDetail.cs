using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_HolderDetail", Schema = "chsrep")]
    public partial class TblRHolderDetail
    {
        [Key]
        [Column("kHolderDetail")]
        public int KHolderDetail { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Required]
        [Column("sHIN")]
        [StringLength(10)]
        public string SHin { get; set; }
        [Column("fkHolderType")]
        public int FkHolderType { get; set; }
        [Column("fkControllingPID")]
        public int FkControllingPid { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("bIsStatementRequired")]
        public bool BIsStatementRequired { get; set; }
        [Required]
        [Column("sRegistrationDetails")]
        [StringLength(180)]
        public string SRegistrationDetails { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("fkEntrepotType")]
        public int? FkEntrepotType { get; set; }
        [Column("fkAdviceReason")]
        public int FkAdviceReason { get; set; }
        [Column("fkHolderStatus")]
        public int? FkHolderStatus { get; set; }
        [Column("fkResidencyIndicator")]
        public int? FkResidencyIndicator { get; set; }
        [Column("sEmailAddress")]
        [StringLength(50)]
        public string SEmailAddress { get; set; }
        [Column("fkEmailPurpose")]
        public int? FkEmailPurpose { get; set; }
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

        [ForeignKey(nameof(FkAdviceReason))]
        [InverseProperty(nameof(TblSAdviceReason.TblRHolderDetail))]
        public virtual TblSAdviceReason FkAdviceReasonNavigation { get; set; }
        [ForeignKey(nameof(FkControllingPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRHolderDetail))]
        public virtual TblDChessmFundUser FkControllingP { get; set; }
        [ForeignKey(nameof(FkEntrepotType))]
        [InverseProperty(nameof(TblSEntrepotType.TblRHolderDetail))]
        public virtual TblSEntrepotType FkEntrepotTypeNavigation { get; set; }
        [ForeignKey(nameof(FkHolderStatus))]
        [InverseProperty(nameof(TblSHolderStatus.TblRHolderDetail))]
        public virtual TblSHolderStatus FkHolderStatusNavigation { get; set; }
        [ForeignKey(nameof(FkHolderType))]
        [InverseProperty(nameof(TblSHolderType.TblRHolderDetail))]
        public virtual TblSHolderType FkHolderTypeNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRHolderDetail))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
        [ForeignKey(nameof(FkResidencyIndicator))]
        [InverseProperty(nameof(TblSResidencyIndicator.TblRHolderDetail))]
        public virtual TblSResidencyIndicator FkResidencyIndicatorNavigation { get; set; }
    }
}
