namespace CheathamBank
{
    partial class Transactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cheathamCustomerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.cheathamCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionFormDataSet = new CheathamBank.transactionFormDataSet();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.custNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.custZipTextBox = new System.Windows.Forms.TextBox();
            this.custCityTextBox = new System.Windows.Forms.TextBox();
            this.custStateTextBox = new System.Windows.Forms.TextBox();
            this.cust_AddressTextBox = new System.Windows.Forms.TextBox();
            this.custAccountNumberToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.custAccountNumberToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.cheathamCustomerTableAdapter = new CheathamBank.transactionFormDataSetTableAdapters.CheathamCustomerTableAdapter();
            this.tableAdapterManager = new CheathamBank.transactionFormDataSetTableAdapters.TableAdapterManager();
            this.transactionTableAdapter = new CheathamBank.transactionFormDataSetTableAdapters.TransactionTableAdapter();
            this.custNameComboBox = new System.Windows.Forms.ComboBox();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.custNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.custNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.cheathamCustomerBindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheathamCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionFormDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cheathamCustomerBindingNavigator
            // 
            this.cheathamCustomerBindingNavigator.AddNewItem = null;
            this.cheathamCustomerBindingNavigator.BindingSource = this.cheathamCustomerBindingSource;
            this.cheathamCustomerBindingNavigator.CountItem = null;
            this.cheathamCustomerBindingNavigator.DeleteItem = null;
            this.cheathamCustomerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cheathamCustomerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cheathamCustomerBindingNavigator.MoveFirstItem = null;
            this.cheathamCustomerBindingNavigator.MoveLastItem = null;
            this.cheathamCustomerBindingNavigator.MoveNextItem = null;
            this.cheathamCustomerBindingNavigator.MovePreviousItem = null;
            this.cheathamCustomerBindingNavigator.Name = "cheathamCustomerBindingNavigator";
            this.cheathamCustomerBindingNavigator.PositionItem = null;
            this.cheathamCustomerBindingNavigator.Size = new System.Drawing.Size(795, 25);
            this.cheathamCustomerBindingNavigator.TabIndex = 0;
            this.cheathamCustomerBindingNavigator.Text = "bindingNavigator1";
            // 
            // cheathamCustomerBindingSource
            // 
            this.cheathamCustomerBindingSource.DataMember = "CheathamCustomer";
            this.cheathamCustomerBindingSource.DataSource = this.transactionFormDataSet;
            // 
            // transactionFormDataSet
            // 
            this.transactionFormDataSet.DataSetName = "transactionFormDataSet";
            this.transactionFormDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "FK_Transaction_ToCheathamCustomer";
            this.transactionBindingSource.DataSource = this.cheathamCustomerBindingSource;
            // 
            // transactionDataGridView
            // 
            this.transactionDataGridView.AllowUserToAddRows = false;
            this.transactionDataGridView.AutoGenerateColumns = false;
            this.transactionDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.transactionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.transactionDataGridView.DataSource = this.transactionBindingSource;
            this.transactionDataGridView.Location = new System.Drawing.Point(12, 244);
            this.transactionDataGridView.Name = "transactionDataGridView";
            this.transactionDataGridView.ReadOnly = true;
            this.transactionDataGridView.RowTemplate.Height = 24;
            this.transactionDataGridView.Size = new System.Drawing.Size(763, 220);
            this.transactionDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransactionNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "TransactionNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustAccountNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustAccountNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TransactionType";
            this.dataGridViewTextBoxColumn3.HeaderText = "TransactionType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TransactionDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "TransactionDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TransactionAmount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "TransactionAmount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.custNameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 143);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // custNameTextBox
            // 
            this.custNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "CustName", true));
            this.custNameTextBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameTextBox.Location = new System.Drawing.Point(42, 63);
            this.custNameTextBox.Name = "custNameTextBox";
            this.custNameTextBox.ReadOnly = true;
            this.custNameTextBox.Size = new System.Drawing.Size(156, 29);
            this.custNameTextBox.TabIndex = 19;
            this.custNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.custZipTextBox);
            this.groupBox2.Controls.Add(this.custCityTextBox);
            this.groupBox2.Controls.Add(this.custStateTextBox);
            this.groupBox2.Controls.Add(this.cust_AddressTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(418, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 143);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // custZipTextBox
            // 
            this.custZipTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custZipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "CustZip", true));
            this.custZipTextBox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custZipTextBox.Location = new System.Drawing.Point(244, 68);
            this.custZipTextBox.Name = "custZipTextBox";
            this.custZipTextBox.ReadOnly = true;
            this.custZipTextBox.Size = new System.Drawing.Size(100, 22);
            this.custZipTextBox.TabIndex = 22;
            // 
            // custCityTextBox
            // 
            this.custCityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "CustCity", true));
            this.custCityTextBox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custCityTextBox.Location = new System.Drawing.Point(32, 68);
            this.custCityTextBox.Name = "custCityTextBox";
            this.custCityTextBox.ReadOnly = true;
            this.custCityTextBox.Size = new System.Drawing.Size(100, 22);
            this.custCityTextBox.TabIndex = 21;
            // 
            // custStateTextBox
            // 
            this.custStateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "CustState", true));
            this.custStateTextBox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custStateTextBox.Location = new System.Drawing.Point(138, 68);
            this.custStateTextBox.Name = "custStateTextBox";
            this.custStateTextBox.ReadOnly = true;
            this.custStateTextBox.Size = new System.Drawing.Size(100, 22);
            this.custStateTextBox.TabIndex = 1;
            // 
            // cust_AddressTextBox
            // 
            this.cust_AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cust_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "Cust Address", true));
            this.cust_AddressTextBox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_AddressTextBox.Location = new System.Drawing.Point(32, 33);
            this.cust_AddressTextBox.Name = "cust_AddressTextBox";
            this.cust_AddressTextBox.ReadOnly = true;
            this.cust_AddressTextBox.Size = new System.Drawing.Size(188, 22);
            this.cust_AddressTextBox.TabIndex = 20;
            // 
            // custAccountNumberToolStripLabel
            // 
            this.custAccountNumberToolStripLabel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAccountNumberToolStripLabel.Name = "custAccountNumberToolStripLabel";
            this.custAccountNumberToolStripLabel.Size = new System.Drawing.Size(140, 27);
            this.custAccountNumberToolStripLabel.Text = "Account Number";
            // 
            // custAccountNumberToolStripTextBox
            // 
            this.custAccountNumberToolStripTextBox.Name = "custAccountNumberToolStripTextBox";
            this.custAccountNumberToolStripTextBox.Size = new System.Drawing.Size(100, 30);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(66, 27);
            this.fillByToolStripButton.Text = "Search";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.custAccountNumberToolStripLabel,
            this.custAccountNumberToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(795, 30);
            this.fillByToolStrip.TabIndex = 17;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // cheathamCustomerTableAdapter
            // 
            this.cheathamCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheathamCustomerTableAdapter = this.cheathamCustomerTableAdapter;
            this.tableAdapterManager.TransactionTableAdapter = this.transactionTableAdapter;
            this.tableAdapterManager.UpdateOrder = CheathamBank.transactionFormDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // custNameComboBox
            // 
            this.custNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheathamCustomerBindingSource, "CustName", true));
            this.custNameComboBox.DataSource = this.cheathamCustomerBindingSource;
            this.custNameComboBox.DisplayMember = "CustName";
            this.custNameComboBox.FormattingEnabled = true;
            this.custNameComboBox.Location = new System.Drawing.Point(282, 105);
            this.custNameComboBox.Name = "custNameComboBox";
            this.custNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.custNameComboBox.TabIndex = 20;
            this.custNameComboBox.ValueMember = "CustAccountNumber";
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.custNameToolStripLabel,
            this.custNameToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 55);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(795, 27);
            this.fillBy1ToolStrip.TabIndex = 21;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // custNameToolStripLabel
            // 
            this.custNameToolStripLabel.Name = "custNameToolStripLabel";
            this.custNameToolStripLabel.Size = new System.Drawing.Size(80, 24);
            this.custNameToolStripLabel.Text = "CustName:";
            // 
            // custNameToolStripTextBox
            // 
            this.custNameToolStripTextBox.Name = "custNameToolStripTextBox";
            this.custNameToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(56, 24);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 484);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.custNameComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.transactionDataGridView);
            this.Controls.Add(this.cheathamCustomerBindingNavigator);
            this.Name = "Transactions";
            this.Text = "Transactions -:|:- Cheatham Bank ";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cheathamCustomerBindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheathamCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionFormDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private transactionFormDataSet transactionFormDataSet;
        private System.Windows.Forms.BindingSource cheathamCustomerBindingSource;
        private transactionFormDataSetTableAdapters.CheathamCustomerTableAdapter cheathamCustomerTableAdapter;
        private transactionFormDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cheathamCustomerBindingNavigator;
        private transactionFormDataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.DataGridView transactionDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox custNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox custZipTextBox;
        private System.Windows.Forms.TextBox custCityTextBox;
        private System.Windows.Forms.TextBox custStateTextBox;
        private System.Windows.Forms.TextBox cust_AddressTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripLabel custAccountNumberToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox custAccountNumberToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ComboBox custNameComboBox;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel custNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox custNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}