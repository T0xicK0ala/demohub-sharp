using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_I_TransactionType", Schema = "ctn")]
    public partial class TblITransactionType1
    {
        public TblITransactionType1()
        {
            TblDCalastoneTransactionRequest = new HashSet<TblDCalastoneTransactionRequest>();
        }

        [Key]
        [Column("kTransactionType")]
        public int KTransactionType { get; set; }
        [Required]
        [Column("sTransactionType")]
        [StringLength(50)]
        public string STransactionType { get; set; }
        [Required]
        [Column("sRegTransactionType")]
        [StringLength(50)]
        public string SRegTransactionType { get; set; }
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

        [InverseProperty("FkTransactionTypeNavigation")]
        public virtual ICollection<TblDCalastoneTransactionRequest> TblDCalastoneTransactionRequest { get; set; }
    }
}
