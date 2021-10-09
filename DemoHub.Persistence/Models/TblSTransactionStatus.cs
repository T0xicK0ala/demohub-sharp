using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_TransactionStatus", Schema = "chs")]
    public partial class TblSTransactionStatus
    {
        public TblSTransactionStatus()
        {
            TblDChesstransactionRequest = new HashSet<TblDChesstransactionRequest>();
        }

        [Key]
        [Column("kTransactionStatus")]
        public int KTransactionStatus { get; set; }
        [Required]
        [Column("sTransactionStatus")]
        [StringLength(1)]
        public string STransactionStatus { get; set; }
        [Required]
        [Column("sTransactionStatusDescription")]
        [StringLength(100)]
        public string STransactionStatusDescription { get; set; }
        [Column("bIsActive")]
        public bool BIsActive { get; set; }
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

        [InverseProperty("FkTransactionStatusNavigation")]
        public virtual ICollection<TblDChesstransactionRequest> TblDChesstransactionRequest { get; set; }
    }
}
