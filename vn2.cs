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
    public partial class vn2 : Form
    {
        public vn2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n;
            double r;

            bool isvalidr = double.TryParse(rbox.Text, out r);
            bool isvalidn = double.TryParse(nbox.Text, out n);
            bool isvalid = isvalidn && isvalidr;

            if (isvalid is true)
            {
                var result = chem.Vn2(n, r);
                vbox.Text = " Vn = " + result.ToString() + " Km/s ";
            }
            else {
                MessageBox.Show("Désolé, veuillez entrer une valeur numérique");
            }
        }

        private void vn2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
