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
    public class ChangeLogHistoricalImplementationClass : IChangeLogHistorical
    {
        private ProvokeDBContext _context;
        public ChangeLogHistoricalImplementationClass(ProvokeDBContext context)
        {
            _context = context;
        }

        public void Delete(String cloud)
        {
            try
            {
                ChangeLogsHistorical eachService = _context.ChangeLogsHistorical.Find(cloud);
                _context.ChangeLogsHistorical.Remove(eachService);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<ChangeLogsHistorical> Get()
        {

            try
            {
                return _context.ChangeLogsHistorical.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void Insert(ChangeLogsHistorical changeLogsHistorical)
        {
            try
            {
                _context.ChangeLogsHistorical.Add(changeLogsHistorical);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public ChangeLogsHistorical Single(String cloud)
        {
            throw new NotImplementedException();
        }

        public void Update(String sourceId, ChangeLogsHistorical changeLogsHistorical)
        {
            try
            {
                var local = _context.Set<ChangeLogsHistorical>().Local.FirstOrDefault(entry => entry.Cloud.Equals(changeLogsHistorical.Cloud));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(changeLogsHistorical).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        
    }
}
