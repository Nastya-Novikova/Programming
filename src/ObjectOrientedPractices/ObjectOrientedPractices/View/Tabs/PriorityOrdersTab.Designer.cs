namespace ObjectOrientedPractices.View.Tabs
{
    partial class PriorityOrdersTab
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
            ObjectOrientedPractices.Model.Address address1 = new ObjectOrientedPractices.Model.Address();
            this.SelectedOrderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeComboBox = new System.Windows.Forms.ComboBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CostLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddressControl = new ObjectOrientedPractices.View.Controls.AddressControl();
            this.SelectedOrderTableLayoutPanel.SuspendLayout();
            this.SelectedOrderGroupBox.SuspendLayout();
            this.ItemsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedOrderTableLayoutPanel
            // 
            this.SelectedOrderTableLayoutPanel.ColumnCount = 1;
            this.SelectedOrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedOrderTableLayoutPanel.Controls.Add(this.SelectedOrderGroupBox, 0, 0);
            this.SelectedOrderTableLayoutPanel.Controls.Add(this.ItemsGroupBox, 0, 2);
            this.SelectedOrderTableLayoutPanel.Controls.Add(this.AddressControl, 0, 1);
            this.SelectedOrderTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedOrderTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SelectedOrderTableLayoutPanel.Name = "SelectedOrderTableLayoutPanel";
            this.SelectedOrderTableLayoutPanel.RowCount = 3;
            this.SelectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.39964F));
            this.SelectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.61634F));
            this.SelectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.98402F));
            this.SelectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SelectedOrderTableLayoutPanel.Size = new System.Drawing.Size(621, 654);
            this.SelectedOrderTableLayoutPanel.TabIndex = 2;
            // 
            // SelectedOrderGroupBox
            // 
            this.SelectedOrderGroupBox.Controls.Add(this.TimeComboBox);
            this.SelectedOrderGroupBox.Controls.Add(this.InfoLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.StatusLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.DateLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.IdLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.IdTextBox);
            this.SelectedOrderGroupBox.Controls.Add(this.DateTextBox);
            this.SelectedOrderGroupBox.Controls.Add(this.StatusComboBox);
            this.SelectedOrderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedOrderGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedOrderGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            this.SelectedOrderGroupBox.Size = new System.Drawing.Size(615, 160);
            this.SelectedOrderGroupBox.TabIndex = 1;
            this.SelectedOrderGroupBox.TabStop = false;
            this.SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // TimeComboBox
            // 
            this.TimeComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeComboBox.FormattingEnabled = true;
            this.TimeComboBox.Location = new System.Drawing.Point(324, 59);
            this.TimeComboBox.Name = "TimeComboBox";
            this.TimeComboBox.Size = new System.Drawing.Size(151, 28);
            this.TimeComboBox.TabIndex = 7;
            this.TimeComboBox.SelectedIndexChanged += new System.EventHandler(this.TimeComboBox_SelectedIndexChanged);
            this.TimeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeComboBox_KeyPress);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(324, 29);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(124, 20);
            this.InfoLabel.TabIndex = 6;
            this.InfoLabel.Text = "Priority Options:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(6, 95);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(52, 20);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Status:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(6, 62);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(64, 20);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(6, 29);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 20);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "ID:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdTextBox.Location = new System.Drawing.Point(86, 26);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(151, 27);
            this.IdTextBox.TabIndex = 2;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTextBox_KeyPress);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTextBox.Location = new System.Drawing.Point(86, 59);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(151, 27);
            this.DateTextBox.TabIndex = 1;
            this.DateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateTextBox_KeyPress);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(86, 92);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(151, 28);
            this.StatusComboBox.TabIndex = 0;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            this.StatusComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StatusComboBox_KeyPress);
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Controls.Add(this.AddButton);
            this.ItemsGroupBox.Controls.Add(this.RemoveButton);
            this.ItemsGroupBox.Controls.Add(this.ClearButton);
            this.ItemsGroupBox.Controls.Add(this.CostLabel);
            this.ItemsGroupBox.Controls.Add(this.AmountLabel);
            this.ItemsGroupBox.Controls.Add(this.ItemsListBox);
            this.ItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsGroupBox.Location = new System.Drawing.Point(3, 375);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Size = new System.Drawing.Size(615, 276);
            this.ItemsGroupBox.TabIndex = 2;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Text = "Order Items";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(6, 187);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(112, 44);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Item";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.Location = new System.Drawing.Point(124, 187);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(112, 44);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove Item";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(242, 187);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 44);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear Order";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CostLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CostLabel.Location = new System.Drawing.Point(0, 204);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(609, 32);
            this.CostLabel.TabIndex = 7;
            this.CostLabel.Text = "0";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(538, 184);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(3, 0, 17, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(71, 20);
            this.AmountLabel.TabIndex = 6;
            this.AmountLabel.Text = "Amount:";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.IntegralHeight = false;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 23);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(606, 158);
            this.ItemsListBox.TabIndex = 0;
            // 
            // AddressControl
            // 
            address1.Apartment = null;
            address1.Building = null;
            address1.City = null;
            address1.Country = null;
            address1.Index = 0;
            address1.Street = null;
            this.AddressControl.Address = address1;
            this.AddressControl.BackColor = System.Drawing.SystemColors.Window;
            this.AddressControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressControl.Enabled = false;
            this.AddressControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddressControl.Location = new System.Drawing.Point(3, 169);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(615, 200);
            this.AddressControl.TabIndex = 3;
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedOrderTableLayoutPanel);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(621, 654);
            this.SelectedOrderTableLayoutPanel.ResumeLayout(false);
            this.SelectedOrderGroupBox.ResumeLayout(false);
            this.SelectedOrderGroupBox.PerformLayout();
            this.ItemsGroupBox.ResumeLayout(false);
            this.ItemsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel SelectedOrderTableLayoutPanel;
        private GroupBox SelectedOrderGroupBox;
        private ComboBox TimeComboBox;
        private Label InfoLabel;
        private Label StatusLabel;
        private Label DateLabel;
        private Label IdLabel;
        private TextBox IdTextBox;
        private TextBox DateTextBox;
        private ComboBox StatusComboBox;
        private GroupBox ItemsGroupBox;
        private Button AddButton;
        private Button RemoveButton;
        private Button ClearButton;
        private Label CostLabel;
        private Label AmountLabel;
        private ListBox ItemsListBox;
        private Controls.AddressControl AddressControl;
    }
}
