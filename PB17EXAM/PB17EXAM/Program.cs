using System;

namespace PB17EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            //17.Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 

            int a, b;

            a = int.Parse(Console.ReadLine());

            b = int.Parse(Console.ReadLine());

            while (a!=b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            Console.WriteLine("CMMDC este " + a);
        }
    }
}
