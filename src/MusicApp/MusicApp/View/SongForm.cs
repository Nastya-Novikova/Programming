﻿using MusicApp.Model.Classes;
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
using MusicApp.Model.Enums;

namespace MusicApp.View
{
    /// <summary>
    /// Реализовывает логику работы дополнительной формы.
    /// </summary>
    public partial class SongForm : Form
    {
        /// <summary>
        /// Содержит объект класса <see cref="Song">.
        /// </summary>
        public Song currentSong { get; set;}

        public SongForm(Song song, string title)
        {
            InitializeComponent();
            currentSong = song;
            FillGenreComboBox();
            FillAllTextBox();
            this.Text = title;
        }

        /// <summary>
        /// Закрывает дополнительную форму, если все условия выполнены.
        /// </summary>
        private void OkPictureBox_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                this.Close();
            }
        }

        /// <summary>
        /// Заполняет GenreComboBox значениями перечисления <see cref="Genre"/>.
        /// </summary>
        private void FillGenreComboBox()
        {
            var genreValues = Enum.GetValues(typeof(Genre));
            foreach (var genre in genreValues)
            {
                GenreComboBox.Items.Add(genre);
            }
        }

        /// <summary>
        /// Запоняет все текстбоксы.
        /// </summary>
        private void FillAllTextBox()
        {
            NameTextBox.Text = currentSong.Name;
            SingerTextBox.Text = currentSong.Singer;
            if (currentSong.Duration != 0)
            {
                DurationTextBox.Text = currentSong.Duration.ToString();
            }
            GenreComboBox.Text = currentSong.Genre;
        }

        /// <summary>
        /// Провеяет наличие текста в текстбоксах и его правильность.
        /// </summary>
        /// <returns>Возвращает true, если все верно, иначе false.</returns>
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
            DialogResult = DialogResult.OK; 
            return true;
        }

        /// <summary>
        /// Отправляет в Data.Value.Name введенный текст.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Color.White;
                currentSong.Name = Convert.ToString(NameTextBox.Text);
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Отправляет в Data.Value.Singer введенный текст.
        /// </summary>
        private void SingerTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SingerTextBox.BackColor = Color.White;
                currentSong.Singer = Convert.ToString(SingerTextBox.Text);
            }
            catch
            {
                SingerTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Отправляет в Data.Value.Duration введенный текст.
        /// </summary>
        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationTextBox.BackColor = Color.White;
                currentSong.Duration = Int32.Parse(DurationTextBox.Text);
            }
            catch
            {
                DurationTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Отправляет в Data.Value.Genre выбранный жанр.
        /// </summary>
        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenreComboBox.SelectedIndex == -1)
            {
                return;
            }

            currentSong.Genre = GenreComboBox.Text;
        }

        /// <summary>
        /// Контролирует ввод в GenreComboBox.
        /// </summary>
        private void GenreComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CancelPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
