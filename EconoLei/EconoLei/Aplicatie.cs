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
    public partial class Aplicatie : Form
    {
        int v;
        public int BT,BRD,BCR;
        public Aplicatie(int s,int x,int y,int z)
        {
            InitializeComponent();
            v = s;
            label2.Text = v.ToString();
            radioButton4.Checked = true;
            BT = x;
            BRD = y;
            BCR = z;
            label9.Text = BT.ToString();
            label10.Text = BRD.ToString();
            label11.Text = BCR.ToString();
        }
        private void Aplicatie_Load(object sender, EventArgs e)
        {
            
        }

        
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { BT = v; BRD = 0; BCR = 0; }
            if (radioButton2.Checked) { BT = 0; BRD = v; BCR = 0; }
            if (radioButton3.Checked) { BT = 0; BRD = 0; BCR = v; }
            label9.Text = BT.ToString();
            label10.Text = BRD.ToString();
            label11.Text = BCR.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
