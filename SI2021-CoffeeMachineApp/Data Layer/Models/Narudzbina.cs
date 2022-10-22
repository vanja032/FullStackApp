using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Models
{
    public class Narudzbina
    {
        public int ID_Narudzbine { get; set; }
        public string Napomena { get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; }

    }
}
