using System;
using System.Collections.Generic;

namespace BikeLog.Model.Collections
{
    /// <summary>
    /// Interface that repositories for <see cref="Manufacturer" /> must implement.
    /// </summary>
    public interface IManufacturerRepository : IEnumerable<Manufacturer>
    {
        /// <summary>
        /// Add a <see cref="Manufacturer" /> to the repository.
        /// </summary>
        /// <param name="manufacturer">
        /// The <see cref="Manufacturer"/> to add.
        /// </param>
        void Add(Manufacturer manufacturer);

        /// <summary>
        /// Get the manufacturer with a given name.
        /// </summary>
        /// <param name="name">
        /// The name of the manufacturer to search for.
        /// </param>
        /// <returns>
        /// The <see cref="Manufacturer"/> with the given name.
        /// </returns>
        Manufacturer GetByName(string name);

        /// <summary>
        /// Remove a <see cref="Manufacturer" /> from the repository.
        /// </summary>
        /// <param name="manufacturer">
        /// The <see cref="Manufacturer"/> to remove.
        /// </param>
        void Remove(Manufacturer manufacturer);

        /// <summary>
        /// Update a <see cref="Manufacturer" /> in the repository.
        /// </summary>
        /// <param name="manufacturer">
        /// The <see cref="Manufacturer"/> to update.
        /// </param>
        void Update(Manufacturer manufacturer);
    }
}

