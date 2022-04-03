using System;

namespace HomeWork_03_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int countCards;
            int sumCards = 0;
            string cards;



            Console.WriteLine("Сыграем? Сколько у Вас карт на руках?");
            countCards = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countCards; i++)
            {
                Console.WriteLine($"Введите {i}-ю карту");
                cards = Console.ReadLine();
                switch (cards)
                {
                    case "2": sumCards += 2; break;
                    case "3": sumCards += 3; break;
                    case "4": sumCards += 4; break;
                    case "5": sumCards += 5; break;
                    case "6": sumCards += 6; break;
                    case "7": sumCards += 7; break;
                    case "8": sumCards += 8; break;
                    case "9": sumCards += 9; break;
                    case "10": sumCards += 10; break;
                    case "J": sumCards += 10; break;
                    case "Q": sumCards += 10; break;
                    case "K": sumCards += 10; break;
                    case "T": sumCards += 10; break;
                    default: Console.WriteLine("Такой карты нет, попробуй еще раз"); i--; continue;
                }

            }
            Console.WriteLine(); // для пустой строки
            if (sumCards < 21) Console.WriteLine($"Недобор! У Вас {sumCards}!");
            else if (sumCards > 21) Console.WriteLine($"Перебор! У Вас {sumCards}!");
            else Console.WriteLine("Победа, ровно 21 очко!");
        }
    }
}
