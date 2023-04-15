using MetroFramework.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace FileAttributeManager
{
    partial class Form1
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
            this.FileNameLabel = new MetroFramework.Controls.MetroLabel();
            this.isHidden = new MetroFramework.Controls.MetroCheckBox();
            this.IsReadonly = new MetroFramework.Controls.MetroCheckBox();
            this.IsSystem = new MetroFramework.Controls.MetroCheckBox();
            this.IsCompressed = new MetroFramework.Controls.MetroCheckBox();
            this.CreateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AccessedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.StartButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.FileChooseButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.FileNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.FileNameLabel.Location = new System.Drawing.Point(240, 195);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(382, 37);
            this.FileNameLabel.Style = MetroFramework.MetroColorStyle.White;
            this.FileNameLabel.TabIndex = 1;
            this.FileNameLabel.Text = "select the file and Drag&Drop him to the Panel";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FileNameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FileNameLabel.UseStyleColors = true;
            // 
            // isHidden
            // 
            this.isHidden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isHidden.AutoSize = true;
            this.isHidden.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.isHidden.Location = new System.Drawing.Point(232, 260);
            this.isHidden.Name = "isHidden";
            this.isHidden.Size = new System.Drawing.Size(79, 19);
            this.isHidden.Style = MetroFramework.MetroColorStyle.Green;
            this.isHidden.TabIndex = 2;
            this.isHidden.Text = "IsHidden";
            this.isHidden.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.isHidden.UseStyleColors = true;
            this.isHidden.UseVisualStyleBackColor = true;
            // 
            // IsReadonly
            // 
            this.IsReadonly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IsReadonly.AutoSize = true;
            this.IsReadonly.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.IsReadonly.Location = new System.Drawing.Point(232, 287);
            this.IsReadonly.Name = "IsReadonly";
            this.IsReadonly.Size = new System.Drawing.Size(91, 19);
            this.IsReadonly.Style = MetroFramework.MetroColorStyle.Green;
            this.IsReadonly.TabIndex = 3;
            this.IsReadonly.Text = "IsReadonly";
            this.IsReadonly.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IsReadonly.UseStyleColors = true;
            this.IsReadonly.UseVisualStyleBackColor = true;
            // 
            // IsSystem
            // 
            this.IsSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IsSystem.AutoSize = true;
            this.IsSystem.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.IsSystem.Location = new System.Drawing.Point(232, 312);
            this.IsSystem.Name = "IsSystem";
            this.IsSystem.Size = new System.Drawing.Size(79, 19);
            this.IsSystem.Style = MetroFramework.MetroColorStyle.Green;
            this.IsSystem.TabIndex = 5;
            this.IsSystem.Text = "IsSystem";
            this.IsSystem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IsSystem.UseStyleColors = true;
            this.IsSystem.UseVisualStyleBackColor = true;
            // 
            // IsCompressed
            // 
            this.IsCompressed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IsCompressed.AutoSize = true;
            this.IsCompressed.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.IsCompressed.Location = new System.Drawing.Point(232, 337);
            this.IsCompressed.Name = "IsCompressed";
            this.IsCompressed.Size = new System.Drawing.Size(111, 19);
            this.IsCompressed.Style = MetroFramework.MetroColorStyle.Green;
            this.IsCompressed.TabIndex = 6;
            this.IsCompressed.Text = "IsCompressed";
            this.IsCompressed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IsCompressed.UseStyleColors = true;
            this.IsCompressed.UseVisualStyleBackColor = true;
            // 
            // CreateDatePicker
            // 
            this.CreateDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.CreateDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.CreateDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.CreateDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.CreateDatePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.CreateDatePicker.Location = new System.Drawing.Point(459, 259);
            this.CreateDatePicker.Name = "CreateDatePicker";
            this.CreateDatePicker.Size = new System.Drawing.Size(200, 20);
            this.CreateDatePicker.TabIndex = 7;
            // 
            // ModifiedDatePicker
            // 
            this.ModifiedDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifiedDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifiedDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.ModifiedDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.ModifiedDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.ModifiedDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.ModifiedDatePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.ModifiedDatePicker.Location = new System.Drawing.Point(459, 299);
            this.ModifiedDatePicker.Name = "ModifiedDatePicker";
            this.ModifiedDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ModifiedDatePicker.TabIndex = 8;
            // 
            // AccessedDatePicker
            // 
            this.AccessedDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccessedDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessedDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.AccessedDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.AccessedDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.AccessedDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.AccessedDatePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.AccessedDatePicker.Location = new System.Drawing.Point(459, 343);
            this.AccessedDatePicker.Name = "AccessedDatePicker";
            this.AccessedDatePicker.Size = new System.Drawing.Size(200, 20);
            this.AccessedDatePicker.TabIndex = 9;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(491, 239);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "select create file date";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(491, 279);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(152, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "select modified file date";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(491, 324);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(137, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "select access file date";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartButton.Highlight = true;
            this.StartButton.Location = new System.Drawing.Point(369, 426);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(142, 23);
            this.StartButton.Style = MetroFramework.MetroColorStyle.Green;
            this.StartButton.TabIndex = 13;
            this.StartButton.Text = "Apply changes";
            this.StartButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.AllowDrop = true;
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(104, 92);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(663, 100);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel1.TabIndex = 14;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FileChooseButton
            // 
            this.FileChooseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileChooseButton.Highlight = true;
            this.FileChooseButton.Location = new System.Drawing.Point(307, 53);
            this.FileChooseButton.Name = "FileChooseButton";
            this.FileChooseButton.Size = new System.Drawing.Size(269, 23);
            this.FileChooseButton.Style = MetroFramework.MetroColorStyle.Green;
            this.FileChooseButton.TabIndex = 15;
            this.FileChooseButton.Text = "Additional file selection button";
            this.FileChooseButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FileChooseButton.Click += new System.EventHandler(this.FileChooseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 472);
            this.ControlBox = false;
            this.Controls.Add(this.FileChooseButton);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.AccessedDatePicker);
            this.Controls.Add(this.ModifiedDatePicker);
            this.Controls.Add(this.CreateDatePicker);
            this.Controls.Add(this.IsCompressed);
            this.Controls.Add(this.IsSystem);
            this.Controls.Add(this.IsReadonly);
            this.Controls.Add(this.isHidden);
            this.Controls.Add(this.FileNameLabel);
            this.DisplayHeader = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Form1";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void File_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                CurrentFilePath = files[0];
                FileNameLabel.Text = "Selected file: " + new FileInfo(CurrentFilePath).Name;
                FileAttributes attributes = File.GetAttributes(CurrentFilePath);
                isHidden.Checked = (attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
                IsReadonly.Checked = (attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;
                IsSystem.Checked = (attributes & FileAttributes.System) == FileAttributes.System;
                IsCompressed.Checked = (attributes & FileAttributes.Compressed) == FileAttributes.Compressed;
                CreateDatePicker.Value = File.GetCreationTime(CurrentFilePath);
                ModifiedDatePicker.Value = File.GetLastWriteTime(CurrentFilePath);
                AccessedDatePicker.Value = File.GetLastAccessTime(CurrentFilePath);
            }
        }

        private void File_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        #endregion
        public MetroFramework.Controls.MetroLabel FileNameLabel;
        public MetroFramework.Controls.MetroCheckBox isHidden;
        public MetroFramework.Controls.MetroCheckBox IsReadonly;
        public MetroFramework.Controls.MetroCheckBox IsSystem;
        public MetroFramework.Controls.MetroCheckBox IsCompressed;
        private DateTimePicker CreateDatePicker;
        private DateTimePicker ModifiedDatePicker;
        private DateTimePicker AccessedDatePicker;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton StartButton;
        public MetroPanel metroPanel1;
        private MetroButton FileChooseButton;
    }
}

