using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CSharper.Tests
{
    [TestClass]
    public class ObjectTest
    {
        [TestMethod]
        public void InWithContainedValue()
        {
            int reallyLongIntegerVariableName = 1;
            bool result = reallyLongIntegerVariableName.In(1, 6, 9, 11);

            Assert.AreEqual(result, true, "In ain't working properly");
        }

        [TestMethod]
        public void InWithUncontainedValue()
        {
            int reallyLongIntegerVariableName = 12;
            bool result = reallyLongIntegerVariableName.In(1, 6, 9, 11);

            Assert.AreEqual(result, false, "In ain't working properly");
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void InWithNullSource()
        {
            int reallyLongIntegerVariableName = 12;
            int[] source = null;
            bool result = reallyLongIntegerVariableName.In(source);
        }

        [TestMethod]
        public void InWithContainedValueList()
        {
            List<string> lst = new List<string>();
            lst.Add("aaa");
            lst.Add("bbb");
            lst.Add("ccc");

            bool result = "aaa".In(lst);

            Assert.AreEqual(result, true, "In ain't working properly");  
        }
    }
}