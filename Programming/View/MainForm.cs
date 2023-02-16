using System.Windows.Forms;
using System.Linq;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            object[] enums = new object[] { typeof(Color), typeof(Genre), typeof(EducationForm), typeof(Manufactures), typeof(Season), typeof(Weekday) };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedItem == null)
            {
                return;
            }

            var selectedEnum = (Type)EnumsListBox.SelectedItem;

            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();
            IntTextBox.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
        }

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