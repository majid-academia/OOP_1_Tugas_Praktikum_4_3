using System;

namespace Deretan_Bilangan_Fibonacci
{
    class Program
    {
        public static int FindFibonacci(int n)
        {
            int p = 0;
            int q = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = p;
                p = q;
                q = temp + q;
            }
            return p;
        }

        static void Main()
        {
            Console.WriteLine("\n\n Menemukkan bilangan Fibonacci dalam jumlah tertentu :");

            Console.Write(" Masukkan jumlah bilangan Fibonacci : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Bilangan Fibonacci sebanyak {0} adalah : ", n1);
            for (int i = 0; i < n1; i++)
            {
                Console.Write("{0} ", FindFibonacci(i));
            }
            Console.ReadKey();
        }
    }
}
