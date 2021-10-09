using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_PaymentFacilityChangeReason", Schema = "chs")]
    public partial class TblSPaymentFacilityChangeReason
    {
        public TblSPaymentFacilityChangeReason()
        {
            TblRPaymentFacilityDetailHistory = new HashSet<TblRPaymentFacilityDetailHistory>();
        }

        [Key]
        [Column("kPaymentFacilityChangeReason")]
        public int KPaymentFacilityChangeReason { get; set; }
        [Required]
        [Column("sPaymentFacilityChangeReason")]
        [StringLength(1)]
        public string SPaymentFacilityChangeReason { get; set; }
        [Required]
        [Column("sPaymentFacilityChangeReasonDescription")]
        [StringLength(30)]
        public string SPaymentFacilityChangeReasonDescription { get; set; }
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

        [InverseProperty("FkPaymentFacilityChangeReasonNavigation")]
        public virtual ICollection<TblRPaymentFacilityDetailHistory> TblRPaymentFacilityDetailHistory { get; set; }
    }
}
