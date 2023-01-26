using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Models;

namespace CloudManifestServices.Interfaces
{
    interface IProcessControl
    {
        IEnumerable<ProcessControl> GetProcess();
        void InsertProcess(ProcessControl process);
        void UpdateProcess(int id, ProcessControl process);
        ProcessControl SingleProcess(int id);
        void DeleteProcess(int id);
    }
}
