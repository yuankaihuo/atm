using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class Form1 : Form
    {
        public String passFileName = "password.txt";
        public int maxTryNum = 3;

        public Form1()
        {
            InitializeComponent();
            string createText = "5100";
            if (!File.Exists(passFileName)){
                File.WriteAllText(passFileName, createText);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passEnter_Click(object sender, EventArgs e)
        {
            String passDefault = File.ReadAllText(passFileName);
            String passInput;
            passInput = passwordBox.Text;
            if (passInput == passDefault)
            {
                passwordBox.Text = "";
                Form2 mainMenu = new Form2();
                mainMenu.Show();
            }
            else
            {
                maxTryNum--;
                if (maxTryNum == 0) {
                    MessageBox.Show("Invalid Password, failed three times, Bye!!!");
                    passwordBox.Text = "";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Password, Try Again, only "+maxTryNum+" opportunities left!");
                    passwordBox.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void passCancel_Click(object sender, EventArgs e)
        {
            String passInput;
            passInput = passwordBox.Text;
            passInput = passInput.Remove(passInput.Length - 1);
            passwordBox.Text = passInput;
        }

        private void passClear_Click(object sender, EventArgs e)
        {
            String passInput = "";
            passwordBox.Text = passInput;
        }

        private void keyOne_Click(object sender, EventArgs e)
        {
            String passInput = passwordBox.Text;
            passwordBox.Text = passInput + "1";
        }

        private void keyTwo_Click(object sender, EventArgs e)
        {
            String passInput = passwordBox.Text;
            passwordBox.Text = passInput + "2";
        }

        private void keyThree_Click(object sender, EventArgs e)
        {
            String passInput = passwordBox.Text;
            passwordBox.Text = passInput + "3";
        }

        private void keyFour_Click(object sender, EventArgs e)
        {
            String passInput = passwordBox.Text;
            passwordBox.Text = passInput + "4";
        }

        private void keyFive_Click(object sender, EventArgs e)
        {
            String passInput = passwordBox.Text;
            passwordBox.Text = passInput + "5";
        }


        private void keySix_Click(object sender, EventArgs e)
        {
            String passInput = passwordBox.Text;
            passwordBox.Text = passInput + "6";
        }

        private void keySeven_Click(object sender, EventArgs e)
        {
            String passInput = passwordBox.Text;
            passwordBox.Text = passInput + "7";
        }

        private void keyEight_Click(object sender, EventArgs e)
        {
            String passInput = passwordBox.Text;
            passwordBox.Text = passInput + "8";
        }

        private void keyNine_Click(object sender, EventArgs e)
        {
            String passInput = passwordBox.Text;
            passwordBox.Text = passInput + "9";
        }

        private void keyZero_Click(object sender, EventArgs e)
        {
            String passInput = passwordBox.Text;
            passwordBox.Text = passInput + "0";
        }
    }
}
