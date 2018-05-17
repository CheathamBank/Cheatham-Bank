namespace CheathamBank
{
    partial class customers
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
            System.Windows.Forms.Label custNameLabel;
            System.Windows.Forms.Label custPhoneLabel;
            System.Windows.Forms.Label cust_AddressLabel;
            System.Windows.Forms.Label custCityLabel;
            System.Windows.Forms.Label custStateLabel;
            System.Windows.Forms.Label custZipLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customers));
            this.customersFormDataSet = new CheathamBank.customersFormDataSet();
            this.cheathamCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cheathamCustomerTableAdapter = new CheathamBank.customersFormDataSetTableAdapters.CheathamCustomerTableAdapter();
            this.tableAdapterManager = new CheathamBank.customersFormDataSetTableAdapters.TableAdapterManager();
            this.cheathamCustomerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cheathamCustomerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.custAccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.custNameTextBox = new System.Windows.Forms.TextBox();
            this.custPhoneTextBox = new System.Windows.Forms.TextBox();
            this.cust_AddressTextBox = new System.Windows.Forms.TextBox();
            this.custCityTextBox = new System.Windows.Forms.TextBox();
            this.custStateTextBox = new System.Windows.Forms.TextBox();
            this.custZipTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTransactions = new System.Windows.Forms.Button();
            custNameLabel = new System.Windows.Forms.Label();
            custPhoneLabel = new System.Windows.Forms.Label();
            cust_AddressLabel = new System.Windows.Forms.Label();
            custCityLabel = new System.Windows.Forms.Label();
            custStateLabel = new System.Windows.Forms.Label();
            custZipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersFormDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheathamCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheathamCustomerBindingNavigator)).BeginInit();
            this.cheathamCustomerBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // custNameLabel
            // 
            custNameLabel.AutoSize = true;
            custNameLabel.Location = new System.Drawing.Point(32, 48);
            custNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            custNameLabel.Name = "custNameLabel";
            custNameLabel.Size = new System.Drawing.Size(55, 23);
            custNameLabel.TabIndex = 3;
            custNameLabel.Text = "Name";
            // 
            // custPhoneLabel
            // 
            custPhoneLabel.AutoSize = true;
            custPhoneLabel.Location = new System.Drawing.Point(180, 47);
            custPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            custPhoneLabel.Name = "custPhoneLabel";
            custPhoneLabel.Size = new System.Drawing.Size(126, 23);
            custPhoneLabel.TabIndex = 5;
            custPhoneLabel.Text = "Phone Number";
            // 
            // cust_AddressLabel
            // 
            cust_AddressLabel.AutoSize = true;
            cust_AddressLabel.Location = new System.Drawing.Point(32, 109);
            cust_AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cust_AddressLabel.Name = "cust_AddressLabel";
            cust_AddressLabel.Size = new System.Drawing.Size(73, 23);
            cust_AddressLabel.TabIndex = 7;
            cust_AddressLabel.Text = "Address";
            // 
            // custCityLabel
            // 
            custCityLabel.AutoSize = true;
            custCityLabel.Location = new System.Drawing.Point(32, 172);
            custCityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            custCityLabel.Name = "custCityLabel";
            custCityLabel.Size = new System.Drawing.Size(39, 23);
            custCityLabel.TabIndex = 9;
            custCityLabel.Text = "City";
            // 
            // custStateLabel
            // 
            custStateLabel.AutoSize = true;
            custStateLabel.Location = new System.Drawing.Point(180, 172);
            custStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            custStateLabel.Name = "custStateLabel";
            custStateLabel.Size = new System.Drawing.Size(49, 23);
            custStateLabel.TabIndex = 11;
            custStateLabel.Text = "State";
            // 
            // custZipLabel
            // 
            custZipLabel.AutoSize = true;
            custZipLabel.Location = new System.Drawing.Point(241, 172);
            custZipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            custZipLabel.Name = "custZipLabel";
            custZipLabel.Size = new System.Drawing.Size(70, 23);
            custZipLabel.TabIndex = 13;
            custZipLabel.Text = "Zipcode";
            // 
            // customersFormDataSet
            // 
            this.customersFormDataSet.DataSetName = "customersFormDataSet";
            this.customersFormDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cheathamCustomerBindingSource
            // 
            this.cheathamCustomerBindingSource.DataMember = "CheathamCustomer";
            this.cheathamCustomerBindingSource.DataSource = this.customersFormDataSet;
            // 
            // cheathamCustomerTableAdapter
            // 
            this.cheathamCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheathamCustomerTableAdapter = this.cheathamCustomerTableAdapter;
            this.tableAdapterManager.UpdateOrder = CheathamBank.customersFormDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cheathamCustomerBindingNavigator
            // 
            this.cheathamCustomerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cheathamCustomerBindingNavigator.BindingSource = this.cheathamCustomerBindingSource;
            this.cheathamCustomerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cheathamCustomerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cheathamCustomerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cheathamCustomerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cheathamCustomerBindingNavigatorSaveItem});
            this.cheathamCustomerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cheathamCustomerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cheathamCustomerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cheathamCustomerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cheathamCustomerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cheathamCustomerBindingNavigator.Name = "cheathamCustomerBindingNavigator";
            this.cheathamCustomerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cheathamCustomerBindingNavigator.Size = new System.Drawing.Size(685, 27);
            this.cheathamCustomerBindingNavigator.TabIndex = 0;
            this.cheathamCustomerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // cheathamCustomerBindingNavigatorSaveItem
            // 
            this.cheathamCustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cheathamCustomerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cheathamCustomerBindingNavigatorSaveItem.Image")));
            this.cheathamCustomerBindingNavigatorSaveItem.Name = "cheathamCustomerBindingNavigatorSaveItem";
            this.cheathamCustomerBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.cheathamCustomerBindingNavigatorSaveItem.Text = "Save Data";
            this.cheathamCustomerBindingNavigatorSaveItem.Click += new System.EventHandler(this.cheathamCustomerBindingNavigatorSaveItem_Click);
            // 
            // custAccountNumberTextBox
            // 
            this.custAccountNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custAccountNumberTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.custAccountNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "CustAccountNumber", true));
            this.custAccountNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAccountNumberTextBox.Location = new System.Drawing.Point(8, 33);
            this.custAccountNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.custAccountNumberTextBox.Name = "custAccountNumberTextBox";
            this.custAccountNumberTextBox.ReadOnly = true;
            this.custAccountNumberTextBox.Size = new System.Drawing.Size(133, 27);
            this.custAccountNumberTextBox.TabIndex = 2;
            this.custAccountNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // custNameTextBox
            // 
            this.custNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "CustName", true));
            this.custNameTextBox.Location = new System.Drawing.Point(36, 69);
            this.custNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.custNameTextBox.Name = "custNameTextBox";
            this.custNameTextBox.Size = new System.Drawing.Size(132, 30);
            this.custNameTextBox.TabIndex = 4;
            // 
            // custPhoneTextBox
            // 
            this.custPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "CustPhone", true));
            this.custPhoneTextBox.Location = new System.Drawing.Point(183, 69);
            this.custPhoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.custPhoneTextBox.Name = "custPhoneTextBox";
            this.custPhoneTextBox.Size = new System.Drawing.Size(153, 30);
            this.custPhoneTextBox.TabIndex = 6;
            // 
            // cust_AddressTextBox
            // 
            this.cust_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "Cust Address", true));
            this.cust_AddressTextBox.Location = new System.Drawing.Point(36, 132);
            this.cust_AddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cust_AddressTextBox.Name = "cust_AddressTextBox";
            this.cust_AddressTextBox.Size = new System.Drawing.Size(300, 30);
            this.cust_AddressTextBox.TabIndex = 8;
            // 
            // custCityTextBox
            // 
            this.custCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "CustCity", true));
            this.custCityTextBox.Location = new System.Drawing.Point(36, 194);
            this.custCityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.custCityTextBox.Name = "custCityTextBox";
            this.custCityTextBox.Size = new System.Drawing.Size(132, 30);
            this.custCityTextBox.TabIndex = 10;
            // 
            // custStateTextBox
            // 
            this.custStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "CustState", true));
            this.custStateTextBox.Location = new System.Drawing.Point(183, 194);
            this.custStateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.custStateTextBox.Name = "custStateTextBox";
            this.custStateTextBox.Size = new System.Drawing.Size(47, 30);
            this.custStateTextBox.TabIndex = 12;
            // 
            // custZipTextBox
            // 
            this.custZipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "CustZip", true));
            this.custZipTextBox.Location = new System.Drawing.Point(244, 194);
            this.custZipTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.custZipTextBox.Name = "custZipTextBox";
            this.custZipTextBox.Size = new System.Drawing.Size(92, 30);
            this.custZipTextBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.custAccountNumberTextBox);
            this.groupBox1.Location = new System.Drawing.Point(472, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(149, 78);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(custZipLabel);
            this.groupBox2.Controls.Add(custStateLabel);
            this.groupBox2.Controls.Add(this.custZipTextBox);
            this.groupBox2.Controls.Add(custCityLabel);
            this.groupBox2.Controls.Add(this.custStateTextBox);
            this.groupBox2.Controls.Add(cust_AddressLabel);
            this.groupBox2.Controls.Add(this.custCityTextBox);
            this.groupBox2.Controls.Add(custPhoneLabel);
            this.groupBox2.Controls.Add(this.cust_AddressTextBox);
            this.groupBox2.Controls.Add(custNameLabel);
            this.groupBox2.Controls.Add(this.custPhoneTextBox);
            this.groupBox2.Controls.Add(this.custNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(17, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(629, 271);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(529, 341);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(117, 32);
            this.btnTransactions.TabIndex = 17;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 385);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cheathamCustomerBindingNavigator);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "customers";
            this.Text = "Customers -:|:- Cheatham Bank";
            this.Load += new System.EventHandler(this.customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersFormDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheathamCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheathamCustomerBindingNavigator)).EndInit();
            this.cheathamCustomerBindingNavigator.ResumeLayout(false);
            this.cheathamCustomerBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private customersFormDataSet customersFormDataSet;
        private System.Windows.Forms.BindingSource cheathamCustomerBindingSource;
        private customersFormDataSetTableAdapters.CheathamCustomerTableAdapter cheathamCustomerTableAdapter;
        private customersFormDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cheathamCustomerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cheathamCustomerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox custAccountNumberTextBox;
        private System.Windows.Forms.TextBox custNameTextBox;
        private System.Windows.Forms.TextBox custPhoneTextBox;
        private System.Windows.Forms.TextBox cust_AddressTextBox;
        private System.Windows.Forms.TextBox custCityTextBox;
        private System.Windows.Forms.TextBox custStateTextBox;
        private System.Windows.Forms.TextBox custZipTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTransactions;
    }
}