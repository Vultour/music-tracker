using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTracker.Core
{
    public class MusicItem
    {
        public string Title { get; set; }

        public string Artist { get; set; }

        public Guid Genre { get; set; }


        public MusicItem(string title, string artist, Guid genre)
        {
            this.Title = title;
            this.Artist = artist;
            this.Genre = genre;
        }
    }
}
