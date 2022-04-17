using System;

namespace HomeWork_05_01
{
    internal class Program
    {
        static String[] Split(string userText1)
        {
            return userText1.Split(' ');
        }
        static void WordsPrint(string userText2)
        {
            foreach (String s in Split(userText2))
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинное предложение разделив слова - пробелом: ");
            string userText = Console.ReadLine();
            Split(userText);
            WordsPrint(userText);
        }

    }
}
