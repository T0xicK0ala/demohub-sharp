using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_L_TransactionHolder", Schema = "chs")]
    public partial class TblLTransactionHolder
    {
        [Key]
        [Column("kTransactionHolderLink")]
        public int KTransactionHolderLink { get; set; }
        [Column("fkHolder")]
        public int FkHolder { get; set; }
        [Column("fkTransaction")]
        public int FkTransaction { get; set; }
        [Column("bIsActive")]
        public bool BIsActive { get; set; }
        [Column("dtProcessingDate", TypeName = "date")]
        public DateTime DtProcessingDate { get; set; }
        [Column("tProcessingTime", TypeName = "time(0)")]
        public TimeSpan TProcessingTime { get; set; }
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

        [ForeignKey(nameof(FkHolder))]
        [InverseProperty(nameof(TblDHolder.TblLTransactionHolder))]
        public virtual TblDHolder FkHolderNavigation { get; set; }
        [ForeignKey(nameof(FkTransaction))]
        [InverseProperty(nameof(TblDTransaction.TblLTransactionHolder))]
        public virtual TblDTransaction FkTransactionNavigation { get; set; }
    }
}
