using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesSession02.BuiltInDelegate
{
    internal class PredicateExample
    {
        public static bool IsPositive(int n) => n > 0;

        public static bool IsNegative(int n) => n < 0;

        public static bool IsLong(string s) => s.Length > 5;
    }
}
