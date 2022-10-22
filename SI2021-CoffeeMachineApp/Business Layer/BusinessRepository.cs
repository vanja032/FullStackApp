using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
using Data_Layer.Models;
using Data_Layer.Interfaces;
using Business_Layer.Interfaces;

namespace Business_Layer
{
    public class BusinessRepository: IBusinessRepository
    {
        private readonly IMagacinRepository dataRepository;
        public Magacin magacin { get; set; }
        public BusinessRepository(IMagacinRepository magacinRepository)
        {
            dataRepository = magacinRepository;
        }
        public Magacin getData()
        {
            magacin = dataRepository.GetAllData();
            return magacin;
        }
        public void ClearMagacin()
        {
            this.magacin = new Magacin();
        }
        public bool InsertProizvod(Proizvod p)
        {
            return dataRepository.InsertProizvod(p) != 0;
        }
        public bool InsertProizvodjac(Proizvodjac p)
        {
            return dataRepository.InsertProizvodjac(p) != 0;
        }
        public bool InsertDobavljac(Dobavljac d)
        {
            return dataRepository.InsertDobavljac(d) != 0;
        }
        public bool InsertDopremnica(Dopremnica d)
        {
            return dataRepository.InsertDopremnica(d) != 0;
        }
        public bool InsertNarudzbina(Narudzbina n)
        {
            return dataRepository.InsertNarudzbina(n) != 0;
        }
        public bool InsertEvidencija(Evidencija e)
        {
            return dataRepository.InsertEvidencija(e) != 0;
        }
        public bool InsertRadnik(Radnik r)
        {
            return dataRepository.InsertRadnik(r) != 0;
        }
        public bool InsertKorisnik(Korisnik k)
        {
            return dataRepository.InsertKorisnik(k) != 0;
        }


        public bool DeleteProizvod(int ID_Proizvoda)
        {
            return dataRepository.DeleteProizvod(ID_Proizvoda) != 0;
        }
        public bool DeleteProizvodjac(int ID_Proizvodjaca)
        {
            return dataRepository.DeleteProizvodjac(ID_Proizvodjaca) != 0;
        }
        public bool DeleteDobavljac(int ID_Dobavljaca)
        {
            return dataRepository.DeleteDobavljac(ID_Dobavljaca) != 0;
        }
        public bool DeleteDopremnica(int ID_Dopremnice)
        {
            return dataRepository.DeleteDopremnica(ID_Dopremnice) != 0;
        }
        public bool DeleteNarudzbina(int ID_Narudzbine)
        {
            return dataRepository.DeleteNarudzbina(ID_Narudzbine) != 0;
        }
        public bool DeleteEvidencija(int ID_Narudzbine, int ID_Proizvoda)
        {
            return dataRepository.DeleteEvidencija(ID_Narudzbine,ID_Proizvoda) != 0;
        }
        public bool DeleteRadnik(int ID_Radnika)
        {
            return dataRepository.DeleteRadnik(ID_Radnika) != 0;
        }
        public bool DeleteKorisnik(int ID_Korisnika)
        {
            return dataRepository.DeleteKorisnik(ID_Korisnika) != 0;
        }


        public bool UpdateProizvod(int ID, Proizvod p)
        {
            return dataRepository.UpdateProizvod(ID,p) != 0;
        }
        public bool UpdateProizvodjac(int ID, Proizvodjac p)
        {
            return dataRepository.UpdateProizvodjac(ID, p) != 0;
        }
        public bool UpdateDobavljac(int ID, Dobavljac d)
        {
            return dataRepository.UpdateDobavljac(ID, d) != 0;
        }
        public bool UpdateDopremnica(int ID, Dopremnica d)
        {
            return dataRepository.UpdateDopremnica(ID, d) != 0;
        }
        public bool UpdateNarudzbina(int ID, Narudzbina n)
        {
            return dataRepository.UpdateNarudzbina(ID, n) != 0;
        }
        public bool UpdateEvidencija(int ID_1, int ID_2, Evidencija e)
        {
            return dataRepository.UpdateEvidencija(ID_1, ID_2,e) != 0;
        }
        public bool UpdateRadnik(int ID, Radnik r)
        {
            return dataRepository.UpdateRadnik(ID, r) != 0;
        }
        public bool UpdateKorisnik(int ID, Korisnik k)
        {
            return dataRepository.UpdateKorisnik(ID, k) != 0;
        }


    }
}
