using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_NettOrGross", Schema = "chs")]
    public partial class TblSNettOrGross
    {
        public TblSNettOrGross()
        {
            TblDChesstransactionRequest = new HashSet<TblDChesstransactionRequest>();
        }

        [Key]
        [Column("kNettOrGross")]
        public int KNettOrGross { get; set; }
        [Required]
        [Column("sNettOrGross")]
        [StringLength(1)]
        public string SNettOrGross { get; set; }
        [Required]
        [Column("sNettOrGrossDescription")]
        [StringLength(5)]
        public string SNettOrGrossDescription { get; set; }
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

        [InverseProperty("FkNettOrGrossNavigation")]
        public virtual ICollection<TblDChesstransactionRequest> TblDChesstransactionRequest { get; set; }
    }
}
