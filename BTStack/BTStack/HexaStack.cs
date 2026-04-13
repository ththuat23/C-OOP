using System;
using System.Collections.Generic;
using System.Text;

namespace BTStack
{
    public class HexaStack : Stack
    {
        public HexaStack(int max) : base(max) { }

        private char ToHex(int x)
        {
            if (x < 10) return (char)(x + '0');
            return (char)(x - 10 + 'A');
        }

        public override void Print()
        {
            for (int i = Top; i >= 0; i--)
            {
                Console.Write(ToHex(Data[i]));
            }
            Console.WriteLine();
        }
    }
}
