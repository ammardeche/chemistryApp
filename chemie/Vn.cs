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
    public partial class Vn : Form
    {
        public Vn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n;

            bool isValidn = double.TryParse(nbox.Text, out n);
            bool isValid = isValidn;

            if (isValid is true)
            {
                var result = chem.Vn(n);
                vbox.Text = " Vn = " + result.ToString() + " m/s ";
            }
            else
                MessageBox.Show("Désolé, veuillez entrer une valeur numérique");
        }
    }
}
