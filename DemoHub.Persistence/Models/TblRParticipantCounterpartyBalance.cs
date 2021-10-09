using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_ParticipantCounterpartyBalance", Schema = "chsrep")]
    public partial class TblRParticipantCounterpartyBalance
    {
        [Key]
        [Column("kParticipantCounterpartyBalance")]
        public int KParticipantCounterpartyBalance { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Column("fkPID")]
        public int FkPid { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
        [Column("fkPayReceiveIndicator")]
        public int FkPayReceiveIndicator { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("dAmount", TypeName = "decimal(12, 2)")]
        public decimal DAmount { get; set; }
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
        [InverseProperty(nameof(TblDChessmFundUser.TblRParticipantCounterpartyBalance))]
        public virtual TblDChessmFundUser FkP { get; set; }
        [ForeignKey(nameof(FkPayReceiveIndicator))]
        [InverseProperty(nameof(TblSPayReceiveIndicator.TblRParticipantCounterpartyBalance))]
        public virtual TblSPayReceiveIndicator FkPayReceiveIndicatorNavigation { get; set; }
        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRParticipantCounterpartyBalance))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
    }
}
