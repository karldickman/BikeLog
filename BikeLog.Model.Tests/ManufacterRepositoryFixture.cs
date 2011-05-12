using System;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using BikeLog.Model.Collections;

namespace BikeLog.Model.Tests
{
    [TestFixture]
    public sealed class ManufacterRepositoryFixture
    {
        #region Properties

        private ISessionFactory SessionFactory { get; set; }

        private Configuration Configuration { get; set; }

        #endregion

        #region Setup

        [TestFixtureSetUp]
        public void SetUpFixture()
        {
            Configuration = new Configuration();
            Configuration.Configure();
            Configuration.AddAssembly(typeof(Manufacturer).Assembly);
            SessionFactory = Configuration.BuildSessionFactory();
        }

        [SetUp]
        public void SetUp()
        {
            new SchemaExport(Configuration).Execute(false, true, false);
        }

        #endregion

        #region Tests

        [Test]
        public void AddNew()
        {
            Manufacturer manufacturer = new Manufacturer(1, "Trek");
            IManufacturerRepository repository = new ManufacturerRepository();
            repository.Add(manufacturer);
        }

        [Test]
        public void GetByName()
        {
            Manufacturer trek = new Manufacturer(1, "Trek");
            Manufacturer specialized = new Manufacturer(2, "Specialized");
            Manufacturer cannondale = new Manufacturer(3, "Cannondale");
            IManufacturerRepository repository = new ManufacturerRepository();
            repository.Add(trek);
            repository.Add(specialized);
            repository.Add(cannondale);
            Manufacturer actual = repository.GetByName("specialized");
            Assert.IsNotNull(actual);
            Assert.AreNotSame(specialized, actual);
            Assert.AreEqual(specialized.ID, actual.ID);
        }

        [Test]
        public void RemoveExisting()
        {
            Manufacturer manufacturer = new Manufacturer(1, "Trek");
            IManufacturerRepository repository = new ManufacturerRepository();
            repository.Add(manufacturer);
            using(ISession session = SessionFactory.OpenSession())
            {
                Assert.IsNotNull(session.Get<Manufacturer>(manufacturer.ID));
            }
            repository.Remove(manufacturer);
            using(ISession session = SessionFactory.OpenSession())
            {
                Assert.IsNull(session.Get<Manufacturer>(manufacturer.ID));
            }
        }

        [Test]
        public void UpdateExisting()
        {
            Manufacturer expected = new Manufacturer(1, "Trek");
            IManufacturerRepository repository = new ManufacturerRepository();
            repository.Add(expected);
            expected.Name = "Specialized";
            repository.Update(expected);
            using(ISession session = SessionFactory.OpenSession())
            {
                Manufacturer actual = session.Get<Manufacturer>(expected.ID);
                Assert.AreEqual(expected.Name, actual.Name);
            }
        }

        #endregion
    }
}

