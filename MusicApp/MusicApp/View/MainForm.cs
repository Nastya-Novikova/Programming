using MusicApp.Model.Classes;
using MusicApp.Model.Enums;
using System.ComponentModel;
using Song = MusicApp.Model.Classes.Song;
using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text.RegularExpressions;

namespace MusicApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ��������� �������� ���� <see cref="Song"/>.
        /// </summary>
        private List<Song> _songs = new List<Song>();

        /// <summary>
        /// ������ ������ <see cref="Song"/>.
        /// </summary>
        private Song _currentSong;

        public MainForm()
        {
            InitializeComponent();
            DeserializeData();
            FillSongsListBox();
        }

        /// <summary>
        /// ����������� ���� _songs � ���������� � ����.
        /// </summary>
        private void SerializeData()
        {
            File.WriteAllText("input.json", string.Empty);
            for (int i = 0; i < _songs.Count; i++)
            {
                File.AppendAllText("input.json", JsonConvert.SerializeObject(_songs[i]));
            }
        }

        /// <summary>
        /// ������������� ���������� �� ����� (���� _songs).
        /// </summary>
        private void DeserializeData()
        {
            JsonTextReader reader = new JsonTextReader(new StreamReader("input.json"));
            reader.SupportMultipleContent = true;
            while (reader.Read())
            {
                JsonSerializer serializer = new JsonSerializer();
                Song tempSong = serializer.Deserialize<Song>(reader);
                _songs.Add(tempSong);
            }
            reader.Close();
        }

        /// <summary>
        /// ��������� SongsListBox ���������� �� _songs.
        /// </summary>
        private void FillSongsListBox()
        {
            SongsListBox.DisplayMember = nameof(Song.Info);
            SongsListBox.DataSource = _songs;
        }

        /// <summary>
        /// ��������� SongsListBox ��� ��������� _songs.
        /// </summary>
        private void UpdateSongsListBox()
        {
            SongsListBox.DataSource = null;
            SongsListBox.DataSource = _songs;
            SongsListBox.DisplayMember = nameof(Song.Info);
        }

        /// <summary>
        /// ��������� _songs � ���������� �������.
        /// ������� �� �����������, ������ ���� - �� �������� �����.
        /// </summary>
        private void SortAlphabetically()
        {
             var sortedSongs = from song in _songs
                               orderby song.Singer, song.Name
                               select song;
             _songs = sortedSongs.ToList();
        }

        /// <summary>
        /// ��������� ���� �� � ������ _songs ����������� �����.
        /// </summary>
        /// <param name="song">����������� �����.</param>
        /// <returns>���������� true ���� ������ �� �����������, ����� false.</returns>
        private bool FindMatches(Song song)
        {
            for (int i = 0; i < _songs.Count; i++)
            {
                if (String.Compare(_songs[i].Name, song.Name, true) == 0 &&
                    String.Compare(_songs[i].Singer, song.Singer, true) == 0 &&
                    _songs[i].Duration == song.Duration &&
                    String.Compare(_songs[i].Genre, song.Genre, true) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// ������� ��� ����������.
        /// </summary>
        private void ClearSongsInfo()
        {
            NameTextBox.Clear();
            SingerTextBox.Clear();
            DurationTextBox.Clear();
            GenreTextBox.Clear();
        }

        /// <summary>
        /// ��������� ���������� � �������� ���� _currentSong ��� 
        /// ������ �������� � SongsListBox.
        /// ����� ������� �������� �������� �� ������� null, ����� ������� ��� ����.
        /// </summary>
        private void SongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SongsListBox.SelectedItem == null)
            {
                ClearSongsInfo();
                return;
            }

            _currentSong = _songs[SongsListBox.SelectedIndex];
            NameTextBox.Text = _currentSong.Name.ToString();
            SingerTextBox.Text = _currentSong.Singer.ToString();
            DurationTextBox.Text = _currentSong.Duration.ToString();
            GenreTextBox.Text = _currentSong.Genre.ToString();
        }

        /// <summary>
        /// ��������� ����� ����� � ���� _songs. �������� ����������. 
        /// </summary>
        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            Data.Value = new Song();
            Data.Flag = false;
            AdditionalForm f = new AdditionalForm();
            f.ShowDialog();
            if (Data.Flag == true && FindMatches(Data.Value))
            {
                _songs.Add(Data.Value);
                SortAlphabetically();
                UpdateSongsListBox();
                SongsListBox.SelectedItem = Data.Value;
                SerializeData();
            }
            else if (FindMatches(Data.Value) == false)
            {
                MessageBox.Show("����� ������ ��� ����������.");
            }
        }

        /// <summary>
        /// ������������ ����� � ����� _songs. �������� ����������.
        /// ����� ������� �������� �������� �� ������� null, ����� �� �����������.
        /// </summary>
        private void EditPictureBox_Click(object sender, EventArgs e)
        {
            if (SongsListBox.SelectedItem == null)
            {
                return;
            }
            Data.Flag = false;
            Data.Value = new Song(_currentSong.Name, _currentSong.Singer,
                                  _currentSong.Duration, _currentSong.Genre);
            AdditionalForm f = new AdditionalForm();
            f.ShowDialog();
            if (Data.Flag == true && FindMatches(Data.Value))
            {
                _currentSong.Name = Data.Value.Name;
                _currentSong.Singer = Data.Value.Singer;
                _currentSong.Duration = Data.Value.Duration;
                _currentSong.Genre = Data.Value.Genre;
                Data.Value = _currentSong;
                SortAlphabetically();
                UpdateSongsListBox();
                SongsListBox.SelectedItem = Data.Value;
                SerializeData();
            }
            else if (FindMatches(Data.Value) == false)
            {
                MessageBox.Show("����� ������ ��� ����������.");
            }
        }

        /// <summary>
        /// ������� ��������� ����� �� ����� _songs.
        /// </summary>
        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
            if (SongsListBox.SelectedItem == null)
            {
                return;
            }
            _songs.RemoveAt(SongsListBox.SelectedIndex);
            UpdateSongsListBox();
            SongsListBox.SelectedIndex = -1;
            _currentSong = null;
            SerializeData();
        }

        /// <summary>
        /// ������������ ���� � NameTextBox.
        /// </summary>
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ������������ ���� � SingerTextBox.
        /// </summary>
        private void SingerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ������������ ���� � DurationTextBox.
        /// </summary>
        private void DurationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ������������ ���� � GenreTextBox.
        /// </summary>
        private void GenreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }
    }
}