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
        {  // Start: Index()
            //
            // Block: Ein Block oder Verarbeitungsblock ist ein abgetrennter Bereich.
            // Der von-bis Bereich ist durch {} markiert
            // Werden Variablen innerhalb des Blocks definiert, dann sind sie ausserhalb des Blocks nicht erreichbar.
            // 
            // Ein Block kann untergeordnete Blocks haben. Die Sub-Blocks gehören zu dem übergeordneten Block. Die Variablen
            // sind auch im Sub-Block erreichbar.
            //

            // Lebensdauer: Ende Index Methode
            var fi = new FileInfo(@"C:\Users\Volker\source\repos\rapport_ppf\Models\Tagesrapporte_aktuell_3.xlsx");

                
            // Lebensdauer: Variable p an den using Block gebunden
            using (var p = new ExcelPackage(fi))
            // Start: using
            {
                // Lebensdauer ws wie p: Bis Ende Block using
                var ws = p.Workbook.Worksheets["Kopf"];

                // Schleife, neuer Subbloc
                for (int id = 1; id <= 4; id++)
                // Start: Schleife
                {
                     // Die folgenden Variablen haben alle Lebensdauer 1 (!!!) Schleifendurchgang
                     // Du definierst die Variablen, befüllst sie mit den Zellwerten
                     // Doch dann machst Du gar nichts mehr mit den Variablen
                     // In diesem Fall kannst Du alles löschen bzw. einen Weg finden wie Du die Daten behältst 
                     // bis zum Ende der Index Methode, bis zum return Statement
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
                // Ende: Schleife
                }
                p.Save();
            // Ende: using
            }
            return View("/Models/ProjectTages.cs", "/Views/Project/Index.cshtml");

        }
        // Ende: Index()

    }
}