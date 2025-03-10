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
                    Zivotinja zivotinja = new Zivotinja
                    {
                        Ime = node.Attributes["Ime"].Value,
                        Vrsta = node.Attributes["Vrsta"].Value,
                        Pasmina = node.Attributes["Pasmina"].Value
                    };

                    ljubimci.Add(zivotinja);
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
            string pojamPretrage = txtPretraga.Text;

            List<Zivotinja> rezultati = ljubimci.Where(l => l.Ime.Contains(pojamPretrage) ||
                                                            l.Vrsta.Contains(pojamPretrage) ||
                                                            l.Pasmina.Contains(pojamPretrage))
                                                .ToList();

            lstRezultati.DataSource = null;
            lstRezultati.Items.Clear();
            foreach (var zivotinja in rezultati)
            {
                lstRezultati.Items.Add(zivotinja.ToString());
            }

        }
    }
}