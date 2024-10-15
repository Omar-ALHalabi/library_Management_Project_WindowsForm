using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_Management_Project
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new BookScreen();
            frm.ShowDialog();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new SaleScreen();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new DailySales();
            frm.ShowDialog();
        }
    }
}
