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
    public partial class UpisNarudzbina : Form
    {
        private int nacinSortiranja { get; set; }
        private readonly BusinessRepository br;
        public UpisNarudzbina(BusinessRepository br)
        {
            this.br = br;
            InitializeComponent();
        }

        private void UpisNarudzbina_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
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

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            Sort();
            Prikazi();
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (napomena.Text != "" && opis.Text != "" && dateTimePicker1.Value != null)
                {
                    Narudzbina n = new Narudzbina() { Napomena = napomena.Text, Opis = opis.Text, Datum = dateTimePicker1.Value };
                    if (br.InsertNarudzbina(n))
                    {
                        MessageBox.Show("Uspešno ste uneli narudžbinu.");
                        napomena.Text = "";
                        opis.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        br.magacin = br.getData();
                        Prikazi();
                    }
                    else
                        MessageBox.Show("Narudžbina nije uneta.");
                }
                else
                {
                    MessageBox.Show("Morate popuniti sve podatke na ispravan način kako bi uneli narudžbinu!");
                }
            }
            catch { MessageBox.Show("Podaci nisu ispravno uneti!"); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (napomena.Text != "" && opis.Text != "" && dateTimePicker1.Value != null)
                {
                    if (dataGridView1.SelectedRows.Count != 0)
                    {
                        Narudzbina n = new Narudzbina() { Napomena = napomena.Text, Opis = opis.Text, Datum = dateTimePicker1.Value };
                        bool check = false;
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                            if (br.UpdateNarudzbina(ID, n))
                            {
                                check = true;
                                napomena.Text = "";
                                opis.Text = "";
                                dateTimePicker1.Value = DateTime.Now;
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
                            MessageBox.Show("Uspešno ste ažurirali narudžbine.");
                        else
                            MessageBox.Show("Narudžbine nisu ažurirane.");
                    }
                    else
                        MessageBox.Show("Morate odabrati narudžbine koje treba ažurirati kako bi ažurirali narudžbine!");

                }
                else
                {
                    MessageBox.Show("Morate popuniti sve podatke na ispravan način kako bi ažurirali narudžbine!");
                }
            }
            catch { MessageBox.Show("Podaci nisu ispravno uneti!"); }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (br.magacin.ListaNarudzbina.Count <= 0)
                return;
            napomena.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            opis.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (br.magacin.ListaNarudzbina.Count <= 0)
                return;
            bool check = false;
            foreach (DataGridViewRow Row in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(Row.Cells[0].Value.ToString());
                if (!br.DeleteNarudzbina(id))
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
