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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void cheathamCustomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cheathamCustomerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transactionFormDataSet);

        }

        private void cheathamCustomerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cheathamCustomerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transactionFormDataSet);

        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transactionFormDataSet.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.transactionFormDataSet.Transaction);
            // TODO: This line of code loads data into the 'transactionFormDataSet.CheathamCustomer' table. You can move, or remove it, as needed.
            this.cheathamCustomerTableAdapter.Fill(this.transactionFormDataSet.CheathamCustomer);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cheathamCustomerTableAdapter.FillBy(this.transactionFormDataSet.CheathamCustomer, ((int)(System.Convert.ChangeType(custAccountNumberToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cheathamCustomerTableAdapter.FillBy1(this.transactionFormDataSet.CheathamCustomer, custNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
