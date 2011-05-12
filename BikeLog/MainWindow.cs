using System;
using Gtk;

namespace BikeLog
{
    /// <summary>
    /// The main window for the application.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Construct a new <see cref="MainWindow" />.
        /// </summary>
        public MainWindow() : base(WindowType.Toplevel)
        {
            Build();
        }

        private void HandleDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }
    }
}
