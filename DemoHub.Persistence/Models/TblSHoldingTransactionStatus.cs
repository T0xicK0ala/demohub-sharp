using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_HoldingTransactionStatus", Schema = "chs")]
    public partial class TblSHoldingTransactionStatus
    {
        public TblSHoldingTransactionStatus()
        {
            TblRFullChesstoIssuerSponsoredConversion = new HashSet<TblRFullChesstoIssuerSponsoredConversion>();
            TblRFullIssuerSponsoredtoChessconversion = new HashSet<TblRFullIssuerSponsoredtoChessconversion>();
        }

        [Key]
        [Column("kHoldingTransactionStatus")]
        public int KHoldingTransactionStatus { get; set; }
        [Column("sHoldingTransactionStatus")]
        [StringLength(1)]
        public string SHoldingTransactionStatus { get; set; }
        [Column("sHoldingTransactionStatusDescription")]
        [StringLength(100)]
        public string SHoldingTransactionStatusDescription { get; set; }
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

        [InverseProperty("FkHoldingTransactionStatusNavigation")]
        public virtual ICollection<TblRFullChesstoIssuerSponsoredConversion> TblRFullChesstoIssuerSponsoredConversion { get; set; }
        [InverseProperty("FkHoldingTransactionStatusNavigation")]
        public virtual ICollection<TblRFullIssuerSponsoredtoChessconversion> TblRFullIssuerSponsoredtoChessconversion { get; set; }
    }
}
