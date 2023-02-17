using System;

namespace T1
{
    internal class T1
    {
        public delegate int Count(int x, int y);

        static void Main(string[] args)
        {
            int a = 64;
            int b = 2;
            Count add = (x, y) => x + y;
            Console.WriteLine(add(a, b));
            Count sub = (x, y) => x - y;
            Console.WriteLine(sub(a, b));
            Count mul = (x, y) => x * y;
            Console.WriteLine(mul(a, b));
            Count div = (x, y) =>
            {
                int result = 0;
                try
                {
                    result = x / y;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                return result;
            };
            Console.WriteLine(div(a, b));
        }
    }
}
