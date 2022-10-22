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
    public partial class PrikazDobavljaca : Form
    {
        private int nacinSortiranja { get; set; }
        private readonly BusinessRepository br;
        public PrikazDobavljaca(BusinessRepository br)
        {
            this.br = br;
            InitializeComponent();
        }



        private void PrikazDobavljaca_Load(object sender, EventArgs e)
        {
            cbNacinSortiranja.SelectedIndex = 0;
            dataGridView1.Columns.Add("ID_Dobavljaca", "ID dobavljača");
            dataGridView1.Columns.Add("Naziv", "Naziv dobavljača");
            dataGridView1.Columns.Add("Adresa", "Adresa dobavljača");
            if (br.magacin.ListaDobavljaca.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaDobavljaca.Count - 1);
            for (int i = 0; i < br.magacin.ListaDobavljaca.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaDobavljaca[i].ID_Dobavljaca;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaDobavljaca[i].Naziv;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaDobavljaca[i].Adresa;
            }
        }

        private void Sort()
        {
            for (int i = 0; i < br.magacin.ListaDobavljaca.Count - 1; i++)
            {
                for (int j = i; j < br.magacin.ListaDobavljaca.Count; j++)
                {
                    if (nacinSortiranja == 0 && br.magacin.ListaDobavljaca[i].Naziv.CompareTo(br.magacin.ListaDobavljaca[j].Naziv) > 0)
                    {
                        Dobavljac pom = br.magacin.ListaDobavljaca[i];
                        br.magacin.ListaDobavljaca[i] = br.magacin.ListaDobavljaca[j];
                        br.magacin.ListaDobavljaca[j] = pom;
                    }
                    else if (nacinSortiranja == 1 && br.magacin.ListaDobavljaca[i].Naziv.CompareTo(br.magacin.ListaDobavljaca[j].Naziv) < 0)
                    {
                        Dobavljac pom = br.magacin.ListaDobavljaca[i];
                        br.magacin.ListaDobavljaca[i] = br.magacin.ListaDobavljaca[j];
                        br.magacin.ListaDobavljaca[j] = pom;
                    }
                    else if (nacinSortiranja == 2 && br.magacin.ListaDobavljaca[i].ID_Dobavljaca < br.magacin.ListaDobavljaca[j].ID_Dobavljaca)
                    {
                        Dobavljac pom = br.magacin.ListaDobavljaca[i];
                        br.magacin.ListaDobavljaca[i] = br.magacin.ListaDobavljaca[j];
                        br.magacin.ListaDobavljaca[j] = pom;
                    }
                    else if (nacinSortiranja == 3 && br.magacin.ListaDobavljaca[i].ID_Dobavljaca > br.magacin.ListaDobavljaca[j].ID_Dobavljaca)
                    {
                        Dobavljac pom = br.magacin.ListaDobavljaca[i];
                        br.magacin.ListaDobavljaca[i] = br.magacin.ListaDobavljaca[j];
                        br.magacin.ListaDobavljaca[j] = pom;
                    }
                }
            }
        }
        private void Prikazi()
        {
            dataGridView1.Rows.Clear();
            if (br.magacin.ListaDobavljaca.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaDobavljaca.Count - 1);
            for (int i = 0; i < br.magacin.ListaDobavljaca.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = br.magacin.ListaDobavljaca[i].ID_Dobavljaca;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaDobavljaca[i].Naziv;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaDobavljaca[i].Adresa;
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
