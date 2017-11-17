using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ZwirCore.Utils.Extensions;

namespace ZwirCore.Tests.Utils.Extensions
{
    [TestClass]
    public class CollectionExtensionsTests
    {
        [TestMethod]
        public void IsNullOrEmptyTest()
        {
            IList<int> list = null;

            bool value = list.IsNullOrEmpty();
            Assert.IsTrue(value);

            list = new List<int>();
            value = list.IsNullOrEmpty();
            Assert.IsTrue(value);

            list.Add(1);
            value = list.IsNullOrEmpty();
            Assert.IsFalse(value);

            list.Clear();
            value = list.IsNullOrEmpty();
            Assert.IsTrue(value);
        }
    }
}
