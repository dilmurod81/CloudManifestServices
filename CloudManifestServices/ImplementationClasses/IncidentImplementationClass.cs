using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Interfaces;
using CloudManifestServices.Models;

namespace CloudManifestServices.ImplementationClasses
{
    public class IncidentImplementationClass : IIncident
    {
        private ProvokeDBContext _context;
        public IncidentImplementationClass(ProvokeDBContext context)
        {
            _context = context;
        }

        public void DeleteIncident(int icm)
        {
            try
            {
                Incident eachService = _context.Incident.Find(icm);
                _context.Incident.Remove(eachService);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Incident> GetIncidents()
        {

            try
            {
                return _context.Incident.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void InsertIncident(Incident incident)
        {
            try
            {
                _context.Incident.Add(incident);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Incident SingleIncident(int icm)
        {
            throw new NotImplementedException();
        }

        public void UpdateIncident(int icm, Incident incident)
        {
            try
            {
                var local = _context.Set<Incident>().Local.FirstOrDefault(entry => entry.IcMincidentId.Equals(incident.IcMincidentId));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(incident).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        
    }
}
