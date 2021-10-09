using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_RejectedRegistryReason", Schema = "chs")]
    public partial class TblSRejectedRegistryReason
    {
        public TblSRejectedRegistryReason()
        {
            TblDIncomeStatementAuthorisationRequest = new HashSet<TblDIncomeStatementAuthorisationRequest>();
        }

        [Key]
        [Column("kRejectedRegistryReason")]
        public int KRejectedRegistryReason { get; set; }
        [Required]
        [Column("sRejectedRegistryReason")]
        [StringLength(1)]
        public string SRejectedRegistryReason { get; set; }
        [Required]
        [Column("sRejectedRegistryReasonDescription")]
        [StringLength(60)]
        public string SRejectedRegistryReasonDescription { get; set; }
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

        [InverseProperty("FkRejectedRegistryReasonNavigation")]
        public virtual ICollection<TblDIncomeStatementAuthorisationRequest> TblDIncomeStatementAuthorisationRequest { get; set; }
    }
}
