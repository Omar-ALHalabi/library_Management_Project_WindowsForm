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
    public partial class DailySales : Form
    {
        public DailySales()
        {
            InitializeComponent();
        }



        private void _fillListView()
        {

            DataTable dt = ClsSalesBook.GetAllInfo();

            foreach(DataRow row in dt.Rows)
            {
                ListViewItem LV = new ListViewItem(row["title"].ToString());
                LV.SubItems.Add(row["category"].ToString());
                LV.SubItems.Add(row["price"].ToString());
                LV.SubItems.Add(row["DateOfSale"].ToString());

                listView1.Items.Add(LV);
               

            


            }




        }

        private void DailySales_Load(object sender, EventArgs e)
        {
            _fillListView();

        }
    }
}
