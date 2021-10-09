using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_RejectedReasonCode", Schema = "ctn")]
    public partial class TblSRejectedReasonCode
    {
        public TblSRejectedReasonCode()
        {
            TblDCalastoneTransactionRequest = new HashSet<TblDCalastoneTransactionRequest>();
        }

        [Key]
        [Column("kRejectedReasonCode")]
        public int KRejectedReasonCode { get; set; }
        [Required]
        [Column("sCode")]
        [StringLength(4)]
        public string SCode { get; set; }
        [Column("sDescription")]
        [StringLength(500)]
        public string SDescription { get; set; }
        [Column("sCodeName")]
        [StringLength(50)]
        public string SCodeName { get; set; }
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

        [InverseProperty("FkTransactionRequestRejectedReasonCodeNavigation")]
        public virtual ICollection<TblDCalastoneTransactionRequest> TblDCalastoneTransactionRequest { get; set; }
    }
}
