using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTracker.Core
{
    public class MusicGenres
    {
        private List<MusicGenre> genres;


        public MusicGenres() { this.genres = new List<MusicGenre>(); }


        public Guid CreateGenre(string title, Guid guid)
        {
            Guid gg = this.GetGenre(title);
            string gt = this.GetGenre(guid);

            if (gg != null) { return gg; }
            if (gt != null) { return this.GetGenre(gt); }

            MusicGenre tmp = new MusicGenre(title, guid);
            this.genres.Add(tmp);
            return tmp.GUID;
        }


        public void RemoveGenre(string title)
        {
            this.genres.RemoveAll((MusicGenre i) => (i.Title == title));
        }

        public void RemoveGenre(Guid guid)
        {
            this.genres.RemoveAll((MusicGenre i) => (i.GUID == guid));
        }


        public Guid GetGenre(string title)
        {
            return this.genres.Find((MusicGenre i) => (i.Title == title)).GUID;
        }

        public string GetGenre(Guid guid)
        {
            return this.genres.Find((MusicGenre i) => (i.GUID == guid)).Title;
        }
    }
}
