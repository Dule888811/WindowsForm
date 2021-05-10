namespace WindowsFormsApp1
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
            this.FoldersAndF = new System.Windows.Forms.TreeView();
            this.buttonFolderFiles = new System.Windows.Forms.Button();
            this.createXmlFile = new System.Windows.Forms.Button();
            this.dataFolder = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // FoldersAndF
            // 
            this.FoldersAndF.Location = new System.Drawing.Point(1, 1);
            this.FoldersAndF.Name = "FoldersAndF";
            this.FoldersAndF.Size = new System.Drawing.Size(495, 449);
            this.FoldersAndF.TabIndex = 0;
            // 
            // buttonFolderFiles
            // 
            this.buttonFolderFiles.Location = new System.Drawing.Point(593, 415);
            this.buttonFolderFiles.Name = "buttonFolderFiles";
            this.buttonFolderFiles.Size = new System.Drawing.Size(130, 23);
            this.buttonFolderFiles.TabIndex = 1;
            this.buttonFolderFiles.Text = "FolderAndFiles";
            this.buttonFolderFiles.UseVisualStyleBackColor = true;
            this.buttonFolderFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // createXmlFile
            // 
            this.createXmlFile.Location = new System.Drawing.Point(512, 415);
            this.createXmlFile.Name = "createXmlFile";
            this.createXmlFile.Size = new System.Drawing.Size(75, 23);
            this.createXmlFile.TabIndex = 3;
            this.createXmlFile.Text = "xmlFile";
            this.createXmlFile.UseVisualStyleBackColor = true;
            // 
            // dataFolder
            // 
            this.dataFolder.FullRowSelect = true;
            this.dataFolder.GridLines = true;
            this.dataFolder.HideSelection = false;
            this.dataFolder.Location = new System.Drawing.Point(542, 1);
            this.dataFolder.Name = "dataFolder";
            this.dataFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataFolder.Size = new System.Drawing.Size(246, 408);
            this.dataFolder.TabIndex = 4;
            this.dataFolder.UseCompatibleStateImageBehavior = false;
            this.dataFolder.View = System.Windows.Forms.View.Details;
           // this.dataFolder.SelectedIndexChanged += new System.EventHandler(this.dataFolder_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataFolder);
            this.Controls.Add(this.createXmlFile);
            this.Controls.Add(this.buttonFolderFiles);
            this.Controls.Add(this.FoldersAndF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView FoldersAndF;
        private System.Windows.Forms.Button buttonFolderFiles;
        private System.Windows.Forms.Button createXmlFile;
        private System.Windows.Forms.ListView dataFolder;
    }
}

