using System;
using Microsoft.EntityFrameworkCore;

namespace Hylian.RIS.API.Repository
{
    internal static class DbFunctions
    {
        [DbFunction("JSON_VALUE", "", IsBuiltIn = true)]
        public static string JsonValue(string source, string path) => throw new NotSupportedException();
        [DbFunction("JSON_Query", "", IsBuiltIn = true)]
        public static string JsonQuery(string source, string path) => throw new NotSupportedException();
        [DbFunction("IsSimilar", "dbo", IsBuiltIn = false)]
        public static bool IsSimilar(string left, string right) => throw new NotSupportedException();
    }
}
