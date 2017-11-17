using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ZwirCore.Utils.Extensions;
using ZwirCore.Utils.Attributes;

namespace ZwirCore.Tests
{
    [TestClass]
    public class EnumExtensionsTests
    {
        public enum TestEnum
        {
            [System.ComponentModel.Description("Test 1")]
            [EnumValue("T1")]
            TestEnum1,
            [EnumValue("T2")]
            [System.ComponentModel.Description("Test 2")]
            TestEnum2,
        }


        [TestMethod]
        public void EnumValueAttributeTest()
        {
            string value = TestEnum.TestEnum1.GetAttributeValue<System.ComponentModel.DescriptionAttribute, string>(x => x.Description);
            Assert.AreEqual("Test 1", value);
            value = TestEnum.TestEnum2.GetAttributeValue<System.ComponentModel.DescriptionAttribute, string>(x => x.Description);
            Assert.AreEqual("Test 2", value);
            value = TestEnum.TestEnum1.GetAttributeValue<EnumValueAttribute, string>(x => x.Value);
            Assert.AreEqual("T1", value);
            value = TestEnum.TestEnum2.GetAttributeValue<EnumValueAttribute, string>(x => x.Value);
            Assert.AreEqual("T2", value);
        }
    }
}
