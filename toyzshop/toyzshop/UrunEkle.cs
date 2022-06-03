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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();
        private void button5_Click(object sender, EventArgs e)
        {
            UrunIslemleri fr = new UrunIslemleri();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlinanUrun t = new AlinanUrun();
            t.UrunAd = textBox10.Text;
            t.UrunKategori = textBox6.Text;
            t.Sirket1 = double.Parse(textBox9.Text);
            t.Sirket2 = double.Parse(textBox8.Text);
            t.Sirket3 = double.Parse(textBox7.Text);
            t.Sirket4 = double.Parse(textBox11.Text);
            t.AlınanSirket = textBox12.Text;
            t.AlınanFiyat = double.Parse(textBox13.Text);
            db.AlinanUrun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün sisteme kayıt edildi.");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SatilanUrun t = new SatilanUrun();
            t.UrunAd = textBox1.Text;
            t.UrunKategori = textBox5.Text;
            t.Stok = int.Parse(textBox2.Text);
            t.Fiyat =double.Parse(textBox3.Text);
            t.İslem = int.Parse(textBox4.Text);
            db.SatilanUrun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün sisteme kayıt edildi.");
        }

       
    }
}
