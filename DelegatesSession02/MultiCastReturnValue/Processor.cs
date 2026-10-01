using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesSession02.MultiCastReturnValue
{
    public delegate int ProcessDelegate(int n);
    internal class Processor
    {
        public static int AddTen(int Value) => Value + 10;
        public static int MultiPlyByTwo(int Value) => Value *2;
    }
}
