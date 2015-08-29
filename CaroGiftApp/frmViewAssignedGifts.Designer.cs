namespace CaroGiftApp
{
    partial class frmViewAssignedGifts
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label personIDLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label lblTotal;
            this.dataGridAssignedProducts = new System.Windows.Forms.DataGridView();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strausserGiftDbDataSet = new CaroGiftApp.StrausserGiftDbDataSet();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTotalGiftPrice = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCalcTotal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.assignedGiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignedGiftsTableAdapter = new CaroGiftApp.StrausserGiftDbDataSetTableAdapters.AssignedGiftsTableAdapter();
            this.tableAdapterManager = new CaroGiftApp.StrausserGiftDbDataSetTableAdapters.TableAdapterManager();
            this.personTableAdapter = new CaroGiftApp.StrausserGiftDbDataSetTableAdapters.PersonTableAdapter();
            firstNameLabel = new System.Windows.Forms.Label();
            personIDLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssignedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strausserGiftDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedGiftsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(18, 47);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(89, 18);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // personIDLabel
            // 
            personIDLabel.AutoSize = true;
            personIDLabel.Location = new System.Drawing.Point(26, 15);
            personIDLabel.Name = "personIDLabel";
            personIDLabel.Size = new System.Drawing.Size(81, 18);
            personIDLabel.TabIndex = 3;
            personIDLabel.Text = "Person ID:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(19, 79);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(88, 18);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(58, 122);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(113, 18);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total Gift Price:";
            // 
            // dataGridAssignedProducts
            // 
            this.dataGridAssignedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAssignedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colProductPrice});
            this.dataGridAssignedProducts.Location = new System.Drawing.Point(219, 12);
            this.dataGridAssignedProducts.Name = "dataGridAssignedProducts";
            this.dataGridAssignedProducts.Size = new System.Drawing.Size(325, 321);
            this.dataGridAssignedProducts.TabIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            // 
            // colProductPrice
            // 
            this.colProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductPrice.HeaderText = "Price";
            this.colProductPrice.Name = "colProductPrice";
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(113, 44);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 26);
            this.txtFirstName.TabIndex = 2;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.strausserGiftDbDataSet;
            // 
            // strausserGiftDbDataSet
            // 
            this.strausserGiftDbDataSet.DataSetName = "StrausserGiftDbDataSet";
            this.strausserGiftDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPersonID
            // 
            this.txtPersonID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "PersonID", true));
            this.txtPersonID.Location = new System.Drawing.Point(113, 12);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(100, 26);
            this.txtPersonID.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(113, 76);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 26);
            this.txtLastName.TabIndex = 6;
            // 
            // txtTotalGiftPrice
            // 
            this.txtTotalGiftPrice.Location = new System.Drawing.Point(59, 143);
            this.txtTotalGiftPrice.Name = "txtTotalGiftPrice";
            this.txtTotalGiftPrice.ReadOnly = true;
            this.txtTotalGiftPrice.Size = new System.Drawing.Size(112, 26);
            this.txtTotalGiftPrice.TabIndex = 7;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Red;
            this.btnPrev.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(12, 175);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(95, 48);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Red;
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(118, 175);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 48);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCalcTotal
            // 
            this.btnCalcTotal.BackColor = System.Drawing.Color.Red;
            this.btnCalcTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTotal.ForeColor = System.Drawing.Color.White;
            this.btnCalcTotal.Location = new System.Drawing.Point(59, 229);
            this.btnCalcTotal.Name = "btnCalcTotal";
            this.btnCalcTotal.Size = new System.Drawing.Size(112, 48);
            this.btnCalcTotal.TabIndex = 11;
            this.btnCalcTotal.Text = "Calculate Total";
            this.btnCalcTotal.UseVisualStyleBackColor = false;
            this.btnCalcTotal.Click += new System.EventHandler(this.btnCalcTotal_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(61, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 48);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // assignedGiftsBindingSource
            // 
            this.assignedGiftsBindingSource.DataMember = "AssignedGifts";
            this.assignedGiftsBindingSource.DataSource = this.strausserGiftDbDataSet;
            // 
            // assignedGiftsTableAdapter
            // 
            this.assignedGiftsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignedGiftsTableAdapter = this.assignedGiftsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OccasionsTableAdapter = null;
            this.tableAdapterManager.PersonTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CaroGiftApp.StrausserGiftDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewAssignedGifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(556, 345);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalcTotal);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(lblTotal);
            this.Controls.Add(this.txtTotalGiftPrice);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(personIDLabel);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dataGridAssignedProducts);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewAssignedGifts";
            this.Text = "View Assigned Gifts";
            this.Load += new System.EventHandler(this.frmViewAssignedGifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssignedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strausserGiftDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedGiftsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StrausserGiftDbDataSet strausserGiftDbDataSet;
        private System.Windows.Forms.BindingSource assignedGiftsBindingSource;
        private StrausserGiftDbDataSetTableAdapters.AssignedGiftsTableAdapter assignedGiftsTableAdapter;
        private StrausserGiftDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridAssignedProducts;
        private System.Windows.Forms.BindingSource personBindingSource;
        private StrausserGiftDbDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtTotalGiftPrice;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCalcTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductPrice;
    }
}