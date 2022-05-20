using Microsoft.EntityFrameworkCore;
using GroupProjLib.Models;
using GroupProjLib.Controllers;

var db = new GpDbContext();
var pc = new ProjectController();
var rc = new ResourcesController();
var wc = new WorkController();

//Remove the comment around the regions for creating the data when you want to create the data.
//Re-add the comment around the regions after creation of the data to run other code.

/*
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


#region ResourceData
var res1 = new Resources();
var res2 = new Resources();
var res3 = new Resources();
var res4 = new Resources();
var res5 = new Resources();
var res6 = new Resources();


res1.Name = "Dorothy";
res1.HoursPerDay = 12;

res2.Name = "Sophia";
res2.HoursPerDay = 10;

res3.Name = "Blanche";
res3.HoursPerDay = 5;

res4.Name = "Rose";
res4.HoursPerDay = 10;

res5.Name = "Groucho";
res5.HoursPerDay = 8;

res6.Name = "Harpo";
res6.HoursPerDay = 4;

rc.AddResources(res1);
rc.AddResources(res2);
rc.AddResources(res3);
rc.AddResources(res4);
rc.AddResources(res5);
rc.AddResources(res6);

#endregion

#region Work Data

var work1 = new Work();
var work2 = new Work();
var work3 = new Work();
var work4 = new Work();
var work5 = new Work();
var work6 = new Work();
var work7 = new Work();
var work8 = new Work();

work1.ProjectId = 1;
work1.Description = "Kitchen Cabinet";
work1.Hours = 2;

work2.ProjectId = 2;
work2.Description = "Retile Floor";
work2.Hours = 16;

work3.ProjectId = 1;
work3.Description = "Sink Install";
work3.Hours = 1;

work4.ProjectId = 1;
work4.Description = "Flooring tile";
work4.Hours = 20;

work5.ProjectId = 2;
work5.Description = "Vanity install";
work5.Hours = 3;

work6.ProjectId = 2;
work6.Description = "Sink Install";
work6.Hours = 2;

work7.ProjectId = 3;
work7.Description = "Shelving Install";
work7.Hours = 25;

work8.ProjectId = 6;
work8.Description = "Pour and stamp Concrete";
work8.Hours = 12;

wc.AddWork(work1);
wc.AddWork(work2);
wc.AddWork(work3);
wc.AddWork(work4);
wc.AddWork(work5);
wc.AddWork(work6);
wc.AddWork(work7);
wc.AddWork(work8);

#endregion
*/


#region TestingAutoProjectAssign

var work = wc.GetWork(1);

work.ResourcesId = 1;

wc.UpdateWork(work);

#endregion