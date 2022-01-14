using System;

namespace PB16EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            //16.Se dau 5 numere. Sa se afiseze in ordine crescatoare.

            int[] v = new int[5];

            for (int i=0;i<5;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            //SORTARE
            for (int i=0;i<4;i++)
            {
                for (int j=i+1;j<5;j++)
                {
                    if (v[i]>v[j])
                    {
                        int aux;
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
            //Afisarea celor 5 numere dupa sortare.
            for (int i=0;i<5;i++)
            {
                Console.Write(v[i] + " ");
            }
        }
    }
}
