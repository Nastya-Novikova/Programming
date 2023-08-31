namespace ObjectOrientedPractices.View.Tabs
{
    partial class ItemsTab
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.SelectedItemGroupBox = new System.Windows.Forms.GroupBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IdTtextBox = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel.SuspendLayout();
            this.ItemsGroupBox.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.SelectedItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.68831F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.31169F));
            this.TableLayoutPanel.Controls.Add(this.ItemsGroupBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.SelectedItemGroupBox, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(716, 373);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Controls.Add(this.ButtonsTableLayoutPanel);
            this.ItemsGroupBox.Controls.Add(this.ItemsListBox);
            this.ItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsGroupBox.Location = new System.Drawing.Point(3, 2);
            this.ItemsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsGroupBox.Size = new System.Drawing.Size(313, 369);
            this.ItemsGroupBox.TabIndex = 0;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Text = "Items";
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddButton, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveButton, 1, 0);
            this.ButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 323);
            this.ButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(307, 44);
            this.ButtonsTableLayoutPanel.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(3, 2);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(96, 40);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.Location = new System.Drawing.Point(105, 2);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(96, 40);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.IntegralHeight = false;
            this.ItemsListBox.ItemHeight = 15;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 18);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(307, 301);
            this.ItemsListBox.TabIndex = 0;
            // 
            // SelectedItemGroupBox
            // 
            this.SelectedItemGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.SelectedItemGroupBox.Controls.Add(this.DescriptionLabel);
            this.SelectedItemGroupBox.Controls.Add(this.NameLabel);
            this.SelectedItemGroupBox.Controls.Add(this.CostLabel);
            this.SelectedItemGroupBox.Controls.Add(this.IdLabel);
            this.SelectedItemGroupBox.Controls.Add(this.DescriptionTextBox);
            this.SelectedItemGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedItemGroupBox.Controls.Add(this.CostTextBox);
            this.SelectedItemGroupBox.Controls.Add(this.IdTtextBox);
            this.SelectedItemGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedItemGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectedItemGroupBox.Location = new System.Drawing.Point(322, 2);
            this.SelectedItemGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            this.SelectedItemGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectedItemGroupBox.Size = new System.Drawing.Size(391, 369);
            this.SelectedItemGroupBox.TabIndex = 4;
            this.SelectedItemGroupBox.TabStop = false;
            this.SelectedItemGroupBox.Text = "Selected Item";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(5, 194);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(70, 15);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(5, 96);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CostLabel.Location = new System.Drawing.Point(5, 66);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(34, 15);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(5, 39);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 15);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "ID:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTextBox.Location = new System.Drawing.Point(5, 212);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(381, 114);
            this.DescriptionTextBox.TabIndex = 3;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(5, 113);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(381, 70);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CostTextBox.Location = new System.Drawing.Point(54, 64);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(158, 23);
            this.CostTextBox.TabIndex = 1;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // IdTtextBox
            // 
            this.IdTtextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdTtextBox.Location = new System.Drawing.Point(54, 39);
            this.IdTtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdTtextBox.Name = "IdTtextBox";
            this.IdTtextBox.Size = new System.Drawing.Size(158, 23);
            this.IdTtextBox.TabIndex = 0;
            this.IdTtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTtextBox_KeyPress);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(716, 373);
            this.TableLayoutPanel.ResumeLayout(false);
            this.ItemsGroupBox.ResumeLayout(false);
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.SelectedItemGroupBox.ResumeLayout(false);
            this.SelectedItemGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private GroupBox ItemsGroupBox;
        private TableLayoutPanel ButtonsTableLayoutPanel;
        private Button AddButton;
        private Button RemoveButton;
        private ListBox ItemsListBox;
        private GroupBox SelectedItemGroupBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IdLabel;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IdTtextBox;
    }
}
