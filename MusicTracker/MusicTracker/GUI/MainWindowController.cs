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
            this.musicList.Change += this.MusicList_Change;

            this.View = new MainWindow();
            this.View.TrackAdded += this.AddTrack_Click;
            this.View.TrackSelected += this.SelectTrack_Click;
            this.View.TrackSaved += this.SaveTrack_Click;
            this.View.GenresCleaned += this.CleanGenres_Click;
            this.View.UpdateGenres(this.musicList.Genres.Genres);
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
        private void MusicList_Change(object sender, EventArgs e)
        {
            if (sender is MusicGenres) { this.View.Invoke((MethodInvoker)delegate { this.View.UpdateGenres(this.musicList.Genres.Genres); }); }
        }
        private void AddTrack_Click(object sender, AddTrackEventArgs e)
        {
            MusicItem tmp = this.musicList.AddTrack(e.Title, e.Artist, e.Genre, e.Downloaded);
            this.View.Invoke((MethodInvoker)delegate { this.View.AddTrack(tmp); });
        }

        private void RemoveTrack_Click(object sender, TrackEventArgs e)
        {
            this.musicList.RemoveTrack(e.Track);
        }

        private void SelectTrack_Click(object sender, SelectTrackEventArgs e)
        {
            this.View.Invoke((MethodInvoker)delegate { this.View.BeginEditTrack(e.Track); });
        }

        private void SaveTrack_Click(object sender, SaveTrackEventArgs e)
        {
            e.OldTrack.Title = e.NewTitle;
            e.OldTrack.Artist = e.NewArtist;
            e.OldTrack.Genre = this.musicList.Genres.CreateGetGenre(e.NewGenre);
            e.OldTrack.Downloaded = e.NewDownloaded;
        }

        private void CleanGenres_Click(object sender, EventArgs e)
        {
            int[] genres = this.musicList.Genres.GenreIDs;
            foreach (int genre in genres)
            {
                if (this.musicList.Tracks.Where((MusicItem i) => (i.Genre == genre)).Count() < 1)
                {
                    this.musicList.Genres.RemoveGenre(genre);
                }
            }
        }
    }
}
