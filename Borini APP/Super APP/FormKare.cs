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
    public partial class FormKare : Form
    {
        public FormKare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);
            lblCevap.Text = Convert.ToString(sayi * sayi);

        }
        private void FormKare_Load(object sender, EventArgs e)
        {
            lblCevap.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSayi.Text = "";
            lblCevap.Text = "";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {

            FormAna formDonus = new FormAna();
            formDonus.Show();
            this.Hide();
        }
    }
}
