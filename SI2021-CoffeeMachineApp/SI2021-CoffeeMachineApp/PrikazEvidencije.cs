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
    public partial class PrikazEvidencije : Form
    {
        private int nacinSortiranja { get; set; }
        private readonly BusinessRepository br;
        public PrikazEvidencije(BusinessRepository br)
        {
            this.br = br;
            InitializeComponent();
        }
        private void PrikazEvidencije_Load(object sender, EventArgs e)
        {
            cbNacinSortiranja.SelectedIndex = 0;
            dataGridView1.Columns.Add("Opis", "Opis");
            dataGridView1.Columns.Add("Napomena", "Napomena");
            dataGridView1.Columns.Add("FK_ID_Narudzbine", "ID narudžbine");
            dataGridView1.Columns.Add("FK_ID_Proizvoda", "Naziv proizvoda");
            if (br.magacin.ListaEvidencija.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaEvidencija.Count - 1);
            for (int i = 0; i < br.magacin.ListaEvidencija.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaEvidencija[i].Opis;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaEvidencija[i].Napomena;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaEvidencija[i].FK_Narudzbina.ID_Narudzbine;
                dataGridView1.Rows[i].Cells[3].Value = br.magacin.ListaEvidencija[i].FK_Proizvod.Naziv;
            }
        }
        private void Sort()
        {
            for (int i = 0; i < br.magacin.ListaEvidencija.Count - 1; i++)
            {
                for (int j = i; j < br.magacin.ListaEvidencija.Count; j++)
                {
                    if (nacinSortiranja == 0 && br.magacin.ListaEvidencija[i].FK_Narudzbina.ID_Narudzbine.CompareTo(br.magacin.ListaEvidencija[j].FK_Narudzbina.ID_Narudzbine) > 0)
                    {
                        Evidencija pom = br.magacin.ListaEvidencija[i];
                        br.magacin.ListaEvidencija[i] = br.magacin.ListaEvidencija[j];
                        br.magacin.ListaEvidencija[j] = pom;
                    }
                    else if (nacinSortiranja == 0 && br.magacin.ListaEvidencija[i].FK_Narudzbina.ID_Narudzbine.CompareTo(br.magacin.ListaEvidencija[j].FK_Narudzbina.ID_Narudzbine) < 0)
                    {
                        Evidencija pom = br.magacin.ListaEvidencija[i];
                        br.magacin.ListaEvidencija[i] = br.magacin.ListaEvidencija[j];
                        br.magacin.ListaEvidencija[j] = pom;
                    }
                    else if (nacinSortiranja == 2 && br.magacin.ListaEvidencija[i].FK_Proizvod.Naziv.CompareTo(br.magacin.ListaEvidencija[j].FK_Proizvod.Naziv) < 0)
                    {
                        Evidencija pom = br.magacin.ListaEvidencija[i];
                        br.magacin.ListaEvidencija[i] = br.magacin.ListaEvidencija[j];
                        br.magacin.ListaEvidencija[j] = pom;
                    }
                    else if (nacinSortiranja == 3 && br.magacin.ListaEvidencija[i].FK_Proizvod.Naziv.CompareTo(br.magacin.ListaEvidencija[j].FK_Proizvod.Naziv) < 0)
                    {
                        Evidencija pom = br.magacin.ListaEvidencija[i];
                        br.magacin.ListaEvidencija[i] = br.magacin.ListaEvidencija[j];
                        br.magacin.ListaEvidencija[j] = pom;
                    }
                }
            }
        }
        private void Prikazi()
        {
            dataGridView1.Rows.Clear();
            if (br.magacin.ListaEvidencija.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaEvidencija.Count - 1);
            for (int i = 0; i < br.magacin.ListaEvidencija.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaEvidencija[i].Opis;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaEvidencija[i].Napomena;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaEvidencija[i].FK_Narudzbina.ID_Narudzbine;
                dataGridView1.Rows[i].Cells[3].Value = br.magacin.ListaEvidencija[i].FK_Proizvod.Naziv;
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
