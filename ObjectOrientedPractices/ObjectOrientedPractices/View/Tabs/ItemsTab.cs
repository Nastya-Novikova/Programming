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

        private void AddButton_Click(object sender, EventArgs e)
        {
            _items.Add(_currentItem);
            ItemsListBox.SelectedIndex = -1;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CostTextBox.BackColor = System.Drawing.Color.White;
                _currentItem.Cost = Double.Parse(CostTextBox.Text);
            }
            catch
            {
                CostTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = System.Drawing.Color.White;
                _currentItem.Name = Convert.ToString(NameTextBox.Text);
            }
            catch
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DescriptionTextBox.BackColor = System.Drawing.Color.White;
                _currentItem.Info = Convert.ToString(DescriptionTextBox.Text);
            }
            catch
            {
                DescriptionTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void IdTtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
