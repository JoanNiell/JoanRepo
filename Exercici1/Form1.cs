using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercici1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metode per entrar les dades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ingressar(object sender, EventArgs e)
        {
            try
            {
                string a = txtUser.Text;
                string b = txtPassword.Text;

                if (a == "joan" && b == "1928")
                    MessageBox.Show("Verificació correcte");
                else MessageBox.Show("Usuari o contrassenya incorrectes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Metode per tancar la consola
        /// </summary>
        /// <param name="sender">Prametre per defecte</param>
        /// <param name="e">Prarametre 2 per defecte</param>
        private void Sortir(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
