using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharper.Tests.Exception
{
    public class DummyClass
    {
        public DummyClass()
        {

        }

        public string Name
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Dummy class for testing purposes with circular references thrown into the mix.
    /// </summary>
    public class DummyCircularClass : DummyClass
    {
        public DummyCircularClass another;

        public DummyCircularClass()
            : base()
        {
            // create 2 more childrens to link in a circle
            var d1 = new DummyCircularClass(true);
            var d2 = new DummyCircularClass(true);

            // create circular references
            d1.another = this;
            this.another = d2;
            d2.another = this;
        }

        private DummyCircularClass(bool placeholder)
            : base()
        {
            /* does nothing */
        }
    }

    /// <summary>
    /// Tests System.Object extension methods.
    /// </summary>
    [TestClass]
    public class ExceptionTest
    {
        /// <summary>
        /// Provide information about current testing context.
        /// Required by MSTests.
        /// </summary>
        public TestContext TestContext { get; set; }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ThrowIfArgumentIsNullOnDummyClass()
        {
            DummyClass sut = null;

            sut.ThrowIfArgIsNull("DummyClass");
        }

        [TestMethod]
        public void ThrowIfArgumentIsNotNullOnDummyClass()
        {
            DummyClass sut = new DummyClass();

            sut.ThrowIfArgIsNull("DummyClass");
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ThrowIfArgumentIsNullOnString()
        {
            string sut = null;

            sut.ThrowIfArgIsNull("string");
        }

        [TestMethod]
        public void ThrowIfArgumentIsNotNullOnString()
        {
            string sut = "not null";

            sut.ThrowIfArgIsNull("string");
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ThrowIfArgumentIsNullOnDummyClassMessage()
        {
            DummyClass sut = null;

            sut.ThrowIfArgIsNull("DummyClass", "string mustn't be null.");
        }

        [TestMethod]
        public void ThrowIfArgumentIsNotNullOnDummyClassMessage()
        {
            DummyClass sut = new DummyClass();

            sut.ThrowIfArgIsNull("DummyClass", "string mustn't be null.");
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ThrowIfArgumentIsNullOnStringMessage()
        {
            string sut = null;

            sut.ThrowIfArgIsNull("string", "string mustn't be null.");
        }

        [TestMethod]
        public void ThrowIfArgumentIsNotNullOnStringMessage()
        {
            string sut = "not null";

            sut.ThrowIfArgIsNull("string", "string mustn't be null.");
        }
    }
}
