using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace rapport_ppf.Models.Repository
{


    public class OrderRepo
    {
        // Static, damit die Inhalte erhalten bleiben
        public static List<Order> Data = new List<Order>();

        public static List<Order> getAll()
        {
            // Folgende Definition würde bedeuten, dass die List nur existiert innnerhalb der Methode getAll
            // getAll wird mit einem return Statement beendet. Dann ist die Liste auch wieder leer beim nächsten
            // Aufruf
            // List<Order> Data = new List<Order>();

            if (Data.Count > 0)
            {
                // Wenn die Liste bereits Einträge hat.
                // Wenn die Liste erst in getAll definiert wird, dann
                return Data;
            }

            // Lebensdauer: Ende Index Methode

            var fi = new System.IO.FileInfo(@"C:\Users\Volker\source\repos\rapport_ppf\Models\Tagesrapporte_aktuell_3.xlsx");
            if (!fi.Exists)
            {
                fi = new FileInfo(@"C:\Users\IFLRGU\Documents\Kunden\Prüflabor\Tagesrapporte_aktuell_3.xlsx");
            }

            // Lebensdauer: Variable p an den using Block gebunden
            using (var p = new ExcelPackage(fi))
            // Start: using
            {
                // Lebensdauer ws wie p: Bis Ende Block using
                var ws = p.Workbook.Worksheets["Kopf"];

                // Schleife, neuer Subbloc
                var id = 2;
                // Wenn auf true/false getestet wird, dann nimmt einen logischen Ausdruck. So heisst das in den runden Klammern
                // Logischer Ausdruck im while(): Muss Wert haben und der Wert ohne Leerzeichen sein. Nur dann geht es im While weiter
                while (ws.Cells[id, 3].Value != null )
                    //& ws.Cells[id, 3].Value.ToString().Trim().Length > 0)
                // Start: Schleife
                {
                    // Die folgenden Variablen haben alle Lebensdauer 1 (!!!) Schleifendurchgang
                    // Du definierst die Variablen, befüllst sie mit den Zellwerten
                    // Doch dann machst Du gar nichts mehr mit den Variablen
                    // In diesem Fall kannst Du alles löschen bzw. einen Weg finden wie Du die Daten behältst 
                    // bis zum Ende der Index Methode, bis zum return Statement
                    Order order = new Order();
                    if (ws.Cells[id, 3].Value != null)
                        order.Auftragsnummer = ws.Cells[id, 3].Value.ToString();
                    if (ws.Cells[id, 4].Value != null)
                        order.Kunde = ws.Cells[id, 4].Value.ToString();
                    if (ws.Cells[id, 5].Value != null)
                        order.Projektbeschreib = ws.Cells[id, 5].Value.ToString();
                    if (ws.Cells[id, 6].Value != null)
                        order.Standort = ws.Cells[id, 6].Value.ToString();
                    if (ws.Cells[id, 7].Value != null)
                        order.VerPerson = ws.Cells[id, 7].Value.ToString();
                    if (ws.Cells[id, 8].Value != null)
                        order.TotalPreis = decimal.Parse(ws.Cells[id, 8].Value.ToString());
                    if (ws.Cells[id, 9].Value != null)
                        order.Verrechnet = ws.Cells[id, 9].Value.ToString();

                    //for (int TagRap = 1; TagRap <= 2; TagRap += 1)
                    //{
                    //    var value = ws.Cells[id, TagRap].Value;
                    //}
                    Data.Add(order);
                    id++;
                    // Ende: Schleife
                }
                p.Save();
                // Ende: using
            }
            return Data;
        }
    }
}
