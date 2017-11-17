using System;
using System.Collections.Generic;
using System.Text;

namespace ZwirCore.Utils.Attributes
{
    /// <summary>
    /// String value for enum as attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class EnumValueAttribute : Attribute
    {

        private string value;
        public virtual string Value
        {
            get { return value; }
        }

        public EnumValueAttribute(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}