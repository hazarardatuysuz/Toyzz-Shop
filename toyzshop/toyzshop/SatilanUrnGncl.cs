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
    public partial class SatilanUrnGncl : Form
    {
        public SatilanUrnGncl()
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

        private void SatilanUrnGncl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.SatilanUrun.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aranan = textBox5.Text;
            var degerler = from item in db.SatilanUrun
                           where item.UrunAd.Contains(aranan)
                           select new
                           {
                               item.UrunID,
                               item.UrunAd,
                               item.UrunKategori,
                               item.Stok,
                               item.Fiyat,
                               item.İslem
                              
                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();//ürünad
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = db.SatilanUrun.Find(int.Parse(textBox1.Text));
            a.UrunAd = textBox2.Text;
            a.UrunKategori = textBox3.Text;
            a.Stok = int.Parse(textBox4.Text);
            a.Fiyat = float.Parse(textBox6.Text);
            a.İslem = int.Parse(textBox7.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün güncellendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int silinen = Convert.ToInt32(textBox1.Text);
            var ktgr = db.SatilanUrun.Find(silinen);
            db.SatilanUrun.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
        }
    }
}
