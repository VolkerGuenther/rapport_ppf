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

            var fi = new FileInfo(@"C:\Users\Volker\source\repos\rapport_ppf\Models\Tagesrapporte_aktuell_3.xlsx");
            using (var p = new ExcelPackage(fi))
            {
                var ws = p.Workbook.Worksheets["Kopf"];

                for (int id = 1; id <= 4; id++)
                {
                    var RapportId = ws.Cells[id, 1].Value;
                    //var DatumDouble = ws.Cells[id, 2].Value;
                    long dateNum = long.Parse(ws.Cells[id, 2].Value.ToString());
                    DateTime TagesrappDatum = DateTime.FromOADate(dateNum);
                    var Auftragsnummer = ws.Cells[id, 3].Value;
                    var Kunde = ws.Cells[id, 4].Value;
                    var Projektbeschreib = ws.Cells[id, 5].Value;
                    var Standort = ws.Cells[id, 6].Value;
                    var VerPerson = ws.Cells[id, 7].Value;
                    var TotalPreis = ws.Cells[id, 8].Value;
                    var Verrechnet = ws.Cells[id, 9].Value;

                    //for (int TagRap = 1; TagRap <= 2; TagRap += 1)
                    //{
                    //    var value = ws.Cells[id, TagRap].Value;
                    //}
                }
                p.Save();
            }
            return View("/Models/ProjectTages.cs", "/Views/Project/Index.cshtml");

        }

    }
}