using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Models
{
    public class Proizvodjac
    {
        public int ID_Proizvodjaca { get; set; }
        public string Naziv { get; set; }
        public string Drzava { get; set; }
        public string Adresa { get; set; }
        public string Opis { get; set; }

    }
}
