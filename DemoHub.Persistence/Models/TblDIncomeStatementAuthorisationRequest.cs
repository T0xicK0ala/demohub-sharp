using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_IncomeStatementAuthorisationRequest", Schema = "chsrep")]
    public partial class TblDIncomeStatementAuthorisationRequest
    {
        [Key]
        [Column("kIncomeStatementAuthorisationRequest")]
        public int KIncomeStatementAuthorisationRequest { get; set; }
        [Column("bIsAccepted")]
        public bool? BIsAccepted { get; set; }
        [Required]
        [Column("sSecurityCode")]
        [StringLength(12)]
        public string SSecurityCode { get; set; }
        [Required]
        [Column("sHIN")]
        [StringLength(10)]
        public string SHin { get; set; }
        [Column("fkPID")]
        public int FkPid { get; set; }
        [Column("fkTargetUIC")]
        public int? FkTargetUic { get; set; }
        [Column("sRegistryReference")]
        [StringLength(16)]
        public string SRegistryReference { get; set; }
        [Column("fkRejectedRegistryReason")]
        public int? FkRejectedRegistryReason { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("dtEffectedProcessingDate", TypeName = "date")]
        public DateTime DtEffectedProcessingDate { get; set; }
        [Column("tEffectedProcessingTime", TypeName = "time(0)")]
        public TimeSpan TEffectedProcessingTime { get; set; }
        [Column("fkIncomeStatementReportFrequency")]
        public int? FkIncomeStatementReportFrequency { get; set; }
        [Column("fkIncomeStatementReportType")]
        public int? FkIncomeStatementReportType { get; set; }
        [Column("bIncomeStatementCancellation")]
        public bool? BIncomeStatementCancellation { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("sAPIRCode")]
        [StringLength(9)]
        public string SApircode { get; set; }
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

        [ForeignKey(nameof(FkIncomeStatementReportFrequency))]
        [InverseProperty(nameof(TblSIncomeStatementReportFrequency.TblDIncomeStatementAuthorisationRequest))]
        public virtual TblSIncomeStatementReportFrequency FkIncomeStatementReportFrequencyNavigation { get; set; }
        [ForeignKey(nameof(FkIncomeStatementReportType))]
        [InverseProperty(nameof(TblSIncomeStatementReportType.TblDIncomeStatementAuthorisationRequest))]
        public virtual TblSIncomeStatementReportType FkIncomeStatementReportTypeNavigation { get; set; }
        [ForeignKey(nameof(FkPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblDIncomeStatementAuthorisationRequestFkP))]
        public virtual TblDChessmFundUser FkP { get; set; }
        [ForeignKey(nameof(FkRejectedRegistryReason))]
        [InverseProperty(nameof(TblSRejectedRegistryReason.TblDIncomeStatementAuthorisationRequest))]
        public virtual TblSRejectedRegistryReason FkRejectedRegistryReasonNavigation { get; set; }
        [ForeignKey(nameof(FkTargetUic))]
        [InverseProperty(nameof(TblDChessmFundUser.TblDIncomeStatementAuthorisationRequestFkTargetUicNavigation))]
        public virtual TblDChessmFundUser FkTargetUicNavigation { get; set; }
    }
}
