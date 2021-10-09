using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_GroupUnitCode", Schema = "ctn")]
    public partial class TblSGroupUnitCode
    {
        public TblSGroupUnitCode()
        {
            TblDCalastoneTransactionRequest = new HashSet<TblDCalastoneTransactionRequest>();
        }

        [Key]
        [Column("kGroupUnitCode")]
        public int KGroupUnitCode { get; set; }
        [Required]
        [Column("sCode")]
        [StringLength(4)]
        public string SCode { get; set; }
        [Required]
        [Column("sDescription")]
        [StringLength(50)]
        public string SDescription { get; set; }
        [Column("bIsActive")]
        public bool? BIsActive { get; set; }
        [Column("vCreatedBy")]
        public int? VCreatedBy { get; set; }
        [Column("dt2CreatedAt")]
        public DateTime? Dt2CreatedAt { get; set; }
        [Column("vUpdatedBy")]
        public int? VUpdatedBy { get; set; }
        [Column("dt2UpdatedAt")]
        public DateTime? Dt2UpdatedAt { get; set; }
        [Required]
        [Column("zVersion")]
        public byte[] ZVersion { get; set; }

        [InverseProperty("FkUnitGroupCodeNavigation")]
        public virtual ICollection<TblDCalastoneTransactionRequest> TblDCalastoneTransactionRequest { get; set; }
    }
}
