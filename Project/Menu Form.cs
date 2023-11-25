using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btn_apply_for_contracts_Click(object sender, EventArgs e)
        {
            Contract_Details form = new Contract_Details();
            form.Show();
            this.Close();
        }

        private void Btn_Display_details_Click(object sender, EventArgs e)
        {
            Show_Data show = new Show_Data();
            show.Show();
            this.Close();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Delete_Data data = new Delete_Data();
            data.Show();
            this.Close();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
           
            Update_Form update = new Update_Form();
            update.Show();
            this.Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Add_work_Click(object sender, EventArgs e)
        {
            Add_Work_Form work = new Add_Work_Form();
            work.Show();
            this.Close();
        }

    }
}
