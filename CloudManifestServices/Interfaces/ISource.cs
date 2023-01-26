using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Models;

namespace CloudManifestServices.Interfaces
{
    interface ISource
    {
        IEnumerable<Source> GetSource();
        void InsertSource(Source source);
        void UpdateSource(String id, Source source);
        Source SingleSource(String id);
        void DeleteSource(String id);
    }
}
