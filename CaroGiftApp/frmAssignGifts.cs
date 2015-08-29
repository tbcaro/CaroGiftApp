using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGiftApp
{
    public partial class frmAssignGifts : Form
    {

        String connectionstring;
        String commandStatement;
        SqlConnection connection;
        SqlCommand command;

        public frmAssignGifts()
        {
            InitializeComponent();

            connectionstring = Properties.Settings.Default.StrausserGiftDbConnectionString;

            commandStatement = "INSERT INTO AssignedGifts " +
                                "(PersonID, ProductID, OccassionID) " +
                                "VALUES (@PersonID,@ProductID,@OccassionID)";

            connection = new SqlConnection(connectionstring);            

        }

        private void frmAssignGifts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'strausserGiftDbDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.strausserGiftDbDataSet.Products);
            // TODO: This line of code loads data into the 'strausserGiftDbDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.strausserGiftDbDataSet.Person);
            // TODO: This line of code loads data into the 'strausserGiftDbDataSet.Occasions' table. You can move, or remove it, as needed.
            this.occasionsTableAdapter.Fill(this.strausserGiftDbDataSet.Occasions);

        }

        private void btnAssignGift_Click(object sender, EventArgs e)
        {
            try
            {
                //Gather input from form
                int PersonID = Convert.ToInt32(comboPerson.SelectedValue);
                int ProductID = Convert.ToInt32(comboProduct.SelectedValue);
                int OccasionID = Convert.ToInt32(comboOccasion.SelectedValue);

                command = new SqlCommand(commandStatement, connection);

                //Add params to command object
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@ProductID", ProductID);
                command.Parameters.AddWithValue("@OccassionID", OccasionID);
                
                //Open connection
                connection.Open();

                //Attempt to insert to database
                command.ExecuteNonQuery();

                //Close connection
                connection.Close();

                MessageBox.Show("Gift successfully assigned");

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }
    }
}
