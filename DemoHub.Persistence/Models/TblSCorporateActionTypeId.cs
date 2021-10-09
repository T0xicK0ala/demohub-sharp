using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_CorporateActionTypeId", Schema = "chs")]
    public partial class TblSCorporateActionTypeId
    {
        public TblSCorporateActionTypeId()
        {
            TblDReportRequest = new HashSet<TblDReportRequest>();
            TblDReportingRequestDetail = new HashSet<TblDReportingRequestDetail>();
            TblRFullAdjustedSettlementInstruction = new HashSet<TblRFullAdjustedSettlementInstruction>();
        }

        [Key]
        [Column("kCorporateActionTypeId")]
        public int KCorporateActionTypeId { get; set; }
        [Required]
        [Column("sCorporateActionTypeId")]
        [StringLength(2)]
        public string SCorporateActionTypeId { get; set; }
        [Required]
        [Column("sCorporateActionTypeIdDescription")]
        [StringLength(20)]
        public string SCorporateActionTypeIdDescription { get; set; }
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

        [InverseProperty("FkPcorporateActionType")]
        public virtual ICollection<TblDReportRequest> TblDReportRequest { get; set; }
        [InverseProperty("FkPcorporateActionType")]
        public virtual ICollection<TblDReportingRequestDetail> TblDReportingRequestDetail { get; set; }
        [InverseProperty("FkCorporateActionType")]
        public virtual ICollection<TblRFullAdjustedSettlementInstruction> TblRFullAdjustedSettlementInstruction { get; set; }
    }
}
