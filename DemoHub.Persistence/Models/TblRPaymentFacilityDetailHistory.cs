using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_PaymentFacilityDetailHistory", Schema = "chsrep")]
    public partial class TblRPaymentFacilityDetailHistory
    {
        [Key]
        [Column("kPaymentFacilityDetailHistory")]
        public int KPaymentFacilityDetailHistory { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Column("sHIN")]
        [StringLength(10)]
        public string SHin { get; set; }
        [Column("fkPID")]
        public int FkPid { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("bDefaultPaymentFacilityIndicator")]
        public bool BDefaultPaymentFacilityIndicator { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("fkPaymentFacilityChangeReason")]
        public int? FkPaymentFacilityChangeReason { get; set; }
        [Column("dtTimestamp", TypeName = "date")]
        public DateTime? DtTimestamp { get; set; }
        [Column("tTimestamp", TypeName = "time(0)")]
        public TimeSpan? TTimestamp { get; set; }
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
        [InverseProperty(nameof(TblDChessmFundUser.TblRPaymentFacilityDetailHistory))]
        public virtual TblDChessmFundUser FkP { get; set; }
        [ForeignKey(nameof(FkPaymentFacilityChangeReason))]
        [InverseProperty(nameof(TblSPaymentFacilityChangeReason.TblRPaymentFacilityDetailHistory))]
        public virtual TblSPaymentFacilityChangeReason FkPaymentFacilityChangeReasonNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRPaymentFacilityDetailHistory))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
