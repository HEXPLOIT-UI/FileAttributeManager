using MetroFramework.Forms;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FileAttributeManager
{
    public partial class Form1 : MetroForm
    {
        public string CurrentFilePath = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, System.EventArgs e)
        {
            File.SetAttributes(CurrentFilePath, File.GetAttributes(CurrentFilePath) | FileAttributes.Hidden);
            if (CurrentFilePath != null && File.Exists(CurrentFilePath))
            {
                try
                {
                    FileAttributes attributes = File.GetAttributes(CurrentFilePath);
                    if (isHidden.Checked)
                    {
                        File.SetAttributes(CurrentFilePath, File.GetAttributes(CurrentFilePath) | FileAttributes.Hidden);
                    }
                    else
                    {
                        attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
                        File.SetAttributes(CurrentFilePath, attributes);
                    }
                    FileAttributes attributes2 = File.GetAttributes(CurrentFilePath);
                    if (IsReadonly.Checked)
                    {
                        File.SetAttributes(CurrentFilePath, File.GetAttributes(CurrentFilePath) | FileAttributes.ReadOnly);
                    }
                    else
                    {
                        attributes2 = RemoveAttribute(attributes2, FileAttributes.ReadOnly);
                        File.SetAttributes(CurrentFilePath, attributes2);
                    }
                    FileAttributes attributes3 = File.GetAttributes(CurrentFilePath);
                    if (IsSystem.Checked)
                    {
                        File.SetAttributes(CurrentFilePath, File.GetAttributes(CurrentFilePath) | FileAttributes.System);
                    }
                    else
                    {
                        attributes3 = RemoveAttribute(attributes3, FileAttributes.System);
                        File.SetAttributes(CurrentFilePath, attributes3);
                    }
                    FileAttributes attributes4 = File.GetAttributes(CurrentFilePath);
                    if (IsCompressed.Checked)
                    {
                        File.SetAttributes(CurrentFilePath, File.GetAttributes(CurrentFilePath) | FileAttributes.Compressed);
                    }
                    else
                    {
                        attributes4 = RemoveAttribute(attributes4, FileAttributes.Compressed);
                        File.SetAttributes(CurrentFilePath, attributes4);
                    }
                    File.SetCreationTime(CurrentFilePath, CreateDatePicker.Value);
                    File.SetLastWriteTime(CurrentFilePath, ModifiedDatePicker.Value);
                    File.SetLastAccessTime(CurrentFilePath, AccessedDatePicker.Value);
                    Program.MessageBox("FileAttributeManager", "Done!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                } 
                catch(Exception ex)
                {
                    Program.MessageBox("FileAttributeManagerException", "File Attributes changed but with the error: " + ex.Message, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            else
            {
                Program.MessageBox("FileAttributeManagerException", "File not found", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

        private void FileChooseButton_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() =>
            {
                var openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CurrentFilePath = openFileDialog.FileName;
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
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
