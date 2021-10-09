using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_MessageCategory", Schema = "chs")]
    public partial class TblSMessageCategory
    {
        [Key]
        [Column("kMessageCategory")]
        public int KMessageCategory { get; set; }
        [Required]
        [Column("sMessageCategory")]
        [StringLength(50)]
        public string SMessageCategory { get; set; }
    }
}
