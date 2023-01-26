﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CloudManifestServices.Models
{
    [Table("Change_Metrics_Historical_NAMM")]
    public partial class ChangeMetricsHistoricalNamm
    {
        [Key]
        [StringLength(50)]
        public string Cloud { get; set; }
        [Key]
        [Column("ResourceProviderType_Total")]
        [StringLength(200)]
        public string ResourceProviderTypeTotal { get; set; }
        [Key]
        [Column("Metric_Total")]
        [StringLength(100)]
        public string MetricTotal { get; set; }
        [Required]
        [StringLength(10)]
        [Unicode(false)]
        public string ChangeType { get; set; }
        public int ChangeTypeNumber { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime ProcessDate { get; set; }
        [Column("Change_MetricDisplayName")]
        public int ChangeMetricDisplayName { get; set; }
        [Column("Change_Unit")]
        public int ChangeUnit { get; set; }
        [Column("Change_AggregationType")]
        public int ChangeAggregationType { get; set; }
        [Column("Change_Description")]
        public int ChangeDescription { get; set; }
        [Column("Change_Dimensions")]
        public int ChangeDimensions { get; set; }
        [Column("Change_MDMAccount")]
        public int ChangeMdmaccount { get; set; }
        [Column("Change_MDMNameSpace")]
        public int ChangeMdmnameSpace { get; set; }
        [Column("ResourceProviderType_Current")]
        [StringLength(200)]
        public string ResourceProviderTypeCurrent { get; set; }
        [Column("ResourceProviderType_Pre")]
        [StringLength(200)]
        public string ResourceProviderTypePre { get; set; }
        [Column("Metric_Current")]
        [StringLength(100)]
        public string MetricCurrent { get; set; }
        [Column("Metric_Pre")]
        [StringLength(100)]
        public string MetricPre { get; set; }
        [Column("MetricDisplayName_Current")]
        [StringLength(150)]
        public string MetricDisplayNameCurrent { get; set; }
        [Column("MetricDisplayName_Pre")]
        [StringLength(150)]
        public string MetricDisplayNamePre { get; set; }
        [Column("Unit_Current")]
        [StringLength(25)]
        public string UnitCurrent { get; set; }
        [Column("Unit_Pre")]
        [StringLength(25)]
        public string UnitPre { get; set; }
        [Column("AggregationType_Current")]
        [StringLength(25)]
        public string AggregationTypeCurrent { get; set; }
        [Column("AggregationType_Pre")]
        [StringLength(25)]
        public string AggregationTypePre { get; set; }
        [Column("Description_Current")]
        [StringLength(1200)]
        public string DescriptionCurrent { get; set; }
        [Column("Description_Pre")]
        [StringLength(1200)]
        public string DescriptionPre { get; set; }
        [Column("Dimensions_Current")]
        [StringLength(300)]
        public string DimensionsCurrent { get; set; }
        [Column("Dimensions_Pre")]
        [StringLength(300)]
        public string DimensionsPre { get; set; }
        [Column("MDMAccount_Current")]
        [StringLength(100)]
        public string MdmaccountCurrent { get; set; }
        [Column("MDMAccount_Pre")]
        [StringLength(100)]
        public string MdmaccountPre { get; set; }
        [Column("MDMNameSpace_Current")]
        [StringLength(100)]
        public string MdmnameSpaceCurrent { get; set; }
        [Column("MDMNameSpace_Pre")]
        [StringLength(100)]
        public string MdmnameSpacePre { get; set; }
        [Column("Change_TimeGrain")]
        public int? ChangeTimeGrain { get; set; }
        [Column("TimeGrain_Current")]
        [StringLength(200)]
        public string TimeGrainCurrent { get; set; }
        [Column("TimeGrain_Pre")]
        [StringLength(200)]
        public string TimeGrainPre { get; set; }
    }
}