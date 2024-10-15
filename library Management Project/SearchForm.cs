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
    public partial class SearchForm : Form
    {
       
        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(int num)
        {
            InitializeComponent();
            BTSearch.Visible = false;
            comboBox1.Visible = false;
            label1.Visible = false;
            clslibrary book = clslibrary._FindBookByID(num);
            if (book != null)
            {

                groupBox1.Visible = true;
                LabelID.Text = book.id.ToString();
                TbTitle.Text = book.title;
                TbAuthor.Text = book.author;
                TBPrice.Text = book.price.ToString();
                TbCategory.Text = ClsCategories._FindCategoryByID(book.category).categoryname;
                TbDate.Text = book.Date.ToString();
                TbRate.Text = book.rate.ToString();
                if (book.imagepath != null && book.imagepath != "")
                {
                    TbImagePath.Text = book.imagepath;
                }
                else
                {
                    TbImagePath.Text = "No Photo";
                }




            }
            else
            {

                MessageBox.Show("This Book Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void fillcbofbooks()
        {
            DataTable dt= clslibrary._getBooksInfo();

            foreach(DataRow row in dt.Rows)
            {

                comboBox1.Items.Add(row["title"]);


            }




        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            fillcbofbooks();
        }

        private void NameSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTSearch_Click(object sender, EventArgs e)
        {
            clslibrary book=clslibrary._FindBookDetailsByName(comboBox1.Text);
            if(book!=null)
            {
                
                groupBox1.Visible = true;
                LabelID.Text =  book.id.ToString(); 
                TbTitle.Text=book.title;
                TbAuthor.Text=book.author;
                TBPrice.Text = book.price.ToString();
                TbCategory.Text = ClsCategories._FindCategoryByID(book.category).categoryname;
                TbDate.Text = book.Date.ToString();
                TbRate.Text=book.rate.ToString();
                if(book.imagepath!= null && book.imagepath!="")
                {
                    TbImagePath.Text = book.imagepath;
                }
                else
                {
                    TbImagePath.Text = "No Photo";
                }
              
               


            }
            else
            {

                MessageBox.Show("This Book Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           // groupBox1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
