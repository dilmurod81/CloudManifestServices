using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Interfaces;
using CloudManifestServices.Models;

namespace CloudManifestServices.ImplementationClasses
{
    public class ProcessImplementationClass : IProcessControl
    {
        private ProvokeDBContext _context;
        public ProcessImplementationClass(ProvokeDBContext context)
        {
            _context = context;
        }

        public void DeleteProcess(int id)
        {
            try
            {
                ProcessControl eachService = _context.ProcessControl.Find(id);
                _context.ProcessControl.Remove(eachService);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<ProcessControl> GetProcess()
        {

            try
            {
                return _context.ProcessControl.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void InsertProcess(ProcessControl process)
        {
            try
            {
                _context.ProcessControl.Add(process);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public ProcessControl SingleProcess(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProcess(int id, ProcessControl process)
        {
            try
            {
                var local = _context.Set<ProcessControl>().Local.FirstOrDefault(entry => entry.Id.Equals(process.Id));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(process).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        
    }
}
