using System;
using System.Collections.Generic;
using System.Text;

namespace BTStack
{
    public class PrimeStack : Stack
    {
        public PrimeStack(int max) : base(max) { }

        public override void Print()
        {
            for (int i = Top; i >= 0; i--)
            {
                Console.Write(Data[i]);
                if (i > 0) Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
