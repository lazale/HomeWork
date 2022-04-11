using System;

namespace HomeWork_04_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное число: ");
            int max = int.Parse(Console.ReadLine());
            Random r = new Random();

            int numb = r.Next(0, max + 1);

            Console.WriteLine("Угадай мое загаданное число :)");

            while (true)
            {
                string userValue = Console.ReadLine();

                if (userValue == "")
                {
                    Console.WriteLine($"Проиграли.\nБыло загадано число: {numb}");
                    break;
                }

                else
                {
                    int numbUser = int.Parse(userValue);
                    if (numb < numbUser)
                    {
                        Console.WriteLine("Ваше число больше загаданного");
                    }
                    else if (numb > numbUser)
                    {
                        Console.WriteLine("Ваше число меньше загаданного");
                    }
                    else
                    {
                        Console.WriteLine("Угадали!");
                        break;
                    }
                }
            }

        }
    }
}
