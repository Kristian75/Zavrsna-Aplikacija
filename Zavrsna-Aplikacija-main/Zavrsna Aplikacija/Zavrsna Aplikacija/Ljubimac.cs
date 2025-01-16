using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsna_Aplikacija
{
    public partial class FormaLjubimac : Form
    {
        public FormaLjubimac()
        {
            InitializeComponent();
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
            if (string.IsNullOrWhiteSpace(txtIme.Text) ||
        string.IsNullOrWhiteSpace(txtVrsta.Text) ||
        string.IsNullOrWhiteSpace(txtPasmina.Text))
            {
                MessageBox.Show("Molimo unesite sve potrebne informacije!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string podaci = $"Ime: {txtIme.Text}\nVrsta: {txtVrsta.Text}\nPasmina: {txtPasmina.Text}\n" +
                            $"Datum Rođenja: {dtpDatumRodenja.Value.ToShortDateString()}\n" +
                            $"Datum Cijepljenja: {dtpDatumCijepljenja.Value.ToShortDateString()}\n" +
                            $"Posjeti Veterinaru: {txtPosjetiVeterinaru.Text}";

            MessageBox.Show("Podaci su uspješno spremljeni:\n" + podaci, "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
