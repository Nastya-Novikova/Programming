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
    public partial class DiscountsTab : UserControl
    {
        BindingList<Item> items = new BindingList<Item>() { new Item("Name", "Info", 38),
                                                            new Item("Name", "Info", 69),
                                                            new Item("Name","Info", 520)};
        PointsDiscount pointsDiscount = new PointsDiscount();

        public DiscountsTab()
        {
            InitializeComponent();
            FillLabels();
        }

        private void FillLabels()
        {
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }

            PointsLabel.Text = pointsDiscount.Info;
            CostLabel.Text = amount.ToString();
            DiscountLabel.Text = "0";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            DiscountLabel.Text = pointsDiscount.Calculate(items).ToString(); 
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }

            CostLabel.Text = (amount - pointsDiscount.Apply(items)).ToString();
            PointsLabel.Text = pointsDiscount.Info;
            DiscountLabel.Text = "0";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            pointsDiscount.Update(items);
            PointsLabel.Text = pointsDiscount.Info;
        }
    }
}
