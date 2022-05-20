using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupProjLib.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupProjLib.Controllers {
    public class ProjectController {

        private GpDbContext _context = new GpDbContext();

        //Read Projects
        public List<Project> GetProjects() {
            return _context.Projects.ToList();
        }

        //Read Project by Id
        public Project GetProject(int Id) {
            return _context.Projects.Find(Id)!;
        }


        //Update Project
        public void UpdateProject(Project project) {
            _context.Entry(project).State = EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                throw new Exception("Update Failed!");
        }


        //Add Project
        public void AddProject(Project project) {
            _context.Projects.Add(project);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                throw new Exception("Add Project failed!");
        }


        //Delete Project
        public void DeleteProject(int id) {
            var project = GetProject(id);
            if (project is null)
                throw new Exception("Project does not exist!");
            _context.Projects.Remove(project);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                throw new Exception("Remove failed!");
        }
    }
}
