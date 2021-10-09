using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_I_FundIDType")]
    public partial class TblIFundIdtype
    {
        public TblIFundIdtype()
        {
            TblDCalastoneTransactionRequest = new HashSet<TblDCalastoneTransactionRequest>();
        }

        [Key]
        [Column("kFundIDType")]
        public int KFundIdtype { get; set; }
        [Required]
        [Column("sFundIDType")]
        [StringLength(35)]
        public string SFundIdtype { get; set; }
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

        [InverseProperty("FkFundIdtypeNavigation")]
        public virtual ICollection<TblDCalastoneTransactionRequest> TblDCalastoneTransactionRequest { get; set; }
    }
}
