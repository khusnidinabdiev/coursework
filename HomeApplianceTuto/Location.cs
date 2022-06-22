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
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }

        private void Search_data_Click(object sender, EventArgs e)
        {
            string med = txt_med.Text;
            string city = txt_city.Text;
            string state = txt_state.Text;
            try
            {
                StringBuilder queryaddess = new StringBuilder();
                queryaddess.Append("http://maps.google.com/maps?q=");

                if(med!=string.Empty)
                {
                    queryaddess.Append(med + "," + "+");
                }
                if(city!=string.Empty)
                {
                    queryaddess.Append(city+","+"+");
                }
                if(state!=string.Empty)
                {
                    queryaddess.Append(state+","+"+");
                }
                webBrowser1.Navigate(queryaddess.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
