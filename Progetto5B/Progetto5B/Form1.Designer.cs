namespace Progetto5B
{
    partial class FormPrincip
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNerucci = new System.Windows.Forms.Button();
            this.btnGarcia = new System.Windows.Forms.Button();
            this.btnSomigli = new System.Windows.Forms.Button();
            this.btnCini = new System.Windows.Forms.Button();
            this.lblPresentazione = new System.Windows.Forms.Label();
            this.btnVannozzi = new System.Windows.Forms.Button();
            this.btnDangelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNerucci
            // 
            this.btnNerucci.Location = new System.Drawing.Point(12, 63);
            this.btnNerucci.Name = "btnNerucci";
            this.btnNerucci.Size = new System.Drawing.Size(118, 23);
            this.btnNerucci.TabIndex = 0;
            this.btnNerucci.Text = "Visualizza Nerucci";
            this.btnNerucci.UseVisualStyleBackColor = true;
            this.btnNerucci.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNerucci_MouseClick);
            // 
            // btnGarcia
            // 
            this.btnGarcia.Location = new System.Drawing.Point(12, 106);
            this.btnGarcia.Name = "btnGarcia";
            this.btnGarcia.Size = new System.Drawing.Size(118, 23);
            this.btnGarcia.TabIndex = 1;
            this.btnGarcia.Text = "Visualizza Garcia";
            this.btnGarcia.UseVisualStyleBackColor = true;
            this.btnGarcia.Click += new System.EventHandler(this.btnGarcia_Click);
            // 
            // btnSomigli
            // 
            this.btnSomigli.Location = new System.Drawing.Point(12, 147);
            this.btnSomigli.Name = "btnSomigli";
            this.btnSomigli.Size = new System.Drawing.Size(118, 23);
            this.btnSomigli.TabIndex = 2;
            this.btnSomigli.Text = "Visualizza Somigli";
            this.btnSomigli.UseVisualStyleBackColor = true;
            this.btnSomigli.Click += new System.EventHandler(this.btnSomigli_Click);
            // 
            // btnCini
            // 
            this.btnCini.Location = new System.Drawing.Point(12, 188);
            this.btnCini.Name = "btnCini";
            this.btnCini.Size = new System.Drawing.Size(118, 23);
            this.btnCini.TabIndex = 3;
            this.btnCini.Text = "Visualizza Cini";
            this.btnCini.UseVisualStyleBackColor = true;
            this.btnCini.Click += new System.EventHandler(this.btnCini_Click);
            // 
            // lblPresentazione
            // 
            this.lblPresentazione.AutoSize = true;
            this.lblPresentazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentazione.Location = new System.Drawing.Point(72, 9);
            this.lblPresentazione.Name = "lblPresentazione";
            this.lblPresentazione.Size = new System.Drawing.Size(319, 33);
            this.lblPresentazione.TabIndex = 3;
            this.lblPresentazione.Text = "Presentazione Classe";
            // 
            // btnVannozzi
            // 
            this.btnVannozzi.Location = new System.Drawing.Point(12, 231);
            this.btnVannozzi.Name = "btnVannozzi";
            this.btnVannozzi.Size = new System.Drawing.Size(118, 23);
            this.btnVannozzi.TabIndex = 4;
            this.btnVannozzi.Text = "Visualizza Vannozzi";
            this.btnVannozzi.UseVisualStyleBackColor = true;
            this.btnVannozzi.Click += new System.EventHandler(this.btnVannozzi_Click);
            // 
            // btnDangelo
            // 
            this.btnDangelo.Location = new System.Drawing.Point(12, 271);
            this.btnDangelo.Name = "btnDangelo";
            this.btnDangelo.Size = new System.Drawing.Size(118, 23);
            this.btnDangelo.TabIndex = 5;
            this.btnDangelo.Text = "Visualizza D\'Angelo";
            this.btnDangelo.UseVisualStyleBackColor = true;
            this.btnDangelo.Click += new System.EventHandler(this.btnDangelo_Click);
            // 
            // FormPrincip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 355);
            this.Controls.Add(this.btnDangelo);
            this.Controls.Add(this.btnVannozzi);
            this.Controls.Add(this.btnCini);
            this.Controls.Add(this.lblPresentazione);
            this.Controls.Add(this.btnSomigli);
            this.Controls.Add(this.btnGarcia);
            this.Controls.Add(this.btnNerucci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentazione ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNerucci;
        private System.Windows.Forms.Button btnGarcia;
        private System.Windows.Forms.Button btnSomigli;
        private System.Windows.Forms.Button btnCini;
        private System.Windows.Forms.Label lblPresentazione;
        private System.Windows.Forms.Button btnVannozzi;
        private System.Windows.Forms.Button btnDangelo;
    }
}

