using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using businessLayer_library_;

namespace library_Management_Project
{
    public partial class LogScreen : Form
    {
        int move = 0;
        int movex = 0;
        int movy = 0;
        public LogScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Logging._GetAllInfoEnter();

            foreach(DataRow row in dt.Rows)
            {
                if (row["UserName"].ToString() == TbUsername.Text && row["Password"].ToString() == TbPassword.Text)
                {
                    Form frm = new MainScreen();
                    frm.ShowDialog();
                    this.Close();
                    TbPassword.Text = "";
                    TbUsername.Text = "";
                    return;

                }



            }




            MessageBox.Show("UserName Or Password Are Not Correct, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TbPassword.Text = "";
            TbUsername.Text = "";





        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frm = new Add_UpdateUsers();
            frm.ShowDialog();




        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movy = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move==1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movy);


            }



        }

        private void TbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btlogin.PerformClick();

            }
        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
