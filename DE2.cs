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
    public partial class DE2 : Form
    {
        public DE2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double landa;

            bool isValidlanda = double.TryParse(lbox.Text, out landa);
            bool isvalid = isValidlanda;
            if (isvalid is true)
            {
                var result = chem.ΔE2(landa);
                rbox.Text = " ΔE = " + result.ToString() + " joule ";
            }
            else {
                MessageBox.Show("Désolé, veuillez entrer une valeur numérique");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
