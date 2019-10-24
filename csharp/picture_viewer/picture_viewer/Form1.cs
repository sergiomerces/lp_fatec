using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //instância da opção sair do menu
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //inicializa fomrulário com aopção JPEG como padrão e configura pasta parão
        private void Form1_Load(object sender, EventArgs e)
        {
            //** pasta padrão para carregar imgens images
            this.radJPEG.Checked = true;

            //** configurar controle da pasta do desktop e outras opções 
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop; 
            this.folderBrowserDialog1.Description = "Por favor localize a pasta contendo as figuras para visualização...";

            //** initialize clock in status bar, and set a timer to update clock... 
            this.sbarClockLabel.Text = System.DateTime.Now.ToString("hh:mm tt\ndd/MM/yyyy"); 
            this.timer1.Interval = 30000; 
            
            //** update every 30 seconds or so 
            this.timer1.Enabled = true;
        }

        //instância do comando para localizar pasta no desktop
        private void abrirFiguraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //** Exibe a caixa de diálogo, mas não retorna nada até que o usuário clique em ok/cancel...
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder, pattern, filename, pathname;
                //** captura a escolha 
                folder = this.folderBrowserDialog1.SelectedPath;

                //** update status bar to display current folder selected by user 
                this.sbarFolderLabel.Text = folder;

                //** referência da classe Globals para lembrar de onde as imagens estão armazenadas 
                Globals.CurrentPictureFolder = folder;
                this.sbarFolderLabel.Text = folder;

                //** qual o tipo do arquivo?  .jpg, .bmp, ? 
                if (this.radJPEG.Checked == true) 
                    pattern = "*.jpg"; 

                else if (this.radBMP.Checked == true) 
                    pattern = "*.bmp"; 
                
                else pattern = "*.*";
                //** lê o conteúdo da pasta conforme o padrão...

                //atenção
                Globals.CurrentPictureFolder = folder;
                this.sbarFolderLabel.Text = folder;

                
                string[] files = null; files = System.IO.Directory.GetFiles(folder, pattern);

                //** limpa a listbox e carrega os nomes dos arquivos! 
                this.lstFileNames.Items.Clear(); 
                foreach (string pathname_loopVariable in files) 
                { 
                    pathname = pathname_loopVariable; 
                    filename = System.IO.Path.GetFileName(pathname); 
                    this.lstFileNames.Items.Add(filename);                   
                }
            }

        }

        //carregar imagens na listbox
        private void lstFileNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filename = null; 
            string folder = null; 
            string pathname = null;

            filename = this.lstFileNames.SelectedItem.ToString(); 
            folder = Globals.CurrentPictureFolder;

            pathname = System.IO.Path.Combine(folder, filename);

            //comando responsável pela captura do endereço da imagem/pasta
            this.picImage.Image = System.Drawing.Image.FromFile(pathname);
        }
    }
}
