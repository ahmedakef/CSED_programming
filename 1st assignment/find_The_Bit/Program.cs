using System;

namespace fintTheBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a position : ");
            int p = Convert.ToInt32(Console.ReadLine());
            
            p--;
            n >>= p;
            n &= 1;
            Console.WriteLine(n);

        }
    }
}
