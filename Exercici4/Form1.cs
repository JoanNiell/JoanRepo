using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercici4
{
    public partial class Form1 : Form
    {
        int result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcul(object sender, EventArgs e)
        {
            try
            {
                int a = Int32.Parse(num1.Text);
                int b = Int32.Parse(num2.Text);

                if (suma.Checked)
                {
                    result = a + b;
                }
                else if (resta.Checked)
                {
                    result = a - b;
                }
                else if (divisio.Checked)
                {
                    result = a / b;
                }
                else if (multiplicacio.Checked)
                {
                    result = a * b;
                }
                else throw new Exception("Selecciona un metode de calcul");

                resultat.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Has demplenar les caselles amb numeros");
            }
        }
        
    }
}
