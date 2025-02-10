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
        public GlavnaForma()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            FormaLjubimac formaLjubimac = new FormaLjubimac();
            formaLjubimac.ShowDialog();
            OsvjeziPrikazZivotinja();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (lstLjubimci.SelectedItem != null)
            {
                Zavrsna_Aplikacija.Zivotinja odabranaZivotinja = (Zavrsna_Aplikacija.Zivotinja)lstLjubimci.SelectedItem;
                FormaLjubimac formaLjubimac = new FormaLjubimac(odabranaZivotinja);
                formaLjubimac.ShowDialog();
                OsvjeziPrikazZivotinja();
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
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
            xmlDoc.Load("Ljubimci.xml");

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

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
