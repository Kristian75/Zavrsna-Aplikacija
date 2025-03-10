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
            Zivotinja novaZivotinja = new Zivotinja
            {
                Ime = txtIme.Text,
                Vrsta = txtVrsta.Text,
                Pasmina = txtPasmina.Text,
                DatumRodenja = dtpDatumRodenja.Value,
                DatumCijepljenja = dtpDatumCijepljenja.Value,
                PosjetVeterinaru = txtPosjetVeterinaru.Text
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

            XmlElement noviElement = xmlDoc.CreateElement("Ljubimac");

            XmlElement imeElement = xmlDoc.CreateElement("Ime");
            imeElement.InnerText = novaZivotinja.Ime;
            noviElement.AppendChild(imeElement);

            XmlElement vrstaElement = xmlDoc.CreateElement("Vrsta");
            vrstaElement.InnerText = novaZivotinja.Vrsta;
            noviElement.AppendChild(vrstaElement);

            XmlElement pasminaElement = xmlDoc.CreateElement("Pasmina");
            pasminaElement.InnerText = novaZivotinja.Pasmina;
            noviElement.AppendChild(pasminaElement);

            XmlElement datumRodjenjaElement = xmlDoc.CreateElement("DatumRodenja");
            datumRodjenjaElement.InnerText = novaZivotinja.DatumRodenja.ToString("yyyy-MM-dd");
            noviElement.AppendChild(datumRodjenjaElement);

            XmlElement datumCijepljenjaElement = xmlDoc.CreateElement("DatumCijepljenja");
            datumCijepljenjaElement.InnerText = novaZivotinja.DatumCijepljenja.ToString("yyyy-MM-dd");
            noviElement.AppendChild(datumCijepljenjaElement);

            XmlElement posjetVeterinaruElement = xmlDoc.CreateElement("PosjetVeterinaru");
            posjetVeterinaruElement.InnerText = novaZivotinja.PosjetVeterinaru;
            noviElement.AppendChild(posjetVeterinaruElement);

            XmlNode existingNode = root.SelectSingleNode($"Ljubimac[Ime='{novaZivotinja.Ime}']");
            if (existingNode != null)
            {
                root.RemoveChild(existingNode);
            }
            root.AppendChild(noviElement);
            xmlDoc.Save("Ljubimci.xml");


            MessageBox.Show("Ljubimac uspješno spremljen.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


    }
}