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
    public partial class intrebare6 : Form
    {
        public int pct;
        public intrebare6()
        {
            InitializeComponent();
            radioButton5.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) { pct = 100; MessageBox.Show("Felicitari, ai obtinut 100 lei"); }
            else MessageBox.Show("Gresit!");
            this.Close();
        }
    }
}
