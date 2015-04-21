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
    public partial class Cursuri : Form
    {
        public int valoare;
        public Cursuri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dice = rand.Next(1, 5);
            
            switch (dice)
            {
                case 1:
                    intrebare1 i = new intrebare1();
                    i.ShowDialog();
                    valoare = valoare + i.pct;
                    break;
                case 2:
                    intrebare2 j = new intrebare2();
                    j.ShowDialog();
                    valoare = valoare + j.pct;
                    break;
                case 3:
                    intrebare3 t = new intrebare3();
                    t.ShowDialog();
                    valoare = valoare + t.pct;
                    break;
                case 4:
                    intrebare4 u = new intrebare4();
                    u.ShowDialog();
                    valoare = valoare + u.pct; 
                    break;
                case 5:
                    intrebare5 o = new intrebare5();
                    o.ShowDialog();
                    valoare = valoare + o.pct;
                    break;
                case 6:
                    intrebare6 p = new intrebare6();
                    p.ShowDialog();
                    valoare = valoare + p.pct;
                    break;


            }
            
        }

        private void Cursuri_Load(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BNR z = new BNR();
            z.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IntroducereEco z = new IntroducereEco();
            z.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgentiEco z = new AgentiEco();
            z.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Relbanclient z = new Relbanclient();
            z.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bursa z = new Bursa();
            z.ShowDialog();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.URL = null;
        }
    }

}
