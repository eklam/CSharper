using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharper
{
    public static class TypeSharper
    {
        public static IEnumerable<Type> NamespaceTypes(this Type oType)
        {
            return oType.Assembly.GetTypes().Where(t => t.Namespace == oType.Namespace);
        }
    }
}