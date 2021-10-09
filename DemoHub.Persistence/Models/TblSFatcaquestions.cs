using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_FATCAQuestions", Schema = "chs")]
    public partial class TblSFatcaquestions
    {
        public TblSFatcaquestions()
        {
            TblDChesstransactionRequest = new HashSet<TblDChesstransactionRequest>();
        }

        [Key]
        [Column("kFATCAQuestions")]
        public int KFatcaquestions { get; set; }
        [Required]
        [Column("sFATCAQuestions")]
        [StringLength(1)]
        public string SFatcaquestions { get; set; }
        [Required]
        [Column("sFATCAQuestionsDescription")]
        [StringLength(40)]
        public string SFatcaquestionsDescription { get; set; }
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

        [InverseProperty("FkFatcaquestionsNavigation")]
        public virtual ICollection<TblDChesstransactionRequest> TblDChesstransactionRequest { get; set; }
    }
}
