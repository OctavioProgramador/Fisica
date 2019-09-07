using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Física
{
    public partial class Form1 : Form
    {
        List<TextBox> textboxlist;
        public Form1()
        {
            InitializeComponent();
            textboxlist = new List<TextBox>()
            {
                txtA_B,txtd1,txtd2,txtMasacaja,txtMasagrua
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            if (!textboxlist.Exists(x => x.Text == ""))
            {
                double f1 = Convert.ToDouble(txtMasagrua.Text);
                double f2 = Convert.ToDouble(txtMasacaja.Text);
                double d1 = Convert.ToDouble(txtd1.Text);
                double d2 = Convert.ToDouble(txtd2.Text) + d1;
                double dAB = Convert.ToDouble(txtA_B.Text);
                double Rb = ((f1 * d1) + (f2 * d2)) / dAB;
                double Rax = -Rb;
                double Ray = f1 + f2;
                double Ra = Math.Sqrt(Math.Pow(Rb, 2) + Math.Pow(Ray, 2));
                lbldespliegue.Text = String.Format("Ra = {0}N, Rb = {1}N", Ra, Rb);
            }
            else
            {
                MessageBox.Show("Rellene todos los campos, por favor");
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {           
            foreach (TextBox item in textboxlist)
            {
                item.Text = "";
            };
            lbldespliegue.Text = "";
        }

        private void buttonsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtA_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.Equals('-'))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.Equals('.'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
