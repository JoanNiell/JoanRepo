using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercici3
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor per defecte
        /// </summary>
        public Form1()
        {
            
            InitializeComponent();
        }
        /// <summary>
        /// Metode per iniciar el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iniciar(object sender, EventArgs e)
        {
            try
            {
                int total = 0;
                llista.Items.Clear();
                int rep = Int32.Parse(repeticions.Text);
                for (int i = 1; i <= rep; i++)
                {
                    if (parcials.Checked)
                    {
                        total += i;
                        llista.Items.Add("Sumant: " + i + " Suma Parcial: " + total);
                    }
                }
                llista.Items.Add("La suma TOTAL ÉS: " + total);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
