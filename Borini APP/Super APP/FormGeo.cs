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
    public partial class FormGeo : Form
    {
        public FormGeo()
        {
            InitializeComponent();
        }

       

        private void FormGeo_Load(object sender, EventArgs e)
        {
            lblDCevap.Text = "";
            lblDikCevap.Text = "";
            lblKCevap.Text = "";
            lblPC.Text = "";
        }

        private void btnDaire_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(txtDaire.Text);
            double sonuc = r * r * 3.14;
            lblDCevap.Text = sonuc.ToString();
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            int kenar = Convert.ToInt32(txtKare.Text);
            int sonuc = kenar * kenar;
            lblKCevap.Text = sonuc.ToString();
        }
        private void btnParalel_Click_1(object sender, EventArgs e)
        {
            int taban = Convert.ToInt32(txtTaban.Text);
            int yukseklik = Convert.ToInt32(txtYukseklik.Text);
            int sonuc = taban * yukseklik;
            lblPC.Text= sonuc.ToString();

        }

        private void btnDikHesapla_Click_1(object sender, EventArgs e)
        {
            int kenar1 = Convert.ToInt32(txt1kenar.Text);
            int kenar2 = Convert.ToInt32(txt2kenar.Text);
            int sonuc = kenar1* kenar2;
            lblDikCevap.Text = sonuc.ToString();
        }

        private void btnTemizle1_Click(object sender, EventArgs e)
        {
            txtDaire.Text = "";
            lblDCevap.Text = "";
        }

        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            txtKare.Text = "";
            lblKCevap.Text = "";
        }

        private void btnTemizle3_Click(object sender, EventArgs e)
        {
            txt1kenar.Text = "";
            txt2kenar.Text = "";
            lblDikCevap.Text = "";

        }

        private void btnTemizle4_Click(object sender, EventArgs e)
        {
            txtTaban.Text = "";
            txtYukseklik.Text = "";
            lblPC.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDaire.Text = "";
            lblDCevap.Text = "";
            txtKare.Text = "";
            lblKCevap.Text = "";
            txt1kenar.Text = "";
            txt2kenar.Text = "";
            lblDikCevap.Text = "";
            txtTaban.Text = "";
            txtYukseklik.Text = "";
            lblPC.Text = "";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormAna formDonus = new FormAna();
            formDonus.Show();
            this.Hide();
        }
    }
}
