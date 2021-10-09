using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_InvestorType", Schema = "chs")]
    public partial class TblSInvestorType
    {
        [Key]
        [Column("kInvestorType")]
        public int KInvestorType { get; set; }
        [Required]
        [Column("sInvestorType")]
        [StringLength(1)]
        public string SInvestorType { get; set; }
        [Required]
        [Column("sInvestorTypeDescription")]
        [StringLength(50)]
        public string SInvestorTypeDescription { get; set; }
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
    }
}
