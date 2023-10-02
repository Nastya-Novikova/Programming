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
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers= _store.Customers;
        }

        /// <summary>
        /// Контролирует перемещение между TabControls.
        /// </summary>
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                CartsTab.RefreshData();
            }
            if (TabControl.SelectedIndex == 3)
            {
                OrdersTab.RefreshData();
            }
        }
    }
}