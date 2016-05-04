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
        public event EventHandler Change;

        protected void onChange(object sender) { this.Change?.Invoke((sender == null) ? (this) : (sender), new EventArgs()); }
        protected void onChange() { this.onChange(this); }
        protected virtual void childChangedHandler(object sender, EventArgs e) { this.onChange(sender); }
    }
}
