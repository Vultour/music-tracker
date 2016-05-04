using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using MusicTracker.Core;


namespace MusicTracker.GUI
{
    class MainWindowController
    {
        private MusicList musicList;


        public MainWindow View { get; private set; }


        public MainWindowController()
        {
            this.musicList = new MusicList();
            this.View = new MainWindow();
        }


        private void loadPrevious()
        {
            if (!Directory.Exists(Properties.Resources.SAVE_FILE_PATH))
            {
                try { Directory.CreateDirectory(Properties.Resources.SAVE_FILE_PATH); }
                catch (Exception)
                {
                    MessageBox.Show(String.Format("{1}{0}{2}", Environment.NewLine, "Unable to create application directory.", String.Format("Make sure that {0} can be created", Properties.Resources.SAVE_FILE_PATH)), "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            if (!File.Exists(String.Format("{0}\\{1}", Properties.Resources.SAVE_FILE_PATH, Properties.Resources.SAVE_FILE_NAME)))
            {
                try { this.musicList.Save(String.Format("{0}\\{1}", Properties.Resources.SAVE_FILE_PATH, Properties.Resources.SAVE_FILE_NAME)); }
                catch (Exception)
                {
                    MessageBox.Show(String.Format("{1}{0}{2}", Environment.NewLine, "Unable to create a save file!", String.Format("Make sure {0} is writable", Properties.Resources.SAVE_FILE_PATH)), "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                try { this.musicList = MusicList.Load(String.Format("{0}\\{1}", Properties.Resources.SAVE_FILE_PATH, Properties.Resources.SAVE_FILE_NAME)); }
                catch (Exception)
                {
                    MessageBox.Show(String.Format("{1}{0}{2}{0}{3}", Environment.NewLine, "Unable to open the save file!", "The file might be corrupted.", String.Format("Try recovering your data from {0}\\{1} and delete the file when done", Properties.Resources.SAVE_FILE_PATH, Properties.Resources.SAVE_FILE_NAME)), "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }


        // TODO: Add event handlers
        public void AddNotDownloadedHandler(object sender, AddTrackEventArgs e)
        {
            // TODO
        }

        public void AddDownloadedHandler(object sender, AddTrackEventArgs e)
        {
            // TODO
        }

        public void SelectTrackHandler(object sender, SelectTrackEventArgs e)
        {
            // TODO
        }

        public void SaveTrackHandler(object sender, SaveTrackEventArgs e)
        {
            // TODO
        }

        public void CleanUnusedGenresHandler(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
