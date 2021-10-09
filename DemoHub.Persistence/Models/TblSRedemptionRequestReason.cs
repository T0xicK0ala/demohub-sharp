using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_RedemptionRequestReason", Schema = "chs")]
    public partial class TblSRedemptionRequestReason
    {
        public TblSRedemptionRequestReason()
        {
            TblDChesstransactionRequest = new HashSet<TblDChesstransactionRequest>();
        }

        [Key]
        [Column("kRedemptionRequestReason")]
        public int KRedemptionRequestReason { get; set; }
        [Required]
        [Column("sRedemptionRequestReason")]
        [StringLength(1)]
        public string SRedemptionRequestReason { get; set; }
        [Required]
        [Column("sRedemptionRequestReasonDescription")]
        [StringLength(20)]
        public string SRedemptionRequestReasonDescription { get; set; }
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

        [InverseProperty("FkRedemptionRequestReasonNavigation")]
        public virtual ICollection<TblDChesstransactionRequest> TblDChesstransactionRequest { get; set; }
    }
}
