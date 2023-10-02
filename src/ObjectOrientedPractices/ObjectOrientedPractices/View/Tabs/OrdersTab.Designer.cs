namespace ObjectOrientedPractices.View.Tabs
{
    partial class OrdersTab
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
            ObjectOrientedPractices.Model.Address address2 = new ObjectOrientedPractices.Model.Address();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedOrderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddressControl = new ObjectOrientedPractices.View.Controls.AddressControl();
            this.OrdersGroupBox = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLayoutPanel.SuspendLayout();
            this.SelectedOrderTableLayoutPanel.SuspendLayout();
            this.SelectedOrderGroupBox.SuspendLayout();
            this.ItemsGroupBox.SuspendLayout();
            this.OrdersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.SelectedOrderTableLayoutPanel, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.OrdersGroupBox, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(974, 569);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // SelectedOrderTableLayoutPanel
            // 
            this.SelectedOrderTableLayoutPanel.ColumnCount = 1;
            this.SelectedOrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedOrderTableLayoutPanel.Controls.Add(this.SelectedOrderGroupBox, 0, 0);
            this.SelectedOrderTableLayoutPanel.Controls.Add(this.ItemsGroupBox, 0, 2);
            this.SelectedOrderTableLayoutPanel.Controls.Add(this.AddressControl, 0, 1);
            this.SelectedOrderTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedOrderTableLayoutPanel.Location = new System.Drawing.Point(490, 3);
            this.SelectedOrderTableLayoutPanel.Name = "SelectedOrderTableLayoutPanel";
            this.SelectedOrderTableLayoutPanel.RowCount = 3;
            this.SelectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.39964F));
            this.SelectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.61634F));
            this.SelectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.98401F));
            this.SelectedOrderTableLayoutPanel.Size = new System.Drawing.Size(481, 563);
            this.SelectedOrderTableLayoutPanel.TabIndex = 1;
            // 
            // SelectedOrderGroupBox
            // 
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
            this.SelectedOrderGroupBox.Size = new System.Drawing.Size(475, 137);
            this.SelectedOrderGroupBox.TabIndex = 1;
            this.SelectedOrderGroupBox.TabStop = false;
            this.SelectedOrderGroupBox.Text = "Selected Order";
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
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTextBox.Location = new System.Drawing.Point(86, 59);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(151, 27);
            this.DateTextBox.TabIndex = 1;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(86, 92);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(151, 28);
            this.StatusComboBox.TabIndex = 0;
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Controls.Add(this.CostLabel);
            this.ItemsGroupBox.Controls.Add(this.AmountLabel);
            this.ItemsGroupBox.Controls.Add(this.ItemsListBox);
            this.ItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsGroupBox.Location = new System.Drawing.Point(3, 324);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Size = new System.Drawing.Size(475, 236);
            this.ItemsGroupBox.TabIndex = 2;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Text = "Order Items";
            // 
            // CostLabel
            // 
            this.CostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CostLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CostLabel.Location = new System.Drawing.Point(6, 201);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(466, 32);
            this.CostLabel.TabIndex = 7;
            this.CostLabel.Text = "0";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(401, 181);
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
            this.ItemsListBox.Size = new System.Drawing.Size(469, 155);
            this.ItemsListBox.TabIndex = 0;
            // 
            // AddressControl
            // 
            address2.Apartment = null;
            address2.Building = null;
            address2.City = null;
            address2.Country = null;
            address2.Index = 0;
            address2.Street = null;
            this.AddressControl.Address = address2;
            this.AddressControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressControl.Location = new System.Drawing.Point(3, 146);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(475, 172);
            this.AddressControl.TabIndex = 3;
            // 
            // OrdersGroupBox
            // 
            this.OrdersGroupBox.Controls.Add(this.DataGridView);
            this.OrdersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrdersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.OrdersGroupBox.Name = "OrdersGroupBox";
            this.OrdersGroupBox.Size = new System.Drawing.Size(481, 563);
            this.OrdersGroupBox.TabIndex = 1;
            this.OrdersGroupBox.TabStop = false;
            this.OrdersGroupBox.Text = "Orders";
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.DateColumn,
            this.StatusColumn,
            this.CustomerColumn,
            this.AddressColumn,
            this.AmountColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(3, 23);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 29;
            this.DataGridView.Size = new System.Drawing.Size(475, 537);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // IdColumn
            // 
            this.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdColumn.Width = 28;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DateColumn.HeaderText = "Created";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateColumn.Width = 67;
            // 
            // StatusColumn
            // 
            this.StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StatusColumn.HeaderText = "Order Status";
            this.StatusColumn.MinimumWidth = 6;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StatusColumn.Width = 87;
            // 
            // CustomerColumn
            // 
            this.CustomerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerColumn.HeaderText = "Customer Fullname";
            this.CustomerColumn.MinimumWidth = 6;
            this.CustomerColumn.Name = "CustomerColumn";
            this.CustomerColumn.ReadOnly = true;
            this.CustomerColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CustomerColumn.Width = 128;
            // 
            // AddressColumn
            // 
            this.AddressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.MinimumWidth = 6;
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            this.AddressColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AddressColumn.Width = 68;
            // 
            // AmountColumn
            // 
            this.AmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.MinimumWidth = 6;
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AmountColumn.Width = 68;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(974, 569);
            this.TableLayoutPanel.ResumeLayout(false);
            this.SelectedOrderTableLayoutPanel.ResumeLayout(false);
            this.SelectedOrderGroupBox.ResumeLayout(false);
            this.SelectedOrderGroupBox.PerformLayout();
            this.ItemsGroupBox.ResumeLayout(false);
            this.ItemsGroupBox.PerformLayout();
            this.OrdersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private TableLayoutPanel SelectedOrderTableLayoutPanel;
        private GroupBox SelectedOrderGroupBox;
        private Label StatusLabel;
        private Label DateLabel;
        private Label IdLabel;
        private TextBox IdTextBox;
        private TextBox DateTextBox;
        private ComboBox StatusComboBox;
        private GroupBox ItemsGroupBox;
        private ListBox ItemsListBox;
        private GroupBox OrdersGroupBox;
        private DataGridView DataGridView;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewTextBoxColumn CustomerColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn AmountColumn;
        private Label CostLabel;
        private Label AmountLabel;
        private Controls.AddressControl AddressControl;
    }
}
