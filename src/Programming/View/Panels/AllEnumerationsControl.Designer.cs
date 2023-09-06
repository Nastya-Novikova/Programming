namespace Programming.View.Panels
{
    partial class AllEnumerationsControl
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
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.EnumsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EnumsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.EnumsGroupBox.Size = new System.Drawing.Size(963, 274);
            this.EnumsGroupBox.TabIndex = 3;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // IntTextBox
            // 
            this.IntTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.IntTextBox.Location = new System.Drawing.Point(407, 46);
            this.IntTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.IntTextBox.Multiline = true;
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.ReadOnly = true;
            this.IntTextBox.Size = new System.Drawing.Size(106, 21);
            this.IntTextBox.TabIndex = 5;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(407, 25);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(55, 15);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(210, 25);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(81, 15);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(13, 25);
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
            this.ValuesListBox.Location = new System.Drawing.Point(211, 46);
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
            this.EnumsListBox.Location = new System.Drawing.Point(13, 46);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(10);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(178, 223);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // AllEnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllEnumerationsControl";
            this.Size = new System.Drawing.Size(963, 274);
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox EnumsGroupBox;
        private TextBox IntTextBox;
        private Label IntValueLabel;
        private Label ValueLabel;
        private Label EnumsLabel;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
    }
}
