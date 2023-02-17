using System;

namespace T3
{
    internal class T3
    {
        public delegate int Delegation(int a, int b, int c);
        static void Main(string[] args)
        {
            int ag = 3;
            int bg = 6;
            int cg = 9;
            Delegation averege = (a, b, c) => (a + b + c) / 3;
            Console.WriteLine(averege(ag, bg, cg));
        }
    }
}