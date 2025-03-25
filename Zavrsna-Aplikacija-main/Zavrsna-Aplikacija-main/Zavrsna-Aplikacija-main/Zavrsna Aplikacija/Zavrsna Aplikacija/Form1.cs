using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Zavrsna_Aplikacija
{
    public partial class GlavnaForma : Form
    {
        private string uloga;
        private List<Zivotinja> ljubimci = new List<Zivotinja>();

        public GlavnaForma(string korisnickaUloga)
        {
            InitializeComponent();
            uloga = korisnickaUloga;

            if (uloga == "korisnik")
            {
                btnUredi.Enabled = false;
                btnIzbrisi.Enabled = false;
            }

            OsvjeziPrikazZivotinja(); 
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
                    Zivotinja odabranaZivotinja = (Zivotinja)lstLjubimci.SelectedItem;

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("Ljubimci.xml");

                    XmlNode root = xmlDoc.DocumentElement;
                    XmlNode nodeToRemove = null;

                    foreach (XmlNode node in root.SelectNodes("Zivotinja"))
                    {
                        if (node.Attributes["Ime"] != null && node.Attributes["Ime"].Value == odabranaZivotinja.Ime)
                        {
                            nodeToRemove = node;
                            break;
                        }
                    }

                    if (nodeToRemove != null)
                    {
                        root.RemoveChild(nodeToRemove);
                        xmlDoc.Save("Ljubimci.xml");
                    }

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
            ljubimci.Clear(); 
            lstLjubimci.Items.Clear();

            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load("Ljubimci.xml");

                foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
                {
                    if (node.Name == "Zivotinja")
                    {
                        string ime, vrsta, pasmina;

                       
                        if (node.Attributes["Ime"] != null)
                        {
                            ime = node.Attributes["Ime"].Value;
                            vrsta = node.Attributes["Vrsta"].Value;
                            pasmina = node.Attributes["Pasmina"].Value;
                        }
                        else
                        {
                           
                            ime = node["Ime"]?.InnerText ?? "Nepoznato";
                            vrsta = node["Vrsta"]?.InnerText ?? "Nepoznato";
                            pasmina = node["Pasmina"]?.InnerText ?? "Nepoznato";
                        }

                        Zivotinja zivotinja = new Zivotinja
                        {
                            Ime = ime,
                            Vrsta = vrsta,
                            Pasmina = pasmina
                        };

                        ljubimci.Add(zivotinja);
                    }
                }

                
                lstLjubimci.Items.AddRange(ljubimci.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju podataka: " + ex.Message, "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SpremiPodatke()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Ljubimci");

            foreach (Zivotinja zivotinja in ljubimci)
            {
                XmlElement xmlZivotinja = xmlDoc.CreateElement("Zivotinja");

                xmlZivotinja.SetAttribute("Ime", zivotinja.Ime);
                xmlZivotinja.SetAttribute("Vrsta", zivotinja.Vrsta);
                xmlZivotinja.SetAttribute("Pasmina", zivotinja.Pasmina);

                root.AppendChild(xmlZivotinja);
            }

            xmlDoc.AppendChild(root);
            xmlDoc.Save("Ljubimci.xml");
        }
    }
}
