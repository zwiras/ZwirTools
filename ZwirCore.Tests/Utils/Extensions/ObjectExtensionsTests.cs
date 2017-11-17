using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZwirCore.Utils.Extensions;

namespace ZwirCore.Tests.Utils.Extensions
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void NotNullTest()
        {
            string obj1 = "test";

            obj1.NotNull(obj1.GetType().Name);
        }

        [TestMethod]
        public void IsNotNullTest()
        {
            object obj1 = null;

            bool value = obj1.IsNotNull();

            Assert.IsFalse(value);

            obj1 = "test";
            value = obj1.IsNotNull();
            Assert.IsTrue(value);
        }
    }
}
