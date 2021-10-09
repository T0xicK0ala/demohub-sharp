﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_SubregisterStatus", Schema = "chs")]
    public partial class TblSSubregisterStatus
    {
        [Key]
        [Column("kSubregisterStatus")]
        public int KSubregisterStatus { get; set; }
        [Required]
        [Column("sSubregisterStatus")]
        [StringLength(1)]
        public string SSubregisterStatus { get; set; }
        [Required]
        [Column("sSubregisterStatusDescription")]
        [StringLength(10)]
        public string SSubregisterStatusDescription { get; set; }
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
