using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_R_PeriodicIncomeStatement", Schema = "chsrep")]
    public partial class TblRPeriodicIncomeStatement
    {
        [Key]
        [Column("kPeriodicIncomeStatement")]
        public int KPeriodicIncomeStatement { get; set; }
        [Required]
        [Column("sSecurityCode")]
        [StringLength(12)]
        public string SSecurityCode { get; set; }
        [Column("dGrossIncomeAmount", TypeName = "decimal(13, 2)")]
        public decimal DGrossIncomeAmount { get; set; }
        [Column("fkIncomeNotificationFlag")]
        public int FkIncomeNotificationFlag { get; set; }
        [Required]
        [Column("sHIN")]
        [StringLength(10)]
        public string SHin { get; set; }
        [Column("fkPID")]
        public int FkPid { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Column("dIncomeAmountPerUnit", TypeName = "decimal(6, 6)")]
        public decimal? DIncomeAmountPerUnit { get; set; }
        [Column("dTaxDeducted", TypeName = "decimal(13, 2)")]
        public decimal? DTaxDeducted { get; set; }
        [Column("dNettAmount", TypeName = "decimal(13, 2)")]
        public decimal? DNettAmount { get; set; }
        [Column("dUnitsParticipating", TypeName = "decimal(12, 2)")]
        public decimal? DUnitsParticipating { get; set; }
        [Column("dFee", TypeName = "decimal(13, 2)")]
        public decimal? DFee { get; set; }
        [Column("dtPaymentDate", TypeName = "date")]
        public DateTime DtPaymentDate { get; set; }
        [Column("dtRecordDate", TypeName = "date")]
        public DateTime DtRecordDate { get; set; }
        [Column("sAPIRCode")]
        [StringLength(9)]
        public string SApircode { get; set; }
        [Column("dTaxCreditAmount", TypeName = "decimal(13, 2)")]
        public decimal? DTaxCreditAmount { get; set; }
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

        [ForeignKey(nameof(FkIncomeNotificationFlag))]
        [InverseProperty(nameof(TblSIncomeNotificationFlag.TblRPeriodicIncomeStatement))]
        public virtual TblSIncomeNotificationFlag FkIncomeNotificationFlagNavigation { get; set; }
        [ForeignKey(nameof(FkPid))]
        [InverseProperty(nameof(TblDChessmFundUser.TblRPeriodicIncomeStatement))]
        public virtual TblDChessmFundUser FkP { get; set; }
    }
}
