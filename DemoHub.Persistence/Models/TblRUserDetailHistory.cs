using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_UserDetailHistory", Schema = "chsrep")]
    public partial class TblRUserDetailHistory
    {
        [Key]
        [Column("kUserDetailHistory")]
        public int KUserDetailHistory { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Required]
        [Column("sContact")]
        [StringLength(30)]
        public string SContact { get; set; }
        [Column("sDefaultSettlementHIN")]
        [StringLength(10)]
        public string SDefaultSettlementHin { get; set; }
        [Column("sDefaultDemandHIN")]
        [StringLength(10)]
        public string SDefaultDemandHin { get; set; }
        [Column("fkUIC")]
        public int FkUic { get; set; }
        [Column("fkMasterUIC")]
        public int? FkMasterUic { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("sDefaultAccumulationHIN")]
        [StringLength(10)]
        public string SDefaultAccumulationHin { get; set; }
        [Column("fkParticipantType")]
        public int? FkParticipantType { get; set; }
        [Column("dtTimestamp", TypeName = "date")]
        public DateTime? DtTimestamp { get; set; }
        [Column("tTimestamp", TypeName = "time(0)")]
        public TimeSpan? TTimestamp { get; set; }
        [Required]
        [Column("sName")]
        [StringLength(90)]
        public string SName { get; set; }
        [Required]
        [Column("sAddress")]
        [StringLength(90)]
        public string SAddress { get; set; }
        [Column("fkSecurityCodePreference")]
        public int FkSecurityCodePreference { get; set; }
        [Column("fkUserStatus")]
        public int FkUserStatus { get; set; }
        [Column("fkUserType")]
        public int FkUserType { get; set; }
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

        [ForeignKey(nameof(FkMasterUic))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRUserDetailHistoryFkMasterUicNavigation))]
        public virtual TblDChessmFundUser FkMasterUicNavigation { get; set; }
        [ForeignKey(nameof(FkParticipantType))]
        [InverseProperty(nameof(TblSParticipantType.TblRUserDetailHistory))]
        public virtual TblSParticipantType FkParticipantTypeNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRUserDetailHistory))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
        [ForeignKey(nameof(FkSecurityCodePreference))]
        [InverseProperty(nameof(TblSSecurityCodePreference.TblRUserDetailHistory))]
        public virtual TblSSecurityCodePreference FkSecurityCodePreferenceNavigation { get; set; }
        [ForeignKey(nameof(FkUic))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRUserDetailHistoryFkUicNavigation))]
        public virtual TblDChessmFundUser FkUicNavigation { get; set; }
        [ForeignKey(nameof(FkUserStatus))]
        [InverseProperty(nameof(TblSUserStatus.TblRUserDetailHistory))]
        public virtual TblSUserStatus FkUserStatusNavigation { get; set; }
        [ForeignKey(nameof(FkUserType))]
        [InverseProperty(nameof(TblSUserType.TblRUserDetailHistory))]
        public virtual TblSUserType FkUserTypeNavigation { get; set; }
    }
}
