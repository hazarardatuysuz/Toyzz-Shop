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
    public partial class PersonelGncl : Form
    {
        public PersonelGncl()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();

        private void PersonelGncl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Kullanici.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aranan = textBox5.Text;
            var degerler = from item in db.Kullanici
                           where item.KullaniciAdSoyad.Contains(aranan)
                           select new
                           {
                               item.KullaniciID,
                               item.KullaniciAdSoyad,
                               item.KullaniciSifre,
                               item.KullaniciMaas,
                               item.IzinGunu
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var a = db.Kullanici.Find(int.Parse(textBox1.Text));
            a.KullaniciAdSoyad = textBox2.Text;
            a.KullaniciSifre = textBox3.Text;
            a.KullaniciMaas = int.Parse(textBox4.Text);
            a.IzinGunu = textBox6.Text;
            
            db.SaveChanges();
            MessageBox.Show("Personel güncellendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int silinen = Convert.ToInt32(textBox1.Text);
            var ktgr = db.Kullanici.Find(silinen);
            db.Kullanici.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Personel silindi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Personelİslemleri fr = new Personelİslemleri();
            fr.Show();
            this.Hide();
        }
    }
    }

