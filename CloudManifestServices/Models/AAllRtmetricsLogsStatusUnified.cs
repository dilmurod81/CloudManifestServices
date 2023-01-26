﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CloudManifestServices.Models
{
    [Keyless]
    [Table("A_AllRTMetricsLogsStatus_Unified")]
    public partial class AAllRtmetricsLogsStatusUnified
    {
        [Required]
        [StringLength(150)]
        public string Cloud { get; set; }
        [Required]
        [StringLength(150)]
        public string ResourceProvider { get; set; }
        [StringLength(150)]
        public string ResourceType { get; set; }
        [Required]
        [StringLength(150)]
        public string ResourceProviderType { get; set; }
        public byte Class { get; set; }
        [Column("Has_Metrics")]
        public bool HasMetrics { get; set; }
        [Column("Type_Metrics")]
        public byte TypeMetrics { get; set; }
        [Column("Has_Logs")]
        public bool HasLogs { get; set; }
        [Column("Type_Logs")]
        public byte TypeLogs { get; set; }
    }
}