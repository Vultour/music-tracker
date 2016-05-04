using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MusicTracker.Core;


namespace MusicTracker.GUI
{
    public partial class MainWindow : Form
    {
        internal event EventHandler<AddTrackEventArgs>      TrackAdded;
        internal event EventHandler<SelectTrackEventArgs>   TrackSelected;
        internal event EventHandler<TrackEventArgs>         TrackMarked;
        internal event EventHandler<SaveTrackEventArgs>     TrackSaved;
        internal event EventHandler<TrackEventArgs>         TrackDeleted;
        internal event EventHandler                         GenresCleaned;


        public MainWindow()
        {
            InitializeComponent();
            this.lblVersion.Text = String.Format(
                "Version {0}",
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
            );

            this.ResetEdit();
            this.ResetAdd();

            this.SetEditState(false);
            this.SetAddState(true);
        }


        public void AddTrack(MusicItem track)
        {
            MusicTrackerListViewItem tmp = new MusicTrackerListViewItem(this.lvMain, track);
            tmp.Deleting += this.ListViewItem_Deleting;
            this.lvMain.Items.Add(tmp);
        }

        public void BeginEditTrack(MusicItem track)
        {
            this.tbEditTitle.Text = track.Title;
            this.tbEditArtist.Text = track.Artist;
            this.cbEditGenre.Text = track.Parent.Genres.GetGenre(track.Genre);
            this.SetEditState(true);
            this.tpEdit.Select();
        }


        public void UpdateGenres(string[] genres)
        {
            this.cbAddGenre.Items.Clear();
            this.cbAddGenre.Items.AddRange(genres);

            this.cbEditGenre.Items.Clear();
            this.cbEditGenre.Items.AddRange(genres);
        }


        public void SetWelcomeState(bool enabled)
        {
            foreach (Control control in this.tpWelcome.Controls) { control.Enabled = enabled; }
        }

        public void SetEditState(bool enabled)
        {
            foreach (Control control in this.tpEdit.Controls) { control.Enabled = enabled; }
        }

        public void SetAddState(bool enabled)
        {
            foreach (Control control in this.tpAdd.Controls) { control.Enabled = enabled; }
        }


        public void ResetEdit()
        {
            this.tbEditTitle.Text = "";
            this.tbEditArtist.Text = "";
            this.cbEditGenre.Text = "";
        }

        public void ResetAdd()
        {
            this.tbAddTitle.Text = "";
            this.tbAddArtist.Text = "";
            this.cbAddGenre.Text = "";
        }


        private void AddTrack_Click(object sender, EventArgs e)
        {
            if (!(sender is Button)) { return; }
            if ((this.tbAddTitle.Text == "") || (this.tbAddArtist.Text == ""))
            {
                MessageBox.Show("Some fields are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Button tmp = (Button)sender;
            this.onTrackAdded(
                this.tbAddTitle.Text,
                this.tbAddArtist.Text,
                this.cbAddGenre.Text,
                (tmp.Name == "btnAddDownloaded") ? (true) : (false)
            );
        }

        private void MarkTrack_Click(object sender, EventArgs e)
        {

        }

        private void SaveTrack_Click(object sender, EventArgs e)
        {
            if (!(sender is Button)) { return; }
            if ((this.tbEditTitle.Text == "") || (this.tbEditArtist.Text == ""))
            {
                MessageBox.Show("Some fields are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.lvMain.SelectedItems.Count < 1) { return; }

            this.onTrackSaved(
                (MusicItem)this.lvMain.SelectedItems[0].Tag,
                this.tbEditTitle.Text,
                this.tbEditArtist.Text,
                this.cbEditGenre.Text,
                ((MusicItem)this.lvMain.SelectedItems[0].Tag).Downloaded
            );

            this.lvMain.SelectedIndices.Clear();

        }

        private void DeleteTrack_Click(object sender, EventArgs e)
        {

        }

        private void CleanGenres_Click(object sender, EventArgs e)
        {
            this.onGenresCleaned();
        }

        private void ListViewItem_Deleting(object sender, EventArgs e)
        {
            if (!(sender is MusicTrackerListViewItem)) { return; }
            MusicTrackerListViewItem tmp = (MusicTrackerListViewItem)sender;
            tmp.Dispose();
            this.lvMain.Items.Remove(tmp);
        }

        private void ListView_Click(object sender, EventArgs e)
        {
            if (this.lvMain.SelectedItems.Count < 1)
            {
                this.SetEditState(false);
                return;
            }
            if (!(this.lvMain.SelectedItems[0] is MusicTrackerListViewItem))
            {
                this.SetEditState(false);
                return;
            }
            this.onTrackSelected(((MusicTrackerListViewItem)this.lvMain.SelectedItems[0]).Track);
        }
        
        
        private void onTrackAdded(string title, string artist, string genre, bool downloaded)
        {
            this.TrackAdded?.Invoke(this, new AddTrackEventArgs(title, artist, genre, downloaded));
        }

        private void onTrackSelected(MusicItem track)
        {
            this.TrackSelected?.Invoke(this, new SelectTrackEventArgs(track));
        }

        private void onTrackSaved(MusicItem oldTrack, string newTitle, string newArtist, string newGenre, bool newDownloaded)
        {
            this.TrackSaved?.Invoke(this, new SaveTrackEventArgs(oldTrack, newTitle, newArtist, newGenre, newDownloaded));
        }

        private void onGenresCleaned()
        {
            this.GenresCleaned?.Invoke(this, new EventArgs());
        }
    }
}
