using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharper.Tests.String
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void IsNullWithNullString()
        {
            string nullString = null;

            bool result = nullString.IsNull();

            Assert.AreEqual(result, true, "StringSharper.IsNull ain't working properly!");
        }

        [TestMethod]
        public void IsNullWithEmptyString()
        {
            string emptyString = "";

            bool result = emptyString.IsNull();

            Assert.AreEqual(result, false, "StringSharper.IsNull ain't working properly!");
        }

        [TestMethod]
        public void IsNullWithNonEmptyString()
        {
            string nonEmptyString = "Hi, here's my value";

            bool result = nonEmptyString.IsNull();

            Assert.AreEqual(result, false, "StringSharper.IsNull ain't working properly!");
        }

        [TestMethod]
        public void IsNullOrEmptyWithNullString()
        {
            string nullString = null;

            bool result = nullString.IsNullOrEmpty();

            Assert.AreEqual(result, true, "StringSharper.IsNullOrEmpty ain't working properly!");
        }

        [TestMethod]
        public void IsNullOrEmptyWithEmptyString()
        {
            string emptyString = "";

            bool result = emptyString.IsNullOrEmpty();

            Assert.AreEqual(result, true, "StringSharper.IsNullOrEmpty ain't working properly!");
        }

        [TestMethod]
        public void IsNullOrEmptylWithNonEmptyString()
        {
            string nonEmptyString = "Hi, here's my value";

            bool result = nonEmptyString.IsNullOrEmpty();

            Assert.AreEqual(result, false, "StringSharper.IsNullOrEmpty ain't working properly!");
        }





        [TestMethod]
        public void IsNullOrWhiteSpaceWithNullString()
        {
            string nullString = null;

            bool result = nullString.IsNullOrWhiteSpace();

            Assert.AreEqual(result, true, "StringSharper.IsNullOrWhiteSpace ain't working properly!");
        }

        [TestMethod]
        public void IsNullOrWhiteSpaceWithEmptyString()
        {
            string emptyString = "";

            bool result = emptyString.IsNullOrWhiteSpace();

            Assert.AreEqual(result, true, "StringSharper.IsNullOrWhiteSpace ain't working properly!");
        }

        [TestMethod]
        public void IsNullOrWhiteSpacelWithNonEmptyString()
        {
            string nonEmptyString = "Hi, here's my value";

            bool result = nonEmptyString.IsNullOrWhiteSpace();

            Assert.AreEqual(result, false, "StringSharper.IsNullOrWhiteSpace ain't working properly!");
        }

        [TestMethod]
        public void IsNullOrWhiteSpacelWithWhitespacedString()
        {
            string whitespacedString = "          ";

            bool result = whitespacedString.IsNullOrWhiteSpace();

            Assert.AreEqual(result, true, "StringSharper.IsNullOrWhiteSpace ain't working properly!");
        }
    }
}