using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sizer
{
    public partial class frmSizer : Form
    {
        public frmSizer()
        {
            InitializeComponent();
        }

        /**se as propriedades da hscrollbar forem alteradas depois é preciso removê-la
         * e reinserir para fazer alterações válidas na proxima compilação.**/
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Size = new Size(hScrollBar1.Value, hScrollBar1.Value);
        }       
    }
}
