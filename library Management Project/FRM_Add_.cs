using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuAnimatorNS;
using businessLayer_library_;

namespace library_Management_Project
{
    public partial class FRM_Add_Edit : Form
    {
      
        
        int move = 0;
        int movex = 0;
        int movey = 0;

         enum enmode { addnew=0,update=1 };
        private enmode mode;
           

        int _BookID;
        clslibrary _Library;
        public FRM_Add_Edit(int bookID)
        {
            InitializeComponent();

            _BookID = bookID;
            if(_BookID==-1)
            {
                mode = enmode.addnew;
            }
            else
            {
                mode = enmode.update;
            }



        }

        



        private void pictureclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);


            }

        }

        private void _fillCategoryInCombobox()
        {

            DataTable dtcategory = ClsCategories._GetAllCategories();

            foreach (DataRow row in dtcategory.Rows)
            {
                comboBoxcategory.Items.Add(row["categoryname"]);

            }




        }



        private void _LoadData()
        {

            _fillCategoryInCombobox();
            comboBoxcategory.SelectedIndex = 0;
            if (mode==enmode.addnew)
            {
                _Library = new clslibrary();
                LabelTitle.Text = "Add New Book";
                return;
            }


            _Library = clslibrary._FindBookByID(_BookID);
            if(_Library!=null)
            {
                LabelTitle.Text = "Update book";
                titlebook.Text = _Library.title;
                author.Text = _Library.author;
                price.Text=_Library.price.ToString();
                comboBoxcategory.SelectedIndex = comboBoxcategory.FindString(ClsCategories._FindCategoryByID(_Library.category).categoryname);    
                datebook.Value= _Library.Date;
                rate.Value = _Library.rate;
                tbbookcopies.Text = _Library.BookCopies.ToString();
                pictureBook.ImageLocation = _Library.imagepath;
                if(pictureBook.ImageLocation!="" && pictureBook.ImageLocation != null) //|| pictureBook.ImageLocation!="")
                {
                    linkLabeldelete.Visible = true;

                }


            }



        }



        private void FRM_Add_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
           // int BookID = clslibrary._FindBookDetailsByName(titlebook.Text).id;
            DialogResult Result;
            if (mode == enmode.addnew)
            {
                Result = MessageBox.Show("Do You Sure To Add This Book?.", "Confiremd", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            }
            else 
            {
                Result = MessageBox.Show("Do You Sure To Update This Book?.", "Confiremd", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            }
           
            if (Result == DialogResult.Yes)
                {


                int categoryid = ClsCategories._FindCategoryByName(comboBoxcategory.Text).id;
                    _Library.title = titlebook.Text;
                    _Library.price = Convert.ToDouble(price.Text);
                _Library.category = categoryid;
                    _Library.Date = datebook.Value;
                    _Library.rate = rate.Value;
                    _Library.author = author.Text;
                _Library.BookCopies = int.Parse(tbbookcopies.Text);
                    if (pictureBook.ImageLocation != null)
                    {
                        _Library.imagepath = pictureBook.ImageLocation;
                    }
                    else
                    {
                        _Library.imagepath = null;
                    }


                    if (_Library.Save())
                        MessageBox.Show("Data Saved Successfully.","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error: Data Is not Saved Successfully.","error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    mode = enmode.update;
                    LabelTitle.Text = "Edit Contact ID = " + _Library.id;
                }

                else if(Result==DialogResult.No)
                {
                    this.Close();
                }
              

            
        



        }

        private void linkLabeldowload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string selectedFilePath = "";

            openFileDialog1.Title = "choose photo";
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog1.FileName;
                 linkLabeldelete.Visible = true;
                pictureBook.Visible = true;
                pictureBook.Load(selectedFilePath);
            }
            //  pictureBook.ImageLocation = openFileDialog1.FileName;

          


        }

        private void linkLabeldelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBook.ImageLocation = null;
           // pictureBook.Visible = false;
            linkLabeldelete.Visible = false;
        }

        private void BtAddCate_Click(object sender, EventArgs e)
        {
            Form frm = new AddCategory();
            bunifuTransition2.ShowSync(frm);

           
      



        }

        private void BtDeleteCat_Click(object sender, EventArgs e)
        {
            Form frm = new DeleteCategory();
            bunifuTransition2.ShowSync(frm);
           
           // _fillCategoryInCombobox();


        }

        private void FRM_Add_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
            {

                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbbookcopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
            {

                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbbookcopies_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
