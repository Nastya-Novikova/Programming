namespace Programming
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
            this.EnumsTabControl = new System.Windows.Forms.TabControl();
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
            this.EnumsTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.EnumsTabPage);
            this.EnumsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(1119, 676);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.tableLayoutPanelMain);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 29);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EnumsTabPage.Size = new System.Drawing.Size(1111, 643);
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
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.5595F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.4405F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1107, 637);
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
            this.tableLayoutPanel.Location = new System.Drawing.Point(2, 376);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1103, 258);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.ParsingAnswerLabel);
            this.WeekdayGroupBox.Controls.Add(this.ParseLabel);
            this.WeekdayGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayGroupBox.Controls.Add(this.ParsingTextBox);
            this.WeekdayGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayGroupBox.Location = new System.Drawing.Point(2, 3);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(547, 252);
            this.WeekdayGroupBox.TabIndex = 0;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // ParsingAnswerLabel
            // 
            this.ParsingAnswerLabel.AutoSize = true;
            this.ParsingAnswerLabel.Location = new System.Drawing.Point(14, 135);
            this.ParsingAnswerLabel.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.ParsingAnswerLabel.Name = "ParsingAnswerLabel";
            this.ParsingAnswerLabel.Size = new System.Drawing.Size(36, 20);
            this.ParsingAnswerLabel.TabIndex = 9;
            this.ParsingAnswerLabel.Text = "Text";
            // 
            // ParseLabel
            // 
            this.ParseLabel.AutoSize = true;
            this.ParseLabel.Location = new System.Drawing.Point(10, 63);
            this.ParseLabel.Name = "ParseLabel";
            this.ParseLabel.Size = new System.Drawing.Size(158, 20);
            this.ParseLabel.TabIndex = 8;
            this.ParseLabel.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(330, 88);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(86, 31);
            this.ParseButton.TabIndex = 7;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Location = new System.Drawing.Point(14, 88);
            this.ParsingTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(309, 27);
            this.ParsingTextBox.TabIndex = 6;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.HandleLabel);
            this.SeasonGroupBox.Controls.Add(this.HandleButton);
            this.SeasonGroupBox.Controls.Add(this.HandleComboBox);
            this.SeasonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonGroupBox.Location = new System.Drawing.Point(553, 3);
            this.SeasonGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SeasonGroupBox.Size = new System.Drawing.Size(548, 252);
            this.SeasonGroupBox.TabIndex = 1;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // HandleLabel
            // 
            this.HandleLabel.AutoSize = true;
            this.HandleLabel.Location = new System.Drawing.Point(10, 63);
            this.HandleLabel.Name = "HandleLabel";
            this.HandleLabel.Size = new System.Drawing.Size(110, 20);
            this.HandleLabel.TabIndex = 12;
            this.HandleLabel.Text = "Choose season:";
            // 
            // HandleButton
            // 
            this.HandleButton.Location = new System.Drawing.Point(258, 87);
            this.HandleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HandleButton.Name = "HandleButton";
            this.HandleButton.Size = new System.Drawing.Size(86, 31);
            this.HandleButton.TabIndex = 11;
            this.HandleButton.Text = "Go!";
            this.HandleButton.UseVisualStyleBackColor = true;
            // 
            // HandleComboBox
            // 
            this.HandleComboBox.FormattingEnabled = true;
            this.HandleComboBox.Location = new System.Drawing.Point(14, 87);
            this.HandleComboBox.Margin = new System.Windows.Forms.Padding(11, 13, 3, 13);
            this.HandleComboBox.Name = "HandleComboBox";
            this.HandleComboBox.Size = new System.Drawing.Size(237, 28);
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
            this.EnumsGroupBox.Location = new System.Drawing.Point(2, 3);
            this.EnumsGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EnumsGroupBox.Size = new System.Drawing.Size(1103, 367);
            this.EnumsGroupBox.TabIndex = 2;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(454, 61);
            this.IntTextBox.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.IntTextBox.Multiline = true;
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(121, 27);
            this.IntTextBox.TabIndex = 5;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(449, 33);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(68, 20);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(223, 33);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(100, 20);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(11, 33);
            this.EnumsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(149, 20);
            this.EnumsLabel.TabIndex = 2;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.IntegralHeight = false;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(227, 61);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(203, 295);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.IntegralHeight = false;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(16, 61);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(188, 295);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 676);
            this.Controls.Add(this.EnumsTabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl EnumsTabControl;
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
    }
}