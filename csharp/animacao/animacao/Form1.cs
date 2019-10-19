using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animacao
{
    public partial class frmAnimacao : Form
    {
        //a variável do contador deve ser declarada como global para ser acessada
        int figura = 0;

        public frmAnimacao()
        {
            InitializeComponent();
        }

        /* o componente timer automatiza a animação criando um laço infinito 
         dispensando a interação do usuário*/
        private void timQuadro_Tick(object sender, EventArgs e)
        {           
            figura++;
            pctDisplay.Image = imlQuadrinho.Images[figura];

            /*a variável figura servirá de controle como índice é preciso atenção
             pois temos 4 imagens, sendo que o arranjo sempre inicia com índice 0*/
            if (figura >= 3)
            {
                figura = 0;
            }
        }       
    }
}
