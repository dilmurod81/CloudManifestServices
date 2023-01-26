using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Models;

namespace CloudManifestServices.Interfaces
{
    interface IServices
    {
        IEnumerable<Services> GetServices();
        void InsertService(Services service);
        void UpdateService(int id, Services service);
        Services SingleService(int id);
        void DeleteService(int id);
    }
}
