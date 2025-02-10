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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;

            if (korisnickoIme == "admin" && lozinka == "password")
            {
                GlavnaForma glavnaForma = new GlavnaForma();
                glavnaForma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Neispravni podaci. Pokušajte ponovo.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
