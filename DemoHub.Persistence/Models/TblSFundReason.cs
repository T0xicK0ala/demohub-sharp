using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_FundReason", Schema = "chs")]
    public partial class TblSFundReason
    {
        public TblSFundReason()
        {
            TblREffectedFundUnitAdjustment = new HashSet<TblREffectedFundUnitAdjustment>();
        }

        [Key]
        [Column("kFundReason")]
        public int KFundReason { get; set; }
        [Required]
        [Column("sFundReason")]
        [StringLength(3)]
        public string SFundReason { get; set; }
        [Required]
        [Column("sFundReasonDescription")]
        [StringLength(35)]
        public string SFundReasonDescription { get; set; }
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

        [InverseProperty("FkFundReasonNavigation")]
        public virtual ICollection<TblREffectedFundUnitAdjustment> TblREffectedFundUnitAdjustment { get; set; }
    }
}
