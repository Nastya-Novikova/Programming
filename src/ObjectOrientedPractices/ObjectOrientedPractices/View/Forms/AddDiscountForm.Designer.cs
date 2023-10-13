namespace ObjectOrientedPractices.View.Forms
{
    partial class AddDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDiscountForm));
            this.DiscountGroupBox = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DiscountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiscountGroupBox
            // 
            this.DiscountGroupBox.Controls.Add(this.CancelButton);
            this.DiscountGroupBox.Controls.Add(this.AddButton);
            this.DiscountGroupBox.Controls.Add(this.CategoryComboBox);
            this.DiscountGroupBox.Controls.Add(this.CategoryLabel);
            this.DiscountGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscountGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountGroupBox.Location = new System.Drawing.Point(0, 0);
            this.DiscountGroupBox.Name = "DiscountGroupBox";
            this.DiscountGroupBox.Size = new System.Drawing.Size(380, 165);
            this.DiscountGroupBox.TabIndex = 0;
            this.DiscountGroupBox.TabStop = false;
            this.DiscountGroupBox.Text = "Percent Discount";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(264, 119);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(110, 40);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(148, 119);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 40);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Ok";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(89, 54);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(285, 28);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            this.CategoryComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CategoryComboBox_KeyPress);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.Location = new System.Drawing.Point(6, 57);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(72, 20);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Category:";
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 165);
            this.Controls.Add(this.DiscountGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDiscountForm";
            this.Text = "Add Discount";
            this.DiscountGroupBox.ResumeLayout(false);
            this.DiscountGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox DiscountGroupBox;
        private Button CancelButton;
        private Button AddButton;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
    }
}