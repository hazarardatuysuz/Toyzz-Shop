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
    public partial class BilgiGuncelleYonetim : Form
    {
        public BilgiGuncelleYonetim()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();

        private void button5_Click(object sender, EventArgs e)
        {
            Yonetici fr = new Yonetici();
            fr.Show();
            this.Hide();
        }

        private void BilgiGuncelleYonetim_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.KullaniciYntm
                                        select new
                                        {
                                            x.KullaniciID,
                                            x.AdSoyad,
                                            x.Sifre,

                                        }).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var a = db.KullaniciYntm.Find(int.Parse(textBox4.Text));
            a.AdSoyad = textBox1.Text;
            a.Sifre = textBox5.Text;
            
            db.SaveChanges();
            MessageBox.Show("bilgiler güncellendi");



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }
    }
}
