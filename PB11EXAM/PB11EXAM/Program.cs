using System;

namespace PB11EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.Afisati in ordine inversa cifrele unui numar n. 

            int n, oglindit = 0;

            n = int.Parse(Console.ReadLine());

            while (n!=0)
            {
                oglindit = oglindit * 10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine(oglindit);
        }
    }
}
