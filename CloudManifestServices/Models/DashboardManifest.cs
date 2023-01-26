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
    [Table("Dashboard_Manifest")]
    public partial class DashboardManifest
    {
        [Column(TypeName = "datetime")]
        public DateTime? ProcessDate { get; set; }
        [Column("NumberRPs_Total")]
        public int? NumberRpsTotal { get; set; }
        [Column("NumberRPs_PROD")]
        public int? NumberRpsProd { get; set; }
        [Column("NumberRPs_JSON")]
        public int? NumberRpsJson { get; set; }
        [Column("NumberRPs_ErrorFile")]
        public int? NumberRpsErrorFile { get; set; }
        [Column("NumberRTs_Total")]
        public int? NumberRtsTotal { get; set; }
        [Column("NumberRTs_Default")]
        public int? NumberRtsDefault { get; set; }
    }
}