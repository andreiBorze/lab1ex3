using System;

namespace lab1ex3
{
    /*Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va afisa ultima cifra a unui numar intreg citit de la tastaura. \n");

            Console.WriteLine("Introduceti numarul:");
            var nr = int.Parse(Console.ReadLine());

            Console.WriteLine("ultima cifra este: " + nr%10);
        }
    }
}
