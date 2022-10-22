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
    public partial class PrikazProizvodjaca : Form
    {
        private int nacinSortiranja { get; set; }
        private readonly BusinessRepository br;
        public PrikazProizvodjaca(BusinessRepository br)
        {
            this.br = br;
            InitializeComponent();
        }


        private void PrikazProizvodjaca_Load(object sender, EventArgs e)
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
