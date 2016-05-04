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
        public string Title { get; set; }

        public string Artist { get; set; }

        public int Genre { get; set; }

        public int ID { get; private set; }


        public MusicItem(int id, string title, string artist, int genre)
        {
            this.ID = id;
            this.Title = title;
            this.Artist = artist;
            this.Genre = genre;
        }


        public XElement SerializeXE()
        {
            return new XElement(
                "track",
                new XElement("title", this.Title),
                new XElement("artist", this.Artist),
                new XElement("genre", this.Genre)
            );
        }
    }
}
