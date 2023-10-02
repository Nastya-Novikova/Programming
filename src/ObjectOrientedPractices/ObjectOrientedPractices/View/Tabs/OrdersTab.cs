using ObjectOrientedPractices.Model;
using System;
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
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Коллекция объектов типа <see cref="Customer"/>.
        /// </summary>
        private BindingList<Customer> _customers;

        private BindingList<Order> _orders = new BindingList<Order>();

        /// <summary>
        /// Возвращает и задает лист покупателей.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public OrdersTab()
        {
            InitializeComponent();
            FillStatusComboBox();
        }

        public void FillStatusComboBox()
        {
            var statusValues = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in statusValues)
            {
                StatusComboBox.Items.Add(status);
            }
        }
        public void RefreshData()
        {
            UpdateOrders();
        }
        private void UpdateOrders()
        {
            _orders.Clear(); ;
            foreach(Customer customer in Customers)
            {
                foreach(Order order in customer.Orders)
                {
                    _orders.Add(order);
                }
            }
            DataGridViewRowCollection rows = DataGridView.Rows;
            if (rows.Count != _orders.Count)
            {
                int HowManyRows = _orders.Count - rows.Count;
                for (int i = 0; i<HowManyRows; i++)
                {
                    rows.Add();
                }
            }
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                row.Cells[0].Value = _orders[row.Index].Id;
                row.Cells[1].Value = _orders[row.Index].Date;
                row.Cells[2].Value = _orders[row.Index].Status;
                for (int i=0; i<Customers.Count;i++)
                {
                    if (Customers[i].Id == _orders[row.Index].CustomerId)
                    {
                        row.Cells[3].Value = Customers[i].Fullname;
                    }
                }
                row.Cells[4].Value = GetAddress(_orders[row.Index].Address);
                row.Cells[5].Value = _orders[row.Index].Amount;
            }
        }

        private string GetAddress(Address address)
        {
            return $"{address.Index}, " +
                   $"{address.Country}, " +
                   $"{address.City}, " +
                   $"{address.Street}, " +
                   $"{address.Building}, " +
                   $"{address.Apartment}";
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow.Cells[0].Value == null)
            {
                DataGridView.ClearSelection();
                return;
            }
            ItemsListBox.Items.Clear();
            ItemsListBox.DisplayMember = nameof(Item.Name);
            var orderId = (int)DataGridView.CurrentRow.Cells[0].Value;
            IdTextBox.Text = orderId.ToString();
            DateTextBox.Text = DataGridView.CurrentRow.Cells[1].Value.ToString();
            StatusComboBox.SelectedItem = (OrderStatus)DataGridView.CurrentRow.Cells[2].Value;
            foreach (Order order in _orders)
            {
                if (orderId == order.Id)
                {
                    AddressControl.Address = order.Address;
                    foreach (Item item in order.Items)
                    {
                        ItemsListBox.Items.Add(item);
                    }
                }
            }
            CostLabel.Text = DataGridView.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
