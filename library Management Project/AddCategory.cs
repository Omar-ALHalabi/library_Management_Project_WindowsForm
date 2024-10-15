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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }


        


       

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }

        private void BtAddCategory_Click(object sender, EventArgs e)
        {
            if ( !System.String.IsNullOrWhiteSpace(TbCat.Text))
            {
                DialogResult DR = MessageBox.Show("Are You sure ?.", "Confirmed", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (DR == DialogResult.Yes)
                {

                    if (ClsCategories._AddCategory(TbCat.Text))
                    {
                        MessageBox.Show("Data Saved successfully","successfull",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        Form frm = new frm_AddDialog();
                        frm.ShowDialog();

                    }
                    
                   

                }
            }
            else
            {
                MessageBox.Show("Please enter the category name first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

       
    }
}
