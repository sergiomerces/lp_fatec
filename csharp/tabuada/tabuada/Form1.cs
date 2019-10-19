using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int multiplicando, multiplicador, produto;
            multiplicando = Convert.ToInt32(txtNumero.Text);
            
            string saida = null;

            //Tabuada em ordem crescente
            for (multiplicador = 0; multiplicador <= 10; multiplicador++)
            {
                produto = multiplicando * multiplicador;

                saida = string.Format("{0: 00} X {1: 00} = {2: 00}\n", multiplicando, multiplicador, produto);
                lblCrescente.Text += saida;
            }

            //Tabuada em ordem decrescente
            for (multiplicador = 10; multiplicador >= 0; multiplicador--)
            {
                produto = multiplicando * multiplicador;

                saida = string.Format("{0: 00} X {1: 00} = {2: 00}\n", multiplicando, multiplicador, produto);
                lblDecrescente.Text += saida;
            }
        }
    }
}
