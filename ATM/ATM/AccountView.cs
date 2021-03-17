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
    public partial class AccountView : Form
    {
        public AccountView(string strTextBox)
        {
            InitializeComponent();
            CustomerLabel.Text = strTextBox;
        }

        private void btn_checking_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckingForm fm = new CheckingForm(CustomerLabel.Text);
            fm.Show();
        }

        private void btn_savings_Click(object sender, EventArgs e)
        {
            this.Hide();
            SavingsForm fm = new SavingsForm(CustomerLabel.Text);
            fm.Show();
        }

        private void AccountView_Load(object sender, EventArgs e)
        {
            UpdateBox();
        }

        public void UpdateBox()
        {
            listBox1.Items.Clear();
            int sNum = SQLHelper.getsavenumber(Convert.ToInt32(CustomerLabel.Text));
            int cNum = SQLHelper.getchecknumber(Convert.ToInt32(CustomerLabel.Text));
            string Update = SQLHelper.Update(sNum, cNum);
            string filler = String.Format("{0,1} {1,18}", "Checking", "Savings");
            listBox1.Items.Add(filler);
            listBox1.Items.Add(Update);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fm = new Login();
            fm.Show();
        }
    }
}
