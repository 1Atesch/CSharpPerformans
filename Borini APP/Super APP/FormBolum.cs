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
    public partial class FormBolum : Form
    {
        public FormBolum()
        {
            InitializeComponent();
        }

        private void FormBolun_Load(object sender, EventArgs e)
        {
            lblCevap.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtBolunen.Text);
            int sayi2 = Convert.ToInt32(txtBolen.Text);
            if(sayi1%sayi2== 0)
            {
                lblCevap.Text = "Sayı Bölünebilir";
            }
            else
            {
                lblCevap.Text = "Sayı Bölünemez";
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormAna formDonus = new FormAna();
            formDonus.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBolen.Text = "";
            txtBolunen.Text = "";
            lblCevap.Text = "";
        }
    }
}
