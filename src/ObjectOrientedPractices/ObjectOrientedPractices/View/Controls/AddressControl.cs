using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model;


namespace ObjectOrientedPractices.View.Controls
{
    /// <summary>
    /// Содержит логику пользовательского элемента управления AddressControl.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// Вызывает заполнение текстбоксов.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                FillAllTextBoxes();
            }
        }

        /// <summary>
        /// Создает объект типа <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Очищает все текстбоксы.
        /// </summary>
        private void ClearAllTextBoxes()
        {
            IndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        /// <summary>
        /// Заполняет все текстбоксы. 
        /// Метод ожидает передачу значения не равного null, иначе очищает все текстбоксы.
        /// </summary>
        private void FillAllTextBoxes()
        {
            if (Address == null)
            {
                ClearAllTextBoxes();
                return;
            }
            if (Address.Index != 0)
            {
                IndexTextBox.Text = Address.Index.ToString();
            }
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;  
        }

        /// <summary>
        /// Записывает в поле <see cref="Address.Index"/> введенное значение.
        /// Если значение null поле не заполняется.
        /// </summary>
        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Address == null)
                {
                    return;
                }
                IndexTextBox.BackColor = Color.White;
                Address.Index = Int32.Parse(IndexTextBox.Text);
            }
            catch
            {
                if (IndexTextBox.Text != String.Empty)
                {
                    IndexTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Записывает в поле <see cref="Address.Country"/> введенное значение.
        /// Если значение null поле не заполняется.
        /// </summary>

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Address == null)
                {
                    return;
                }
                CountryTextBox.BackColor = Color.White;
                Address.Country = CountryTextBox.Text;
            }
            catch
            {
                if (CountryTextBox.Text != String.Empty)
                {
                    CountryTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Записывает в поле <see cref="Address.City"/> введенное значение.
        /// Если значение null поле не заполняется.
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Address == null)
                {
                    return;
                }
                CityTextBox.BackColor = Color.White;
                Address.City = CityTextBox.Text; 
            }
            catch
            {
                if (CityTextBox.Text != String.Empty)
                {
                    CityTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Записывает в поле <see cref="Address.Street"/> введенное значение.
        /// Если значение null поле не заполняется.
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Address == null)
                {
                    return;
                }
                StreetTextBox.BackColor = Color.White;
                Address.Street = StreetTextBox.Text;
            }
            catch
            {
                if (StreetTextBox.Text != String.Empty)
                {
                    StreetTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Записывает в поле <see cref="Address.Building"/> введенное значение.
        /// Если значение null поле не заполняется.
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Address == null)
                {
                    return;
                }
                BuildingTextBox.BackColor = Color.White;
                Address.Building = BuildingTextBox.Text;
            }
            catch
            {
                if (BuildingTextBox.Text != String.Empty)
                {
                    BuildingTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Записывает в поле <see cref="Address.Apartment"/> введенное значение.
        /// Если значение null поле не заполняется.
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Address == null)
                {
                    return;
                }
                ApartmentTextBox.BackColor = Color.White;
                Address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                if (ApartmentTextBox.Text != String.Empty)
                {
                    ApartmentTextBox.BackColor = Color.LightPink;
                }
            }
        }
    }
}
