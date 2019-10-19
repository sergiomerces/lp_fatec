namespace fontchooser
{
    partial class frmFontChooser
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.lstFontName = new System.Windows.Forms.ListBox();
            this.rad10 = new System.Windows.Forms.RadioButton();
            this.rad20 = new System.Windows.Forms.RadioButton();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(30, 25);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(320, 41);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "Texto de Exemplo";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstFontName
            // 
            this.lstFontName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFontName.FormattingEnabled = true;
            this.lstFontName.ItemHeight = 16;
            this.lstFontName.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            "Comic Sans MS"});
            this.lstFontName.Location = new System.Drawing.Point(33, 85);
            this.lstFontName.Name = "lstFontName";
            this.lstFontName.Size = new System.Drawing.Size(317, 52);
            this.lstFontName.TabIndex = 1;
            this.lstFontName.SelectedIndexChanged += new System.EventHandler(this.lstFontName_SelectedIndexChanged);
            // 
            // rad10
            // 
            this.rad10.AutoSize = true;
            this.rad10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad10.Location = new System.Drawing.Point(17, 22);
            this.rad10.Name = "rad10";
            this.rad10.Size = new System.Drawing.Size(65, 21);
            this.rad10.TabIndex = 2;
            this.rad10.TabStop = true;
            this.rad10.Text = "10 pts";
            this.rad10.UseVisualStyleBackColor = true;
            this.rad10.CheckedChanged += new System.EventHandler(this.rad10_CheckedChanged);
            // 
            // rad20
            // 
            this.rad20.AutoSize = true;
            this.rad20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad20.Location = new System.Drawing.Point(17, 61);
            this.rad20.Name = "rad20";
            this.rad20.Size = new System.Drawing.Size(65, 21);
            this.rad20.TabIndex = 3;
            this.rad20.TabStop = true;
            this.rad20.Text = "20 pts";
            this.rad20.UseVisualStyleBackColor = true;
            this.rad20.CheckedChanged += new System.EventHandler(this.rad20_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.Location = new System.Drawing.Point(223, 23);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(73, 21);
            this.chkBold.TabIndex = 4;
            this.chkBold.Text = "Negrito";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(223, 62);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(63, 21);
            this.chkItalic.TabIndex = 5;
            this.chkItalic.Text = "Itálico";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rad20);
            this.panel1.Controls.Add(this.chkItalic);
            this.panel1.Controls.Add(this.rad10);
            this.panel1.Controls.Add(this.chkBold);
            this.panel1.Location = new System.Drawing.Point(33, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 100);
            this.panel1.TabIndex = 6;
            // 
            // frmFontChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 288);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstFontName);
            this.Controls.Add(this.lblOutput);
            this.Name = "frmFontChooser";
            this.Text = "Font Chooser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ListBox lstFontName;
        private System.Windows.Forms.RadioButton rad10;
        private System.Windows.Forms.RadioButton rad20;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.Panel panel1;
    }
}

