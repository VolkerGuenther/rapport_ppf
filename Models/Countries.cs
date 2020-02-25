using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace rapport_ppf.Models
{
    public class Countries
    {
        public string Country { get; set; }

        public List<SelectListItem> Laender { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "MX", Text = "Mexico"},
            new SelectListItem { Value = "CA", Text = "Canada"},
            new SelectListItem { Value = "US", Text = "USA"},
        };
    }
}
