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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        public string ad;
        
        dataveriEntities3 db = new dataveriEntities3();

        private void button3_Click(object sender, EventArgs e)
        {
            BilgiGuncelle fr = new BilgiGuncelle();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UrunIslemleri fr = new UrunIslemleri();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokPersonel fr = new StokPersonel();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Giris fr = new Giris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Satis fr = new Satis();
            fr.Show();
            this.Hide();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            label3.Text = ad;
            dataGridView1.DataSource = (from x in db.Duyuru
                                        select new
                                        {
                                            x.Duyuru1
                                            
                                        }).ToList();
            
        }
    }
}
