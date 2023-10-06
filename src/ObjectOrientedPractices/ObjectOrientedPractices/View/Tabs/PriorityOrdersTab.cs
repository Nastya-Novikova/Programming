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
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Массив временных промежутков.
        /// </summary>
        private string[] _intervals = new string[] {"9:00 – 11:00",
                                                   "11:00 – 13:00",
                                                   "13:00 – 15:00",
                                                   "15:00 – 17:00",
                                                   "17:00 – 19:00",
                                                   "19:00 – 21:00"};
        /// <summary>
        /// Объект класса <see cref="PriorityOrder"/>.
        /// </summary>
        private PriorityOrder _order = new PriorityOrder(new Address(100000, "Country", "City", "Street", "Building", "Apartment"),
                                                        new BindingList<Item>(),
                                                        1,
                                                        "9:00 – 11:00");
        /// <summary>
        /// Счетчик товаров.
        /// </summary>
        private int _count = 0;

        /// <summary>
        /// Создает объект типа <see cref="PriorityOrdersTab"/>.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();
            FillTimeComboBox();
            FillStatusComboBox();
            FillTab();
        }

        /// <summary>
        /// Заполняет FillTimeComboBox.
        /// </summary>
        private void FillTimeComboBox()
        {
            TimeComboBox.Items.AddRange(_intervals);
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
        /// Заполняет поля на вкладке.
        /// </summary>
        private void FillTab()
        {
            IdTextBox.Text = _order.Id.ToString();
            DateTextBox.Text = _order.Date.ToString();
            StatusComboBox.SelectedItem = _order.Status;
            TimeComboBox.SelectedItem = _order.Interval;
            AddressControl.Address = _order.Address;
        }

        /// <summary>
        /// Присваивает в статус заказа выбранный статус в StatusComboBox.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _order.Status = (OrderStatus)StatusComboBox.SelectedItem;
        }

        /// <summary>
        /// Присваивает во временной интервал заказа интервал из TimeComboBox.
        /// </summary>
        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _order.Interval = TimeComboBox.SelectedItem.ToString();
        }

        /// <summary>
        /// Добавляет объект товара в листбокс и заказ. 
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _count++;
            Item newItem = new Item($"Item {_count}", " ", 100);
            _order.Items.Add(newItem);
            ItemsListBox.DisplayMember = nameof(Item.Name);
            ItemsListBox.Items.Add(newItem);
            CostLabel.Text = _order.Amount.ToString();
        }

        /// <summary>
        /// Удаляет товар из литсбокса и заказа.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            { 
                return; 
            }
            int index = ItemsListBox.SelectedIndex;
            ItemsListBox.Items.RemoveAt(index);
            _order.Items.RemoveAt(index);
            if (index == 0 && ItemsListBox.Items.Count > 0)
            {
                ItemsListBox.SelectedIndex = 0;
            }
            else if (index != 0 && ItemsListBox.Items.Count > 0)
            {
                ItemsListBox.SelectedIndex = index - 1;
            }
            else
            {
                ItemsListBox.SelectedIndex = -1;
            }
            CostLabel.Text = _order.Amount.ToString();
        }

        /// <summary>
        /// Очищает заказ, создает новый объект.
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Clear();
            DateTextBox.Clear();
            StatusComboBox.SelectedIndex = -1;
            TimeComboBox.SelectedIndex = -1;
            AddressControl.ClearAllTextBoxes();
            ItemsListBox.Items.Clear();
            CostLabel.Text = "0";
            _order = new PriorityOrder(new Address(100000, "Country", "City", "Street", "Building", "Apartment"),
                                                        new BindingList<Item>(),
                                                        1,
                                                        "9:00 – 11:00");
            FillTab();
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
        /// Контролирует ввод StatusComboBox.
        /// </summary>
        private void StatusComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Контролирует ввод в TimeComboBox.
        /// </summary>
        private void TimeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
