using System;

namespace PB9EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.Afisati toti divizorii numarului n. 

            int n;

            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Divizorii lui " + n + " sunt: ");

            for (int i=1;i<=n;i++)
            {
                if (n % i == 0) Console.Write(i + " ");
            }
        }
    }
}
