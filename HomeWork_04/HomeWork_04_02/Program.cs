using System;

namespace HomeWork_04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Введите длину последовательности: ");
                int dlina = int.Parse(Console.ReadLine());
                int[] array = new int[dlina];
                int count = 1;


                Console.WriteLine("Введите целые числа поочередно.");

                for (int i = 0; i < array.Length; i++)
                {   
                    Console.WriteLine($"Введите число {count++}:");
                    array[i] = int.Parse(Console.ReadLine());
                }

                int min = int.MaxValue;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < min)
                    { min = array[i]; }

                }

                Console.WriteLine($"Вы ввели самое наименьшее число: {min};");
            }
        }
    }
}
