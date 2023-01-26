using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Models;

namespace CloudManifestServices.Interfaces
{
    interface IChangeMetricsHistorical
    {
        IEnumerable<ChangeMetricsHistorical> Get();
        void Insert(ChangeMetricsHistorical changeMetricsHistorical);
        void Update(String cloud, ChangeMetricsHistorical changeMetricsHistorical);
        ChangeMetricsHistorical Single(String cloud);
        void Delete(String cloud);
    }
}
