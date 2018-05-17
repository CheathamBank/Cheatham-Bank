using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheathamBank
{
    public partial class customers : Form
    {
        public customers()
        {
            InitializeComponent();
        }

        private void cheathamCustomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cheathamCustomerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersFormDataSet);
            custAccountNumberTextBox.ReadOnly = true;
            custAccountNumberTextBox.Cursor = Cursors.No;

        }

        private void customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersFormDataSet.CheathamCustomer' table. You can move, or remove it, as needed.
            this.cheathamCustomerTableAdapter.Fill(this.customersFormDataSet.CheathamCustomer);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            custAccountNumberTextBox.ReadOnly = false;
            custAccountNumberTextBox.Cursor = Cursors.IBeam;
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            Form Transactions = new Transactions();
            Transactions.ShowDialog();
        }
    }
}
