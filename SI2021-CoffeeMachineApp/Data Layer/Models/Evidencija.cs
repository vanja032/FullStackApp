using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Models
{
    public class Evidencija
    {
        public string Opis { get; set; }
        public string Napomena { get; set; }
        public Narudzbina FK_Narudzbina { get; set; }
        public Proizvod FK_Proizvod { get; set; }

    }
}
