using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
using Data_Layer.Models;

namespace Business_Layer.Interfaces
{
    public interface IBusinessRepository
    {
        Magacin getData();
        void ClearMagacin();
        bool InsertProizvod(Proizvod p);
        bool InsertProizvodjac(Proizvodjac p);
        bool InsertDobavljac(Dobavljac d);
        bool InsertDopremnica(Dopremnica d);
        bool InsertNarudzbina(Narudzbina n);
        bool InsertEvidencija(Evidencija e);
        bool InsertRadnik(Radnik r);
        bool InsertKorisnik(Korisnik k);
        bool DeleteProizvod(int ID_Proizvoda);
        bool DeleteProizvodjac(int ID_Proizvodjaca);
        bool DeleteDobavljac(int ID_Dobavljaca);
        bool DeleteDopremnica(int ID_Dopremnice);
        bool DeleteNarudzbina(int ID_Narudzbine);
        bool DeleteEvidencija(int ID_Narudzbine, int ID_Proizvoda);
        bool DeleteRadnik(int ID_Radnika);
        bool DeleteKorisnik(int ID_Korisnika);
        bool UpdateProizvod(int ID, Proizvod p);
        bool UpdateProizvodjac(int ID, Proizvodjac p);
        bool UpdateDobavljac(int ID, Dobavljac d);
        bool UpdateDopremnica(int ID, Dopremnica d);
        bool UpdateNarudzbina(int ID, Narudzbina n);
        bool UpdateEvidencija(int ID_1, int ID_2, Evidencija e);
        bool UpdateRadnik(int ID, Radnik r);
        bool UpdateKorisnik(int ID, Korisnik k);
    }
}
