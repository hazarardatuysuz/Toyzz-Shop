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
    public partial class UrunGncl : Form
    {
        public UrunGncl()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunIslemleri fr = new UrunIslemleri();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlinanUrnGncl fr = new AlinanUrnGncl();
            fr.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SatilanUrnGncl fr = new SatilanUrnGncl();
            fr.Show();
            this.Hide();
        }
    }
}
