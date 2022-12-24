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
    public partial class FormPoz : Form
    {
        public FormPoz()
        {
            InitializeComponent();
        }

        private void FormPoz_Load(object sender, EventArgs e)
        {
            lblCevap.Text = "";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);
            if (sayi > 0)
            {
                lblCevap.Text = "Girilen Sayı Pozitiftir.";
            }
            else if (sayi < 0)
            {
                lblCevap.Text = "Girilen Sayı Negatiftir.";
            }
            else
            {
                lblCevap.Text = "Girilen Sayı Nötrdür.";
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormAna formDonus = new FormAna();
            formDonus.Show();
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSayi.Text = "";
            lblCevap.Text = "";
        }
    }
}
