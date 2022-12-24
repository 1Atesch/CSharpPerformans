using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_APP
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

       

        private void btnKare_Click(object sender, EventArgs e)
        {
            FormKare formKareGecis = new FormKare();
            formKareGecis.Show();
            this.Hide();
        }


        private void btnFak_Click(object sender, EventArgs e)
        {
            FormFak formFakGecis = new FormFak();
            formFakGecis.Show();
            this.Hide();
        }

        private void btnBolunme_Click(object sender, EventArgs e)
        {
            FormBolum formBolunmeGecis = new FormBolum();
            formBolunmeGecis.Show();
            this.Hide();
        }

        private void btnYuzde_Click(object sender, EventArgs e)
        {
            FormYuzde formYuzdeGecis = new FormYuzde();
            formYuzdeGecis.Show();
            this.Hide();
        }

        private void btnGeo_Click(object sender, EventArgs e)
        {
            FormGeo formGeogecis = new FormGeo();
            formGeogecis.Show();
            this.Hide();
        }

        private void btnPoz_Click(object sender, EventArgs e)
        {
            FormPoz formPozGecis = new FormPoz();
            formPozGecis.Show();
            this.Hide();
        }

        private void btnArasındaki_Click(object sender, EventArgs e)
        {
            FormArasındaki formPozGecis = new FormArasındaki();
            formPozGecis.Show();
            this.Hide();
        }
    }
}
