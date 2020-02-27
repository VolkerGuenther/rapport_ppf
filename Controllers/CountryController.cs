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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CountryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var msg = model.Country + " selected";
                return RedirectToAction("IndexSuccess", new { message = msg });
            }

            // If we got this far, something failed; redisplay form.
            return View("/Views/Country/Index.cshtml", model);
        }
    }
}
