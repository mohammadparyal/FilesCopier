using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeploymentBuildTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            folderPathTextBox.ReadOnly = true;
            targetFolderBrowserTextBox.ReadOnly = true;

            folderPathTextBox.Text = SpecialSettings.Default.RootFolderPath;
            targetFolderBrowserTextBox.Text = SpecialSettings.Default.TargetFolderPath;
        }

        private void OpenFolderBrowserDialogBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialogBrowser.ShowNewFolderButton = false;
            var result = folderBrowserDialogBrowser.ShowDialog();
            if (result != DialogResult.OK)
            {
                if (MessageBox.Show("Please select root path of your project folder which should contains branches", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                {
                    result = folderBrowserDialogBrowser.ShowDialog();
                };
            }

            if (!string.IsNullOrEmpty(folderBrowserDialogBrowser.SelectedPath))
            {
                folderPathTextBox.Text = folderBrowserDialogBrowser.SelectedPath;
                SpecialSettings.Default.RootFolderPath = folderPathTextBox.Text;
                SpecialSettings.Default.Save();
            }
        }

        private void targetFileBrowserBtn_Click(object sender, EventArgs e)
        {
            targetFolderBrowserDialog.ShowNewFolderButton = false;
            var result = targetFolderBrowserDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                if (MessageBox.Show("Please select root path of your project folder which should contains branches", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                {
                    result = targetFolderBrowserDialog.ShowDialog();
                };
            }

            if (!string.IsNullOrEmpty(targetFolderBrowserDialog.SelectedPath))
            {
                targetFolderBrowserTextBox.Text = targetFolderBrowserDialog.SelectedPath;
                SpecialSettings.Default.TargetFolderPath = targetFolderBrowserTextBox.Text;

                SpecialSettings.Default.Save();

            }
        }

        private void CopyFilesBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(allFilesUrlsRichTextBox.Text) && !string.IsNullOrEmpty(SpecialSettings.Default.TargetFolderPath) && !string.IsNullOrEmpty(SpecialSettings.Default.RootFolderPath))
            {
                var targetFolderPath = Path.GetFullPath(SpecialSettings.Default.TargetFolderPath + (autoGenerateTargetFolderCheckBox.Checked ? ("\\" + DateTime.Now.ToString("ddMMyyyy-hhmmdd")) : string.Empty));
                var paths = allFilesUrlsRichTextBox.Text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var path in paths)
                {
                    var fullPath = Path.GetFullPath(SpecialSettings.Default.RootFolderPath + path);

                    if (File.Exists(fullPath))
                    {
                        var destinationPath = Path.GetFullPath(targetFolderPath + path);
                        Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
                        File.Copy(fullPath, destinationPath, true);
                    }
                }

                MessageBox.Show("Copied successfull");
                Process.Start(targetFolderPath);
            }
            else
            {
                MessageBox.Show("Please enter file urls Or select folder paths", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
