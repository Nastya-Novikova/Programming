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
        /// Передает данные в <see cref="ItemsTab"/>, <see cref="CustomersTab"/>,
        /// <see cref="CartsTab"/>, <see cref="OrdersTab"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers= _store.Customers;
            ItemsTab.ItemsChanged += ItemsTab_ItemsChanged;
            CustomersTab.CustomersChanged += CustomersTab_CustomersChanged;

        }

        private void ItemsTab_ItemsChanged(object sender, EventArgs args)
        {
            //CartsTab.RefreshData();
            //OrdersTab.RefreshData();
        }

        private void CustomersTab_CustomersChanged(object sender, EventArgs args)
        {
            //CartsTab.RefreshData();
            //OrdersTab.RefreshData();
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