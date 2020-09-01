using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Library.Basic
{
    public class ToolDialog
    {
        public static string OpenFile(string fileName, string title, string initPath = null, string filter = null)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = initPath;
            dlg.Title = title;
            dlg.Filter = filter;
            dlg.FileName = fileName;

            string result = null;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                result = dlg.FileName;
            }

            return result;
        }

        public static string SaveFile(string fileName, string title, string initPath = null, string filter = null)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.InitialDirectory = initPath;
            dlg.Title = title;
            dlg.Filter = filter;
            dlg.AddExtension = true;
            dlg.FileName = fileName;
            string result = null;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                result = dlg.FileName;
            }

            return result;
        }

        public static string OpenFolder(string title, bool showNewFolder = true, string initPath = null)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = initPath;
            dlg.Description = title;
            dlg.ShowNewFolderButton = showNewFolder;
            string result = null;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                result = dlg.SelectedPath;
            }
            return result;
        }
    }
}
