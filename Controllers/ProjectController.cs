using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace rapport_ppf.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {

            var fi = new FileInfo(@"C:\Users\Volker\source\repos\rapport_ppf\Models\Essen.xlsx");
            using (var p = new ExcelPackage(fi))
            {
                //Get the Worksheet created in the previous codesample. 
                //orkbook.Worksheets["MySheet"];
                //Set the cell value using row and column.
                //ws.Cells[2, 1].Value = "This is cell A2. It is set to bolds";
                //The style object is used to access most cells formatting and styles.
                //ws.Cells[2, 1].Style.Font.Bold = true;
                //Save and close the package.
                var ws = p.Workbook.Worksheets["Kopf"];
                var value1 = ws.Cells[1,1].Value;
                var value12 = ws.Cells[1, 2].Value;
                Console.WriteLine(value1); 
                Console.WriteLine(value12);
                p.Save();
            }
            return View();
        }
    }
}