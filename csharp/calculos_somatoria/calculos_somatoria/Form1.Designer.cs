namespace calculos_somatoria
{
    partial class frmExemplo3
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnSomatoria = new System.Windows.Forms.Button();
            this.btnImpar = new System.Windows.Forms.Button();
            this.btnFatorial = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(19, 21);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(106, 23);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSomatoria
            // 
            this.btnSomatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomatoria.Location = new System.Drawing.Point(19, 67);
            this.btnSomatoria.Name = "btnSomatoria";
            this.btnSomatoria.Size = new System.Drawing.Size(106, 29);
            this.btnSomatoria.TabIndex = 1;
            this.btnSomatoria.Text = "Somatória";
            this.btnSomatoria.UseVisualStyleBackColor = true;
            this.btnSomatoria.Click += new System.EventHandler(this.btnSomatoria_Click);
            // 
            // btnImpar
            // 
            this.btnImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpar.Location = new System.Drawing.Point(19, 117);
            this.btnImpar.Name = "btnImpar";
            this.btnImpar.Size = new System.Drawing.Size(106, 27);
            this.btnImpar.TabIndex = 2;
            this.btnImpar.Text = "Soma Ímpares";
            this.btnImpar.UseVisualStyleBackColor = true;
            this.btnImpar.Click += new System.EventHandler(this.btnImpar_Click);
            // 
            // btnFatorial
            // 
            this.btnFatorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFatorial.Location = new System.Drawing.Point(18, 167);
            this.btnFatorial.Name = "btnFatorial";
            this.btnFatorial.Size = new System.Drawing.Size(107, 27);
            this.btnFatorial.TabIndex = 3;
            this.btnFatorial.Text = "Fatorial";
            this.btnFatorial.UseVisualStyleBackColor = true;
            this.btnFatorial.Click += new System.EventHandler(this.btnFatorial_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(131, 167);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 27);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmExemplo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 213);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFatorial);
            this.Controls.Add(this.btnImpar);
            this.Controls.Add(this.btnSomatoria);
            this.Controls.Add(this.txtNum);
            this.Name = "frmExemplo3";
            this.Text = "Exemplo 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnSomatoria;
        private System.Windows.Forms.Button btnImpar;
        private System.Windows.Forms.Button btnFatorial;
        private System.Windows.Forms.Button btnSair;
    }
}

