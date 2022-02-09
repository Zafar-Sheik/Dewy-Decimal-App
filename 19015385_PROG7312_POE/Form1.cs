using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19015385_PROG7312_POE
{
    public partial class frmHome : Form
    {


        public frmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReplacingBooksPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReplacingBooks f2 = new frmReplacingBooks();
            f2.Show();
        }

        private void IdentifyingAreasPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIdentifyAreas f3 = new frmIdentifyAreas();
            f3.Show();
        }
    }
}
