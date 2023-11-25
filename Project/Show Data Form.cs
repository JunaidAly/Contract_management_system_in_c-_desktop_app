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

namespace Project
{
    public partial class Show_Data : Form
    {
        string ConString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Junaid Ali\Documents\Project_DB.mdf;Integrated Security=True;Connect Timeout=30";
        public Show_Data()
        {
            InitializeComponent();
        }

        private void Btn_showdata_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);

            con.Open();

            string query = "SELECT * FROM Details";


            SqlCommand cmdAdapter = new SqlCommand(query, con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdAdapter);



            System.Data.DataTable dt = new System.Data.DataTable();


            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Menu page = new Menu();
            page.Show();
            this.Close();
        }
    }
}
