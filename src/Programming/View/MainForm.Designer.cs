namespace Programming.View
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
            this.ProgrammingTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeekdayParsingControl = new Programming.View.Panels.WeekdayParsingControl();
            this.SeasonsControl = new Programming.View.Panels.SeasonsControl();
            this.AllEnumerationsControl = new Programming.View.Panels.AllEnumerationsControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.ClassesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RectanglesControl = new Programming.View.Panels.RectanglesControl();
            this.MoviesControl = new Programming.View.Panels.MoviesControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesCollisionControl = new Programming.View.Panels.RectanglesCollisionControl();
            this.ProgrammingTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.ClassesTableLayoutPanel.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgrammingTabControl
            // 
            this.ProgrammingTabControl.Controls.Add(this.EnumsTabPage);
            this.ProgrammingTabControl.Controls.Add(this.ClassesTabPage);
            this.ProgrammingTabControl.Controls.Add(this.RectanglesTabPage);
            this.ProgrammingTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgrammingTabControl.Location = new System.Drawing.Point(0, 0);
            this.ProgrammingTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.ProgrammingTabControl.Name = "ProgrammingTabControl";
            this.ProgrammingTabControl.SelectedIndex = 0;
            this.ProgrammingTabControl.Size = new System.Drawing.Size(979, 507);
            this.ProgrammingTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.tableLayoutPanelMain);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 24);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.EnumsTabPage.Size = new System.Drawing.Size(971, 479);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.AllEnumerationsControl, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.5595F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.4405F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(967, 475);
            this.tableLayoutPanelMain.TabIndex = 3;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.WeekdayParsingControl, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.SeasonsControl, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(2, 280);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(963, 193);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // WeekdayParsingControl
            // 
            this.WeekdayParsingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsingControl.Location = new System.Drawing.Point(3, 3);
            this.WeekdayParsingControl.Name = "WeekdayParsingControl";
            this.WeekdayParsingControl.Size = new System.Drawing.Size(475, 187);
            this.WeekdayParsingControl.TabIndex = 13;
            // 
            // SeasonsControl
            // 
            this.SeasonsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonsControl.Location = new System.Drawing.Point(484, 3);
            this.SeasonsControl.Name = "SeasonsControl";
            this.SeasonsControl.Size = new System.Drawing.Size(476, 187);
            this.SeasonsControl.TabIndex = 14;
            // 
            // AllEnumerationsControl
            // 
            this.AllEnumerationsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllEnumerationsControl.Location = new System.Drawing.Point(3, 2);
            this.AllEnumerationsControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AllEnumerationsControl.Name = "AllEnumerationsControl";
            this.AllEnumerationsControl.Size = new System.Drawing.Size(961, 274);
            this.AllEnumerationsControl.TabIndex = 2;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.ClassesTableLayoutPanel);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Size = new System.Drawing.Size(971, 479);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesTableLayoutPanel
            // 
            this.ClassesTableLayoutPanel.ColumnCount = 2;
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.Controls.Add(this.RectanglesControl, 0, 0);
            this.ClassesTableLayoutPanel.Controls.Add(this.MoviesControl, 1, 0);
            this.ClassesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesTableLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.ClassesTableLayoutPanel.Name = "ClassesTableLayoutPanel";
            this.ClassesTableLayoutPanel.RowCount = 1;
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ClassesTableLayoutPanel.Size = new System.Drawing.Size(965, 475);
            this.ClassesTableLayoutPanel.TabIndex = 0;
            // 
            // RectanglesControl
            // 
            this.RectanglesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesControl.Location = new System.Drawing.Point(3, 3);
            this.RectanglesControl.Name = "RectanglesControl";
            this.RectanglesControl.Size = new System.Drawing.Size(476, 469);
            this.RectanglesControl.TabIndex = 1;
            // 
            // MoviesControl
            // 
            this.MoviesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesControl.Location = new System.Drawing.Point(485, 3);
            this.MoviesControl.Name = "MoviesControl";
            this.MoviesControl.Size = new System.Drawing.Size(477, 469);
            this.MoviesControl.TabIndex = 2;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.RectanglesCollisionControl);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 24);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(971, 479);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesCollisionControl
            // 
            this.RectanglesCollisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesCollisionControl.Location = new System.Drawing.Point(3, 3);
            this.RectanglesCollisionControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesCollisionControl.Name = "RectanglesCollisionControl";
            this.RectanglesCollisionControl.Size = new System.Drawing.Size(965, 473);
            this.RectanglesCollisionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 507);
            this.Controls.Add(this.ProgrammingTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.ProgrammingTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesTableLayoutPanel.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl ProgrammingTabControl;
        private TabPage EnumsTabPage;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanel;
        private TabPage ClassesTabPage;
        private TableLayoutPanel ClassesTableLayoutPanel;
        private TabPage RectanglesTabPage;
        private Panels.RectanglesCollisionControl RectanglesCollisionControl;
        private Panels.AllEnumerationsControl AllEnumerationsControl;
        private Panels.WeekdayParsingControl WeekdayParsingControl;
        private Panels.SeasonsControl SeasonsControl;
        private Panels.RectanglesControl RectanglesControl;
        private Panels.MoviesControl MoviesControl;
    }
}