using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\benke\source\repos\ATM\ATM\ATM Database.mdf;Integrated Security = True; Connect Timeout = 30";

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txt_Cust.Text == "" || txt_PIN.Text == "")
            {
                MessageBox.Show("Please provide Customer Number and PIN");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from [BankCustomer] where CustomerNumber=@customernumber and PIN=@pin", con);
                cmd.Parameters.AddWithValue("@customernumber", txt_Cust.Text);
                cmd.Parameters.AddWithValue("@pin", txt_PIN.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    AccountView fm = new AccountView(txt_Cust.Text);
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Cust.Clear();
            txt_PIN.Clear();
        }
    }
}
