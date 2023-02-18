namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // ������, ���������� ��� ������������
            object[] enums = new object[] { typeof(Color), typeof(Genre), typeof(EducationForm),
                                           typeof(Manufactures), typeof(Season), typeof(Weekday) }; 
            // ���������� ������������ � ListBox
            EnumsListBox.Items.AddRange(enums);                                                             
            EnumsListBox.SelectedIndex = 0;

            // ������, ���������� �������� ������������ Season
            var seasonValues = Enum.GetValues(typeof(Season));   
            //���������� HandleComboBox
            foreach (var seasonValue in seasonValues)                                                       
            {
                HandleComboBox.Items.Add(seasonValue);
            }
        }

        // ������ � ValuesListBox
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)                         
        {
            if (EnumsListBox.SelectedItem == null)
            {
                return;
            }

            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            // ������ �� ��������� ������������, ���������� �������������
            var enumValues = Enum.GetValues(selectedEnum);                                                 

            ValuesListBox.Items.Clear();
            IntTextBox.Clear();

            // ���������� ��������� ������������ � ValuesListBox
            foreach (var enumValue in enumValues)                                                           
            {
                ValuesListBox.Items.Add(enumValue);
            }
        }

        // ������ � IntTextBox
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)                         
        {
            if (ValuesListBox.SelectedItem == null)
            {
                return;
            }
            var selectedValue = (int)ValuesListBox.SelectedItem;
            IntTextBox.Text = selectedValue.ToString();
        }

        // ������ � ����� Weekday Parsing
        private void ParseButton_Click(object sender, EventArgs e)                                          
        {
            if (ParsingTextBox.Text == null)
            {
                return;
            }

            object EnteredDay;
            // ��������� �������������� ����������������� �����
            bool result = Enum.TryParse(typeof(Weekday), ParsingTextBox.Text, true, out EnteredDay);        

            int number;
            if (result)
            {
                // ��������� ������ ���������� ��� ������
                number = (int)EnteredDay + 1;                                                               
                ParsingAnswerLabel.Text = ($"��� ���� ������ ({EnteredDay} = {number})");
                return;
            }
            else
            {
                ParsingAnswerLabel.Text = ("��� ������ ��� ������");
            }
        }

        // ������ � ����� Season Handle
        private void HandleButton_Click(object sender, EventArgs e)                                         
        {
            // ��������� �������� ����� MainForm
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
            // ���������� �������� �� ��������� ������� �� HandleComboBox
            switch (selectedItem)                                                                          
            {
                case "Winter":
                    MessageBox.Show("����! �������!");
                    break;
                case "Summer":
                    MessageBox.Show("���! ������!");
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
                    MessageBox.Show("�������� ����� �� ����������� ������.");
                    break;
            }
        }
    }
}