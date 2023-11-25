using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Project
{
    public partial class Login_Page : Form
    {
       
        string ConString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Junaid Ali\Documents\Project_DB.mdf;Integrated Security=True;Connect Timeout=30";
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConString);
            string query = "SELECT * FROM Login WHERE Email='" + user_text_box.Text.Trim() + "' and password='" + Pass_text_box.Text.Trim() + "'";
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            adp.Fill(data);

            if (data.Rows.Count == 1)
            {
                Menu m = new Menu();
                this.Hide();
                m.Show();

            }
            else
            {
                MessageBox.Show(" Enter Valid username and password");
            }
        }

        private void click_here_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up sign = new Sign_Up();
            this.Hide();
            sign.Show();

        }

       
    }
}
