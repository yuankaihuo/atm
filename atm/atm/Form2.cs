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
    public partial class Form2 : Form
    {
        public String passFileName = "password.txt";
        public String balanceFileName = "balance.txt";

        private String bName;

        private bool InfomationWasClicked = false;
        private bool BalanceWasClicked = false;
        private bool ChangePINWasClicked = false;
        private bool DepositWasClicked = false;
        private bool WithdrawWasClicked = false;
        private bool CashWasClicked = false;
        private bool oldPass1 = false;
        private bool oldPass2 = false;
        private bool newPass1 = false;


        public Form2()
        {
            InitializeComponent();
            string createText = "0";
            if (!File.Exists(balanceFileName))
            {
                File.WriteAllText(balanceFileName, createText);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            label3.Refresh();
            //label1.BackColor = Color.Azure;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            InfomationWasClicked = true;
            BalanceWasClicked = false;
            ChangePINWasClicked = false;
            DepositWasClicked = false;
            WithdrawWasClicked = false;
            CashWasClicked = false;

            label3.Text = "Name:";
            label3.Visible = true;
            label4.Text = "Type:";
            label4.Visible = true;
            label5.Text = "Phone:";
            label5.Visible = true;
            label6.Text = "Address:";
            label6.Visible = true;
            label7.Text = "Ge Liu";
            label7.Visible = true;
            label8.Text = "Checking **** **** **** 1024";
            label8.Visible = true;
            label9.Text = "(201)-519-1111";
            label9.Visible = true;
            label10.Text = "101 Main st, Nashville, TN, 37205";
            label10.Visible = true;

            title.Text = "Account Information:";
            title.Visible = true;

            money.Visible = false;

            oldPassBox1.Visible = false;
            oldPassBox2.Visible = false;
            newPassBox.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            InfomationWasClicked = false;
            BalanceWasClicked = true;
            ChangePINWasClicked = false;
            DepositWasClicked = false;
            WithdrawWasClicked = false;
            CashWasClicked = false;

            label3.Visible = false;
            label7.Visible = false;
            label10.Visible = false;
            label4.Visible = false;
            label8.Visible = false;
            label5.Visible = false;
            label9.Visible = false;
            label6.Visible = false;

            title.Text = "Balance:";
            title.Visible = true;


            String balanceVal = File.ReadAllText(balanceFileName);
            money.Text = balanceVal;
            money.Visible = true;

            oldPassBox1.Visible = false;
            oldPassBox2.Visible = false;
            newPassBox.Visible = false;
        }

        private void money_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            InfomationWasClicked = false;
            BalanceWasClicked = false;
            ChangePINWasClicked = false;
            DepositWasClicked = true;
            WithdrawWasClicked = false;
            CashWasClicked = false;

            label3.Visible = false;
            label7.Visible = false;
            label10.Visible = false;
            label4.Visible = false;
            label8.Visible = false;
            label5.Visible = false;
            label9.Visible = false;
            label6.Visible = false;

            title.Text = "Make Deposit:";
            title.Visible = true;


            money.Text = "";
            money.Visible = true;

            oldPassBox1.Visible = false;
            oldPassBox2.Visible = false;
            newPassBox.Visible = false;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            String balanceVal = File.ReadAllText(balanceFileName);
            int balanceInt = Convert.ToInt32(balanceVal);

            if (balanceInt < 100)
            {
                MessageBox.Show("Withdraw not allow! Balance is less than 100");
            }
            else
            {

                InfomationWasClicked = false;
                BalanceWasClicked = false;
                ChangePINWasClicked = false;
                DepositWasClicked = false;
                WithdrawWasClicked = true;
                CashWasClicked = false;

                label3.Visible = false;
                label7.Visible = false;
                label10.Visible = false;
                label4.Visible = false;
                label8.Visible = false;
                label5.Visible = false;
                label9.Visible = false;
                label6.Visible = false;

                title.Text = "Withdraw Money:";
                title.Visible = true;


                money.Text = "";
                money.Visible = true;
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            String balanceVal = File.ReadAllText(balanceFileName);
            int balanceInt = Convert.ToInt32(balanceVal);

            if (balanceInt < 100)
            {
                MessageBox.Show("Fast CASH not allow! Balance is less than 200");
            }
            else
            {

                InfomationWasClicked = false;
                BalanceWasClicked = false;
                ChangePINWasClicked = false;
                DepositWasClicked = false;
                WithdrawWasClicked = false;
                CashWasClicked = true;

                label3.Visible = false;
                label7.Visible = false;
                label10.Visible = false;
                label4.Visible = false;
                label8.Visible = false;
                label5.Visible = false;
                label9.Visible = false;
                label6.Visible = false;

                title.Text = "Fast CASH:";
                title.Visible = true;


                balanceVal = File.ReadAllText(balanceFileName);
                balanceInt = Convert.ToInt32(balanceVal);

                if (balanceInt < 200)
                {
                    MessageBox.Show("Fast CASH not allow! Balance is less than 200");
                }
                else
                {
                    balanceInt = balanceInt - 100;
                    balanceVal = Convert.ToString(balanceInt);
                    File.WriteAllText(balanceFileName, balanceVal);
                    money.Text = "$ " + 100 + " fast CASH ";
                    money.Visible = true;
                }

                oldPassBox1.Visible = false;
                oldPassBox2.Visible = false;
                newPassBox.Visible = false;
            }
        }

        private void clickNum(String numString)
        {
            if (DepositWasClicked || WithdrawWasClicked)
            {
                String moneyInput = money.Text;
                money.Text = moneyInput + numString;
            }
            if (ChangePINWasClicked)
            {
                if (bName != null)
                {
                    if (bName.Equals("oldPassBox1"))
                    {
                        String passInput = oldPassBox1.Text;
                        oldPassBox1.Text = passInput + numString;
                    }
                    else if (bName.Equals("oldPassBox2"))
                    {
                        String passInput = oldPassBox2.Text;
                        oldPassBox2.Text = passInput + numString;
                    }
                    else if (bName.Equals("newPassBox"))
                    {
                        String passInput = newPassBox.Text;
                        newPassBox.Text = passInput + numString;
                    }
                }
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.clickNum("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.clickNum("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.clickNum("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.clickNum("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.clickNum("5");
        }


        private void btnSix_Click(object sender, EventArgs e)
        {
            this.clickNum("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.clickNum("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.clickNum("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.clickNum("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            this.clickNum("0");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (DepositWasClicked || WithdrawWasClicked)
            {
                String moneyInput = "";
                money.Text = moneyInput;
            }
            if (ChangePINWasClicked)
            {
                if (bName != null)
                {
                    if (bName.Equals("oldPassBox1"))
                    {
                        oldPassBox1.Text = "";
                    }
                    else if (bName.Equals("oldPassBox2"))
                    {
                        oldPassBox2.Text = "";
                    }
                    else if (bName.Equals("newPassBox"))
                    {
                        newPassBox.Text = "";
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (DepositWasClicked || WithdrawWasClicked)
            {
                String moneyInput;
                moneyInput = money.Text;
                moneyInput = moneyInput.Remove(moneyInput.Length - 1);
                money.Text = moneyInput;
            }
            if (ChangePINWasClicked)
            {
                if (bName != null)
                {
                    if (bName.Equals("oldPassBox1"))
                    {
                        String passInput = oldPassBox1.Text;
                        passInput = passInput.Remove(passInput.Length - 1);
                        oldPassBox1.Text = passInput;
                    }
                    else if (bName.Equals("oldPassBox2"))
                    {
                        String passInput = oldPassBox2.Text;
                        passInput = passInput.Remove(passInput.Length - 1);
                        oldPassBox2.Text = passInput;
                    }
                    else if (bName.Equals("newPassBox"))
                    {
                        String passInput = newPassBox.Text;
                        passInput = passInput.Remove(passInput.Length - 1);
                        newPassBox.Text = passInput;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (DepositWasClicked)
            {
                int moneyDeposit = Convert.ToInt32(money.Text);
                if (moneyDeposit > 1000)
                {
                    MessageBox.Show("Maximum Deposit is 1000");
                }
                else
                {
                    String balanceVal = File.ReadAllText(balanceFileName);
                    int balanceInt = Convert.ToInt32(balanceVal);
                    balanceInt = balanceInt + moneyDeposit;
                    balanceVal = Convert.ToString(balanceInt);
                    File.WriteAllText(balanceFileName, balanceVal);
                    money.Text = "$ " + moneyDeposit + " saved ";
                }
            }

            if (WithdrawWasClicked)
            {
                int moneyWithdraw = Convert.ToInt32(money.Text);
                String balanceVal = File.ReadAllText(balanceFileName);
                int balanceInt = Convert.ToInt32(balanceVal);

                if (balanceInt < 100)
                {
                    MessageBox.Show("Withdraw not allow! Balance is less than 100");
                }
                else
                {
                    if (moneyWithdraw > balanceInt)
                    {
                        MessageBox.Show("Withdraw larger than balance, not allow!");
                    }
                    else
                    {
                        balanceInt = balanceInt - moneyWithdraw;
                        balanceVal = Convert.ToString(balanceInt);
                        File.WriteAllText(balanceFileName, balanceVal);
                        money.Text = "$ " + moneyWithdraw + " withdrawed ";
                    }
                }
            }

            if (ChangePINWasClicked)
            {
                String oldPass1Input = oldPassBox1.Text;
                String oldPass2Input = oldPassBox2.Text;
                String newPassInput = newPassBox.Text;
                if (oldPass1Input.Length == 0 || oldPass2Input.Length == 0 || newPassInput.Length == 0)
                {
                    MessageBox.Show("Fields cannot be empty!");
                }
                else
                {
                    if (oldPass1Input.Equals(oldPass2Input))
                    {
                        String passDefault = File.ReadAllText(passFileName);
                        if (oldPass1Input.Equals(passDefault))
                        {
                            File.WriteAllText(passFileName, newPassInput);
                            MessageBox.Show("PIN has been changed successfully!");
                        }else
                        {
                            MessageBox.Show("Old PIN is not correct!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Old PINs are not match!");
                    }
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            InfomationWasClicked = false;
            BalanceWasClicked = false;
            ChangePINWasClicked = true;
            DepositWasClicked = false;
            WithdrawWasClicked = false;
            CashWasClicked = false;

            label3.Text = "Type in Old Pass:";
            label3.Visible = true;
            label4.Text = "Repeat Old Pass:";
            label4.Visible = true;
            label5.Text = "Type in New Pass:";
            label5.Visible = true;
            label6.Visible = false;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

            title.Text = "Withdraw Money:";
            title.Visible = true;


            money.Text = "";
            money.Visible = true;

            oldPassBox1.Visible = true;
            oldPassBox2.Visible = true;
            newPassBox.Visible = true;
        }

        private void oldPassBox1_TextChanged(object sender, EventArgs e)
        {
            if (ChangePINWasClicked)
            {
               bName = ((TextBox)sender).Name;
            }
        }

        private void oldPassBox2_TextChanged(object sender, EventArgs e)
        {
            if (ChangePINWasClicked)
            {
               bName = ((TextBox)sender).Name;
            }
        }

        private void newPassBox_TextChanged(object sender, EventArgs e)
        {
            if (ChangePINWasClicked)
            {
                bName = ((TextBox)sender).Name;
            }
        }

        private void oldPassBox1_Click(object sender, EventArgs e)
        {
            if (ChangePINWasClicked)
            {
                bName = ((TextBox)sender).Name;
            }
        }

        private void oldPassBox2_Click(object sender, EventArgs e)
        {
            if (ChangePINWasClicked)
            {
                bName = ((TextBox)sender).Name;
            }
        }

        private void newPassBox_Click(object sender, EventArgs e)
        {
            if (ChangePINWasClicked)
            {
                bName = ((TextBox)sender).Name;
            }
        }
    }
}
