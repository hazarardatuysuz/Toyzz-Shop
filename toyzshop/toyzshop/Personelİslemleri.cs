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
    public partial class Personelİslemleri : Form
    {
        public Personelİslemleri()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();


        private void button2_Click(object sender, EventArgs e)
        {
            PersonelEkle fr = new PersonelEkle();
            fr.Show();
            this.Hide();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Kullanici.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelGncl fr = new PersonelGncl();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Yonetici fr = new Yonetici();
            fr.Show();
            this.Hide();
        }
    }
}
