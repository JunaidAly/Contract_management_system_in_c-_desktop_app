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
    public partial class Contract_Details : Form
    {
        string ConString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Junaid Ali\Documents\Project_DB.mdf;Integrated Security=True;Connect Timeout=30";
        public Contract_Details()
        {
            InitializeComponent();
        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);
            if (fullnametxt.Text.Equals("") || companynametxt.Text.Equals("") || concodetxt.Text.Equals("") || labourforcetxt.Text.Equals("") || recentprojecttxt.Text.Equals("") || workexptxt.Text.Equals("") || pecnotxt.Text.Equals("") || concategorytxt.Text.Equals(""))
            {
                MessageBox.Show("1st Fill the Form");
            }
            else
            {
                int contractorcode = int.Parse(concodetxt.Text);
                string fullname = fullnametxt.Text;
                string comname = companynametxt.Text;
                string contractcategory = concategorytxt.Text;
                string labourforce = labourforcetxt.Text;
                string recentproject = recentprojecttxt.Text;
                string workingexp = workexptxt.Text;
                string pec = pecnotxt.Text;



                string query = String.Format("INSERT INTO Details Values" +
                    "({0}, '{1}','{2}','{3}','{4}','{5}','{6}','{7}')", contractorcode, fullname, comname, contractcategory, labourforce, recentproject, workingexp, pec);

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                concodetxt.Text = "";

                fullnametxt.Text = "";

                companynametxt.Text = "";

                concategorytxt.Text = "";

                labourforcetxt.Text = "";

                recentprojecttxt.Text = "";

                workexptxt.Text = "";

                pecnotxt.Text = "";

                con.Close();

            }

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Menu page = new Menu();
            page.Show();
            this.Close();
        }

        private void pecnotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void concodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void workexptxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void recentprojecttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void labourforcetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void concategorytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void companynametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
