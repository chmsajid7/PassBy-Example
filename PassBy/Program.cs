using System;

namespace PassBy
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            PassByVal(a, b);
            Console.WriteLine("In Main method after PassByVal: a = " + a + ", b = " + b);

            PassByRef(ref a, ref b);
            Console.WriteLine("In Main method after PassByRef: a = " + a + ", b = " + b);
            Console.ReadKey();
        }
        private static void PassByVal(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("In method PassByVal: a = " + a + ", b = " + b);
        }
        private static void PassByRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("In method PassByRef: a = " + a + ", b = " + b);
        }
    }
}
