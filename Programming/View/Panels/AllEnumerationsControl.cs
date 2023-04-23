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
    public partial class AllEnumerationsControl : UserControl
    {
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

        // работа с ValuesListBox
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

        // работа с IntTextBox
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
