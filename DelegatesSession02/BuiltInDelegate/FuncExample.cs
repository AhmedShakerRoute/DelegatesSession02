using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesSession02.BuiltInDelegate
{
    internal class FuncExample
    {   



        public static int GetRandomNumber()=> new Random().Next(1 , 100);

        public static int Square(int n)
        {

            return n * n;
        }

        public static int Add(int x , int y)
        {
            return x+ y;
        }
        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
