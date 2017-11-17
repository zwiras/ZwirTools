using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ZwirCore.Utils.Extensions
{
    /// <summary>
    /// Extensions for all objects
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// If null then exception
        /// </summary>
        /// <param name="obj">Object</param>
        /// <param name="objectType">Type object as string</param>
        public static void NotNull(this object obj, string objectType)
        {
            if (obj == null)
                throw new ArgumentNullException(objectType);
        }

        /// <summary>
        /// Method check that object is null
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Return true if object is not null or flase if null</returns>
        public static bool IsNotNull(this object obj)
        {
            return obj == null ? false : true;
        }

    }
}
