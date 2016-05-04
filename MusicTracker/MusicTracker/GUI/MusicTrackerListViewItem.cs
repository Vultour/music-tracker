using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MusicTracker.Core;

namespace MusicTracker.GUI
{
    class MusicTrackerListViewItem : ListViewItem
    {
        public event EventHandler Deleting;


        public MusicItem Track { get; private set; }

        public Control Parent { get; private set; }


        public MusicTrackerListViewItem(Control parent, MusicItem track) : base()
        {
            this.Parent = parent;

            this.Track = track;
            this.Track.Change += this.Track_Change;

            this.Group = (track.Downloaded) ? (((ListView)this.Parent).Groups["lvgDownloaded"]) : (((ListView)this.Parent).Groups["lvgNotDownloaded"]);
            this.Text = track.Title;
            this.SubItems.AddRange(new[] { track.Artist, track.Parent.Genres.GetGenre(track.Genre) });
        }


        private void Track_Change(object sender, EventArgs e)
        {
            if (!(sender is MusicItem)) { return; }
            MusicItem tmp = (MusicItem)sender;
            this.Group = (tmp.Downloaded) ? (((ListView)this.Parent).Groups["lvgDownloaded"]) : (((ListView)this.Parent).Groups["lvgNotDownloaded"]);
            this.Text = tmp.Title;
            this.SubItems.Clear();
            this.SubItems.AddRange(new[] { tmp.Artist, tmp.Parent.Genres.GetGenre(tmp.Genre) });
        }

        private void Track_Deleting(object sender, EventArgs e)
        {
            if (!(sender is MusicItem)) { return; }
            this.onDeleting();
        }


        public void Dispose()
        {
            this.Track.Change -= this.Track_Change;
        }


        private void onDeleting() { this.Deleting?.Invoke(this, new EventArgs()); }
    }
}
