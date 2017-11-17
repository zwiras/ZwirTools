using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZwirCore.Utils.Extensions
{
    /// <summary>
    /// Extensions for collection
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Return True if collection is null of empty
        /// </summary>
        /// <typeparam name="TSource">Element type from the collection</typeparam>
        /// <param name="source">Collection</param>
        /// <returns>True if collection is null of empty</returns>
        public static bool IsNullOrEmpty<TSource>(this IEnumerable<TSource> source)
        {
            return source == null || source.Count() == 0;
        }
    }
}
