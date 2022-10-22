using System;
using Data_Layer;
using Data_Layer.Models;
using Business_Layer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SI2021_CoffeeMachineApp
{
    public partial class PrikazKorisnika : Form
    {
        public int nacinSortiranja { get; set; }
        private readonly BusinessRepository br;
        public PrikazKorisnika(BusinessRepository br)
        {
            this.br = br;
            InitializeComponent();
        }

        private void PrikazKorisnika_Load(object sender, EventArgs e)
        {
            cbNacinSortiranja.SelectedIndex = 0;
            dataGridView1.Columns.Add("ID_Korisnika", "ID korisnika");
            dataGridView1.Columns.Add("Username", "Korisničko ime");
            dataGridView1.Columns.Add("Password", "Šifra");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Ime", "Prezime korisnika");
            dataGridView1.Columns.Add("Prezime", "Prezime korisnika");
            dataGridView1.Columns.Add("Telefon", "Telefon korisnika");
            dataGridView1.Columns.Add("Role", "Uloga korisnika");
            if (br.magacin.ListaKorisnika.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaKorisnika.Count - 1);
            for (int i = 0; i < br.magacin.ListaKorisnika.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaKorisnika[i].ID_Korisnika;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaKorisnika[i].Username;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaKorisnika[i].Password;
                dataGridView1.Rows[i].Cells[3].Value = br.magacin.ListaKorisnika[i].Email;
                dataGridView1.Rows[i].Cells[4].Value = br.magacin.ListaKorisnika[i].Ime;
                dataGridView1.Rows[i].Cells[5].Value = br.magacin.ListaKorisnika[i].Prezime;
                dataGridView1.Rows[i].Cells[6].Value = br.magacin.ListaKorisnika[i].Telefon;
                dataGridView1.Rows[i].Cells[7].Value = br.magacin.ListaKorisnika[i].Role;
            }
        }
        private void Sort()
        {
            for (int i = 0; i < br.magacin.ListaKorisnika.Count - 1; i++)
            {
                for (int j = i; j < br.magacin.ListaKorisnika.Count; j++)
                {
                    if (nacinSortiranja == 0 && br.magacin.ListaKorisnika[i].Ime.CompareTo(br.magacin.ListaKorisnika[j].Ime) > 0)
                    {
                        Korisnik pom = br.magacin.ListaKorisnika[i];
                        br.magacin.ListaKorisnika[i] = br.magacin.ListaKorisnika[j];
                        br.magacin.ListaKorisnika[j] = pom;
                    }
                    else if (nacinSortiranja == 1 && br.magacin.ListaKorisnika[i].Ime.CompareTo(br.magacin.ListaKorisnika[j].Ime) < 0)
                    {
                        Korisnik pom = br.magacin.ListaKorisnika[i];
                        pom = br.magacin.ListaKorisnika[i];
                        br.magacin.ListaKorisnika[i] = br.magacin.ListaKorisnika[j];
                        br.magacin.ListaKorisnika[j] = pom;
                    }
                    if (nacinSortiranja == 2 && br.magacin.ListaKorisnika[i].Prezime.CompareTo(br.magacin.ListaKorisnika[j].Prezime) > 0)
                    {
                        Korisnik pom = br.magacin.ListaKorisnika[i];
                        br.magacin.ListaKorisnika[i] = br.magacin.ListaKorisnika[j];
                        br.magacin.ListaKorisnika[j] = pom;
                    }
                    else if (nacinSortiranja == 3 && br.magacin.ListaKorisnika[i].Prezime.CompareTo(br.magacin.ListaKorisnika[j].Prezime) < 0)
                    {
                        Korisnik pom = br.magacin.ListaKorisnika[i];
                        pom = br.magacin.ListaKorisnika[i];
                        br.magacin.ListaKorisnika[i] = br.magacin.ListaKorisnika[j];
                        br.magacin.ListaKorisnika[j] = pom;
                    }
                    else if (nacinSortiranja == 4 && br.magacin.ListaKorisnika[i].ID_Korisnika< br.magacin.ListaKorisnika[j].ID_Korisnika)
                    {
                        Korisnik pom = br.magacin.ListaKorisnika[i];
                        br.magacin.ListaKorisnika[i] = br.magacin.ListaKorisnika[j];
                        br.magacin.ListaKorisnika[j] = pom;
                    }
                    else if (nacinSortiranja == 5 && br.magacin.ListaKorisnika[i].ID_Korisnika > br.magacin.ListaKorisnika[j].ID_Korisnika)
                    {
                        Korisnik pom = br.magacin.ListaKorisnika[i];
                        br.magacin.ListaKorisnika[i] = br.magacin.ListaKorisnika[j];
                        br.magacin.ListaKorisnika[j] = pom;
                    }
                    else if (nacinSortiranja == 6 && br.magacin.ListaKorisnika[i].Role.CompareTo(br.magacin.ListaKorisnika[j].Role) > 0)
                    {
                        Korisnik pom = br.magacin.ListaKorisnika[i];
                        br.magacin.ListaKorisnika[i] = br.magacin.ListaKorisnika[j];
                        br.magacin.ListaKorisnika[j] = pom;
                    }

                }
            }
        }
        private void Prikazi()
        {
            dataGridView1.Rows.Clear();
            if (br.magacin.ListaKorisnika.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaKorisnika.Count - 1);
            for (int i = 0; i < br.magacin.ListaKorisnika.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaKorisnika[i].ID_Korisnika;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaKorisnika[i].Username;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaKorisnika[i].Password;
                dataGridView1.Rows[i].Cells[3].Value = br.magacin.ListaKorisnika[i].Email;
                dataGridView1.Rows[i].Cells[4].Value = br.magacin.ListaKorisnika[i].Ime;
                dataGridView1.Rows[i].Cells[5].Value = br.magacin.ListaKorisnika[i].Prezime;
                dataGridView1.Rows[i].Cells[6].Value = br.magacin.ListaKorisnika[i].Telefon;
                dataGridView1.Rows[i].Cells[7].Value = br.magacin.ListaKorisnika[i].Role;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sort();
            Prikazi();
        }
        private void cbNacinSortiranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            nacinSortiranja = cbNacinSortiranja.SelectedIndex;
        }
    }
}
