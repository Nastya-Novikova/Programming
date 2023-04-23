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
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (ParseTextBox.Text == null)
            {
                return;
            }

            object enteredDay;
            // результат преобразования пользовательского ввода
            bool result = Enum.TryParse(typeof(Weekday), ParseTextBox.Text, true, out enteredDay);

            if (result)
            {
                // получение номера введенного дня недели
                var number = (int)enteredDay + 1;
                ParseAnswerLabel.Text = ($"Это день недели ({enteredDay} = {number})");
                return;
            }
            else
            {
                ParseAnswerLabel.Text = ("Нет такого дня недели");
            }
        }
    }
}
