﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CloudManifestServices.Models
{
    [Table("Change_Metrics_Historical_ACROSS_Clouds_NAMM")]
    public partial class ChangeMetricsHistoricalAcrossCloudsNamm
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
        [Column("ResourceProviderType_Master")]
        [StringLength(200)]
        public string ResourceProviderTypeMaster { get; set; }
        [Column("ResourceProviderType_Selected")]
        [StringLength(200)]
        public string ResourceProviderTypeSelected { get; set; }
        [Column("Metric_Master")]
        [StringLength(100)]
        public string MetricMaster { get; set; }
        [Column("Metric_Selected")]
        [StringLength(100)]
        public string MetricSelected { get; set; }
        [Column("MetricDisplayName_Master")]
        [StringLength(150)]
        public string MetricDisplayNameMaster { get; set; }
        [Column("MetricDisplayName_Selected")]
        [StringLength(150)]
        public string MetricDisplayNameSelected { get; set; }
        [Column("Unit_Master")]
        [StringLength(25)]
        public string UnitMaster { get; set; }
        [Column("Unit_Selected")]
        [StringLength(25)]
        public string UnitSelected { get; set; }
        [Column("AggregationType_Master")]
        [StringLength(25)]
        public string AggregationTypeMaster { get; set; }
        [Column("AggregationType_Selected")]
        [StringLength(25)]
        public string AggregationTypeSelected { get; set; }
        [Column("Description_Master")]
        [StringLength(1200)]
        public string DescriptionMaster { get; set; }
        [Column("Description_Selected")]
        [StringLength(1200)]
        public string DescriptionSelected { get; set; }
        [Column("Dimensions_Master")]
        [StringLength(300)]
        public string DimensionsMaster { get; set; }
        [Column("Dimensions_Selected")]
        [StringLength(300)]
        public string DimensionsSelected { get; set; }
        [Column("MDMAccount_Master")]
        [StringLength(100)]
        public string MdmaccountMaster { get; set; }
        [Column("MDMAccount_Selected")]
        [StringLength(100)]
        public string MdmaccountSelected { get; set; }
        [Column("MDMNameSpace_Master")]
        [StringLength(100)]
        public string MdmnameSpaceMaster { get; set; }
        [Column("MDMNameSpace_Selected")]
        [StringLength(100)]
        public string MdmnameSpaceSelected { get; set; }
        [Column("Change_TimeGrain")]
        public int? ChangeTimeGrain { get; set; }
        [Column("TimeGrain_Master")]
        [StringLength(200)]
        public string TimeGrainMaster { get; set; }
        [Column("TimeGrain_Selected")]
        [StringLength(200)]
        public string TimeGrainSelected { get; set; }
    }
}