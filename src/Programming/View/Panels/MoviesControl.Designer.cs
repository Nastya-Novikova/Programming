namespace Programming.View.Panels
{
    partial class MoviesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviesButton = new System.Windows.Forms.Button();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.MoviesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.MoviesButton);
            this.MoviesGroupBox.Controls.Add(this.RatingLabel);
            this.MoviesGroupBox.Controls.Add(this.GenreLabel);
            this.MoviesGroupBox.Controls.Add(this.YearLabel);
            this.MoviesGroupBox.Controls.Add(this.DurationLabel);
            this.MoviesGroupBox.Controls.Add(this.NameLabel);
            this.MoviesGroupBox.Controls.Add(this.RatingTextBox);
            this.MoviesGroupBox.Controls.Add(this.GenreTextBox);
            this.MoviesGroupBox.Controls.Add(this.YearTextBox);
            this.MoviesGroupBox.Controls.Add(this.DurationTextBox);
            this.MoviesGroupBox.Controls.Add(this.NameTextBox);
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(476, 460);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MoviesButton
            // 
            this.MoviesButton.Location = new System.Drawing.Point(178, 357);
            this.MoviesButton.Margin = new System.Windows.Forms.Padding(22, 3, 22, 22);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.Size = new System.Drawing.Size(75, 25);
            this.MoviesButton.TabIndex = 17;
            this.MoviesButton.Text = "Find";
            this.MoviesButton.UseVisualStyleBackColor = true;
            this.MoviesButton.Click += new System.EventHandler(this.MoviesButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(178, 287);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(44, 15);
            this.RatingLabel.TabIndex = 15;
            this.RatingLabel.Text = "Rating:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(178, 220);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(41, 15);
            this.GenreLabel.TabIndex = 14;
            this.GenreLabel.Text = "Genre:";
            // 
            // YearLabel
            // 
            this.YearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(176, 153);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(32, 15);
            this.YearLabel.TabIndex = 13;
            this.YearLabel.Text = "Year:";
            // 
            // DurationLabel
            // 
            this.DurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(176, 86);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(56, 15);
            this.DurationLabel.TabIndex = 12;
            this.DurationLabel.Text = "Duration:";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(176, 19);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RatingTextBox.Location = new System.Drawing.Point(178, 309);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(22);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(200, 23);
            this.RatingTextBox.TabIndex = 11;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GenreTextBox.Location = new System.Drawing.Point(178, 242);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(22);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(200, 23);
            this.GenreTextBox.TabIndex = 10;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.YearTextBox.Location = new System.Drawing.Point(178, 175);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(22);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(200, 23);
            this.YearTextBox.TabIndex = 9;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DurationTextBox.Location = new System.Drawing.Point(178, 108);
            this.DurationTextBox.Margin = new System.Windows.Forms.Padding(22);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(200, 23);
            this.DurationTextBox.TabIndex = 8;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameTextBox.Location = new System.Drawing.Point(178, 41);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(22);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 23);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.IntegralHeight = false;
            this.MoviesListBox.ItemHeight = 15;
            this.MoviesListBox.Location = new System.Drawing.Point(3, 19);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(150, 438);
            this.MoviesListBox.TabIndex = 7;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MoviesGroupBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(476, 460);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox MoviesGroupBox;
        private Button MoviesButton;
        private Label RatingLabel;
        private Label GenreLabel;
        private Label YearLabel;
        private Label DurationLabel;
        private Label NameLabel;
        private TextBox RatingTextBox;
        private TextBox GenreTextBox;
        private TextBox YearTextBox;
        private TextBox DurationTextBox;
        private TextBox NameTextBox;
        private ListBox MoviesListBox;
    }
}
