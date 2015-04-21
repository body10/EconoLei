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
    public partial class intrebare3 : Form
    {
        public int pct;
        public intrebare3()
        {
            InitializeComponent();
            radioButton4.Checked = true;
        }

        private void intrebare3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { pct = 100; MessageBox.Show("Felicitari, ai obtinut 100 lei"); }
            else MessageBox.Show("Gresit!");
            this.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
