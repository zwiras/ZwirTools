using System;
using System.Collections.Generic;
using System.Text;
using ZwirCore.Utils.Attributes;

namespace ZwirCore.Enums
{
    /// <summary>
    /// Class with all enums in library
    /// </summary>
    public class Enums
    {
        /// <summary>
        /// 
        /// </summary>
        public enum ResultEnum
        {
            Success,
            Error,
        }

        /// <summary>
        /// String value for MediaTypeWithQualityHeaderValue (WebApi)
        /// </summary>
        public enum MediaTypeEnum
        {
            [EnumValue("application/json")]
            ApplicationJson,

        }
    }
}
