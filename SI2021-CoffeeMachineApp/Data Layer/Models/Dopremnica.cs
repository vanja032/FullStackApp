using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Models
{
    public class Dopremnica
    {
        public int ID_Dopremnice { get; set; }
        public Proizvod FK_Proizvod { get; set; }
        public Dobavljac FK_Dobavljac { get; set; }
    }
}
