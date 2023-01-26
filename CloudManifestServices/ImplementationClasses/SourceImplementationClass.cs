using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudManifestServices.Interfaces;
using CloudManifestServices.Models;

namespace CloudManifestServices.ImplementationClasses
{
    public class SourceImplementationClass : ISource
    {
        private CloudManifestServices.Models.ProvokeDBContext _context;
        public SourceImplementationClass(CloudManifestServices.Models.ProvokeDBContext context)
        {
            _context = context;
        }

        public void DeleteSource(String id)
        {
            try
            {
                Source eachService = _context.Source.Find(id);
                _context.Source.Remove(eachService);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Source> GetSource()
        {

            try
            {
                return _context.Source.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void InsertSource(Source source)
        {
            try
            {
                _context.Source.Add(source);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Source SingleSource(String id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSource(String id, Source source)
        {
            try
            {
                var local = _context.Set<Source>().Local.FirstOrDefault(entry => entry.Id.Equals(source.Id));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(source).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        
    }
}
