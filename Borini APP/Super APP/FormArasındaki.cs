using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_APP
{
    public partial class FormArasındaki : Form
    {
        public FormArasındaki()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int bas=Convert.ToInt32((txtBaslangic).Text);
            int bit = Convert.ToInt32((txtBitis).Text);
            int sonuc=0;
            if (bit>bas)
            {
                int[] sayilar = new int[bit - bas];
                for (int x = 0; x < sayilar.Length; x++)
                {
                    for (int i = bas; i <= bit; i++)
                    {
                        sayilar[x] = i;
                        listBox1.Items.Add(sayilar[x].ToString());
                    }
                    sonuc += sayilar[x];
                }
                lblCevap.Text = Convert.ToString(sonuc);
            }
            else if (bas>bit)
            {
                int[] sayilar = new int[bas-bit];
                for (int x = 0; x < sayilar.Length; x++)
                {
                    for (int i = bit; i < bas; i++)
                    {
                        sayilar[x] = i;
                        listBox1.Items.Add(sayilar[x].ToString());
                    }
                    sonuc += sayilar[x];
                }
                lblCevap.Text = Convert.ToString(sonuc);
            }
        }

        private void FormArasındaki_Load(object sender, EventArgs e)
        {
            lblCevap.Text = "";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormAna formDonus = new FormAna();
            formDonus.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCevap.Text = "";
            listBox1.Items.Clear();
            txtBaslangic.Text = "";
            txtBitis.Text = "";
        }
    }
}
