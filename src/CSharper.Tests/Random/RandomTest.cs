using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharper.Tests
{
    [TestClass]
    public class RandomTest
    {
        [TestMethod]
        public void ArrayRandomWithParams()
        {
            Random r = new Random(0);

            Assert.AreEqual(3, r.OneOf(1, 2, 3));
        }

        [TestMethod]
        public void ArrayRandomWithArray()
        {
            Random r = new Random(0);

            int[] arr = new int[] { 1, 2, 3, 4 };

            Assert.AreEqual(3, r.OneOf(arr));
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ArrayRandomWithNullArray()
        {
            Random r = new Random(0);

            int[] arr = null;

            var result = r.OneOf(arr);
        }

        [TestMethod]
        public void IEnumerableRandomWithIEnumerable()
        {
        }

        [TestMethod]
        public void ArrayRandomWithNullIEnumerable()
        {
        }

        [TestMethod]
        public void ArrayRandomWithEmptyIEnumerable()
        {
        }
    }
}