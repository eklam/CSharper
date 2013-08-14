using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharper;

namespace CSharper.Tests.Type
{
    [TestClass]
    public class TypeTest
    {
        [TestMethod]
        public void NamespaceTypesWithOriginalTypeOnly()
        {
            var types = typeof(CSharper.Teste.Test.Namespace1.Type1).NamespaceTypes();

            Assert.AreEqual(types.Count(), 1, "TypeSharper.NamespaceTypes aint working properly!");
        }

        [TestMethod]
        public void NamespaceTypesWithOriginal2TypesMore()
        {
            var types = typeof(CSharper.Teste.Test.Namespace2.Type1).NamespaceTypes();

            Assert.AreEqual(types.Count(), 3, "TypeSharper.NamespaceTypes aint working properly!");
        }
    }
}

namespace CSharper.Teste.Test.Namespace1
{
    public class Type1 { }
}

namespace CSharper.Teste.Test.Namespace2
{
    public class Type1 { }
    public class Type2 { }
    public class Type3 { }
}
