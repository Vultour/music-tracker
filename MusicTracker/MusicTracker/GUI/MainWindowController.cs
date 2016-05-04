using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using MusicTracker.Core;


namespace MusicTracker.GUI
{
    class MainWindowController
    {
        private MusicList musicList;


        public MainWindow View { get; private set; }


        public MainWindowController()
        {
            this.musicList = new MusicList();
            this.View = new MainWindow();
        }


        private void loadPrevious()
        {
            if (!Directory.Exists(Properties.Resources.SAVE_FILE_PATH)) { Directory.CreateDirectory(Properties.Resources.SAVE_FILE_PATH); }
            if (!File.Exists(String.Format("{0}\\{1}", Properties.Resources.SAVE_FILE_PATH, Properties.Resources.SAVE_FILE_NAME)))
            {
                this.musicList
            }
        }


        // TODO: Add event handlers
    }
}
