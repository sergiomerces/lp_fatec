using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_dados2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random randomNumber = new Random(); 

        private void btnRoll_Click(object sender, EventArgs e)
        {
            DisplayDie(dieLabel1); DisplayDie(dieLabel2); DisplayDie(dieLabel3); DisplayDie(dieLabel4);

        }
    }
}
