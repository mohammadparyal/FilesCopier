namespace DeploymentBuildTool
{
    partial class MainForm
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
            this.RootFolderLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialogBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.OpenFolderBrowserDialogBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.allFilesUrlsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.targetFileBrowserBtn = new System.Windows.Forms.Button();
            this.targetFolderBrowserTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.targetFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CopyFilesBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.autoGenerateTargetFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // RootFolderLabel
            // 
            this.RootFolderLabel.AutoSize = true;
            this.RootFolderLabel.Location = new System.Drawing.Point(14, 14);
            this.RootFolderLabel.Name = "RootFolderLabel";
            this.RootFolderLabel.Size = new System.Drawing.Size(101, 13);
            this.RootFolderLabel.TabIndex = 0;
            this.RootFolderLabel.Text = "Select Root Folder :";
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.Location = new System.Drawing.Point(17, 42);
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.Size = new System.Drawing.Size(614, 20);
            this.folderPathTextBox.TabIndex = 2;
            // 
            // OpenFolderBrowserDialogBtn
            // 
            this.OpenFolderBrowserDialogBtn.Location = new System.Drawing.Point(637, 39);
            this.OpenFolderBrowserDialogBtn.Name = "OpenFolderBrowserDialogBtn";
            this.OpenFolderBrowserDialogBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenFolderBrowserDialogBtn.TabIndex = 1;
            this.OpenFolderBrowserDialogBtn.Text = "Open";
            this.OpenFolderBrowserDialogBtn.UseVisualStyleBackColor = true;
            this.OpenFolderBrowserDialogBtn.Click += new System.EventHandler(this.OpenFolderBrowserDialogBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paste all file local urls :";
            // 
            // allFilesUrlsRichTextBox
            // 
            this.allFilesUrlsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allFilesUrlsRichTextBox.Location = new System.Drawing.Point(12, 106);
            this.allFilesUrlsRichTextBox.Name = "allFilesUrlsRichTextBox";
            this.allFilesUrlsRichTextBox.Size = new System.Drawing.Size(698, 209);
            this.allFilesUrlsRichTextBox.TabIndex = 4;
            this.allFilesUrlsRichTextBox.Text = "";
            // 
            // targetFileBrowserBtn
            // 
            this.targetFileBrowserBtn.Location = new System.Drawing.Point(637, 350);
            this.targetFileBrowserBtn.Name = "targetFileBrowserBtn";
            this.targetFileBrowserBtn.Size = new System.Drawing.Size(75, 23);
            this.targetFileBrowserBtn.TabIndex = 6;
            this.targetFileBrowserBtn.Text = "Open";
            this.targetFileBrowserBtn.UseVisualStyleBackColor = true;
            this.targetFileBrowserBtn.Click += new System.EventHandler(this.targetFileBrowserBtn_Click);
            // 
            // targetFolderBrowserTextBox
            // 
            this.targetFolderBrowserTextBox.Location = new System.Drawing.Point(12, 352);
            this.targetFolderBrowserTextBox.Name = "targetFolderBrowserTextBox";
            this.targetFolderBrowserTextBox.Size = new System.Drawing.Size(619, 20);
            this.targetFolderBrowserTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Target Paste Folder :";
            // 
            // CopyFilesBtn
            // 
            this.CopyFilesBtn.Location = new System.Drawing.Point(365, 425);
            this.CopyFilesBtn.Name = "CopyFilesBtn";
            this.CopyFilesBtn.Size = new System.Drawing.Size(75, 23);
            this.CopyFilesBtn.TabIndex = 8;
            this.CopyFilesBtn.Text = "Copy Files";
            this.CopyFilesBtn.UseVisualStyleBackColor = true;
            this.CopyFilesBtn.Click += new System.EventHandler(this.CopyFilesBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(270, 425);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // autoGenerateTargetFolderCheckBox
            // 
            this.autoGenerateTargetFolderCheckBox.AutoSize = true;
            this.autoGenerateTargetFolderCheckBox.Checked = true;
            this.autoGenerateTargetFolderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoGenerateTargetFolderCheckBox.Location = new System.Drawing.Point(12, 390);
            this.autoGenerateTargetFolderCheckBox.Name = "autoGenerateTargetFolderCheckBox";
            this.autoGenerateTargetFolderCheckBox.Size = new System.Drawing.Size(161, 17);
            this.autoGenerateTargetFolderCheckBox.TabIndex = 10;
            this.autoGenerateTargetFolderCheckBox.Text = "Auto Generate Target Folder";
            this.autoGenerateTargetFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 490);
            this.Controls.Add(this.autoGenerateTargetFolderCheckBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CopyFilesBtn);
            this.Controls.Add(this.targetFileBrowserBtn);
            this.Controls.Add(this.targetFolderBrowserTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.allFilesUrlsRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenFolderBrowserDialogBtn);
            this.Controls.Add(this.folderPathTextBox);
            this.Controls.Add(this.RootFolderLabel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RootFolderLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogBrowser;
        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.Button OpenFolderBrowserDialogBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox allFilesUrlsRichTextBox;
        private System.Windows.Forms.Button targetFileBrowserBtn;
        private System.Windows.Forms.TextBox targetFolderBrowserTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog targetFolderBrowserDialog;
        private System.Windows.Forms.Button CopyFilesBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.CheckBox autoGenerateTargetFolderCheckBox;
    }
}

