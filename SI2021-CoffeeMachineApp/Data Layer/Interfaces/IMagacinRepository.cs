using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
using Data_Layer.Models;

namespace Data_Layer.Interfaces
{
    public interface IMagacinRepository
    {
        Magacin GetAllData();

        int InsertProizvod(Proizvod p);
        int InsertProizvodjac(Proizvodjac p);
        int InsertDobavljac(Dobavljac d);
        int InsertDopremnica(Dopremnica d);
        int InsertNarudzbina(Narudzbina n);
        int InsertEvidencija(Evidencija e);
        int InsertRadnik(Radnik r);
        int InsertKorisnik(Korisnik k);
        int DeleteProizvod(int ID_Proizvoda);
        int DeleteProizvodjac(int ID_Proizvodjaca);
        int DeleteDobavljac(int ID_Dobavljaca);
        int DeleteDopremnica(int ID_Dopremnice);
        int DeleteNarudzbina(int ID_Narudzbine);
        int DeleteEvidencija(int ID_Narudzbine, int ID_Proizvoda);
        int DeleteRadnik(int ID_Radnika);
        int DeleteKorisnik(int ID_Korisnika);
        int UpdateProizvod(int ID, Proizvod p);
        int UpdateProizvodjac(int ID, Proizvodjac p);
        int UpdateDobavljac(int ID, Dobavljac d);
        int UpdateDopremnica(int ID, Dopremnica d);
        int UpdateNarudzbina(int ID, Narudzbina n);
        int UpdateEvidencija(int ID_1, int ID_2, Evidencija e);
        int UpdateRadnik(int ID, Radnik r);
        int UpdateKorisnik(int ID, Korisnik k);
    }
}
