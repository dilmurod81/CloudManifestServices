using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Models;

namespace CloudManifestServices.Interfaces
{
    interface IIncident
    {
        IEnumerable<Incident> GetIncidents();
        void InsertIncident(Incident incident);
        void UpdateIncident(int icm, Incident incident);
        Incident SingleIncident(int icm);
        void DeleteIncident(int icm);
    }
}
