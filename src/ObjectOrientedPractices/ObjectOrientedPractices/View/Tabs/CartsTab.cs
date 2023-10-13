using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Orders;
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
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Коллекция объектов типа <see cref="Item"/>.
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// Коллекция объектов типа <see cref="Customer"/>.
        /// </summary>
        private BindingList<Customer> _customers;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Возвращает и задает выбранного покупателя.
        /// </summary>
        private Customer CurrentCustomer { get; set; }

        /// <summary>
        /// Возвращает и задает лист товаров.
        /// </summary>
        public BindingList<Item> Items
        {
            get { return _items; }
            set { _items = value; }
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
        /// Создает объект класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
            FillItemsListBox();
            FillCustomersComboBox();
        }

        /// <summary>
        /// Обновляет данные в CustomersComboBox и ItemsListBox.
        /// </summary>
        public void RefreshData()
        {
            FillCustomersComboBox();
            FillItemsListBox();
        }

        /// <summary>
        /// Заполняет ItemsListBox.
        /// </summary>
        private void FillItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = Items;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        /// <summary>
        /// Заполняет CartListBox.
        /// </summary>
        private void UpdateCartListBox()
        {
            CartListBox.DataSource = null;
            CartListBox.DataSource = CurrentCustomer.Cart.Items;
            CartListBox.DisplayMember = nameof(Item.Name);
        }

        /// <summary>
        /// Заполняет CustomersComboBox.
        /// </summary>
        private void FillCustomersComboBox()
        {
            CustomersComboBox.DataSource = null;
            CustomersComboBox.DataSource = Customers;
            CustomersComboBox.DisplayMember = nameof(Customer.Fullname);
        }

        /// <summary>
        /// Изменяет поле СurrentCustomer и обновляет корзину и ее общую стоимость 
        /// при выборе элемента в CustomersComboBox.
        /// </summary>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedItem == null)
            {
                return;
            }
            CurrentCustomer = Customers[CustomersComboBox.SelectedIndex];
            UpdateCartListBox();
            UpdateCartAmount();
            CartListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Добавляет в корзину товар из списка Items.
        /// Обновляет общую стоимость корзины.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null || CustomersComboBox.SelectedItem == null)
            {
                return;
            }
            _currentItem = Items[ItemsListBox.SelectedIndex];
            CurrentCustomer.Cart.Items.Add(_currentItem);
            UpdateCartAmount();
            CartListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Удаляет товар из корзины и обновляет общую стоимость.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedItem == null)
            {
                return;
            }
            CurrentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
            UpdateCartAmount();
            CartListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Очищает корзину, обновляет общую стоимость.
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items == null || CartListBox.Items.Count == 0)
            {
                return;
            }
            CurrentCustomer.Cart.Items.Clear();
            UpdateCartAmount();
        }

        /// <summary>
        /// Создает новый объект класса <see cref="Order"/> или <see cref="PriorityOrder"/> и добавляет его в список заказов.
        /// </summary>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items == null || CartListBox.Items.Count == 0)
            {
                return;
            }
            if (CurrentCustomer.IsPriority)
            {
                PriorityOrder currentOrder = new PriorityOrder(CurrentCustomer.Address, CurrentCustomer.Cart.Items,
                                                               CurrentCustomer.Id);
                CurrentCustomer.Orders.Add(currentOrder);
            }
            else
            {
                Order currentOrder = new Order(CurrentCustomer.Address, CurrentCustomer.Cart.Items,
                                          CurrentCustomer.Id);
                CurrentCustomer.Orders.Add(currentOrder);
            }
            CurrentCustomer.Cart.Items = new BindingList<Item>();
            CartListBox.DataSource = CurrentCustomer.Cart.Items;
            UpdateCartAmount();
            MessageBox.Show("Заказ создан.");
        }

        /// <summary>
        /// Обновляет общую стоимость корзины.
        /// </summary>
        private void UpdateCartAmount()
        {
            CostLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// Контролирует обновление листбокса.
        /// </summary>
        private void ItemsListBox_Leave(object sender, EventArgs e)
        {
            ItemsListBox.Update();
        }

        /// <summary>
        /// Контроллирует обновление листбокса.
        /// </summary>
        private void CartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartListBox.Update();
        }

        /// <summary>
        /// Контролирует ввод в CustomersComboBox.
        /// </summary>
        private void CustomersComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
