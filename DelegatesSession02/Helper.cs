using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesSession02
{
    internal static class Helper
    {
        public static void PrintList<T>(string listName, List<T> list)
        {
            Console.WriteLine($"{listName}: [{string.Join(", ", list)}]\n");

        }
    }
}
