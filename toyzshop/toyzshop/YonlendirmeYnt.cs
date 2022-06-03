using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toyzshop
{
    public partial class YonlendirmeYnt : Form
    {
        public YonlendirmeYnt()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();
        private void button2_Click(object sender, EventArgs e)
        {
            Giris fr = new Giris();
            fr.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.KullaniciYntm where x.AdSoyad == textBox1.Text && x.Sifre == textBox2.Text  select x;
            if (sorgu.Any())
            {
                Yonetici fr = new Yonetici();
                fr.ad1 = textBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış giriş bilgileri");
            }
        }

        private void YonlendirmeYnt_Load(object sender, EventArgs e)
        {

        }
    }
}
