namespace Progetto5B
{
    partial class FormDiVincenzo
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
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblLuogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(337, 12);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(100, 20);
            this.txtbNome.TabIndex = 0;
            this.txtbNome.Text = "Marco";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(286, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(337, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Di Vincenzo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(337, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "28/04/1998";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(337, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Firenze";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(269, 41);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 6;
            this.lblCognome.Text = "Cognome";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(243, 67);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(78, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data di nascita";
            // 
            // lblLuogo
            // 
            this.lblLuogo.AutoSize = true;
            this.lblLuogo.Location = new System.Drawing.Point(236, 93);
            this.lblLuogo.Name = "lblLuogo";
            this.lblLuogo.Size = new System.Drawing.Size(85, 13);
            this.lblLuogo.TabIndex = 8;
            this.lblLuogo.Text = "Luogo di nascita";
            // 
            // FormDiVincenzo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 330);
            this.Controls.Add(this.lblLuogo);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtbNome);
            this.Name = "FormDiVincenzo";
            this.Text = "Di_Vincenzo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblLuogo;
    }
}