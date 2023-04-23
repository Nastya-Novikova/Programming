using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class SeasonsControl : UserControl
    {
        public SeasonsControl()
        {
            InitializeComponent();

            var seasonValues = Enum.GetValues(typeof(Season));
            FillHandleComboBox(seasonValues);
        }

        private void FillHandleComboBox(Array seasonValues)
        {
            foreach (var seasonValue in seasonValues)
            {
                HandleComboBox.Items.Add(seasonValue);
            }
        }
        // работа с окном Season Handle
        private void HandleButton_Click(object sender, EventArgs e)
        {
            // установка базового цвета MainForm
            this.BackColor = AppColor.White;
            SeasonGroupBox.BackColor = AppColor.White;

            if (HandleComboBox.Text == null)
            {
                return;
            }

            string selectedItem = Convert.ToString(HandleComboBox.SelectedItem);
            // реализация действия на выбранный элемент из HandleComboBox
            switch (selectedItem)
            {
                case "Winter":
                    {
                        MessageBox.Show("Бррр! Холодно!");
                        break;
                    }
                case "Summer":
                    {
                        MessageBox.Show("Ура! Солнце!");
                        break;
                    }
                case "Autumn":
                    {
                        var orange = AppColor.AutumnOrange;
                        this.BackColor = orange;
                        SeasonGroupBox.BackColor = orange;
                        break;
                    }
                case "Spring":
                    {
                        var green = AppColor.SpringGreen;
                        this.BackColor = green;
                        SeasonGroupBox.BackColor = green;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Выберете сезон из выпадающего списка.");
                        break;
                    }
            }
        }
    }
}
