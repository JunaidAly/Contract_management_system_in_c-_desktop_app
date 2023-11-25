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
    public partial class Delete_Data : Form
    {
      
        string ConString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Junaid Ali\Documents\Project_DB.mdf;Integrated Security=True;Connect Timeout=30";
        public Delete_Data()
        {
            InitializeComponent();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try {

                int Contractor_ID = Convert.ToInt32(Con_id.Text);
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE  from Details WHERE Contractor_Code='" + Contractor_ID + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is Successfully Deleted");
                con.Close();
                Show_Data();

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured or 1st Enter the ID");
            }
          
        }

        public void Show_Data()
        {
            SqlConnection con = new SqlConnection(ConString);

            con.Open();

            string query = "SELECT * FROM Details";


            SqlCommand cmdAdapter = new SqlCommand(query, con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdAdapter);



            System.Data.DataTable dt = new System.Data.DataTable();


            adapter.Fill(dt);

            DaleteDataGridView.DataSource = dt;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Menu page = new Menu();
            page.Show();
            this.Close();
        }

        private void Btn_show_Click(object sender, EventArgs e)
        {
            Show_Data();
        }

       
    }
}
