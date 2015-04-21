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
    public partial class Cariera : Form
    {
        int y;
        public int v;
        public Cariera(int s)
        {
            InitializeComponent();
            y = s;
            v = y;
            label2.Text = v.ToString();
        }

        private void Cariera_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked) || (radioButton2.Checked) || (radioButton3.Checked) || (radioButton4.Checked) || (radioButton5.Checked) || (radioButton6.Checked))
            {
                Random rand = new Random();
                int dice = rand.Next(-11, 16);
                if (dice == 0) { v = v; MessageBox.Show("Firma in care ai investit a ramas constanta. Oscilatia la bursa:" + dice.ToString() + ". Noua suma:" + v.ToString(),"Felicitari!"); }
                if (dice > 0) { v = v + (v * dice) / 100; MessageBox.Show("Firma in care ai investit a crescut. Oscilatia la bursa:" + dice.ToString() + ". Noua suma:" + v.ToString(),"Felicitari!"); }
                if (dice < 0) { v = v + ((v * dice) / 100); MessageBox.Show("Firma in care ai investit a decazut. Oscilatia la bursa:" + dice.ToString() + ". Noua suma:" + v.ToString(),"Din pacate"); }
                if (v < 0) v = 0;
                label2.Text = v.ToString();
            }
            else MessageBox.Show("Nu ai ales firma!", "Atentie!");
        }
    }
}
