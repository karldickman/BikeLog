using System;
using Gtk;
using BikeLog.Model;
using NHibernate.Tool.hbm2ddl;

namespace BikeLog
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main method for the application.
        /// </summary>
        /// <param name="args">
        /// The command-line arguments.
        /// </param>
        public static void Main(string[] args)
        {
            NHibernate.Cfg.Configuration configuration = new NHibernate.Cfg.Configuration();
            configuration.Configure();
            configuration.AddAssembly(typeof(Manufacturer).Assembly);
            new SchemaExport(configuration).Execute(true, false, true);
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}

