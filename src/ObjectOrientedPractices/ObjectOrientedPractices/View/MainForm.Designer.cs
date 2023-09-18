namespace ObjectOrientedPractices
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectOrientedPractices.View.Tabs.ItemsTab();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTab = new ObjectOrientedPractices.View.Tabs.CustomersTab();
            this.TabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemsTabPage);
            this.TabControl.Controls.Add(this.CustomersTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(914, 600);
            this.TabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 29);
            this.ItemsTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemsTabPage.Size = new System.Drawing.Size(906, 567);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab.Location = new System.Drawing.Point(3, 4);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(900, 559);
            this.ItemsTab.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.CustomersTab);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 29);
            this.CustomersTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomersTabPage.Size = new System.Drawing.Size(906, 567);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTab.Location = new System.Drawing.Point(3, 4);
            this.CustomersTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(900, 559);
            this.CustomersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practices";
            this.TabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabControl;
        private TabPage ItemsTabPage;
        private TabPage CustomersTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private View.Tabs.CustomersTab CustomersTab;
    }
}