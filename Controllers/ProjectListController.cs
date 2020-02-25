using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rapport.Models;

namespace rapport.Controllers
{
    public class ProjectListController : Controller
    {
        public static List<Project> ProjectList;
        public IActionResult Index()
        {
            /*  List<Project> projectList = new List<Project>();*/
            ProjectList = new List<Project>();
            {
                Project project  = new Project();
                project.Id = 1;
                project.Location = "HCMC";
                project.ProjectName = "Beton auf Ameisensäure prüfen";
                project.Responsible = "Thich Quan Duc";
                project.Order = "422";
                project.Customer = "Bird Corp";
                ProjectList.Add(project);
            }

            {
                Project project = new Project();
                project.Id = 2;
                project.Location = "HCMC";
                project.ProjectName = "Beton auf Rattenreste prüfen";
                project.Responsible = "Thich Quan Duc";
                project.Order = "169";
                project.Customer = "Bird Corp";
                ProjectList.Add(project);
            }
            return View("/Views/Project/Index.cshtml",ProjectList);
        }

       public IActionResult Index2(string searchString)
        //public async Task<IActionResult> Index2(string searchString)
        {
           // var PModels = from m in ProjectList
             //             select m;

            //if (!string.IsNullOrEmpty(searchString))
            //{
            //    PModels = PModels.Where(s => s.Order.Contains(searchString));
            //}

          return View("/Views/Project/Index.cshtml", ProjectList);
           // return View(await PModels.ToListAsync());
        }

        public string Details()
        {
            return "This is the details of a book.";
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}