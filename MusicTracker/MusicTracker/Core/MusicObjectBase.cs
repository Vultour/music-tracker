using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace MusicTracker.Core
{
    public abstract class MusicObjectBase
    {
        public delegate void MusicObjectChanged(MusicObjectBase sender);
        public event MusicObjectChanged Change;

        protected void onChange(MusicObjectBase sender) { this.Change?.Invoke((sender == null) ? (this) : (sender)); }
        protected void onChange() { this.onChange(null); }
        protected virtual void childChangedHandler(MusicObjectBase sender) { this.onChange(sender); }
    }
}
