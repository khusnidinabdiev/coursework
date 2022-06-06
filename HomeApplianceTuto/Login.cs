using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeApplianceTuto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Admin Name and Password");
            }
            else if (UidTb.Text == "Admin" && PasswordTb.Text == "Pass")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Wrong Admin Name or Password");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Selling Sell = new Selling();
            Sell.Show();
            this.Hide();
        }
    }
}
