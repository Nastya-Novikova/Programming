namespace MusicApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            AdditionalForm newForm = new AdditionalForm();
            newForm.Show();
        }

        private void EditPictureBox_Click(object sender, EventArgs e)
        {
            AdditionalForm newForm = new AdditionalForm();
            newForm.Show();
        }
    }
}