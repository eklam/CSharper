using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharper.Tests
{
    [TestClass]
    public class ObjectTest
    {
        [TestMethod]
        public void InWithContainedValue()
        {
            int reallyLongIntegerVariableName = 1;
            bool result = reallyLongIntegerVariableName.In(1, 6, 9, 11);

            Assert.AreEqual(result, true, "In ain't working properly");
        }

        [TestMethod]
        public void InWithUncontainedValue()
        {
            int reallyLongIntegerVariableName = 12;
            bool result = reallyLongIntegerVariableName.In(1, 6, 9, 11);

            Assert.AreEqual(result, false, "In ain't working properly");
        }
    }
}