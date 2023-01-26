using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Models;

namespace CloudManifestServices.Interfaces
{
    interface IManifestManagement
    {
        IEnumerable<ManifestManagement> Get();
        void Insert(ManifestManagement manifestmanagement);
        void Update(String manifest, ManifestManagement manifestmanagement);
        ManifestManagement Single(String manifest);
        void Delete(String manifest);
    }
}
