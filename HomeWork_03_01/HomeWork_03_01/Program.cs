using System;

namespace HomeWork_03_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbUser;

            Console.WriteLine("Введите целое число: ");
            numbUser = int.Parse(Console.ReadLine());

            if (numbUser % 2 == 0)
            {
                Console.WriteLine("Вы ввели чётное число");
            }
            else
            {
                Console.WriteLine("Вы ввели нечётное число");
            }
        }
    }
}
