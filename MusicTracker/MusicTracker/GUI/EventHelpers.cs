using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicTracker.Core;


namespace MusicTracker.GUI
{
    internal class AddTrackEventArgs : EventArgs
    {
        public string Title { get; private set; }

        public string Artist { get; private set; }

        public string Genre { get; private set; }


        public AddTrackEventArgs(string title, string artist, string genre)
        {
            this.Title = title;
            this.Artist = artist;
            this.Genre = genre;
        }
    }


    internal class SelectTrackEventArgs : EventArgs
    {
        public MusicItem Track { get; private set; }


        public SelectTrackEventArgs(MusicItem track) { this.Track = track; }
    }


    internal class SaveTrackEventArgs : EventArgs
    {
        public MusicItem OldTrack { get; private set; }

        public string NewTitle { get; private set; }

        public string NewArtist { get; private set; }

        public string NewGenre { get; private set; }


        public SaveTrackEventArgs(MusicItem oldTrack, string newTitle, string newArtist, string newGenre)
        {
            this.OldTrack = oldTrack;
            this.NewTitle = newTitle;
            this.NewArtist = newArtist;
            this.NewGenre = newGenre;
        }
    }
}
