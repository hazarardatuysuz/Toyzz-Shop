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
    public partial class BilgiGuncelle : Form
    {
        public BilgiGuncelle()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();

        private void button5_Click(object sender, EventArgs e)
        {
            Personel fr = new Personel();
            fr.Show();
            this.Hide();
        }

        private void BilgiGuncelle_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Kullanici
                                        select new
                                        {
                                            x.KullaniciID,
                                            x.KullaniciAdSoyad,
                                            x.KullaniciSifre,

                                        }).ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = db.Kullanici.Find(int.Parse(textBox4.Text));
            a.KullaniciAdSoyad = textBox1.Text;
            a.KullaniciSifre = textBox5.Text;

            db.SaveChanges();
            MessageBox.Show("bilgiler güncellendi");
        }
    }
}
