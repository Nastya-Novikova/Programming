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

        /// <summary>
        /// Коллекция объектов типа <see cref="Order"/>.
        /// </summary>
        private BindingList<Order> _orders = new BindingList<Order>();

        /// <summary>
        /// Выбранный в таблице заказ.
        /// </summary>
        private Order _selectedOrder;

        /// <summary>
        /// Выбранный в таблице приоритетный заказ.
        /// </summary>
        private PriorityOrder _selectedPriorityOrder;

        /// <summary>
        /// Возвращает и задает выбранный приоритетный заказ.
        /// </summary>
        public PriorityOrder? SelectedPriorityOrder
        {
            get { return _selectedPriorityOrder; }
            set { _selectedPriorityOrder = value; }
        }

        /// <summary>
        /// Возвращает и задает выбранный заказ.
        /// Если заказ является приоритетным присваивает его в SelectedPriorityOrder.
        /// </summary>
        public Order SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                if (value is PriorityOrder)
                {
                    SelectedPriorityOrder = (PriorityOrder)value;
                    OptionsPanel.Visible = true;
                    TimeComboBox.SelectedItem = SelectedPriorityOrder.Interval;
                }
                else
                {
                    SelectedPriorityOrder = null;
                    OptionsPanel.Visible = false;
                }
                _selectedOrder = value;
            }
        }

        /// <summary>
        /// Возвращает и задает лист покупателей.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Создает объект типа <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            FillStatusComboBox();
            FillTimeComboBox();
        }

        /// <summary>
        /// Обновляет данные в _orders, DataGridView, очищает выбор.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
            UpdateDataGridView();
            Clear();
        }

        /// <summary>
        /// Заполняет StatusComboBox.
        /// </summary>
        private void FillStatusComboBox()
        {
            var statusValues = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in statusValues)
            {
                StatusComboBox.Items.Add(status);
            }
        }

        /// <summary>
        /// Заполняет TimeComboBox.
        /// </summary>
        private void FillTimeComboBox()
        {
            string[] intervals = new string[] {"9:00 – 11:00",
                                                "11:00 – 13:00",
                                                "13:00 – 15:00",
                                                "15:00 – 17:00",
                                                "17:00 – 19:00",
                                                "19:00 – 21:00"};
            TimeComboBox.Items.AddRange(intervals);
        }

        /// <summary>
        /// Обновляет список _orders.
        /// </summary>
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
        }

        /// <summary>
        /// Обновляет таблицу DataGridView.
        /// </summary>
        private void UpdateDataGridView()
        {
            DataGridViewRowCollection rows = DataGridView.Rows;
            if (rows.Count != _orders.Count)
            {
                int HowManyRows = _orders.Count - rows.Count;
                for (int i = 0; i < HowManyRows; i++)
                {
                    rows.Add();
                }
            }
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                if (_orders[row.Index] is PriorityOrder)
                {
                    row.Cells[0].Value = Properties.Resources.Star;
                }
                else
                {
                    row.Cells[0].Value = Properties.Resources.White;
                }
                row.Cells[1].Value = _orders[row.Index].Id;
                row.Cells[2].Value = _orders[row.Index].Date;
                row.Cells[3].Value = _orders[row.Index].Status;
                for (int i = 0; i < Customers.Count; i++)
                {
                    if (Customers[i].Id == _orders[row.Index].CustomerId)
                    {
                        row.Cells[4].Value = Customers[i].Fullname;
                    }
                }
                row.Cells[5].Value = GetAddress(_orders[row.Index].Address);
                row.Cells[6].Value = _orders[row.Index].Amount;
            }
        }

        /// <summary>
        /// Формирует адрес в строку.
        /// </summary>
        /// <param name="address">Объект класса <see cref="Address"/>.</param>
        /// <returns>Строка с адресом.</returns>
        private string GetAddress(Address address)
        {
            return $"{address.Index}, " +
                   $"{address.Country}, " +
                   $"{address.City}, " +
                   $"{address.Street}, " +
                   $"{address.Building}, " +
                   $"{address.Apartment}";
        }

        /// <summary>
        /// Заполняет текстбоксы в соответствии с выбранной строкой в таблице.
        /// </summary>
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow.Cells[1].Value == null)
            {
                return;
            }

            ItemsListBox.Items.Clear();
            ItemsListBox.DisplayMember = nameof(Item.Name);
            var orderId = (int)DataGridView.CurrentRow.Cells[1].Value;
            foreach (Order order in _orders)
            {
                if (orderId == order.Id)
                {
                    SelectedOrder = order;
                }
            }
            IdTextBox.Text = SelectedOrder.Id.ToString();
            DateTextBox.Text = SelectedOrder.Date;
            StatusComboBox.SelectedItem = SelectedOrder.Status;
            AddressControl.Address = SelectedOrder.Address;
            foreach (Item item in SelectedOrder.Items)
            {
                ItemsListBox.Items.Add(item);
            }
            CostLabel.Text = SelectedOrder.Amount.ToString();
        }

        /// <summary>
        /// Обновляет статус заказа на выбранный в StatusComboBox.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null || StatusComboBox.SelectedIndex == -1)
            {
                return;
            }
            DataGridView.CurrentRow.Cells[3].Value = StatusComboBox.SelectedItem;
            SelectedOrder.Status = (OrderStatus)StatusComboBox.SelectedItem;
        }

        /// <summary>
        /// Обновляет время доставки на выбранное в TimeComboBox.
        /// </summary>
        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null || TimeComboBox.SelectedIndex == -1)
            {
                return;
            }
            SelectedPriorityOrder.Interval = TimeComboBox.SelectedItem.ToString();
        }

        /// <summary>
        /// Очищает выбор, все поля.
        /// </summary>
        private void Clear()
        {
            DataGridView.ClearSelection();
            IdTextBox.Clear();
            DateTextBox.Clear();
            StatusComboBox.SelectedIndex = -1;
            AddressControl.ClearAllTextBoxes();
            ItemsListBox.Items.Clear();
            CostLabel.Text = "0";
            OptionsPanel.Visible = false;
        }

        /// <summary>
        /// Контролирует ввод в IdTextBox.
        /// </summary>
        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Контролирует ввод в DateTextBox.
        /// </summary>
        private void DateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Контролирует ввод в StatusComboBox.
        /// </summary>
        private void StatusComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
