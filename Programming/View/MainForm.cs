namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            object[] enums = new object[] { typeof(Color), typeof(Genre), typeof(EducationForm),
                                           typeof(Manufactures), typeof(Season), typeof(Weekday) };         //массив, содержащий все перечисления
            EnumsListBox.Items.AddRange(enums);                                                             //добавление перечислений в ListBox
            EnumsListBox.SelectedIndex = 0;

            var seasonValues = Enum.GetValues(typeof(Season));                                              //массив, содержащий элементы перечисления Season
            foreach (var seasonValue in seasonValues)                                                       //заполнение HandleComboBox
            {
                HandleComboBox.Items.Add(seasonValue);
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)                          //работа с ValuesListBox
        {
            if (EnumsListBox.SelectedItem == null)
            {
                return;
            }

            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);                                                  //массив из элементов перечисления, выбранного пользователем

            ValuesListBox.Items.Clear();
            IntTextBox.Clear();

            foreach (var enumValue in enumValues)                                                           //добавление элементов перечисления в ValuesListBox
            {
                ValuesListBox.Items.Add(enumValue);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)                         //работа с IntTextBox
        {
            if (ValuesListBox.SelectedItem == null)
            {
                return;
            }
            var selectedValue = (int)ValuesListBox.SelectedItem;
            IntTextBox.Text = selectedValue.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)                                          //работа с окном Weekday Parsing
        {
            if (ParsingTextBox.Text == null)
            {
                return;
            }

            object EnteredDay;
            bool result = Enum.TryParse(typeof(Weekday), ParsingTextBox.Text, true, out EnteredDay);        //результат преобразования пользовательского ввода

            int number;
            if (result)
            {
                number = (int)EnteredDay + 1;                                                               //получение номера введенного дня недели
                ParsingAnswerLabel.Text = ($"Это день недели ({EnteredDay} = {number})");
                return;
            }
            else
            {
                ParsingAnswerLabel.Text = ("Нет такого дня недели");
            }
        }

        private void HandleButton_Click(object sender, EventArgs e)                                         //работа с окном Season Handle
        {
            this.BackColor = System.Drawing.Color.White;                                                    //установка базового цвета MainForm
            EnumsGroupBox.BackColor = System.Drawing.Color.White;
            WeekdayGroupBox.BackColor = System.Drawing.Color.White;
            SeasonGroupBox.BackColor = System.Drawing.Color.White;
            EnumsTabPage.BackColor = System.Drawing.Color.White;

            if (HandleComboBox.Text == null)
            {
                return;
            }

            string selectedItem = Convert.ToString(HandleComboBox.SelectedItem);
            switch (selectedItem)                                                                           //реализация действия на выбранный элемент из HandleComboBox
            {
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    var orange = System.Drawing.ColorTranslator.FromHtml("#e29c45");
                    this.BackColor = orange;
                    EnumsGroupBox.BackColor = orange;
                    WeekdayGroupBox.BackColor = orange;
                    SeasonGroupBox.BackColor = orange;
                    EnumsTabPage.BackColor = orange;
                    break;
                case "Spring":
                    var green = System.Drawing.ColorTranslator.FromHtml("#559c45");
                    this.BackColor = green;
                    EnumsGroupBox.BackColor = green;
                    WeekdayGroupBox.BackColor = green;
                    SeasonGroupBox.BackColor = green;
                    EnumsTabPage.BackColor = green;
                    break;
                default:
                    MessageBox.Show("Выберете сезон из выпадающего списка.");
                    break;
            }
        }
    }
}