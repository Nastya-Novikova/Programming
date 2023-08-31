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
            this.ItemsTabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectOrientedPractices.View.Tabs.ItemsTab();
            this.ItemsTabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsTabControl
            // 
            this.ItemsTabControl.Controls.Add(this.ItemsTabPage);
            this.ItemsTabControl.Controls.Add(this.tabPage2);
            this.ItemsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTabControl.Location = new System.Drawing.Point(0, 0);
            this.ItemsTabControl.Name = "ItemsTabControl";
            this.ItemsTabControl.SelectedIndex = 0;
            this.ItemsTabControl.Size = new System.Drawing.Size(800, 450);
            this.ItemsTabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(792, 422);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab.Location = new System.Drawing.Point(3, 3);
            this.ItemsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(786, 416);
            this.ItemsTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ItemsTabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ItemsTabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl ItemsTabControl;
        private TabPage ItemsTabPage;
        private TabPage tabPage2;
        private View.Tabs.ItemsTab ItemsTab;
    }
}