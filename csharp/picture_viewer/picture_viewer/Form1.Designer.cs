namespace picture_viewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lstFileNames = new System.Windows.Forms.ListBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFiguraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radJPEG = new System.Windows.Forms.RadioButton();
            this.radBMP = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbarFolderLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbarClockLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lstFileNames
            // 
            this.lstFileNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstFileNames.FormattingEnabled = true;
            this.lstFileNames.Location = new System.Drawing.Point(12, 31);
            this.lstFileNames.Name = "lstFileNames";
            this.lstFileNames.Size = new System.Drawing.Size(166, 238);
            this.lstFileNames.TabIndex = 1;
            this.lstFileNames.SelectedIndexChanged += new System.EventHandler(this.lstFileNames_SelectedIndexChanged);
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.Location = new System.Drawing.Point(184, 29);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(461, 348);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.radBMP);
            this.groupBox1.Controls.Add(this.radJPEG);
            this.groupBox1.Location = new System.Drawing.Point(12, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato de Imagem";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFiguraToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirFiguraToolStripMenuItem
            // 
            this.abrirFiguraToolStripMenuItem.Name = "abrirFiguraToolStripMenuItem";
            this.abrirFiguraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirFiguraToolStripMenuItem.Text = "Abrir Figura";
            this.abrirFiguraToolStripMenuItem.Click += new System.EventHandler(this.abrirFiguraToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // radJPEG
            // 
            this.radJPEG.AutoSize = true;
            this.radJPEG.Location = new System.Drawing.Point(7, 35);
            this.radJPEG.Name = "radJPEG";
            this.radJPEG.Size = new System.Drawing.Size(52, 17);
            this.radJPEG.TabIndex = 0;
            this.radJPEG.TabStop = true;
            this.radJPEG.Text = "JPEG";
            this.radJPEG.UseVisualStyleBackColor = true;
            // 
            // radBMP
            // 
            this.radBMP.AutoSize = true;
            this.radBMP.Location = new System.Drawing.Point(7, 68);
            this.radBMP.Name = "radBMP";
            this.radBMP.Size = new System.Drawing.Size(48, 17);
            this.radBMP.TabIndex = 1;
            this.radBMP.TabStop = true;
            this.radBMP.Text = "BMP";
            this.radBMP.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbarFolderLabel,
            this.sbarClockLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(657, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbarFolderLabel
            // 
            this.sbarFolderLabel.Name = "sbarFolderLabel";
            this.sbarFolderLabel.Size = new System.Drawing.Size(611, 17);
            this.sbarFolderLabel.Spring = true;
            this.sbarFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sbarClockLabel
            // 
            this.sbarClockLabel.Name = "sbarClockLabel";
            this.sbarClockLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 405);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lstFileNames);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Visualizador de Imagens 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirFiguraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ListBox lstFileNames;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBMP;
        private System.Windows.Forms.RadioButton radJPEG;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbarFolderLabel;
        private System.Windows.Forms.ToolStripStatusLabel sbarClockLabel;
    }
}

