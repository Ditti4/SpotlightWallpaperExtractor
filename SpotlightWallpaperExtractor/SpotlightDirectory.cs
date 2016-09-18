using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace SpotlightWallpaperExtractor {
    public class SpotlightDirectory {
        private const int ResolutionThreshold = 400;

        public string SpotlightWallpaperPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Packages",
            "Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy", "LocalState", "Assets");

        public List<Wallpaper> Wallpapers { get; } = new List<Wallpaper>();

        public void LoadImages() {
            foreach (string filename in Directory.GetFiles(SpotlightWallpaperPath)) {
                Wallpaper newEntry = new Wallpaper {Path = Path.Combine(SpotlightWallpaperPath, filename)};
                Image newImage;
                try {
                    newImage = Image.FromFile(newEntry.Path);
                } catch (OutOfMemoryException) {
                    // not an image but rather some other file, skip it
                    continue;
                }
                if (newImage.Width < ResolutionThreshold || newImage.Width < ResolutionThreshold) {
                    continue;
                }
                newEntry.Width = newImage.Width;
                newEntry.Height = newImage.Height;
                newEntry.Date = new FileInfo(newEntry.Path).CreationTime;
                Wallpapers.Add(newEntry);
            }
        }

        public IEnumerable<Wallpaper> GetTodaysWallpapers() {
            return Wallpapers.Where(w => w.Date.Date == DateTime.Today);
        }

        public IEnumerable<Wallpaper> GetMostRecentWallpaper() {
            // Spotlight seems to always download one desktop and one mobile version of each wallpaper so we just export both
            return Wallpapers.OrderByDescending(w => w.Date).Take(2);
        }

        public IEnumerable<Wallpaper> GetWallpapersByResolution(int width, int height) {
            return Wallpapers.OrderByDescending(w => w.Width == width && w.Height == height);
        }

        public bool ExportTodaysWallpapers(string path) {
            return ExportWallpapers(GetTodaysWallpapers(), path);
        }

        public bool ExportMostRecentWallpaper(string path) {
            return ExportWallpapers(GetMostRecentWallpaper(), path);
        }

        public bool ExportWallpapers(IEnumerable<Wallpaper> wallpapers, string path) {
            if (!Directory.Exists(path)) {
                return false;
            }
            string desktopDirectory = Path.Combine(path, "desktop");
            string mobileDirectory = Path.Combine(path, "mobile");
            if (!Directory.Exists(desktopDirectory)) {
                Directory.CreateDirectory(desktopDirectory);
            }
            if (!Directory.Exists(mobileDirectory)) {
                Directory.CreateDirectory(mobileDirectory);
            }
            foreach (Wallpaper wallpaper in wallpapers) {
                try {
                    File.Copy(wallpaper.Path, Path.Combine(wallpaper.Width > wallpaper.Height ? desktopDirectory : mobileDirectory, Path.GetFileName(wallpaper.Path) + ".jpg"), true);
                } catch (Exception) {
                    return false;
                }
            }
            return true;
        }
    }
}
