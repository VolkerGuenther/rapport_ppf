using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rapport_ppf.Models
{
    public class Order
    {

        public String Auftragsnummer { get; set; }

        public String Kunde { get; set; }

        public String Projektbeschreib { get; set; }

        public String Standort { get; set; }

        public String VerPerson { get; set; }

        public decimal TotalPreis { get; set; }

        public String Verrechnet { get; set; }
    }
}
