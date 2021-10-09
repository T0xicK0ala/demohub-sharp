using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_IncomeStatementSet", Schema = "chsrep")]
    public partial class TblDIncomeStatementSet
    {
        [Key]
        [Column("kIncomeStatementSet")]
        public int KIncomeStatementSet { get; set; }
        [Column("dDate", TypeName = "date")]
        public DateTime? DDate { get; set; }
        [Required]
        [Column("sTransactionId")]
        [StringLength(16)]
        public string STransactionId { get; set; }
        [Required]
        [Column("sOriginTransactionId")]
        [StringLength(16)]
        public string SOriginTransactionId { get; set; }
        [Required]
        [Column("sSetTransactionId")]
        [StringLength(16)]
        public string SSetTransactionId { get; set; }
        [Column("iTotalMessageCount")]
        public int ITotalMessageCount { get; set; }
        [Column("bIsAcceptedRegistryIncomeStatementSet")]
        public bool? BIsAcceptedRegistryIncomeStatementSet { get; set; }
        [Column("bIsRejectedRegistryIncomeStatementSet")]
        public bool? BIsRejectedRegistryIncomeStatementSet { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime? DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan? TProcessingTime { get; set; }
        [Column("fkRejectedIncomeStatementSetReason")]
        public int? FkRejectedIncomeStatementSetReason { get; set; }
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
    }
}
