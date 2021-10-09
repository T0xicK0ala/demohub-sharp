﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_EntrepotType", Schema = "chs")]
    public partial class TblSEntrepotType
    {
        public TblSEntrepotType()
        {
            TblDHolder = new HashSet<TblDHolder>();
            TblRHolderDetail = new HashSet<TblRHolderDetail>();
            TblRHolderHistory = new HashSet<TblRHolderHistory>();
        }

        [Key]
        [Column("kEntrepotType")]
        public int KEntrepotType { get; set; }
        [Required]
        [Column("sEntrepotType")]
        [StringLength(1)]
        public string SEntrepotType { get; set; }
        [Required]
        [Column("sEntrepotTypeDescription")]
        [StringLength(15)]
        public string SEntrepotTypeDescription { get; set; }
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

        [InverseProperty("FkEntrepotTypeNavigation")]
        public virtual ICollection<TblDHolder> TblDHolder { get; set; }
        [InverseProperty("FkEntrepotTypeNavigation")]
        public virtual ICollection<TblRHolderDetail> TblRHolderDetail { get; set; }
        [InverseProperty("FkEntrepotTypeNavigation")]
        public virtual ICollection<TblRHolderHistory> TblRHolderHistory { get; set; }
    }
}
