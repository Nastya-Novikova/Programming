namespace MusicApp
{
    partial class AdditionalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalForm));
            this.SelectedSongGroupBox = new System.Windows.Forms.GroupBox();
            this.OkPictureBox = new System.Windows.Forms.PictureBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.SingerLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.SingerTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedSongGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedSongGroupBox
            // 
            this.SelectedSongGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedSongGroupBox.Controls.Add(this.OkPictureBox);
            this.SelectedSongGroupBox.Controls.Add(this.GenreLabel);
            this.SelectedSongGroupBox.Controls.Add(this.DurationLabel);
            this.SelectedSongGroupBox.Controls.Add(this.SingerLabel);
            this.SelectedSongGroupBox.Controls.Add(this.NameLabel);
            this.SelectedSongGroupBox.Controls.Add(this.GenreComboBox);
            this.SelectedSongGroupBox.Controls.Add(this.DurationTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.SingerTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedSongGroupBox.Location = new System.Drawing.Point(48, 26);
            this.SelectedSongGroupBox.Name = "SelectedSongGroupBox";
            this.SelectedSongGroupBox.Size = new System.Drawing.Size(455, 235);
            this.SelectedSongGroupBox.TabIndex = 10;
            this.SelectedSongGroupBox.TabStop = false;
            this.SelectedSongGroupBox.Text = "Your Song";
            // 
            // OkPictureBox
            // 
            this.OkPictureBox.Image = global::MusicApp.Properties.Resources.ok_40x40;
            this.OkPictureBox.Location = new System.Drawing.Point(409, 189);
            this.OkPictureBox.Name = "OkPictureBox";
            this.OkPictureBox.Size = new System.Drawing.Size(40, 40);
            this.OkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OkPictureBox.TabIndex = 11;
            this.OkPictureBox.TabStop = false;
            this.OkPictureBox.Click += new System.EventHandler(this.OkPictureBox_Click);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(114, 161);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(51, 20);
            this.GenreLabel.TabIndex = 17;
            this.GenreLabel.Text = "Genre:";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(97, 128);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(70, 20);
            this.DurationLabel.TabIndex = 16;
            this.DurationLabel.Text = "Duration:";
            // 
            // SingerLabel
            // 
            this.SingerLabel.AutoSize = true;
            this.SingerLabel.Location = new System.Drawing.Point(113, 95);
            this.SingerLabel.Name = "SingerLabel";
            this.SingerLabel.Size = new System.Drawing.Size(54, 20);
            this.SingerLabel.TabIndex = 15;
            this.SingerLabel.Text = "Singer:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(113, 62);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Name:";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(171, 158);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(151, 28);
            this.GenreComboBox.TabIndex = 13;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(171, 125);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(151, 27);
            this.DurationTextBox.TabIndex = 12;
            // 
            // SingerTextBox
            // 
            this.SingerTextBox.Location = new System.Drawing.Point(171, 92);
            this.SingerTextBox.Name = "SingerTextBox";
            this.SingerTextBox.Size = new System.Drawing.Size(151, 27);
            this.SingerTextBox.TabIndex = 11;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(171, 59);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(151, 27);
            this.NameTextBox.TabIndex = 10;
            // 
            // AdditionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 296);
            this.Controls.Add(this.SelectedSongGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdditionalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Or Edit Song";
            this.SelectedSongGroupBox.ResumeLayout(false);
            this.SelectedSongGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OkPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox SelectedSongGroupBox;
        private Label GenreLabel;
        private Label DurationLabel;
        private Label SingerLabel;
        private Label NameLabel;
        private ComboBox GenreComboBox;
        private TextBox DurationTextBox;
        private TextBox SingerTextBox;
        private TextBox NameTextBox;
        private PictureBox OkPictureBox;
    }
}