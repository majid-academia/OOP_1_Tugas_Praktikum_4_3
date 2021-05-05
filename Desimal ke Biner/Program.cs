using System;

namespace Desimal_ke_Biner
{
    class Program
    {
        static void Main(string[] args)
        {
            string jawaban;
            string hasil;

            Console.Write("Masukkan angka : ");
            jawaban = Console.ReadLine();

            int num = Convert.ToInt32(jawaban);
            hasil = "";
            while (num > 1)
            {
                int remainder = num % 2;
                hasil = Convert.ToString(remainder) + hasil;
                num /= 2;
            }
            hasil = Convert.ToString(num) + hasil;
            Console.WriteLine("Binary: {0}", hasil);
        }
    }
}
