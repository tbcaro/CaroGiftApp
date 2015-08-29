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
    public partial class frmViewAssignedGifts : Form
    {
        //sql variables
        String connectionstring;       
        SqlConnection connection;

        //List to store current users prices so that I can calculate total
        List<float> curUserPrices;

        public frmViewAssignedGifts()
        {
            InitializeComponent();

            //Initialize connection variables
            connectionstring = Properties.Settings.Default.StrausserGiftDbConnectionString;

            connection = new SqlConnection(connectionstring);

        }

        private void assignedGiftsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assignedGiftsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.strausserGiftDbDataSet);

        }

        private void frmViewAssignedGifts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'strausserGiftDbDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.strausserGiftDbDataSet.Person);
            // TODO: This line of code loads data into the 'strausserGiftDbDataSet.AssignedGifts' table. You can move, or remove it, as needed.
            this.assignedGiftsTableAdapter.Fill(this.strausserGiftDbDataSet.AssignedGifts);

            //Instantiate list
            curUserPrices = new List<float>();

            //Clear the list and datagrid view, then get what gifts are assigned to initial user in form
            clearUserList();
            clearDataGrid();
            getAssignedProducts();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //Move to previous person
            personBindingSource.MovePrevious();

            //Clear the list so that it can be filled with the new user's gifts 
            //Clear dataGrid so new users gifts can fill it
            //Then get new users gifts
            clearUserList();
            clearDataGrid();
            getAssignedProducts();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Move to next person
            personBindingSource.MoveNext();

            //Clear the list so that it can be filled with the new user's gifts 
            //Clear dataGrid so new users gifts can fill it
            //Then get new users gifts
            clearUserList();
            clearDataGrid();
            getAssignedProducts();
        }

        private void btnCalcTotal_Click(object sender, EventArgs e)
        {
            //Sum the prices of all the person's gifts and output to textbox
            txtTotalGiftPrice.Text = curUserPrices.Sum().ToString("c");            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        private void getAssignedProducts()
        {
            try
            {
                //Gather form input
                int PersonID = Convert.ToInt32(txtPersonID.Text);

                //Select statement selecting only the products associated with the person's assigned gifts
                String commandStatement = "SELECT  Products.ProductName, Products.Price " +
                                    "FROM   AssignedGifts INNER JOIN " +
                                    "Products ON AssignedGifts.ProductID = Products.ProductID " +
                                    "WHERE  (AssignedGifts.PersonID = @PersonID)";

                //Add parameters
                SqlCommand command = new SqlCommand(commandStatement, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);

                //Read database
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Product aProd = new Product();

                    aProd.ProductName = reader["ProductName"].ToString();
                    aProd.Price = (float)Convert.ToDouble(reader["Price"]);

                    //Put the person's gifts into the datagrid and add their prices to the list
                    curUserPrices.Add(aProd.Price);
                    dataGridAssignedProducts.Rows.Add(aProd.ProductName, aProd.Price.ToString("c"));
                }

                connection.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearDataGrid()
        {
            //Clear data grid for next person's gifts
            dataGridAssignedProducts.Rows.Clear();
        }

        private void clearUserList()
        {
            //Clear the list for next person
            curUserPrices.Clear();
        }
    }
}
