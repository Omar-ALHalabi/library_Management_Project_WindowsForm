using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuAnimatorNS;
using businessLayer_library_;

namespace library_Management_Project
{
    public partial class BookScreen : Form
    {
        int movex = 0;
        int movey = 0;
        int move = 0;

        public BookScreen()
        {
            InitializeComponent();
        }

        void refreshInfo()
        {
            dgv1.DataSource = clslibrary._getBooksInfo();
            



        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureclose.BackColor = Color.Blue;
        }

        private void pictureclose_MouseLeave(object sender, EventArgs e)
        {
            pictureclose.BackColor = Color.Silver;
        }

       
        private void panelAbove_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void panelAbove_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panelAbove_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {

               // this.SetDesktopLocation(DesktopLocation.X - movex, DesktopLocation .Y - movey);
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }

        }




        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            Form frm_add = new FRM_Add_Edit(-1);

            frm_add.ShowDialog();
            refreshInfo();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshInfo();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form FrmMain = new FRM_Add_Edit((int)dgv1.CurrentRow.Cells[0].Value);
            FrmMain.ShowDialog();
            refreshInfo();

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure You delete this Book ?.", "confirmed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {


                clslibrary._DeleteBook((int)dgv1.CurrentRow.Cells[0].Value);

                refreshInfo();

            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Form FRM = new SearchForm();
            bunifuTransition1.ShowSync(FRM);
            refreshInfo();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Form frm = new SearchForm((int)dgv1.CurrentRow.Cells[0].Value);
            bunifuTransition1.ShowSync(frm);
            refreshInfo();

        }

        private void panelAbove_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {

                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
