using System;

namespace PB12EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            //12.Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 

            int a, b, n, nr = 0;

            a = int.Parse(Console.ReadLine());

            b = int.Parse(Console.ReadLine());

            n = int.Parse(Console.ReadLine());

            for (int i=a;i<=b;i++)
            {
                if (i % n == 0) nr++;
            }
            Console.WriteLine("Exista " + nr + " numere divizibile cu " + n + " in intervalul [" + a + "," + b + "]");
        }
    }
}
