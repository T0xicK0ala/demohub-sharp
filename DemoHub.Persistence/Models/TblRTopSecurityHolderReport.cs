using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_TopSecurityHolderReport", Schema = "chsrep")]
    public partial class TblRTopSecurityHolderReport
    {
        [Key]
        [Column("kTopSecurityHolderReport")]
        public int KTopSecurityHolderReport { get; set; }
        [Column("fkReportRequest")]
        public int FkReportRequest { get; set; }
        [Column("bIsmFund")]
        public bool BIsmFund { get; set; }
        [Required]
        [Column("sSecurityCode")]
        [StringLength(12)]
        public string SSecurityCode { get; set; }
        [Column("dtOpeningBalanceDate", TypeName = "date")]
        public DateTime DtOpeningBalanceDate { get; set; }
        [Column("dtClosingBalanceDate", TypeName = "date")]
        public DateTime DtClosingBalanceDate { get; set; }
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
        [Column("dTotalMovementsOff", TypeName = "decimal(11, 0)")]
        public decimal? DTotalMovementsOff { get; set; }
        [Column("dTotalMovementsOn", TypeName = "decimal(11, 0)")]
        public decimal? DTotalMovementsOn { get; set; }
        [Column("dClosingBalance", TypeName = "decimal(11, 0)")]
        public decimal? DClosingBalance { get; set; }
        [Column("dOpeningBalance", TypeName = "decimal(11, 0)")]
        public decimal? DOpeningBalance { get; set; }
        [Required]
        [Column("sRegistrationDetails")]
        [StringLength(180)]
        public string SRegistrationDetails { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Column("fkResidencyIndicator")]
        public int FkResidencyIndicator { get; set; }
        [Column("dTotalFundMovementsOff", TypeName = "decimal(12, 6)")]
        public decimal? DTotalFundMovementsOff { get; set; }
        [Column("dClosingFundBalance", TypeName = "decimal(12, 6)")]
        public decimal? DClosingFundBalance { get; set; }
        [Column("dTotalFundMovementsOn", TypeName = "decimal(12, 6)")]
        public decimal? DTotalFundMovementsOn { get; set; }
        [Column("dOpeningFundBalance", TypeName = "decimal(12, 6)")]
        public decimal? DOpeningFundBalance { get; set; }
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

        [ForeignKey(nameof(FkReportRequest))]
        [InverseProperty(nameof(TblDReportRequest.TblRTopSecurityHolderReport))]
        public virtual TblDReportRequest FkReportRequestNavigation { get; set; }
        [ForeignKey(nameof(FkResidencyIndicator))]
        [InverseProperty(nameof(TblSResidencyIndicator.TblRTopSecurityHolderReport))]
        public virtual TblSResidencyIndicator FkResidencyIndicatorNavigation { get; set; }
    }
}
