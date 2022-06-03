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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();
        private void button3_Click(object sender, EventArgs e)
        {
            BilgiGuncelleYonetim fr = new BilgiGuncelleYonetim();
            fr.Show();
            this.Hide();
        }
        public string ad1;
        public string id1;
        public string sif;

        private void button2_Click(object sender, EventArgs e)
        {
            Personelİslemleri fr = new Personelİslemleri();
            fr.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
         
            if (richTextBox1.Text=="")
            {
                errorProvider1.SetError(richTextBox1,"Burası boş bırakılamaz");
            }
            else
            {
                Duyuru t = new Duyuru();
                t.Duyuru1 = richTextBox1.Text;
                db.Duyuru.Add(t);
                db.SaveChanges();
                MessageBox.Show("Duyuru sisteme kayıt edildi.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Duyurular fr = new Duyurular();
            fr.Show();
            this.Hide();
        }

        private void Yonetici_Load(object sender, EventArgs e)
        {
            label3.Text = ad1;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokTakip fr = new StokTakip();
            fr.Show();
            this.Hide();
            string uyar;
            uyar = (from x in db.SatilanUrun orderby x.Stok ascending select x.UrunAd).FirstOrDefault();
            MessageBox.Show(uyar + " adlı ürünün stoğu çok azaldıı !!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Analiz fr = new Analiz();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Giris fr = new Giris();
            fr.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
