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
    public partial class FormFak : Form
    {
        public FormFak()
        {
            InitializeComponent();
        }

        private void FormFak_Load(object sender, EventArgs e)
        {
            lblCevap.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fakt = 1;
            int sayi = Convert.ToInt32(txtSayi.Text);
            for (int i = 1; i <= sayi; i++)
            {
                fakt *= i;
            }
            lblCevap.Text = fakt.ToString();
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
