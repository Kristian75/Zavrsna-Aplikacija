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


        public string Uloga { get; private set; }

        public Prijava()

        {
            InitializeComponent();
            txtLozinka.PasswordChar = '•'; 
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

            if (korisnickoIme == "admin" && lozinka == "admin")
            {
                Uloga = "administrator";
                
            }
            else
            {
                Uloga = "korisnik";
            }



            GlavnaForma glavnaForma = new GlavnaForma(Uloga);
            glavnaForma.Show();
            this.Hide();

        }

        private void btnPrikaziLozinku_MouseDown_1(object sender, MouseEventArgs e)
        {
            txtLozinka.PasswordChar = '\0'; 
        }

        private void btnPrikaziLozinku_MouseUp(object sender, MouseEventArgs e)
        {
            txtLozinka.PasswordChar = '•';
        }
    }
}


