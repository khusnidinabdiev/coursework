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
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
        }
        Operations Op = new Operations();
        private void GetProduct()
        {
            string myquery = "select * from ProductTbl";
            var ds = Op.populate(myquery);
            ProductDGV.DataSource = ds.Tables[0];
        }
        private void Selling_Load(object sender, EventArgs e)
        {
            GetProduct();
        }
        int oldQty=0, Pid, newQty;
        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdNameTb.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            //ProdQtyTb.Text = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
            ProdPriceTb.Text = ProductDGV.SelectedRows[0].Cells[5].Value.ToString();
            oldQty = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[4].Value.ToString());
            Pid = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[0].Value.ToString());
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;
        int n=0;int GrdTotal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (ProdQtyTb.Text == "" || Convert.ToInt32(ProdQtyTb.Text) > oldQty)
            {
                MessageBox.Show("Not Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(ProdQtyTb.Text) * Convert.ToInt32(ProdPriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV); ;

                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdNameTb;
                newRow.Cells[2].Value = ProdQtyTb;
                newRow.Cells[3].Value = ProdPriceTb;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                AmtLbl.Text = "" + GrdTotal;
            }
            newQty = oldQty - Convert.ToInt32(ProdQtyTb.Text);
            string myquery = "update ProductTbl set ProdQty=" + newQty + " where ID=" + Pid + ";";
            Op.Editdata(myquery);
            GetProduct();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Home Appliance Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(57));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26,40));
            foreach(DataGridViewRow row in BillDGV.Rows)
            {
                prodid=Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = ""+ row.Cells["Column2"].Value;
                prodprice=Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty=Convert.ToInt32(row.Cells["Column4"].Value);
                tottal=Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold),Brushes.Blue, new Point(26,pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold),Brushes.Blue, new Point(45,pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold),Brushes.Blue, new Point(120,pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold),Brushes.Blue, new Point(170,pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold),Brushes.Blue, new Point(235,pos));

            }
            e.Graphics.DrawString("Grand Total: Rs" + GrdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos+50));
            e.Graphics.DrawString("************CSpace************", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos+85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            GrdTotal=0;
            n=0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 85,600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
