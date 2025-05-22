using System;

namespace A06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdueix el valor màxim: ");
            int maxim = int.Parse(Console.ReadLine());
            int valor = 7;
            int count = Metodes.comptadorMultiples(valor, maxim);

            // Llista de múltiples de 7 menors que maxim
            Console.WriteLine($"Múltiples de {valor} menors que {maxim}:");
            for (int i = valor; i < maxim; i += valor)
            {
                Console.Write(i);
                if (i + valor < maxim)
                    Console.Write(", ");
            }
            Console.WriteLine();
            Console.WriteLine($"Total: {count}");
        }
    }

    class Metodes
    {
        // Modifiquem el mètode per rebre també el màxim
        public static int comptadorMultiples(int valor, int maxim)
        {
            int countMultiples = 0;
            for (int i = valor; i < maxim; i += valor)
            {
                countMultiples += 1;
            }
            return countMultiples;
        }
    }
}
