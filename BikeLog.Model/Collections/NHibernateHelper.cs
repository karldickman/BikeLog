using System;
using NHibernate;
using NHibernate.Cfg;

namespace BikeLog.Model.Collections
{
    /// <summary>
    /// Helper class that provides NHibrnate <see cref="ISession" /> objects
    /// on demand.
    /// </summary>
    public static class NHibernateHelper
    {
        private static readonly ISessionFactory SessionFactory;

        static NHibernateHelper()
        {
            Configuration configuration = new Configuration();
            configuration.Configure();
            configuration.AddAssembly(typeof(Manufacturer).Assembly);
            SessionFactory = configuration.BuildSessionFactory();
        }

        /// <summary>
        /// Generate a new <see cref="ISession" />.
        /// </summary>
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}

