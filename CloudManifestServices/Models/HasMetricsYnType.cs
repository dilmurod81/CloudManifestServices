﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CloudManifestServices.Models
{
    [Table("HasMetricsYN_Type")]
    public partial class HasMetricsYnType
    {
        [Key]
        public int Type { get; set; }
        [Required]
        [Column("Type_Description")]
        [StringLength(50)]
        public string TypeDescription { get; set; }
    }
}