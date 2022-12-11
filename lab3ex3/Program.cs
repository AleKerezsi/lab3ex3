using System;

namespace lab3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 3 Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul */

            Console.WriteLine("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());

            bool patratPerfect = VerificaPatratPerfect(n);

            if (patratPerfect == true) Console.WriteLine("Numarul " + n + " este patrat perfect");
            else Console.WriteLine("Numarul " + n + " nu este patrat perfect");

        }

        public static bool VerificaPatratPerfect(int x) 
        {
            for (int i = 1; i <= x; i++) 
                if (x == i * i)
                    return true;
            return false;
        }
    }
}
