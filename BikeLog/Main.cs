using System;
using BikeLog.Model;
using BikeLog.Model.Collections;
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
            IManufacturerRepository repository = new ManufacturerRepository();
            repository.Add(new Manufacturer(1, "Trek"));
        }
    }
}

