// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CloudManifestServices.Models
{
    [Table("Kusto_ServiceTree")]
    public partial class KustoServiceTree
    {
        [Key]
        [StringLength(100)]
        public string ResourceProvider { get; set; }
        [Key]
        [Column("ResourceTypeNoRP")]
        [StringLength(200)]
        public string ResourceTypeNoRp { get; set; }
        [Key]
        [Column("ServiceID")]
        [StringLength(100)]
        public string ServiceId { get; set; }
        [StringLength(100)]
        public string DevOnwer { get; set; }
        [StringLength(100)]
        public string DevOnwerMail { get; set; }
        [StringLength(100)]
        public string DisplayName { get; set; }
        [StringLength(150)]
        public string ServiceName { get; set; }
        [StringLength(150)]
        public string ServiceRing { get; set; }
    }
}