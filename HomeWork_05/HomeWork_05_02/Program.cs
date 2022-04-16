using System;

namespace HomeWork_05_02
{
    internal class Program
    {
        /// <summary>
        /// Полученный текст разделяется на слова
        /// </summary>
        /// <returns></returns>
        static String[] TextUserArray()
        {
            Console.WriteLine("Введите длинное предложение разделив слова - пробелом: ");
            string userText = Console.ReadLine();
            string[] arrayUserText = userText.Split(' ');
            return arrayUserText;
        }
        /// <summary>
        /// Инвертирование слов и их вывод
        /// </summary>
        /// <param name="array"></param>
        static void TextReverse(Array array)
        {
            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            TextReverse(TextUserArray());
        }
    }
}
