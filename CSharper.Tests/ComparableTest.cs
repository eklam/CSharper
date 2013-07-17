using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharper.Tests
{
    [TestClass]
    public class ComparableTest
    {
        [TestMethod]
        public void BetweenWithinRange()
        {
            bool result = 3.Between(3, 7);

            Assert.AreEqual(result, true, "ComparableSharper.Between ain't working properly!");
        }

        [TestMethod]
        public void BetweenNotWithinRange()
        {
            bool result = 2.Between(3, 7);

            Assert.AreEqual(result, false, "ComparableSharper.Between ain't working properly!");
        }

        [TestMethod]
        public void BetweenWithinRangeUpperBound()
        {
            bool result = 6.Between(3, 7);

            Assert.AreEqual(result, true, "ComparableSharper.Between ain't working properly!");
        }

        [TestMethod]
        public void BetweenNotWithinUpperBound()
        {
            bool result = 7.Between(3, 7);

            Assert.AreEqual(result, false, "ComparableSharper.Between ain't working properly!");
        }
    }
}
