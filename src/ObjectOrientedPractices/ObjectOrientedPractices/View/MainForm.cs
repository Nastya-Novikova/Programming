using ObjectOrientedPractices.Model;

namespace ObjectOrientedPractices
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект класса <see cref="Store"/>.
        /// </summary>
        private Store _store = new Store();

        /// <summary>
        /// Создает объект класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
        }
    }
}