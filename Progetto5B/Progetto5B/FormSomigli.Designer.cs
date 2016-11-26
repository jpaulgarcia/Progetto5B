namespace Progetto5B
{
    partial class FormSomigli
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
            this.lblNomSom = new System.Windows.Forms.Label();
            this.lblCognSom = new System.Windows.Forms.Label();
            this.lblDataSom = new System.Windows.Forms.Label();
            this.lblLuogNascSom = new System.Windows.Forms.Label();
            this.txbNomeSom = new System.Windows.Forms.TextBox();
            this.txtCognSom = new System.Windows.Forms.TextBox();
            this.txbDataSom = new System.Windows.Forms.TextBox();
            this.txtLuogNascSom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomSom
            // 
            this.lblNomSom.AutoSize = true;
            this.lblNomSom.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomSom.Location = new System.Drawing.Point(171, 41);
            this.lblNomSom.Name = "lblNomSom";
            this.lblNomSom.Size = new System.Drawing.Size(45, 15);
            this.lblNomSom.TabIndex = 2;
            this.lblNomSom.Text = "Nome:";
            // 
            // lblCognSom
            // 
            this.lblCognSom.AutoSize = true;
            this.lblCognSom.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognSom.Location = new System.Drawing.Point(171, 80);
            this.lblCognSom.Name = "lblCognSom";
            this.lblCognSom.Size = new System.Drawing.Size(63, 15);
            this.lblCognSom.TabIndex = 4;
            this.lblCognSom.Text = "Cognome:";
            // 
            // lblDataSom
            // 
            this.lblDataSom.AutoSize = true;
            this.lblDataSom.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSom.Location = new System.Drawing.Point(171, 123);
            this.lblDataSom.Name = "lblDataSom";
            this.lblDataSom.Size = new System.Drawing.Size(85, 15);
            this.lblDataSom.TabIndex = 5;
            this.lblDataSom.Text = "Data di nascita";
            // 
            // lblLuogNascSom
            // 
            this.lblLuogNascSom.AutoSize = true;
            this.lblLuogNascSom.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuogNascSom.Location = new System.Drawing.Point(171, 168);
            this.lblLuogNascSom.Name = "lblLuogNascSom";
            this.lblLuogNascSom.Size = new System.Drawing.Size(97, 15);
            this.lblLuogNascSom.TabIndex = 6;
            this.lblLuogNascSom.Text = "Luogo di nascita:";
            // 
            // txbNomeSom
            // 
            this.txbNomeSom.Location = new System.Drawing.Point(298, 41);
            this.txbNomeSom.Name = "txbNomeSom";
            this.txbNomeSom.ReadOnly = true;
            this.txbNomeSom.Size = new System.Drawing.Size(100, 20);
            this.txbNomeSom.TabIndex = 7;
            this.txbNomeSom.Text = "Riccardo";
            // 
            // txtCognSom
            // 
            this.txtCognSom.Location = new System.Drawing.Point(298, 75);
            this.txtCognSom.Name = "txtCognSom";
            this.txtCognSom.ReadOnly = true;
            this.txtCognSom.Size = new System.Drawing.Size(100, 20);
            this.txtCognSom.TabIndex = 8;
            this.txtCognSom.Text = "Somigli";
            // 
            // txbDataSom
            // 
            this.txbDataSom.Location = new System.Drawing.Point(298, 118);
            this.txbDataSom.Name = "txbDataSom";
            this.txbDataSom.ReadOnly = true;
            this.txbDataSom.Size = new System.Drawing.Size(100, 20);
            this.txbDataSom.TabIndex = 10;
            this.txbDataSom.Text = "17/08/1997";
            // 
            // txtLuogNascSom
            // 
            this.txtLuogNascSom.Location = new System.Drawing.Point(298, 166);
            this.txtLuogNascSom.Name = "txtLuogNascSom";
            this.txtLuogNascSom.ReadOnly = true;
            this.txtLuogNascSom.Size = new System.Drawing.Size(100, 20);
            this.txtLuogNascSom.TabIndex = 11;
            this.txtLuogNascSom.Text = "Bagno a Ripoli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Progetto5B.Properties.Resources.Somigli;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormSomigli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 230);
            this.Controls.Add(this.txtLuogNascSom);
            this.Controls.Add(this.txbDataSom);
            this.Controls.Add(this.txtCognSom);
            this.Controls.Add(this.txbNomeSom);
            this.Controls.Add(this.lblLuogNascSom);
            this.Controls.Add(this.lblDataSom);
            this.Controls.Add(this.lblCognSom);
            this.Controls.Add(this.lblNomSom);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSomigli";
            this.Text = "FormSomigli";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomSom;
        private System.Windows.Forms.Label lblCognSom;
        private System.Windows.Forms.Label lblDataSom;
        private System.Windows.Forms.Label lblLuogNascSom;
        private System.Windows.Forms.TextBox txbNomeSom;
        private System.Windows.Forms.TextBox txtCognSom;
        private System.Windows.Forms.TextBox txbDataSom;
        private System.Windows.Forms.TextBox txtLuogNascSom;
    }
}