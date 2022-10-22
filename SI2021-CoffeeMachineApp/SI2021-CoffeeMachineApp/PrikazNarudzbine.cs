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
    public partial class PrikazNarudzbine : Form
    {
        private int nacinSortiranja { get; set; }
        private readonly BusinessRepository br;
        public PrikazNarudzbine(BusinessRepository br)
        {
            this.br = br;
            InitializeComponent();
        }
        private void PrikazNarudzbine_Load(object sender, EventArgs e)
        {
            cbNacinSortiranja.SelectedIndex = 0;
            dataGridView1.Columns.Add("ID_Narudzbine", "ID narudzbine");
            dataGridView1.Columns.Add("Napomena", "Napomenat");
            dataGridView1.Columns.Add("Opis", "Opis");
            dataGridView1.Columns.Add("Datum", "Datum");
            if (br.magacin.ListaNarudzbina.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaNarudzbina.Count - 1);
            for (int i = 0; i < br.magacin.ListaNarudzbina.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaNarudzbina[i].ID_Narudzbine;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaNarudzbina[i].Napomena;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaNarudzbina[i].Opis;
                dataGridView1.Rows[i].Cells[3].Value = br.magacin.ListaNarudzbina[i].Datum;
            }
        }
        private void Sort()
        {
            for (int i = 0; i < br.magacin.ListaNarudzbina.Count - 1; i++)
            {
                for (int j = i; j < br.magacin.ListaNarudzbina.Count; j++)
                { 
                    if (nacinSortiranja == 0 && br.magacin.ListaNarudzbina[i].ID_Narudzbine < br.magacin.ListaNarudzbina[j].ID_Narudzbine)
                    {
                        Narudzbina pom = br.magacin.ListaNarudzbina[i];
                        br.magacin.ListaNarudzbina[i] = br.magacin.ListaNarudzbina[j];
                        br.magacin.ListaNarudzbina[j] = pom;
                    }
                    else if (nacinSortiranja == 1 && br.magacin.ListaNarudzbina[i].ID_Narudzbine > br.magacin.ListaNarudzbina[j].ID_Narudzbine)
                    {
                        Narudzbina pom = br.magacin.ListaNarudzbina[i];
                        br.magacin.ListaNarudzbina[i] = br.magacin.ListaNarudzbina[j];
                        br.magacin.ListaNarudzbina[j] = pom;
                    }
                }
            }
        }
        private void Prikazi()
        {
            dataGridView1.Rows.Clear();
            if (br.magacin.ListaNarudzbina.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaNarudzbina.Count - 1);
            for (int i = 0; i < br.magacin.ListaNarudzbina.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaNarudzbina[i].ID_Narudzbine;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaNarudzbina[i].Napomena;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaNarudzbina[i].Opis;
                dataGridView1.Rows[i].Cells[3].Value = br.magacin.ListaNarudzbina[i].Datum;
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
