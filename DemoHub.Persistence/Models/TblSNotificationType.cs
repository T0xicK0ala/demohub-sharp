﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoHub.Persistence.Models
{
    [Table("tbl_S_NotificationType", Schema = "chs")]
    public partial class TblSNotificationType
    {
        [Key]
        [Column("kNotificationType")]
        public int KNotificationType { get; set; }
        [Required]
        [Column("sNotificationType")]
        [StringLength(1)]
        public string SNotificationType { get; set; }
        [Required]
        [Column("sNotificationTypeDescription")]
        [StringLength(20)]
        public string SNotificationTypeDescription { get; set; }
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
