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
    public partial class StokTakip : Form
    {
        public StokTakip()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.SatilanUrun
                                        select new
                                        {
                                            x.UrunID,
                                            x.UrunAd,
                                            x.UrunKategori,
                                            x.Stok

                                        }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var deger = db.SatilanUrun.Where(x => x.Stok < 50);
            dataGridView1.DataSource = deger.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var deger = db.SatilanUrun.Where(x => x.Stok > 100);
            dataGridView1.DataSource = deger.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Yonetici fr = new Yonetici();
            fr.Show();
            this.Hide();
        }
    }
}
