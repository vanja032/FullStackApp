using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Layer;
using Data_Layer.Models;
using Business_Layer;
using Business_Layer.Interfaces;
using System.Collections;

namespace MagacinWebApp
{
    public partial class SiteMaster : MasterPage
    {
        private readonly BusinessRepository br = new BusinessRepository(new MagacinRepository());
        private List<Proizvod> proizvodiZaKupovinu = new List<Proizvod>();
        protected void Page_Load(object sender, EventArgs e)
        {
            br.getData();
            ArrayList arrList = new ArrayList();
            foreach (Proizvod proizvod in br.magacin.ListaProizvoda)
            {
                string p = proizvod.Naziv + " " + proizvod.Opis + " " + proizvod.Cena;
                ListItem li = new ListItem();
                li.Value = br.magacin.ListaProizvoda.FindIndex(pr=>pr.ID_Proizvoda == proizvod.ID_Proizvoda).ToString();
                li.Text = p;
                ListBox1.Items.Add(li);
            }
            if (Session["val"] != null)
                proizvodiZaKupovinu = (List<Proizvod>)Session["val"];
            else
                proizvodiZaKupovinu = new List<Proizvod>();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pretraga = TextBox1.Text;
            ListBox1.Items.Clear();
            foreach (Proizvod proizvod in br.magacin.ListaProizvoda)
            {
                if ((proizvod.Naziv + " " + proizvod.Opis).ToLower().Contains(pretraga.ToLower()))
                {
                    string p = proizvod.Naziv + " " + proizvod.Opis + " " + proizvod.Cena;
                    ListItem li = new ListItem();
                    li.Value = br.magacin.ListaProizvoda.FindIndex(pr => pr.ID_Proizvoda == proizvod.ID_Proizvoda).ToString();
                    li.Text = p;
                    ListBox1.Items.Add(li);
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            if (ListBox1.SelectedIndex != -1)
            {
                string item = ListBox1.SelectedItem.ToString();
                double cena = 0;
                ListBox2.Items.Add(item);

                proizvodiZaKupovinu.Add(br.magacin.ListaProizvoda[Convert.ToInt32(ListBox1.SelectedValue)]);
                
                Session["val"] = proizvodiZaKupovinu;

                for (int i = 0; i < ListBox2.Items.Count; i++)
                {
                    cena += Convert.ToDouble(ListBox2.Items[i].ToString().Split(' ').Last());
                }
                Label1.Text = "Ukupno " + cena + " Dinara";
            }
            ListBox1.Items.Clear();
            foreach (Proizvod proizvod in br.magacin.ListaProizvoda)
            {
                string p = proizvod.Naziv + " " + proizvod.Opis + " " + proizvod.Cena;
                ListItem li = new ListItem();
                li.Value = br.magacin.ListaProizvoda.FindIndex(pr => pr.ID_Proizvoda == proizvod.ID_Proizvoda).ToString();
                li.Text = p;
                ListBox1.Items.Add(li);
            }
            ListBox1.SelectedIndex = -1;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double cena = 0;
            ListBox1.Items.Clear();
            foreach (Proizvod proizvod in br.magacin.ListaProizvoda)
            {
                string p = proizvod.Naziv + " " + proizvod.Opis + " " + proizvod.Cena;
                ListItem li = new ListItem();
                li.Value = br.magacin.ListaProizvoda.FindIndex(pr => pr.ID_Proizvoda == proizvod.ID_Proizvoda).ToString();
                li.Text = p;
                ListBox1.Items.Add(li);
            }
            if (ListBox2.SelectedIndex != -1)
            {
                int item = ListBox1.SelectedIndex + 1;
                
                ListBox2.Items.RemoveAt(item);

                for (int i = 0; i < ListBox2.Items.Count; i++)
                {
                    cena += Convert.ToDouble(ListBox2.Items[i].ToString().Split(' ').Last());
                }
                Label1.Text = cena.ToString();
            }
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Narudzbina n = new Narudzbina() { Opis = "Narudžbina datuma " + DateTime.Now, Datum = DateTime.Now, Napomena = "Napomena" };
            br.InsertNarudzbina(n);
            br.getData();
            n = br.magacin.ListaNarudzbina.Last();
            proizvodiZaKupovinu.Distinct();
            foreach (Proizvod p in proizvodiZaKupovinu)
            {
                br.InsertEvidencija(new Evidencija() { FK_Proizvod = p, FK_Narudzbina = n, Opis = "Evidencija za narudžbinu " + n.Opis + " i proizvod " + p.Naziv, Napomena = "Napomena" });
            }
            Session["val"] = null;
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();
            TextBox1.Text = "";
            Label1.Text = "0";
            foreach (Proizvod proizvod in br.magacin.ListaProizvoda)
            {
                string p = proizvod.Naziv + " " + proizvod.Opis + " " + proizvod.Cena;
                ListItem li = new ListItem();
                li.Value = br.magacin.ListaProizvoda.FindIndex(pr => pr.ID_Proizvoda == proizvod.ID_Proizvoda).ToString();
                li.Text = p;
                ListBox1.Items.Add(li);
            }
        }
    }
}