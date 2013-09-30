using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharper.Tests.IDictionary
{
    [TestClass]
    public class IDictionaryTest
    {
        [TestMethod]
        public void GetValueOrDefaultValidKey()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            dict.Add(1, 1);
            dict.Add(2, 2);
            dict.Add(3, 3);

            Assert.AreEqual(1, dict.GetValueOrDefault(1), "IDictionarySharper ain't working properly!");
        }

        [TestMethod]
        public void GetValueOrDefaultValidKey2()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            dict.Add(1, 1);
            dict.Add(2, 2);
            dict.Add(3, 3);

            Assert.AreEqual(2, dict.GetValueOrDefault(2), "IDictionarySharper ain't working properly!");
        }

        [TestMethod]
        public void GetValueOrDefaultInvalidKey()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            dict.Add(1, 1);
            dict.Add(2, 2);
            dict.Add(3, 3);

            Assert.AreEqual(0, dict.GetValueOrDefault(4), "IDictionarySharper ain't working properly!");
        }

        [TestMethod]
        public void GetValueOrDefaultInvalidKeyAndDefault()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            dict.Add(1, 1);
            dict.Add(2, 2);
            dict.Add(3, 3);

            Assert.AreEqual(-1, dict.GetValueOrDefault(4, -1), "IDictionarySharper ain't working properly!");
        }

        [TestMethod]
        public void SafeAddWithDupKeyValues()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            dict.SafeAdd(1, 1);
            dict.SafeAdd(2, 2);
            dict.SafeAdd(2, 2);

            Assert.AreEqual(2, dict.Count, "IDictionarySharper.SafeAdd ain't working properly!");
        }

        [TestMethod]
        public void SafeAddWithNonDupKeyValues()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            dict.SafeAdd(1, 1);
            dict.SafeAdd(2, 2);
            dict.SafeAdd(3, 3);

            Assert.AreEqual(3, dict.Count, "IDictionarySharper.SafeAdd ain't working properly!");
        }

        [TestMethod]
        public void SafeAddWithNullDict()
        {
            try
            {
                Dictionary<int, int> dict = null;

                dict.SafeAdd(1, 1);

                Assert.Fail("IDictionarySharper.SafeAdd ain't working properly!");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(ArgumentNullException));
            }
        }

        [TestMethod]
        public void SafeAddWithSameKeysDiferentValue()
        {
            try
            {
                Dictionary<int, int> dict = new Dictionary<int, int>(); ;

                dict.SafeAdd(1, 1);
                dict.SafeAdd(1, 2);

                Assert.Fail("IDictionarySharper.SafeAdd ain't working properly!");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(ArgumentException),
                    "IDictionarySharper.SafeAdd ain't working properly!");
                Assert.AreEqual(ex.Message, "Another value already exists for specified key",
                    "IDictionarySharper.SafeAdd ain't working properly!");
            }
        }
    }
}
