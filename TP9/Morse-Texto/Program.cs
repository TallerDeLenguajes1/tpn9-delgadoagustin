using System;
using System.IO;
using Helpers;

namespace Morse_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Helpers.ConversorDeMorse.MorseATexto(input));
        }
    }
}
