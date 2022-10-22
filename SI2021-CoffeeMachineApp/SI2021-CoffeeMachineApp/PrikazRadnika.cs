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
    public partial class PrikazRadnika : Form
    {
        private int nacinSortiranja { get; set; }
        private readonly BusinessRepository br;
        public PrikazRadnika(BusinessRepository br)
        {
            this.br = br;
            InitializeComponent();
        }
        private void PrikazRadnika_Load(object sender, EventArgs e)
        {
            cbNacinSortiranja.SelectedIndex = 0;
            dataGridView1.Columns.Add("ID_Radnika", "ID radnika");
            dataGridView1.Columns.Add("Ime", "Ime radnika");
            dataGridView1.Columns.Add("Prezime", "Prezime radnika");
            dataGridView1.Columns.Add("Telefon", "Telefon radnika");
            dataGridView1.Columns.Add("JMBG", "JMBG radnika");
            dataGridView1.Columns.Add("Email", "Email radnika");
            dataGridView1.Columns.Add("FK_ID_Rukovodioca", "Ime rukovodioca");
            dataGridView1.Columns.Add("Username", "Username");
            dataGridView1.Columns.Add("Password", "Password");
            if (br.magacin.ListaRadnika.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaRadnika.Count - 1);
            for (int i = 0; i < br.magacin.ListaRadnika.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaRadnika[i].ID_Radnika;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaRadnika[i].Ime;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaRadnika[i].Prezime;
                dataGridView1.Rows[i].Cells[3].Value = br.magacin.ListaRadnika[i].Telefon;
                dataGridView1.Rows[i].Cells[4].Value = br.magacin.ListaRadnika[i].JMBG;
                dataGridView1.Rows[i].Cells[5].Value = br.magacin.ListaRadnika[i].Email;
                dataGridView1.Rows[i].Cells[6].Value = br.magacin.ListaRadnika[i].FK_Rukovodilac.Ime;
                dataGridView1.Rows[i].Cells[7].Value = br.magacin.ListaRadnika[i].Username;
                dataGridView1.Rows[i].Cells[8].Value = br.magacin.ListaRadnika[i].Password;
            }
        }

        private void Sort()
        {
            for (int i = 0; i < br.magacin.ListaRadnika.Count - 1; i++)
            {
                for (int j = i; j < br.magacin.ListaRadnika.Count; j++)
                {
                    if (nacinSortiranja == 0 && br.magacin.ListaRadnika[i].Ime.CompareTo(br.magacin.ListaRadnika[j].Ime) > 0)
                    {
                        Radnik pom = br.magacin.ListaRadnika[i];
                        br.magacin.ListaRadnika[i] = br.magacin.ListaRadnika[j];
                        br.magacin.ListaRadnika[j] = pom;
                    }
                    else if (nacinSortiranja == 1 && br.magacin.ListaRadnika[i].Ime.CompareTo(br.magacin.ListaRadnika[j].Ime) < 0)
                    {
                        Radnik pom = br.magacin.ListaRadnika[i];
                        pom = br.magacin.ListaRadnika[i];
                        br.magacin.ListaRadnika[i] = br.magacin.ListaRadnika[j];
                        br.magacin.ListaRadnika[j] = pom;
                    }
                    if (nacinSortiranja == 2 && br.magacin.ListaRadnika[i].Prezime.CompareTo(br.magacin.ListaRadnika[j].Prezime) > 0)
                    {
                        Radnik pom = br.magacin.ListaRadnika[i];
                        br.magacin.ListaRadnika[i] = br.magacin.ListaRadnika[j];
                        br.magacin.ListaRadnika[j] = pom;
                    }
                    else if (nacinSortiranja == 3 && br.magacin.ListaRadnika[i].Prezime.CompareTo(br.magacin.ListaRadnika[j].Prezime) < 0)
                    {
                        Radnik pom = br.magacin.ListaRadnika[i];
                        pom = br.magacin.ListaRadnika[i];
                        br.magacin.ListaRadnika[i] = br.magacin.ListaRadnika[j];
                        br.magacin.ListaRadnika[j] = pom;
                    }
                    else if (nacinSortiranja == 4 && br.magacin.ListaRadnika[i].ID_Radnika < br.magacin.ListaRadnika[j].ID_Radnika)
                    {
                        Radnik pom = br.magacin.ListaRadnika[i];
                        br.magacin.ListaRadnika[i] = br.magacin.ListaRadnika[j];
                        br.magacin.ListaRadnika[j] = pom;
                    }
                    else if (nacinSortiranja == 5 && br.magacin.ListaRadnika[i].ID_Radnika > br.magacin.ListaRadnika[j].ID_Radnika)
                    {
                        Radnik pom = br.magacin.ListaRadnika[i];
                        br.magacin.ListaRadnika[i] = br.magacin.ListaRadnika[j];
                        br.magacin.ListaRadnika[j] = pom;
                    }

                }
            }
        }
        private void Prikazi()
        {
            dataGridView1.Rows.Clear();
            if (br.magacin.ListaRadnika.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaRadnika.Count - 1);
            for (int i = 0; i < br.magacin.ListaRadnika.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaRadnika[i].ID_Radnika;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaRadnika[i].Ime;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaRadnika[i].Prezime;
                dataGridView1.Rows[i].Cells[3].Value = br.magacin.ListaRadnika[i].Telefon;
                dataGridView1.Rows[i].Cells[4].Value = br.magacin.ListaRadnika[i].JMBG;
                dataGridView1.Rows[i].Cells[5].Value = br.magacin.ListaRadnika[i].Email;
                dataGridView1.Rows[i].Cells[6].Value = br.magacin.ListaRadnika[i].FK_Rukovodilac.Ime;
                dataGridView1.Rows[i].Cells[7].Value = br.magacin.ListaRadnika[i].Username;
                dataGridView1.Rows[i].Cells[8].Value = br.magacin.ListaRadnika[i].Password;
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
