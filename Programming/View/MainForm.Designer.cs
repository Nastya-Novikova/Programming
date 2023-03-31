namespace Programming.View
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
            this.ProgrammingTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.ParsingAnswerLabel = new System.Windows.Forms.Label();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.HandleLabel = new System.Windows.Forms.Label();
            this.HandleButton = new System.Windows.Forms.Button();
            this.HandleComboBox = new System.Windows.Forms.ComboBox();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.ClassesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MoviesGroupBox1 = new System.Windows.Forms.GroupBox();
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.CenterGroupBox = new System.Windows.Forms.GroupBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesButton = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.ProgrammingTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.ClassesTableLayoutPanel.SuspendLayout();
            this.MoviesGroupBox1.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.CenterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgrammingTabControl
            // 
            this.ProgrammingTabControl.Controls.Add(this.EnumsTabPage);
            this.ProgrammingTabControl.Controls.Add(this.ClassesTabPage);
            this.ProgrammingTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgrammingTabControl.Location = new System.Drawing.Point(0, 0);
            this.ProgrammingTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.ProgrammingTabControl.Name = "ProgrammingTabControl";
            this.ProgrammingTabControl.SelectedIndex = 0;
            this.ProgrammingTabControl.Size = new System.Drawing.Size(979, 507);
            this.ProgrammingTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.tableLayoutPanelMain);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 24);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.EnumsTabPage.Size = new System.Drawing.Size(971, 479);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.EnumsGroupBox, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.5595F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.4405F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(967, 475);
            this.tableLayoutPanelMain.TabIndex = 3;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.WeekdayGroupBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.SeasonGroupBox, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(2, 280);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(963, 193);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.ParsingAnswerLabel);
            this.WeekdayGroupBox.Controls.Add(this.ParseLabel);
            this.WeekdayGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayGroupBox.Controls.Add(this.ParsingTextBox);
            this.WeekdayGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayGroupBox.Location = new System.Drawing.Point(2, 2);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(477, 189);
            this.WeekdayGroupBox.TabIndex = 0;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // ParsingAnswerLabel
            // 
            this.ParsingAnswerLabel.AutoSize = true;
            this.ParsingAnswerLabel.Location = new System.Drawing.Point(12, 101);
            this.ParsingAnswerLabel.Margin = new System.Windows.Forms.Padding(10);
            this.ParsingAnswerLabel.Name = "ParsingAnswerLabel";
            this.ParsingAnswerLabel.Size = new System.Drawing.Size(0, 15);
            this.ParsingAnswerLabel.TabIndex = 9;
            // 
            // ParseLabel
            // 
            this.ParseLabel.AutoSize = true;
            this.ParseLabel.Location = new System.Drawing.Point(9, 47);
            this.ParseLabel.Name = "ParseLabel";
            this.ParseLabel.Size = new System.Drawing.Size(125, 15);
            this.ParseLabel.TabIndex = 8;
            this.ParseLabel.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(289, 66);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 7;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Location = new System.Drawing.Point(12, 66);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(271, 23);
            this.ParsingTextBox.TabIndex = 6;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.HandleLabel);
            this.SeasonGroupBox.Controls.Add(this.HandleButton);
            this.SeasonGroupBox.Controls.Add(this.HandleComboBox);
            this.SeasonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonGroupBox.Location = new System.Drawing.Point(483, 2);
            this.SeasonGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SeasonGroupBox.Size = new System.Drawing.Size(478, 189);
            this.SeasonGroupBox.TabIndex = 1;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // HandleLabel
            // 
            this.HandleLabel.AutoSize = true;
            this.HandleLabel.Location = new System.Drawing.Point(9, 47);
            this.HandleLabel.Name = "HandleLabel";
            this.HandleLabel.Size = new System.Drawing.Size(89, 15);
            this.HandleLabel.TabIndex = 12;
            this.HandleLabel.Text = "Choose season:";
            // 
            // HandleButton
            // 
            this.HandleButton.Location = new System.Drawing.Point(226, 65);
            this.HandleButton.Name = "HandleButton";
            this.HandleButton.Size = new System.Drawing.Size(75, 23);
            this.HandleButton.TabIndex = 11;
            this.HandleButton.Text = "Go!";
            this.HandleButton.UseVisualStyleBackColor = true;
            this.HandleButton.Click += new System.EventHandler(this.HandleButton_Click);
            // 
            // HandleComboBox
            // 
            this.HandleComboBox.FormattingEnabled = true;
            this.HandleComboBox.Location = new System.Drawing.Point(12, 65);
            this.HandleComboBox.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.HandleComboBox.Name = "HandleComboBox";
            this.HandleComboBox.Size = new System.Drawing.Size(208, 23);
            this.HandleComboBox.TabIndex = 10;
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.IntTextBox);
            this.EnumsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumsGroupBox.Controls.Add(this.ValueLabel);
            this.EnumsGroupBox.Controls.Add(this.EnumsLabel);
            this.EnumsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsGroupBox.Location = new System.Drawing.Point(2, 2);
            this.EnumsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.EnumsGroupBox.Size = new System.Drawing.Size(963, 274);
            this.EnumsGroupBox.TabIndex = 2;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(397, 46);
            this.IntTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.IntTextBox.Multiline = true;
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(106, 21);
            this.IntTextBox.TabIndex = 5;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(393, 25);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(55, 15);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(195, 25);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(81, 15);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(10, 25);
            this.EnumsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(121, 15);
            this.EnumsLabel.TabIndex = 2;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.IntegralHeight = false;
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(199, 46);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(10);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(178, 223);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.IntegralHeight = false;
            this.EnumsListBox.ItemHeight = 15;
            this.EnumsListBox.Location = new System.Drawing.Point(14, 46);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(10);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(165, 223);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.ClassesTableLayoutPanel);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Size = new System.Drawing.Size(971, 479);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesTableLayoutPanel
            // 
            this.ClassesTableLayoutPanel.ColumnCount = 2;
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.Controls.Add(this.MoviesGroupBox1, 1, 0);
            this.ClassesTableLayoutPanel.Controls.Add(this.RectanglesGroupBox, 0, 0);
            this.ClassesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesTableLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.ClassesTableLayoutPanel.Name = "ClassesTableLayoutPanel";
            this.ClassesTableLayoutPanel.RowCount = 2;
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.ClassesTableLayoutPanel.Size = new System.Drawing.Size(965, 475);
            this.ClassesTableLayoutPanel.TabIndex = 0;
            // 
            // MoviesGroupBox1
            // 
            this.MoviesGroupBox1.Controls.Add(this.MoviesButton);
            this.MoviesGroupBox1.Controls.Add(this.RatingLabel);
            this.MoviesGroupBox1.Controls.Add(this.GenreLabel);
            this.MoviesGroupBox1.Controls.Add(this.YearLabel);
            this.MoviesGroupBox1.Controls.Add(this.DurationLabel);
            this.MoviesGroupBox1.Controls.Add(this.NameLabel);
            this.MoviesGroupBox1.Controls.Add(this.RatingTextBox);
            this.MoviesGroupBox1.Controls.Add(this.GenreTextBox);
            this.MoviesGroupBox1.Controls.Add(this.YearTextBox);
            this.MoviesGroupBox1.Controls.Add(this.DurationTextBox);
            this.MoviesGroupBox1.Controls.Add(this.NameTextBox);
            this.MoviesGroupBox1.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesGroupBox1.Location = new System.Drawing.Point(485, 3);
            this.MoviesGroupBox1.Name = "MoviesGroupBox1";
            this.MoviesGroupBox1.Size = new System.Drawing.Size(477, 460);
            this.MoviesGroupBox1.TabIndex = 0;
            this.MoviesGroupBox1.TabStop = false;
            this.MoviesGroupBox1.Text = "Movies";
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
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.CenterGroupBox);
            this.RectanglesGroupBox.Controls.Add(this.IdTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesButton);
            this.RectanglesGroupBox.Controls.Add(this.IdLabel);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(476, 460);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // CenterGroupBox
            // 
            this.CenterGroupBox.Controls.Add(this.YLabel);
            this.CenterGroupBox.Controls.Add(this.XLabel);
            this.CenterGroupBox.Controls.Add(this.YTextBox);
            this.CenterGroupBox.Controls.Add(this.XTextBox);
            this.CenterGroupBox.Location = new System.Drawing.Point(174, 296);
            this.CenterGroupBox.Margin = new System.Windows.Forms.Padding(22);
            this.CenterGroupBox.Name = "CenterGroupBox";
            this.CenterGroupBox.Size = new System.Drawing.Size(210, 117);
            this.CenterGroupBox.TabIndex = 18;
            this.CenterGroupBox.TabStop = false;
            this.CenterGroupBox.Text = "Center";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(4, 70);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 15);
            this.YLabel.TabIndex = 19;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(4, 22);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 15);
            this.XLabel.TabIndex = 19;
            this.XLabel.Text = "X:";
            // 
            // YTextBox
            // 
            this.YTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.YTextBox.Location = new System.Drawing.Point(4, 88);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(200, 23);
            this.YTextBox.TabIndex = 20;
            this.YTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YTextBox_KeyPress);
            // 
            // XTextBox
            // 
            this.XTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.XTextBox.Location = new System.Drawing.Point(4, 40);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(200, 23);
            this.XTextBox.TabIndex = 19;
            this.XTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XTextBox_KeyPress);
            // 
            // IdTextBox
            // 
            this.IdTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.IdTextBox.Location = new System.Drawing.Point(178, 43);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(22);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(200, 23);
            this.IdTextBox.TabIndex = 17;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTextBox_KeyPress);
            // 
            // RectanglesButton
            // 
            this.RectanglesButton.Location = new System.Drawing.Point(178, 430);
            this.RectanglesButton.Margin = new System.Windows.Forms.Padding(22, 3, 22, 22);
            this.RectanglesButton.Name = "RectanglesButton";
            this.RectanglesButton.Size = new System.Drawing.Size(75, 25);
            this.RectanglesButton.TabIndex = 16;
            this.RectanglesButton.Text = "Find";
            this.RectanglesButton.UseVisualStyleBackColor = true;
            this.RectanglesButton.Click += new System.EventHandler(this.RectanglesButton_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(176, 19);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 15);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "ID:";
            // 
            // ColorLabel
            // 
            this.ColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(176, 222);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(39, 15);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(176, 155);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(42, 15);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(176, 88);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(47, 15);
            this.LengthLabel.TabIndex = 4;
            this.LengthLabel.Text = "Length:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ColorTextBox.Location = new System.Drawing.Point(178, 244);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(22);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(200, 23);
            this.ColorTextBox.TabIndex = 3;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WidthTextBox.Location = new System.Drawing.Point(178, 177);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(22);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(200, 23);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LengthTextBox.Location = new System.Drawing.Point(178, 110);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(22);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(200, 23);
            this.LengthTextBox.TabIndex = 1;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.IntegralHeight = false;
            this.RectanglesListBox.ItemHeight = 15;
            this.RectanglesListBox.Location = new System.Drawing.Point(3, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(150, 438);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 507);
            this.Controls.Add(this.ProgrammingTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.ProgrammingTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesTableLayoutPanel.ResumeLayout(false);
            this.MoviesGroupBox1.ResumeLayout(false);
            this.MoviesGroupBox1.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.CenterGroupBox.ResumeLayout(false);
            this.CenterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl ProgrammingTabControl;
        private TabPage EnumsTabPage;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private GroupBox EnumsGroupBox;
        private TextBox IntTextBox;
        private Label IntValueLabel;
        private Label ValueLabel;
        private Label EnumsLabel;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanel;
        private GroupBox WeekdayGroupBox;
        private GroupBox SeasonGroupBox;
        private Label ParsingAnswerLabel;
        private Label ParseLabel;
        private Button ParseButton;
        private TextBox ParsingTextBox;
        private Label HandleLabel;
        private Button HandleButton;
        private ComboBox HandleComboBox;
        private TabPage ClassesTabPage;
        private TableLayoutPanel ClassesTableLayoutPanel;
        private GroupBox MoviesGroupBox1;
        private GroupBox RectanglesGroupBox;
        private TextBox LengthTextBox;
        private ListBox RectanglesListBox;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private Label YearLabel;
        private Label DurationLabel;
        private Label NameLabel;
        private TextBox RatingTextBox;
        private TextBox GenreTextBox;
        private TextBox YearTextBox;
        private TextBox DurationTextBox;
        private TextBox NameTextBox;
        private ListBox MoviesListBox;
        private Label ColorLabel;
        private Label WidthLabel;
        private Label LengthLabel;
        private Label RatingLabel;
        private Label GenreLabel;
        private Button MoviesButton;
        private Button RectanglesButton;
        private GroupBox CenterGroupBox;
        private Label YLabel;
        private Label XLabel;
        private TextBox YTextBox;
        private TextBox XTextBox;
        private TextBox IdTextBox;
        private Label IdLabel;
    }
}