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
    [Table("Dashboard_Kusto")]
    public partial class DashboardKusto
    {
        [Column(TypeName = "datetime")]
        public DateTime? ProcessDate { get; set; }
        [Column("NumberRTs_Total")]
        public int? NumberRtsTotal { get; set; }
    }
}