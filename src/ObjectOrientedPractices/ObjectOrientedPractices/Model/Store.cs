using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    public class Store
    {
        private BindingList<Item> _items;
        private BindingList<Customer> _customers;

        public BindingList<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public Store()
        {
            _items = new BindingList<Item>();
            _customers = new BindingList<Customer>();
        }
    }
}
