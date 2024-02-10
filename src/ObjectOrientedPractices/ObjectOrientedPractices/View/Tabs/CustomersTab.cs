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
using System.Reflection.Metadata.Ecma335;
using ObjectOrientedPractices.View.Controls;
using ObjectOrientedPractices.View.Forms;
using ObjectOrientedPractices.Model.Discounts;

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Содержит логику пользовательского элемента управления CustomersTab.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        public event EventHandler<EventArgs> CustomersChanged;

        /// <summary>
        /// Коллекция объектов типа <see cref="Customer"/>.
        /// </summary>
        private BindingList<Customer> _customers;

        /// <summary>
        /// Объект класса <see cref="Customer"/>.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Счетчик элементов.
        /// </summary>
        private int _count;

        /// <summary>
        /// Возвращает и задает лист покупателей.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Создает объект класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            FillCustomersListBox(); 
        }

        /// <summary>
        /// Заполняет CustomersListBox значениями из списка _customers.
        /// </summary>
        private void FillCustomersListBox()
        {
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = Customers;
            CustomersListBox.DisplayMember = nameof(Customer.Fullname);
        }

        /// <summary>
        /// Обновляет CustomersListBox.
        /// </summary>
        private void UpdateCustomersListBox()
        {
            CustomersListBox.DisplayMember = null;
            CustomersListBox.DisplayMember = nameof(Customer.Fullname);
        }

        /// <summary>
        /// Заполняет DiscountsListBox.
        /// </summary>
        private void FillDiscountsListBox()
        {
            if (CustomersListBox.SelectedItem == null)
            {
                return;
            }

            DiscountsListBox.Items.Clear();
            for (int i=0; i<_currentCustomer.Discounts.Count; i++)
            {
                DiscountsListBox.Items.Add(_currentCustomer.Discounts[i].Info);
            }
        }

        /// <summary>
        /// Очищает все поля.
        /// </summary>
        private void ClearAll()
        {
            IdTextBox.Clear();
            NameTextBox.Clear();
            AddressControl.Address = null;
            DiscountsListBox.Items.Clear();
        }

        /// <summary>
        /// Заполняет поля и изменяет поле _currentCustomer
        /// при выборе элемента в CustomersListBox.
        /// Метод ожидает передачу значения не равного null, иначе очищает все поля.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null)
            {
                ClearAll();
                return;
            }
            _currentCustomer = Customers[CustomersListBox.SelectedIndex];
            IdTextBox.Text = _currentCustomer.Id.ToString();
            NameTextBox.Text = _currentCustomer.Fullname.ToString();
            AddressControl.Address = _currentCustomer.Address;
            PriorityCheckBox.Checked = _currentCustomer.IsPriority;
            FillDiscountsListBox();
        }

        /// <summary>
        /// Создает новый объект класса <see cref="Customer"/> и добавляет его в список.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _count++;
            _currentCustomer = new Customer($"Customer {_count}");
            Customers.Add(_currentCustomer);
            CustomersChanged?.Invoke(sender, EventArgs.Empty);
            CustomersListBox.SelectedItem = _currentCustomer;
            FillCustomersListBox();
        }

        /// <summary>
        /// Создает несколько объектов класса <see cref="Customer"/> и добавляет их в список.
        /// </summary>
        private void AddListButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                _count++;
                _currentCustomer = new Customer($"Customer {_count}"); 
                Customers.Add(_currentCustomer);
                CustomersChanged?.Invoke(sender, EventArgs.Empty);
            }
            FillCustomersListBox();
            CustomersListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Удаляет выбранный объект из листа.
        /// Метод ожидает передачу значения не равного null.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null)
            {
                return;
            }
            Customers.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersChanged?.Invoke(sender, EventArgs.Empty);
            CustomersListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Добавляет процентные скидки в DiscountsListBox.
        /// </summary>
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null)
            {
                return;
            }
            AddDiscountForm addDiscountForm = new AddDiscountForm();
            var dialogResult =  addDiscountForm.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            _currentCustomer.Discounts.Add(new PercentDiscount(addDiscountForm.Category));
            CustomersChanged?.Invoke(sender, EventArgs.Empty);
            FillDiscountsListBox();
        }

        /// <summary>
        /// Удаляет процентную скидку из DiscountsListBox.
        /// Удаление накопительной скидки невозможно.
        /// </summary>
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null ||
                DiscountsListBox.SelectedItem == null ||
                DiscountsListBox.SelectedIndex == 0)
            {
                return;
            }

            _currentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
            DiscountsListBox.Items.Remove(DiscountsListBox.SelectedItem);
            CustomersChanged?.Invoke(sender, EventArgs.Empty);
        }

        /// <summary>
        /// Записывает в поле <see cref="Customer.Fullname"/> введенное значение.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null)
            {
                return;
            }
            try
            {
                NameTextBox.BackColor = Color.White;
                if (_currentCustomer.Fullname == NameTextBox.Text)
                {
                    return;
                }
                _currentCustomer.Fullname = NameTextBox.Text;
                CustomersChanged?.Invoke(sender, EventArgs.Empty);
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

        /// <summary>
        /// Контролирует ввод в IdTextBox.
        /// </summary>
        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Присваивает полю _currentCustomer значение true, если нажат чекбокс,
        /// иначе false.
        /// </summary>
        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PriorityCheckBox.Checked)
            {
                _currentCustomer.IsPriority = true;
            }
            else
            {
                _currentCustomer.IsPriority = false;
            }
            CustomersChanged?.Invoke(sender, EventArgs.Empty);
        }
    }
}
