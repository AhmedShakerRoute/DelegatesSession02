using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesSession02.DelegateAsParameter
{
    public delegate bool FilterDelegate(int number);
    public delegate int TransformDelegate(int number);
    internal class NumberProcessor
    {
        //FilterDelegate filter = 
        public static List<int> Filter (List<int> list , FilterDelegate filter)//Reference To Method (IsEven / IsOdd)
        {
            List<int> result = new List<int>();
            foreach (int i in list)
            {
                if(filter(i))//True / False
                {
                    result.Add(i);
                }
            }
            return result;
        }

        // 1 2 3 4 5 6 
       // 1 *2 = 2
        public static List<int> Transform (List<int> list , TransformDelegate Transform)//Reference To Method (IsEven / IsOdd)
        {
            List<int> result = new List<int>();
            foreach (int i in list)
            {
                    result.Add(Transform(i));
            }
            return result;
        }
        public static bool IsEven(int i) => i % 2 == 0;
        public static bool IsOdd(int i) => i % 2 != 0;
        public static bool IsPositive(int i) => i > 0;
        public static bool IsGreaterThan10(int i) => i > 10;

        public static int Double(int i) => i * 2;
        public static int Square(int i) => i * i;

    }
}
