using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharper.Tests
{
    [TestClass]
    public class EnumTest
    {
        enum TestEnum { CSharp, Java, Python, Ruby, PHP }

        [TestMethod]
        public void EnumParseWithCorrectValue()
        {
            TestEnum foo = "Java".EnumParse<TestEnum>();

            Assert.AreEqual(foo, TestEnum.Java, "EnumSharper.EnumParse ain't working properly!");
        }

        [TestMethod]
        public void EnumParseWithImproperCaseValue()
        {
            try
            {
                TestEnum foo = "java".EnumParse<TestEnum>();
                Assert.IsTrue(false, "EnumSharper.EnumParse ain't working properly!");
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void EnumParseWithCasedValue()
        {
            try
            {
                TestEnum foo = "Java".EnumParse<TestEnum>(true);
                Assert.AreEqual(foo, TestEnum.Java, "EnumSharper.EnumParse ain't working properly!");
            }
            catch
            {
                Assert.IsTrue(false, "EnumSharper.EnumParse ain't working properly!");
            }
        }

        [TestMethod]
        public void EnumParseWithInorrectValue()
        {
            try
            {
                TestEnum foo = "Erlang".EnumParse<TestEnum>();
                Assert.IsTrue(false, "EnumSharper.EnumParse ain't working properly!"); 
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
    }
}
