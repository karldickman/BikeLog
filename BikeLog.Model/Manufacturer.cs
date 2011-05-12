using System;

namespace BikeLog.Model
{
    /// <summary>
    /// A company that manufactures bicycles.
    /// </summary>
    public class Manufacturer
    {
        #region Properties

        #region Physical implementation

        private string _name;

        #endregion

        /// <summary>
        /// A number that identifies the manufacturer.
        /// </summary>
        public virtual int ID { get; set; }

        /// <summary>
        /// The name of the manufacturer.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// Thrown if assigned a <see langword="null" />.
        /// </exception>
        public virtual string Name
        {
            get { return _name; }

            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("value");
                }
                _name = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Construct a new <see cref="Manufacturer" />.
        /// </summary>
        /// <param name="id">
        /// A number that identifies the manufacturer.
        /// </param>
        /// <param name="name">
        /// The name of the manufacturer.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="name" /> is <see langword="null" />.
        /// </exception>
        public Manufacturer(int id, string name)
        {
            ID = id;
            Name = name;
        }

        /// <summary>
        /// Do not call this constructor!  It is to be used only by the
        /// lazy-loading library!
        /// </summary>
        protected Manufacturer()
        {
        }

        #endregion
    }
}

