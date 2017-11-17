using System;

namespace ZwirCore.DataObjects
{
    /// <summary>
    /// Base class for DataObject
    /// </summary>
    /// <typeparam name="TIdType">Type of identifier</typeparam>
    public class ZwirBaseDo<TIdType>
    {
        private TIdType id;
        /// <summary>
        /// Identifier
        /// </summary>
        public TIdType Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
