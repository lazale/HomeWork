using System;

namespace HomeWork_04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int sum = 0;

            int[,] arr2d = new int[row, col];

            Random rand = new Random();


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr2d[i, j] = rand.Next(1, 10);
                    Console.Write($"{arr2d[i, j]} ");
                    sum += arr2d[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Cумма всех элементов матрицы: {sum};");
        }
    
    }
}
