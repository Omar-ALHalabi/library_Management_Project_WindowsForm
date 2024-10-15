using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using businessLayer_library_;

namespace library_Management_Project
{
    public partial class UpdateUser: Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void fillcomboboxUsers()
        {

            DataTable dt = Logging._GetAllInfoEnter();

            foreach (DataRow row in dt.Rows)
            {
                CbUsers.Items.Add(row["username"]);

            }
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Logging._GetAllInfoEnter();
           
            foreach (DataRow row in dt.Rows)
            {
                if (CbUsers.Text == row["username"].ToString() && tboldpassword.Text == row["password"].ToString())
                {
                    Logging._UpdateUser(CbUsers.Text, tbnewuser.Text,tbnewpassword.Text);
                    MessageBox.Show("user Updated successfully", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tboldpassword.Text = "";
                    tbnewuser.Text = "";
                    tbnewpassword.Text = "";
                    return;

                }



            }

            MessageBox.Show("password is incorrect , please try again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }


        private void UpdateUser_Load(object sender, EventArgs e)
        {
            fillcomboboxUsers();
        }
    }
}
