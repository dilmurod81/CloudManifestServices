// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CloudManifestServices.Models
{
    [Keyless]
    [Index("Cloud", "ResourceProviderType", Name = "Idx_DiagnosticLogCategories")]
    public partial class DiagnosticLogCategories
    {
        [Required]
        [StringLength(50)]
        public string Cloud { get; set; }
        [Required]
        [StringLength(200)]
        public string ResourceProviderType { get; set; }
        [StringLength(100)]
        public string Category { get; set; }
        [StringLength(150)]
        public string CategoryDisplayName { get; set; }
        public int? Approved { get; set; }
        public int? CostsToExport { get; set; }
    }
}