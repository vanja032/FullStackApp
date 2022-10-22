using System;
using Business_Layer;
using System.IO;
using Data_Layer;
using Data_Layer.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer.Interfaces;

namespace SI2021_CoffeeMachineApp
{
    public partial class Pocetna : Form
    {
        private Korisnik korisnik = new Korisnik();
        private readonly BusinessRepository br;
        public Pocetna(IBusinessRepository br) 
        {
            this.br = (BusinessRepository)br;
            br.getData();
            InitializeComponent();
        }

        private void prijaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Login f = new Login(br))
            {
                var rezultat = f.ShowDialog();
                if (rezultat == DialogResult.OK)
                {
                    korisnik = f.korisnik;
                    menuStrip1.Items[0].Enabled = true;
                    if (korisnik.Role.ToUpper().Equals("ADMIN"))
                    {
                        upisToolStripMenuItem.Enabled = true;
                        prikazRadnikaToolStripMenuItem.Visible = true;
                        prikazKorisnikaToolStripMenuItem.Visible = true;
                        upisRadnikaToolStripMenuItem.Visible = true;
                        upisKorisnikaToolStripMenuItem.Visible = true;
                    }
                    else
                    { 
                        upisToolStripMenuItem.Enabled = false;
                        prikazRadnikaToolStripMenuItem.Visible = true;
                        prikazKorisnikaToolStripMenuItem.Visible = true;
                    }
                    odjaviSeToolStripMenuItem.Visible = true;
                    prijaviSeToolStripMenuItem.Visible = false;
                    lblWelcome.Text = "Dobrodošli, korisnik "+korisnik.Ime+" "+korisnik.Prezime;
                    br.magacin = br.getData();
                }
            }
            
        }

        private void prikazProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrikazProizvoda pp = new PrikazProizvoda(br))
            {
                pp.ShowDialog();
                if (pp.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            odjaviSeToolStripMenuItem.Visible = false;
            prijaviSeToolStripMenuItem.Visible = true;
        }

        private void prikazProizvođačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrikazProizvodjaca pp = new PrikazProizvodjaca(br))
            {
                pp.ShowDialog();
                if (pp.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void prikazKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrikazKorisnika pk = new PrikazKorisnika(br))
            {
                pk.ShowDialog();
                if (pk.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void prikazDobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrikazDobavljaca pd = new PrikazDobavljaca(br))
            {
                pd.ShowDialog();
                if (pd.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void prikazDopremnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrikazDopremnice pd = new PrikazDopremnice(br))
            {
                pd.ShowDialog();
                if (pd.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void prikazNarudžbinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrikazNarudzbine pn = new PrikazNarudzbine(br))
            {
                pn.ShowDialog();
                if (pn.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void prikazRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrikazRadnika pr = new PrikazRadnika(br))
            {
                pr.ShowDialog();
                if (pr.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void prikazEvidencijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrikazEvidencije pe = new PrikazEvidencije(br))
            {
                pe.ShowDialog();
                if (pe.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void upisProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (UpisProizvoda up = new UpisProizvoda(br)) {
                up.ShowDialog();
                if(up.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            korisnik = new Korisnik();
            br.ClearMagacin();
            menuStrip1.Items[0].Enabled = false;
            menuStrip1.Items[1].Enabled = false;
            prikazRadnikaToolStripMenuItem.Visible = false;
            prikazKorisnikaToolStripMenuItem.Visible = false;
            upisRadnikaToolStripMenuItem.Visible = false;
            upisKorisnikaToolStripMenuItem.Visible = false;

            odjaviSeToolStripMenuItem.Visible = false;
            prijaviSeToolStripMenuItem.Visible = true;
            lblWelcome.Text = "";
        }

        private void upisProizvođačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (UpisProizvodjaca up = new UpisProizvodjaca(br))
            {
                up.ShowDialog();
                if (up.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void upisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (UpisDobavljaca ud = new UpisDobavljaca(br))
            {
                ud.ShowDialog();
                if (ud.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void upisToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (UpisDopremnica ud = new UpisDopremnica(br))
            {
                ud.ShowDialog();
                if (ud.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void upisNarudžbinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (UpisNarudzbina un = new UpisNarudzbina(br))
            {
                un.ShowDialog();
                if (un.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void upisEvidencijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (UpisEvidencija ue = new UpisEvidencija(br))
            {
                ue.ShowDialog();
                if (ue.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void upisKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (UpisKorisnika uk = new UpisKorisnika(br))
            {
                uk.ShowDialog();
                if (uk.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void upisRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (UpisRadnika ur = new UpisRadnika(br))
            {
                ur.ShowDialog();
                if (ur.DialogResult == DialogResult.Cancel)
                {
                    this.br.getData();
                }
            }
        }

        private void webFormaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://localhost:44353/");
        }
    }
}
