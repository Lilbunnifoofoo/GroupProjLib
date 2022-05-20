using Microsoft.EntityFrameworkCore;
using GroupProjLib.Models;
using GroupProjLib.Controllers;

var db = new GpDbContext();
var pc = new ProjectController();
var rc = new ResourcesController();
var wc = new WorkController();

#region Project Data

var proj1 = new Project() { };
var proj2 = new Project() { };
var proj3 = new Project() { };
var proj4 = new Project() { };
var proj5 = new Project() { };
var proj6 = new Project() { };

proj1.description = "New Kitchen";
proj1.estimatedHours = 50;
proj1.actualHours = 0;
proj1.status = "New";

proj2.description = "New Bathroom";
proj2.estimatedHours = 25;
proj2.actualHours = 0;
proj2.status = "New";

proj3.description = "New Library";
proj3.estimatedHours = 40;
proj3.actualHours = 0;
proj3.status = "New";

proj4.description = "New Foyer";
proj4.estimatedHours = 10;
proj4.actualHours = 0;
proj4.status = "New";

proj5.description = "Recarpet Stairs";
proj5.estimatedHours = 8;
proj5.actualHours = 0;
proj5.status = "New";

proj6.description = "New Driveway";
proj6.estimatedHours = 12;
proj6.actualHours = 0;
proj6.status = "New";

pc.AddProject(proj1);
pc.AddProject(proj2);
pc.AddProject(proj3);
pc.AddProject(proj4);
pc.AddProject(proj5);
pc.AddProject(proj6);

#endregion