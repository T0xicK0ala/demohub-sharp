﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_BasisOfMovement", Schema = "chs")]
    public partial class TblSBasisOfMovement
    {
        [Key]
        [Column("kBasisOfMovement")]
        public int KBasisOfMovement { get; set; }
        [Required]
        [Column("sBasisOfMovement")]
        [StringLength(2)]
        public string SBasisOfMovement { get; set; }
        [Required]
        [Column("sBasisOfMovementDescription")]
        [StringLength(30)]
        public string SBasisOfMovementDescription { get; set; }
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
