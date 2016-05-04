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


        public List<string> Genres { get { return this.genres.Select((MusicGenre i) => i.Title).ToList(); } }


        public MusicGenres()
        {
            this.lastID = 0;
            this.genres = new List<MusicGenre>();
            this.CreateGenre("???", 0);
        }


        public int CreateGenre(string title, int id)
        {
            int gID = this.GetGenre(title);
            string gTitle = this.GetGenre(id);

            if (gID != 0) { return gID; }
            if (gTitle != null) { return this.GetGenre(gTitle); }

            this.genres.Add(new MusicGenre(title, id));
            return this.lastID;
        }

        public int CreateGenre(string title)
        {
            return this.CreateGenre(title, ++this.lastID);
        }


        public void RemoveGenre(string title)
        {
            this.genres.RemoveAll((MusicGenre i) => (i.Title == title));
        }

        public void RemoveGenre(int id)
        {
            this.genres.RemoveAll((MusicGenre i) => (i.ID == id));
        }


        public int GetGenre(string title)
        {
            return this.genres.Find((MusicGenre i) => (i.Title == title)).ID;
        }

        public string GetGenre(int id)
        {
            return this.genres.Find((MusicGenre i) => (i.ID == id)).Title;
        }


        public int CreateGetGenre(string title)
        {
            int gID = this.GetGenre(title);
            if (gID != 0) { return gID; }
            return this.CreateGenre(title);
        }


        public XElement SerializeXE()
        {
            XElement genres = new XElement("genres");
            foreach (MusicGenre g in this.genres) { genres.Add(g.SerializeXE()); }
            return genres;
        }
    }
}
