using System;
using System.Collections.Generic;
using System.Text;

namespace ZwirCore.Utils.Extensions
{
    /// <summary>
    /// Extensions for stringss
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Method check that string is null or empty
        /// </summary>
        /// <param name="text">Value</param>
        /// <returns>Return true if string null or empty</returns>
        public static bool IsNullOrEmpty(this string text)
        {
            if (text == null)
                return true;
            if (text == "")
                return true;

            return false;
        }

        /// <summary>
        /// Method trim string and check that string is null or empty
        /// </summary>
        /// <param name="text">Value</param>
        /// <returns>Return true if string null or empty</returns>
        public static bool IsNullOrEmptyWithTrimm(this string text)
        {
            if (text == null)
                return true;
            if (text.Trim() == "")
                return true;

            return false;
        }
    }
}
