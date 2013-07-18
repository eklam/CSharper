using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharper.Tests
{
    [TestClass]
    public class IEnumerableTest
    {
        [TestMethod]
        public void SafeWithNullList()
        {
            List<int> lstInts = null;

            int count = lstInts.Safe().Count();

            Assert.AreEqual(count, 0, "Safe ain't working properly");
        }

        [TestMethod]
        public void SafeWithFilledList()
        {
            List<int> lstInts = new List<int>();

            lstInts.Add(1);
            lstInts.Add(2);
            lstInts.Add(3);

            int count = lstInts.Safe().Count();

            Assert.AreEqual(count, 3, "Safe ain't working properly");
        }

        [TestMethod]
        public void IsEmptyWithNullList()
        {
            List<int> lstInts = null;

            bool isEmpty = lstInts.IsEmpty();

            Assert.AreEqual(isEmpty, true, "IsEmpty ain't working properly");
        }

        [TestMethod]
        public void IsEmptyWithEmptyList()
        {
            List<int> lstInts = new List<int>();

            bool isEmpty = lstInts.IsEmpty();

            Assert.AreEqual(isEmpty, true, "IsEmpty ain't working properly");
        }

        [TestMethod]
        public void IsEmptyWithFilledList()
        {
            List<int> lstInts = new List<int>();

            lstInts.Add(1);
            lstInts.Add(2);
            lstInts.Add(3);

            bool isEmpty = lstInts.IsEmpty();

            Assert.AreEqual(isEmpty, false, "IsEmpty ain't working properly");
        }

        [TestMethod]
        public void SafeForEachWithNullList()
        {
            List<int> lstInts = null;

            int sum = 0;

            lstInts.SafeForEach((item) =>
            {
                sum += item;
            });

            Assert.AreEqual(sum, 0, "SafeForEach ain't working properly");
        }

        [TestMethod]
        public void SafeForEachWithEmptyList()
        {
            List<int> lstInts = new List<int>();

            int sum = 0;

            lstInts.SafeForEach((item) =>
            {
                sum += item;
            });

            Assert.AreEqual(sum, 0, "SafeForEach ain't working properly");
        }

        [TestMethod]
        public void SafeForEachWithFilledList()
        {
            List<int> lstInts = new List<int>();

            lstInts.Add(1);
            lstInts.Add(2);
            lstInts.Add(3);

            int sum = 0;

            lstInts.SafeForEach((item) =>
            {
                sum += item;
            });

            Assert.AreEqual(sum, 6, "SafeForEach ain't working properly");
        }
    }
}
