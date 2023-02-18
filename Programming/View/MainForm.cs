namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // массив, содержащий все перечисления
            object[] enums = new object[] { typeof(Color), typeof(Genre), typeof(EducationForm),
                                           typeof(Manufactures), typeof(Season), typeof(Weekday) }; 
            // добавление перечислений в ListBox
            EnumsListBox.Items.AddRange(enums);                                                             
            EnumsListBox.SelectedIndex = 0;

            // массив, содержащий элементы перечисления Season
            var seasonValues = Enum.GetValues(typeof(Season));   
            //заполнение HandleComboBox
            foreach (var seasonValue in seasonValues)                                                       
            {
                HandleComboBox.Items.Add(seasonValue);
            }
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

        // работа с окном Weekday Parsing
        private void ParseButton_Click(object sender, EventArgs e)                                          
        {
            if (ParsingTextBox.Text == null)
            {
                return;
            }

            object EnteredDay;
            // результат преобразования пользовательского ввода
            bool result = Enum.TryParse(typeof(Weekday), ParsingTextBox.Text, true, out EnteredDay);        

            int number;
            if (result)
            {
                // получение номера введенного дня недели
                number = (int)EnteredDay + 1;                                                               
                ParsingAnswerLabel.Text = ($"Это день недели ({EnteredDay} = {number})");
                return;
            }
            else
            {
                ParsingAnswerLabel.Text = ("Нет такого дня недели");
            }
        }

        // работа с окном Season Handle
        private void HandleButton_Click(object sender, EventArgs e)                                         
        {
            // установка базового цвета MainForm
            this.BackColor = System.Drawing.Color.White;                                                    
            EnumsGroupBox.BackColor = System.Drawing.Color.White;
            WeekdayGroupBox.BackColor = System.Drawing.Color.White;
            SeasonGroupBox.BackColor = System.Drawing.Color.White;
            EnumsTabPage.BackColor = System.Drawing.Color.White;

            if (HandleComboBox.Text == null)
            {
                return;
            }

            string selectedItem = Convert.ToString(HandleComboBox.SelectedItem);
            // реализация действия на выбранный элемент из HandleComboBox
            switch (selectedItem)                                                                          
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