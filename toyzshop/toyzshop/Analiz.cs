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
    public partial class Analiz : Form
    {
        public Analiz()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();
        private void Analiz_Load(object sender, EventArgs e)
        {
            label2.Text = (from x in db.SatilanUrun orderby x.Stok descending select x.UrunAd).FirstOrDefault();
            label3.Text = (from x in db.SatilanUrun orderby x.Stok ascending select x.UrunAd).FirstOrDefault();
            label5.Text = (from x in db.SatilanUrun orderby x.İslem descending select x.UrunAd).FirstOrDefault();
            label7.Text = (from x in db.SatilanUrun orderby x.İslem ascending select x.UrunAd).FirstOrDefault();
            label9.Text = (from x in db.SatilanUrun orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();
            label11.Text = (from x in db.SatilanUrun orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();
            label13.Text = (from x in db.AlinanUrun orderby x.AlınanFiyat descending select x.UrunAd).FirstOrDefault();
            label15.Text = (from x in db.AlinanUrun orderby x.AlınanFiyat ascending select x.UrunAd).FirstOrDefault();
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Yonetici fr = new Yonetici();
            fr.Show();
            this.Hide();
        }
    }
}
