using System;
using System.Windows.Forms;

namespace SpotlightWallpaperExtractor {
    public partial class MainForm : Form {
        public SpotlightDirectory SpotlightDirectory { get; } = new SpotlightDirectory();

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            if (Environment.OSVersion.Version.Major < 10) {
                MessageBox.Show("This application can only be run on Windows 10 and up, earlier versions of Windows " +
                    "don't offer the Spotlight feature. Thank you for your undestanding.", "Unsupported operating system");
                Close();
            }
        }

        private void buttonChooseFolder_Click(object sender, EventArgs e) {
            FolderBrowserDialog outputFolderDialog = new FolderBrowserDialog();
            outputFolderDialog.Description = "Select the folder you want to export the wallpapers to";
            outputFolderDialog.ShowNewFolderButton = true;
            if (outputFolderDialog.ShowDialog() == DialogResult.OK) {
                groupBoxExportOptions.Enabled = true;
                textBoxOutputFolder.Text = outputFolderDialog.SelectedPath;
            }
        }

        private void buttonExportMostRecent_Click(object sender, EventArgs e) {
            LoadImagesIfNeeded();
            ShowResultDialog(SpotlightDirectory.ExportMostRecentWallpaper(textBoxOutputFolder.Text));
        }

        private void buttonExportTodays_Click(object sender, EventArgs e) {
            LoadImagesIfNeeded();
            ShowResultDialog(SpotlightDirectory.ExportTodaysWallpapers(textBoxOutputFolder.Text));
        }

        private void buttonExportAll_Click(object sender, EventArgs e) {
            LoadImagesIfNeeded();
            ShowResultDialog(SpotlightDirectory.ExportWallpapers(SpotlightDirectory.Wallpapers, textBoxOutputFolder.Text));
        }

        private void LoadImagesIfNeeded() {
            if (SpotlightDirectory.Wallpapers.Count == 0) {
                SpotlightDirectory.LoadImages();
            }
        }

        private void ShowResultDialog(bool result) {
            if (result) {
                MessageBox.Show("Export succeeded.", "Success");
            } else {
                MessageBox.Show("Export failed for some reason. Does the output folder exist and is it writeable?", "Error");
            }
        }
    }
}
