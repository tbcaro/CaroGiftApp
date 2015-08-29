using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGiftApp
{
    public partial class frmAddProduct : Form
    {
        String fileLocation;

        String connectionstring;
        SqlConnection connection;
        String commandStatement;
        SqlCommand command;

        public frmAddProduct()
        {
            InitializeComponent();

            //Initialize sql variables
            connectionstring = Properties.Settings.Default.StrausserGiftDbConnectionString;

            connection = new SqlConnection(connectionstring);

            commandStatement = "INSERT INTO Products " +
                                "(ProductName, ProductDescription, Price, ProductPicture) " +
                                "VALUES (@ProductName,@ProductDescription,@Price,@ProductPicture)";


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Try to open file dialog and choose image. Once user clicks ok in file dialog save fileLocation.
            //Display image in picbox, Then enable the user to save the image.
            try
            {
                //Create a file dialog object
                OpenFileDialog fileDialog = new OpenFileDialog();

                //Filter the types of files displayed in the file dialog
                fileDialog.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                fileDialog.Title = "Choose an image";

                //Once user clicks ok store the location of image and then display in picturebox
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileLocation = fileDialog.FileName.ToString();
                    picboxProduct.ImageLocation = fileLocation;
                    
                    //Once there is a picture in the picbox then enable the option to save it
                    btnSavePicture.Enabled = true;
                }                
            }
            
            //Catch any exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSavePicture_Click(object sender, EventArgs e)
        {
            //Store picture as an array of bytes. To do this, create a fileStream object and a binReader obj.
            //Set fileStream to target image in picbox. Then read bytes into array with binReader.

            //After array is successfully filled, gather other information about product.
            //Fill product object with information and then attempt to insert into database.
            try
            {

                //Declare product object
                Product aProduct = new Product();

                //Declare array of bytes
                byte[] pic = null;

                //Declare file reading objects
                FileStream fileStream = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
                BinaryReader binReader = new BinaryReader(fileStream);

                //Read file with binary reader into pic array
                pic = binReader.ReadBytes((int)fileStream.Length);

                //Read input from form to object as well as pic array
                aProduct.ProductName = txtProductName.Text;
                aProduct.ProductDescription = txtProductDescription.Text;
                aProduct.Price = (float)Convert.ToDouble(txtPrice.Text);
                aProduct.ProductPicture = pic;

                command = new SqlCommand(commandStatement, connection);

                //Add params to command object
                command.Parameters.AddWithValue("@ProductName", aProduct.ProductName);
                command.Parameters.AddWithValue("@ProductDescription", aProduct.ProductDescription);
                command.Parameters.AddWithValue("@Price", aProduct.Price);
                command.Parameters.AddWithValue("@ProductPicture", aProduct.ProductPicture);

                //Open connection
                connection.Open();

                //Attempt insert into database
                command.ExecuteNonQuery();

                //Close connection
                connection.Close();

                MessageBox.Show("New product successfully saved to database");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save product to database! " + ex.Message);
                connection.Close();
            }


        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.strausserGiftDbDataSet);

        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'strausserGiftDbDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.strausserGiftDbDataSet.Products);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }
    }
}
