using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculos_exemplo2
{
    public partial class frmExemplo2 : Form
    {
        public frmExemplo2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2;
            string msg = null;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            msg = string.Format("{0: ###,##0.00} X {1: ###,##0.00} = {2: ###,##0.00}", num1, num2, num1 * num2);

            MessageBox.Show(msg, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
        }
    }
}
