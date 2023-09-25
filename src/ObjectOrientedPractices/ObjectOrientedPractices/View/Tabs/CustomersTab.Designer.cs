namespace ObjectOrientedPractices.View.Tabs
{
    partial class CustomersTab
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddListButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.SelectedCustomerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.AddressControl = new ObjectOrientedPractices.View.Controls.AddressControl();
            this.TableLayoutPanel.SuspendLayout();
            this.CustomersGroupBox.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.SelectedCustomerTableLayoutPanel.SuspendLayout();
            this.SelectedCustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.58391F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.41609F));
            this.TableLayoutPanel.Controls.Add(this.CustomersGroupBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.SelectedCustomerTableLayoutPanel, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(933, 637);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // CustomersGroupBox
            // 
            this.CustomersGroupBox.Controls.Add(this.ButtonsTableLayoutPanel);
            this.CustomersGroupBox.Controls.Add(this.CustomersListBox);
            this.CustomersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CustomersGroupBox.Name = "CustomersGroupBox";
            this.CustomersGroupBox.Size = new System.Drawing.Size(409, 631);
            this.CustomersGroupBox.TabIndex = 3;
            this.CustomersGroupBox.TabStop = false;
            this.CustomersGroupBox.Text = "Customers";
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveButton, 2, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddListButton, 0, 0);
            this.ButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 569);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(403, 59);
            this.ButtonsTableLayoutPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(137, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(128, 53);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.Location = new System.Drawing.Point(271, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(129, 53);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddListButton
            // 
            this.AddListButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddListButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddListButton.Location = new System.Drawing.Point(3, 3);
            this.AddListButton.Name = "AddListButton";
            this.AddListButton.Size = new System.Drawing.Size(128, 53);
            this.AddListButton.TabIndex = 9;
            this.AddListButton.Text = "Add List";
            this.AddListButton.UseVisualStyleBackColor = true;
            this.AddListButton.Click += new System.EventHandler(this.AddListButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.IntegralHeight = false;
            this.CustomersListBox.ItemHeight = 20;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 23);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(403, 543);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // SelectedCustomerTableLayoutPanel
            // 
            this.SelectedCustomerTableLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.SelectedCustomerTableLayoutPanel.ColumnCount = 1;
            this.SelectedCustomerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedCustomerTableLayoutPanel.Controls.Add(this.SelectedCustomerGroupBox, 0, 0);
            this.SelectedCustomerTableLayoutPanel.Controls.Add(this.AddressControl, 0, 1);
            this.SelectedCustomerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedCustomerTableLayoutPanel.Location = new System.Drawing.Point(418, 4);
            this.SelectedCustomerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectedCustomerTableLayoutPanel.Name = "SelectedCustomerTableLayoutPanel";
            this.SelectedCustomerTableLayoutPanel.RowCount = 3;
            this.SelectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.SelectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.SelectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedCustomerTableLayoutPanel.Size = new System.Drawing.Size(512, 629);
            this.SelectedCustomerTableLayoutPanel.TabIndex = 4;
            // 
            // SelectedCustomerGroupBox
            // 
            this.SelectedCustomerGroupBox.Controls.Add(this.NameLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.IdLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.IdTextBox);
            this.SelectedCustomerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedCustomerGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedCustomerGroupBox.Location = new System.Drawing.Point(3, 0);
            this.SelectedCustomerGroupBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            this.SelectedCustomerGroupBox.Size = new System.Drawing.Size(506, 107);
            this.SelectedCustomerGroupBox.TabIndex = 0;
            this.SelectedCustomerGroupBox.TabStop = false;
            this.SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(7, 76);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(79, 20);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(7, 38);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 20);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "ID:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(87, 72);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(405, 27);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdTextBox.Location = new System.Drawing.Point(87, 35);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(180, 27);
            this.IdTextBox.TabIndex = 0;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTextBox_KeyPress);
            // 
            // AddressControl
            // 
            this.AddressControl.Address = address1;
            this.AddressControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressControl.Location = new System.Drawing.Point(3, 113);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(506, 174);
            this.AddressControl.TabIndex = 5;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(933, 637);
            this.TableLayoutPanel.ResumeLayout(false);
            this.CustomersGroupBox.ResumeLayout(false);
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.SelectedCustomerTableLayoutPanel.ResumeLayout(false);
            this.SelectedCustomerGroupBox.ResumeLayout(false);
            this.SelectedCustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private GroupBox CustomersGroupBox;
        private ListBox CustomersListBox;
        private TableLayoutPanel SelectedCustomerTableLayoutPanel;
        private GroupBox SelectedCustomerGroupBox;
        private TextBox NameTextBox;
        private TextBox IdTextBox;
        private Label NameLabel;
        private Label IdLabel;
        private TableLayoutPanel ButtonsTableLayoutPanel;
        private Button AddButton;
        private Button RemoveButton;
        private Button AddListButton;
        private Controls.AddressControl AddressControl;
    }
}
