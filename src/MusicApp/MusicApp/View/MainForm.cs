using MusicApp.Model.Classes;
using MusicApp.Model.Enums;
using System.ComponentModel;
using Song = MusicApp.Model.Classes.Song;
using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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

        /// <summary>
        /// ��� �����.
        /// </summary>
        private string _fileName;

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
            File.WriteAllText(_fileName, string.Empty);
            for (int i = 0; i < _songs.Count; i++)
            {
                File.AppendAllText(_fileName, JsonConvert.SerializeObject(_songs[i]));
            }
        }

        /// <summary>
        /// ������������� ���������� �� ����� (���� _songs).
        /// </summary>
        private void DeserializeData()
        {
            string directoryName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MusicApp");
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryName);
            if (!directoryInfo.Exists)
            {
                Directory.CreateDirectory(directoryName);
            }
            _fileName = Path.Combine(directoryName, "input.json");
            FileInfo fileInfo = new FileInfo(_fileName);
            if (fileInfo.Exists)
            {
                JsonTextReader reader = new JsonTextReader(new StreamReader(_fileName));
                reader.SupportMultipleContent = true;
                while (reader.Read())
                {
                    JsonSerializer serializer = new JsonSerializer();
                    Song tempSong = serializer.Deserialize<Song>(reader);
                    _songs.Add(tempSong);
                }
                reader.Close();
            }
            else
            {
                File.WriteAllText(_fileName, string.Empty);
            }
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
            SongForm songForm = new SongForm(new Song(), "Add new song");
            var dialogResult = songForm.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            if (FindMatches(songForm.currentSong))
            {
                _songs.Add(songForm.currentSong);
                SortAlphabetically();
                UpdateSongsListBox();
                SongsListBox.SelectedItem = songForm.currentSong;
                SerializeData();
            }
            else if (FindMatches(songForm.currentSong) == false)
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

            SongForm songForm = new SongForm((Song)_currentSong.Clone(), "Edit your song");
            var dialogResult = songForm.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            if (FindMatches(songForm.currentSong))
            {
                _currentSong.Name = songForm.currentSong.Name;
                _currentSong.Singer = songForm.currentSong.Singer;
                _currentSong.Duration = songForm.currentSong.Duration;
                _currentSong.Genre = songForm.currentSong.Genre;
                SortAlphabetically();
                UpdateSongsListBox();
                SongsListBox.SelectedItem = songForm.currentSong;
                SerializeData();
            }
            else if (FindMatches(songForm.currentSong) == false)
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