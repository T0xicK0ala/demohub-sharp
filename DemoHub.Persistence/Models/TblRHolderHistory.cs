using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_HolderHistory", Schema = "chsrep")]
    public partial class TblRHolderHistory
    {
        [Key]
        [Column("kHolderHistory")]
        public int KHolderHistory { get; set; }
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
        [Column("dtTimestamp", TypeName = "date")]
        public DateTime DtTimestamp { get; set; }
        [Column("tTimestamp")]
        public TimeSpan TTimestamp { get; set; }
        [Column("dtResponseTimestamp", TypeName = "date")]
        public DateTime DtResponseTimestamp { get; set; }
        [Column("tResponseTimestamp")]
        public TimeSpan TResponseTimestamp { get; set; }
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

        [ForeignKey(nameof(FkControllingPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRHolderHistory))]
        public virtual TblDChessmFundUser FkControllingP { get; set; }
        [ForeignKey(nameof(FkEmailPurpose))]
        [InverseProperty(nameof(TblSEmailPurpose.TblRHolderHistory))]
        public virtual TblSEmailPurpose FkEmailPurposeNavigation { get; set; }
        [ForeignKey(nameof(FkEntrepotType))]
        [InverseProperty(nameof(TblSEntrepotType.TblRHolderHistory))]
        public virtual TblSEntrepotType FkEntrepotTypeNavigation { get; set; }
        [ForeignKey(nameof(FkHolderStatus))]
        [InverseProperty(nameof(TblSHolderStatus.TblRHolderHistory))]
        public virtual TblSHolderStatus FkHolderStatusNavigation { get; set; }
        [ForeignKey(nameof(FkHolderType))]
        [InverseProperty(nameof(TblSHolderType.TblRHolderHistory))]
        public virtual TblSHolderType FkHolderTypeNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRHolderHistory))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
        [ForeignKey(nameof(FkResidencyIndicator))]
        [InverseProperty(nameof(TblSResidencyIndicator.TblRHolderHistory))]
        public virtual TblSResidencyIndicator FkResidencyIndicatorNavigation { get; set; }
    }
}
