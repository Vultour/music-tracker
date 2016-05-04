using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using MusicTracker.Util;

namespace MusicTracker.Core
{
    public class MusicItem : MusicObjectBase, IXESerializable
    {
        public event EventHandler Deleting;

        private string title;
        private string artist;
        private int genre;
        private bool downloaded;


        public MusicList Parent { get; private set; }
        public string Title
        {
            get { return this.title; }
            set {
                if (this.title != value)
                {
                    this.title = value;
                    this.onChange();
                }
            }
        }

        public string Artist
        {
            get { return this.artist; }
            set {
                if (this.artist != value)
                {
                    this.artist = value;
                    this.onChange();
                }
            }
        }

        public int Genre
        {
            get { return this.genre; }
            set {
                if (this.genre != value)
                {
                    this.genre = value;
                    this.onChange();
                }
            }
        }

        public bool Downloaded
        {
            get { return this.downloaded; }
            set
            {
                if (this.downloaded != value)
                {
                    this.downloaded = value;
                    this.onChange();
                }
            }
        }

        public int ID { get; private set; }


        public MusicItem(MusicList parent, int id, string title, string artist, int genre, bool downloaded)
        {
            this.Parent = parent;
            this.ID = id;
            this.Title = title;
            this.Artist = artist;
            this.Genre = genre;
            this.Downloaded = downloaded;
        }


        public XElement SerializeXE()
        {
            return new XElement(
                "track",
                new XElement("title", this.Title),
                new XElement("artist", this.Artist),
                new XElement("genre", this.Genre),
                new XElement("downloaded", this.Downloaded)
            );
        }


        public void Detach()
        {
            this.onDeleting();
        }


        private void onDeleting() { this.Deleting?.Invoke(this, new EventArgs()); }
    }
}
