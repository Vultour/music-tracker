using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTracker.Core
{
    public class MusicList
    {
        public List<MusicItem> Downloaded { get; private set; }
        public List<MusicItem> NotDownloaded { get; private set; }


        public MusicList()
        {
            this.Downloaded = new List<MusicItem>();
            this.NotDownloaded = new List<MusicItem>();
        }


        public void AddDownloaded(string title, string artist, string genre)
        {
            this.Downloaded.Add(new MusicItem(title, artist, genre));
        }

        public void AddNotDownloaded(string title, string artist, string genre)
        {

            this.NotDownloaded.Add(new MusicItem(title, artist, genre));
        }
    }
}
