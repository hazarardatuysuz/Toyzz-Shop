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
    public partial class UrunIslemleri : Form
    {
        public UrunIslemleri()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Personel fr = new Personel();
            fr.Show();
            this.Hide();
        }
        dataveriEntities3 db = new dataveriEntities3();
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.SatilanUrun.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunEkle fr = new UrunEkle();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokPersonel fr = new StokPersonel();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunGncl fr = new UrunGncl();
            fr.Show();
            this.Hide();
        }
    }
}
