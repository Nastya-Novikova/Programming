using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создает объект <see cref="AddDiscountForm"/>.
        /// Заполняет CategoryComboBox.
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
            FillCategoryComboBox();
        }

        /// <summary>
        /// Заполняет CategoryComboBox.
        /// </summary>
        private void FillCategoryComboBox()
        {
            var categoryValues = Enum.GetValues(typeof(Category));
            foreach(Category category in categoryValues)
            {
                CategoryComboBox.Items.Add(category);
            }
        }

        /// <summary>
        /// Присваивает в свойство Category выбранную категорию в CategoryComboBox.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == -1)
            {
                return;
            }
            Category = (Category)CategoryComboBox.SelectedItem;
        }

        /// <summary>
        /// Закрывает форму с результатом ОК.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex != -1)
            {
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Закрывает форму с результатом Cancel.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Контролирует ввод в CategoryComboBox.
        /// </summary>
        private void CategoryComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
