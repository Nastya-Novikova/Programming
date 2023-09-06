﻿using System;
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

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Содержит логику пользовательского элемента управления CustomersTab.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Коллекция объектов типа <see cref="Customer"/>.
        /// </summary>
        private BindingList<Customer> _customers = new ();

        /// <summary>
        /// Объект класса <see cref="Customer"/>.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Счетчик элементов.
        /// </summary>
        private static int _count;

        /// <summary>
        /// Создает объект типа <see cref="CustomersTab"/>.
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
            CustomersListBox.DataSource = _customers;
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
        /// Очищает все поля.
        /// </summary>
        private void ClearAllTextBoxes()
        {
            IdTextBox.Clear();
            NameTextBox.Clear();
            AddressTextBox.Clear();
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
                ClearAllTextBoxes();
                return;
            }
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            IdTextBox.Text = _currentCustomer.Id.ToString();
            NameTextBox.Text = _currentCustomer.Fullname.ToString();
            AddressTextBox.Text = _currentCustomer.Address.ToString();
        }

        /// <summary>
        /// Создает новый объект класса <see cref="Customer"/> и добавляет его в список.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer("Customer", " ");
            _customers.Add(_currentCustomer);
            CustomersListBox.SelectedItem = _currentCustomer;
            UpdateCustomersListBox();
        }

        /// <summary>
        /// Создает несколько объектов класса <see cref="Customer"/> и добавляет их в список.
        /// </summary>
        private void AddListButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                _count++;
                _currentCustomer = new Customer($"Customer {_count}", " ");
                _customers.Add(_currentCustomer);
            }
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
            _customers.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.SelectedIndex = -1;
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

        /// <summary>
        /// Записывает в поле <see cref="Customer.Address"/> введенное значение.
        /// </summary>
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null)
            {
                return;
            }
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

        /// <summary>
        /// Контролирует ввод в IdTextBox.
        /// </summary>
        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
