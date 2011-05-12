using System;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace BikeLog.Model.Tests
{
    [TestFixture]
    public sealed class GenerateSchemaFixture
    {
        #region Tests

        [Test]
        public void SchemaGeneration()
        {
            Configuration configuration = new Configuration();
            configuration.Configure();
            configuration.AddAssembly(typeof(Manufacturer).Assembly);
            new SchemaExport(configuration).Execute(false, true, false);
        }

        #endregion
    }
}

