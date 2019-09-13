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
                txtMasa,txtFuerza
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            if (!textboxlist.Exists(x => x.Text == ""))
            {
                double fuerza = Convert.ToDouble(txtFuerza.Text);
                double masa = Convert.ToDouble(txtMasa.Text);                                
                lbldespliegue.Text = String.Format("Aceleración = {0} m/s^2", (fuerza/masa));
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

        private void lbldespliegue_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbldespliegue.Text = "";
        }
    }
}
