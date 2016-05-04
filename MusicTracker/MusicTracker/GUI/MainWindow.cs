using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicTracker.GUI
{
    public partial class MainWindow : Form
    {
        internal event EventHandler<AddTrackEventArgs>      DownloadedTrackAdded;
        internal event EventHandler<AddTrackEventArgs>      NotDownloadedTrackAdded;
        internal event EventHandler<SelectTrackEventArgs>   TrackSelected;
        internal event EventHandler<SaveTrackEventArgs>     TrackSaved;
        internal event EventHandler                         GenresCleaned;


        public MainWindow()
        {
            InitializeComponent();
            this.lblVersion.Text = String.Format(
                "Version {0}",
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
            );
        }
    }
}
