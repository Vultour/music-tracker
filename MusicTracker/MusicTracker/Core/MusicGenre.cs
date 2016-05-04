using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using MusicTracker.Util;

namespace MusicTracker.Core
{
    internal class MusicGenre : IXESerializable
    {
        public string Title { get; private set; }

        public int ID { get; private set; }


        public MusicGenre(string title, int id)
        {
            this.ID = id;
            this.Title = title;
        }

        public MusicGenre(string title) : this(title, new Random().Next()) { }


        public XElement SerializeXE()
        {
            return new XElement(
                "genre",
                new XElement("id", this.ID),
                new XElement("title", this.Title)
            );
        }
    }
}
