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
    public partial class DeleteCategory  : Form
    {
        public DeleteCategory ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbDelete.Text) )
            {
                DialogResult DR = MessageBox.Show("Are You sure  ?.", "Confirmed", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (DR == DialogResult.Yes)
                {

                     ClsCategories._DeleteCategory(tbDelete.Text);

                    MessageBox.Show("Data Saved successfully");
                    Form frm = new frm_DeleteDialog();
                    frm.ShowDialog();


                }
               

            }
            else
            {
                MessageBox.Show("Please enter the category name first","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }
    }
}
