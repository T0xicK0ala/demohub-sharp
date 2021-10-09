using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_ParticipantType", Schema = "chs")]
    public partial class TblSParticipantType
    {
        public TblSParticipantType()
        {
            TblRUserDetailHistory = new HashSet<TblRUserDetailHistory>();
        }

        [Key]
        [Column("kParticipantType")]
        public int KParticipantType { get; set; }
        [Required]
        [Column("sParticipantType")]
        [StringLength(1)]
        public string SParticipantType { get; set; }
        [Required]
        [Column("sParticipantTypeDescription")]
        [StringLength(10)]
        public string SParticipantTypeDescription { get; set; }
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

        [InverseProperty("FkParticipantTypeNavigation")]
        public virtual ICollection<TblRUserDetailHistory> TblRUserDetailHistory { get; set; }
    }
}
