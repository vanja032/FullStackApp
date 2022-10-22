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
using System.IO;

namespace SI2021_CoffeeMachineApp
{
    public partial class PrikazProizvoda : Form
    {
        private int nacinSortiranja { get; set; }
        private readonly BusinessRepository br;
        public PrikazProizvoda(BusinessRepository br)
        {
            this.br = br;
            InitializeComponent();
        }

        private void PrikazProizvoda_Load(object sender, EventArgs e)
        {
            cbNacinSortiranja.SelectedIndex = 0;
            DataGridViewImageColumn kolona = new DataGridViewImageColumn();
            kolona.HeaderText = "Slika proizvoda";
            kolona.ImageLayout = DataGridViewImageCellLayout.Zoom;
            kolona.Name = "Slika_Proizvoda";
            dataGridView1.Columns.Insert(0, kolona);
            dataGridView1.Columns.Add("ID_Proizvoda", "ID proizvoda");
            dataGridView1.Columns.Add("Naziv", "Naziv proizvoda");
            dataGridView1.Columns.Add("Cena", "Cena proizvoda");
            dataGridView1.Columns.Add("Opis", "Opis proizvoda");
            dataGridView1.Columns.Add("FK_ID_Proizvodjaca", "Proizvođač");
            if (br.magacin.ListaProizvoda.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaProizvoda.Count - 1);
            for (int i = 0; i < br.magacin.ListaProizvoda.Count; i++)
            {
                dataGridView1.Rows[i].Height = 50;
                Bitmap pb = new Bitmap(br.magacin.ListaProizvoda[i].Slika_Proizvoda);
                Image slika = Image.FromHbitmap(pb.GetHbitmap());
                ((DataGridViewImageCell)dataGridView1.Rows[i].Cells[0]).Value = slika;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaProizvoda[i].ID_Proizvoda;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaProizvoda[i].Naziv;
                dataGridView1.Rows[i].Cells[3].Value = br.magacin.ListaProizvoda[i].Cena;
                dataGridView1.Rows[i].Cells[4].Value = br.magacin.ListaProizvoda[i].Opis;
                dataGridView1.Rows[i].Cells[5].Value = br.magacin.ListaProizvoda[i].FK_Proizvodjac.Naziv;
                pb.Dispose();
            }
        }
        private void Sort()
        {
            for(int i=0;i<br.magacin.ListaProizvoda.Count-1;i++)
            {
                for (int j = i; j < br.magacin.ListaProizvoda.Count; j++)
                {
                    if(nacinSortiranja==0 && br.magacin.ListaProizvoda[i].Naziv.CompareTo(br.magacin.ListaProizvoda[j].Naziv)>0)
                    {
                        Proizvod pom = br.magacin.ListaProizvoda[i];
                        br.magacin.ListaProizvoda[i]= br.magacin.ListaProizvoda[j];
                        br.magacin.ListaProizvoda[j] = pom;
                    }
                    else if (nacinSortiranja == 1 && br.magacin.ListaProizvoda[i].Naziv.CompareTo(br.magacin.ListaProizvoda[j].Naziv) < 0)
                    {
                        Proizvod pom = br.magacin.ListaProizvoda[i];
                        br.magacin.ListaProizvoda[i] = br.magacin.ListaProizvoda[j];
                        br.magacin.ListaProizvoda[j] = pom;
                    }
                    else if (nacinSortiranja == 2 && br.magacin.ListaProizvoda[i].Cena > br.magacin.ListaProizvoda[j].Cena)
                    {
                        Proizvod pom = br.magacin.ListaProizvoda[i];
                        br.magacin.ListaProizvoda[i] = br.magacin.ListaProizvoda[j];
                        br.magacin.ListaProizvoda[j] = pom;
                    }
                    else if (nacinSortiranja == 3 && br.magacin.ListaProizvoda[i].Cena < br.magacin.ListaProizvoda[j].Cena)
                    {
                        Proizvod pom = br.magacin.ListaProizvoda[i];
                        br.magacin.ListaProizvoda[i] = br.magacin.ListaProizvoda[j];
                        br.magacin.ListaProizvoda[j] = pom;
                    }
                    else if (nacinSortiranja == 4 && br.magacin.ListaProizvoda[i].ID_Proizvoda < br.magacin.ListaProizvoda[j].ID_Proizvoda)
                    {
                        Proizvod pom = br.magacin.ListaProizvoda[i];
                        br.magacin.ListaProizvoda[i] = br.magacin.ListaProizvoda[j];
                        br.magacin.ListaProizvoda[j] = pom;
                    }
                    else if (nacinSortiranja == 5 && br.magacin.ListaProizvoda[i].ID_Proizvoda > br.magacin.ListaProizvoda[j].ID_Proizvoda)
                    {
                        Proizvod pom = br.magacin.ListaProizvoda[i];
                        br.magacin.ListaProizvoda[i] = br.magacin.ListaProizvoda[j];
                        br.magacin.ListaProizvoda[j] = pom;
                    }
                    else if (nacinSortiranja == 6 && br.magacin.ListaProizvoda[i].FK_Proizvodjac.Naziv.CompareTo(br.magacin.ListaProizvoda[j].FK_Proizvodjac.Naziv) < 0)
                    {
                        Proizvod pom = br.magacin.ListaProizvoda[i];
                        br.magacin.ListaProizvoda[i] = br.magacin.ListaProizvoda[j];
                        br.magacin.ListaProizvoda[j] = pom;
                    }
                    else if (nacinSortiranja == 7 && br.magacin.ListaProizvoda[i].FK_Proizvodjac.Naziv.CompareTo(br.magacin.ListaProizvoda[j].FK_Proizvodjac.Naziv) < 0)
                    {
                        Proizvod pom = br.magacin.ListaProizvoda[i];
                        br.magacin.ListaProizvoda[i] = br.magacin.ListaProizvoda[j];
                        br.magacin.ListaProizvoda[j] = pom;
                    }

                }
            }
        }
        private void Prikazi()
        {
            dataGridView1.Rows.Clear();
            if (br.magacin.ListaProizvoda.Count > 1)
                dataGridView1.Rows.Add(br.magacin.ListaProizvoda.Count - 1);
            for (int i = 0; i < br.magacin.ListaProizvoda.Count; i++)
            {
                dataGridView1.Rows[i].Height = 50;
                Bitmap pb = new Bitmap(br.magacin.ListaProizvoda[i].Slika_Proizvoda);
                Image slika = Image.FromHbitmap(pb.GetHbitmap());
                ((DataGridViewImageCell)dataGridView1.Rows[i].Cells[0]).Value = slika;
                dataGridView1.Rows[i].Cells[1].Value = br.magacin.ListaProizvoda[i].ID_Proizvoda;
                dataGridView1.Rows[i].Cells[2].Value = br.magacin.ListaProizvoda[i].Naziv;
                dataGridView1.Rows[i].Cells[3].Value = br.magacin.ListaProizvoda[i].Cena;
                dataGridView1.Rows[i].Cells[4].Value = br.magacin.ListaProizvoda[i].Opis;
                dataGridView1.Rows[i].Cells[5].Value = br.magacin.ListaProizvoda[i].FK_Proizvodjac.Naziv;
                pb.Dispose();
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
