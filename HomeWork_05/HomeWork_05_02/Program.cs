using System;

namespace HomeWork_05_02
{
    internal class Program
    {
        static string[] Split(string inputPhrase)
        {
            string[] arrayUserText = inputPhrase.Split(' ');
            return arrayUserText;
        }
        static void ReversWords(string inputPhrase)
        {
            string[] array = Split(inputPhrase);
            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинное предложение разделив слова - пробелом: ");
            string inputPhrase = Console.ReadLine();

            ReversWords(inputPhrase);
        }

    }
}
