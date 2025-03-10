using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsna_Aplikacija
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Prijava loginForma = new Prijava();
            Application.Run(loginForma);

            // Ako želiš da se glavna forma pokrene tek nakon uspješne prijave, napravi nešto slično ovome:
            if (loginForma.DialogResult == DialogResult.OK)
            {
                Application.Run(new GlavnaForma(loginForma.Uloga));
            }

        }
    }
}
