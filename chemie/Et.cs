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
    public partial class Et : Form
    {
        public Et()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n;
            double z;

            bool isvalidn = double.TryParse(nbox.Text, out n);
            bool isvalidz = double.TryParse(zbox.Text, out z);
            bool isValid = isvalidn && isvalidz;

            if (isValid is true)
            {
                var result = chem.ET(n, z);
                rbox.Text = " Et = En = " + result.ToString() + " ev ";
            }
            else {
                MessageBox.Show("Désolé, veuillez entrer une valeur numérique");
            }
        }

        private void Et_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
