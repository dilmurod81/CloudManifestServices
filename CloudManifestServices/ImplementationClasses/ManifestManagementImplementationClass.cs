using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Interfaces;
using CloudManifestServices.Models;

namespace CloudManifestServices.ImplementationClasses
{
    public class ManifestManagementImplementationClass : IManifestManagement
    {
        private ProvokeDBContext _context;
        public ManifestManagementImplementationClass(ProvokeDBContext context)
        {
            _context = context;
        }

        public void Delete(String manifest)
        {
            try
            {
                ManifestManagement eachService = _context.ManifestManagement.Find(manifest);
                _context.ManifestManagement.Remove(eachService);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<ManifestManagement> Get()
        {

            try
            {
                return _context.ManifestManagement.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void Insert(ManifestManagement manifest)
        {
            try
            {
                _context.ManifestManagement.Add(manifest);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public ManifestManagement Single(String manifest)
        {
            throw new NotImplementedException();
        }

        public void Update(String manifest, ManifestManagement manifestmanagement)
        {
            try
            {
                var local = _context.Set<ManifestManagement>().Local.FirstOrDefault(entry => entry.ResourceProvider.Equals(manifestmanagement.ResourceProvider));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(manifestmanagement).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        
    }
}
