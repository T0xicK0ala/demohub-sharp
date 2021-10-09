using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_TransactionClassParameter", Schema = "chsrep")]
    public partial class TblSTransactionClassParameter
    {
        public TblSTransactionClassParameter()
        {
            TblDReportRequest = new HashSet<TblDReportRequest>();
            TblDReportingRequestDetail = new HashSet<TblDReportingRequestDetail>();
        }

        [Key]
        [Column("kTransactionClassParameter")]
        public int KTransactionClassParameter { get; set; }
        [Required]
        [Column("sTransactionClassParameter")]
        [StringLength(1)]
        public string STransactionClassParameter { get; set; }
        [Required]
        [Column("sTransactionClassParameterDescription")]
        [StringLength(40)]
        public string STransactionClassParameterDescription { get; set; }
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

        [InverseProperty("FkPtransactionClassNavigation")]
        public virtual ICollection<TblDReportRequest> TblDReportRequest { get; set; }
        [InverseProperty("FkPtransactionClassNavigation")]
        public virtual ICollection<TblDReportingRequestDetail> TblDReportingRequestDetail { get; set; }
    }
}
