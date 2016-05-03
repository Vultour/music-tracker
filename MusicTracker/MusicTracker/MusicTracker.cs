using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MusicTracker.GUI;


namespace MusicTracker
{
    internal class MusicTracker : ApplicationContext
    {
        private MainWindowController mainWindow;


        public MusicTracker()
        {
            this.mainWindow = new MainWindowController();
            this.MainForm = this.mainWindow.View;
            this.MainForm.Show();
        }
    }
}
