using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Models;

namespace CloudManifestServices.Interfaces
{
    interface IChangeLogHistorical
    {
        IEnumerable<ChangeLogsHistorical> Get();
        void Insert(ChangeLogsHistorical log);
        void Update(String cloud, ChangeLogsHistorical changeLogsHistorical);
        ChangeLogsHistorical Single(String cloud);
        void Delete(String cloud);
    }
}
