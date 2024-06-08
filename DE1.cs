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
    public partial class DE1 : Form
    {
        public DE1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double z;

            bool isvalidn1 = double.TryParse(n1box.Text, out n1);
            bool isvalidn2 = double.TryParse(n2box.Text, out n2);
            bool isvalidz = double.TryParse(zbox.Text, out z);
            bool IsValid = isvalidn1 && isvalidn2 && isvalidz;
            if (IsValid == true)
            {
                var result = chem.ΔE1(n1, n2, z);
                rbox.Text = " ΔE = " + result.ToString() + " ev ";
            }
            else {
                MessageBox.Show("Désolé, veuillez entrer une valeur numérique");
            }
        }
    }
}
