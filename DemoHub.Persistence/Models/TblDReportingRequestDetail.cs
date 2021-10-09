using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_ReportingRequestDetail", Schema = "chsrep")]
    public partial class TblDReportingRequestDetail
    {
        [Key]
        [Column("kReportingRequestDetail")]
        public int KReportingRequestDetail { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Column("sPSecurityCode")]
        [StringLength(12)]
        public string SPsecurityCode { get; set; }
        [Column("fkPCorporateActionTypeId")]
        public int? FkPcorporateActionTypeId { get; set; }
        [Column("dtReportingStartDate", TypeName = "date")]
        public DateTime? DtReportingStartDate { get; set; }
        [Column("dtReportingEndDate", TypeName = "date")]
        public DateTime? DtReportingEndDate { get; set; }
        [Column("sPHIN")]
        [StringLength(10)]
        public string SPhin { get; set; }
        [Column("fkPID")]
        public int? FkPid { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("sPPaymentFacility")]
        [StringLength(6)]
        public string SPpaymentFacility { get; set; }
        [Column("fkPSubpositionType")]
        public int? FkPsubpositionType { get; set; }
        [Column("sPTakeoverCode")]
        [StringLength(6)]
        public string SPtakeoverCode { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Column("sPTransactionId")]
        [StringLength(16)]
        public string SPtransactionId { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("fkReportingRequestStatus")]
        public int FkReportingRequestStatus { get; set; }
        [Column("fkReportingId")]
        public int FkReportingId { get; set; }
        [Column("fkProcessingFrequency")]
        public int FkProcessingFrequency { get; set; }
        [Column("dtPExDate", TypeName = "date")]
        public DateTime? DtPexDate { get; set; }
        [Column("sPNumberofDays")]
        [StringLength(3)]
        public string SPnumberofDays { get; set; }
        [Column("fkPPositionType")]
        public int? FkPpositionType { get; set; }
        [Column("fkProcessingPoint")]
        public int? FkProcessingPoint { get; set; }
        [Column("fkProcessingPeriod")]
        public int? FkProcessingPeriod { get; set; }
        [Column("dtPStartDate", TypeName = "date")]
        public DateTime? DtPstartDate { get; set; }
        [Column("dtPEndDate", TypeName = "date")]
        public DateTime? DtPendDate { get; set; }
        [Column("dtPAsAtDate", TypeName = "date")]
        public DateTime? DtPasAtDate { get; set; }
        [Column("fkPReportingId")]
        public int? FkPreportingId { get; set; }
        [Column("fkPTransactionClass")]
        public int? FkPtransactionClass { get; set; }
        [Column("fkPAdditionalReporting")]
        public int? FkPadditionalReporting { get; set; }
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

        [ForeignKey(nameof(FkPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblDReportingRequestDetail))]
        public virtual TblDChessmFundUser FkP { get; set; }
        [ForeignKey(nameof(FkPadditionalReporting))]
        [InverseProperty(nameof(TblSAdditionalReportingParameter.TblDReportingRequestDetail))]
        public virtual TblSAdditionalReportingParameter FkPadditionalReportingNavigation { get; set; }
        [ForeignKey(nameof(FkPcorporateActionTypeId))]
        [InverseProperty(nameof(TblSCorporateActionTypeId.TblDReportingRequestDetail))]
        public virtual TblSCorporateActionTypeId FkPcorporateActionType { get; set; }
        [ForeignKey(nameof(FkPpositionType))]
        [InverseProperty(nameof(TblSPositionTypeParameter.TblDReportingRequestDetail))]
        public virtual TblSPositionTypeParameter FkPpositionTypeNavigation { get; set; }
        [ForeignKey(nameof(FkPreportingId))]
        [InverseProperty(nameof(TblSReportingId.TblDReportingRequestDetailFkPreporting))]
        public virtual TblSReportingId FkPreporting { get; set; }
        [ForeignKey(nameof(FkProcessingFrequency))]
        [InverseProperty(nameof(TblSProcessingFrequency.TblDReportingRequestDetail))]
        public virtual TblSProcessingFrequency FkProcessingFrequencyNavigation { get; set; }
        [ForeignKey(nameof(FkProcessingPeriod))]
        [InverseProperty(nameof(TblSProcessingPeriod.TblDReportingRequestDetail))]
        public virtual TblSProcessingPeriod FkProcessingPeriodNavigation { get; set; }
        [ForeignKey(nameof(FkProcessingPoint))]
        [InverseProperty(nameof(TblSProcessingPoint.TblDReportingRequestDetail))]
        public virtual TblSProcessingPoint FkProcessingPointNavigation { get; set; }
        [ForeignKey(nameof(FkPsubpositionType))]
        [InverseProperty(nameof(TblSSubpositionType.TblDReportingRequestDetail))]
        public virtual TblSSubpositionType FkPsubpositionTypeNavigation { get; set; }
        [ForeignKey(nameof(FkPtransactionClass))]
        [InverseProperty(nameof(TblSTransactionClassParameter.TblDReportingRequestDetail))]
        public virtual TblSTransactionClassParameter FkPtransactionClassNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblDReportingRequestDetail))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
        [ForeignKey(nameof(FkReportingId))]
        [InverseProperty(nameof(TblSReportingId.TblDReportingRequestDetailFkReporting))]
        public virtual TblSReportingId FkReporting { get; set; }
        [ForeignKey(nameof(FkReportingRequestStatus))]
        [InverseProperty(nameof(TblSReportingRequestStatus.TblDReportingRequestDetail))]
        public virtual TblSReportingRequestStatus FkReportingRequestStatusNavigation { get; set; }
    }
}
