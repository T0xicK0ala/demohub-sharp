using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_PositionTypeParameter", Schema = "chsrep")]
    public partial class TblSPositionTypeParameter
    {
        public TblSPositionTypeParameter()
        {
            TblDReportRequest = new HashSet<TblDReportRequest>();
            TblDReportingRequestDetail = new HashSet<TblDReportingRequestDetail>();
        }

        [Key]
        [Column("kPositionTypeParameter")]
        public int KPositionTypeParameter { get; set; }
        [Required]
        [Column("sPositionTypeParameter")]
        [StringLength(1)]
        public string SPositionTypeParameter { get; set; }
        [Required]
        [Column("sPositionTypeParameterDescription")]
        [StringLength(20)]
        public string SPositionTypeParameterDescription { get; set; }
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

        [InverseProperty("FkPpositionTypeNavigation")]
        public virtual ICollection<TblDReportRequest> TblDReportRequest { get; set; }
        [InverseProperty("FkPpositionTypeNavigation")]
        public virtual ICollection<TblDReportingRequestDetail> TblDReportingRequestDetail { get; set; }
    }
}
