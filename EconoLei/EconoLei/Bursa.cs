using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconoLei
{
    public partial class Bursa : Form
    {
        public Bursa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bvb z = new bvb();
            z.ShowDialog();
        }
    }
}
