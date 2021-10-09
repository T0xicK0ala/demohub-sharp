using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_IncomeNotificationFlag", Schema = "chsrep")]
    public partial class TblSIncomeNotificationFlag
    {
        public TblSIncomeNotificationFlag()
        {
            TblRPeriodicIncomeStatement = new HashSet<TblRPeriodicIncomeStatement>();
        }

        [Key]
        [Column("kIncomeNotificationFlag")]
        public int KIncomeNotificationFlag { get; set; }
        [Required]
        [Column("sIncomeNotificationFlag")]
        [StringLength(1)]
        public string SIncomeNotificationFlag { get; set; }
        [Required]
        [Column("sIncomeNotificationFlagDescription")]
        [StringLength(35)]
        public string SIncomeNotificationFlagDescription { get; set; }
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

        [InverseProperty("FkIncomeNotificationFlagNavigation")]
        public virtual ICollection<TblRPeriodicIncomeStatement> TblRPeriodicIncomeStatement { get; set; }
    }
}
