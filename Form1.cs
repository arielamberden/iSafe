using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'issuerDataSet.cardholder' table. You can move, or remove it, as needed.
            this.cardholderTableAdapter.Fill(issuerDataSet.cardholder);
            // TODO: This line of code loads data into the 'issuerDataSet.merchant' table. You can move, or remove it, as needed.
            this.merchantTableAdapter.Fill(this.issuerDataSet.merchant);
            // TODO: This line of code loads data into the 'issuerDataSet.trnsaction' table. You can move, or remove it, as needed.
            this.trnsactionTableAdapter.Fill(this.issuerDataSet.trnsaction);
            // TODO: This line of code loads data into the 'issuerDataSet.account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.issuerDataSet.account);
        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cardholderBindingSource.EndEdit();
                this.accountBindingSource1.EndEdit();
                this.merchantBindingSource.EndEdit();
                this.trnsactionBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.issuerDataSet);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
   
        private void accountBindingSource1_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.cardholderBindingSource.EndEdit();
        }

        private void trnsactionBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.cardholderBindingSource.EndEdit();
            this.merchantBindingSource.EndEdit();
        }
    }
}
