using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chemie
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Et et = new Et();
            et.Show(); 
        } 

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AboutMe a = new AboutMe();
            a.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DE1 d = new DE1();
            d.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DE2 d = new DE2();
            d.Show(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FR f = new FR(); 
            f.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rn f = new Rn();
            f.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vn r = new Vn();
            r.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vn2 vn = new vn2();
            vn.Show(); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nu n = new nu();
            n.Show(); 
        }
    }
}
