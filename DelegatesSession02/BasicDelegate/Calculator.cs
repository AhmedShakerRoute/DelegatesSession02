using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesSession02.BasicDelegate
{

    //Delegate 
    //Reference To Method

    public delegate int MathOperation(int a, int b);

    internal class Calculator
    {
        public static int Add(int a , int b) => a + b;
        public static int Subtract(int a , int b) => a - b;
    }
}
