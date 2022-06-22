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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        Operations Op = new Operations();
        string query;
        int ProdId;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProdId = Op.count();
                query = "insert into ProductTbl values("+ProdId+",'" + ProdNameTb.Text + "', '" + BrandCb.SelectedItem.ToString() + "', '" + CategoryCb.SelectedItem.ToString() + "', " + ProdQty.Text + ", " + PriceTb.Text + ")";
                Op.insertdata(query);
                ProdNameTb.Text = "";
                ProdQty.Text = "";
                BrandCb.SelectedIndex = -1;
                CategoryCb.SelectedIndex = -1;
                PriceTb.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        private void clear()
        {
            ProdNameTb.Text = "";
            ProdQty.Text = "";
            BrandCb.SelectedIndex = -1;
            CategoryCb.SelectedIndex = -1;
            PriceTb.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
