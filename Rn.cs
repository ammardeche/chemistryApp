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
    public partial class Rn : Form
    {
        public Rn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n;
            double z;

            bool IsValidn = double.TryParse(nbox.Text , out n);
            bool IsValidz = double.TryParse(zbox.Text , out z);
            bool isvalid = IsValidn && IsValidz;

            if (isvalid is true)
            {
                var result = chem.rn(z, n);
                rnbox.Text = " Rn = " + result.ToString() + " Å ";
            }
            else {
                MessageBox.Show("Désolé, veuillez entrer une valeur numérique"); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
