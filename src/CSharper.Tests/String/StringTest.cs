using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharper.Tests
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

            bool result = nullString.IsEmpty();

            Assert.AreEqual(result, true, "StringSharper.IsNullOrEmpty ain't working properly!");
        }

        [TestMethod]
        public void IsNullOrEmptyWithEmptyString()
        {
            string emptyString = "";

            bool result = emptyString.IsEmpty();

            Assert.AreEqual(result, true, "StringSharper.IsNullOrEmpty ain't working properly!");
        }

        [TestMethod]
        public void IsNullOrEmptylWithNonEmptyString()
        {
            string nonEmptyString = "Hi, here's my value";

            bool result = nonEmptyString.IsEmpty();

            Assert.AreEqual(result, false, "StringSharper.IsNullOrEmpty ain't working properly!");
        }

        [TestMethod]
        public void IsNullOrWhiteSpaceWithNullString()
        {
            string nullString = null;

            bool result = nullString.IsWhiteSpaces();

            Assert.AreEqual(result, true, "StringSharper.IsNullOrWhiteSpace ain't working properly!");
        }

        [TestMethod]
        public void IsNullOrWhiteSpaceWithEmptyString()
        {
            string emptyString = "";

            bool result = emptyString.IsWhiteSpaces();

            Assert.AreEqual(result, true, "StringSharper.IsNullOrWhiteSpace ain't working properly!");
        }

        [TestMethod]
        public void IsNullOrWhiteSpacelWithNonEmptyString()
        {
            string nonEmptyString = "Hi, here's my value";

            bool result = nonEmptyString.IsWhiteSpaces();

            Assert.AreEqual(result, false, "StringSharper.IsNullOrWhiteSpace ain't working properly!");
        }

        [TestMethod]
        public void IsNullOrWhiteSpacelWithWhitespacedString()
        {
            string whitespacedString = "          ";

            bool result = whitespacedString.IsWhiteSpaces();

            Assert.AreEqual(result, true, "StringSharper.IsNullOrWhiteSpace ain't working properly!");
        }
    }
}