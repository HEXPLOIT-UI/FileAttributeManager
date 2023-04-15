using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FileAttributeManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void MessageBox(string title, string message, MessageBoxButtons buttons, MessageBoxIcon messageBoxIcon)
        {
            new Thread(() =>
            {
                System.Windows.Forms.MessageBox.Show(message, title, buttons, messageBoxIcon);
            }).Start();
        }
    }
}
