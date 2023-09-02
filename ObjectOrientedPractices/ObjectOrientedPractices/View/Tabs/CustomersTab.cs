using System;
using ObjectOrientedPractices.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractices.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private BindingList<Customer> _customers = new ();

        private Customer _currentCustomer = new Customer();

        private Customer _newCustomer;

        public CustomersTab()
        {
            InitializeComponent();
            FillCustomersListBox();
        }

        private void FillCustomersListBox()
        {
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = nameof(Customer.Fullname);
        }

        private void ClearAllTextBoxes()
        {
            IdTextBox.Clear();
            NameTextBox.Clear();
            AddressTextBox.Clear();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Color.White;
                _currentCustomer.Fullname = NameTextBox.Text.ToString();
            }
            catch
            {
                if (NameTextBox.Text != String.Empty)
                {
                    NameTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.BackColor = Color.White;
                _currentCustomer.Address = AddressTextBox.Text.ToString();
            }
            catch
            {
                if (AddressTextBox.Text != String.Empty)
                {
                    AddressTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
