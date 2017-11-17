using System;
using System.Collections.Generic;
using System.Text;
using static ZwirCore.Enums.Enums;

namespace ZwirCore.Utils.Results
{
    /// <summary>
    /// Base class for return values
    /// </summary>
    /// <typeparam name="TObjectType">object type</typeparam>
    public class BaseResult<TObjectType> 
    {
        public string ErrorMessage { get; set; }
        public ResultEnum Result { get; set; }
        public TObjectType Value { get; set; }
    }
}
