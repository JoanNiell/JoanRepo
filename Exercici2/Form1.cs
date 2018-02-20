using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercici2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// hola
        /// </summary>
        int result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculaGastos(object sender, EventArgs e)
        {
            
            try
            {
                
                if (radio1.Checked)
                {
                    result += 50;
                }
                if (radio2.Checked)
                {
                    result += 100;
                }
                if (radio3.Checked)
                {
                    result += 150;
                }
                if (check1.Checked)
                {
                    result += 5;
                }
                if (check1.Checked)
                {
                    result += 15;
                }
                if (check3.Checked)
                {
                    result += 20;
                }

                MessageBox.Show("El total de gastos d'enviament serà de " + result + "€");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
