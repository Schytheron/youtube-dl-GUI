namespace youtube_dl_gui
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FPSDropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QualityDropDown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.downloadPathTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(121, 65);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(280, 20);
            this.URLTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "YouTube Video URL";
            // 
            // FPSDropDown
            // 
            this.FPSDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FPSDropDown.FormattingEnabled = true;
            this.FPSDropDown.Items.AddRange(new object[] {
            "30",
            "50",
            "60"});
            this.FPSDropDown.Location = new System.Drawing.Point(356, 190);
            this.FPSDropDown.Name = "FPSDropDown";
            this.FPSDropDown.Size = new System.Drawing.Size(45, 21);
            this.FPSDropDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FPS";
            // 
            // QualityDropDown
            // 
            this.QualityDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QualityDropDown.FormattingEnabled = true;
            this.QualityDropDown.Items.AddRange(new object[] {
            "144p",
            "240p",
            "360p",
            "480p",
            "720p",
            "1080p",
            "1440p",
            "2160p (4K)",
            "4320p (8K)"});
            this.QualityDropDown.Location = new System.Drawing.Point(121, 190);
            this.QualityDropDown.Name = "QualityDropDown";
            this.QualityDropDown.Size = new System.Drawing.Size(80, 21);
            this.QualityDropDown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Video Quality";
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(161, 254);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadButton.TabIndex = 6;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(374, 125);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(27, 23);
            this.selectFolderButton.TabIndex = 7;
            this.selectFolderButton.Text = "...";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // downloadPathTxtBox
            // 
            this.downloadPathTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.downloadPathTxtBox.Location = new System.Drawing.Point(121, 127);
            this.downloadPathTxtBox.Name = "downloadPathTxtBox";
            this.downloadPathTxtBox.ReadOnly = true;
            this.downloadPathTxtBox.Size = new System.Drawing.Size(247, 20);
            this.downloadPathTxtBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Download path ";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select folder to which you wish to store your downloaded video";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(271, 254);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 324);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.downloadPathTxtBox);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QualityDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FPSDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URLTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "youtube-dl GUI";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FPSDropDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox QualityDropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.TextBox downloadPathTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button UpdateButton;
    }
}

