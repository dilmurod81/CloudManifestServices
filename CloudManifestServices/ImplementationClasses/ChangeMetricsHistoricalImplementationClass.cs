using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Interfaces;
using CloudManifestServices.Models;
using CloudManifestServices.Pages;

namespace CloudManifestServices.ImplementationClasses
{
    public class ChangeMetricsHistoricalImplementationClass : IChangeMetricsHistorical
    {
        private ProvokeDBContext _context;
        public ChangeMetricsHistoricalImplementationClass(ProvokeDBContext context)
        {
            _context = context;
        }

        public void Delete(String cloud)
        {
            try
            {
                ChangeMetricsHistorical eachService = _context.ChangeMetricsHistorical.Find(cloud);
                _context.ChangeMetricsHistorical.Remove(eachService);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<ChangeMetricsHistorical> Get()
        {

            try
            {
                return _context.ChangeMetricsHistorical.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void Insert(ChangeMetricsHistorical changeMetricsHistorical)
        {
            try
            {
                _context.ChangeMetricsHistorical.Add(changeMetricsHistorical);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public ChangeMetricsHistorical Single(String cloud)
        {
            throw new NotImplementedException();
        }

        public void Update(String cloud, ChangeMetricsHistorical changeMetricsHistorical)
        {
            try
            {
                var local = _context.Set<ChangeMetricsHistorical>().Local.FirstOrDefault(entry => entry.Cloud.Equals(changeMetricsHistorical.Cloud));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(changeMetricsHistorical).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        
    }
}
