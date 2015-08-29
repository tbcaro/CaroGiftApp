namespace CaroGiftApp
{
    partial class frmAssignGifts
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
            this.comboOccasion = new System.Windows.Forms.ComboBox();
            this.occasionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strausserGiftDbDataSet = new CaroGiftApp.StrausserGiftDbDataSet();
            this.occasionsTableAdapter = new CaroGiftApp.StrausserGiftDbDataSetTableAdapters.OccasionsTableAdapter();
            this.comboPerson = new System.Windows.Forms.ComboBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.personTableAdapter = new CaroGiftApp.StrausserGiftDbDataSetTableAdapters.PersonTableAdapter();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new CaroGiftApp.StrausserGiftDbDataSetTableAdapters.ProductsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAssignGift = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.occasionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strausserGiftDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboOccasion
            // 
            this.comboOccasion.DataSource = this.occasionsBindingSource;
            this.comboOccasion.DisplayMember = "OccassionName";
            this.comboOccasion.FormattingEnabled = true;
            this.comboOccasion.Location = new System.Drawing.Point(12, 53);
            this.comboOccasion.Name = "comboOccasion";
            this.comboOccasion.Size = new System.Drawing.Size(147, 26);
            this.comboOccasion.TabIndex = 0;
            this.comboOccasion.ValueMember = "OccasionID";
            // 
            // occasionsBindingSource
            // 
            this.occasionsBindingSource.DataMember = "Occasions";
            this.occasionsBindingSource.DataSource = this.strausserGiftDbDataSet;
            // 
            // strausserGiftDbDataSet
            // 
            this.strausserGiftDbDataSet.DataSetName = "StrausserGiftDbDataSet";
            this.strausserGiftDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // occasionsTableAdapter
            // 
            this.occasionsTableAdapter.ClearBeforeFill = true;
            // 
            // comboPerson
            // 
            this.comboPerson.DataSource = this.personBindingSource;
            this.comboPerson.DisplayMember = "FirstName";
            this.comboPerson.FormattingEnabled = true;
            this.comboPerson.Location = new System.Drawing.Point(191, 53);
            this.comboPerson.Name = "comboPerson";
            this.comboPerson.Size = new System.Drawing.Size(147, 26);
            this.comboPerson.TabIndex = 1;
            this.comboPerson.ValueMember = "PersonID";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.strausserGiftDbDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Occasion";
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // comboProduct
            // 
            this.comboProduct.DataSource = this.productsBindingSource;
            this.comboProduct.DisplayMember = "ProductName";
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Location = new System.Drawing.Point(373, 53);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(147, 26);
            this.comboProduct.TabIndex = 3;
            this.comboProduct.ValueMember = "ProductID";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product";
            // 
            // btnAssignGift
            // 
            this.btnAssignGift.BackColor = System.Drawing.Color.Red;
            this.btnAssignGift.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignGift.ForeColor = System.Drawing.Color.White;
            this.btnAssignGift.Location = new System.Drawing.Point(48, 124);
            this.btnAssignGift.Name = "btnAssignGift";
            this.btnAssignGift.Size = new System.Drawing.Size(200, 59);
            this.btnAssignGift.TabIndex = 18;
            this.btnAssignGift.Text = "Assign Gift";
            this.btnAssignGift.UseVisualStyleBackColor = false;
            this.btnAssignGift.Click += new System.EventHandler(this.btnAssignGift_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(288, 124);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 59);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAssignGifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(536, 195);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAssignGift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPerson);
            this.Controls.Add(this.comboOccasion);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAssignGifts";
            this.Text = "Assign Gifts";
            this.Load += new System.EventHandler(this.frmAssignGifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.occasionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strausserGiftDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboOccasion;
        private StrausserGiftDbDataSet strausserGiftDbDataSet;
        private System.Windows.Forms.BindingSource occasionsBindingSource;
        private StrausserGiftDbDataSetTableAdapters.OccasionsTableAdapter occasionsTableAdapter;
        private System.Windows.Forms.ComboBox comboPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private StrausserGiftDbDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.ComboBox comboProduct;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private StrausserGiftDbDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAssignGift;
        private System.Windows.Forms.Button btnExit;
    }
}