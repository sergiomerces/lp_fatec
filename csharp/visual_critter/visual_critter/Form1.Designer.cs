namespace visual_critter
{
    partial class frmMyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cobHumor = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnMudarNome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radVermelho = new System.Windows.Forms.RadioButton();
            this.radVerde = new System.Windows.Forms.RadioButton();
            this.radAzul = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.picCritter = new System.Windows.Forms.PictureBox();
            this.picFeliz = new System.Windows.Forms.PictureBox();
            this.picIndiferente = new System.Windows.Forms.PictureBox();
            this.picLouco = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCritter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFeliz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIndiferente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLouco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cobHumor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMudarNome);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Location = new System.Drawing.Point(13, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radAzul);
            this.panel3.Controls.Add(this.radVerde);
            this.panel3.Controls.Add(this.radVermelho);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(13, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 116);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.hScrollBar1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(13, 395);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione meu humor";
            // 
            // cobHumor
            // 
            this.cobHumor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobHumor.FormattingEnabled = true;
            this.cobHumor.Items.AddRange(new object[] {
            "indiferente",
            "feliz",
            "louco"});
            this.cobHumor.Location = new System.Drawing.Point(17, 59);
            this.cobHumor.Name = "cobHumor";
            this.cobHumor.Size = new System.Drawing.Size(168, 24);
            this.cobHumor.TabIndex = 1;
            this.cobHumor.SelectedIndexChanged += new System.EventHandler(this.cobHumor_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(16, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(168, 23);
            this.txtNome.TabIndex = 0;
            // 
            // btnMudarNome
            // 
            this.btnMudarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudarNome.Location = new System.Drawing.Point(16, 61);
            this.btnMudarNome.Name = "btnMudarNome";
            this.btnMudarNome.Size = new System.Drawing.Size(168, 29);
            this.btnMudarNome.TabIndex = 1;
            this.btnMudarNome.Text = "Mude meu nome";
            this.btnMudarNome.UseVisualStyleBackColor = true;
            this.btnMudarNome.Click += new System.EventHandler(this.btnMudarNome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Escolha minha cor";
            // 
            // radVermelho
            // 
            this.radVermelho.AutoSize = true;
            this.radVermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVermelho.Location = new System.Drawing.Point(16, 40);
            this.radVermelho.Name = "radVermelho";
            this.radVermelho.Size = new System.Drawing.Size(86, 21);
            this.radVermelho.TabIndex = 1;
            this.radVermelho.TabStop = true;
            this.radVermelho.Text = "Vermelho";
            this.radVermelho.UseVisualStyleBackColor = true;
            this.radVermelho.CheckedChanged += new System.EventHandler(this.radVermelho_CheckedChanged);
            // 
            // radVerde
            // 
            this.radVerde.AutoSize = true;
            this.radVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVerde.Location = new System.Drawing.Point(16, 64);
            this.radVerde.Name = "radVerde";
            this.radVerde.Size = new System.Drawing.Size(64, 21);
            this.radVerde.TabIndex = 2;
            this.radVerde.TabStop = true;
            this.radVerde.Text = "Verde";
            this.radVerde.UseVisualStyleBackColor = true;
            this.radVerde.CheckedChanged += new System.EventHandler(this.radVerde_CheckedChanged);
            // 
            // radAzul
            // 
            this.radAzul.AutoSize = true;
            this.radAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAzul.Location = new System.Drawing.Point(16, 90);
            this.radAzul.Name = "radAzul";
            this.radAzul.Size = new System.Drawing.Size(53, 21);
            this.radAzul.TabIndex = 3;
            this.radAzul.TabStop = true;
            this.radAzul.Text = "Azul";
            this.radAzul.UseVisualStyleBackColor = true;
            this.radAzul.CheckedChanged += new System.EventHandler(this.radAzul_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mude meu tamanho";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(16, 63);
            this.hScrollBar1.Maximum = 300;
            this.hScrollBar1.Minimum = 50;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(168, 17);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Value = 100;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(240, 12);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(142, 24);
            this.lblMensagem.TabIndex = 4;
            this.lblMensagem.Text = "Clique em mim!";
            // 
            // picCritter
            // 
            this.picCritter.Location = new System.Drawing.Point(243, 39);
            this.picCritter.Name = "picCritter";
            this.picCritter.Size = new System.Drawing.Size(100, 73);
            this.picCritter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCritter.TabIndex = 5;
            this.picCritter.TabStop = false;
            this.picCritter.Click += new System.EventHandler(this.picCritter_Click);
            // 
            // picFeliz
            // 
            this.picFeliz.Image = ((System.Drawing.Image)(resources.GetObject("picFeliz.Image")));
            this.picFeliz.Location = new System.Drawing.Point(243, 395);
            this.picFeliz.Name = "picFeliz";
            this.picFeliz.Size = new System.Drawing.Size(100, 100);
            this.picFeliz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFeliz.TabIndex = 6;
            this.picFeliz.TabStop = false;
            this.picFeliz.Visible = false;
            // 
            // picIndiferente
            // 
            this.picIndiferente.Image = ((System.Drawing.Image)(resources.GetObject("picIndiferente.Image")));
            this.picIndiferente.Location = new System.Drawing.Point(380, 395);
            this.picIndiferente.Name = "picIndiferente";
            this.picIndiferente.Size = new System.Drawing.Size(100, 100);
            this.picIndiferente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIndiferente.TabIndex = 7;
            this.picIndiferente.TabStop = false;
            this.picIndiferente.Visible = false;
            // 
            // picLouco
            // 
            this.picLouco.Image = ((System.Drawing.Image)(resources.GetObject("picLouco.Image")));
            this.picLouco.Location = new System.Drawing.Point(516, 395);
            this.picLouco.Name = "picLouco";
            this.picLouco.Size = new System.Drawing.Size(100, 100);
            this.picLouco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLouco.TabIndex = 8;
            this.picLouco.TabStop = false;
            this.picLouco.Visible = false;
            // 
            // frmMyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 507);
            this.Controls.Add(this.picLouco);
            this.Controls.Add(this.picIndiferente);
            this.Controls.Add(this.picFeliz);
            this.Controls.Add(this.picCritter);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMyForm";
            this.Text = "The Visual Critter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCritter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFeliz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIndiferente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLouco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cobHumor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMudarNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radAzul;
        private System.Windows.Forms.RadioButton radVerde;
        private System.Windows.Forms.RadioButton radVermelho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox picCritter;
        private System.Windows.Forms.PictureBox picFeliz;
        private System.Windows.Forms.PictureBox picIndiferente;
        private System.Windows.Forms.PictureBox picLouco;
    }
}

