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
            txtLozinka.PasswordChar = '•'; // Lozinka se inicijalno prikazuje kao točke
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
            string uloga;

            // Hardkodirane vjerodajnice za testiranje
            if (korisnickoIme == "admin" && lozinka == "06102006")
            {
                uloga = "administrator";
            }

            else
            {
                uloga = "korisnik";
            }

            // Otvori glavnu formu i proslijedi ulogu
            GlavnaForma glavnaForma = new GlavnaForma(uloga);
            glavnaForma.Show();
            this.Hide();
        }

        private void btnPrikaziLozinku_MouseDown_1(object sender, MouseEventArgs e)
        {
            txtLozinka.PasswordChar = '\0'; // Lozinka postaje vidljiva dok držiš pritisak
        }

        private void btnPrikaziLozinku_MouseUp(object sender, MouseEventArgs e)
        {
            txtLozinka.PasswordChar = '•'; // Lozinka se vraća na skrivene znakove
        }
    }
}
