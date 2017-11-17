using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZwirCore.Utils.Extensions;

namespace ZwirCore.Tests.Utils.Extensions
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void IsNullOrEmptyTest()
        {
            string obj1 = null;

            bool value = obj1.IsNullOrEmpty();
            Assert.IsTrue(value);

            obj1 = "";
            value = obj1.IsNullOrEmpty();
            Assert.IsTrue(value);

            obj1 = "test";
            value = obj1.IsNullOrEmpty();
            Assert.IsFalse(value);
        }

        [TestMethod]
        public void IsNullOrEmptyWithTrimmTest()
        {
            string obj1 = null;

            bool value = obj1.IsNullOrEmptyWithTrimm();
            Assert.IsTrue(value);

            obj1 = "";
            value = obj1.IsNullOrEmptyWithTrimm();
            Assert.IsTrue(value);

            obj1 = "test";
            value = obj1.IsNullOrEmptyWithTrimm();
            Assert.IsFalse(value);

            obj1 = "   ";
            value = obj1.IsNullOrEmptyWithTrimm();
            Assert.IsTrue(value);

        }
    }
}
