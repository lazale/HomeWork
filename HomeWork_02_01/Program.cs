using System;

namespace HomeWork_02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Пушкин Александр Сергеевич";
            byte age = 37; //чаще используется int в возрасте?) 
            string email = "sanya_pushka@skillbox.ru";
            double pointsProg = 12.22;
            double pointsMaths = 31.45;
            double pointsPhys = 28.80;

            //Console.WriteLine("Ф.И.О.: {0};\nВозраст: {1};\nE-mail: {2};\nБаллы по программированию: {3};\nБаллы по математике: {4};\nБаллы по физике: {5};",
            //    fullName,
            //    age,
            //    email,
            //    pointsProg,
            //    pointsMaths,
            //    pointsPhys); //первый вариант

            Console.WriteLine($"Ф.И.О.: {fullName,45};\nВозраст: {age,20};\nE-mail: {email,43};\nБаллы по программированию: {pointsProg,1};\nБаллы по математике: {pointsMaths,11};\nБаллы по физике: {pointsPhys,14};");
            //второй вариант
        }
    }
}
