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
    public partial class frmAddPerson : Form
    {
        //Declare sql variables
        String connectionstring;
        String commandStatement;
        SqlConnection connection;
        SqlCommand command;

        public frmAddPerson()
        {
            InitializeComponent();

            //Initialize sql variables
            connectionstring = Properties.Settings.Default.StrausserGiftDbConnectionString;

            commandStatement =   "INSERT INTO Person "+
                                        "(FirstName, LastName, Address, City, State, Zip, Birthday) "+
                                        "VALUES (@FirstName,@LastName,@Address,@City,@State,@Zip,@Birthday)";

            connection = new SqlConnection(connectionstring);

                
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.strausserGiftDbDataSet);

        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'strausserGiftDbDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.strausserGiftDbDataSet.Person);

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            //Upon clicking button try to parse information from textboxes into object
            //From add parameters to command object via the object information and then attempt to upload to database
            //If successful display message
            try
            {
                //Create person object
                Person aPerson = new Person();

                //Fill person object with form input
                aPerson.FirstName = txtFirstName.Text;
                aPerson.LastName = txtLastName.Text;
                aPerson.Address = txtAddress.Text;
                aPerson.City = txtCity.Text;
                aPerson.State = txtState.Text;
                aPerson.ZipCode = Convert.ToInt32(txtZip.Text);
                aPerson.BirthDate = Convert.ToDateTime(dateBirthDay.Value);

                command = new SqlCommand(commandStatement, connection);

                //Add parameters to command object
                command.Parameters.AddWithValue("@FirstName", aPerson.FirstName);
                command.Parameters.AddWithValue("@LastName", aPerson.LastName);
                command.Parameters.AddWithValue("@Address", aPerson.Address);
                command.Parameters.AddWithValue("@City", aPerson.City);
                command.Parameters.AddWithValue("@State", aPerson.State);
                command.Parameters.AddWithValue("@Zip", aPerson.ZipCode);
                command.Parameters.AddWithValue("@Birthday", aPerson.BirthDate);

                //Open Connection
                connection.Open();

                //Attempt sql Insert into database
                command.ExecuteNonQuery();

                //Close connection
                connection.Close();

                MessageBox.Show("Successfully added new person to database");

            }
            
            //Catch any exceptions
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Form
            this.Close();
        }
    }
}
