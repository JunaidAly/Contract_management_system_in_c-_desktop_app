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
    public partial class Update_Form : Form
    {
        string ConString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Junaid Ali\Documents\Project_DB.mdf;Integrated Security=True;Connect Timeout=30";
        public Update_Form()
        {
            InitializeComponent();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
          
            
            try
            {
                SqlConnection con = new SqlConnection(ConString);

                int contractor_code = Convert.ToInt32(concode.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Details SET  Full_Name='" + fullname.Text + "',Company_Name='" + companyname.Text + "',Contractor_Category='" + concategory.Text + "',Labour_Force='" + labourforce.Text + "',Recent_Project='" + recentproject.Text + "',Working_Experience='" + workexp.Text + "',PEC_License_Number='" + pecno.Text + "'WHERE Contractor_Code='" + contractor_code + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Show_Data();
            }


            catch(Exception)
            {
                MessageBox.Show("An Error Occured OR 1st Fill the Form");
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

            UpdateDataGridView.DataSource = dt;
        }
            

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Menu page = new Menu();
            page.Show();
            this.Close();
            
            

        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            Show_Data();
        }
    }
}
