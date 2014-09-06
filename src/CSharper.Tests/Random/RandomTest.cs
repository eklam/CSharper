using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
            Random r = new Random(0);

            int[] arr = new int[] { 1, 2, 3, 4 };

            Assert.AreEqual(3, arr.Random(r));
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ArrayRandomWithNullIEnumerable()
        {
            Random r = new Random(0);

            int[] arr = null;

            Assert.AreEqual(3, arr.Random(r));
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ArrayRandomWithEmptyIEnumerable()
        {
            Random r = new Random(0);

            int[] arr = new int[] { };

            Assert.AreEqual(3, arr.Random(r));
        }

        [TestMethod]
        public void ShuffleArray()
        {
            Random r = new Random(0);

            int[] arr = new int[] { 1, 2, 3, 4 };

            Assert.IsFalse(Enumerable.SequenceEqual(arr, arr.Shuffle(r)));
        }

        [TestMethod]
        public void RandomShuffleArray()
        {
            Random r = new Random(0);

            int[] arr = new int[] { 1, 2, 3, 4 };

            Assert.IsFalse(Enumerable.SequenceEqual(arr, r.Shuffle(arr)));
        }

        [TestMethod]
        public void RandomShuffleParams()
        {
            Random r = new Random(0);

            int[] arr = new int[] { 1, 2, 3, 4 };

            Assert.IsFalse(Enumerable.SequenceEqual(arr, r.Shuffle(1, 2, 3, 4)));
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void RandomShuffleNullArray()
        {
            Random r = new Random(0);

            int[] arr = null;

            Assert.IsFalse(Enumerable.SequenceEqual(arr, r.Shuffle(arr)));
        }

        [TestMethod]
        public void ShuffleEmptyArray()
        {
            Random r = new Random(0);

            int[] arr = new int[] { };

            Assert.IsTrue(Enumerable.SequenceEqual(arr, arr.Shuffle(r)));
        }

        public void RandomShuffleParamsWithRegisteredRandom()
        {
            RandomSharper.RegisterRandom(() => new Random(0));

            int[] arr = new int[] { 1, 2, 3, 4 };

            Assert.IsFalse(Enumerable.SequenceEqual(arr, arr.Shuffle()));
        }

        [TestMethod]
        public void ArrayRandomWithArrayWithRegisteredRandom()
        {
            RandomSharper.RegisterRandom(() => new Random(0));

            int[] arr = new int[] { 1, 2, 3, 4 };

            Assert.AreEqual(3, arr.Random());
        }
    }
}