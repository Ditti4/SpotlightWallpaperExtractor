namespace SpotlightWallpaperExtractor {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.textBoxOutputFolder = new System.Windows.Forms.TextBox();
            this.groupBoxExportOptions = new System.Windows.Forms.GroupBox();
            this.buttonExportMostRecent = new System.Windows.Forms.Button();
            this.buttonExportTodays = new System.Windows.Forms.Button();
            this.buttonExportAll = new System.Windows.Forms.Button();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxExportOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.Controls.Add(this.textBoxOutputFolder);
            this.groupBoxSettings.Controls.Add(this.buttonChooseFolder);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(260, 82);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Export settings";
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseFolder.Location = new System.Drawing.Point(7, 20);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(247, 23);
            this.buttonChooseFolder.TabIndex = 0;
            this.buttonChooseFolder.Text = "Choose output folder";
            this.buttonChooseFolder.UseVisualStyleBackColor = true;
            this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
            // 
            // textBoxOutputFolder
            // 
            this.textBoxOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputFolder.Location = new System.Drawing.Point(7, 50);
            this.textBoxOutputFolder.Name = "textBoxOutputFolder";
            this.textBoxOutputFolder.ReadOnly = true;
            this.textBoxOutputFolder.Size = new System.Drawing.Size(247, 20);
            this.textBoxOutputFolder.TabIndex = 1;
            // 
            // groupBoxExportOptions
            // 
            this.groupBoxExportOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxExportOptions.Controls.Add(this.buttonExportAll);
            this.groupBoxExportOptions.Controls.Add(this.buttonExportTodays);
            this.groupBoxExportOptions.Controls.Add(this.buttonExportMostRecent);
            this.groupBoxExportOptions.Enabled = false;
            this.groupBoxExportOptions.Location = new System.Drawing.Point(13, 101);
            this.groupBoxExportOptions.Name = "groupBoxExportOptions";
            this.groupBoxExportOptions.Size = new System.Drawing.Size(259, 113);
            this.groupBoxExportOptions.TabIndex = 1;
            this.groupBoxExportOptions.TabStop = false;
            this.groupBoxExportOptions.Text = "Export options";
            // 
            // buttonExportMostRecent
            // 
            this.buttonExportMostRecent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportMostRecent.Location = new System.Drawing.Point(7, 20);
            this.buttonExportMostRecent.Name = "buttonExportMostRecent";
            this.buttonExportMostRecent.Size = new System.Drawing.Size(246, 23);
            this.buttonExportMostRecent.TabIndex = 0;
            this.buttonExportMostRecent.Text = "Export most recent wallpaper";
            this.buttonExportMostRecent.UseVisualStyleBackColor = true;
            this.buttonExportMostRecent.Click += new System.EventHandler(this.buttonExportMostRecent_Click);
            // 
            // buttonExportTodays
            // 
            this.buttonExportTodays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportTodays.Location = new System.Drawing.Point(7, 50);
            this.buttonExportTodays.Name = "buttonExportTodays";
            this.buttonExportTodays.Size = new System.Drawing.Size(246, 23);
            this.buttonExportTodays.TabIndex = 1;
            this.buttonExportTodays.Text = "Export today\'s wallpapers";
            this.buttonExportTodays.UseVisualStyleBackColor = true;
            this.buttonExportTodays.Click += new System.EventHandler(this.buttonExportTodays_Click);
            // 
            // buttonExportAll
            // 
            this.buttonExportAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportAll.Location = new System.Drawing.Point(7, 80);
            this.buttonExportAll.Name = "buttonExportAll";
            this.buttonExportAll.Size = new System.Drawing.Size(246, 23);
            this.buttonExportAll.TabIndex = 2;
            this.buttonExportAll.Text = "Export all wallpapers";
            this.buttonExportAll.UseVisualStyleBackColor = true;
            this.buttonExportAll.Click += new System.EventHandler(this.buttonExportAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Controls.Add(this.groupBoxExportOptions);
            this.Controls.Add(this.groupBoxSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Spotlight wallpaper extractor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxExportOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TextBox textBoxOutputFolder;
        private System.Windows.Forms.Button buttonChooseFolder;
        private System.Windows.Forms.GroupBox groupBoxExportOptions;
        private System.Windows.Forms.Button buttonExportAll;
        private System.Windows.Forms.Button buttonExportTodays;
        private System.Windows.Forms.Button buttonExportMostRecent;
    }
}

