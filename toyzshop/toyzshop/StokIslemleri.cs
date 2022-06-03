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
    public partial class StokIslemleri : Form
    {
      
        
        public StokIslemleri()
        {
            InitializeComponent();
        }
        dataveriEntities3 db = new dataveriEntities3();

        private void StokIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.SatilanUrun
                                        select new
                                        {
                                            x.UrunAd,
                                            x.UrunID,
                                            x.UrunKategori,

                                        }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
