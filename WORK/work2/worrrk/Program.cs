using System;
using System.IO;

namespace worrrk
{
    internal class Program
    {
        static void GetDir(string path, string trim = "")
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path); //получаем инф о текущем каталоге

            foreach (var item in directoryInfo.GetDirectories()) //перебираем все подкаталоги текущего каталога
            {
                Console.WriteLine($"{trim}{item.Name}");  //выводим информацию о нем
                GetDir(item.FullName, trim + "   "); //просмотр вложенного каталога
            }

            foreach (var item in directoryInfo.GetFiles())  //перебираем все файлы текущего каталога 
            {
                Console.WriteLine($"{trim}{item.Name}"); //выводим информацию о них
            }
        }
        static void Main(string[] args)
        {

           GetDir (@"C:\adb_run\");

        }
    }
}
