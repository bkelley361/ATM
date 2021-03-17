using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class CheckingForm : Form
    {

        public CheckingForm(string strtext)
        {
            InitializeComponent();
            customernumber.Text = strtext;
        }

        private void CheckingForm_Load(object sender, EventArgs e)
        {
            UpdateBox();
        }

        public void UpdateBox()
        {
            listBox1.Items.Clear();
            int sNum = SQLHelper.getsavenumber(Convert.ToInt32(customernumber.Text));
            int cNum = SQLHelper.getchecknumber(Convert.ToInt32(customernumber.Text));
            string Update = SQLHelper.Update(sNum, cNum);
            string filler = String.Format("{0,1} {1,18}", "Checking", "Savings");
            listBox1.Items.Add(filler);
            listBox1.Items.Add(Update);
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            int cNum = SQLHelper.getchecknumber(Convert.ToInt32(customernumber.Text));
            Savings check = new Savings();
            bool ver = check.verify(txt_amount.Text);

            if (ver == false)
            {
                MessageBox.Show("Please enter a number");
                txt_amount.Clear();
            }
            else
            {
                decimal amount = Convert.ToDecimal(txt_amount.Text);
                SQLHelper.Deposit(cNum, amount);
                txt_amount.Clear();
                UpdateBox();
            }
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            int cNum = SQLHelper.getchecknumber(Convert.ToInt32(customernumber.Text));
            int sNum = SQLHelper.getsavenumber(Convert.ToInt32(customernumber.Text));
            Savings check = new Savings();
            bool ver = check.verify(txt_amount.Text);
            if (ver == false)
            {
                MessageBox.Show("Please enter a number");
                txt_amount.Clear();
            }
            else
            {
                decimal amount = Convert.ToDecimal(txt_amount.Text);
                SQLHelper.WithdrawChecking(amount, cNum, sNum);
                txt_amount.Clear();
                UpdateBox();
            }
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            int sNum = SQLHelper.getsavenumber(Convert.ToInt32(customernumber.Text));
            int cNum = SQLHelper.getchecknumber(Convert.ToInt32(customernumber.Text));
            Savings check = new Savings();
            bool ver = check.verify(txt_amount.Text);
            if (ver == false)
            {
                MessageBox.Show("Please enter a number");
                txt_amount.Clear();
            }
            else
            {
                decimal amount = Convert.ToDecimal(txt_amount.Text);
                SQLHelper.Transfer(amount, sNum, cNum);
                txt_amount.Clear();
                UpdateBox();
            }
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountView fm = new AccountView(customernumber.Text);
            fm.Show();
        }

    }
}
