using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto5B
{
    public partial class FormPrincip : Form
    {
        public FormPrincip()
        {
            InitializeComponent();
        }

        private void btnNerucci_MouseClick(object sender, MouseEventArgs e)
        {
            FormNerucci frNerucci = new FormNerucci();
            frNerucci.Show();
        }

        private void btnGarcia_Click(object sender, EventArgs e)
        {
            FormGarcia frGarcia = new FormGarcia();
            frGarcia.Show();
        }

        private void btnSomigli_Click(object sender, EventArgs e)
        {
            FormSomigli FromSomigli = new FormSomigli();
            FromSomigli.Show();
        }

        private void btnCini_Click(object sender, EventArgs e)
        {
            FormCini FrCini = new FormCini();
            FrCini.Show();
        }

        private void btnVannozzi_Click(object sender, EventArgs e)
        {
            FormVannozzi frVannozzi = new FormVannozzi();
            frVannozzi.Show();
        }
    }
}
