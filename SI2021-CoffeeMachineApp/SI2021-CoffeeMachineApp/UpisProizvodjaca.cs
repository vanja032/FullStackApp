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
    public partial class UpisProizvodjaca : Form
    {
        private readonly BusinessRepository br;
        private int nacinSortiranja { get; set; }
        public UpisProizvodjaca(BusinessRepository br)
        {
            this.br = br;
            InitializeComponent();
        }

        private void UpisProizvodjaca_Load(object sender, EventArgs e)
        {
            cbNacinSortiranja.SelectedIndex = 0;
            dataGridView1.Columns.Add("ID_Proizvodjaca", "ID proizvođača");
            dataGridView1.Columns.Add("Naziv", "Naziv proizvođača");
            dataGridView1.Columns.Add("Drzava", "Država u kojoj je proizvođač");
            dataGridView1.Columns.Add("Adresa", "Adresa proizvođača");
            dataGridView1.Columns.Add("Opis", "Opis proizvođača");
            if (br.magacin.ListaProizvodjaca.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaProizvodjaca.Count - 1);
            for (int i = 0; i < br.magacin.ListaProizvodjaca.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaProizvodjaca[i].ID_Proizvodjaca;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaProizvodjaca[i].Naziv;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaProizvodjaca[i].Drzava;
                dataGridView1.Rows[i].Cells[3].Value = br.magacin.ListaProizvodjaca[i].Adresa;
                dataGridView1.Rows[i].Cells[4].Value = br.magacin.ListaProizvodjaca[i].Opis;
            }
        }
        private void Sort()
        {
            for (int i = 0; i < br.magacin.ListaProizvodjaca.Count - 1; i++)
            {
                for (int j = i; j < br.magacin.ListaProizvodjaca.Count; j++)
                {
                    if (nacinSortiranja == 0 && br.magacin.ListaProizvodjaca[i].Naziv.CompareTo(br.magacin.ListaProizvodjaca[j].Naziv) > 0)
                    {
                        Proizvodjac pom = br.magacin.ListaProizvodjaca[i];
                        br.magacin.ListaProizvodjaca[i] = br.magacin.ListaProizvodjaca[j];
                        br.magacin.ListaProizvodjaca[j] = pom;
                    }
                    else if (nacinSortiranja == 1 && br.magacin.ListaProizvodjaca[i].Naziv.CompareTo(br.magacin.ListaProizvodjaca[j].Naziv) < 0)
                    {
                        Proizvodjac pom = br.magacin.ListaProizvodjaca[i];
                        br.magacin.ListaProizvodjaca[i] = br.magacin.ListaProizvodjaca[j];
                        br.magacin.ListaProizvodjaca[j] = pom;
                    }
                    else if (nacinSortiranja == 2 && br.magacin.ListaProizvodjaca[i].ID_Proizvodjaca < br.magacin.ListaProizvodjaca[j].ID_Proizvodjaca)
                    {
                        Proizvodjac pom = br.magacin.ListaProizvodjaca[i];
                        br.magacin.ListaProizvodjaca[i] = br.magacin.ListaProizvodjaca[j];
                        br.magacin.ListaProizvodjaca[j] = pom;
                    }
                    else if (nacinSortiranja == 3 && br.magacin.ListaProizvodjaca[i].ID_Proizvodjaca > br.magacin.ListaProizvodjaca[j].ID_Proizvodjaca)
                    {
                        Proizvodjac pom = br.magacin.ListaProizvodjaca[i];
                        br.magacin.ListaProizvodjaca[i] = br.magacin.ListaProizvodjaca[j];
                        br.magacin.ListaProizvodjaca[j] = pom;
                    }
                }
            }
        }
        private void Prikazi()
        {
            dataGridView1.Rows.Clear();
            if (br.magacin.ListaProizvodjaca.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaProizvodjaca.Count - 1);
            for (int i = 0; i < br.magacin.ListaProizvodjaca.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaProizvodjaca[i].ID_Proizvodjaca;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaProizvodjaca[i].Naziv;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaProizvodjaca[i].Drzava;
                dataGridView1.Rows[i].Cells[3].Value = br.magacin.ListaProizvodjaca[i].Adresa;
                dataGridView1.Rows[i].Cells[4].Value = br.magacin.ListaProizvodjaca[i].Opis;
            }
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            Sort();
            Prikazi();
        }

        private void cbNacinSortiranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            nacinSortiranja = cbNacinSortiranja.SelectedIndex;
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            try { 
            if (naziv.Text != "" && drzava.Text != "" && adresa.Text != "" && opis.Text != "")
            {
                Proizvodjac p = new Proizvodjac() { Naziv = naziv.Text, Drzava = drzava.Text, Adresa = adresa.Text, Opis = opis.Text };
                if (br.InsertProizvodjac(p))
                {
                    MessageBox.Show("Uspešno ste uneli proizvođača.");
                    naziv.Text = "";
                    drzava.Text = "";
                    adresa.Text = "";
                    opis.Text = "";
                    br.magacin = br.getData();
                    Prikazi();
                }
                else
                    MessageBox.Show("Proizvođač nije unet.");
            }
            else
            {
                MessageBox.Show("Morate popuniti sve podatke na ispravan način kako bi uneli proizvođača!");
            }
            }
            catch { MessageBox.Show("Podaci nisu ispravno uneti!"); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (naziv.Text != "" && drzava.Text != "" && adresa.Text != "" && opis.Text != "")
                {
                    if (dataGridView1.SelectedRows.Count != 0)
                    {
                        Proizvodjac p = new Proizvodjac() { Naziv = naziv.Text, Drzava = drzava.Text, Adresa = adresa.Text, Opis = opis.Text };
                        bool check = false;
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                            if (br.UpdateProizvodjac(ID, p))
                            {
                                check = true;
                                naziv.Text = "";
                                drzava.Text = "";
                                adresa.Text = "";
                                opis.Text = "";
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
                            MessageBox.Show("Uspešno ste ažurirali proizvođače.");
                        else
                            MessageBox.Show("Proizvođači nisu ažurirani.");
                    }
                    else
                        MessageBox.Show("Morate odabrati proizvođače koje treba ažurirati kako bi ažurirali proizvođače!");

                }
                else
                {
                    MessageBox.Show("Morate popuniti sve podatke na ispravan način kako bi ažurirali proizvođače!");
                }
            }
            catch { MessageBox.Show("Podaci nisu ispravno uneti!"); }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (br.magacin.ListaProizvodjaca.Count <= 0)
                return;
            naziv.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            drzava.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            adresa.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            opis.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (br.magacin.ListaProizvodjaca.Count <= 0)
                return;
            bool check = false;
            foreach (DataGridViewRow Row in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(Row.Cells[0].Value.ToString());
                if (!br.DeleteProizvodjac(id))
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
