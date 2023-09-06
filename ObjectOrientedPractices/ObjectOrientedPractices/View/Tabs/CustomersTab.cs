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

        private Customer _currentCustomer;

        private static int _count;

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

        private void UpdateCustomersListBox()
        {
            CustomersListBox.DisplayMember = null;
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
            if (CustomersListBox.SelectedItem == null)
            {
                ClearAllTextBoxes();
                return;
            }
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            IdTextBox.Text = _currentCustomer.Id.ToString();
            NameTextBox.Text = _currentCustomer.Fullname.ToString();
            AddressTextBox.Text = _currentCustomer.Address.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer("Customer", " ");
            _customers.Add(_currentCustomer);
            CustomersListBox.SelectedItem = _currentCustomer;
            UpdateCustomersListBox();
        }

        private void AddListButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                _count++;
                _currentCustomer = new Customer("Customer " + _count.ToString()," ");
                _customers.Add(_currentCustomer);
            }
            CustomersListBox.SelectedIndex = -1;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null)
            {
                return;
            }
            _customers.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.SelectedIndex = -1;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Color.White;
                _currentCustomer.Fullname = NameTextBox.Text.ToString();
                UpdateCustomersListBox();
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
