namespace animacao
{
    partial class frmAnimacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnimacao));
            this.pctDisplay = new System.Windows.Forms.PictureBox();
            this.imlQuadrinho = new System.Windows.Forms.ImageList(this.components);
            this.timQuadro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pctDisplay
            // 
            this.pctDisplay.Location = new System.Drawing.Point(13, 13);
            this.pctDisplay.Name = "pctDisplay";
            this.pctDisplay.Size = new System.Drawing.Size(409, 290);
            this.pctDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDisplay.TabIndex = 0;
            this.pctDisplay.TabStop = false;
            // 
            // imlQuadrinho
            // 
            this.imlQuadrinho.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlQuadrinho.ImageStream")));
            this.imlQuadrinho.TransparentColor = System.Drawing.Color.Transparent;
            this.imlQuadrinho.Images.SetKeyName(0, "fabio1.jpg");
            this.imlQuadrinho.Images.SetKeyName(1, "fabio2.jpg");
            this.imlQuadrinho.Images.SetKeyName(2, "fabio3.jpg");
            this.imlQuadrinho.Images.SetKeyName(3, "fabio4.jpg");
            // 
            // timQuadro
            // 
            this.timQuadro.Enabled = true;
            this.timQuadro.Tick += new System.EventHandler(this.timQuadro_Tick);
            // 
            // frmAnimacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 315);
            this.Controls.Add(this.pctDisplay);
            this.Name = "frmAnimacao";
            this.Text = "Animação";
            ((System.ComponentModel.ISupportInitialize)(this.pctDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDisplay;
        private System.Windows.Forms.ImageList imlQuadrinho;
        private System.Windows.Forms.Timer timQuadro;

    }
}

