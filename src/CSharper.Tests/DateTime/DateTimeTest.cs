using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharper;

namespace CSharper.Tests
{
    [TestClass]
    public class DateTimeTest
    {
        [TestMethod]
        public void IsWeekendWithWeekendDate()
        {
            var date = new DateTime(2013, 07, 20);

            Assert.IsTrue(date.IsWeekend());
        }

        [TestMethod]
        public void IsWeekendWithWeekendDate2()
        {
            var date = new DateTime(1990, 07, 15);

            Assert.IsTrue(date.IsWeekend());
        }

        [TestMethod]
        public void IsWeekendWithWeekendDate3()
        {
            var date = new DateTime(2030, 06, 16);

            Assert.IsTrue(date.IsWeekend());
        }

        [TestMethod]
        public void IsWeekendWithNonWeekendDate()
        {
            var date = new DateTime(2013, 07, 19);

            Assert.IsFalse(date.IsWeekend());
        }

        [TestMethod]
        public void IsWeekendWithNonWeekendDate2()
        {
            var date = new DateTime(1990, 07, 12);

            Assert.IsFalse(date.IsWeekend());
        }

        [TestMethod]
        public void IsWeekendWithNonWeekendDate3()
        {
            var date = new DateTime(2030, 06, 13);

            Assert.IsFalse(date.IsWeekend());
        }
    }
}
