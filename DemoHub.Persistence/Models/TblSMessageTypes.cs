using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_MessageTypes", Schema = "chs")]
    public partial class TblSMessageTypes
    {
        public TblSMessageTypes()
        {
            TblDRawMessage = new HashSet<TblDRawMessage>();
        }

        [Key]
        [Column("kMessageType")]
        public int KMessageType { get; set; }
        [Required]
        [Column("cMessageTypeIndex")]
        [StringLength(3)]
        public string CMessageTypeIndex { get; set; }
        [Required]
        [Column("sDescription")]
        [StringLength(100)]
        public string SDescription { get; set; }
        [Column("kSender")]
        public int KSender { get; set; }
        [Column("kReceiver")]
        public int KReceiver { get; set; }

        [InverseProperty("FkMessageTypeNavigation")]
        public virtual ICollection<TblDRawMessage> TblDRawMessage { get; set; }
    }
}
