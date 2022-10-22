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
    public partial class UpisKorisnika : Form
    {
        private readonly BusinessRepository br;
        private int nacinSortiranja { get; set; }
        public UpisKorisnika(BusinessRepository br)
        {
            this.br = br;
            InitializeComponent();
        }

        private void UpisKorisnika_Load(object sender, EventArgs e)
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
                    else if (nacinSortiranja == 4 && br.magacin.ListaKorisnika[i].ID_Korisnika < br.magacin.ListaKorisnika[j].ID_Korisnika)
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
                if (username.Text != "" && password.Text != "" && email.Text != "" && ime.Text != "" && prezime.Text != "" && telefon.Text != "" && role.SelectedIndex != -1)
                {
                    Korisnik k = new Korisnik() { Username = username.Text, Password = password.Text, Email = email.Text, Ime=ime.Text, Prezime = prezime.Text, Telefon = telefon.Text, Role = role.SelectedItem.ToString() };
                    if (br.InsertKorisnik(k))
                    {
                        MessageBox.Show("Uspešno ste uneli korisnika.");
                        username.Text = "";
                        password.Text = "";
                        email.Text = "";
                        ime.Text = "";
                        prezime.Text = "";
                        telefon.Text = "";
                        role.SelectedIndex = -1;
                        br.magacin = br.getData();
                        Prikazi();
                    }
                    else
                        MessageBox.Show("Korisnik nije unet.");
                }
                else
                {
                    MessageBox.Show("Morate popuniti sve podatke na ispravan način kako bi uneli korisnika!");
                }
            }
            catch { MessageBox.Show("Podaci nisu ispravno uneti!"); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text != "" && password.Text != "" && email.Text != "" && ime.Text != "" && prezime.Text != "" && telefon.Text != "" && role.SelectedIndex != -1)
                {
                    if (dataGridView1.SelectedRows.Count != 0)
                    {
                        Korisnik k = new Korisnik() { Username = username.Text, Password = password.Text, Email = email.Text, Ime = ime.Text, Prezime = prezime.Text, Telefon = telefon.Text, Role = role.SelectedItem.ToString() };
                        bool check = false;
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                            if (br.UpdateKorisnik(ID, k))
                            {
                                check = true;
                                username.Text = "";
                                password.Text = "";
                                email.Text = "";
                                ime.Text = "";
                                prezime.Text = "";
                                telefon.Text = "";
                                role.SelectedIndex = -1;
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
                            MessageBox.Show("Uspešno ste ažurirali korisnike.");
                        else
                            MessageBox.Show("Korisnici nisu ažurirani.");
                    }
                    else
                        MessageBox.Show("Morate odabrati korisnike koje treba ažurirati kako bi ažurirali korisnike!");

                }
                else
                {
                    MessageBox.Show("Morate popuniti sve podatke na ispravan način kako bi ažurirali korisnike!");
                }
            }
            catch { MessageBox.Show("Podaci nisu ispravno uneti!"); }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (br.magacin.ListaKorisnika.Count <= 0)
                return;
            username.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            password.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            email.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            ime.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            prezime.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            telefon.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            role.SelectedIndex = role.FindString(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (br.magacin.ListaKorisnika.Count <= 0)
                return;
            bool check = false;
            foreach (DataGridViewRow Row in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(Row.Cells[0].Value.ToString());
                if (!br.DeleteKorisnik(id))
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
