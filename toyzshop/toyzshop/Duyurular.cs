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
    public partial class Duyurular : Form
    {
        public Duyurular()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();

        private void Duyurular_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Duyuru
                                        select new
                                        {
                                            x.Duyuru1
                                        }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Yonetici fr = new Yonetici();
            fr.Show();
            this.Hide();
        }
    }
}
