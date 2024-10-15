using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using businessLayer_library_;

namespace library_Management_Project
{
    public partial class SaleScreen : Form
    {
        ClsSalesBook _salebook;
        struct stBookInfo
        {
            public string Author;
            public double price;
            public DateTime establishDate;
            public string category;

        }

        clslibrary _library;
        public SaleScreen()
        {
            InitializeComponent();
        }

        private void _fillComboBoxOfBook()
        {

            DataTable dt = clslibrary._getBooksInfo();
           
            foreach (DataRow row in dt.Rows)
            {

                comboBox1.Items.Add(row["Title"]);

            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _library = clslibrary._FindBookDetailsByName(comboBox1.Text);
          
            if (_library != null)
            {
                string cat = ClsCategories._FindCategoryByID(_library.category).categoryname;
                tbdate.Text = _library.Date.ToString();
                tbauthor.Text = _library.author.ToString();
                Price.Text = _library.price.ToString();
                tbcategory.Text = cat;
                if( !string.IsNullOrWhiteSpace(_library.imagepath.ToString()))
                {
                    pictureBox1.Load(_library.imagepath);
                }
                else
                {
                    pictureBox1.ImageLocation = "";
                }



            }
        }
        private void SaveDataInDailySales(clslibrary library)
        {

            string cat = ClsCategories._FindCategoryByID(_library.category).categoryname;
            _salebook = new ClsSalesBook();
            _salebook.BookID = _library.id;
            _salebook.Title = _library.title;
            _salebook.price = _library.price;
            _salebook.Date = DateTime.Now;
            _salebook.category = cat;
            if (_salebook.AddSaleBook())
            {
                MessageBox.Show("operation accomplished successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {

                MessageBox.Show("The operation failed", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }



        }
        private void SaleScreen_Load(object sender, EventArgs e)
        {
            _fillComboBoxOfBook();
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _library = clslibrary._FindBookDetailsByName(comboBox1.Text);
            if (_library!=null)
            {
                if (_library.BookCopies > 0)
                {
                    _library.BookCopies = _library.BookCopies - 1;
                    _library._updateBookDetails();

                    SaveDataInDailySales(_library);
                }
                else
                {

                    MessageBox.Show("this book is not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            else {

                MessageBox.Show("please select a book","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
               }
        }
    }
}
