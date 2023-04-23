namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            this.RectanglesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InfoRectanglesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedRectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedHeightLabel = new System.Windows.Forms.Label();
            this.SelectedWidthLabel = new System.Windows.Forms.Label();
            this.SelectedYLabel = new System.Windows.Forms.Label();
            this.SelectedXLabel = new System.Windows.Forms.Label();
            this.SelectedIdLabel = new System.Windows.Forms.Label();
            this.SelectedHeightTextBox = new System.Windows.Forms.TextBox();
            this.SelectedWidthTextBox = new System.Windows.Forms.TextBox();
            this.SelectedYTextBox = new System.Windows.Forms.TextBox();
            this.SelectedXTextBox = new System.Windows.Forms.TextBox();
            this.SelectedIdTextBox = new System.Windows.Forms.TextBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoRectanglesListBox = new System.Windows.Forms.ListBox();
            this.RemovePictureBox = new System.Windows.Forms.PictureBox();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.RectanglesTableLayoutPanel.SuspendLayout();
            this.InfoRectanglesTableLayoutPanel.SuspendLayout();
            this.SelectedRectangleGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RectanglesTableLayoutPanel
            // 
            this.RectanglesTableLayoutPanel.ColumnCount = 2;
            this.RectanglesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.RectanglesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.RectanglesTableLayoutPanel.Controls.Add(this.InfoRectanglesTableLayoutPanel, 0, 0);
            this.RectanglesTableLayoutPanel.Controls.Add(this.CanvasPanel, 1, 0);
            this.RectanglesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RectanglesTableLayoutPanel.Name = "RectanglesTableLayoutPanel";
            this.RectanglesTableLayoutPanel.RowCount = 1;
            this.RectanglesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RectanglesTableLayoutPanel.Size = new System.Drawing.Size(967, 476);
            this.RectanglesTableLayoutPanel.TabIndex = 1;
            // 
            // InfoRectanglesTableLayoutPanel
            // 
            this.InfoRectanglesTableLayoutPanel.ColumnCount = 1;
            this.InfoRectanglesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InfoRectanglesTableLayoutPanel.Controls.Add(this.SelectedRectangleGroupBox, 0, 1);
            this.InfoRectanglesTableLayoutPanel.Controls.Add(this.InfoGroupBox, 0, 0);
            this.InfoRectanglesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoRectanglesTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.InfoRectanglesTableLayoutPanel.Name = "InfoRectanglesTableLayoutPanel";
            this.InfoRectanglesTableLayoutPanel.RowCount = 2;
            this.InfoRectanglesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InfoRectanglesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InfoRectanglesTableLayoutPanel.Size = new System.Drawing.Size(332, 470);
            this.InfoRectanglesTableLayoutPanel.TabIndex = 0;
            // 
            // SelectedRectangleGroupBox
            // 
            this.SelectedRectangleGroupBox.Controls.Add(this.SelectedHeightLabel);
            this.SelectedRectangleGroupBox.Controls.Add(this.SelectedWidthLabel);
            this.SelectedRectangleGroupBox.Controls.Add(this.SelectedYLabel);
            this.SelectedRectangleGroupBox.Controls.Add(this.SelectedXLabel);
            this.SelectedRectangleGroupBox.Controls.Add(this.SelectedIdLabel);
            this.SelectedRectangleGroupBox.Controls.Add(this.SelectedHeightTextBox);
            this.SelectedRectangleGroupBox.Controls.Add(this.SelectedWidthTextBox);
            this.SelectedRectangleGroupBox.Controls.Add(this.SelectedYTextBox);
            this.SelectedRectangleGroupBox.Controls.Add(this.SelectedXTextBox);
            this.SelectedRectangleGroupBox.Controls.Add(this.SelectedIdTextBox);
            this.SelectedRectangleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedRectangleGroupBox.Location = new System.Drawing.Point(3, 238);
            this.SelectedRectangleGroupBox.Name = "SelectedRectangleGroupBox";
            this.SelectedRectangleGroupBox.Size = new System.Drawing.Size(326, 229);
            this.SelectedRectangleGroupBox.TabIndex = 4;
            this.SelectedRectangleGroupBox.TabStop = false;
            this.SelectedRectangleGroupBox.Text = "Selected Rectangle:";
            // 
            // SelectedHeightLabel
            // 
            this.SelectedHeightLabel.AutoSize = true;
            this.SelectedHeightLabel.Location = new System.Drawing.Point(5, 142);
            this.SelectedHeightLabel.Name = "SelectedHeightLabel";
            this.SelectedHeightLabel.Size = new System.Drawing.Size(46, 15);
            this.SelectedHeightLabel.TabIndex = 9;
            this.SelectedHeightLabel.Text = "Height:";
            // 
            // SelectedWidthLabel
            // 
            this.SelectedWidthLabel.AutoSize = true;
            this.SelectedWidthLabel.Location = new System.Drawing.Point(9, 112);
            this.SelectedWidthLabel.Name = "SelectedWidthLabel";
            this.SelectedWidthLabel.Size = new System.Drawing.Size(42, 15);
            this.SelectedWidthLabel.TabIndex = 8;
            this.SelectedWidthLabel.Text = "Width:";
            // 
            // SelectedYLabel
            // 
            this.SelectedYLabel.AutoSize = true;
            this.SelectedYLabel.Location = new System.Drawing.Point(34, 84);
            this.SelectedYLabel.Name = "SelectedYLabel";
            this.SelectedYLabel.Size = new System.Drawing.Size(17, 15);
            this.SelectedYLabel.TabIndex = 7;
            this.SelectedYLabel.Text = "Y:";
            // 
            // SelectedXLabel
            // 
            this.SelectedXLabel.AutoSize = true;
            this.SelectedXLabel.Location = new System.Drawing.Point(34, 55);
            this.SelectedXLabel.Name = "SelectedXLabel";
            this.SelectedXLabel.Size = new System.Drawing.Size(17, 15);
            this.SelectedXLabel.TabIndex = 6;
            this.SelectedXLabel.Text = "X:";
            // 
            // SelectedIdLabel
            // 
            this.SelectedIdLabel.AutoSize = true;
            this.SelectedIdLabel.Location = new System.Drawing.Point(31, 26);
            this.SelectedIdLabel.Name = "SelectedIdLabel";
            this.SelectedIdLabel.Size = new System.Drawing.Size(20, 15);
            this.SelectedIdLabel.TabIndex = 5;
            this.SelectedIdLabel.Text = "Id:";
            // 
            // SelectedHeightTextBox
            // 
            this.SelectedHeightTextBox.Location = new System.Drawing.Point(56, 138);
            this.SelectedHeightTextBox.Name = "SelectedHeightTextBox";
            this.SelectedHeightTextBox.Size = new System.Drawing.Size(150, 23);
            this.SelectedHeightTextBox.TabIndex = 4;
            this.SelectedHeightTextBox.TextChanged += new System.EventHandler(this.SelectedHeightTextBox_TextChanged);
            // 
            // SelectedWidthTextBox
            // 
            this.SelectedWidthTextBox.Location = new System.Drawing.Point(56, 109);
            this.SelectedWidthTextBox.Name = "SelectedWidthTextBox";
            this.SelectedWidthTextBox.Size = new System.Drawing.Size(150, 23);
            this.SelectedWidthTextBox.TabIndex = 3;
            this.SelectedWidthTextBox.TextChanged += new System.EventHandler(this.SelectedWidthTextBox_TextChanged);
            // 
            // SelectedYTextBox
            // 
            this.SelectedYTextBox.Location = new System.Drawing.Point(56, 80);
            this.SelectedYTextBox.Name = "SelectedYTextBox";
            this.SelectedYTextBox.Size = new System.Drawing.Size(150, 23);
            this.SelectedYTextBox.TabIndex = 2;
            this.SelectedYTextBox.TextChanged += new System.EventHandler(this.SelectedYTextBox_TextChanged);
            // 
            // SelectedXTextBox
            // 
            this.SelectedXTextBox.Location = new System.Drawing.Point(56, 51);
            this.SelectedXTextBox.Name = "SelectedXTextBox";
            this.SelectedXTextBox.Size = new System.Drawing.Size(150, 23);
            this.SelectedXTextBox.TabIndex = 1;
            this.SelectedXTextBox.TextChanged += new System.EventHandler(this.SelectedXTextBox_TextChanged);
            // 
            // SelectedIdTextBox
            // 
            this.SelectedIdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SelectedIdTextBox.Location = new System.Drawing.Point(56, 22);
            this.SelectedIdTextBox.Name = "SelectedIdTextBox";
            this.SelectedIdTextBox.Size = new System.Drawing.Size(150, 23);
            this.SelectedIdTextBox.TabIndex = 0;
            this.SelectedIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectedIdTextBox_KeyPress);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.InfoRectanglesListBox);
            this.InfoGroupBox.Controls.Add(this.RemovePictureBox);
            this.InfoGroupBox.Controls.Add(this.AddPictureBox);
            this.InfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(326, 229);
            this.InfoGroupBox.TabIndex = 4;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Rectangles:";
            // 
            // InfoRectanglesListBox
            // 
            this.InfoRectanglesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoRectanglesListBox.FormattingEnabled = true;
            this.InfoRectanglesListBox.IntegralHeight = false;
            this.InfoRectanglesListBox.ItemHeight = 15;
            this.InfoRectanglesListBox.Location = new System.Drawing.Point(3, 19);
            this.InfoRectanglesListBox.Name = "InfoRectanglesListBox";
            this.InfoRectanglesListBox.Size = new System.Drawing.Size(321, 157);
            this.InfoRectanglesListBox.TabIndex = 0;
            this.InfoRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.InfoRectanglesListBox_SelectedIndexChanged);
            // 
            // RemovePictureBox
            // 
            this.RemovePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RemovePictureBox.Image = global::Programming.Properties.Resources.RemoveIcon_30x30;
            this.RemovePictureBox.Location = new System.Drawing.Point(182, 186);
            this.RemovePictureBox.Name = "RemovePictureBox";
            this.RemovePictureBox.Size = new System.Drawing.Size(30, 30);
            this.RemovePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemovePictureBox.TabIndex = 3;
            this.RemovePictureBox.TabStop = false;
            this.RemovePictureBox.Click += new System.EventHandler(this.RemovePictureBox_Click);
            this.RemovePictureBox.MouseLeave += new System.EventHandler(this.RemovePictureBox_MouseLeave);
            this.RemovePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemovePictureBox_MouseMove);
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddPictureBox.Image = global::Programming.Properties.Resources.AddIcon_30x30;
            this.AddPictureBox.Location = new System.Drawing.Point(109, 185);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(30, 30);
            this.AddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddPictureBox.TabIndex = 2;
            this.AddPictureBox.TabStop = false;
            this.AddPictureBox.Click += new System.EventHandler(this.AddPictureBox_Click);
            this.AddPictureBox.MouseLeave += new System.EventHandler(this.AddPictureBox_MouseLeave);
            this.AddPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddPictureBox_MouseMove);
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CanvasPanel.Location = new System.Drawing.Point(341, 3);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(623, 470);
            this.CanvasPanel.TabIndex = 1;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(967, 476);
            this.RectanglesTableLayoutPanel.ResumeLayout(false);
            this.InfoRectanglesTableLayoutPanel.ResumeLayout(false);
            this.SelectedRectangleGroupBox.ResumeLayout(false);
            this.SelectedRectangleGroupBox.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel RectanglesTableLayoutPanel;
        private TableLayoutPanel InfoRectanglesTableLayoutPanel;
        private GroupBox SelectedRectangleGroupBox;
        private Label SelectedHeightLabel;
        private Label SelectedWidthLabel;
        private Label SelectedYLabel;
        private Label SelectedXLabel;
        private Label SelectedIdLabel;
        private TextBox SelectedHeightTextBox;
        private TextBox SelectedWidthTextBox;
        private TextBox SelectedYTextBox;
        private TextBox SelectedXTextBox;
        private TextBox SelectedIdTextBox;
        private GroupBox InfoGroupBox;
        private ListBox InfoRectanglesListBox;
        private PictureBox RemovePictureBox;
        private PictureBox AddPictureBox;
        private Panel CanvasPanel;
    }
}
