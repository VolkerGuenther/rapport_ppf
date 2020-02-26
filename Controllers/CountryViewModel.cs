using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rapport_ppf.Models;

namespace rapport_ppf.Controllers
{
    public class CountryViewModel : Controller
    { 
        public IActionResult Index()
        {
            var model = new Countries();
            model.Country = "CA";
            return View("/Views/Project/C_Index.cshtml", model);
        }
    }
}
