namespace Programming.View.Panels
{
    partial class SeasonsControl
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
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.HandleLabel = new System.Windows.Forms.Label();
            this.HandleButton = new System.Windows.Forms.Button();
            this.HandleComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.HandleLabel);
            this.SeasonGroupBox.Controls.Add(this.HandleButton);
            this.SeasonGroupBox.Controls.Add(this.HandleComboBox);
            this.SeasonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SeasonGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SeasonGroupBox.Size = new System.Drawing.Size(475, 187);
            this.SeasonGroupBox.TabIndex = 2;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // HandleLabel
            // 
            this.HandleLabel.AutoSize = true;
            this.HandleLabel.Location = new System.Drawing.Point(8, 46);
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
            // SeasonsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonGroupBox);
            this.Name = "SeasonsControl";
            this.Size = new System.Drawing.Size(475, 187);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox SeasonGroupBox;
        private Label HandleLabel;
        private Button HandleButton;
        private ComboBox HandleComboBox;
    }
}
