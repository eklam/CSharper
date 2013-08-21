using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CSharper.Tests
{
    [TestClass]
    public class ObjectTest
    {
        string Property1 { get; set; }
        int Property2 { get; set; }
        private string Property3 { get; set; }
        protected string Property4 { get; set; }
        public string Property5 { get; set; }

        string _property1;
        int _property2;
        private string _property3;
        protected string _property4;
        public string _property5;

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

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void InWithNullList()
        {
            List<string> lst = null;

            bool result = "aaa".In(lst);
        }

        [TestMethod]
        public void PropertyNameWith_property1()
        {
            ObjectTest t = new ObjectTest();

            var result = t.PropertyName(x => x._property1);

            Assert.AreEqual(result, "_property1", "It aint working properly");
        }

        [TestMethod]
        public void PropertyNameWith_property2()
        {
            ObjectTest t = new ObjectTest();

            var result = t.PropertyName(x => x._property2);

            Assert.AreEqual(result, "_property2", "It aint working properly");
        }

        [TestMethod]
        public void PropertyNameWith_property3()
        {
            ObjectTest t = new ObjectTest();

            var result = t.PropertyName(x => x._property3);

            Assert.AreEqual(result, "_property3", "It aint working properly");
        }

        [TestMethod]
        public void PropertyNameWith_property4()
        {
            ObjectTest t = new ObjectTest();

            var result = t.PropertyName(x => x._property4);

            Assert.AreEqual(result, "_property4", "It aint working properly");
        }

        [TestMethod]
        public void PropertyNameWith_property5()
        {
            ObjectTest t = new ObjectTest();

            var result = t.PropertyName(x => x._property5);

            Assert.AreEqual(result, "_property5", "It aint working properly");
        }

        [TestMethod]
        public void PropertyNameWithProperty1()
        {
            ObjectTest t = new ObjectTest();

            var result = t.PropertyName(x => x.Property1);

            Assert.AreEqual(result, "Property1", "It aint working properly");
        }

        [TestMethod]
        public void PropertyNameWithProperty2()
        {
            ObjectTest t = new ObjectTest();

            var result = t.PropertyName(x => x.Property2);

            Assert.AreEqual(result, "Property2", "It aint working properly");
        }

        [TestMethod]
        public void PropertyNameWithProperty3()
        {
            ObjectTest t = new ObjectTest();

            var result = t.PropertyName(x => x.Property3);

            Assert.AreEqual(result, "Property3", "It aint working properly");
        }

        [TestMethod]
        public void PropertyNameWithProperty4()
        {
            ObjectTest t = new ObjectTest();

            var result = t.PropertyName(x => x.Property4);

            Assert.AreEqual(result, "Property4", "It aint working properly");
        }

        [TestMethod]
        public void PropertyNameWithProperty5()
        {
            ObjectTest t = new ObjectTest();

            var result = t.PropertyName(x => x.Property5);

            Assert.AreEqual(result, "Property5", "It aint working properly");
        }
    }
}