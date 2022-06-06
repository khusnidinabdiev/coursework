using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace HomeApplianceTuto
{
    class Operations
    {
        protected OleDbConnection getCon()
        {
            OleDbConnection Con = new OleDbConnection();
            Con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\HomeApplianceDb.accdb";
            return Con;
        }
        public void insertdata(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Product Added Successfully!");
            Con.Close();
        }
        public void Editdata(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Product Updated Successfully!");
            Con.Close();
        }
        public void deleteProd(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Product Deleted Successfully");
            Con.Close();
        }
        public int count()
        {
            OleDbConnection Con = getCon();
            string query = "select * from ProductTbl order by ID";

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = Con;
            Con.Open();
            cmd.CommandText = query;
            OleDbDataReader rdr = cmd.ExecuteReader();
            int id = 0;
            while (rdr.Read())
            {
                id = rdr.GetInt32(0);
            }
            id = id + 1;
            Con.Close();
            return id;
        }
        public DataSet populate(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = Con;
            cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
