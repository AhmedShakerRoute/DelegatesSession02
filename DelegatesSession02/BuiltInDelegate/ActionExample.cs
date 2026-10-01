using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesSession02.BuiltInDelegate
{
    internal class ActionExample
    {
        public static void Greet()
        {
            Console.WriteLine("Hello");
        }
        public static void GreetPerson(string Name)
        {
            Console.WriteLine($"Hello {Name}");
        }
        
        public static void GreetPersonWithAge(string Name , int Age)
        {
            Console.WriteLine($"Hello {Name}! You are {Age} Years Old");
        }

    }
}
