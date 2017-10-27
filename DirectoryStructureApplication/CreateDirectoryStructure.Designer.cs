namespace DirectoryStructureApplication
{
    partial class CreateDirectoryStructure
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.selectRootFolder = new System.Windows.Forms.Button();
            this.closeDialog = new System.Windows.Forms.Button();
            this.selectedFolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectRootFolder
            // 
            this.selectRootFolder.AutoSize = true;
            this.selectRootFolder.Location = new System.Drawing.Point(45, 65);
            this.selectRootFolder.Name = "selectRootFolder";
            this.selectRootFolder.Padding = new System.Windows.Forms.Padding(5);
            this.selectRootFolder.Size = new System.Drawing.Size(115, 33);
            this.selectRootFolder.TabIndex = 0;
            this.selectRootFolder.Text = "Select Root Folder";
            this.selectRootFolder.UseVisualStyleBackColor = true;
            this.selectRootFolder.Click += new System.EventHandler(this.selectRootFolder_Click);
            // 
            // closeDialog
            // 
            this.closeDialog.AutoSize = true;
            this.closeDialog.Location = new System.Drawing.Point(200, 65);
            this.closeDialog.Name = "closeDialog";
            this.closeDialog.Padding = new System.Windows.Forms.Padding(5);
            this.closeDialog.Size = new System.Drawing.Size(75, 33);
            this.closeDialog.TabIndex = 1;
            this.closeDialog.Text = "Close";
            this.closeDialog.UseVisualStyleBackColor = true;
            this.closeDialog.Click += new System.EventHandler(this.closeDialog_Click);
            // 
            // selectedFolder
            // 
            this.selectedFolder.AutoSize = true;
            this.selectedFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFolder.Location = new System.Drawing.Point(40, 10);
            this.selectedFolder.Name = "selectedFolder";
            this.selectedFolder.Padding = new System.Windows.Forms.Padding(5);
            this.selectedFolder.Size = new System.Drawing.Size(137, 23);
            this.selectedFolder.TabIndex = 2;
            this.selectedFolder.Text = "Selected Root Folder";
            this.selectedFolder.Visible = false;
            // 
            // CreateDirectoryStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 161);
            this.Controls.Add(this.selectedFolder);
            this.Controls.Add(this.closeDialog);
            this.Controls.Add(this.selectRootFolder);
            this.Name = "CreateDirectoryStructure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Directory Structure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button selectRootFolder;
        private System.Windows.Forms.Button closeDialog;
        private System.Windows.Forms.Label selectedFolder;
    }
}

