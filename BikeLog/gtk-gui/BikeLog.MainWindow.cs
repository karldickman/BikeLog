#pragma warning disable 1591
// This file has been generated by the GUI designer. Do not modify.
namespace BikeLog
{
    public partial class MainWindow
    {
        protected virtual void Build()
        {
            global::Stetic.Gui.Initialize(this);
            // Widget BikeLog.MainWindow
            this.Name = "BikeLog.MainWindow";
            this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
            this.WindowPosition = ((global::Gtk.WindowPosition)(4));
            if((this.Child != null))
            {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 300;
            this.Show();
            this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.HandleDeleteEvent);
        }
    }
}
#pragma warning restore 1591