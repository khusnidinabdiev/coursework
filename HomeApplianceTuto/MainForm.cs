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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddProduct AddProd = new AddProduct();
            AddProd.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ViewStock ViewS = new ViewStock();
            ViewS.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Selling main = new Selling();
            main.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Location main = new Location();
            main.Show();
            this.Hide();
        }
    }
}
