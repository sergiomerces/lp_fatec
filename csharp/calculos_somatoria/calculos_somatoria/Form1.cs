using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculos_somatoria
{
    public partial class frmExemplo3 : Form
    {
        public frmExemplo3()
        {
            InitializeComponent();
        }

        private void btnSomatoria_Click(object sender, EventArgs e)
        {
            int num, resultado;
            num= Convert.ToInt32(txtNum.Text);
            resultado = 0;

            for (int i = 0; i <= num; i++)
               resultado += i;

            MessageBox.Show(string.Format("O resultado é {0:##,###,#00}", resultado), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImpar_Click(object sender, EventArgs e)
        {
            int num, resultado;
            num = Convert.ToInt32(txtNum.Text);
            resultado = 0;

            for (int i = 0; i <= num; i++)
            {
                if ((i % 2) != 0)
                {
                    resultado += i; 
                }
            }

            MessageBox.Show(string.Format("O resultado é {0:##,###,#00}", resultado), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      
        private void btnFatorial_Click(object sender, EventArgs e)
        {
            int num, resultado;
            num = Convert.ToInt32(txtNum.Text);
            resultado = 1;

            for (int i = 1; i <= num; i++)            
                resultado *= i;

            MessageBox.Show(string.Format("O resultado é {0:##,###,#00}", resultado), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
