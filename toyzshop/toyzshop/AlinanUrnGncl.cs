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
    public partial class AlinanUrnGncl : Form
    {
        public AlinanUrnGncl()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();

        private void button2_Click(object sender, EventArgs e)
        {
            string aranan = textBox5.Text;
            var degerler = from item in db.AlinanUrun
                           where item.UrunAd.Contains(aranan)
                           select new
                           {
                               item.UrunID,
                               item.UrunAd,
                               item.UrunKategori,
                               item.Sirket1,
                               item.Sirket2,
                               item.Sirket3,
                               item.Sirket4,
                               item.AlınanSirket,
                               item.AlınanFiyat
                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void AlinanUrnGncl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.AlinanUrun.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();//ürünad
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();//sirket 4
            textBox9.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            textBox10.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = db.AlinanUrun.Find(int.Parse(textBox1.Text));
            a.UrunAd =textBox2.Text;
            a.UrunKategori = textBox3.Text;
            a.Sirket1 = float.Parse(textBox4.Text);
            a.Sirket2 = float.Parse(textBox6.Text);
            a.Sirket3 = float.Parse(textBox8.Text);
            a.Sirket4 = float.Parse(textBox7.Text);
            a.AlınanSirket = textBox9.Text;
            a.AlınanFiyat = float.Parse(textBox10.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün güncellendi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunIslemleri fr = new UrunIslemleri();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int silinen = Convert.ToInt32(textBox1.Text);
            var ktgr = db.AlinanUrun.Find(silinen);
            db.AlinanUrun.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Ürün silindi");

        }
    }
}
