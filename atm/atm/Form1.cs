using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passEnter_Click(object sender, EventArgs e)
        {
            String passInput;
            passInput = passwordBox.Text;
            if (passInput == "5100")
            {
                MessageBox.Show("Valid Password");
            }
            else
            {
                MessageBox.Show("Invalid Password, Try Again");
            }
        }
    }
}
