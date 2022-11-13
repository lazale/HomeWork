using System;
using System.Threading;


namespace work2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2020, 04, 24, 17, 19, 22);
            Console.WriteLine(date);

            Console.WriteLine(date.Year); //вывод года на экран
            Console.WriteLine(date.Month); //вывод месяца на экран
            Console.WriteLine(date.Day); //вывод числа на экран
            Console.WriteLine(date.Hour); //вывод часов на экран
            Console.WriteLine(date.Minute); //вывод минут на экран
            
            Console.WriteLine(date.ToShortTimeString()); //вывод времени на экран
            Console.WriteLine(date.ToShortDateString()); //вывод даты на экран

            DateTime newDate = date.AddMinutes(15); //добавить 15 минут
            Console.WriteLine(newDate); 

            Console.WriteLine(DateTime.Now); //текущая дата и время компьютера

            TimeSpan span = newDate - date;
            Console.WriteLine(span);
            Console.WriteLine(span.TotalMinutes);
            

            date = DateTime.Now;

            double sum = 0;

            for (int i = 0; i <= 1000000; i++)
            {
                sum += i;
            
            }

            Console.WriteLine(sum); 
            TimeSpan timespan = DateTime.Now - date;
            Console.WriteLine(timespan.TotalMilliseconds);
        }


    }
    
}


