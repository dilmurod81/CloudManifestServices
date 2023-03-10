// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CloudManifestServices.Models
{
    public partial class Services
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Title { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string ShortDescription { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ScheduledStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEntered { get; set; }
    }
}