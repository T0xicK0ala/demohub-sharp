using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_I_CHESSMessageTypes", Schema = "chs")]
    public partial class TblIChessmessageTypes
    {
        public TblIChessmessageTypes()
        {
            TblDRawMessage = new HashSet<TblDRawMessage>();
        }

        [Key]
        [Column("kCHESSMessageType")]
        public int KChessmessageType { get; set; }
        [Required]
        [Column("cCHESSMessageTypeIndex")]
        [StringLength(3)]
        public string CChessmessageTypeIndex { get; set; }
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
