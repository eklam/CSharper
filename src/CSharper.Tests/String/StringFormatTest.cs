using System.Globalization;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharper.Tests
{
    [TestClass]
    public class StringFormatTest
    {
        [TestMethod]
        public void FormatWithStringOneArgument()
        {
            string s = "{0} ought to be enough for everybody.";
            string param0 = "64K";

            string expected = "64K ought to be enough for everybody.";

            Assert.AreEqual(expected, s.F(param0),
                "1-argument string.FormatWith is not formatting string properly.");
        }

        [TestMethod]
        public void FormatWithStringOneNullArgument()
        {
            string s = "{0} ought to be enough for everybody.";
            string param0 = null;

            string expected = " ought to be enough for everybody.";

            Assert.AreEqual(expected, s.F(param0),
                "1-argument string.FormatWith is not formatting string properly.");
        }

        [TestMethod]
        public void FormatWithStringTwoArguments()
        {
            string s = "{0} ought to be enough for {1}.";
            string param0 = "64K";
            string param1 = "everybody";

            string expected = "64K ought to be enough for everybody.";

            Assert.AreEqual(expected, s.F(param0, param1),
                "2-arguments string.FormatWith is not formatting string properly.");
        }

        [TestMethod]
        public void FormatWithStringTwoNullArguments()
        {
            string s = "{0} ought to be enough for {1}.";
            string param0 = null;
            string param1 = null;

            string expected = " ought to be enough for .";

            Assert.AreEqual(expected, s.F(param0, param1),
                "2-arguments string.FormatWith is not formatting string properly.");
        }

        [TestMethod]
        public void FormatWithStringThreeArguments()
        {
            string s = "{0} ought to be {1} for {2}.";
            string param0 = "64K";
            string param1 = "enough";
            string param2 = "everybody";

            string expected = "64K ought to be enough for everybody.";

            Assert.AreEqual(expected, s.F(param0, param1, param2),
                "3-arguments string.FormatWith is not formatting string properly.");
        }

        [TestMethod]
        public void FormatWithStringThreeNullArguments()
        {
            string s = "{0} ought to be {1} for {2}.";
            string param0 = null;
            string param1 = null;
            string param2 = null;

            string expected = " ought to be  for .";

            Assert.AreEqual(expected, s.F(param0, param1, param2),
                "3-arguments string.FormatWith is not formatting string properly.");
        }

        [TestMethod]
        public void FormatWithStringMultipleArguments()
        {
            string s = "{0} {1} to be {2} for {3}.";
            string param0 = "64K";
            string param1 = "ought";
            string param2 = "enough";
            string param3 = "everybody";

            string expected = "64K ought to be enough for everybody.";

            Assert.AreEqual(expected, s.F(param0, param1, param2, param3),
                "4-arguments string.FormatWith is not formatting string properly.");
        }

        [TestMethod]
        public void FormatWithStringMultipleNullArguments()
        {
            string s = "{0} {1} to be {2} for {3}.";
            string param0 = null;
            string param1 = null;
            string param2 = null;
            string param3 = null;

            string expected = "  to be  for .";

            Assert.AreEqual(expected, s.F(param0, param1, param2, param3),
                "4-arguments string.FormatWith is not formatting string properly.");
        }

        [TestMethod]
        public void FormatWithStringObeyThreadCulture()
        {
            string s = "{0} is used as the decimal separator in French, as in {1:#,##0.00}";
            string param0 = "Comma";
            float param1 = 123.45F;

            var expected = "Comma is used as the decimal separator in French, as in 123,45";

            // save current culture for later restore and switch to fr-FR culture
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");

            Assert.AreEqual(expected, s.F(Thread.CurrentThread.CurrentCulture, param0, param1),
                "2-arguments string.FormatWith does not obey the current thread culture.");

            // restore culture
            Thread.CurrentThread.CurrentCulture = currentCulture;
        }

        [TestMethod]
        public void TruncateWithLongString()
        {
            string str = "123456789x";

            Assert.AreEqual("1234---", str.Truncate(7, "---"));
        }

        [TestMethod]
        public void TruncateWithShortString()
        {
            string str = "1234567";

            Assert.AreEqual("1234567", str.Truncate(7, "---"));
        }

        [TestMethod]
        public void TruncateWithEmptyString()
        {
            string str = "";

            Assert.AreEqual("", str.Truncate(7, "---"));
        }

        [TestMethod]
        public void TruncateWithNullString()
        {
            string str = null;

            Assert.AreEqual(null, str.Truncate(7, "---"));
        }

    
    }
}