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
using Color = Programming.Model.Enums.Color;

namespace Programming.View.Panels
{
    /// <summary>
    /// Содержит логику пользовательского элемента управления AllEnumerationsControl.
    /// </summary>
    public partial class AllEnumerationsControl : UserControl
    {
        /// <summary>
        /// Создает объект типа <see cref="AllEnumerationsControl"/>.
        /// </summary>
        public AllEnumerationsControl()
        {
            InitializeComponent();

            // массив, содержащий все перечисления
            object[] enums = new object[]
            {
                typeof(Color),
                typeof(Genre),
                typeof(EducationForm),
                typeof(Manufactures),
                typeof(Season),
                typeof(Weekday)
            };
            // добавление перечислений в EnumsListBox
            EnumsListBox.DisplayMember = nameof(Type.Name);
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Отображает в ValuesListBox коллекцию элементов из выбранного перечисления.
        /// Метод ожидает передачу значения не равного null.
        /// </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedItem == null)
            {
                return;
            }

            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            // массив из элементов перечисления, выбранного пользователем
            var enumValues = Enum.GetValues(selectedEnum);

            ValuesListBox.Items.Clear();
            IntTextBox.Clear();

            // добавление элементов перечисления в ValuesListBox
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
        }

        /// <summary>
        /// Отображает в IntTextBox индекс элемента, выбранного в ValuesListBox.
        /// Метод ожидает передачу значения не равного null.
        /// </summary>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem == null)
            {
                return;
            }
            var selectedValue = (int)ValuesListBox.SelectedItem;
            IntTextBox.Text = selectedValue.ToString();
        }
    }
}
