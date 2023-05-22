using MusicApp.Model.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Data = MusicApp.Model.Classes.Data;
using MusicApp.Model.Enums;

namespace MusicApp.View
{
    public partial class AdditionalForm : Form
    {
        public AdditionalForm()
        {
            InitializeComponent();
            FillGenreComboBox();
        }

        private void OkPictureBox_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                this.Close();
            }
        }

        private void FillGenreComboBox()
        {
            var genreValues = Enum.GetValues(typeof(Genre));
            foreach (var genre in genreValues)
            {
                GenreComboBox.Items.Add(genre);
            }
        }
        private bool CheckTextBox()
        {

            if (NameTextBox.Text == "" || NameTextBox.BackColor == Color.LightPink)
            {
                MessageBox.Show("Название песни должно содержать от 1 до 50 символов.");
                return false;
            }
            if (SingerTextBox.Text == "" || SingerTextBox.BackColor == Color.LightPink)
            {
                MessageBox.Show("Имя исполнителя должно содержать от 1 до 50 символов.");
                return false;
            }
            if (DurationTextBox.Text == "" || DurationTextBox.BackColor == Color.LightPink)
            {
                MessageBox.Show("Продолжительность песни должна быть от 1 до 7200 секунд.");
                return false;
            }
            if (GenreComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите жанр из выпадающего списка.");
                return false;
            }
            return true;
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Color.White;
                /*if (Data.Value.Name != null)
                {
                    return;
                }*/
                Data.Value.Name = Convert.ToString(NameTextBox.Text);
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void SingerTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SingerTextBox.BackColor = Color.White;
                Data.Value.Singer = Convert.ToString(SingerTextBox.Text);
            }
            catch
            {
                SingerTextBox.BackColor = Color.LightPink;
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationTextBox.BackColor = Color.White;
                Data.Value.Duration = Int32.Parse(DurationTextBox.Text);
            }
            catch
            {
                DurationTextBox.BackColor = Color.LightPink;
            }
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenreComboBox.SelectedIndex == -1)
            {
                return;
            }

            Data.Value.Genre = GenreComboBox.Text;
        }

        private void GenreComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
