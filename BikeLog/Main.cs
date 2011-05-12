using System;
using BikeLog.Model;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace BikeLog
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Configuration configuration = new Configuration();
            configuration.Configure();
            configuration.AddAssembly(typeof(Manufacturer).Assembly);
            new SchemaExport(configuration).Execute(false, true, false);
        }
    }
}

