using System;

namespace Deretan_Bilangan_Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, ctr, stno, enno;

            Console.Write("\n\n");
            Console.Write("Temukan bilangan prima dalam rentang:\n");
            Console.Write("\n\n");

            Console.Write("Masukkan batas rentang nomor awal: ");
            stno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan batas rentang nomor akhir : ");
            enno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bilangan prima antara {0} dan {1} adalah : \n", stno, enno);

            for (num = stno; num <= enno; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }
    }
}
