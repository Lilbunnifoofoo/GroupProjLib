using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupProjLib.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupProjLib.Controllers {
    public class WorkController {

        private GpDbContext _context = new GpDbContext();

        //Read Works
        public List<Work> GetWorks() {
            return _context.Works.ToList();
        }

        //Read Work by Id
        public Work GetWork(int Id) {
            return _context.Works.Find(Id)!;
        }


        //Update Work
        public void UpdateWork(Work work) {
            _context.Entry(work).State = EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                throw new Exception("Update Failed!");
        }


        //Add Work
        public void AddWork(Work work) {
            _context.Works.Add(work);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                throw new Exception("Add Work failed!");
        }


        //Delete Work
        public void DeleteWork(int id) {
            var work = GetWork(id);
            if (work is null)
                throw new Exception("Work does not exist!");
            _context.Works.Remove(work);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                throw new Exception("Remove failed!");
        }

    }
}
