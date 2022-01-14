using System;

namespace PB4EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Detreminati daca un an y este an bisect. 
            int n;

            int bisect = 0;

            n = int.Parse(Console.ReadLine());

            if ((n % 4 == 0) && (n % 100 != 0)) bisect = 1;
            if (n % 400 == 0) bisect = 1;
            if (bisect == 1) Console.WriteLine("Anul este bisect");
            else Console.WriteLine("Anul nu este bisect");

        }
    }
}
