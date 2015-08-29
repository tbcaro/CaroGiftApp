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
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            //After 1 tick of desired interval stop timer and display main form
            splashTimer.Stop();
            this.Hide();
       
            frmMainScreen mainForm = new frmMainScreen();
            mainForm.Show();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            //On form load, start timer
            splashTimer.Start();
        }

    }
}
