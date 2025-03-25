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
    public partial class FormaLjubimac : Form
    {

        public FormaLjubimac()
        {
            InitializeComponent();
        }



        private Zivotinja trenutnaZivotinja;

        public FormaLjubimac(Zivotinja zivotinja)
        {
            InitializeComponent();
            trenutnaZivotinja = zivotinja;

            txtIme.Text = zivotinja.Ime;
            txtVrsta.Text = zivotinja.Vrsta;
            txtPasmina.Text = zivotinja.Pasmina;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                Zivotinja novaZivotinja = new Zivotinja
                {
                    Ime = txtIme.Text.Trim(),
                    Vrsta = txtVrsta.Text.Trim(),
                    Pasmina = txtPasmina.Text.Trim(),
                    DatumRodenja = dtpDatumRodenja.Value,
                    DatumCijepljenja = dtpDatumCijepljenja.Value,
                    PosjetVeterinaru = txtPosjetVeterinaru.Text.Trim()
                };

                XmlDocument xmlDoc = new XmlDocument();

                if (System.IO.File.Exists("Ljubimci.xml"))
                {
                    xmlDoc.Load("Ljubimci.xml");
                }
                else
                {
                    XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlElement rootElement = xmlDoc.CreateElement("Ljubimci");
                    xmlDoc.AppendChild(xmlDeclaration);
                    xmlDoc.AppendChild(rootElement);
                }

                XmlNode root = xmlDoc.DocumentElement;

                foreach (XmlNode node in root.SelectNodes("Zivotinja"))
                {
                    if (node.Attributes["Ime"] != null && node.Attributes["Ime"].Value == novaZivotinja.Ime)
                    {
                        root.RemoveChild(node);
                        break;
                    }
                }

                XmlElement noviElement = xmlDoc.CreateElement("Zivotinja");
                noviElement.SetAttribute("Ime", novaZivotinja.Ime);
                noviElement.SetAttribute("Vrsta", novaZivotinja.Vrsta);
                noviElement.SetAttribute("Pasmina", novaZivotinja.Pasmina);

                root.AppendChild(noviElement);
                xmlDoc.Save("Ljubimci.xml");

                MessageBox.Show("Ljubimac uspješno spremljen.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri spremanju ljubimca: " + ex.Message, "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private XmlElement CreateXmlElement(XmlDocument doc, string tagName, string value)
        {
            XmlElement element = doc.CreateElement(tagName);
            element.InnerText = value;
            return element;
        }

        private void FormaLjubimac_Load(object sender, EventArgs e)
        {

        }
    }
}