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
        public partial class Form1 : Form
        {
            int s = 0, x, y, z;
            public Form1()
            {
                InitializeComponent();
            }
            
            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Pentru suport, trimiteți email la una din adresele: deeadeiutza66@yahoo.com sau body11gna@yahoo.com; Mulțumim pentru interesul acordat!", "Suport");

            }

            private void button3_Click(object sender, EventArgs e)
            {
                Cursuri i = new Cursuri();
                i.ShowDialog();
                s=s+i.valoare;
            }

            private void button4_Click(object sender, EventArgs e)
            {
                Aplicatie j = new Aplicatie(s,x,y,z);
                j.ShowDialog();
                x = j.BT;
                y = j.BRD;
                z = j.BCR;
            }

            private void button5_Click(object sender, EventArgs e)
            {
                Cariera t = new Cariera(s);
                t.ShowDialog();
                s = t.v;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                video k = new video();
                k.ShowDialog();
            }
        }
}
