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

        private void Sortir(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
