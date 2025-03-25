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

namespace Zavrsna_Aplikacija
{
    public partial class FormaPretrazi : Form
    {

        private List<Zivotinja> ljubimci;
        public FormaPretrazi()
        {
            InitializeComponent();
            UcitajLjubimce();
        }

        private void UcitajLjubimce()
        {
            ljubimci = new List<Zivotinja>();

            XmlDocument xmlDoc = new XmlDocument();

            if (System.IO.File.Exists("Ljubimci.xml"))
            {
                xmlDoc.Load("Ljubimci.xml");

                foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
                {
                    if (node.Attributes != null)
                    {
                        string ime = node.Attributes["Ime"]?.Value ?? "Nepoznato";
                        string vrsta = node.Attributes["Vrsta"]?.Value ?? "Nepoznato";
                        string pasmina = node.Attributes["Pasmina"]?.Value ?? "Nepoznato";

                        Zivotinja zivotinja = new Zivotinja
                        {
                            Ime = ime,
                            Vrsta = vrsta,
                            Pasmina = pasmina
                        };

                        ljubimci.Add(zivotinja);
                    }
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pretrazi_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string pojamPretrage = txtPretraga.Text?.Trim();

            if (!string.IsNullOrEmpty(pojamPretrage))
            {
                List<Zivotinja> rezultati = ljubimci
     .Where(l => l.Ime.IndexOf(pojamPretrage, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 l.Vrsta.IndexOf(pojamPretrage, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 l.Pasmina.IndexOf(pojamPretrage, StringComparison.OrdinalIgnoreCase) >= 0)
     .ToList();


                lstRezultati.DataSource = null;
                lstRezultati.Items.Clear();

                foreach (var zivotinja in rezultati)
                {
                    lstRezultati.Items.Add(zivotinja.ToString());
                }
            }
            else
            {
                MessageBox.Show("Unesite pojam za pretragu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}