using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rapport.Models;

namespace rapport.Controllers
{
    public class CountryController : Controller
    { 
        public IActionResult Index()
        {
            var model = new CountryViewModel();
            model.Country = "CA";
            return View("/Views/Country/Index.cshtml", model);
        }
    }
}
