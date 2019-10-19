using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_critter
{
    public partial class frmMyForm : Form
    {
        public frmMyForm()
        {
            InitializeComponent();
        }

        private void cobHumor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cobHumor.Text)
            {
                case "indiferente":
                    {
                        picCritter.Image = picIndiferente.Image;
                        break;
                    }
                case "feliz":
                    {
                        picCritter.Image = picFeliz.Image;
                        break;
                    }
                case "louco":
                    {
                        picCritter.Image = picLouco.Image;
                        break;
                    }
                default:
                    {
                        picCritter.Image = picIndiferente.Image;
                        break;
                    }
            }
        }

        private void picCritter_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Me dê um novo nome!";
        }

        private void btnMudarNome_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                lblMensagem.Text = "Não seja rabugento me dê um nome!";
            }

            else
            {
                lblMensagem.Text = txtNome.Text;
                MessageBox.Show("Oi meu nome é " + txtNome.Text +"!", "Saudação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radVermelho_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            panel1.BackColor = Color.LightGray;
            panel2.BackColor = Color.LightGray;
            panel3.BackColor = Color.LightGray;
            panel4.BackColor = Color.LightGray;
        }

        private void radVerde_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            panel1.BackColor = Color.LightGray;
            panel2.BackColor = Color.LightGray;
            panel3.BackColor = Color.LightGray;
            panel4.BackColor = Color.LightGray;
        }

        private void radAzul_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            panel1.BackColor = Color.LightGray;
            panel2.BackColor = Color.LightGray;
            panel3.BackColor = Color.LightGray;
            panel4.BackColor = Color.LightGray;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            picCritter.Size = new Size(hScrollBar1.Value, hScrollBar1.Value);
        }
    }
}
