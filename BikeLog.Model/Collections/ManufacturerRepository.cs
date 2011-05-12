using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Linq;

namespace BikeLog.Model.Collections
{
    /// <summary>
    /// Persistence repository for <see cref="Manufacturer" />.
    /// </summary>
    public class ManufacturerRepository : IManufacturerRepository
    {
        #region IManufacturerRepository implementation

        #region IEnumerable[BikeLog.Model.Manufacturer] implementation

        #region IEnumerable implementation

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach(Manufacturer manufacturer in this)
            {
                yield return manufacturer;
            }
        }

        #endregion

        /// <inheritdoc />
        public IEnumerator<Manufacturer> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        /// <inheritdoc />
        public void Add(Manufacturer manufacturer)
        {
            using(ISession session = NHibernateHelper.OpenSession())
            {
                using(ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(manufacturer);
                    transaction.Commit();
                }
            }
        }

        /// <inheritdoc />
        public Manufacturer GetByName(string name)
        {
            using(ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Manufacturer>().SingleOrDefault(m => m.Name == name);
            }
        }

        /// <inheritdoc />
        public void Remove(Manufacturer manufacturer)
        {
            using(ISession session = NHibernateHelper.OpenSession())
            {
                using(ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(manufacturer);
                    transaction.Commit();
                }
            }
        }

        /// <inheritdoc />
        public void Update(Manufacturer manufacturer)
        {
            using(ISession session = NHibernateHelper.OpenSession())
            {
                using(ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(manufacturer);
                    transaction.Commit();
                }
            }
        }

        #endregion
    }
}

