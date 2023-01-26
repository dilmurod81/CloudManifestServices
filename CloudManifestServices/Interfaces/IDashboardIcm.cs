using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Models;

namespace CloudManifestServices.Interfaces
{
    interface IDashboardIcm
    {
        IEnumerable<DashboardIcM> Get();
        void Insert(DashboardIcM dashboardIcm);
        void Update(String sourceId, DashboardIcM dashboardIcm);
        DashboardIcM Single(String sourceId);
        void Delete(String sourceId);
    }
}
