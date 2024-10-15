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
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Logging._GetAllInfoEnter();

            foreach (DataRow row in dt.Rows)
            {
                if (row["username"].ToString()== tbuser.Text && row["password"].ToString()== tbpassword.Text)
                {


                    MessageBox.Show("Username and password are founded , please choose another password or username", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbuser.Text = "";
                    tbpassword.Text = "";
                        return;
                }

            }







            if( string .IsNullOrWhiteSpace(tbuser.Text) || string.IsNullOrWhiteSpace(tbpassword.Text))
            {
                MessageBox.Show("Username or Password Is Empty ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            if (Logging._AddUsers(tbuser.Text,tbpassword.Text))
            {
                MessageBox.Show("Data Saved Successfully", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Data Not Saved Successfully ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbuser.Text = "";
                tbpassword.Text = "";

            }
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {

                button1.PerformClick();

            }
        }
    }
}
