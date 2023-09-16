﻿using ObjectOrientedPractices.Model;
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
    /// <summary>
    /// Содержит логику пользовательского элемента управления ItemsTab.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Коллекция объектов типа <see cref="Item"/>.
        /// </summary>
        private BindingList<Item> _items = new();

        /// <summary>
        /// Объект класса <see cref="Item"/>.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Счетчик элементов.
        /// </summary>
        private int _count;

        /// <summary>
        /// Создает объект типа <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            FillItemsListBox();
        }

        /// <summary>
        /// Заполняет ItemsListBox значениями из списка _items.
        /// </summary>
        private void FillItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        /// <summary>
        /// Обновляет ItemsListBox.
        /// </summary>
        private void UpdateItemsListBox()
        {
            ItemsListBox.DisplayMember = null;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        /// <summary>
        /// Очищает все поля.
        /// </summary>
        private void ClearAllTextBoxes()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
        }

        /// <summary>
        /// Заполняет поля и изменяет поле _currentItem
        /// при выборе элемента в ItemsListBox.
        /// Метод ожидает передачу значения не равного null, иначе очищает все поля.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                ClearAllTextBoxes();
                return;
            }
            _currentItem = _items[ItemsListBox.SelectedIndex];
            IdTextBox.Text = _currentItem.Id.ToString();
            NameTextBox.Text = _currentItem.Name.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            DescriptionTextBox.Text = _currentItem.Info.ToString();
        }

        /// <summary>
        /// Создает новый объект класса <see cref="Item"/> и добавляет его в список.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item("Item", " ", 0);
            _items.Add(_currentItem);
            ItemsListBox.SelectedItem = _currentItem;
            UpdateItemsListBox();
        }

        /// <summary>
        /// Создает несколько объектов класса <see cref="Item"/> и добавляет их в список. 
        /// </summary>
        private void AddListButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                _count++;
                _currentItem = new Item($"Item {_count}", " ", _count);
                _items.Add(_currentItem);
            }
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Удаляет выбранный объект из листа.
        /// Метод ожидает передачу значения не равного null.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                return;
            }
            _items.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Записывает в поле <see cref="Item.Cost"/> введенное значение.
        /// Принимает положительные числа.
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                return;
            }
            try
            {
                CostTextBox.BackColor = Color.White;
                _currentItem.Cost = Double.Parse(CostTextBox.Text);
            }
            catch
            {
                if (CostTextBox.Text != String.Empty)
                {
                    CostTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Записывает в поле <see cref="Item.Name"/> введенное значение.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                return;
            }
            try
            {
                NameTextBox.BackColor = Color.White;
                _currentItem.Name = NameTextBox.Text.ToString();
                UpdateItemsListBox();
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
        /// Записывает в поле <see cref="Item.Info"/> введенное значение.
        /// </summary>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                return;
            }
            try
            {
                DescriptionTextBox.BackColor = Color.White;
                _currentItem.Info = DescriptionTextBox.Text.ToString();
            }
            catch
            {
                if (DescriptionTextBox.Text != String.Empty)
                {
                    DescriptionTextBox.BackColor = Color.LightPink;
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
