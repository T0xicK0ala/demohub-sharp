using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_D_RawMessage", Schema = "chs")]
    public partial class TblDRawMessage
    {
        [Key]
        [Column("kRawMessage")]
        public int KRawMessage { get; set; }
        [Required]
        [Column("sRawMessage")]
        [MaxLength(8000)]
        public byte[] SRawMessage { get; set; }
        [Column("iMSN")]
        public int IMsn { get; set; }
        [Column("bIsIncoming")]
        public bool BIsIncoming { get; set; }
        [Column("fkMessageType")]
        public int FkMessageType { get; set; }
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

        [ForeignKey(nameof(FkMessageType))]
        [InverseProperty(nameof(TblIChessmessageTypes.TblDRawMessage))]
        public virtual TblIChessmessageTypes FkMessageTypeNavigation { get; set; }
    }
}
