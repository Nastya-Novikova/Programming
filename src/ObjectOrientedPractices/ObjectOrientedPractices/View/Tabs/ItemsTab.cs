using Microsoft.VisualBasic;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Enums;
using ObjectOrientedPractices.Services;
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
        /// Объект класса <see cref="Random"/>.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Коллекция объектов типа <see cref="Item"/>.
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// Объект класса <see cref="Item"/>.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Счетчик элементов.
        /// </summary>
        private int _count;

        /// <summary>
        /// Стоимость заказа.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Текст в поисковой строке.
        /// </summary>
        private string _line;

        /// <summary>
        /// Отображаемые элементы.
        /// </summary>
        private BindingList<Item> _displayedItems;

        /// <summary>
        /// Возвращает и задает лист товаров.
        /// </summary>
        public BindingList<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Создает объект класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            FillCategoryComboBox();
            FillOrderByComboBox();
            FillItemsListBox(Items);
        }

        /// <summary>
        /// Заполняет CategoryComboBox значениями <see cref="Category"/>.
        /// </summary>
        private void FillCategoryComboBox()
        {
            var categoryValues = Enum.GetValues(typeof(Category));
            foreach (var category in categoryValues)
            {
                CategoryComboBox.Items.Add(category);
            }
        }

        /// <summary>
        /// Заполняет OrderByComboBox.
        /// </summary>
        private void FillOrderByComboBox()
        {
            string[] values = new string[] { "Name (Ascending)",
                                             "Cost (Ascending)",
                                             "Cost (Descending)"};
            OrderByComboBox.Items.AddRange(values);
            OrderByComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Заполняет ItemsListBox значениями из списка _items.
        /// </summary>
        private void FillItemsListBox(BindingList<Item> items)
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = items;
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
            CategoryComboBox.SelectedItem = null;
        }

        /// <summary>
        /// Выбирает товары, в названии которых содержится введенная подстрока.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <returns>true, если подстрока содержится, иначе false.</returns>
        private bool FilterByName(Item item)
        {
            return item.Name.Contains(_line);
        }

        /// <summary>
        /// Сортирует товары в алфавитном порядке.
        /// </summary>
        /// <param name="firstItem">Первый товар.</param>
        /// <param name="secondItem">Второй товар.</param>
        /// <returns>true, если название первого товара должно
        /// стоять после названия второго, иначе false.</returns>
        private bool SortByName(Item firstItem, Item secondItem)
        {
            if (String.Compare(firstItem.Name, secondItem.Name) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Сортирует товары по возрастанию цены.
        /// </summary>
        /// <param name="firstItem">Первый товар.</param>
        /// <param name="secondItem">Второй товар.</param>
        /// <returns>true, если цена первого больше цены второго, иначе false.</returns>
        private bool SortByAscendingCost(Item firstItem, Item secondItem)
        {
            if (firstItem.CompareTo(secondItem) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Сортирует товары по убыванию цены.
        /// </summary>
        /// <param name="firstItem">Первый товар.</param>
        /// <param name="secondItem">Второй товар.</param>
        /// <returns>true, если цена первого меньше цены второго, иначе false.</returns>
        private bool SortByDescendingCost(Item firstItem, Item secondItem)
        {
            if (firstItem.CompareTo(secondItem) < 0)
            {
                return true;
            }
            return false;
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
            if (FindTextBox.Text != String.Empty)
            {
                _currentItem = _displayedItems[ItemsListBox.SelectedIndex];
            }
            else
            {
                _currentItem = Items[ItemsListBox.SelectedIndex];
            }
            IdTextBox.Text = _currentItem.Id.ToString();
            NameTextBox.Text = _currentItem.Name;
            CostTextBox.Text = _currentItem.Cost.ToString();
            DescriptionTextBox.Text = _currentItem.Info;
            CategoryComboBox.Text = _currentItem.Category.ToString();
        }

        /// <summary>
        /// Создает новый объект класса <see cref="Item"/> и добавляет его в список.
        /// Сортирует товары.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FindTextBox.Text != String.Empty)
            {
                return;
            }
            int number = _random.Next(24);
            string name = Convert.ToString((FoodItemNames)number);
            _cost = Math.Round(_random.NextDouble() * 100 + 1);
            _currentItem = new Item(name, " ", _cost);
            Items.Add(_currentItem);
            ItemsListBox.SelectedItem = _currentItem;
            SortItemsListBox();
            FillItemsListBox(Items);
        }
   
        /// <summary>
        /// Создает несколько объектов класса <see cref="Item"/> и добавляет их в список. 
        /// Сортирует товары.
        /// </summary>
        private void AddListButton_Click(object sender, EventArgs e)
        {
            if (FindTextBox.Text != String.Empty)
            {
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                int number = _random.Next(24);
                string name = Convert.ToString((FoodItemNames)number);
                _cost = Math.Round(_random.NextDouble() * 100 + 1);
                _currentItem = new Item(name, " ", _cost);
                Items.Add(_currentItem);
            }
            ItemsListBox.DataSource = null;
            SortItemsListBox();
            FillItemsListBox(Items);
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
            var selectedItem = ItemsListBox.SelectedItem;
            if (FindTextBox.Text != String.Empty)
            {
                _displayedItems.Remove((Item)selectedItem);
            }
            Items.Remove((Item)selectedItem);
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
        /// Выводит товары по введенной подстроке.
        /// </summary>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text == String.Empty)
            {
                SortItemsListBox();
                FillItemsListBox(Items);
                return;
            }
            _line = FindTextBox.Text;
            _displayedItems = DataTools.Filter(Items, FilterByName);
            FillItemsListBox(_displayedItems);
        }

        /// <summary>
        /// Записывает в поле <see cref="Item.Category"/> выбранное значение.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                return;
            }
            _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
        }

        /// <summary>
        /// Сортирует товары по выбранному способу.
        /// </summary>
        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0)
            {
                return;
            }
            SortItemsListBox();
        }

        /// <summary>
        /// Сортирует товары по выбранному способу.
        /// </summary>
        private void SortItemsListBox()
        {
            var selectedItem = ItemsListBox.SelectedItem;
            BindingList<Item> items = new BindingList<Item>();
            if (FindTextBox.Text != String.Empty)
            {
                items = _displayedItems;
            }
            else
            {
                items = Items;
            }

            if (OrderByComboBox.SelectedIndex == 0)
            {
                DataTools.Sort(items, SortByName);
                ItemsListBox.SelectedItem = selectedItem;
            }
            else if (OrderByComboBox.SelectedIndex == 1)
            {
                DataTools.Sort(items, SortByAscendingCost);
                ItemsListBox.SelectedItem = selectedItem;
            }
            else
            {
                DataTools.Sort(items, SortByDescendingCost);
                ItemsListBox.SelectedItem = selectedItem;
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
        /// Контролирует ввод в комбобокс.
        /// </summary>
        private void CategoryComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Контролирует обновление листбокса.
        /// </summary>
        private void ItemsListBox_Leave(object sender, EventArgs e)
        {
            ItemsListBox.Update();
        }
    }
}
