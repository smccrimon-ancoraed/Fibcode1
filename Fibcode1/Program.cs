using System;

namespace Fibcode1
{
    class Program
    {

        /*
         * Function:  int Fib(n)
         * Return nth terms of the Fibonacci series using a Looping method / iterative method
         * 
         */

        public int Fib(int num)
        {
            int i;
            int n1 = 0;  // Initial value
            int n2 = 1;  // Initial next value
            int n3 = 0;  // next sum 

            for (i = 1; i < num; i++)
            {
                Console.Write(n1 + " " + n2 + " ");
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine();
            return n3;

        }



        static void Main(string[] args)
        {
            Program mynum = new Program();


            Console.WriteLine("Fibonacci numbers\n");
            Console.WriteLine("The number of rabbits paris at the end of n months");
            Console.WriteLine("\nIn this example we will use n=14");
            Console.WriteLine("Fib(14) = "+mynum.Fib(14));
            Console.ReadKey();
        }
    }
}
