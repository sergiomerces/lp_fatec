using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fontchooser
{
    public partial class frmFontChooser : Form
    {               
        public frmFontChooser()
        {
            InitializeComponent();
        }
        //cria uma classe para anipulação de fonte
        private System.Drawing.Font myFont;
        
        //declara os atributos da fonte como um novo tipo de variável para alterar propriedades da fonte
        private string fontName = "Arial"; 
        private int fontSize = 20; 
        private FontStyle myStyle = FontStyle.Regular;

        //seletor de do tipo de fonte
        private void lstFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Formatar();
        }

        //procedimento de formatação da fonte que será chamado na função principal e nos demais métodos
        private void Formatar()
        {
            fontName = lstFontName.Text; myStyle = FontStyle.Regular;
            if (chkBold.Checked)
            {
                myStyle = myStyle | FontStyle.Bold;
            }

            if (chkItalic.Checked)
            {
                myStyle = myStyle | FontStyle.Italic;
            }

            myFont = new Font(fontName, fontSize, myStyle);
            lblOutput.Font = myFont;

        }

        //altera a fonte para tamanho 10
        private void rad10_CheckedChanged(object sender, EventArgs e)
        {
            fontSize = 10;
            Formatar();
        }

        //altera a fonte para tamanho 20
        private void rad20_CheckedChanged(object sender, EventArgs e)
        {
            fontSize = 20;
            Formatar();
        }

        //aplica estilo negrito ao texto
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            myStyle = myStyle | FontStyle.Bold;
            Formatar();
        }

        //aplica estilo itálico ao texto
        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            myStyle = myStyle | FontStyle.Italic;
            Formatar();
        }
    }
}
