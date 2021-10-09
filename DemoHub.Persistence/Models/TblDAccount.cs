using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_Account", Schema = "chs")]
    public partial class TblDAccount
    {
        public TblDAccount()
        {
            TblDHolder = new HashSet<TblDHolder>();
        }

        [Key]
        [Column("kAccount")]
        public int KAccount { get; set; }
        [Column("sAccountNumber")]
        [StringLength(9)]
        public string SAccountNumber { get; set; }
        [Column("sRegAccountNumber")]
        [StringLength(20)]
        public string SRegAccountNumber { get; set; }
        [Column("sAccountName")]
        [StringLength(32)]
        public string SAccountName { get; set; }
        [Column("bAccountCancellation")]
        public bool? BAccountCancellation { get; set; }
        [Column("fkAccountPurpose")]
        public int? FkAccountPurpose { get; set; }
        [Column("fkAccountType")]
        public int FkAccountType { get; set; }
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

        [ForeignKey(nameof(FkAccountPurpose))]
        [InverseProperty(nameof(TblSAccountPurpose.TblDAccount))]
        public virtual TblSAccountPurpose FkAccountPurposeNavigation { get; set; }
        [ForeignKey(nameof(FkAccountType))]
        [InverseProperty(nameof(TblSAccountType.TblDAccount))]
        public virtual TblSAccountType FkAccountTypeNavigation { get; set; }
        [InverseProperty("FkAccountNavigation")]
        public virtual ICollection<TblDHolder> TblDHolder { get; set; }
    }
}
