using System;

namespace T2
{
    internal class T2
    {
        public delegate int RDel();

        public static int Average(RDel[] array)
        {
            int x = 0;
            foreach (RDel rDel in array)
            {
                x += rDel();
            }
            x /= array.Length;
            Console.WriteLine("result: " + x);
            return x;
        }

        public static int RandEl()
        {
            Random rand = new Random();
            int e = rand.Next(1, 100);
            Console.WriteLine(e);
            return e;
        }

        static void Main(string[] args)
        {
            RDel del = RandEl;
            RDel del2 = RandEl;
            RDel del3 = RandEl;
            RDel del4 = RandEl;
            RDel del5 = RandEl;

            RDel[] dels = new RDel[5];
            dels[0] = del;
            dels[1] = del2;
            dels[2] = del3;
            dels[3] = del4;
            dels[4] = del5;
            Average(dels);
        }
    }
}