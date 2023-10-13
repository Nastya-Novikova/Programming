using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Discounts;
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
    public partial class PercentDiscountsTab : UserControl
    {
        BindingList<Item> items = new BindingList<Item>() { new Item("Name", "Info", 1000),
                                                            new Item("Name", "Info", 1069),
                                                            new Item("Name","Info", 520)};

        PercentDiscount discount = new PercentDiscount(Model.Enums.Category.HouseholdChemistry);
        public PercentDiscountsTab()
        {
            InitializeComponent();
            FillItemsCategory();
            FillLabels();
        }

        private void FillItemsCategory()
        {
            items[0].Category = Model.Enums.Category.HouseholdChemistry;
            items[1].Category = Model.Enums.Category.ProductsForChildren;
            items[2].Category = Model.Enums.Category.PetProducts;
        }

        private void FillLabels()
        {
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }

            PointsLabel.Text = discount.Info;
            CostLabel.Text = amount.ToString();
            DiscountLabel.Text = "0";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            DiscountLabel.Text = discount.Calculate(items).ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }

            CostLabel.Text = (amount - discount.Apply(items)).ToString();
            DiscountLabel.Text = "0";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            discount.Update(items);
            PointsLabel.Text = discount.Info;
        }
    }
}
