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

        public void ProjectAssignBasedOnWork(Work work) {
            var resource = _context.Resources.Find(work.ResourcesId);
            if (resource == null) {
                throw new Exception("There is no value for this resourceId.");
            }
            resource.ProjectId = work.ProjectId;
            _context.SaveChanges();
        }

        public void RecalculateActualHours(int projId) {
            var project = _context.Projects.Find(projId);
            if (project == null) {
                throw new Exception("There is no value for this projectId.");
            }
            project.actualHours = (from w in _context.Works
                                   where w.ProjectId == projId
                                   select new { TotalHours = w.Hours }).Sum(x => x.TotalHours);
            _context.SaveChanges();
        }

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
            RecalculateActualHours(work.ProjectId);
            ProjectAssignBasedOnWork(work);
        }


        //Add Work
        public void AddWork(Work work) {
            _context.Works.Add(work);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                throw new Exception("Add Work failed!");
            RecalculateActualHours(work.ProjectId);
            ProjectAssignBasedOnWork(work);
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
            RecalculateActualHours(work.ProjectId);
            ProjectAssignBasedOnWork(work);
        }

    }
}
