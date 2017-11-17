using System;
using System.Reflection;

namespace ZwirCore.Utils.Extensions
{
    /// <summary>
    /// Extensions for enum
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        ///  Get value from enum attribute
        /// </summary>
        /// <typeparam name="TAttribute">The type of the attribute you want to retrieve</typeparam>
        /// <typeparam name="Expected"></typeparam>
        /// <param name="enumValue">The enum value</param>
        /// <param name="expression">Expression</param>
        /// <returns>Return value from enum attribute</returns>
        public static Expected GetAttributeValue<TAttribute, Expected>(this System.Enum enumValue, Func<TAttribute, Expected> expression)
            where TAttribute : Attribute
        {
            Type type = enumValue.GetType();
            MemberInfo[] memInfo = type.GetMember(enumValue.ToString());
            object[] attributes = memInfo[0].GetCustomAttributes(typeof(TAttribute), false);
            if (attributes.IsNullOrEmpty())
                throw new Exception("Attribute not found");

            return expression((TAttribute)attributes[0]);
        }


    }
}
