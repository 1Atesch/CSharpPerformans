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
    public partial class FormYuzde : Form
    {
        public FormYuzde()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            lblCevap.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txt1.Text);
            double yuzde = Convert.ToInt32(txt2.Text);
            double sayininYuzdesi = sayi * yuzde / 100;
            lblCevap.Text = Convert.ToString(sayininYuzdesi);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormAna formDonus = new FormAna();
            formDonus.Show();
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
        }
    }
}
