namespace Progetto5B
{
    partial class FormDuta
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDuta = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txbCognome = new System.Windows.Forms.TextBox();
            this.lblDataNascita = new System.Windows.Forms.Label();
            this.txbDataNascita = new System.Windows.Forms.TextBox();
            this.lblLuogoNAscita = new System.Windows.Forms.Label();
            this.txbLuogoNascita = new System.Windows.Forms.TextBox();
            this.btnChiudi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Progetto5B.Properties.Resources.duta;
            this.pictureBox1.Location = new System.Drawing.Point(21, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 227);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDuta
            // 
            this.lblDuta.AutoSize = true;
            this.lblDuta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuta.Location = new System.Drawing.Point(182, 45);
            this.lblDuta.Name = "lblDuta";
            this.lblDuta.Size = new System.Drawing.Size(45, 15);
            this.lblDuta.TabIndex = 2;
            this.lblDuta.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(300, 40);
            this.txbNome.Name = "txbNome";
            this.txbNome.ReadOnly = true;
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 6;
            this.txbNome.Text = "Adriano";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(182, 89);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(63, 15);
            this.lblCognome.TabIndex = 7;
            this.lblCognome.Text = "Cognome:";
            // 
            // txbCognome
            // 
            this.txbCognome.Location = new System.Drawing.Point(300, 84);
            this.txbCognome.Name = "txbCognome";
            this.txbCognome.ReadOnly = true;
            this.txbCognome.Size = new System.Drawing.Size(100, 20);
            this.txbCognome.TabIndex = 8;
            this.txbCognome.Text = "Duta";
            // 
            // lblDataNascita
            // 
            this.lblDataNascita.AutoSize = true;
            this.lblDataNascita.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascita.Location = new System.Drawing.Point(182, 134);
            this.lblDataNascita.Name = "lblDataNascita";
            this.lblDataNascita.Size = new System.Drawing.Size(89, 15);
            this.lblDataNascita.TabIndex = 9;
            this.lblDataNascita.Text = "Data di nascita:";
            // 
            // txbDataNascita
            // 
            this.txbDataNascita.Location = new System.Drawing.Point(300, 129);
            this.txbDataNascita.Name = "txbDataNascita";
            this.txbDataNascita.ReadOnly = true;
            this.txbDataNascita.Size = new System.Drawing.Size(100, 20);
            this.txbDataNascita.TabIndex = 10;
            this.txbDataNascita.Text = "07/06/1995";
            // 
            // lblLuogoNAscita
            // 
            this.lblLuogoNAscita.AutoSize = true;
            this.lblLuogoNAscita.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuogoNAscita.Location = new System.Drawing.Point(182, 175);
            this.lblLuogoNAscita.Name = "lblLuogoNAscita";
            this.lblLuogoNAscita.Size = new System.Drawing.Size(97, 15);
            this.lblLuogoNAscita.TabIndex = 11;
            this.lblLuogoNAscita.Text = "Luogo di nascita:";
            // 
            // txbLuogoNascita
            // 
            this.txbLuogoNascita.Location = new System.Drawing.Point(300, 170);
            this.txbLuogoNascita.Name = "txbLuogoNascita";
            this.txbLuogoNascita.ReadOnly = true;
            this.txbLuogoNascita.Size = new System.Drawing.Size(100, 20);
            this.txbLuogoNascita.TabIndex = 12;
            this.txbLuogoNascita.Text = "Romania";
            // 
            // btnChiudi
            // 
            this.btnChiudi.Location = new System.Drawing.Point(248, 233);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(75, 23);
            this.btnChiudi.TabIndex = 13;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // FormDuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 310);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.txbLuogoNascita);
            this.Controls.Add(this.lblLuogoNAscita);
            this.Controls.Add(this.txbDataNascita);
            this.Controls.Add(this.lblDataNascita);
            this.Controls.Add(this.txbCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblDuta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormDuta";
            this.Text = "FormDuta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDuta;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txbCognome;
        private System.Windows.Forms.Label lblDataNascita;
        private System.Windows.Forms.TextBox txbDataNascita;
        private System.Windows.Forms.Label lblLuogoNAscita;
        private System.Windows.Forms.TextBox txbLuogoNascita;
        private System.Windows.Forms.Button btnChiudi;
    }
}