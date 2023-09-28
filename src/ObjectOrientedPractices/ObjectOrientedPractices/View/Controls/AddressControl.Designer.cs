namespace ObjectOrientedPractices.View.Controls
{
    partial class AddressControl
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
            this.components = new System.ComponentModel.Container();
            this.AddressGroupBox = new System.Windows.Forms.GroupBox();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.IndexTextBox = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddressGroupBox
            // 
            this.AddressGroupBox.Controls.Add(this.ApartmentLabel);
            this.AddressGroupBox.Controls.Add(this.BuildingLabel);
            this.AddressGroupBox.Controls.Add(this.StreetLabel);
            this.AddressGroupBox.Controls.Add(this.CityLabel);
            this.AddressGroupBox.Controls.Add(this.CountryLabel);
            this.AddressGroupBox.Controls.Add(this.IndexLabel);
            this.AddressGroupBox.Controls.Add(this.CountryTextBox);
            this.AddressGroupBox.Controls.Add(this.CityTextBox);
            this.AddressGroupBox.Controls.Add(this.StreetTextBox);
            this.AddressGroupBox.Controls.Add(this.BuildingTextBox);
            this.AddressGroupBox.Controls.Add(this.ApartmentTextBox);
            this.AddressGroupBox.Controls.Add(this.IndexTextBox);
            this.AddressGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressGroupBox.Location = new System.Drawing.Point(0, 0);
            this.AddressGroupBox.Name = "AddressGroupBox";
            this.AddressGroupBox.Size = new System.Drawing.Size(542, 200);
            this.AddressGroupBox.TabIndex = 0;
            this.AddressGroupBox.TabStop = false;
            this.AddressGroupBox.Text = "Delivery Address";
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ApartmentLabel.Location = new System.Drawing.Point(241, 137);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(83, 20);
            this.ApartmentLabel.TabIndex = 11;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuildingLabel.Location = new System.Drawing.Point(6, 137);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(67, 20);
            this.BuildingLabel.TabIndex = 10;
            this.BuildingLabel.Text = "Building:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StreetLabel.Location = new System.Drawing.Point(6, 104);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(51, 20);
            this.StreetLabel.TabIndex = 9;
            this.StreetLabel.Text = "Street:";
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityLabel.Location = new System.Drawing.Point(324, 71);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(37, 20);
            this.CityLabel.TabIndex = 8;
            this.CityLabel.Text = "City:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountryLabel.Location = new System.Drawing.Point(6, 71);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(63, 20);
            this.CountryLabel.TabIndex = 7;
            this.CountryLabel.Text = "Country:";
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IndexLabel.Location = new System.Drawing.Point(6, 38);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(79, 20);
            this.IndexLabel.TabIndex = 6;
            this.IndexLabel.Text = "Post Index:";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountryTextBox.Location = new System.Drawing.Point(86, 68);
            this.CountryTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(225, 27);
            this.CountryTextBox.TabIndex = 5;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityTextBox.Location = new System.Drawing.Point(361, 68);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(166, 27);
            this.CityTextBox.TabIndex = 4;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StreetTextBox.Location = new System.Drawing.Point(86, 101);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(441, 27);
            this.StreetTextBox.TabIndex = 3;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuildingTextBox.Location = new System.Drawing.Point(86, 134);
            this.BuildingTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(135, 27);
            this.BuildingTextBox.TabIndex = 2;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApartmentTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ApartmentTextBox.Location = new System.Drawing.Point(330, 134);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(197, 27);
            this.ApartmentTextBox.TabIndex = 1;
            this.ApartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // IndexTextBox
            // 
            this.IndexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IndexTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IndexTextBox.Location = new System.Drawing.Point(86, 35);
            this.IndexTextBox.Name = "IndexTextBox";
            this.IndexTextBox.Size = new System.Drawing.Size(125, 27);
            this.IndexTextBox.TabIndex = 0;
            this.IndexTextBox.TextChanged += new System.EventHandler(this.IndexTextBox_TextChanged);
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddressGroupBox);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(542, 200);
            this.AddressGroupBox.ResumeLayout(false);
            this.AddressGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox AddressGroupBox;
        private TextBox CountryTextBox;
        private TextBox CityTextBox;
        private TextBox StreetTextBox;
        private TextBox BuildingTextBox;
        private TextBox ApartmentTextBox;
        private TextBox IndexTextBox;
        private Label ApartmentLabel;
        private Label BuildingLabel;
        private Label StreetLabel;
        private Label CityLabel;
        private Label CountryLabel;
        private Label IndexLabel;
        private ToolTip ToolTip;
    }
}
