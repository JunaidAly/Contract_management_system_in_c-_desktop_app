using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Add_Work_Form : Form
    {
        string ConString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Junaid Ali\Documents\Project_DB.mdf;Integrated Security=True;Connect Timeout=30";
        public Add_Work_Form()
        {
            InitializeComponent();
        }

        private void Btn_Add_work_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection con = new SqlConnection(ConString);
                int ID = int.Parse(TS_number.Text);
                string location = Location.Text;
                string workTitle = worktitle.Text;
                string TSAmount = TS_amount.Text;
                string worktype = work_type.Text;



                string query = String.Format("INSERT INTO Add_Work Values" +
                    "({0}, '{1}','{2}','{3}','{4}')", ID, TSAmount, workTitle, worktype, location);

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                TS_number.Text = "";

                TS_amount.Text = "";

                worktitle.Text = "";

                work_type.Text = "";

                Location.Text = "";

                con.Close();

                showData();
            
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured OR 1st Fill the Form");
            }
        }

        public void showData()
        {
            SqlConnection con = new SqlConnection(ConString);

            con.Open();

            string query = "SELECT * FROM Add_Work";


            SqlCommand cmdAdapter = new SqlCommand(query, con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdAdapter);



            System.Data.DataTable dt = new System.Data.DataTable();


            adapter.Fill(dt);

            Add_Data_Grid.DataSource = dt;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Menu page = new Menu();
            page.Show();
            this.Close();
        }

        private void Btn_show_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);

                int ID = Convert.ToInt32(TS_number.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Add_Work SET  TS_Amount ='" + TS_amount.Text + "', Work_Title='" + worktitle.Text + "',Work_Type='" + work_type.Text + "',Location='" + Location.Text + "'WHERE TS_Number='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                showData();
            }


            catch (Exception)
            {
                MessageBox.Show("An Error Occured OR 1st Fill the Form");
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try{
                int ID = Convert.ToInt32(TS_number.Text);
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE  FROM Add_Work WHERE TS_Number='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is Successfully Deleted");
                con.Close();
                showData();

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured or 1st Enter the ID");
            }
        }
    }
}
