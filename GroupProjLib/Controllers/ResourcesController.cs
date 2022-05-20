using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupProjLib.Models;

namespace GroupProjLib.Controllers
{
  public class ResourcesController
    {
        private GpDbContext _context = new GpDbContext();
        
        public List<Resources> GetResources()
        {
            return _context.Resources.ToList();
        }
        public Resources GetResources(int id)
        {
            return _context.Resources.Find(id)!;
        }
        public void AddResources(Resources Name)
        {
            _context.Resources.Add(Name);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("Add resource failed!");
            }             
        }
        public void UpdateResource(Resources name)
        {
            _context.Entry(name).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("Update resourse failed!");
            }
        }
        public void DeleteResource(int id)
        {
            var resource = GetResources(id);
            if (resource is null)
            {
                throw new Exception("Resource not found!");
            }
            _context.Resources.Remove(resource);
            var rowsAffected = _context.SaveChanges();
            if(rowsAffected != 1)
            {
                throw new Exception("Delete resource failed!");
            }
        }

    }
}
