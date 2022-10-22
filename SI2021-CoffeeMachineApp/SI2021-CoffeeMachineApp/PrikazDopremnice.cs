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
    public partial class PrikazDopremnice : Form
    {
        public int nacinSortiranja { get; set; }
        private readonly BusinessRepository br;
        public PrikazDopremnice(BusinessRepository br)
        {
            this.br = br;
            InitializeComponent();
        }

        private void PrikazDopremnice_Load(object sender, EventArgs e)
        {
            cbNacinSortiranja.SelectedIndex = 0;
            dataGridView1.Columns.Add("ID_Dopremnice", "ID dopremnice");
            dataGridView1.Columns.Add("FK_ID_Proizvoda", "Naziv proizvoda");
            dataGridView1.Columns.Add("FK_ID_Dobavljaca", "Naziv dobavljača");
            if (br.magacin.ListaDopremnica.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaDopremnica.Count-1);
            for (int i = 0; i < br.magacin.ListaDopremnica.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaDopremnica[i].ID_Dopremnice;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaDopremnica[i].FK_Proizvod.Naziv;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaDopremnica[i].FK_Dobavljac.Naziv;
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
            for (int i = 0; i < br.magacin.ListaDopremnica.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaDopremnica[i].ID_Dopremnice;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaDopremnica[i].FK_Proizvod.Naziv;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaDopremnica[i].FK_Dobavljac.Naziv;
            }
        }

        private void cbNacinSortiranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            nacinSortiranja = cbNacinSortiranja.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sort();
            Prikazi();
        }
    }
}
