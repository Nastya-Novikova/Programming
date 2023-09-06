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
    /// <summary>
    /// Содержит логику пользовательского элемента управления SeasonsControl.
    /// </summary>
    public partial class SeasonsControl : UserControl
    {
        /// <summary>
        /// Создает объект типа <see cref="SeasonsControl"/>.
        /// </summary>
        public SeasonsControl()
        {
            InitializeComponent();

            var seasonValues = Enum.GetValues(typeof(Season));
            FillHandleComboBox(seasonValues);
        }

        /// <summary>
        /// Заполняет HandleComboBox.
        /// </summary>
        /// <param name="seasonValues">Массив, содержащий перечисление <see cref="Season"/></param>
        private void FillHandleComboBox(Array seasonValues)
        {
            foreach (var seasonValue in seasonValues)
            {
                HandleComboBox.Items.Add(seasonValue);
            }
        }

        /// <summary>
        /// Проверяет введенное значение на совпадение с элементами перечисления <see cref="Season"/>.
        /// В зависимости от совпадения выполняет определенную логику.
        /// Метод ожидает передачу значения не равного null.
        /// </summary>
        private void HandleButton_Click(object sender, EventArgs e)
        {
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
