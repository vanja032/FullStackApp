using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Layer;
using Data_Layer.Models;
using Business_Layer;

namespace SI2021_CoffeeMachineApp
{
    public partial class UpisDopremnica : Form
    {
        private readonly BusinessRepository br;
        private int nacinSortiranja { get; set; }
        private List<Proizvod> listaProizvoda = new List<Proizvod>();
        private List<Dobavljac> listaDobavljaca = new List<Dobavljac>();

        private List<int> listaSelektovanihProizvodID = new List<int>();
        private List<int> listaSelektovanihDobavljacID = new List<int>();
        public UpisDopremnica(BusinessRepository br)
        {
            this.br = br; 
            InitializeComponent();
        }

        private void UpisDopremnica_Load(object sender, EventArgs e)
        {
            cbNacinSortiranja.SelectedIndex = 0;
            foreach (Proizvod proizvod in br.magacin.ListaProizvoda)
            {
                FKProizvod.Items.Add(proizvod.Naziv);
                listaProizvoda.Add(proizvod);
            }
            foreach (Dobavljac dobavljac in br.magacin.ListaDobavljaca)
            {
                FKDobavljac.Items.Add(dobavljac.Naziv);
                listaDobavljaca.Add(dobavljac);
            }
            listaSelektovanihProizvodID.Clear();
            listaSelektovanihDobavljacID.Clear();
            dataGridView1.Columns.Add("ID_Dopremnice", "ID dopremnice");
            dataGridView1.Columns.Add("FK_ID_Proizvoda", "Naziv proizvoda");
            dataGridView1.Columns.Add("FK_ID_Dobavljaca", "Naziv dobavljača"); 
            if (br.magacin.ListaDopremnica.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaDopremnica.Count - 1);
            for (int i = 0; i < br.magacin.ListaDopremnica.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaDopremnica[i].ID_Dopremnice;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaDopremnica[i].FK_Proizvod.Naziv;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaDopremnica[i].FK_Dobavljac.Naziv;
                listaSelektovanihProizvodID.Add(br.magacin.ListaDopremnica[i].FK_Proizvod.ID_Proizvoda);
                listaSelektovanihDobavljacID.Add(br.magacin.ListaDopremnica[i].FK_Dobavljac.ID_Dobavljaca);
            }

        }
        private void Sort()
        {
            for (int i = 0; i < br.magacin.ListaDopremnica.Count - 1; i++)
            {
                for (int j = i; j < br.magacin.ListaDopremnica.Count; j++)
                {
                    if (nacinSortiranja == 0 && br.magacin.ListaDopremnica[i].FK_Dobavljac.Naziv.CompareTo(br.magacin.ListaDopremnica[j].FK_Dobavljac.Naziv) > 0)
                    {
                        Dopremnica pom = br.magacin.ListaDopremnica[i];
                        br.magacin.ListaDopremnica[i] = br.magacin.ListaDopremnica[j];
                        br.magacin.ListaDopremnica[j] = pom;
                    }
                    else if (nacinSortiranja == 1 && br.magacin.ListaDopremnica[i].FK_Dobavljac.Naziv.CompareTo(br.magacin.ListaDopremnica[j].FK_Dobavljac.Naziv) < 0)
                    {
                        Dopremnica pom = br.magacin.ListaDopremnica[i];
                        br.magacin.ListaDopremnica[i] = br.magacin.ListaDopremnica[j];
                        br.magacin.ListaDopremnica[j] = pom;
                    }
                    else if (nacinSortiranja == 2 && br.magacin.ListaDopremnica[i].FK_Proizvod.Naziv.CompareTo(br.magacin.ListaDopremnica[j].FK_Proizvod.Naziv) < 0)
                    {
                        Dopremnica pom = br.magacin.ListaDopremnica[i];
                        br.magacin.ListaDopremnica[i] = br.magacin.ListaDopremnica[j];
                        br.magacin.ListaDopremnica[j] = pom;
                    }
                    else if (nacinSortiranja == 3 && br.magacin.ListaDopremnica[i].FK_Proizvod.Naziv.CompareTo(br.magacin.ListaDopremnica[j].FK_Proizvod.Naziv) < 0)
                    {
                        Dopremnica pom = br.magacin.ListaDopremnica[i];
                        br.magacin.ListaDopremnica[i] = br.magacin.ListaDopremnica[j];
                        br.magacin.ListaDopremnica[j] = pom;
                    }
                    else if (nacinSortiranja == 4 && br.magacin.ListaDopremnica[i].ID_Dopremnice < br.magacin.ListaDopremnica[j].ID_Dopremnice)
                    {
                        Dopremnica pom = br.magacin.ListaDopremnica[i];
                        br.magacin.ListaDopremnica[i] = br.magacin.ListaDopremnica[j];
                        br.magacin.ListaDopremnica[j] = pom;
                    }
                    else if (nacinSortiranja == 5 && br.magacin.ListaDopremnica[i].ID_Dopremnice > br.magacin.ListaDopremnica[j].ID_Dopremnice)
                    {
                        Dopremnica pom = br.magacin.ListaDopremnica[i];
                        br.magacin.ListaDopremnica[i] = br.magacin.ListaDopremnica[j];
                        br.magacin.ListaDopremnica[j] = pom;
                    }
                }
            }
        }
        private void Prikazi()
        {
            dataGridView1.Rows.Clear();
            if (br.magacin.ListaDopremnica.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaDopremnica.Count - 1);
            listaSelektovanihProizvodID.Clear();
            listaSelektovanihDobavljacID.Clear();
            for (int i = 0; i < br.magacin.ListaDopremnica.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaDopremnica[i].ID_Dopremnice;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaDopremnica[i].FK_Proizvod.Naziv;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaDopremnica[i].FK_Dobavljac.Naziv;
                listaSelektovanihProizvodID.Add(br.magacin.ListaDopremnica[i].FK_Proizvod.ID_Proizvoda);
                listaSelektovanihDobavljacID.Add(br.magacin.ListaDopremnica[i].FK_Dobavljac.ID_Dobavljaca);
            }
        }

        private void cbNacinSortiranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            nacinSortiranja = cbNacinSortiranja.SelectedIndex;
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            Sort();
            Prikazi();
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (FKProizvod.SelectedIndex != -1 && FKDobavljac.SelectedIndex != -1)
                {
                    Dopremnica d = new Dopremnica() { FK_Proizvod = listaProizvoda[FKProizvod.SelectedIndex], FK_Dobavljac = listaDobavljaca[FKDobavljac.SelectedIndex] };
                    if (br.InsertDopremnica(d))
                    {
                        MessageBox.Show("Uspešno ste uneli dopremnicu.");
                        FKProizvod.SelectedIndex = -1;
                        FKDobavljac.SelectedIndex = -1;
                        br.magacin = br.getData();
                        Prikazi();
                    }
                    else
                        MessageBox.Show("Dopremnica nije uneta.");
                }
                else
                {
                    MessageBox.Show("Morate popuniti sve podatke na ispravan način kako bi uneli dopremnicu!");
                }
            }
            catch { MessageBox.Show("Podaci nisu ispravno uneti!"); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (FKProizvod.SelectedIndex != -1 && FKDobavljac.SelectedIndex != -1)
                {
                    if (dataGridView1.SelectedRows.Count != 0)
                    {
                        Dopremnica d = new Dopremnica() { FK_Proizvod = listaProizvoda[FKProizvod.SelectedIndex], FK_Dobavljac = listaDobavljaca[FKDobavljac.SelectedIndex] };
                        bool check = false;
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                            if (br.UpdateDopremnica(ID, d))
                            {
                                check = true;
                                FKProizvod.SelectedIndex = -1;
                                FKDobavljac.SelectedIndex = -1;
                                br.magacin = br.getData();
                                Prikazi();
                            }
                            else
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check)
                            MessageBox.Show("Uspešno ste ažurirali dopremnice.");
                        else
                            MessageBox.Show("Dopremnice nisu ažurirane.");
                    }
                    else
                        MessageBox.Show("Morate odabrati dopremnice koje treba ažurirati kako bi ažurirali dopremnice!");

                }
                else
                {
                    MessageBox.Show("Morate popuniti sve podatke na ispravan način kako bi ažurirali dopremnice!");
                }
            }
            catch { MessageBox.Show("Podaci nisu ispravno uneti!"); }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (br.magacin.ListaDopremnica.Count <= 0)
                return;
            FKProizvod.SelectedIndex = listaProizvoda.FindIndex(p => p.ID_Proizvoda == listaSelektovanihProizvodID[e.RowIndex]);
            FKDobavljac.SelectedIndex = listaDobavljaca.FindIndex(d => d.ID_Dobavljaca == listaSelektovanihDobavljacID[e.RowIndex]);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (br.magacin.ListaDopremnica.Count <= 0)
                return;
            bool check = false;
            foreach (DataGridViewRow Row in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(Row.Cells[0].Value.ToString());
                if (!br.DeleteDopremnica(id))
                {
                    check = false;
                    break;
                }
                check = true;
            }
            br.magacin = br.getData();
            if (check)
                MessageBox.Show("Uspešno obrisani podaci!");
            else
                MessageBox.Show("Podaci nisu obrisani!");
            Prikazi();
        }
    }
}
