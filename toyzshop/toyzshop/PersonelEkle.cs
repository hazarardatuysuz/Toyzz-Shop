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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();

        private void button5_Click(object sender, EventArgs e)
        {
            Personelİslemleri fr = new Personelİslemleri();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanici t = new Kullanici();
            t.KullaniciAdSoyad = textBox10.Text;
            t.KullaniciSifre = textBox9.Text;
            t.KullaniciMaas = int.Parse(textBox8.Text);
            t.IzinGunu = comboBox1.Text;
            db.Kullanici.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel sisteme kayıt edildi.");


        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Kullanici.ToList();
        }
    }
}
