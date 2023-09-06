namespace MusicApp.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EditPictureBox = new System.Windows.Forms.PictureBox();
            this.RemovePictureBox = new System.Windows.Forms.PictureBox();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.SongsListBox = new System.Windows.Forms.ListBox();
            this.SelectedSongGroupBox = new System.Windows.Forms.GroupBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.SingerLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.SingerTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            this.SelectedSongGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditPictureBox
            // 
            this.EditPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditPictureBox.Image = global::MusicApp.Properties.Resources.editSong_40x40;
            this.EditPictureBox.Location = new System.Drawing.Point(133, 377);
            this.EditPictureBox.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.EditPictureBox.Name = "EditPictureBox";
            this.EditPictureBox.Size = new System.Drawing.Size(40, 40);
            this.EditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditPictureBox.TabIndex = 8;
            this.EditPictureBox.TabStop = false;
            this.EditPictureBox.Click += new System.EventHandler(this.EditPictureBox_Click);
            // 
            // RemovePictureBox
            // 
            this.RemovePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemovePictureBox.Image = global::MusicApp.Properties.Resources.removeSong_40x40;
            this.RemovePictureBox.Location = new System.Drawing.Point(184, 377);
            this.RemovePictureBox.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.RemovePictureBox.Name = "RemovePictureBox";
            this.RemovePictureBox.Size = new System.Drawing.Size(40, 40);
            this.RemovePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemovePictureBox.TabIndex = 7;
            this.RemovePictureBox.TabStop = false;
            this.RemovePictureBox.Click += new System.EventHandler(this.RemovePictureBox_Click);
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddPictureBox.Image = global::MusicApp.Properties.Resources.addSong_40x40;
            this.AddPictureBox.Location = new System.Drawing.Point(80, 377);
            this.AddPictureBox.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(40, 40);
            this.AddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddPictureBox.TabIndex = 6;
            this.AddPictureBox.TabStop = false;
            this.AddPictureBox.Click += new System.EventHandler(this.AddPictureBox_Click);
            // 
            // SongsListBox
            // 
            this.SongsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SongsListBox.FormattingEnabled = true;
            this.SongsListBox.IntegralHeight = false;
            this.SongsListBox.ItemHeight = 20;
            this.SongsListBox.Location = new System.Drawing.Point(19, 20);
            this.SongsListBox.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.SongsListBox.Name = "SongsListBox";
            this.SongsListBox.Size = new System.Drawing.Size(301, 335);
            this.SongsListBox.TabIndex = 5;
            this.SongsListBox.SelectedIndexChanged += new System.EventHandler(this.SongsListBox_SelectedIndexChanged);
            // 
            // SelectedSongGroupBox
            // 
            this.SelectedSongGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedSongGroupBox.Controls.Add(this.GenreTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.GenreLabel);
            this.SelectedSongGroupBox.Controls.Add(this.DurationLabel);
            this.SelectedSongGroupBox.Controls.Add(this.SingerLabel);
            this.SelectedSongGroupBox.Controls.Add(this.NameLabel);
            this.SelectedSongGroupBox.Controls.Add(this.DurationTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.SingerTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedSongGroupBox.Location = new System.Drawing.Point(333, 20);
            this.SelectedSongGroupBox.Name = "SelectedSongGroupBox";
            this.SelectedSongGroupBox.Size = new System.Drawing.Size(455, 235);
            this.SelectedSongGroupBox.TabIndex = 9;
            this.SelectedSongGroupBox.TabStop = false;
            this.SelectedSongGroupBox.Text = "Selected Song";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(77, 158);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(151, 27);
            this.GenreTextBox.TabIndex = 18;
            this.GenreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GenreTextBox_KeyPress);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(22, 161);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(51, 20);
            this.GenreLabel.TabIndex = 17;
            this.GenreLabel.Text = "Genre:";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(3, 128);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(70, 20);
            this.DurationLabel.TabIndex = 16;
            this.DurationLabel.Text = "Duration:";
            // 
            // SingerLabel
            // 
            this.SingerLabel.AutoSize = true;
            this.SingerLabel.Location = new System.Drawing.Point(19, 95);
            this.SingerLabel.Name = "SingerLabel";
            this.SingerLabel.Size = new System.Drawing.Size(54, 20);
            this.SingerLabel.TabIndex = 15;
            this.SingerLabel.Text = "Singer:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(19, 62);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Name:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(77, 125);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(151, 27);
            this.DurationTextBox.TabIndex = 12;
            this.DurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DurationTextBox_KeyPress);
            // 
            // SingerTextBox
            // 
            this.SingerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SingerTextBox.Location = new System.Drawing.Point(77, 92);
            this.SingerTextBox.Name = "SingerTextBox";
            this.SingerTextBox.Size = new System.Drawing.Size(242, 27);
            this.SingerTextBox.TabIndex = 11;
            this.SingerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SingerTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(77, 59);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(242, 27);
            this.NameTextBox.TabIndex = 10;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.SelectedSongGroupBox);
            this.Controls.Add(this.EditPictureBox);
            this.Controls.Add(this.RemovePictureBox);
            this.Controls.Add(this.AddPictureBox);
            this.Controls.Add(this.SongsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicApp";
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            this.SelectedSongGroupBox.ResumeLayout(false);
            this.SelectedSongGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox EditPictureBox;
        private PictureBox RemovePictureBox;
        private PictureBox AddPictureBox;
        private ListBox SongsListBox;
        private GroupBox SelectedSongGroupBox;
        private Label GenreLabel;
        private Label DurationLabel;
        private Label SingerLabel;
        private Label NameLabel;
        private TextBox DurationTextBox;
        private TextBox SingerTextBox;
        private TextBox NameTextBox;
        private TextBox GenreTextBox;
    }
}