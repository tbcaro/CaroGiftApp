using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGiftApp
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close app 
            Application.Exit();
        }

        private void frmMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Close app
            Application.Exit();
        }

        private void btnViewGifts_Click(object sender, EventArgs e)
        {
            //Open View Gifts Form
            frmViewAssignedGifts ViewGiftForm = new frmViewAssignedGifts();
            ViewGiftForm.ShowDialog();
        }

        private void btnAssignGifts_Click(object sender, EventArgs e)
        {
            //Open Assign Gifts Form
            frmAssignGifts AssignGiftForm = new frmAssignGifts();
            AssignGiftForm.ShowDialog();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            //Open Add Person Form
            frmAddPerson AddPersonForm = new frmAddPerson();
            AddPersonForm.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //Open Add Product Form
            frmAddProduct AddProductForm = new frmAddProduct();
            AddProductForm.ShowDialog();
        }
    }
}
