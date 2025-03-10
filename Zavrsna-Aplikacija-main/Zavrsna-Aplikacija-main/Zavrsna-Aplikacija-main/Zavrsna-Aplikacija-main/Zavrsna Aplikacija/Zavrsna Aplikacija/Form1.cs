using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Zavrsna_Aplikacija;

namespace Zavrsna_Aplikacija
{
    public partial class GlavnaForma : Form
    {
        private string uloga;

        public GlavnaForma(string korisnickaUloga)
        {
            InitializeComponent();
            uloga = korisnickaUloga;

            if (uloga == "korisnik")
            {
                btnUredi.Enabled = false;
                btnIzbrisi.Enabled = false;
            }
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormaLjubimac formaLjubimac = new FormaLjubimac();
            formaLjubimac.ShowDialog();
            OsvjeziPrikazZivotinja();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (uloga == "korisnik")
            {
                MessageBox.Show("Nemate dopuštenje za uređivanje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstLjubimci.SelectedItem != null)
            {
                Zivotinja odabranaZivotinja = (Zivotinja)lstLjubimci.SelectedItem;
                FormaLjubimac formaLjubimac = new FormaLjubimac(odabranaZivotinja);
                formaLjubimac.ShowDialog();
                OsvjeziPrikazZivotinja();
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (uloga == "korisnik")
            {
                MessageBox.Show("Nemate dopuštenje za brisanje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstLjubimci.SelectedItem != null)
            {
                DialogResult rezultat = MessageBox.Show("Jeste li sigurni da želite izbrisati ljubimca?", "Potvrda", MessageBoxButtons.YesNo);
                if (rezultat == DialogResult.Yes)
                {
                    lstLjubimci.Items.Remove(lstLjubimci.SelectedItem);
                    OsvjeziPrikazZivotinja();
                }
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            FormaPretrazi formaPretrazi = new FormaPretrazi();
            formaPretrazi.ShowDialog();
        }

        private void OsvjeziPrikazZivotinja()
        {
            lstLjubimci.Items.Clear();

            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load("Ljubimci.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju podataka: " + ex.Message, "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
                {
                    Zivotinja zivotinja = new Zivotinja
                    {
                        Ime = node.Attributes["Ime"].Value,
                        Vrsta = node.Attributes["Vrsta"].Value,
                        Pasmina = node.Attributes["Pasmina"].Value
                    };

                    lstLjubimci.Items.Add(zivotinja);
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}