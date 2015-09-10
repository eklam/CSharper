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
        enum TestEnum { [System.ComponentModel.Description("C#")]CSharp = 1, Java = 2, Python,  [System.ComponentModel.Description("rb")] Ruby, PHP = 19, CoffeScript }

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

        [TestMethod]
        public void EnumToEnumerable()
        {
            var enumArr = EnumSharper.ToEnumerable<TestEnum>().ToArray();

            Assert.IsTrue(enumArr.Length == 6, "Some itens aren't in the array!");

            Assert.IsTrue(enumArr[0].Value == 1);
            Assert.IsTrue(enumArr[0].Name == "CSharp");
            Assert.IsTrue(enumArr[0].Description == "C#");

            Assert.IsTrue(enumArr[1].Value == 2);
            Assert.IsTrue(enumArr[1].Name == "Java");
            Assert.IsTrue(enumArr[1].Description == null);

            Assert.IsTrue(enumArr[2].Name == "Python");
            Assert.IsTrue(enumArr[2].Description == null);

            Assert.IsTrue(enumArr[3].Name == "Ruby");
            Assert.IsTrue(enumArr[3].Description == "rb");

            Assert.IsTrue(enumArr[4].Value == 19);
            Assert.IsTrue(enumArr[4].Name == "PHP");
            Assert.IsTrue(enumArr[4].Description == null);

            Assert.IsTrue(enumArr[5].Name == "CoffeScript");
            Assert.IsTrue(enumArr[5].Description == null);
        }
    }
}
