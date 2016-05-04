using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using MusicTracker.Util;

namespace MusicTracker.Core
{
    public class MusicGenres : MusicObjectBase, IXESerializable
    {
        private List<MusicGenre> genres;
        private int lastID = 0;


        public string[] Genres { get { return this.genres.Select((MusicGenre i) => i.Title).ToArray(); } }

        public int[] GenreIDs { get { return this.genres.Select((MusicGenre i) => i.ID).ToArray(); } }


        public MusicGenres()
        {
            this.lastID = 0;
            this.genres = new List<MusicGenre>();
            this.CreateGetGenre("???", 0);
        }


        public int CreateGetGenre(string title, int id)
        {
            int gID = this.GetGenre(title);
            string gTitle = this.GetGenre(id);

            if (gID != 0) { return gID; }
            if (gTitle != null) { return this.GetGenre(gTitle); }

            this.genres.Add(new MusicGenre(title, id));
            this.onChange();
            return this.lastID;
        }

        public int CreateGetGenre(string title)
        {
            return this.CreateGetGenre(title, ++this.lastID);
        }


        public void RemoveGenre(string title)
        {
            this.genres.RemoveAll((MusicGenre i) => (i.Title == title));
            this.onChange();
        }

        public void RemoveGenre(int id)
        {
            this.genres.RemoveAll((MusicGenre i) => (i.ID == id));
            this.onChange();
        }


        public int GetGenre(string title)
        {
            if (this.genres.Count < 1) { return 0; }
            MusicGenre tmp = this.genres.Find((MusicGenre i) => (i.Title == title));
            if (tmp != null) { return tmp.ID; }
            return 0;
        }

        public string GetGenre(int id)
        {
            if (this.genres.Count < 1) { return null; }
            return this.genres.Find((MusicGenre i) => (i.ID == id))?.Title;
        }


        public XElement SerializeXE()
        {
            XElement genres = new XElement("genres");
            foreach (MusicGenre g in this.genres) { genres.Add(g.SerializeXE()); }
            return genres;
        }
    }
}
