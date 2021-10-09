using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_MessageType", Schema = "chs")]
    public partial class TblSMessageType
    {
        [Key]
        [Column("kMessageType")]
        public int KMessageType { get; set; }
        [Required]
        [Column("sMessageType")]
        [StringLength(2)]
        public string SMessageType { get; set; }
        [Required]
        [Column("sMessageTypeDescription")]
        [StringLength(40)]
        public string SMessageTypeDescription { get; set; }
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
