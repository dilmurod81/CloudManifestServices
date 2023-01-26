using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudManifestServices.Models
{
    public class ServicesImplementationClass : IServices
    {
        private CloudManifestServices.Models.ProvokeDBContext _context;
        public ServicesImplementationClass(CloudManifestServices.Models.ProvokeDBContext context)
        {
            _context = context;
        }

        public void DeleteService(int id)
        {
            try
            {
                Services eachService = _context.Services.Find(id);
                _context.Services.Remove(eachService);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Services> GetServices()
        {

            try
            {
                return _context.Services.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void InsertService(Services service)
        {
            try
            {
                _context.Services.Add(service);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Services SingleService(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateService(int id, Services service)
        {
            try
            {
                var local = _context.Set<Services>().Local.FirstOrDefault(entry => entry.Id.Equals(service.Id));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(service).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        
    }
}
