using System;

namespace HomeWork_03_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            int i = 2;
            bool numberPrime = true;


            while (i < number)
            {
                if (number % i == 0)
                {
                    numberPrime = true;
                    break;
                }
                else
                    numberPrime = false;
                i++;
            }

            if (numberPrime == false)
            {
                Console.WriteLine("Это простое число");
            }
            else
            {
                Console.WriteLine("Это составное число");
            }
        }
    }
}
