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
    public partial class nu : Form
    {
        public nu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double landa;
            bool isvalidl = double.TryParse(lbox.Text, out landa);
            bool isValid = isvalidl;

            if (isValid is true)
            {
                var result = chem.nu(landa);
                nbox.Text = " La Fréquence = " + result.ToString();
            }
            else
                MessageBox.Show("Désolé, veuillez entrer une valeur numérique");
        }
    }
}
