using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Interfaces;
using CloudManifestServices.Models;

namespace CloudManifestServices.ImplementationClasses
{
    public class DashboardIcmImplementationClass : IDashboardIcm
    {
        private ProvokeDBContext _context;
        public DashboardIcmImplementationClass(ProvokeDBContext context)
        {
            _context = context;
        }

        public void Delete(String sourceId)
        {
            try
            {
                DashboardIcM eachService = _context.DashboardIcM.Find(sourceId);
                _context.DashboardIcM.Remove(eachService);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<DashboardIcM> Get()
        {

            try
            {
                return _context.DashboardIcM.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void Insert(DashboardIcM dashboardIcm)
        {
            try
            {
                _context.DashboardIcM.Add(dashboardIcm);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public DashboardIcM Single(String sourceId)
        {
            throw new NotImplementedException();
        }

        public void Update(String sourceId, DashboardIcM dashboardIcm)
        {
            try
            {
                var local = _context.Set<DashboardIcM>().Local.FirstOrDefault(entry => entry.SourceId.Equals(dashboardIcm.SourceId));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(dashboardIcm).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        
    }
}
