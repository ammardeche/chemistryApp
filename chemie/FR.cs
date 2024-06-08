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
    public partial class FR : Form
    {
        public FR()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                var result = chem.λ(n1, n2, z);
                rbox.Text = " λ = " + result.ToString() + " m ";
            }
            else
            {
                MessageBox.Show("Désolé, veuillez entrer une valeur numérique");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
