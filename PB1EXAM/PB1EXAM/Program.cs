using System;

namespace PB1EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 

            float a, b;

            a = float.Parse(Console.ReadLine());

            b = float.Parse(Console.ReadLine());

            if (a == 0)
            {

                Console.WriteLine("Nu exista solutie");
            }
            else Console.WriteLine(-b / a);
        }
    }
}
