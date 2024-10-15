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
    public partial class Add_UpdateUsers : Form
    {
        public Add_UpdateUsers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new AddUsers();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new UpdateUser();
            
            frm.ShowDialog();
        }

        private void Add_Users_Load(object sender, EventArgs e)
        {

        }
    }
}
