namespace CaroGiftApp
{
    partial class frmAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label productDescriptionLabel;
            System.Windows.Forms.Label productNameLabel;
            this.btnSavePicture = new System.Windows.Forms.Button();
            this.picboxProduct = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.strausserGiftDbDataSet = new CaroGiftApp.StrausserGiftDbDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new CaroGiftApp.StrausserGiftDbDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new CaroGiftApp.StrausserGiftDbDataSetTableAdapters.TableAdapterManager();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            priceLabel = new System.Windows.Forms.Label();
            productDescriptionLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strausserGiftDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(12, 380);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(49, 18);
            priceLabel.TabIndex = 27;
            priceLabel.Text = "Price:";
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Location = new System.Drawing.Point(12, 303);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new System.Drawing.Size(150, 18);
            productDescriptionLabel.TabIndex = 25;
            productDescriptionLabel.Text = "Product Description:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(12, 271);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(112, 18);
            productNameLabel.TabIndex = 23;
            productNameLabel.Text = "Product Name:";
            // 
            // btnSavePicture
            // 
            this.btnSavePicture.BackColor = System.Drawing.Color.Red;
            this.btnSavePicture.Enabled = false;
            this.btnSavePicture.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePicture.ForeColor = System.Drawing.Color.White;
            this.btnSavePicture.Location = new System.Drawing.Point(218, 425);
            this.btnSavePicture.Name = "btnSavePicture";
            this.btnSavePicture.Size = new System.Drawing.Size(200, 59);
            this.btnSavePicture.TabIndex = 18;
            this.btnSavePicture.Text = "Save";
            this.btnSavePicture.UseVisualStyleBackColor = false;
            this.btnSavePicture.Click += new System.EventHandler(this.btnSavePicture_Click);
            // 
            // picboxProduct
            // 
            this.picboxProduct.Location = new System.Drawing.Point(12, 12);
            this.picboxProduct.Name = "picboxProduct";
            this.picboxProduct.Size = new System.Drawing.Size(406, 245);
            this.picboxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxProduct.TabIndex = 19;
            this.picboxProduct.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Red;
            this.btnBrowse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(12, 425);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(200, 59);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // strausserGiftDbDataSet
            // 
            this.strausserGiftDbDataSet.DataSetName = "StrausserGiftDbDataSet";
            this.strausserGiftDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.strausserGiftDbDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignedGiftsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OccasionsTableAdapter = null;
            this.tableAdapterManager.PersonTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CaroGiftApp.StrausserGiftDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(168, 377);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(134, 26);
            this.txtPrice.TabIndex = 28;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(168, 300);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(250, 71);
            this.txtProductDescription.TabIndex = 26;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(168, 268);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(250, 26);
            this.txtProductName.TabIndex = 24;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(115, 498);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 59);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(438, 569);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(productDescriptionLabel);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picboxProduct);
            this.Controls.Add(this.btnSavePicture);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddProduct";
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strausserGiftDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSavePicture;
        private System.Windows.Forms.PictureBox picboxProduct;
        private System.Windows.Forms.Button btnBrowse;
        private StrausserGiftDbDataSet strausserGiftDbDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private StrausserGiftDbDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private StrausserGiftDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnExit;
    }
}