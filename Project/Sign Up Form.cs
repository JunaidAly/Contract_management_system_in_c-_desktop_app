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
    public partial class Sign_Up : Form
    {
        string ConString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Junaid Ali\Documents\Project_DB.mdf;Integrated Security=True;Connect Timeout=30";
        public Sign_Up()
        {
            InitializeComponent();
        }


        private void Btn_create_Click(object sender, EventArgs e)
        {

            if (!IsPasswordsEqual(passtxtbox.Text, conpasstxt.Text))
            {
                MessageBox.Show("Enter same password in both");


            }
            else
            {
                SqlConnection con = new SqlConnection(ConString);
                if (username.Text.Equals("") || conpasstxt.Text.Equals(""))
                {
                    MessageBox.Show("Fill Up Above form");
                }
                else
                {
                    string Full_Name = Full_Name_txtbox.Text;
                    string email = username.Text;
                    string pass = passtxtbox.Text;
                    string con_password = conpasstxt.Text;


                    string query = String.Format("INSERT INTO Login Values" +
                        "('{0}', '{1}','{2}','{3}')", Full_Name, email, pass, con_password);

                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.ExecuteNonQuery();

                    Full_Name_txtbox.Text = "";

                    username.Text = "";

                    passtxtbox.Text = "";

                    conpasstxt.Text = "";

                    con.Close();


                    MessageBox.Show("Account Created Successfully");
                }
               

                
            }
           
        }
        public bool IsPasswordsEqual(string password1, string password2)
        {
            if (password1.Equals(password2))
            {
                return true;
            }

            return false;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Login_Page login = new Login_Page();
            login.Show();
            this.Hide();
        }
    }
}
