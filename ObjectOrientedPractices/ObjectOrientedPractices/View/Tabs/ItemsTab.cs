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
    public partial class ItemsTab : UserControl
    {
        private BindingList<Item> _items = new();

        private Item _currentItem = new Item();

        private Item _newItem;

        public ItemsTab()
        {
            InitializeComponent();
            FillItemsListBox();
        }

        private void FillItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        /*private void UpdateItemsListBox()
        {
            int index = ItemsListBox.SelectedIndex;
            ItemsListBox.DisplayMember = null;
            ItemsListBox.DisplayMember = nameof(Item.Name);
            ItemsListBox.SelectedIndex = index;
        }*/

        private void ClearAllTextBoxes()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                if (_currentItem == null)
                {
                    _currentItem = _newItem;
                }
                ClearAllTextBoxes();
                return;
            }
            _currentItem = _items[ItemsListBox.SelectedIndex];
            IdTextBox.Text = _currentItem.Id.ToString();
            NameTextBox.Text = _currentItem.Name.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            DescriptionTextBox.Text = _currentItem.Info.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null ||
                CostTextBox.Text == String.Empty ||
                NameTextBox.Text == String.Empty ||
                DescriptionTextBox.Text == String.Empty)
            {
                return;
            }
            _items.Add(_currentItem);
            _newItem = new Item();
            _currentItem = null;
            ItemsListBox.SelectedIndex = -1;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                return;
            }
            _currentItem = null;
            _items.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.SelectedIndex = -1;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            _currentItem = null;
            ItemsListBox.SelectedIndex = -1;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
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

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Color.White;
                _currentItem.Name = NameTextBox.Text.ToString();
                //UpdateItemsListBox();
            }
            catch
            {
                if (NameTextBox.Text != String.Empty)
                {
                    NameTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
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

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
