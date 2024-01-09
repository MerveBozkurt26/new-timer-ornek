using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace time_ornek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sayac = 0;
            
        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString(@"U");
            
        }
    }
}
