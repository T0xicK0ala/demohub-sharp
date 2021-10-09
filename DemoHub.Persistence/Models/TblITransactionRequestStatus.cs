using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_I_TransactionRequestStatus", Schema = "ctn")]
    public partial class TblITransactionRequestStatus
    {
        public TblITransactionRequestStatus()
        {
            TblDCalastoneTransactionRequest = new HashSet<TblDCalastoneTransactionRequest>();
        }

        [Key]
        [Column("kTransactionRequestStatus")]
        public int KTransactionRequestStatus { get; set; }
        [Required]
        [Column("sTransactionRequestStatus")]
        [StringLength(100)]
        public string STransactionRequestStatus { get; set; }
        [Column("sTransactionRequestStatusDesc")]
        [StringLength(100)]
        public string STransactionRequestStatusDesc { get; set; }
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

        [InverseProperty("FkTransactionRequestStatusNavigation")]
        public virtual ICollection<TblDCalastoneTransactionRequest> TblDCalastoneTransactionRequest { get; set; }
    }
}
