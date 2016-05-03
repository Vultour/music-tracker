using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTracker.Core
{
    internal class MusicGenre
    {
        public string Title { get; private set; }

        public Guid GUID { get; private set; }


        public MusicGenre(string title, Guid guid)
        {
            this.GUID = guid;
            this.Title = title;
        }

        public MusicGenre(string title) : this(title, new Guid()) { }
    }
}
