using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Models
{
    public class Proizvod
    {
        public int ID_Proizvoda { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public Proizvodjac FK_Proizvodjac { get; set; }
        public string Slika_Proizvoda { get; set; }
        public decimal Cena { get; set; }
    }
}
