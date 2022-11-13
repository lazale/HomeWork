using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static String Split(string inputPhrase)
        {
            string[] arrayUserText = inputPhrase.Split(' ');
            return arrayUserText;
        }
        static string ReversWords(string inputPhrase)
        {
            string[] array = Split(inputPhrase);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинное предложение разделив слова - пробелом: ");
            string userText = Console.ReadLine();

        }
    }
}
